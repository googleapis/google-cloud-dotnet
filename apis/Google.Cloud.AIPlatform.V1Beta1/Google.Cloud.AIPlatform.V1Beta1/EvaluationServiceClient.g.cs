// Copyright 2024 Google LLC
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
    /// <summary>Settings for <see cref="EvaluationServiceClient"/> instances.</summary>
    public sealed partial class EvaluationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EvaluationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EvaluationServiceSettings"/>.</returns>
        public static EvaluationServiceSettings GetDefault() => new EvaluationServiceSettings();

        /// <summary>Constructs a new <see cref="EvaluationServiceSettings"/> object with default settings.</summary>
        public EvaluationServiceSettings()
        {
        }

        private EvaluationServiceSettings(EvaluationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            EvaluateInstancesSettings = existing.EvaluateInstancesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(EvaluationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.EvaluateInstances</c> and <c>EvaluationServiceClient.EvaluateInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EvaluateInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EvaluationServiceSettings"/> object.</returns>
        public EvaluationServiceSettings Clone() => new EvaluationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EvaluationServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class EvaluationServiceClientBuilder : gaxgrpc::ClientBuilderBase<EvaluationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EvaluationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EvaluationServiceClientBuilder() : base(EvaluationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EvaluationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EvaluationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EvaluationServiceClient Build()
        {
            EvaluationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EvaluationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EvaluationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EvaluationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EvaluationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EvaluationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EvaluationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EvaluationServiceClient.ChannelPool;
    }

    /// <summary>EvaluationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Vertex AI Online Evaluation Service.
    /// </remarks>
    public abstract partial class EvaluationServiceClient
    {
        /// <summary>
        /// The default endpoint for the EvaluationService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default EvaluationService scopes.</summary>
        /// <remarks>
        /// The default EvaluationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EvaluationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EvaluationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EvaluationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EvaluationServiceClient"/>.</returns>
        public static stt::Task<EvaluationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EvaluationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EvaluationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EvaluationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EvaluationServiceClient"/>.</returns>
        public static EvaluationServiceClient Create() => new EvaluationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EvaluationServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EvaluationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EvaluationServiceClient"/>.</returns>
        internal static EvaluationServiceClient Create(grpccore::CallInvoker callInvoker, EvaluationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EvaluationService.EvaluationServiceClient grpcClient = new EvaluationService.EvaluationServiceClient(callInvoker);
            return new EvaluationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EvaluationService client</summary>
        public virtual EvaluationService.EvaluationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Evaluates instances based on a given metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluateInstancesResponse EvaluateInstances(EvaluateInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Evaluates instances based on a given metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluateInstancesResponse> EvaluateInstancesAsync(EvaluateInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Evaluates instances based on a given metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluateInstancesResponse> EvaluateInstancesAsync(EvaluateInstancesRequest request, st::CancellationToken cancellationToken) =>
            EvaluateInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EvaluationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Vertex AI Online Evaluation Service.
    /// </remarks>
    public sealed partial class EvaluationServiceClientImpl : EvaluationServiceClient
    {
        private readonly gaxgrpc::ApiCall<EvaluateInstancesRequest, EvaluateInstancesResponse> _callEvaluateInstances;

        /// <summary>
        /// Constructs a client wrapper for the EvaluationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EvaluationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EvaluationServiceClientImpl(EvaluationService.EvaluationServiceClient grpcClient, EvaluationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EvaluationServiceSettings effectiveSettings = settings ?? EvaluationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callEvaluateInstances = clientHelper.BuildApiCall<EvaluateInstancesRequest, EvaluateInstancesResponse>("EvaluateInstances", grpcClient.EvaluateInstancesAsync, grpcClient.EvaluateInstances, effectiveSettings.EvaluateInstancesSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callEvaluateInstances);
            Modify_EvaluateInstancesApiCall(ref _callEvaluateInstances);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_EvaluateInstancesApiCall(ref gaxgrpc::ApiCall<EvaluateInstancesRequest, EvaluateInstancesResponse> call);

        partial void OnConstruction(EvaluationService.EvaluationServiceClient grpcClient, EvaluationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EvaluationService client</summary>
        public override EvaluationService.EvaluationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_EvaluateInstancesRequest(ref EvaluateInstancesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Evaluates instances based on a given metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluateInstancesResponse EvaluateInstances(EvaluateInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvaluateInstancesRequest(ref request, ref callSettings);
            return _callEvaluateInstances.Sync(request, callSettings);
        }

        /// <summary>
        /// Evaluates instances based on a given metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluateInstancesResponse> EvaluateInstancesAsync(EvaluateInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvaluateInstancesRequest(ref request, ref callSettings);
            return _callEvaluateInstances.Async(request, callSettings);
        }
    }

    public static partial class EvaluationService
    {
        public partial class EvaluationServiceClient
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
