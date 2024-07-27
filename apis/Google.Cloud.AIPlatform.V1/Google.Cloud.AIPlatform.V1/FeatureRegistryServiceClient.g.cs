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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="FeatureRegistryServiceClient"/> instances.</summary>
    public sealed partial class FeatureRegistryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeatureRegistryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeatureRegistryServiceSettings"/>.</returns>
        public static FeatureRegistryServiceSettings GetDefault() => new FeatureRegistryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeatureRegistryServiceSettings"/> object with default settings.
        /// </summary>
        public FeatureRegistryServiceSettings()
        {
        }

        private FeatureRegistryServiceSettings(FeatureRegistryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateFeatureGroupSettings = existing.CreateFeatureGroupSettings;
            CreateFeatureGroupOperationsSettings = existing.CreateFeatureGroupOperationsSettings.Clone();
            GetFeatureGroupSettings = existing.GetFeatureGroupSettings;
            ListFeatureGroupsSettings = existing.ListFeatureGroupsSettings;
            UpdateFeatureGroupSettings = existing.UpdateFeatureGroupSettings;
            UpdateFeatureGroupOperationsSettings = existing.UpdateFeatureGroupOperationsSettings.Clone();
            DeleteFeatureGroupSettings = existing.DeleteFeatureGroupSettings;
            DeleteFeatureGroupOperationsSettings = existing.DeleteFeatureGroupOperationsSettings.Clone();
            CreateFeatureSettings = existing.CreateFeatureSettings;
            CreateFeatureOperationsSettings = existing.CreateFeatureOperationsSettings.Clone();
            GetFeatureSettings = existing.GetFeatureSettings;
            ListFeaturesSettings = existing.ListFeaturesSettings;
            UpdateFeatureSettings = existing.UpdateFeatureSettings;
            UpdateFeatureOperationsSettings = existing.UpdateFeatureOperationsSettings.Clone();
            DeleteFeatureSettings = existing.DeleteFeatureSettings;
            DeleteFeatureOperationsSettings = existing.DeleteFeatureOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeatureRegistryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.CreateFeatureGroup</c> and
        /// <c>FeatureRegistryServiceClient.CreateFeatureGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeatureGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureRegistryServiceClient.CreateFeatureGroup</c> and
        /// <c>FeatureRegistryServiceClient.CreateFeatureGroupAsync</c>.
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
        public lro::OperationsSettings CreateFeatureGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.GetFeatureGroup</c> and <c>FeatureRegistryServiceClient.GetFeatureGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeatureGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.ListFeatureGroups</c> and
        /// <c>FeatureRegistryServiceClient.ListFeatureGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeatureGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.UpdateFeatureGroup</c> and
        /// <c>FeatureRegistryServiceClient.UpdateFeatureGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeatureGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureRegistryServiceClient.UpdateFeatureGroup</c> and
        /// <c>FeatureRegistryServiceClient.UpdateFeatureGroupAsync</c>.
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
        public lro::OperationsSettings UpdateFeatureGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.DeleteFeatureGroup</c> and
        /// <c>FeatureRegistryServiceClient.DeleteFeatureGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeatureGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureRegistryServiceClient.DeleteFeatureGroup</c> and
        /// <c>FeatureRegistryServiceClient.DeleteFeatureGroupAsync</c>.
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
        public lro::OperationsSettings DeleteFeatureGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.CreateFeature</c> and <c>FeatureRegistryServiceClient.CreateFeatureAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureRegistryServiceClient.CreateFeature</c> and
        /// <c>FeatureRegistryServiceClient.CreateFeatureAsync</c>.
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
        public lro::OperationsSettings CreateFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.GetFeature</c> and <c>FeatureRegistryServiceClient.GetFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.ListFeatures</c> and <c>FeatureRegistryServiceClient.ListFeaturesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeaturesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.UpdateFeature</c> and <c>FeatureRegistryServiceClient.UpdateFeatureAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureRegistryServiceClient.UpdateFeature</c> and
        /// <c>FeatureRegistryServiceClient.UpdateFeatureAsync</c>.
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
        public lro::OperationsSettings UpdateFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureRegistryServiceClient.DeleteFeature</c> and <c>FeatureRegistryServiceClient.DeleteFeatureAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeatureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureRegistryServiceClient.DeleteFeature</c> and
        /// <c>FeatureRegistryServiceClient.DeleteFeatureAsync</c>.
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
        public lro::OperationsSettings DeleteFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="FeatureRegistryServiceSettings"/> object.</returns>
        public FeatureRegistryServiceSettings Clone() => new FeatureRegistryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeatureRegistryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class FeatureRegistryServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeatureRegistryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeatureRegistryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeatureRegistryServiceClientBuilder() : base(FeatureRegistryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeatureRegistryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeatureRegistryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeatureRegistryServiceClient Build()
        {
            FeatureRegistryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeatureRegistryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeatureRegistryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeatureRegistryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeatureRegistryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FeatureRegistryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeatureRegistryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeatureRegistryServiceClient.ChannelPool;
    }

    /// <summary>FeatureRegistryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that handles CRUD and List for resources for
    /// FeatureRegistry.
    /// </remarks>
    public abstract partial class FeatureRegistryServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeatureRegistryService service, which is a host of "aiplatform.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default FeatureRegistryService scopes.</summary>
        /// <remarks>
        /// The default FeatureRegistryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeatureRegistryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeatureRegistryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="FeatureRegistryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeatureRegistryServiceClient"/>.</returns>
        public static stt::Task<FeatureRegistryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeatureRegistryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeatureRegistryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="FeatureRegistryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeatureRegistryServiceClient"/>.</returns>
        public static FeatureRegistryServiceClient Create() => new FeatureRegistryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeatureRegistryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeatureRegistryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeatureRegistryServiceClient"/>.</returns>
        internal static FeatureRegistryServiceClient Create(grpccore::CallInvoker callInvoker, FeatureRegistryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeatureRegistryService.FeatureRegistryServiceClient grpcClient = new FeatureRegistryService.FeatureRegistryServiceClient(callInvoker);
            return new FeatureRegistryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeatureRegistryService client</summary>
        public virtual FeatureRegistryService.FeatureRegistryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> CreateFeatureGroup(CreateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> CreateFeatureGroupAsync(CreateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> CreateFeatureGroupAsync(CreateFeatureGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateFeatureGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFeatureGroup</c>.</summary>
        public virtual lro::OperationsClient CreateFeatureGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFeatureGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> PollOnceCreateFeatureGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeatureGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> PollOnceCreateFeatureGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup to create.
        /// </param>
        /// <param name="featureGroupId">
        /// Required. The ID to use for this FeatureGroup, which will become the final
        /// component of the FeatureGroup's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> CreateFeatureGroup(string parent, FeatureGroup featureGroup, string featureGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureGroup(new CreateFeatureGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeatureGroup = gax::GaxPreconditions.CheckNotNull(featureGroup, nameof(featureGroup)),
                FeatureGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup to create.
        /// </param>
        /// <param name="featureGroupId">
        /// Required. The ID to use for this FeatureGroup, which will become the final
        /// component of the FeatureGroup's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> CreateFeatureGroupAsync(string parent, FeatureGroup featureGroup, string featureGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureGroupAsync(new CreateFeatureGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeatureGroup = gax::GaxPreconditions.CheckNotNull(featureGroup, nameof(featureGroup)),
                FeatureGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup to create.
        /// </param>
        /// <param name="featureGroupId">
        /// Required. The ID to use for this FeatureGroup, which will become the final
        /// component of the FeatureGroup's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> CreateFeatureGroupAsync(string parent, FeatureGroup featureGroup, string featureGroupId, st::CancellationToken cancellationToken) =>
            CreateFeatureGroupAsync(parent, featureGroup, featureGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup to create.
        /// </param>
        /// <param name="featureGroupId">
        /// Required. The ID to use for this FeatureGroup, which will become the final
        /// component of the FeatureGroup's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> CreateFeatureGroup(gagr::LocationName parent, FeatureGroup featureGroup, string featureGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureGroup(new CreateFeatureGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeatureGroup = gax::GaxPreconditions.CheckNotNull(featureGroup, nameof(featureGroup)),
                FeatureGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup to create.
        /// </param>
        /// <param name="featureGroupId">
        /// Required. The ID to use for this FeatureGroup, which will become the final
        /// component of the FeatureGroup's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> CreateFeatureGroupAsync(gagr::LocationName parent, FeatureGroup featureGroup, string featureGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureGroupAsync(new CreateFeatureGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeatureGroup = gax::GaxPreconditions.CheckNotNull(featureGroup, nameof(featureGroup)),
                FeatureGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup to create.
        /// </param>
        /// <param name="featureGroupId">
        /// Required. The ID to use for this FeatureGroup, which will become the final
        /// component of the FeatureGroup's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> CreateFeatureGroupAsync(gagr::LocationName parent, FeatureGroup featureGroup, string featureGroupId, st::CancellationToken cancellationToken) =>
            CreateFeatureGroupAsync(parent, featureGroup, featureGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureGroup GetFeatureGroup(GetFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureGroup> GetFeatureGroupAsync(GetFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureGroup> GetFeatureGroupAsync(GetFeatureGroupRequest request, st::CancellationToken cancellationToken) =>
            GetFeatureGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureGroup GetFeatureGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureGroup(new GetFeatureGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureGroup> GetFeatureGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureGroupAsync(new GetFeatureGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureGroup> GetFeatureGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureGroup GetFeatureGroup(FeatureGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureGroup(new GetFeatureGroupRequest
            {
                FeatureGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureGroup> GetFeatureGroupAsync(FeatureGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureGroupAsync(new GetFeatureGroupRequest
            {
                FeatureGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureGroup> GetFeatureGroupAsync(FeatureGroupName name, st::CancellationToken cancellationToken) =>
            GetFeatureGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroups(ListFeatureGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroupsAsync(ListFeatureGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="FeatureGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeatureGroupsRequest request = new ListFeatureGroupsRequest
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
            return ListFeatureGroups(request, callSettings);
        }

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeatureGroupsRequest request = new ListFeatureGroupsRequest
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
            return ListFeatureGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="FeatureGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeatureGroupsRequest request = new ListFeatureGroupsRequest
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
            return ListFeatureGroups(request, callSettings);
        }

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureGroups.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeatureGroupsRequest request = new ListFeatureGroupsRequest
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
            return ListFeatureGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> UpdateFeatureGroup(UpdateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>> UpdateFeatureGroupAsync(UpdateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>> UpdateFeatureGroupAsync(UpdateFeatureGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeatureGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFeatureGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateFeatureGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFeatureGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> PollOnceUpdateFeatureGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeatureGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>> PollOnceUpdateFeatureGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup's `name` field is used to identify the
        /// FeatureGroup to be updated. Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `description`
        /// * `big_query`
        /// * `big_query.entity_id_columns`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> UpdateFeatureGroup(FeatureGroup featureGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureGroup(new UpdateFeatureGroupRequest
            {
                FeatureGroup = gax::GaxPreconditions.CheckNotNull(featureGroup, nameof(featureGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup's `name` field is used to identify the
        /// FeatureGroup to be updated. Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `description`
        /// * `big_query`
        /// * `big_query.entity_id_columns`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>> UpdateFeatureGroupAsync(FeatureGroup featureGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureGroupAsync(new UpdateFeatureGroupRequest
            {
                FeatureGroup = gax::GaxPreconditions.CheckNotNull(featureGroup, nameof(featureGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="featureGroup">
        /// Required. The FeatureGroup's `name` field is used to identify the
        /// FeatureGroup to be updated. Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `description`
        /// * `big_query`
        /// * `big_query.entity_id_columns`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>> UpdateFeatureGroupAsync(FeatureGroup featureGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureGroupAsync(featureGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureGroup(DeleteFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureGroupAsync(DeleteFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureGroupAsync(DeleteFeatureGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeatureGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeatureGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteFeatureGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFeatureGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteFeatureGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeatureGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteFeatureGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features under this FeatureGroup
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureGroup has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureGroup(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureGroup(new DeleteFeatureGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features under this FeatureGroup
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureGroup has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureGroupAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureGroupAsync(new DeleteFeatureGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features under this FeatureGroup
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureGroup has no Features.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureGroupAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteFeatureGroupAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features under this FeatureGroup
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureGroup has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureGroup(FeatureGroupName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureGroup(new DeleteFeatureGroupRequest
            {
                FeatureGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features under this FeatureGroup
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureGroup has no Features.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureGroupAsync(FeatureGroupName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureGroupAsync(new DeleteFeatureGroupRequest
            {
                FeatureGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureGroup to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="force">
        /// If set to true, any Features under this FeatureGroup
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureGroup has no Features.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureGroupAsync(FeatureGroupName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteFeatureGroupAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFeature</c>.</summary>
        public virtual lro::OperationsClient CreateFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> PollOnceCreateFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, CreateFeatureOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> PollOnceCreateFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, CreateFeatureOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(string parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(string parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(string parent, Feature feature, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(EntityTypeName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(EntityTypeName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(EntityTypeName parent, Feature feature, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(FeatureGroupName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(FeatureGroupName parent, Feature feature, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                FeatureId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntityType or FeatureGroup to create a
        /// Feature. Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="feature">
        /// Required. The Feature to create.
        /// </param>
        /// <param name="featureId">
        /// Required. The ID to use for the Feature, which will become the final
        /// component of the Feature's resource name.
        /// 
        /// This value may be up to 128 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within an EntityType/FeatureGroup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(FeatureGroupName parent, Feature feature, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, feature, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeature(new GetFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureAsync(new GetFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeature(new GetFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureAsync(new GetFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feature resource.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(FeatureName name, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
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
            return ListFeatures(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
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
            return ListFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(EntityTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeatures(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(EntityTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(FeatureGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeatures(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Features.
        /// Format for entity_type as parent:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}`
        /// Format for feature_group as parent:
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(FeatureGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsFeatureGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeaturesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, UpdateFeatureOperationMetadata> UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, UpdateFeatureOperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, UpdateFeatureOperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFeature</c>.</summary>
        public virtual lro::OperationsClient UpdateFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Feature, UpdateFeatureOperationMetadata> PollOnceUpdateFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, UpdateFeatureOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Feature, UpdateFeatureOperationMetadata>> PollOnceUpdateFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, UpdateFeatureOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="feature">
        /// Required. The Feature's `name` field is used to identify the Feature to be
        /// updated.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Features resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `disable_monitoring` (Not supported for FeatureRegistryService Feature)
        /// * `point_of_contact` (Not supported for FeaturestoreService FeatureStore)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, UpdateFeatureOperationMetadata> UpdateFeature(Feature feature, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeature(new UpdateFeatureRequest
            {
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="feature">
        /// Required. The Feature's `name` field is used to identify the Feature to be
        /// updated.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Features resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `disable_monitoring` (Not supported for FeatureRegistryService Feature)
        /// * `point_of_contact` (Not supported for FeaturestoreService FeatureStore)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, UpdateFeatureOperationMetadata>> UpdateFeatureAsync(Feature feature, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureAsync(new UpdateFeatureRequest
            {
                Feature = gax::GaxPreconditions.CheckNotNull(feature, nameof(feature)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="feature">
        /// Required. The Feature's `name` field is used to identify the Feature to be
        /// updated.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Features resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `description`
        /// * `labels`
        /// * `disable_monitoring` (Not supported for FeatureRegistryService Feature)
        /// * `point_of_contact` (Not supported for FeaturestoreService FeatureStore)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, UpdateFeatureOperationMetadata>> UpdateFeatureAsync(Feature feature, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(feature, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeature</c>.</summary>
        public virtual lro::OperationsClient DeleteFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeature(new DeleteFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureAsync(new DeleteFeatureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeature(new DeleteFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(FeatureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureAsync(new DeleteFeatureRequest
            {
                FeatureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Features to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entity_type}/features/{feature}`
        /// `projects/{project}/locations/{location}/featureGroups/{feature_group}/features/{feature}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(FeatureName name, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeatureRegistryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that handles CRUD and List for resources for
    /// FeatureRegistry.
    /// </remarks>
    public sealed partial class FeatureRegistryServiceClientImpl : FeatureRegistryServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateFeatureGroupRequest, lro::Operation> _callCreateFeatureGroup;

        private readonly gaxgrpc::ApiCall<GetFeatureGroupRequest, FeatureGroup> _callGetFeatureGroup;

        private readonly gaxgrpc::ApiCall<ListFeatureGroupsRequest, ListFeatureGroupsResponse> _callListFeatureGroups;

        private readonly gaxgrpc::ApiCall<UpdateFeatureGroupRequest, lro::Operation> _callUpdateFeatureGroup;

        private readonly gaxgrpc::ApiCall<DeleteFeatureGroupRequest, lro::Operation> _callDeleteFeatureGroup;

        private readonly gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> _callCreateFeature;

        private readonly gaxgrpc::ApiCall<GetFeatureRequest, Feature> _callGetFeature;

        private readonly gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> _callListFeatures;

        private readonly gaxgrpc::ApiCall<UpdateFeatureRequest, lro::Operation> _callUpdateFeature;

        private readonly gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> _callDeleteFeature;

        /// <summary>
        /// Constructs a client wrapper for the FeatureRegistryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FeatureRegistryServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeatureRegistryServiceClientImpl(FeatureRegistryService.FeatureRegistryServiceClient grpcClient, FeatureRegistryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeatureRegistryServiceSettings effectiveSettings = settings ?? FeatureRegistryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFeatureGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeatureGroupOperationsSettings, logger);
            UpdateFeatureGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFeatureGroupOperationsSettings, logger);
            DeleteFeatureGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureGroupOperationsSettings, logger);
            CreateFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeatureOperationsSettings, logger);
            UpdateFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFeatureOperationsSettings, logger);
            DeleteFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateFeatureGroup = clientHelper.BuildApiCall<CreateFeatureGroupRequest, lro::Operation>("CreateFeatureGroup", grpcClient.CreateFeatureGroupAsync, grpcClient.CreateFeatureGroup, effectiveSettings.CreateFeatureGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeatureGroup);
            Modify_CreateFeatureGroupApiCall(ref _callCreateFeatureGroup);
            _callGetFeatureGroup = clientHelper.BuildApiCall<GetFeatureGroupRequest, FeatureGroup>("GetFeatureGroup", grpcClient.GetFeatureGroupAsync, grpcClient.GetFeatureGroup, effectiveSettings.GetFeatureGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeatureGroup);
            Modify_GetFeatureGroupApiCall(ref _callGetFeatureGroup);
            _callListFeatureGroups = clientHelper.BuildApiCall<ListFeatureGroupsRequest, ListFeatureGroupsResponse>("ListFeatureGroups", grpcClient.ListFeatureGroupsAsync, grpcClient.ListFeatureGroups, effectiveSettings.ListFeatureGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatureGroups);
            Modify_ListFeatureGroupsApiCall(ref _callListFeatureGroups);
            _callUpdateFeatureGroup = clientHelper.BuildApiCall<UpdateFeatureGroupRequest, lro::Operation>("UpdateFeatureGroup", grpcClient.UpdateFeatureGroupAsync, grpcClient.UpdateFeatureGroup, effectiveSettings.UpdateFeatureGroupSettings).WithGoogleRequestParam("feature_group.name", request => request.FeatureGroup?.Name);
            Modify_ApiCall(ref _callUpdateFeatureGroup);
            Modify_UpdateFeatureGroupApiCall(ref _callUpdateFeatureGroup);
            _callDeleteFeatureGroup = clientHelper.BuildApiCall<DeleteFeatureGroupRequest, lro::Operation>("DeleteFeatureGroup", grpcClient.DeleteFeatureGroupAsync, grpcClient.DeleteFeatureGroup, effectiveSettings.DeleteFeatureGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeatureGroup);
            Modify_DeleteFeatureGroupApiCall(ref _callDeleteFeatureGroup);
            _callCreateFeature = clientHelper.BuildApiCall<CreateFeatureRequest, lro::Operation>("CreateFeature", grpcClient.CreateFeatureAsync, grpcClient.CreateFeature, effectiveSettings.CreateFeatureSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeature);
            Modify_CreateFeatureApiCall(ref _callCreateFeature);
            _callGetFeature = clientHelper.BuildApiCall<GetFeatureRequest, Feature>("GetFeature", grpcClient.GetFeatureAsync, grpcClient.GetFeature, effectiveSettings.GetFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeature);
            Modify_GetFeatureApiCall(ref _callGetFeature);
            _callListFeatures = clientHelper.BuildApiCall<ListFeaturesRequest, ListFeaturesResponse>("ListFeatures", grpcClient.ListFeaturesAsync, grpcClient.ListFeatures, effectiveSettings.ListFeaturesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatures);
            Modify_ListFeaturesApiCall(ref _callListFeatures);
            _callUpdateFeature = clientHelper.BuildApiCall<UpdateFeatureRequest, lro::Operation>("UpdateFeature", grpcClient.UpdateFeatureAsync, grpcClient.UpdateFeature, effectiveSettings.UpdateFeatureSettings).WithGoogleRequestParam("feature.name", request => request.Feature?.Name);
            Modify_ApiCall(ref _callUpdateFeature);
            Modify_UpdateFeatureApiCall(ref _callUpdateFeature);
            _callDeleteFeature = clientHelper.BuildApiCall<DeleteFeatureRequest, lro::Operation>("DeleteFeature", grpcClient.DeleteFeatureAsync, grpcClient.DeleteFeature, effectiveSettings.DeleteFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeature);
            Modify_DeleteFeatureApiCall(ref _callDeleteFeature);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateFeatureGroupApiCall(ref gaxgrpc::ApiCall<CreateFeatureGroupRequest, lro::Operation> call);

        partial void Modify_GetFeatureGroupApiCall(ref gaxgrpc::ApiCall<GetFeatureGroupRequest, FeatureGroup> call);

        partial void Modify_ListFeatureGroupsApiCall(ref gaxgrpc::ApiCall<ListFeatureGroupsRequest, ListFeatureGroupsResponse> call);

        partial void Modify_UpdateFeatureGroupApiCall(ref gaxgrpc::ApiCall<UpdateFeatureGroupRequest, lro::Operation> call);

        partial void Modify_DeleteFeatureGroupApiCall(ref gaxgrpc::ApiCall<DeleteFeatureGroupRequest, lro::Operation> call);

        partial void Modify_CreateFeatureApiCall(ref gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> call);

        partial void Modify_GetFeatureApiCall(ref gaxgrpc::ApiCall<GetFeatureRequest, Feature> call);

        partial void Modify_ListFeaturesApiCall(ref gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> call);

        partial void Modify_UpdateFeatureApiCall(ref gaxgrpc::ApiCall<UpdateFeatureRequest, lro::Operation> call);

        partial void Modify_DeleteFeatureApiCall(ref gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> call);

        partial void OnConstruction(FeatureRegistryService.FeatureRegistryServiceClient grpcClient, FeatureRegistryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeatureRegistryService client</summary>
        public override FeatureRegistryService.FeatureRegistryServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateFeatureGroupRequest(ref CreateFeatureGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureGroupRequest(ref GetFeatureGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeatureGroupsRequest(ref ListFeatureGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeatureGroupRequest(ref UpdateFeatureGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureGroupRequest(ref DeleteFeatureGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeatureRequest(ref CreateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureRequest(ref GetFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeaturesRequest(ref ListFeaturesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeatureRequest(ref UpdateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureRequest(ref DeleteFeatureRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateFeatureGroup</c>.</summary>
        public override lro::OperationsClient CreateFeatureGroupOperationsClient { get; }

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> CreateFeatureGroup(CreateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureGroupRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>(_callCreateFeatureGroup.Sync(request, callSettings), CreateFeatureGroupOperationsClient);
        }

        /// <summary>
        /// Creates a new FeatureGroup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>> CreateFeatureGroupAsync(CreateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureGroupRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureGroup, CreateFeatureGroupOperationMetadata>(await _callCreateFeatureGroup.Async(request, callSettings).ConfigureAwait(false), CreateFeatureGroupOperationsClient);
        }

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeatureGroup GetFeatureGroup(GetFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureGroupRequest(ref request, ref callSettings);
            return _callGetFeatureGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeatureGroup> GetFeatureGroupAsync(GetFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureGroupRequest(ref request, ref callSettings);
            return _callGetFeatureGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroups(ListFeatureGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeatureGroupsRequest, ListFeatureGroupsResponse, FeatureGroup>(_callListFeatureGroups, request, callSettings);
        }

        /// <summary>
        /// Lists FeatureGroups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeatureGroupsResponse, FeatureGroup> ListFeatureGroupsAsync(ListFeatureGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeatureGroupsRequest, ListFeatureGroupsResponse, FeatureGroup>(_callListFeatureGroups, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateFeatureGroup</c>.</summary>
        public override lro::OperationsClient UpdateFeatureGroupOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata> UpdateFeatureGroup(UpdateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureGroupRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>(_callUpdateFeatureGroup.Sync(request, callSettings), UpdateFeatureGroupOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>> UpdateFeatureGroupAsync(UpdateFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureGroupRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureGroup, UpdateFeatureGroupOperationMetadata>(await _callUpdateFeatureGroup.Async(request, callSettings).ConfigureAwait(false), UpdateFeatureGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeatureGroup</c>.</summary>
        public override lro::OperationsClient DeleteFeatureGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureGroup(DeleteFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteFeatureGroup.Sync(request, callSettings), DeleteFeatureGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a single FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureGroupAsync(DeleteFeatureGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteFeatureGroup.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateFeature</c>.</summary>
        public override lro::OperationsClient CreateFeatureOperationsClient { get; }

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Feature, CreateFeatureOperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, CreateFeatureOperationMetadata>(_callCreateFeature.Sync(request, callSettings), CreateFeatureOperationsClient);
        }

        /// <summary>
        /// Creates a new Feature in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Feature, CreateFeatureOperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, CreateFeatureOperationMetadata>(await _callCreateFeature.Async(request, callSettings).ConfigureAwait(false), CreateFeatureOperationsClient);
        }

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feature GetFeature(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureRequest(ref request, ref callSettings);
            return _callGetFeature.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureRequest(ref request, ref callSettings);
            return _callGetFeature.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeaturesRequest, ListFeaturesResponse, Feature>(_callListFeatures, request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given FeatureGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeaturesRequest, ListFeaturesResponse, Feature>(_callListFeatures, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateFeature</c>.</summary>
        public override lro::OperationsClient UpdateFeatureOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Feature, UpdateFeatureOperationMetadata> UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, UpdateFeatureOperationMetadata>(_callUpdateFeature.Sync(request, callSettings), UpdateFeatureOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Feature, UpdateFeatureOperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, UpdateFeatureOperationMetadata>(await _callUpdateFeature.Async(request, callSettings).ConfigureAwait(false), UpdateFeatureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeature</c>.</summary>
        public override lro::OperationsClient DeleteFeatureOperationsClient { get; }

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteFeature.Sync(request, callSettings), DeleteFeatureOperationsClient);
        }

        /// <summary>
        /// Deletes a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteFeature.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureOperationsClient);
        }
    }

    public partial class ListFeatureGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeaturesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeatureGroupsResponse : gaxgrpc::IPageResponse<FeatureGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeatureGroup> GetEnumerator() => FeatureGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class FeatureRegistryService
    {
        public partial class FeatureRegistryServiceClient
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

    public static partial class FeatureRegistryService
    {
        public partial class FeatureRegistryServiceClient
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
