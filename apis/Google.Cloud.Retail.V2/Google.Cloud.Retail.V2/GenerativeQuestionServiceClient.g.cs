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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Retail.V2
{
    /// <summary>Settings for <see cref="GenerativeQuestionServiceClient"/> instances.</summary>
    public sealed partial class GenerativeQuestionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GenerativeQuestionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GenerativeQuestionServiceSettings"/>.</returns>
        public static GenerativeQuestionServiceSettings GetDefault() => new GenerativeQuestionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GenerativeQuestionServiceSettings"/> object with default settings.
        /// </summary>
        public GenerativeQuestionServiceSettings()
        {
        }

        private GenerativeQuestionServiceSettings(GenerativeQuestionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UpdateGenerativeQuestionsFeatureConfigSettings = existing.UpdateGenerativeQuestionsFeatureConfigSettings;
            GetGenerativeQuestionsFeatureConfigSettings = existing.GetGenerativeQuestionsFeatureConfigSettings;
            ListGenerativeQuestionConfigsSettings = existing.ListGenerativeQuestionConfigsSettings;
            UpdateGenerativeQuestionConfigSettings = existing.UpdateGenerativeQuestionConfigSettings;
            BatchUpdateGenerativeQuestionConfigsSettings = existing.BatchUpdateGenerativeQuestionConfigsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GenerativeQuestionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenerativeQuestionServiceClient.UpdateGenerativeQuestionsFeatureConfig</c> and
        /// <c>GenerativeQuestionServiceClient.UpdateGenerativeQuestionsFeatureConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGenerativeQuestionsFeatureConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenerativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfig</c> and
        /// <c>GenerativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGenerativeQuestionsFeatureConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenerativeQuestionServiceClient.ListGenerativeQuestionConfigs</c> and
        /// <c>GenerativeQuestionServiceClient.ListGenerativeQuestionConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGenerativeQuestionConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenerativeQuestionServiceClient.UpdateGenerativeQuestionConfig</c> and
        /// <c>GenerativeQuestionServiceClient.UpdateGenerativeQuestionConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGenerativeQuestionConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenerativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigs</c> and
        /// <c>GenerativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateGenerativeQuestionConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GenerativeQuestionServiceSettings"/> object.</returns>
        public GenerativeQuestionServiceSettings Clone() => new GenerativeQuestionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GenerativeQuestionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GenerativeQuestionServiceClientBuilder : gaxgrpc::ClientBuilderBase<GenerativeQuestionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GenerativeQuestionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GenerativeQuestionServiceClientBuilder() : base(GenerativeQuestionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GenerativeQuestionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GenerativeQuestionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GenerativeQuestionServiceClient Build()
        {
            GenerativeQuestionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GenerativeQuestionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GenerativeQuestionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GenerativeQuestionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GenerativeQuestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GenerativeQuestionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GenerativeQuestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GenerativeQuestionServiceClient.ChannelPool;
    }

    /// <summary>GenerativeQuestionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing LLM generated questions in search serving.
    /// </remarks>
    public abstract partial class GenerativeQuestionServiceClient
    {
        /// <summary>
        /// The default endpoint for the GenerativeQuestionService service, which is a host of "retail.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

        /// <summary>The default GenerativeQuestionService scopes.</summary>
        /// <remarks>
        /// The default GenerativeQuestionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GenerativeQuestionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GenerativeQuestionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GenerativeQuestionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GenerativeQuestionServiceClient"/>.</returns>
        public static stt::Task<GenerativeQuestionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GenerativeQuestionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GenerativeQuestionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GenerativeQuestionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GenerativeQuestionServiceClient"/>.</returns>
        public static GenerativeQuestionServiceClient Create() => new GenerativeQuestionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GenerativeQuestionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GenerativeQuestionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GenerativeQuestionServiceClient"/>.</returns>
        internal static GenerativeQuestionServiceClient Create(grpccore::CallInvoker callInvoker, GenerativeQuestionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GenerativeQuestionService.GenerativeQuestionServiceClient grpcClient = new GenerativeQuestionService.GenerativeQuestionServiceClient(callInvoker);
            return new GenerativeQuestionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GenerativeQuestionService client</summary>
        public virtual GenerativeQuestionService.GenerativeQuestionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerativeQuestionsFeatureConfig UpdateGenerativeQuestionsFeatureConfig(UpdateGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> UpdateGenerativeQuestionsFeatureConfigAsync(UpdateGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> UpdateGenerativeQuestionsFeatureConfigAsync(UpdateGenerativeQuestionsFeatureConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateGenerativeQuestionsFeatureConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="generativeQuestionsFeatureConfig">
        /// Required. The configuration managing the feature state.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [GenerativeQuestionsFeatureConfig][google.cloud.retail.v2.GenerativeQuestionsFeatureConfig]
        /// to update. If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerativeQuestionsFeatureConfig UpdateGenerativeQuestionsFeatureConfig(GenerativeQuestionsFeatureConfig generativeQuestionsFeatureConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGenerativeQuestionsFeatureConfig(new UpdateGenerativeQuestionsFeatureConfigRequest
            {
                GenerativeQuestionsFeatureConfig = gax::GaxPreconditions.CheckNotNull(generativeQuestionsFeatureConfig, nameof(generativeQuestionsFeatureConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="generativeQuestionsFeatureConfig">
        /// Required. The configuration managing the feature state.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [GenerativeQuestionsFeatureConfig][google.cloud.retail.v2.GenerativeQuestionsFeatureConfig]
        /// to update. If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> UpdateGenerativeQuestionsFeatureConfigAsync(GenerativeQuestionsFeatureConfig generativeQuestionsFeatureConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGenerativeQuestionsFeatureConfigAsync(new UpdateGenerativeQuestionsFeatureConfigRequest
            {
                GenerativeQuestionsFeatureConfig = gax::GaxPreconditions.CheckNotNull(generativeQuestionsFeatureConfig, nameof(generativeQuestionsFeatureConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="generativeQuestionsFeatureConfig">
        /// Required. The configuration managing the feature state.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [GenerativeQuestionsFeatureConfig][google.cloud.retail.v2.GenerativeQuestionsFeatureConfig]
        /// to update. If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> UpdateGenerativeQuestionsFeatureConfigAsync(GenerativeQuestionsFeatureConfig generativeQuestionsFeatureConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGenerativeQuestionsFeatureConfigAsync(generativeQuestionsFeatureConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerativeQuestionsFeatureConfig GetGenerativeQuestionsFeatureConfig(GetGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> GetGenerativeQuestionsFeatureConfigAsync(GetGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> GetGenerativeQuestionsFeatureConfigAsync(GetGenerativeQuestionsFeatureConfigRequest request, st::CancellationToken cancellationToken) =>
            GetGenerativeQuestionsFeatureConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="catalog">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerativeQuestionsFeatureConfig GetGenerativeQuestionsFeatureConfig(string catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetGenerativeQuestionsFeatureConfig(new GetGenerativeQuestionsFeatureConfigRequest
            {
                Catalog = gax::GaxPreconditions.CheckNotNullOrEmpty(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="catalog">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> GetGenerativeQuestionsFeatureConfigAsync(string catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetGenerativeQuestionsFeatureConfigAsync(new GetGenerativeQuestionsFeatureConfigRequest
            {
                Catalog = gax::GaxPreconditions.CheckNotNullOrEmpty(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="catalog">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> GetGenerativeQuestionsFeatureConfigAsync(string catalog, st::CancellationToken cancellationToken) =>
            GetGenerativeQuestionsFeatureConfigAsync(catalog, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="catalog">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerativeQuestionsFeatureConfig GetGenerativeQuestionsFeatureConfig(CatalogName catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetGenerativeQuestionsFeatureConfig(new GetGenerativeQuestionsFeatureConfigRequest
            {
                CatalogAsCatalogName = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="catalog">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> GetGenerativeQuestionsFeatureConfigAsync(CatalogName catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetGenerativeQuestionsFeatureConfigAsync(new GetGenerativeQuestionsFeatureConfigRequest
            {
                CatalogAsCatalogName = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="catalog">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionsFeatureConfig> GetGenerativeQuestionsFeatureConfigAsync(CatalogName catalog, st::CancellationToken cancellationToken) =>
            GetGenerativeQuestionsFeatureConfigAsync(catalog, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListGenerativeQuestionConfigsResponse ListGenerativeQuestionConfigs(ListGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListGenerativeQuestionConfigsResponse> ListGenerativeQuestionConfigsAsync(ListGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListGenerativeQuestionConfigsResponse> ListGenerativeQuestionConfigsAsync(ListGenerativeQuestionConfigsRequest request, st::CancellationToken cancellationToken) =>
            ListGenerativeQuestionConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListGenerativeQuestionConfigsResponse ListGenerativeQuestionConfigs(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListGenerativeQuestionConfigs(new ListGenerativeQuestionConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListGenerativeQuestionConfigsResponse> ListGenerativeQuestionConfigsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListGenerativeQuestionConfigsAsync(new ListGenerativeQuestionConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListGenerativeQuestionConfigsResponse> ListGenerativeQuestionConfigsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListGenerativeQuestionConfigsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListGenerativeQuestionConfigsResponse ListGenerativeQuestionConfigs(CatalogName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListGenerativeQuestionConfigs(new ListGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListGenerativeQuestionConfigsResponse> ListGenerativeQuestionConfigsAsync(CatalogName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListGenerativeQuestionConfigsAsync(new ListGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListGenerativeQuestionConfigsResponse> ListGenerativeQuestionConfigsAsync(CatalogName parent, st::CancellationToken cancellationToken) =>
            ListGenerativeQuestionConfigsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerativeQuestionConfig UpdateGenerativeQuestionConfig(UpdateGenerativeQuestionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionConfig> UpdateGenerativeQuestionConfigAsync(UpdateGenerativeQuestionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionConfig> UpdateGenerativeQuestionConfigAsync(UpdateGenerativeQuestionConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateGenerativeQuestionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="generativeQuestionConfig">
        /// Required. The question to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [GenerativeQuestionConfig][google.cloud.retail.v2.GenerativeQuestionConfig]
        /// to update. The following are NOT supported:
        /// 
        /// * [GenerativeQuestionConfig.frequency][google.cloud.retail.v2.GenerativeQuestionConfig.frequency]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerativeQuestionConfig UpdateGenerativeQuestionConfig(GenerativeQuestionConfig generativeQuestionConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGenerativeQuestionConfig(new UpdateGenerativeQuestionConfigRequest
            {
                GenerativeQuestionConfig = gax::GaxPreconditions.CheckNotNull(generativeQuestionConfig, nameof(generativeQuestionConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="generativeQuestionConfig">
        /// Required. The question to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [GenerativeQuestionConfig][google.cloud.retail.v2.GenerativeQuestionConfig]
        /// to update. The following are NOT supported:
        /// 
        /// * [GenerativeQuestionConfig.frequency][google.cloud.retail.v2.GenerativeQuestionConfig.frequency]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionConfig> UpdateGenerativeQuestionConfigAsync(GenerativeQuestionConfig generativeQuestionConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGenerativeQuestionConfigAsync(new UpdateGenerativeQuestionConfigRequest
            {
                GenerativeQuestionConfig = gax::GaxPreconditions.CheckNotNull(generativeQuestionConfig, nameof(generativeQuestionConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="generativeQuestionConfig">
        /// Required. The question to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [GenerativeQuestionConfig][google.cloud.retail.v2.GenerativeQuestionConfig]
        /// to update. The following are NOT supported:
        /// 
        /// * [GenerativeQuestionConfig.frequency][google.cloud.retail.v2.GenerativeQuestionConfig.frequency]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerativeQuestionConfig> UpdateGenerativeQuestionConfigAsync(GenerativeQuestionConfig generativeQuestionConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGenerativeQuestionConfigAsync(generativeQuestionConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateGenerativeQuestionConfigsResponse BatchUpdateGenerativeQuestionConfigs(BatchUpdateGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateGenerativeQuestionConfigsResponse> BatchUpdateGenerativeQuestionConfigsAsync(BatchUpdateGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateGenerativeQuestionConfigsResponse> BatchUpdateGenerativeQuestionConfigsAsync(BatchUpdateGenerativeQuestionConfigsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateGenerativeQuestionConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="parent">
        /// Optional. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="requests">
        /// Required. The updates question configs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateGenerativeQuestionConfigsResponse BatchUpdateGenerativeQuestionConfigs(string parent, scg::IEnumerable<UpdateGenerativeQuestionConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateGenerativeQuestionConfigs(new BatchUpdateGenerativeQuestionConfigsRequest
            {
                Parent = parent ?? "",
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="parent">
        /// Optional. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="requests">
        /// Required. The updates question configs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateGenerativeQuestionConfigsResponse> BatchUpdateGenerativeQuestionConfigsAsync(string parent, scg::IEnumerable<UpdateGenerativeQuestionConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateGenerativeQuestionConfigsAsync(new BatchUpdateGenerativeQuestionConfigsRequest
            {
                Parent = parent ?? "",
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="parent">
        /// Optional. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="requests">
        /// Required. The updates question configs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateGenerativeQuestionConfigsResponse> BatchUpdateGenerativeQuestionConfigsAsync(string parent, scg::IEnumerable<UpdateGenerativeQuestionConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateGenerativeQuestionConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="parent">
        /// Optional. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="requests">
        /// Required. The updates question configs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateGenerativeQuestionConfigsResponse BatchUpdateGenerativeQuestionConfigs(CatalogName parent, scg::IEnumerable<UpdateGenerativeQuestionConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateGenerativeQuestionConfigs(new BatchUpdateGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = parent,
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="parent">
        /// Optional. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="requests">
        /// Required. The updates question configs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateGenerativeQuestionConfigsResponse> BatchUpdateGenerativeQuestionConfigsAsync(CatalogName parent, scg::IEnumerable<UpdateGenerativeQuestionConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateGenerativeQuestionConfigsAsync(new BatchUpdateGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = parent,
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="parent">
        /// Optional. Resource name of the parent catalog.
        /// Format: projects/{project}/locations/{location}/catalogs/{catalog}
        /// </param>
        /// <param name="requests">
        /// Required. The updates question configs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateGenerativeQuestionConfigsResponse> BatchUpdateGenerativeQuestionConfigsAsync(CatalogName parent, scg::IEnumerable<UpdateGenerativeQuestionConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateGenerativeQuestionConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GenerativeQuestionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing LLM generated questions in search serving.
    /// </remarks>
    public sealed partial class GenerativeQuestionServiceClientImpl : GenerativeQuestionServiceClient
    {
        private readonly gaxgrpc::ApiCall<UpdateGenerativeQuestionsFeatureConfigRequest, GenerativeQuestionsFeatureConfig> _callUpdateGenerativeQuestionsFeatureConfig;

        private readonly gaxgrpc::ApiCall<GetGenerativeQuestionsFeatureConfigRequest, GenerativeQuestionsFeatureConfig> _callGetGenerativeQuestionsFeatureConfig;

        private readonly gaxgrpc::ApiCall<ListGenerativeQuestionConfigsRequest, ListGenerativeQuestionConfigsResponse> _callListGenerativeQuestionConfigs;

        private readonly gaxgrpc::ApiCall<UpdateGenerativeQuestionConfigRequest, GenerativeQuestionConfig> _callUpdateGenerativeQuestionConfig;

        private readonly gaxgrpc::ApiCall<BatchUpdateGenerativeQuestionConfigsRequest, BatchUpdateGenerativeQuestionConfigsResponse> _callBatchUpdateGenerativeQuestionConfigs;

        /// <summary>
        /// Constructs a client wrapper for the GenerativeQuestionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GenerativeQuestionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GenerativeQuestionServiceClientImpl(GenerativeQuestionService.GenerativeQuestionServiceClient grpcClient, GenerativeQuestionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GenerativeQuestionServiceSettings effectiveSettings = settings ?? GenerativeQuestionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callUpdateGenerativeQuestionsFeatureConfig = clientHelper.BuildApiCall<UpdateGenerativeQuestionsFeatureConfigRequest, GenerativeQuestionsFeatureConfig>("UpdateGenerativeQuestionsFeatureConfig", grpcClient.UpdateGenerativeQuestionsFeatureConfigAsync, grpcClient.UpdateGenerativeQuestionsFeatureConfig, effectiveSettings.UpdateGenerativeQuestionsFeatureConfigSettings).WithGoogleRequestParam("generative_questions_feature_config.catalog", request => request.GenerativeQuestionsFeatureConfig?.Catalog);
            Modify_ApiCall(ref _callUpdateGenerativeQuestionsFeatureConfig);
            Modify_UpdateGenerativeQuestionsFeatureConfigApiCall(ref _callUpdateGenerativeQuestionsFeatureConfig);
            _callGetGenerativeQuestionsFeatureConfig = clientHelper.BuildApiCall<GetGenerativeQuestionsFeatureConfigRequest, GenerativeQuestionsFeatureConfig>("GetGenerativeQuestionsFeatureConfig", grpcClient.GetGenerativeQuestionsFeatureConfigAsync, grpcClient.GetGenerativeQuestionsFeatureConfig, effectiveSettings.GetGenerativeQuestionsFeatureConfigSettings).WithGoogleRequestParam("catalog", request => request.Catalog);
            Modify_ApiCall(ref _callGetGenerativeQuestionsFeatureConfig);
            Modify_GetGenerativeQuestionsFeatureConfigApiCall(ref _callGetGenerativeQuestionsFeatureConfig);
            _callListGenerativeQuestionConfigs = clientHelper.BuildApiCall<ListGenerativeQuestionConfigsRequest, ListGenerativeQuestionConfigsResponse>("ListGenerativeQuestionConfigs", grpcClient.ListGenerativeQuestionConfigsAsync, grpcClient.ListGenerativeQuestionConfigs, effectiveSettings.ListGenerativeQuestionConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGenerativeQuestionConfigs);
            Modify_ListGenerativeQuestionConfigsApiCall(ref _callListGenerativeQuestionConfigs);
            _callUpdateGenerativeQuestionConfig = clientHelper.BuildApiCall<UpdateGenerativeQuestionConfigRequest, GenerativeQuestionConfig>("UpdateGenerativeQuestionConfig", grpcClient.UpdateGenerativeQuestionConfigAsync, grpcClient.UpdateGenerativeQuestionConfig, effectiveSettings.UpdateGenerativeQuestionConfigSettings).WithGoogleRequestParam("generative_question_config.catalog", request => request.GenerativeQuestionConfig?.Catalog);
            Modify_ApiCall(ref _callUpdateGenerativeQuestionConfig);
            Modify_UpdateGenerativeQuestionConfigApiCall(ref _callUpdateGenerativeQuestionConfig);
            _callBatchUpdateGenerativeQuestionConfigs = clientHelper.BuildApiCall<BatchUpdateGenerativeQuestionConfigsRequest, BatchUpdateGenerativeQuestionConfigsResponse>("BatchUpdateGenerativeQuestionConfigs", grpcClient.BatchUpdateGenerativeQuestionConfigsAsync, grpcClient.BatchUpdateGenerativeQuestionConfigs, effectiveSettings.BatchUpdateGenerativeQuestionConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateGenerativeQuestionConfigs);
            Modify_BatchUpdateGenerativeQuestionConfigsApiCall(ref _callBatchUpdateGenerativeQuestionConfigs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UpdateGenerativeQuestionsFeatureConfigApiCall(ref gaxgrpc::ApiCall<UpdateGenerativeQuestionsFeatureConfigRequest, GenerativeQuestionsFeatureConfig> call);

        partial void Modify_GetGenerativeQuestionsFeatureConfigApiCall(ref gaxgrpc::ApiCall<GetGenerativeQuestionsFeatureConfigRequest, GenerativeQuestionsFeatureConfig> call);

        partial void Modify_ListGenerativeQuestionConfigsApiCall(ref gaxgrpc::ApiCall<ListGenerativeQuestionConfigsRequest, ListGenerativeQuestionConfigsResponse> call);

        partial void Modify_UpdateGenerativeQuestionConfigApiCall(ref gaxgrpc::ApiCall<UpdateGenerativeQuestionConfigRequest, GenerativeQuestionConfig> call);

        partial void Modify_BatchUpdateGenerativeQuestionConfigsApiCall(ref gaxgrpc::ApiCall<BatchUpdateGenerativeQuestionConfigsRequest, BatchUpdateGenerativeQuestionConfigsResponse> call);

        partial void OnConstruction(GenerativeQuestionService.GenerativeQuestionServiceClient grpcClient, GenerativeQuestionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GenerativeQuestionService client</summary>
        public override GenerativeQuestionService.GenerativeQuestionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_UpdateGenerativeQuestionsFeatureConfigRequest(ref UpdateGenerativeQuestionsFeatureConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGenerativeQuestionsFeatureConfigRequest(ref GetGenerativeQuestionsFeatureConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGenerativeQuestionConfigsRequest(ref ListGenerativeQuestionConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGenerativeQuestionConfigRequest(ref UpdateGenerativeQuestionConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateGenerativeQuestionConfigsRequest(ref BatchUpdateGenerativeQuestionConfigsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerativeQuestionsFeatureConfig UpdateGenerativeQuestionsFeatureConfig(UpdateGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGenerativeQuestionsFeatureConfigRequest(ref request, ref callSettings);
            return _callUpdateGenerativeQuestionsFeatureConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerativeQuestionsFeatureConfig> UpdateGenerativeQuestionsFeatureConfigAsync(UpdateGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGenerativeQuestionsFeatureConfigRequest(ref request, ref callSettings);
            return _callUpdateGenerativeQuestionsFeatureConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerativeQuestionsFeatureConfig GetGenerativeQuestionsFeatureConfig(GetGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGenerativeQuestionsFeatureConfigRequest(ref request, ref callSettings);
            return _callGetGenerativeQuestionsFeatureConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Manages overal generative question feature state -- enables toggling
        /// feature on and off.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerativeQuestionsFeatureConfig> GetGenerativeQuestionsFeatureConfigAsync(GetGenerativeQuestionsFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGenerativeQuestionsFeatureConfigRequest(ref request, ref callSettings);
            return _callGetGenerativeQuestionsFeatureConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListGenerativeQuestionConfigsResponse ListGenerativeQuestionConfigs(ListGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGenerativeQuestionConfigsRequest(ref request, ref callSettings);
            return _callListGenerativeQuestionConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns all questions for a given catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListGenerativeQuestionConfigsResponse> ListGenerativeQuestionConfigsAsync(ListGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGenerativeQuestionConfigsRequest(ref request, ref callSettings);
            return _callListGenerativeQuestionConfigs.Async(request, callSettings);
        }

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerativeQuestionConfig UpdateGenerativeQuestionConfig(UpdateGenerativeQuestionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGenerativeQuestionConfigRequest(ref request, ref callSettings);
            return _callUpdateGenerativeQuestionConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Allows management of individual questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerativeQuestionConfig> UpdateGenerativeQuestionConfigAsync(UpdateGenerativeQuestionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGenerativeQuestionConfigRequest(ref request, ref callSettings);
            return _callUpdateGenerativeQuestionConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateGenerativeQuestionConfigsResponse BatchUpdateGenerativeQuestionConfigs(BatchUpdateGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateGenerativeQuestionConfigsRequest(ref request, ref callSettings);
            return _callBatchUpdateGenerativeQuestionConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Allows management of multiple questions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateGenerativeQuestionConfigsResponse> BatchUpdateGenerativeQuestionConfigsAsync(BatchUpdateGenerativeQuestionConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateGenerativeQuestionConfigsRequest(ref request, ref callSettings);
            return _callBatchUpdateGenerativeQuestionConfigs.Async(request, callSettings);
        }
    }

    public static partial class GenerativeQuestionService
    {
        public partial class GenerativeQuestionServiceClient
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
