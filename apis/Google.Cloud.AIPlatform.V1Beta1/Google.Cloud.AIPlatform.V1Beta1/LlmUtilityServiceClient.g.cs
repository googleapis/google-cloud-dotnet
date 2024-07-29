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
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="LlmUtilityServiceClient"/> instances.</summary>
    public sealed partial class LlmUtilityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LlmUtilityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LlmUtilityServiceSettings"/>.</returns>
        public static LlmUtilityServiceSettings GetDefault() => new LlmUtilityServiceSettings();

        /// <summary>Constructs a new <see cref="LlmUtilityServiceSettings"/> object with default settings.</summary>
        public LlmUtilityServiceSettings()
        {
        }

        private LlmUtilityServiceSettings(LlmUtilityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ComputeTokensSettings = existing.ComputeTokensSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(LlmUtilityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LlmUtilityServiceClient.ComputeTokens</c> and <c>LlmUtilityServiceClient.ComputeTokensAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeTokensSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LlmUtilityServiceSettings"/> object.</returns>
        public LlmUtilityServiceSettings Clone() => new LlmUtilityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LlmUtilityServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LlmUtilityServiceClientBuilder : gaxgrpc::ClientBuilderBase<LlmUtilityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LlmUtilityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LlmUtilityServiceClientBuilder() : base(LlmUtilityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LlmUtilityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LlmUtilityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LlmUtilityServiceClient Build()
        {
            LlmUtilityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LlmUtilityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LlmUtilityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LlmUtilityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LlmUtilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LlmUtilityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LlmUtilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LlmUtilityServiceClient.ChannelPool;
    }

    /// <summary>LlmUtilityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for LLM related utility functions.
    /// </remarks>
    public abstract partial class LlmUtilityServiceClient
    {
        /// <summary>
        /// The default endpoint for the LlmUtilityService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default LlmUtilityService scopes.</summary>
        /// <remarks>
        /// The default LlmUtilityService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LlmUtilityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LlmUtilityServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LlmUtilityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LlmUtilityServiceClient"/>.</returns>
        public static stt::Task<LlmUtilityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LlmUtilityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LlmUtilityServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LlmUtilityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LlmUtilityServiceClient"/>.</returns>
        public static LlmUtilityServiceClient Create() => new LlmUtilityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LlmUtilityServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LlmUtilityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LlmUtilityServiceClient"/>.</returns>
        internal static LlmUtilityServiceClient Create(grpccore::CallInvoker callInvoker, LlmUtilityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LlmUtilityService.LlmUtilityServiceClient grpcClient = new LlmUtilityService.LlmUtilityServiceClient(callInvoker);
            return new LlmUtilityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LlmUtilityService client</summary>
        public virtual LlmUtilityService.LlmUtilityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeTokensResponse ComputeTokens(ComputeTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeTokensResponse> ComputeTokensAsync(ComputeTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeTokensResponse> ComputeTokensAsync(ComputeTokensRequest request, st::CancellationToken cancellationToken) =>
            ComputeTokensAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to get lists of tokens and
        /// token ids.
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token computing API call.
        /// Schema is identical to the prediction schema of the text model, even for
        /// the non-text models, like chat models, or Codey models.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeTokensResponse ComputeTokens(string endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            ComputeTokens(new ComputeTokensRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to get lists of tokens and
        /// token ids.
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token computing API call.
        /// Schema is identical to the prediction schema of the text model, even for
        /// the non-text models, like chat models, or Codey models.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeTokensResponse> ComputeTokensAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            ComputeTokensAsync(new ComputeTokensRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to get lists of tokens and
        /// token ids.
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token computing API call.
        /// Schema is identical to the prediction schema of the text model, even for
        /// the non-text models, like chat models, or Codey models.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeTokensResponse> ComputeTokensAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, st::CancellationToken cancellationToken) =>
            ComputeTokensAsync(endpoint, instances, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to get lists of tokens and
        /// token ids.
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token computing API call.
        /// Schema is identical to the prediction schema of the text model, even for
        /// the non-text models, like chat models, or Codey models.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeTokensResponse ComputeTokens(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            ComputeTokens(new ComputeTokensRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to get lists of tokens and
        /// token ids.
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token computing API call.
        /// Schema is identical to the prediction schema of the text model, even for
        /// the non-text models, like chat models, or Codey models.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeTokensResponse> ComputeTokensAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            ComputeTokensAsync(new ComputeTokensRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to get lists of tokens and
        /// token ids.
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token computing API call.
        /// Schema is identical to the prediction schema of the text model, even for
        /// the non-text models, like chat models, or Codey models.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeTokensResponse> ComputeTokensAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, st::CancellationToken cancellationToken) =>
            ComputeTokensAsync(endpoint, instances, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LlmUtilityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for LLM related utility functions.
    /// </remarks>
    public sealed partial class LlmUtilityServiceClientImpl : LlmUtilityServiceClient
    {
        private readonly gaxgrpc::ApiCall<ComputeTokensRequest, ComputeTokensResponse> _callComputeTokens;

        /// <summary>
        /// Constructs a client wrapper for the LlmUtilityService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LlmUtilityServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LlmUtilityServiceClientImpl(LlmUtilityService.LlmUtilityServiceClient grpcClient, LlmUtilityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LlmUtilityServiceSettings effectiveSettings = settings ?? LlmUtilityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callComputeTokens = clientHelper.BuildApiCall<ComputeTokensRequest, ComputeTokensResponse>("ComputeTokens", grpcClient.ComputeTokensAsync, grpcClient.ComputeTokens, effectiveSettings.ComputeTokensSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callComputeTokens);
            Modify_ComputeTokensApiCall(ref _callComputeTokens);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ComputeTokensApiCall(ref gaxgrpc::ApiCall<ComputeTokensRequest, ComputeTokensResponse> call);

        partial void OnConstruction(LlmUtilityService.LlmUtilityServiceClient grpcClient, LlmUtilityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LlmUtilityService client</summary>
        public override LlmUtilityService.LlmUtilityServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ComputeTokensRequest(ref ComputeTokensRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeTokensResponse ComputeTokens(ComputeTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeTokensRequest(ref request, ref callSettings);
            return _callComputeTokens.Sync(request, callSettings);
        }

        /// <summary>
        /// Return a list of tokens based on the input text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeTokensResponse> ComputeTokensAsync(ComputeTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeTokensRequest(ref request, ref callSettings);
            return _callComputeTokens.Async(request, callSettings);
        }
    }

    public static partial class LlmUtilityService
    {
        public partial class LlmUtilityServiceClient
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
