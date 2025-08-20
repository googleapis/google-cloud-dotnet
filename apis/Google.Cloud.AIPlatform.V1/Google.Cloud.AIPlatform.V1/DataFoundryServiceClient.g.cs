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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="DataFoundryServiceClient"/> instances.</summary>
    public sealed partial class DataFoundryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataFoundryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataFoundryServiceSettings"/>.</returns>
        public static DataFoundryServiceSettings GetDefault() => new DataFoundryServiceSettings();

        /// <summary>Constructs a new <see cref="DataFoundryServiceSettings"/> object with default settings.</summary>
        public DataFoundryServiceSettings()
        {
        }

        private DataFoundryServiceSettings(DataFoundryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateSyntheticDataSettings = existing.GenerateSyntheticDataSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataFoundryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataFoundryServiceClient.GenerateSyntheticData</c> and
        /// <c>DataFoundryServiceClient.GenerateSyntheticDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateSyntheticDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataFoundryServiceSettings"/> object.</returns>
        public DataFoundryServiceSettings Clone() => new DataFoundryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataFoundryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataFoundryServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataFoundryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataFoundryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataFoundryServiceClientBuilder() : base(DataFoundryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataFoundryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataFoundryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataFoundryServiceClient Build()
        {
            DataFoundryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataFoundryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataFoundryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataFoundryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataFoundryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataFoundryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataFoundryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataFoundryServiceClient.ChannelPool;
    }

    /// <summary>DataFoundryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for generating and preparing datasets for Gen AI evaluation.
    /// </remarks>
    public abstract partial class DataFoundryServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataFoundryService service, which is a host of "aiplatform.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default DataFoundryService scopes.</summary>
        /// <remarks>
        /// The default DataFoundryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataFoundryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataFoundryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataFoundryServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataFoundryServiceClient"/>.</returns>
        public static stt::Task<DataFoundryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataFoundryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataFoundryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataFoundryServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="DataFoundryServiceClient"/>.</returns>
        public static DataFoundryServiceClient Create() => new DataFoundryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataFoundryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataFoundryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataFoundryServiceClient"/>.</returns>
        internal static DataFoundryServiceClient Create(grpccore::CallInvoker callInvoker, DataFoundryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataFoundryService.DataFoundryServiceClient grpcClient = new DataFoundryService.DataFoundryServiceClient(callInvoker);
            return new DataFoundryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataFoundryService client</summary>
        public virtual DataFoundryService.DataFoundryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Generates synthetic data based on the provided configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateSyntheticDataResponse GenerateSyntheticData(GenerateSyntheticDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates synthetic data based on the provided configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSyntheticDataResponse> GenerateSyntheticDataAsync(GenerateSyntheticDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates synthetic data based on the provided configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSyntheticDataResponse> GenerateSyntheticDataAsync(GenerateSyntheticDataRequest request, st::CancellationToken cancellationToken) =>
            GenerateSyntheticDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataFoundryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for generating and preparing datasets for Gen AI evaluation.
    /// </remarks>
    public sealed partial class DataFoundryServiceClientImpl : DataFoundryServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateSyntheticDataRequest, GenerateSyntheticDataResponse> _callGenerateSyntheticData;

        /// <summary>
        /// Constructs a client wrapper for the DataFoundryService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataFoundryServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataFoundryServiceClientImpl(DataFoundryService.DataFoundryServiceClient grpcClient, DataFoundryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataFoundryServiceSettings effectiveSettings = settings ?? DataFoundryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGenerateSyntheticData = clientHelper.BuildApiCall<GenerateSyntheticDataRequest, GenerateSyntheticDataResponse>("GenerateSyntheticData", grpcClient.GenerateSyntheticDataAsync, grpcClient.GenerateSyntheticData, effectiveSettings.GenerateSyntheticDataSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callGenerateSyntheticData);
            Modify_GenerateSyntheticDataApiCall(ref _callGenerateSyntheticData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateSyntheticDataApiCall(ref gaxgrpc::ApiCall<GenerateSyntheticDataRequest, GenerateSyntheticDataResponse> call);

        partial void OnConstruction(DataFoundryService.DataFoundryServiceClient grpcClient, DataFoundryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataFoundryService client</summary>
        public override DataFoundryService.DataFoundryServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GenerateSyntheticDataRequest(ref GenerateSyntheticDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Generates synthetic data based on the provided configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateSyntheticDataResponse GenerateSyntheticData(GenerateSyntheticDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSyntheticDataRequest(ref request, ref callSettings);
            return _callGenerateSyntheticData.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates synthetic data based on the provided configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateSyntheticDataResponse> GenerateSyntheticDataAsync(GenerateSyntheticDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSyntheticDataRequest(ref request, ref callSettings);
            return _callGenerateSyntheticData.Async(request, callSettings);
        }
    }

    public static partial class DataFoundryService
    {
        public partial class DataFoundryServiceClient
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
