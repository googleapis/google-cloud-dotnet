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
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.Tpu.V1
{
    /// <summary>Settings for <see cref="TpuClient"/> instances.</summary>
    public sealed partial class TpuSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TpuSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TpuSettings"/>.</returns>
        public static TpuSettings GetDefault() => new TpuSettings();

        /// <summary>Constructs a new <see cref="TpuSettings"/> object with default settings.</summary>
        public TpuSettings()
        {
        }

        private TpuSettings(TpuSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListNodesSettings = existing.ListNodesSettings;
            GetNodeSettings = existing.GetNodeSettings;
            CreateNodeSettings = existing.CreateNodeSettings;
            CreateNodeOperationsSettings = existing.CreateNodeOperationsSettings.Clone();
            DeleteNodeSettings = existing.DeleteNodeSettings;
            DeleteNodeOperationsSettings = existing.DeleteNodeOperationsSettings.Clone();
            ReimageNodeSettings = existing.ReimageNodeSettings;
            ReimageNodeOperationsSettings = existing.ReimageNodeOperationsSettings.Clone();
            StopNodeSettings = existing.StopNodeSettings;
            StopNodeOperationsSettings = existing.StopNodeOperationsSettings.Clone();
            StartNodeSettings = existing.StartNodeSettings;
            StartNodeOperationsSettings = existing.StartNodeOperationsSettings.Clone();
            ListTensorFlowVersionsSettings = existing.ListTensorFlowVersionsSettings;
            GetTensorFlowVersionSettings = existing.GetTensorFlowVersionSettings;
            ListAcceleratorTypesSettings = existing.ListAcceleratorTypesSettings;
            GetAcceleratorTypeSettings = existing.GetAcceleratorTypeSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TpuSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TpuClient.ListNodes</c> and
        /// <c>TpuClient.ListNodesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNodesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TpuClient.GetNode</c> and
        /// <c>TpuClient.GetNodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TpuClient.CreateNode</c>
        /// and <c>TpuClient.CreateNodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TpuClient.CreateNode</c> and <c>TpuClient.CreateNodeAsync</c>
        /// .
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
        public lro::OperationsSettings CreateNodeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TpuClient.DeleteNode</c>
        /// and <c>TpuClient.DeleteNodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TpuClient.DeleteNode</c> and <c>TpuClient.DeleteNodeAsync</c>
        /// .
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
        public lro::OperationsSettings DeleteNodeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TpuClient.ReimageNode</c>
        /// and <c>TpuClient.ReimageNodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReimageNodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TpuClient.ReimageNode</c> and <c>TpuClient.ReimageNodeAsync</c>
        /// .
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
        public lro::OperationsSettings ReimageNodeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TpuClient.StopNode</c> and
        /// <c>TpuClient.StopNodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopNodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TpuClient.StopNode</c> and <c>TpuClient.StopNodeAsync</c>.
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
        public lro::OperationsSettings StopNodeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TpuClient.StartNode</c> and
        /// <c>TpuClient.StartNodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartNodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TpuClient.StartNode</c> and <c>TpuClient.StartNodeAsync</c>.
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
        public lro::OperationsSettings StartNodeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TpuClient.ListTensorFlowVersions</c> and <c>TpuClient.ListTensorFlowVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTensorFlowVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TpuClient.GetTensorFlowVersion</c> and <c>TpuClient.GetTensorFlowVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTensorFlowVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TpuClient.ListAcceleratorTypes</c> and <c>TpuClient.ListAcceleratorTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAcceleratorTypesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TpuClient.GetAcceleratorType</c> and <c>TpuClient.GetAcceleratorTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAcceleratorTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TpuSettings"/> object.</returns>
        public TpuSettings Clone() => new TpuSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TpuClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TpuClientBuilder : gaxgrpc::ClientBuilderBase<TpuClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TpuSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TpuClientBuilder() : base(TpuClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TpuClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TpuClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TpuClient Build()
        {
            TpuClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TpuClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TpuClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TpuClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TpuClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TpuClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TpuClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TpuClient.ChannelPool;
    }

    /// <summary>Tpu client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages TPU nodes and other resources
    /// 
    /// TPU API v1
    /// </remarks>
    public abstract partial class TpuClient
    {
        /// <summary>
        /// The default endpoint for the Tpu service, which is a host of "tpu.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "tpu.googleapis.com:443";

        /// <summary>The default Tpu scopes.</summary>
        /// <remarks>
        /// The default Tpu scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Tpu.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TpuClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="TpuClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TpuClient"/>.</returns>
        public static stt::Task<TpuClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TpuClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TpuClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="TpuClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TpuClient"/>.</returns>
        public static TpuClient Create() => new TpuClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TpuClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TpuSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TpuClient"/>.</returns>
        internal static TpuClient Create(grpccore::CallInvoker callInvoker, TpuSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Tpu.TpuClient grpcClient = new Tpu.TpuClient(callInvoker);
            return new TpuClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Tpu client</summary>
        public virtual Tpu.TpuClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Node"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNodesResponse, Node> ListNodes(ListNodesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Node"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNodesResponse, Node> ListNodesAsync(ListNodesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="Node"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNodesResponse, Node> ListNodes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNodesRequest request = new ListNodesRequest
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
            return ListNodes(request, callSettings);
        }

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Node"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNodesResponse, Node> ListNodesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNodesRequest request = new ListNodesRequest
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
            return ListNodesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="Node"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNodesResponse, Node> ListNodes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNodesRequest request = new ListNodesRequest
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
            return ListNodes(request, callSettings);
        }

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Node"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNodesResponse, Node> ListNodesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNodesRequest request = new ListNodesRequest
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
            return ListNodesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Node GetNode(GetNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Node> GetNodeAsync(GetNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Node> GetNodeAsync(GetNodeRequest request, st::CancellationToken cancellationToken) =>
            GetNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Node GetNode(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNode(new GetNodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Node> GetNodeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeAsync(new GetNodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Node> GetNodeAsync(string name, st::CancellationToken cancellationToken) =>
            GetNodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Node GetNode(NodeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNode(new GetNodeRequest
            {
                NodeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Node> GetNodeAsync(NodeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeAsync(new GetNodeRequest
            {
                NodeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Node> GetNodeAsync(NodeName name, st::CancellationToken cancellationToken) =>
            GetNodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> CreateNode(CreateNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> CreateNodeAsync(CreateNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> CreateNodeAsync(CreateNodeRequest request, st::CancellationToken cancellationToken) =>
            CreateNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateNode</c>.</summary>
        public virtual lro::OperationsClient CreateNodeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Node, OperationMetadata> PollOnceCreateNode(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNodeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> PollOnceCreateNodeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNodeOperationsClient, callSettings);

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// </param>
        /// <param name="node">
        /// Required. The node.
        /// </param>
        /// <param name="nodeId">
        /// The unqualified resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> CreateNode(string parent, Node node, string nodeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNode(new CreateNodeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NodeId = nodeId ?? "",
                Node = gax::GaxPreconditions.CheckNotNull(node, nameof(node)),
            }, callSettings);

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// </param>
        /// <param name="node">
        /// Required. The node.
        /// </param>
        /// <param name="nodeId">
        /// The unqualified resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> CreateNodeAsync(string parent, Node node, string nodeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodeAsync(new CreateNodeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NodeId = nodeId ?? "",
                Node = gax::GaxPreconditions.CheckNotNull(node, nameof(node)),
            }, callSettings);

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// </param>
        /// <param name="node">
        /// Required. The node.
        /// </param>
        /// <param name="nodeId">
        /// The unqualified resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> CreateNodeAsync(string parent, Node node, string nodeId, st::CancellationToken cancellationToken) =>
            CreateNodeAsync(parent, node, nodeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// </param>
        /// <param name="node">
        /// Required. The node.
        /// </param>
        /// <param name="nodeId">
        /// The unqualified resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> CreateNode(gagr::LocationName parent, Node node, string nodeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNode(new CreateNodeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NodeId = nodeId ?? "",
                Node = gax::GaxPreconditions.CheckNotNull(node, nameof(node)),
            }, callSettings);

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// </param>
        /// <param name="node">
        /// Required. The node.
        /// </param>
        /// <param name="nodeId">
        /// The unqualified resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> CreateNodeAsync(gagr::LocationName parent, Node node, string nodeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodeAsync(new CreateNodeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NodeId = nodeId ?? "",
                Node = gax::GaxPreconditions.CheckNotNull(node, nameof(node)),
            }, callSettings);

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// </param>
        /// <param name="node">
        /// Required. The node.
        /// </param>
        /// <param name="nodeId">
        /// The unqualified resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> CreateNodeAsync(gagr::LocationName parent, Node node, string nodeId, st::CancellationToken cancellationToken) =>
            CreateNodeAsync(parent, node, nodeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> DeleteNode(DeleteNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> DeleteNodeAsync(DeleteNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> DeleteNodeAsync(DeleteNodeRequest request, st::CancellationToken cancellationToken) =>
            DeleteNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteNode</c>.</summary>
        public virtual lro::OperationsClient DeleteNodeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Node, OperationMetadata> PollOnceDeleteNode(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNodeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> PollOnceDeleteNodeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNodeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> DeleteNode(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNode(new DeleteNodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> DeleteNodeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNodeAsync(new DeleteNodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> DeleteNodeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> DeleteNode(NodeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNode(new DeleteNodeRequest
            {
                NodeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> DeleteNodeAsync(NodeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNodeAsync(new DeleteNodeRequest
            {
                NodeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> DeleteNodeAsync(NodeName name, st::CancellationToken cancellationToken) =>
            DeleteNodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reimages a node's OS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> ReimageNode(ReimageNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reimages a node's OS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> ReimageNodeAsync(ReimageNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reimages a node's OS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> ReimageNodeAsync(ReimageNodeRequest request, st::CancellationToken cancellationToken) =>
            ReimageNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReimageNode</c>.</summary>
        public virtual lro::OperationsClient ReimageNodeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReimageNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Node, OperationMetadata> PollOnceReimageNode(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReimageNodeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReimageNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> PollOnceReimageNodeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReimageNodeOperationsClient, callSettings);

        /// <summary>
        /// Stops a node, this operation is only available with single TPU nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> StopNode(StopNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a node, this operation is only available with single TPU nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> StopNodeAsync(StopNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a node, this operation is only available with single TPU nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> StopNodeAsync(StopNodeRequest request, st::CancellationToken cancellationToken) =>
            StopNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopNode</c>.</summary>
        public virtual lro::OperationsClient StopNodeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Node, OperationMetadata> PollOnceStopNode(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopNodeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> PollOnceStopNodeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopNodeOperationsClient, callSettings);

        /// <summary>
        /// Starts a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Node, OperationMetadata> StartNode(StartNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> StartNodeAsync(StartNodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> StartNodeAsync(StartNodeRequest request, st::CancellationToken cancellationToken) =>
            StartNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartNode</c>.</summary>
        public virtual lro::OperationsClient StartNodeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Node, OperationMetadata> PollOnceStartNode(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartNodeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartNode</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Node, OperationMetadata>> PollOnceStartNodeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Node, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartNodeOperationsClient, callSettings);

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersions(ListTensorFlowVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersionsAsync(ListTensorFlowVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorFlowVersionsRequest request = new ListTensorFlowVersionsRequest
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
            return ListTensorFlowVersions(request, callSettings);
        }

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorFlowVersionsRequest request = new ListTensorFlowVersionsRequest
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
            return ListTensorFlowVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersions(TensorFlowVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorFlowVersionsRequest request = new ListTensorFlowVersionsRequest
            {
                ParentAsTensorFlowVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorFlowVersions(request, callSettings);
        }

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersionsAsync(TensorFlowVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorFlowVersionsRequest request = new ListTensorFlowVersionsRequest
            {
                ParentAsTensorFlowVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorFlowVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorFlowVersion GetTensorFlowVersion(GetTensorFlowVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorFlowVersion> GetTensorFlowVersionAsync(GetTensorFlowVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorFlowVersion> GetTensorFlowVersionAsync(GetTensorFlowVersionRequest request, st::CancellationToken cancellationToken) =>
            GetTensorFlowVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorFlowVersion GetTensorFlowVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorFlowVersion(new GetTensorFlowVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorFlowVersion> GetTensorFlowVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorFlowVersionAsync(new GetTensorFlowVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorFlowVersion> GetTensorFlowVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetTensorFlowVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorFlowVersion GetTensorFlowVersion(TensorFlowVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorFlowVersion(new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorFlowVersion> GetTensorFlowVersionAsync(TensorFlowVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorFlowVersionAsync(new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorFlowVersion> GetTensorFlowVersionAsync(TensorFlowVersionName name, st::CancellationToken cancellationToken) =>
            GetTensorFlowVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypes(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypesAsync(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
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
            return ListAcceleratorTypes(request, callSettings);
        }

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
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
            return ListAcceleratorTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypes(AcceleratorTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                ParentAsAcceleratorTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAcceleratorTypes(request, callSettings);
        }

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypesAsync(AcceleratorTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                ParentAsAcceleratorTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAcceleratorTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AcceleratorType GetAcceleratorType(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAcceleratorTypeAsync(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAcceleratorTypeAsync(GetAcceleratorTypeRequest request, st::CancellationToken cancellationToken) =>
            GetAcceleratorTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AcceleratorType GetAcceleratorType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAcceleratorType(new GetAcceleratorTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAcceleratorTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAcceleratorTypeAsync(new GetAcceleratorTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAcceleratorTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetAcceleratorTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AcceleratorType GetAcceleratorType(AcceleratorTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAcceleratorType(new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAcceleratorTypeAsync(AcceleratorTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAcceleratorTypeAsync(new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAcceleratorTypeAsync(AcceleratorTypeName name, st::CancellationToken cancellationToken) =>
            GetAcceleratorTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Tpu client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages TPU nodes and other resources
    /// 
    /// TPU API v1
    /// </remarks>
    public sealed partial class TpuClientImpl : TpuClient
    {
        private readonly gaxgrpc::ApiCall<ListNodesRequest, ListNodesResponse> _callListNodes;

        private readonly gaxgrpc::ApiCall<GetNodeRequest, Node> _callGetNode;

        private readonly gaxgrpc::ApiCall<CreateNodeRequest, lro::Operation> _callCreateNode;

        private readonly gaxgrpc::ApiCall<DeleteNodeRequest, lro::Operation> _callDeleteNode;

        private readonly gaxgrpc::ApiCall<ReimageNodeRequest, lro::Operation> _callReimageNode;

        private readonly gaxgrpc::ApiCall<StopNodeRequest, lro::Operation> _callStopNode;

        private readonly gaxgrpc::ApiCall<StartNodeRequest, lro::Operation> _callStartNode;

        private readonly gaxgrpc::ApiCall<ListTensorFlowVersionsRequest, ListTensorFlowVersionsResponse> _callListTensorFlowVersions;

        private readonly gaxgrpc::ApiCall<GetTensorFlowVersionRequest, TensorFlowVersion> _callGetTensorFlowVersion;

        private readonly gaxgrpc::ApiCall<ListAcceleratorTypesRequest, ListAcceleratorTypesResponse> _callListAcceleratorTypes;

        private readonly gaxgrpc::ApiCall<GetAcceleratorTypeRequest, AcceleratorType> _callGetAcceleratorType;

        /// <summary>
        /// Constructs a client wrapper for the Tpu service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TpuSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TpuClientImpl(Tpu.TpuClient grpcClient, TpuSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TpuSettings effectiveSettings = settings ?? TpuSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateNodeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateNodeOperationsSettings, logger);
            DeleteNodeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteNodeOperationsSettings, logger);
            ReimageNodeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReimageNodeOperationsSettings, logger);
            StopNodeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopNodeOperationsSettings, logger);
            StartNodeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartNodeOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListNodes = clientHelper.BuildApiCall<ListNodesRequest, ListNodesResponse>("ListNodes", grpcClient.ListNodesAsync, grpcClient.ListNodes, effectiveSettings.ListNodesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNodes);
            Modify_ListNodesApiCall(ref _callListNodes);
            _callGetNode = clientHelper.BuildApiCall<GetNodeRequest, Node>("GetNode", grpcClient.GetNodeAsync, grpcClient.GetNode, effectiveSettings.GetNodeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNode);
            Modify_GetNodeApiCall(ref _callGetNode);
            _callCreateNode = clientHelper.BuildApiCall<CreateNodeRequest, lro::Operation>("CreateNode", grpcClient.CreateNodeAsync, grpcClient.CreateNode, effectiveSettings.CreateNodeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNode);
            Modify_CreateNodeApiCall(ref _callCreateNode);
            _callDeleteNode = clientHelper.BuildApiCall<DeleteNodeRequest, lro::Operation>("DeleteNode", grpcClient.DeleteNodeAsync, grpcClient.DeleteNode, effectiveSettings.DeleteNodeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNode);
            Modify_DeleteNodeApiCall(ref _callDeleteNode);
            _callReimageNode = clientHelper.BuildApiCall<ReimageNodeRequest, lro::Operation>("ReimageNode", grpcClient.ReimageNodeAsync, grpcClient.ReimageNode, effectiveSettings.ReimageNodeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReimageNode);
            Modify_ReimageNodeApiCall(ref _callReimageNode);
            _callStopNode = clientHelper.BuildApiCall<StopNodeRequest, lro::Operation>("StopNode", grpcClient.StopNodeAsync, grpcClient.StopNode, effectiveSettings.StopNodeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopNode);
            Modify_StopNodeApiCall(ref _callStopNode);
            _callStartNode = clientHelper.BuildApiCall<StartNodeRequest, lro::Operation>("StartNode", grpcClient.StartNodeAsync, grpcClient.StartNode, effectiveSettings.StartNodeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartNode);
            Modify_StartNodeApiCall(ref _callStartNode);
            _callListTensorFlowVersions = clientHelper.BuildApiCall<ListTensorFlowVersionsRequest, ListTensorFlowVersionsResponse>("ListTensorFlowVersions", grpcClient.ListTensorFlowVersionsAsync, grpcClient.ListTensorFlowVersions, effectiveSettings.ListTensorFlowVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTensorFlowVersions);
            Modify_ListTensorFlowVersionsApiCall(ref _callListTensorFlowVersions);
            _callGetTensorFlowVersion = clientHelper.BuildApiCall<GetTensorFlowVersionRequest, TensorFlowVersion>("GetTensorFlowVersion", grpcClient.GetTensorFlowVersionAsync, grpcClient.GetTensorFlowVersion, effectiveSettings.GetTensorFlowVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTensorFlowVersion);
            Modify_GetTensorFlowVersionApiCall(ref _callGetTensorFlowVersion);
            _callListAcceleratorTypes = clientHelper.BuildApiCall<ListAcceleratorTypesRequest, ListAcceleratorTypesResponse>("ListAcceleratorTypes", grpcClient.ListAcceleratorTypesAsync, grpcClient.ListAcceleratorTypes, effectiveSettings.ListAcceleratorTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAcceleratorTypes);
            Modify_ListAcceleratorTypesApiCall(ref _callListAcceleratorTypes);
            _callGetAcceleratorType = clientHelper.BuildApiCall<GetAcceleratorTypeRequest, AcceleratorType>("GetAcceleratorType", grpcClient.GetAcceleratorTypeAsync, grpcClient.GetAcceleratorType, effectiveSettings.GetAcceleratorTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAcceleratorType);
            Modify_GetAcceleratorTypeApiCall(ref _callGetAcceleratorType);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListNodesApiCall(ref gaxgrpc::ApiCall<ListNodesRequest, ListNodesResponse> call);

        partial void Modify_GetNodeApiCall(ref gaxgrpc::ApiCall<GetNodeRequest, Node> call);

        partial void Modify_CreateNodeApiCall(ref gaxgrpc::ApiCall<CreateNodeRequest, lro::Operation> call);

        partial void Modify_DeleteNodeApiCall(ref gaxgrpc::ApiCall<DeleteNodeRequest, lro::Operation> call);

        partial void Modify_ReimageNodeApiCall(ref gaxgrpc::ApiCall<ReimageNodeRequest, lro::Operation> call);

        partial void Modify_StopNodeApiCall(ref gaxgrpc::ApiCall<StopNodeRequest, lro::Operation> call);

        partial void Modify_StartNodeApiCall(ref gaxgrpc::ApiCall<StartNodeRequest, lro::Operation> call);

        partial void Modify_ListTensorFlowVersionsApiCall(ref gaxgrpc::ApiCall<ListTensorFlowVersionsRequest, ListTensorFlowVersionsResponse> call);

        partial void Modify_GetTensorFlowVersionApiCall(ref gaxgrpc::ApiCall<GetTensorFlowVersionRequest, TensorFlowVersion> call);

        partial void Modify_ListAcceleratorTypesApiCall(ref gaxgrpc::ApiCall<ListAcceleratorTypesRequest, ListAcceleratorTypesResponse> call);

        partial void Modify_GetAcceleratorTypeApiCall(ref gaxgrpc::ApiCall<GetAcceleratorTypeRequest, AcceleratorType> call);

        partial void OnConstruction(Tpu.TpuClient grpcClient, TpuSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Tpu client</summary>
        public override Tpu.TpuClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListNodesRequest(ref ListNodesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNodeRequest(ref GetNodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNodeRequest(ref CreateNodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNodeRequest(ref DeleteNodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReimageNodeRequest(ref ReimageNodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopNodeRequest(ref StopNodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartNodeRequest(ref StartNodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTensorFlowVersionsRequest(ref ListTensorFlowVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTensorFlowVersionRequest(ref GetTensorFlowVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAcceleratorTypesRequest(ref ListAcceleratorTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAcceleratorTypeRequest(ref GetAcceleratorTypeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Node"/> resources.</returns>
        public override gax::PagedEnumerable<ListNodesResponse, Node> ListNodes(ListNodesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNodesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNodesRequest, ListNodesResponse, Node>(_callListNodes, request, callSettings);
        }

        /// <summary>
        /// Lists nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Node"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNodesResponse, Node> ListNodesAsync(ListNodesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNodesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNodesRequest, ListNodesResponse, Node>(_callListNodes, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Node GetNode(GetNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodeRequest(ref request, ref callSettings);
            return _callGetNode.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Node> GetNodeAsync(GetNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodeRequest(ref request, ref callSettings);
            return _callGetNode.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateNode</c>.</summary>
        public override lro::OperationsClient CreateNodeOperationsClient { get; }

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Node, OperationMetadata> CreateNode(CreateNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(_callCreateNode.Sync(request, callSettings), CreateNodeOperationsClient);
        }

        /// <summary>
        /// Creates a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Node, OperationMetadata>> CreateNodeAsync(CreateNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(await _callCreateNode.Async(request, callSettings).ConfigureAwait(false), CreateNodeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteNode</c>.</summary>
        public override lro::OperationsClient DeleteNodeOperationsClient { get; }

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Node, OperationMetadata> DeleteNode(DeleteNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(_callDeleteNode.Sync(request, callSettings), DeleteNodeOperationsClient);
        }

        /// <summary>
        /// Deletes a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Node, OperationMetadata>> DeleteNodeAsync(DeleteNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(await _callDeleteNode.Async(request, callSettings).ConfigureAwait(false), DeleteNodeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReimageNode</c>.</summary>
        public override lro::OperationsClient ReimageNodeOperationsClient { get; }

        /// <summary>
        /// Reimages a node's OS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Node, OperationMetadata> ReimageNode(ReimageNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReimageNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(_callReimageNode.Sync(request, callSettings), ReimageNodeOperationsClient);
        }

        /// <summary>
        /// Reimages a node's OS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Node, OperationMetadata>> ReimageNodeAsync(ReimageNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReimageNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(await _callReimageNode.Async(request, callSettings).ConfigureAwait(false), ReimageNodeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopNode</c>.</summary>
        public override lro::OperationsClient StopNodeOperationsClient { get; }

        /// <summary>
        /// Stops a node, this operation is only available with single TPU nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Node, OperationMetadata> StopNode(StopNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(_callStopNode.Sync(request, callSettings), StopNodeOperationsClient);
        }

        /// <summary>
        /// Stops a node, this operation is only available with single TPU nodes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Node, OperationMetadata>> StopNodeAsync(StopNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(await _callStopNode.Async(request, callSettings).ConfigureAwait(false), StopNodeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartNode</c>.</summary>
        public override lro::OperationsClient StartNodeOperationsClient { get; }

        /// <summary>
        /// Starts a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Node, OperationMetadata> StartNode(StartNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(_callStartNode.Sync(request, callSettings), StartNodeOperationsClient);
        }

        /// <summary>
        /// Starts a node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Node, OperationMetadata>> StartNodeAsync(StartNodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartNodeRequest(ref request, ref callSettings);
            return new lro::Operation<Node, OperationMetadata>(await _callStartNode.Async(request, callSettings).ConfigureAwait(false), StartNodeOperationsClient);
        }

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersions(ListTensorFlowVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorFlowVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTensorFlowVersionsRequest, ListTensorFlowVersionsResponse, TensorFlowVersion>(_callListTensorFlowVersions, request, callSettings);
        }

        /// <summary>
        /// List TensorFlow versions supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorFlowVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTensorFlowVersionsResponse, TensorFlowVersion> ListTensorFlowVersionsAsync(ListTensorFlowVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorFlowVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTensorFlowVersionsRequest, ListTensorFlowVersionsResponse, TensorFlowVersion>(_callListTensorFlowVersions, request, callSettings);
        }

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorFlowVersion GetTensorFlowVersion(GetTensorFlowVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorFlowVersionRequest(ref request, ref callSettings);
            return _callGetTensorFlowVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets TensorFlow Version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorFlowVersion> GetTensorFlowVersionAsync(GetTensorFlowVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorFlowVersionRequest(ref request, ref callSettings);
            return _callGetTensorFlowVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AcceleratorType"/> resources.</returns>
        public override gax::PagedEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypes(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAcceleratorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAcceleratorTypesRequest, ListAcceleratorTypesResponse, AcceleratorType>(_callListAcceleratorTypes, request, callSettings);
        }

        /// <summary>
        /// Lists accelerator types supported by this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AcceleratorType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> ListAcceleratorTypesAsync(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAcceleratorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAcceleratorTypesRequest, ListAcceleratorTypesResponse, AcceleratorType>(_callListAcceleratorTypes, request, callSettings);
        }

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AcceleratorType GetAcceleratorType(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAcceleratorTypeRequest(ref request, ref callSettings);
            return _callGetAcceleratorType.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets AcceleratorType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AcceleratorType> GetAcceleratorTypeAsync(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAcceleratorTypeRequest(ref request, ref callSettings);
            return _callGetAcceleratorType.Async(request, callSettings);
        }
    }

    public partial class ListNodesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTensorFlowVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAcceleratorTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNodesResponse : gaxgrpc::IPageResponse<Node>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Node> GetEnumerator() => Nodes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTensorFlowVersionsResponse : gaxgrpc::IPageResponse<TensorFlowVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TensorFlowVersion> GetEnumerator() => TensorflowVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAcceleratorTypesResponse : gaxgrpc::IPageResponse<AcceleratorType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AcceleratorType> GetEnumerator() => AcceleratorTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Tpu
    {
        public partial class TpuClient
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

    public static partial class Tpu
    {
        public partial class TpuClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
