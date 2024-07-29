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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="ExtensionRegistryServiceClient"/> instances.</summary>
    public sealed partial class ExtensionRegistryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExtensionRegistryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExtensionRegistryServiceSettings"/>.</returns>
        public static ExtensionRegistryServiceSettings GetDefault() => new ExtensionRegistryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ExtensionRegistryServiceSettings"/> object with default settings.
        /// </summary>
        public ExtensionRegistryServiceSettings()
        {
        }

        private ExtensionRegistryServiceSettings(ExtensionRegistryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ImportExtensionSettings = existing.ImportExtensionSettings;
            ImportExtensionOperationsSettings = existing.ImportExtensionOperationsSettings.Clone();
            GetExtensionSettings = existing.GetExtensionSettings;
            ListExtensionsSettings = existing.ListExtensionsSettings;
            UpdateExtensionSettings = existing.UpdateExtensionSettings;
            DeleteExtensionSettings = existing.DeleteExtensionSettings;
            DeleteExtensionOperationsSettings = existing.DeleteExtensionOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExtensionRegistryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionRegistryServiceClient.ImportExtension</c> and
        /// <c>ExtensionRegistryServiceClient.ImportExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ExtensionRegistryServiceClient.ImportExtension</c> and
        /// <c>ExtensionRegistryServiceClient.ImportExtensionAsync</c>.
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
        public lro::OperationsSettings ImportExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionRegistryServiceClient.GetExtension</c> and <c>ExtensionRegistryServiceClient.GetExtensionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionRegistryServiceClient.ListExtensions</c> and
        /// <c>ExtensionRegistryServiceClient.ListExtensionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExtensionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionRegistryServiceClient.UpdateExtension</c> and
        /// <c>ExtensionRegistryServiceClient.UpdateExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionRegistryServiceClient.DeleteExtension</c> and
        /// <c>ExtensionRegistryServiceClient.DeleteExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ExtensionRegistryServiceClient.DeleteExtension</c> and
        /// <c>ExtensionRegistryServiceClient.DeleteExtensionAsync</c>.
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
        public lro::OperationsSettings DeleteExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExtensionRegistryServiceSettings"/> object.</returns>
        public ExtensionRegistryServiceSettings Clone() => new ExtensionRegistryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExtensionRegistryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ExtensionRegistryServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExtensionRegistryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExtensionRegistryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExtensionRegistryServiceClientBuilder() : base(ExtensionRegistryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExtensionRegistryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExtensionRegistryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExtensionRegistryServiceClient Build()
        {
            ExtensionRegistryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExtensionRegistryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExtensionRegistryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExtensionRegistryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExtensionRegistryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExtensionRegistryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExtensionRegistryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExtensionRegistryServiceClient.ChannelPool;
    }

    /// <summary>ExtensionRegistryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's Extension registry.
    /// </remarks>
    public abstract partial class ExtensionRegistryServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExtensionRegistryService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ExtensionRegistryService scopes.</summary>
        /// <remarks>
        /// The default ExtensionRegistryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ExtensionRegistryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExtensionRegistryServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ExtensionRegistryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExtensionRegistryServiceClient"/>.</returns>
        public static stt::Task<ExtensionRegistryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExtensionRegistryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExtensionRegistryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ExtensionRegistryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExtensionRegistryServiceClient"/>.</returns>
        public static ExtensionRegistryServiceClient Create() => new ExtensionRegistryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExtensionRegistryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExtensionRegistryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExtensionRegistryServiceClient"/>.</returns>
        internal static ExtensionRegistryServiceClient Create(grpccore::CallInvoker callInvoker, ExtensionRegistryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExtensionRegistryService.ExtensionRegistryServiceClient grpcClient = new ExtensionRegistryService.ExtensionRegistryServiceClient(callInvoker);
            return new ExtensionRegistryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ExtensionRegistryService client</summary>
        public virtual ExtensionRegistryService.ExtensionRegistryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Extension, ImportExtensionOperationMetadata> ImportExtension(ImportExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> ImportExtensionAsync(ImportExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> ImportExtensionAsync(ImportExtensionRequest request, st::CancellationToken cancellationToken) =>
            ImportExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportExtension</c>.</summary>
        public virtual lro::OperationsClient ImportExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Extension, ImportExtensionOperationMetadata> PollOnceImportExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Extension, ImportExtensionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> PollOnceImportExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Extension, ImportExtensionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportExtensionOperationsClient, callSettings);

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to import the Extension in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="extension">
        /// Required. The Extension to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Extension, ImportExtensionOperationMetadata> ImportExtension(string parent, Extension extension, gaxgrpc::CallSettings callSettings = null) =>
            ImportExtension(new ImportExtensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Extension = gax::GaxPreconditions.CheckNotNull(extension, nameof(extension)),
            }, callSettings);

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to import the Extension in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="extension">
        /// Required. The Extension to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> ImportExtensionAsync(string parent, Extension extension, gaxgrpc::CallSettings callSettings = null) =>
            ImportExtensionAsync(new ImportExtensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Extension = gax::GaxPreconditions.CheckNotNull(extension, nameof(extension)),
            }, callSettings);

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to import the Extension in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="extension">
        /// Required. The Extension to import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> ImportExtensionAsync(string parent, Extension extension, st::CancellationToken cancellationToken) =>
            ImportExtensionAsync(parent, extension, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to import the Extension in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="extension">
        /// Required. The Extension to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Extension, ImportExtensionOperationMetadata> ImportExtension(gagr::LocationName parent, Extension extension, gaxgrpc::CallSettings callSettings = null) =>
            ImportExtension(new ImportExtensionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Extension = gax::GaxPreconditions.CheckNotNull(extension, nameof(extension)),
            }, callSettings);

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to import the Extension in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="extension">
        /// Required. The Extension to import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> ImportExtensionAsync(gagr::LocationName parent, Extension extension, gaxgrpc::CallSettings callSettings = null) =>
            ImportExtensionAsync(new ImportExtensionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Extension = gax::GaxPreconditions.CheckNotNull(extension, nameof(extension)),
            }, callSettings);

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to import the Extension in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="extension">
        /// Required. The Extension to import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> ImportExtensionAsync(gagr::LocationName parent, Extension extension, st::CancellationToken cancellationToken) =>
            ImportExtensionAsync(parent, extension, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Extension GetExtension(GetExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> GetExtensionAsync(GetExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> GetExtensionAsync(GetExtensionRequest request, st::CancellationToken cancellationToken) =>
            GetExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Extension GetExtension(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExtension(new GetExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> GetExtensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExtensionAsync(new GetExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> GetExtensionAsync(string name, st::CancellationToken cancellationToken) =>
            GetExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Extension GetExtension(ExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExtension(new GetExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> GetExtensionAsync(ExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExtensionAsync(new GetExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> GetExtensionAsync(ExtensionName name, st::CancellationToken cancellationToken) =>
            GetExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Extension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExtensionsResponse, Extension> ListExtensions(ListExtensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Extension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExtensionsResponse, Extension> ListExtensionsAsync(ListExtensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Extensions from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Extension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExtensionsResponse, Extension> ListExtensions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExtensionsRequest request = new ListExtensionsRequest
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
            return ListExtensions(request, callSettings);
        }

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Extensions from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Extension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExtensionsResponse, Extension> ListExtensionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExtensionsRequest request = new ListExtensionsRequest
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
            return ListExtensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Extensions from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Extension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExtensionsResponse, Extension> ListExtensions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExtensionsRequest request = new ListExtensionsRequest
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
            return ListExtensions(request, callSettings);
        }

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Extensions from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Extension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExtensionsResponse, Extension> ListExtensionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExtensionsRequest request = new ListExtensionsRequest
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
            return ListExtensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Extension UpdateExtension(UpdateExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> UpdateExtensionAsync(UpdateExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> UpdateExtensionAsync(UpdateExtensionRequest request, st::CancellationToken cancellationToken) =>
            UpdateExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="extension">
        /// Required. The Extension which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `runtime_config`
        /// * `tool_use_examples`
        /// * `manifest.description`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Extension UpdateExtension(Extension extension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExtension(new UpdateExtensionRequest
            {
                Extension = gax::GaxPreconditions.CheckNotNull(extension, nameof(extension)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="extension">
        /// Required. The Extension which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `runtime_config`
        /// * `tool_use_examples`
        /// * `manifest.description`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> UpdateExtensionAsync(Extension extension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExtensionAsync(new UpdateExtensionRequest
            {
                Extension = gax::GaxPreconditions.CheckNotNull(extension, nameof(extension)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="extension">
        /// Required. The Extension which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `runtime_config`
        /// * `tool_use_examples`
        /// * `manifest.description`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Extension> UpdateExtensionAsync(Extension extension, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExtensionAsync(extension, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExtension(DeleteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExtensionAsync(DeleteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExtensionAsync(DeleteExtensionRequest request, st::CancellationToken cancellationToken) =>
            DeleteExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteExtension</c>.</summary>
        public virtual lro::OperationsClient DeleteExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExtension(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExtension(new DeleteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExtensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExtensionAsync(new DeleteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExtensionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExtension(ExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExtension(new DeleteExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExtensionAsync(ExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExtensionAsync(new DeleteExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Extension resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExtensionAsync(ExtensionName name, st::CancellationToken cancellationToken) =>
            DeleteExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ExtensionRegistryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's Extension registry.
    /// </remarks>
    public sealed partial class ExtensionRegistryServiceClientImpl : ExtensionRegistryServiceClient
    {
        private readonly gaxgrpc::ApiCall<ImportExtensionRequest, lro::Operation> _callImportExtension;

        private readonly gaxgrpc::ApiCall<GetExtensionRequest, Extension> _callGetExtension;

        private readonly gaxgrpc::ApiCall<ListExtensionsRequest, ListExtensionsResponse> _callListExtensions;

        private readonly gaxgrpc::ApiCall<UpdateExtensionRequest, Extension> _callUpdateExtension;

        private readonly gaxgrpc::ApiCall<DeleteExtensionRequest, lro::Operation> _callDeleteExtension;

        /// <summary>
        /// Constructs a client wrapper for the ExtensionRegistryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ExtensionRegistryServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExtensionRegistryServiceClientImpl(ExtensionRegistryService.ExtensionRegistryServiceClient grpcClient, ExtensionRegistryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExtensionRegistryServiceSettings effectiveSettings = settings ?? ExtensionRegistryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ImportExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportExtensionOperationsSettings, logger);
            DeleteExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteExtensionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callImportExtension = clientHelper.BuildApiCall<ImportExtensionRequest, lro::Operation>("ImportExtension", grpcClient.ImportExtensionAsync, grpcClient.ImportExtension, effectiveSettings.ImportExtensionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportExtension);
            Modify_ImportExtensionApiCall(ref _callImportExtension);
            _callGetExtension = clientHelper.BuildApiCall<GetExtensionRequest, Extension>("GetExtension", grpcClient.GetExtensionAsync, grpcClient.GetExtension, effectiveSettings.GetExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExtension);
            Modify_GetExtensionApiCall(ref _callGetExtension);
            _callListExtensions = clientHelper.BuildApiCall<ListExtensionsRequest, ListExtensionsResponse>("ListExtensions", grpcClient.ListExtensionsAsync, grpcClient.ListExtensions, effectiveSettings.ListExtensionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExtensions);
            Modify_ListExtensionsApiCall(ref _callListExtensions);
            _callUpdateExtension = clientHelper.BuildApiCall<UpdateExtensionRequest, Extension>("UpdateExtension", grpcClient.UpdateExtensionAsync, grpcClient.UpdateExtension, effectiveSettings.UpdateExtensionSettings).WithGoogleRequestParam("extension.name", request => request.Extension?.Name);
            Modify_ApiCall(ref _callUpdateExtension);
            Modify_UpdateExtensionApiCall(ref _callUpdateExtension);
            _callDeleteExtension = clientHelper.BuildApiCall<DeleteExtensionRequest, lro::Operation>("DeleteExtension", grpcClient.DeleteExtensionAsync, grpcClient.DeleteExtension, effectiveSettings.DeleteExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExtension);
            Modify_DeleteExtensionApiCall(ref _callDeleteExtension);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ImportExtensionApiCall(ref gaxgrpc::ApiCall<ImportExtensionRequest, lro::Operation> call);

        partial void Modify_GetExtensionApiCall(ref gaxgrpc::ApiCall<GetExtensionRequest, Extension> call);

        partial void Modify_ListExtensionsApiCall(ref gaxgrpc::ApiCall<ListExtensionsRequest, ListExtensionsResponse> call);

        partial void Modify_UpdateExtensionApiCall(ref gaxgrpc::ApiCall<UpdateExtensionRequest, Extension> call);

        partial void Modify_DeleteExtensionApiCall(ref gaxgrpc::ApiCall<DeleteExtensionRequest, lro::Operation> call);

        partial void OnConstruction(ExtensionRegistryService.ExtensionRegistryServiceClient grpcClient, ExtensionRegistryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExtensionRegistryService client</summary>
        public override ExtensionRegistryService.ExtensionRegistryServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ImportExtensionRequest(ref ImportExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExtensionRequest(ref GetExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExtensionsRequest(ref ListExtensionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExtensionRequest(ref UpdateExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExtensionRequest(ref DeleteExtensionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>ImportExtension</c>.</summary>
        public override lro::OperationsClient ImportExtensionOperationsClient { get; }

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Extension, ImportExtensionOperationMetadata> ImportExtension(ImportExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<Extension, ImportExtensionOperationMetadata>(_callImportExtension.Sync(request, callSettings), ImportExtensionOperationsClient);
        }

        /// <summary>
        /// Imports an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Extension, ImportExtensionOperationMetadata>> ImportExtensionAsync(ImportExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<Extension, ImportExtensionOperationMetadata>(await _callImportExtension.Async(request, callSettings).ConfigureAwait(false), ImportExtensionOperationsClient);
        }

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Extension GetExtension(GetExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExtensionRequest(ref request, ref callSettings);
            return _callGetExtension.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Extension> GetExtensionAsync(GetExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExtensionRequest(ref request, ref callSettings);
            return _callGetExtension.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Extension"/> resources.</returns>
        public override gax::PagedEnumerable<ListExtensionsResponse, Extension> ListExtensions(ListExtensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExtensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExtensionsRequest, ListExtensionsResponse, Extension>(_callListExtensions, request, callSettings);
        }

        /// <summary>
        /// Lists Extensions in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Extension"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExtensionsResponse, Extension> ListExtensionsAsync(ListExtensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExtensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExtensionsRequest, ListExtensionsResponse, Extension>(_callListExtensions, request, callSettings);
        }

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Extension UpdateExtension(UpdateExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExtensionRequest(ref request, ref callSettings);
            return _callUpdateExtension.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Extension> UpdateExtensionAsync(UpdateExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExtensionRequest(ref request, ref callSettings);
            return _callUpdateExtension.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteExtension</c>.</summary>
        public override lro::OperationsClient DeleteExtensionOperationsClient { get; }

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteExtension(DeleteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteExtension.Sync(request, callSettings), DeleteExtensionOperationsClient);
        }

        /// <summary>
        /// Deletes an Extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteExtensionAsync(DeleteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteExtension.Async(request, callSettings).ConfigureAwait(false), DeleteExtensionOperationsClient);
        }
    }

    public partial class ListExtensionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExtensionsResponse : gaxgrpc::IPageResponse<Extension>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Extension> GetEnumerator() => Extensions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ExtensionRegistryService
    {
        public partial class ExtensionRegistryServiceClient
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

    public static partial class ExtensionRegistryService
    {
        public partial class ExtensionRegistryServiceClient
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
