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

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Settings for <see cref="HealthCheckServiceClient"/> instances.</summary>
    public sealed partial class HealthCheckServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HealthCheckServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HealthCheckServiceSettings"/>.</returns>
        public static HealthCheckServiceSettings GetDefault() => new HealthCheckServiceSettings();

        /// <summary>Constructs a new <see cref="HealthCheckServiceSettings"/> object with default settings.</summary>
        public HealthCheckServiceSettings()
        {
        }

        private HealthCheckServiceSettings(HealthCheckServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            HealthCheckSettings = existing.HealthCheckSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(HealthCheckServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HealthCheckServiceClient.HealthCheck</c> and <c>HealthCheckServiceClient.HealthCheckAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings HealthCheckSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HealthCheckServiceSettings"/> object.</returns>
        public HealthCheckServiceSettings Clone() => new HealthCheckServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HealthCheckServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class HealthCheckServiceClientBuilder : gaxgrpc::ClientBuilderBase<HealthCheckServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HealthCheckServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HealthCheckServiceClientBuilder() : base(HealthCheckServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HealthCheckServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HealthCheckServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HealthCheckServiceClient Build()
        {
            HealthCheckServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HealthCheckServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HealthCheckServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HealthCheckServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HealthCheckServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HealthCheckServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HealthCheckServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HealthCheckServiceClient.ChannelPool;
    }

    /// <summary>HealthCheckService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// HealthCheckService provides an interface for Vertex AI Vision Cluster Health
    /// Check.
    /// </remarks>
    public abstract partial class HealthCheckServiceClient
    {
        /// <summary>
        /// The default endpoint for the HealthCheckService service, which is a host of "visionai.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "visionai.googleapis.com:443";

        /// <summary>The default HealthCheckService scopes.</summary>
        /// <remarks>
        /// The default HealthCheckService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(HealthCheckService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HealthCheckServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HealthCheckServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HealthCheckServiceClient"/>.</returns>
        public static stt::Task<HealthCheckServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HealthCheckServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HealthCheckServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HealthCheckServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="HealthCheckServiceClient"/>.</returns>
        public static HealthCheckServiceClient Create() => new HealthCheckServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HealthCheckServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HealthCheckServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HealthCheckServiceClient"/>.</returns>
        internal static HealthCheckServiceClient Create(grpccore::CallInvoker callInvoker, HealthCheckServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HealthCheckService.HealthCheckServiceClient grpcClient = new HealthCheckService.HealthCheckServiceClient(callInvoker);
            return new HealthCheckServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC HealthCheckService client</summary>
        public virtual HealthCheckService.HealthCheckServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// HealthCheck method checks the health status of the cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HealthCheckResponse HealthCheck(HealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// HealthCheck method checks the health status of the cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HealthCheckResponse> HealthCheckAsync(HealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// HealthCheck method checks the health status of the cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HealthCheckResponse> HealthCheckAsync(HealthCheckRequest request, st::CancellationToken cancellationToken) =>
            HealthCheckAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HealthCheckService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// HealthCheckService provides an interface for Vertex AI Vision Cluster Health
    /// Check.
    /// </remarks>
    public sealed partial class HealthCheckServiceClientImpl : HealthCheckServiceClient
    {
        private readonly gaxgrpc::ApiCall<HealthCheckRequest, HealthCheckResponse> _callHealthCheck;

        /// <summary>
        /// Constructs a client wrapper for the HealthCheckService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HealthCheckServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HealthCheckServiceClientImpl(HealthCheckService.HealthCheckServiceClient grpcClient, HealthCheckServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HealthCheckServiceSettings effectiveSettings = settings ?? HealthCheckServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callHealthCheck = clientHelper.BuildApiCall<HealthCheckRequest, HealthCheckResponse>("HealthCheck", grpcClient.HealthCheckAsync, grpcClient.HealthCheck, effectiveSettings.HealthCheckSettings).WithGoogleRequestParam("cluster", request => request.Cluster);
            Modify_ApiCall(ref _callHealthCheck);
            Modify_HealthCheckApiCall(ref _callHealthCheck);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_HealthCheckApiCall(ref gaxgrpc::ApiCall<HealthCheckRequest, HealthCheckResponse> call);

        partial void OnConstruction(HealthCheckService.HealthCheckServiceClient grpcClient, HealthCheckServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HealthCheckService client</summary>
        public override HealthCheckService.HealthCheckServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_HealthCheckRequest(ref HealthCheckRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// HealthCheck method checks the health status of the cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HealthCheckResponse HealthCheck(HealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HealthCheckRequest(ref request, ref callSettings);
            return _callHealthCheck.Sync(request, callSettings);
        }

        /// <summary>
        /// HealthCheck method checks the health status of the cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HealthCheckResponse> HealthCheckAsync(HealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HealthCheckRequest(ref request, ref callSettings);
            return _callHealthCheck.Async(request, callSettings);
        }
    }

    public static partial class HealthCheckService
    {
        public partial class HealthCheckServiceClient
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
