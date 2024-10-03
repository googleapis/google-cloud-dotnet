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

namespace Google.Cloud.Run.V2
{
    /// <summary>Settings for <see cref="BuildsClient"/> instances.</summary>
    public sealed partial class BuildsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BuildsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BuildsSettings"/>.</returns>
        public static BuildsSettings GetDefault() => new BuildsSettings();

        /// <summary>Constructs a new <see cref="BuildsSettings"/> object with default settings.</summary>
        public BuildsSettings()
        {
        }

        private BuildsSettings(BuildsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SubmitBuildSettings = existing.SubmitBuildSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BuildsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BuildsClient.SubmitBuild</c>
        ///  and <c>BuildsClient.SubmitBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubmitBuildSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BuildsSettings"/> object.</returns>
        public BuildsSettings Clone() => new BuildsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BuildsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BuildsClientBuilder : gaxgrpc::ClientBuilderBase<BuildsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BuildsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BuildsClientBuilder() : base(BuildsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BuildsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BuildsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BuildsClient Build()
        {
            BuildsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BuildsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BuildsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BuildsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BuildsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BuildsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BuildsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BuildsClient.ChannelPool;
    }

    /// <summary>Builds client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Build Control Plane API
    /// </remarks>
    public abstract partial class BuildsClient
    {
        /// <summary>
        /// The default endpoint for the Builds service, which is a host of "run.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "run.googleapis.com:443";

        /// <summary>The default Builds scopes.</summary>
        /// <remarks>
        /// The default Builds scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Builds.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BuildsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="BuildsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BuildsClient"/>.</returns>
        public static stt::Task<BuildsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BuildsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BuildsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="BuildsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BuildsClient"/>.</returns>
        public static BuildsClient Create() => new BuildsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BuildsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BuildsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BuildsClient"/>.</returns>
        internal static BuildsClient Create(grpccore::CallInvoker callInvoker, BuildsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Builds.BuildsClient grpcClient = new Builds.BuildsClient(callInvoker);
            return new BuildsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Builds client</summary>
        public virtual Builds.BuildsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a build in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SubmitBuildResponse SubmitBuild(SubmitBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a build in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitBuildResponse> SubmitBuildAsync(SubmitBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a build in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SubmitBuildResponse> SubmitBuildAsync(SubmitBuildRequest request, st::CancellationToken cancellationToken) =>
            SubmitBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Builds client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Build Control Plane API
    /// </remarks>
    public sealed partial class BuildsClientImpl : BuildsClient
    {
        private readonly gaxgrpc::ApiCall<SubmitBuildRequest, SubmitBuildResponse> _callSubmitBuild;

        /// <summary>
        /// Constructs a client wrapper for the Builds service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BuildsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BuildsClientImpl(Builds.BuildsClient grpcClient, BuildsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BuildsSettings effectiveSettings = settings ?? BuildsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callSubmitBuild = clientHelper.BuildApiCall<SubmitBuildRequest, SubmitBuildResponse>("SubmitBuild", grpcClient.SubmitBuildAsync, grpcClient.SubmitBuild, effectiveSettings.SubmitBuildSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSubmitBuild);
            Modify_SubmitBuildApiCall(ref _callSubmitBuild);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SubmitBuildApiCall(ref gaxgrpc::ApiCall<SubmitBuildRequest, SubmitBuildResponse> call);

        partial void OnConstruction(Builds.BuildsClient grpcClient, BuildsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Builds client</summary>
        public override Builds.BuildsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SubmitBuildRequest(ref SubmitBuildRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Submits a build in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SubmitBuildResponse SubmitBuild(SubmitBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitBuildRequest(ref request, ref callSettings);
            return _callSubmitBuild.Sync(request, callSettings);
        }

        /// <summary>
        /// Submits a build in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SubmitBuildResponse> SubmitBuildAsync(SubmitBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitBuildRequest(ref request, ref callSettings);
            return _callSubmitBuild.Async(request, callSettings);
        }
    }

    public static partial class Builds
    {
        public partial class BuildsClient
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
