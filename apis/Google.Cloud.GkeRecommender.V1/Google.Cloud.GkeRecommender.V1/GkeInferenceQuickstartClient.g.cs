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

namespace Google.Cloud.GkeRecommender.V1
{
    /// <summary>Settings for <see cref="GkeInferenceQuickstartClient"/> instances.</summary>
    public sealed partial class GkeInferenceQuickstartSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GkeInferenceQuickstartSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GkeInferenceQuickstartSettings"/>.</returns>
        public static GkeInferenceQuickstartSettings GetDefault() => new GkeInferenceQuickstartSettings();

        /// <summary>
        /// Constructs a new <see cref="GkeInferenceQuickstartSettings"/> object with default settings.
        /// </summary>
        public GkeInferenceQuickstartSettings()
        {
        }

        private GkeInferenceQuickstartSettings(GkeInferenceQuickstartSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FetchModelsSettings = existing.FetchModelsSettings;
            FetchModelServersSettings = existing.FetchModelServersSettings;
            FetchModelServerVersionsSettings = existing.FetchModelServerVersionsSettings;
            FetchProfilesSettings = existing.FetchProfilesSettings;
            GenerateOptimizedManifestSettings = existing.GenerateOptimizedManifestSettings;
            FetchBenchmarkingDataSettings = existing.FetchBenchmarkingDataSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GkeInferenceQuickstartSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeInferenceQuickstartClient.FetchModels</c> and <c>GkeInferenceQuickstartClient.FetchModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeInferenceQuickstartClient.FetchModelServers</c> and
        /// <c>GkeInferenceQuickstartClient.FetchModelServersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchModelServersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeInferenceQuickstartClient.FetchModelServerVersions</c> and
        /// <c>GkeInferenceQuickstartClient.FetchModelServerVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchModelServerVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeInferenceQuickstartClient.FetchProfiles</c> and <c>GkeInferenceQuickstartClient.FetchProfilesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeInferenceQuickstartClient.GenerateOptimizedManifest</c> and
        /// <c>GkeInferenceQuickstartClient.GenerateOptimizedManifestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateOptimizedManifestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeInferenceQuickstartClient.FetchBenchmarkingData</c> and
        /// <c>GkeInferenceQuickstartClient.FetchBenchmarkingDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchBenchmarkingDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GkeInferenceQuickstartSettings"/> object.</returns>
        public GkeInferenceQuickstartSettings Clone() => new GkeInferenceQuickstartSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GkeInferenceQuickstartClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GkeInferenceQuickstartClientBuilder : gaxgrpc::ClientBuilderBase<GkeInferenceQuickstartClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GkeInferenceQuickstartSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GkeInferenceQuickstartClientBuilder() : base(GkeInferenceQuickstartClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GkeInferenceQuickstartClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GkeInferenceQuickstartClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GkeInferenceQuickstartClient Build()
        {
            GkeInferenceQuickstartClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GkeInferenceQuickstartClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GkeInferenceQuickstartClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GkeInferenceQuickstartClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GkeInferenceQuickstartClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GkeInferenceQuickstartClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GkeInferenceQuickstartClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GkeInferenceQuickstartClient.ChannelPool;
    }

    /// <summary>GkeInferenceQuickstart client wrapper, for convenient use.</summary>
    /// <remarks>
    /// GKE Inference Quickstart (GIQ) service provides profiles with performance
    /// metrics for popular models and model servers across multiple accelerators.
    /// These profiles help generate optimized best practices for running inference
    /// on GKE.
    /// </remarks>
    public abstract partial class GkeInferenceQuickstartClient
    {
        /// <summary>
        /// The default endpoint for the GkeInferenceQuickstart service, which is a host of
        /// "gkerecommender.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkerecommender.googleapis.com:443";

        /// <summary>The default GkeInferenceQuickstart scopes.</summary>
        /// <remarks>
        /// The default GkeInferenceQuickstart scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GkeInferenceQuickstart.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GkeInferenceQuickstartClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GkeInferenceQuickstartClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GkeInferenceQuickstartClient"/>.</returns>
        public static stt::Task<GkeInferenceQuickstartClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GkeInferenceQuickstartClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GkeInferenceQuickstartClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GkeInferenceQuickstartClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GkeInferenceQuickstartClient"/>.</returns>
        public static GkeInferenceQuickstartClient Create() => new GkeInferenceQuickstartClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GkeInferenceQuickstartClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GkeInferenceQuickstartSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GkeInferenceQuickstartClient"/>.</returns>
        internal static GkeInferenceQuickstartClient Create(grpccore::CallInvoker callInvoker, GkeInferenceQuickstartSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GkeInferenceQuickstart.GkeInferenceQuickstartClient grpcClient = new GkeInferenceQuickstart.GkeInferenceQuickstartClient(callInvoker);
            return new GkeInferenceQuickstartClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GkeInferenceQuickstart client</summary>
        public virtual GkeInferenceQuickstart.GkeInferenceQuickstartClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available models. Open-source models follow the Huggingface Hub
        /// `owner/model_name` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchModelsResponse, string> FetchModels(FetchModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available models. Open-source models follow the Huggingface Hub
        /// `owner/model_name` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchModelsResponse, string> FetchModelsAsync(FetchModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available model servers. Open-source model servers use simplified,
        /// lowercase names (e.g., `vllm`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchModelServersResponse, string> FetchModelServers(FetchModelServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available model servers. Open-source model servers use simplified,
        /// lowercase names (e.g., `vllm`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchModelServersResponse, string> FetchModelServersAsync(FetchModelServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available model server versions. Open-source servers use their own
        /// versioning schemas (e.g., `vllm` uses semver like `v1.0.0`).
        /// 
        /// Some model servers have different versioning schemas depending on the
        /// accelerator. For example, `vllm` uses semver on GPUs, but returns nightly
        /// build tags on TPUs. All available versions will be returned when different
        /// schemas are present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchModelServerVersionsResponse, string> FetchModelServerVersions(FetchModelServerVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available model server versions. Open-source servers use their own
        /// versioning schemas (e.g., `vllm` uses semver like `v1.0.0`).
        /// 
        /// Some model servers have different versioning schemas depending on the
        /// accelerator. For example, `vllm` uses semver on GPUs, but returns nightly
        /// build tags on TPUs. All available versions will be returned when different
        /// schemas are present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchModelServerVersionsResponse, string> FetchModelServerVersionsAsync(FetchModelServerVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available profiles. A profile contains performance metrics and
        /// cost information for a specific model server setup. Profiles can be
        /// filtered by parameters. If no filters are provided, all profiles are
        /// returned.
        /// 
        /// Profiles display a single value per performance metric based on the
        /// provided performance requirements. If no requirements are given, the
        /// metrics represent the inflection point. See [Run best practice inference
        /// with GKE Inference Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart#how)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchProfilesResponse, Profile> FetchProfiles(FetchProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches available profiles. A profile contains performance metrics and
        /// cost information for a specific model server setup. Profiles can be
        /// filtered by parameters. If no filters are provided, all profiles are
        /// returned.
        /// 
        /// Profiles display a single value per performance metric based on the
        /// provided performance requirements. If no requirements are given, the
        /// metrics represent the inflection point. See [Run best practice inference
        /// with GKE Inference Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart#how)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchProfilesResponse, Profile> FetchProfilesAsync(FetchProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an optimized deployment manifest for a given model and model
        /// server, based on the specified accelerator, performance targets, and
        /// configurations. See [Run best practice inference with GKE Inference
        /// Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart)
        /// for deployment details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateOptimizedManifestResponse GenerateOptimizedManifest(GenerateOptimizedManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an optimized deployment manifest for a given model and model
        /// server, based on the specified accelerator, performance targets, and
        /// configurations. See [Run best practice inference with GKE Inference
        /// Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart)
        /// for deployment details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateOptimizedManifestResponse> GenerateOptimizedManifestAsync(GenerateOptimizedManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an optimized deployment manifest for a given model and model
        /// server, based on the specified accelerator, performance targets, and
        /// configurations. See [Run best practice inference with GKE Inference
        /// Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart)
        /// for deployment details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateOptimizedManifestResponse> GenerateOptimizedManifestAsync(GenerateOptimizedManifestRequest request, st::CancellationToken cancellationToken) =>
            GenerateOptimizedManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches all of the benchmarking data available for a profile. Benchmarking
        /// data returns all of the performance metrics available for a given model
        /// server setup on a given instance type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchBenchmarkingDataResponse FetchBenchmarkingData(FetchBenchmarkingDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches all of the benchmarking data available for a profile. Benchmarking
        /// data returns all of the performance metrics available for a given model
        /// server setup on a given instance type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchBenchmarkingDataResponse> FetchBenchmarkingDataAsync(FetchBenchmarkingDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches all of the benchmarking data available for a profile. Benchmarking
        /// data returns all of the performance metrics available for a given model
        /// server setup on a given instance type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchBenchmarkingDataResponse> FetchBenchmarkingDataAsync(FetchBenchmarkingDataRequest request, st::CancellationToken cancellationToken) =>
            FetchBenchmarkingDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GkeInferenceQuickstart client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// GKE Inference Quickstart (GIQ) service provides profiles with performance
    /// metrics for popular models and model servers across multiple accelerators.
    /// These profiles help generate optimized best practices for running inference
    /// on GKE.
    /// </remarks>
    public sealed partial class GkeInferenceQuickstartClientImpl : GkeInferenceQuickstartClient
    {
        private readonly gaxgrpc::ApiCall<FetchModelsRequest, FetchModelsResponse> _callFetchModels;

        private readonly gaxgrpc::ApiCall<FetchModelServersRequest, FetchModelServersResponse> _callFetchModelServers;

        private readonly gaxgrpc::ApiCall<FetchModelServerVersionsRequest, FetchModelServerVersionsResponse> _callFetchModelServerVersions;

        private readonly gaxgrpc::ApiCall<FetchProfilesRequest, FetchProfilesResponse> _callFetchProfiles;

        private readonly gaxgrpc::ApiCall<GenerateOptimizedManifestRequest, GenerateOptimizedManifestResponse> _callGenerateOptimizedManifest;

        private readonly gaxgrpc::ApiCall<FetchBenchmarkingDataRequest, FetchBenchmarkingDataResponse> _callFetchBenchmarkingData;

        /// <summary>
        /// Constructs a client wrapper for the GkeInferenceQuickstart service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GkeInferenceQuickstartSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GkeInferenceQuickstartClientImpl(GkeInferenceQuickstart.GkeInferenceQuickstartClient grpcClient, GkeInferenceQuickstartSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GkeInferenceQuickstartSettings effectiveSettings = settings ?? GkeInferenceQuickstartSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callFetchModels = clientHelper.BuildApiCall<FetchModelsRequest, FetchModelsResponse>("FetchModels", grpcClient.FetchModelsAsync, grpcClient.FetchModels, effectiveSettings.FetchModelsSettings);
            Modify_ApiCall(ref _callFetchModels);
            Modify_FetchModelsApiCall(ref _callFetchModels);
            _callFetchModelServers = clientHelper.BuildApiCall<FetchModelServersRequest, FetchModelServersResponse>("FetchModelServers", grpcClient.FetchModelServersAsync, grpcClient.FetchModelServers, effectiveSettings.FetchModelServersSettings);
            Modify_ApiCall(ref _callFetchModelServers);
            Modify_FetchModelServersApiCall(ref _callFetchModelServers);
            _callFetchModelServerVersions = clientHelper.BuildApiCall<FetchModelServerVersionsRequest, FetchModelServerVersionsResponse>("FetchModelServerVersions", grpcClient.FetchModelServerVersionsAsync, grpcClient.FetchModelServerVersions, effectiveSettings.FetchModelServerVersionsSettings);
            Modify_ApiCall(ref _callFetchModelServerVersions);
            Modify_FetchModelServerVersionsApiCall(ref _callFetchModelServerVersions);
            _callFetchProfiles = clientHelper.BuildApiCall<FetchProfilesRequest, FetchProfilesResponse>("FetchProfiles", grpcClient.FetchProfilesAsync, grpcClient.FetchProfiles, effectiveSettings.FetchProfilesSettings);
            Modify_ApiCall(ref _callFetchProfiles);
            Modify_FetchProfilesApiCall(ref _callFetchProfiles);
            _callGenerateOptimizedManifest = clientHelper.BuildApiCall<GenerateOptimizedManifestRequest, GenerateOptimizedManifestResponse>("GenerateOptimizedManifest", grpcClient.GenerateOptimizedManifestAsync, grpcClient.GenerateOptimizedManifest, effectiveSettings.GenerateOptimizedManifestSettings);
            Modify_ApiCall(ref _callGenerateOptimizedManifest);
            Modify_GenerateOptimizedManifestApiCall(ref _callGenerateOptimizedManifest);
            _callFetchBenchmarkingData = clientHelper.BuildApiCall<FetchBenchmarkingDataRequest, FetchBenchmarkingDataResponse>("FetchBenchmarkingData", grpcClient.FetchBenchmarkingDataAsync, grpcClient.FetchBenchmarkingData, effectiveSettings.FetchBenchmarkingDataSettings);
            Modify_ApiCall(ref _callFetchBenchmarkingData);
            Modify_FetchBenchmarkingDataApiCall(ref _callFetchBenchmarkingData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FetchModelsApiCall(ref gaxgrpc::ApiCall<FetchModelsRequest, FetchModelsResponse> call);

        partial void Modify_FetchModelServersApiCall(ref gaxgrpc::ApiCall<FetchModelServersRequest, FetchModelServersResponse> call);

        partial void Modify_FetchModelServerVersionsApiCall(ref gaxgrpc::ApiCall<FetchModelServerVersionsRequest, FetchModelServerVersionsResponse> call);

        partial void Modify_FetchProfilesApiCall(ref gaxgrpc::ApiCall<FetchProfilesRequest, FetchProfilesResponse> call);

        partial void Modify_GenerateOptimizedManifestApiCall(ref gaxgrpc::ApiCall<GenerateOptimizedManifestRequest, GenerateOptimizedManifestResponse> call);

        partial void Modify_FetchBenchmarkingDataApiCall(ref gaxgrpc::ApiCall<FetchBenchmarkingDataRequest, FetchBenchmarkingDataResponse> call);

        partial void OnConstruction(GkeInferenceQuickstart.GkeInferenceQuickstartClient grpcClient, GkeInferenceQuickstartSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GkeInferenceQuickstart client</summary>
        public override GkeInferenceQuickstart.GkeInferenceQuickstartClient GrpcClient { get; }

        partial void Modify_FetchModelsRequest(ref FetchModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchModelServersRequest(ref FetchModelServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchModelServerVersionsRequest(ref FetchModelServerVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchProfilesRequest(ref FetchProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateOptimizedManifestRequest(ref GenerateOptimizedManifestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchBenchmarkingDataRequest(ref FetchBenchmarkingDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Fetches available models. Open-source models follow the Huggingface Hub
        /// `owner/model_name` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<FetchModelsResponse, string> FetchModels(FetchModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchModelsRequest, FetchModelsResponse, string>(_callFetchModels, request, callSettings);
        }

        /// <summary>
        /// Fetches available models. Open-source models follow the Huggingface Hub
        /// `owner/model_name` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchModelsResponse, string> FetchModelsAsync(FetchModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchModelsRequest, FetchModelsResponse, string>(_callFetchModels, request, callSettings);
        }

        /// <summary>
        /// Fetches available model servers. Open-source model servers use simplified,
        /// lowercase names (e.g., `vllm`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<FetchModelServersResponse, string> FetchModelServers(FetchModelServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchModelServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchModelServersRequest, FetchModelServersResponse, string>(_callFetchModelServers, request, callSettings);
        }

        /// <summary>
        /// Fetches available model servers. Open-source model servers use simplified,
        /// lowercase names (e.g., `vllm`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchModelServersResponse, string> FetchModelServersAsync(FetchModelServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchModelServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchModelServersRequest, FetchModelServersResponse, string>(_callFetchModelServers, request, callSettings);
        }

        /// <summary>
        /// Fetches available model server versions. Open-source servers use their own
        /// versioning schemas (e.g., `vllm` uses semver like `v1.0.0`).
        /// 
        /// Some model servers have different versioning schemas depending on the
        /// accelerator. For example, `vllm` uses semver on GPUs, but returns nightly
        /// build tags on TPUs. All available versions will be returned when different
        /// schemas are present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<FetchModelServerVersionsResponse, string> FetchModelServerVersions(FetchModelServerVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchModelServerVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchModelServerVersionsRequest, FetchModelServerVersionsResponse, string>(_callFetchModelServerVersions, request, callSettings);
        }

        /// <summary>
        /// Fetches available model server versions. Open-source servers use their own
        /// versioning schemas (e.g., `vllm` uses semver like `v1.0.0`).
        /// 
        /// Some model servers have different versioning schemas depending on the
        /// accelerator. For example, `vllm` uses semver on GPUs, but returns nightly
        /// build tags on TPUs. All available versions will be returned when different
        /// schemas are present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchModelServerVersionsResponse, string> FetchModelServerVersionsAsync(FetchModelServerVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchModelServerVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchModelServerVersionsRequest, FetchModelServerVersionsResponse, string>(_callFetchModelServerVersions, request, callSettings);
        }

        /// <summary>
        /// Fetches available profiles. A profile contains performance metrics and
        /// cost information for a specific model server setup. Profiles can be
        /// filtered by parameters. If no filters are provided, all profiles are
        /// returned.
        /// 
        /// Profiles display a single value per performance metric based on the
        /// provided performance requirements. If no requirements are given, the
        /// metrics represent the inflection point. See [Run best practice inference
        /// with GKE Inference Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart#how)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public override gax::PagedEnumerable<FetchProfilesResponse, Profile> FetchProfiles(FetchProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchProfilesRequest, FetchProfilesResponse, Profile>(_callFetchProfiles, request, callSettings);
        }

        /// <summary>
        /// Fetches available profiles. A profile contains performance metrics and
        /// cost information for a specific model server setup. Profiles can be
        /// filtered by parameters. If no filters are provided, all profiles are
        /// returned.
        /// 
        /// Profiles display a single value per performance metric based on the
        /// provided performance requirements. If no requirements are given, the
        /// metrics represent the inflection point. See [Run best practice inference
        /// with GKE Inference Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart#how)
        /// for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchProfilesResponse, Profile> FetchProfilesAsync(FetchProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchProfilesRequest, FetchProfilesResponse, Profile>(_callFetchProfiles, request, callSettings);
        }

        /// <summary>
        /// Generates an optimized deployment manifest for a given model and model
        /// server, based on the specified accelerator, performance targets, and
        /// configurations. See [Run best practice inference with GKE Inference
        /// Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart)
        /// for deployment details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateOptimizedManifestResponse GenerateOptimizedManifest(GenerateOptimizedManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateOptimizedManifestRequest(ref request, ref callSettings);
            return _callGenerateOptimizedManifest.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates an optimized deployment manifest for a given model and model
        /// server, based on the specified accelerator, performance targets, and
        /// configurations. See [Run best practice inference with GKE Inference
        /// Quickstart
        /// recipes](https://cloud.google.com/kubernetes-engine/docs/how-to/machine-learning/inference/inference-quickstart)
        /// for deployment details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateOptimizedManifestResponse> GenerateOptimizedManifestAsync(GenerateOptimizedManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateOptimizedManifestRequest(ref request, ref callSettings);
            return _callGenerateOptimizedManifest.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches all of the benchmarking data available for a profile. Benchmarking
        /// data returns all of the performance metrics available for a given model
        /// server setup on a given instance type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchBenchmarkingDataResponse FetchBenchmarkingData(FetchBenchmarkingDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchBenchmarkingDataRequest(ref request, ref callSettings);
            return _callFetchBenchmarkingData.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches all of the benchmarking data available for a profile. Benchmarking
        /// data returns all of the performance metrics available for a given model
        /// server setup on a given instance type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchBenchmarkingDataResponse> FetchBenchmarkingDataAsync(FetchBenchmarkingDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchBenchmarkingDataRequest(ref request, ref callSettings);
            return _callFetchBenchmarkingData.Async(request, callSettings);
        }
    }

    public partial class FetchModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchModelServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchModelServerVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchModelsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => Models.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchModelServersResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => ModelServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchModelServerVersionsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => ModelServerVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchProfilesResponse : gaxgrpc::IPageResponse<Profile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Profile> GetEnumerator() => Profile.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
