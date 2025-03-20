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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="MatchServiceClient"/> instances.</summary>
    public sealed partial class MatchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MatchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MatchServiceSettings"/>.</returns>
        public static MatchServiceSettings GetDefault() => new MatchServiceSettings();

        /// <summary>Constructs a new <see cref="MatchServiceSettings"/> object with default settings.</summary>
        public MatchServiceSettings()
        {
        }

        private MatchServiceSettings(MatchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FindNeighborsSettings = existing.FindNeighborsSettings;
            ReadIndexDatapointsSettings = existing.ReadIndexDatapointsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(MatchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MatchServiceClient.FindNeighbors</c> and <c>MatchServiceClient.FindNeighborsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FindNeighborsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MatchServiceClient.ReadIndexDatapoints</c> and <c>MatchServiceClient.ReadIndexDatapointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadIndexDatapointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MatchServiceSettings"/> object.</returns>
        public MatchServiceSettings Clone() => new MatchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MatchServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MatchServiceClientBuilder : gaxgrpc::ClientBuilderBase<MatchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MatchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MatchServiceClientBuilder() : base(MatchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MatchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MatchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MatchServiceClient Build()
        {
            MatchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MatchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MatchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MatchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MatchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MatchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MatchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MatchServiceClient.ChannelPool;
    }

    /// <summary>MatchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// MatchService is a Google managed service for efficient vector similarity
    /// search at scale.
    /// </remarks>
    public abstract partial class MatchServiceClient
    {
        /// <summary>
        /// The default endpoint for the MatchService service, which is a host of "aiplatform.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default MatchService scopes.</summary>
        /// <remarks>
        /// The default MatchService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MatchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MatchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MatchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MatchServiceClient"/>.</returns>
        public static stt::Task<MatchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MatchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MatchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MatchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MatchServiceClient"/>.</returns>
        public static MatchServiceClient Create() => new MatchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MatchServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MatchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MatchServiceClient"/>.</returns>
        internal static MatchServiceClient Create(grpccore::CallInvoker callInvoker, MatchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MatchService.MatchServiceClient grpcClient = new MatchService.MatchServiceClient(callInvoker);
            return new MatchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MatchService client</summary>
        public virtual MatchService.MatchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Finds the nearest neighbors of each vector within the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindNeighborsResponse FindNeighbors(FindNeighborsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds the nearest neighbors of each vector within the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindNeighborsResponse> FindNeighborsAsync(FindNeighborsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds the nearest neighbors of each vector within the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindNeighborsResponse> FindNeighborsAsync(FindNeighborsRequest request, st::CancellationToken cancellationToken) =>
            FindNeighborsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads the datapoints/vectors of the given IDs.
        /// A maximum of 1000 datapoints can be retrieved in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadIndexDatapointsResponse ReadIndexDatapoints(ReadIndexDatapointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads the datapoints/vectors of the given IDs.
        /// A maximum of 1000 datapoints can be retrieved in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadIndexDatapointsResponse> ReadIndexDatapointsAsync(ReadIndexDatapointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads the datapoints/vectors of the given IDs.
        /// A maximum of 1000 datapoints can be retrieved in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadIndexDatapointsResponse> ReadIndexDatapointsAsync(ReadIndexDatapointsRequest request, st::CancellationToken cancellationToken) =>
            ReadIndexDatapointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MatchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// MatchService is a Google managed service for efficient vector similarity
    /// search at scale.
    /// </remarks>
    public sealed partial class MatchServiceClientImpl : MatchServiceClient
    {
        private readonly gaxgrpc::ApiCall<FindNeighborsRequest, FindNeighborsResponse> _callFindNeighbors;

        private readonly gaxgrpc::ApiCall<ReadIndexDatapointsRequest, ReadIndexDatapointsResponse> _callReadIndexDatapoints;

        /// <summary>
        /// Constructs a client wrapper for the MatchService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MatchServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MatchServiceClientImpl(MatchService.MatchServiceClient grpcClient, MatchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MatchServiceSettings effectiveSettings = settings ?? MatchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callFindNeighbors = clientHelper.BuildApiCall<FindNeighborsRequest, FindNeighborsResponse>("FindNeighbors", grpcClient.FindNeighborsAsync, grpcClient.FindNeighbors, effectiveSettings.FindNeighborsSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callFindNeighbors);
            Modify_FindNeighborsApiCall(ref _callFindNeighbors);
            _callReadIndexDatapoints = clientHelper.BuildApiCall<ReadIndexDatapointsRequest, ReadIndexDatapointsResponse>("ReadIndexDatapoints", grpcClient.ReadIndexDatapointsAsync, grpcClient.ReadIndexDatapoints, effectiveSettings.ReadIndexDatapointsSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callReadIndexDatapoints);
            Modify_ReadIndexDatapointsApiCall(ref _callReadIndexDatapoints);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FindNeighborsApiCall(ref gaxgrpc::ApiCall<FindNeighborsRequest, FindNeighborsResponse> call);

        partial void Modify_ReadIndexDatapointsApiCall(ref gaxgrpc::ApiCall<ReadIndexDatapointsRequest, ReadIndexDatapointsResponse> call);

        partial void OnConstruction(MatchService.MatchServiceClient grpcClient, MatchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MatchService client</summary>
        public override MatchService.MatchServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_FindNeighborsRequest(ref FindNeighborsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadIndexDatapointsRequest(ref ReadIndexDatapointsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Finds the nearest neighbors of each vector within the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindNeighborsResponse FindNeighbors(FindNeighborsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindNeighborsRequest(ref request, ref callSettings);
            return _callFindNeighbors.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds the nearest neighbors of each vector within the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindNeighborsResponse> FindNeighborsAsync(FindNeighborsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindNeighborsRequest(ref request, ref callSettings);
            return _callFindNeighbors.Async(request, callSettings);
        }

        /// <summary>
        /// Reads the datapoints/vectors of the given IDs.
        /// A maximum of 1000 datapoints can be retrieved in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadIndexDatapointsResponse ReadIndexDatapoints(ReadIndexDatapointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadIndexDatapointsRequest(ref request, ref callSettings);
            return _callReadIndexDatapoints.Sync(request, callSettings);
        }

        /// <summary>
        /// Reads the datapoints/vectors of the given IDs.
        /// A maximum of 1000 datapoints can be retrieved in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadIndexDatapointsResponse> ReadIndexDatapointsAsync(ReadIndexDatapointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadIndexDatapointsRequest(ref request, ref callSettings);
            return _callReadIndexDatapoints.Async(request, callSettings);
        }
    }

    public static partial class MatchService
    {
        public partial class MatchServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
