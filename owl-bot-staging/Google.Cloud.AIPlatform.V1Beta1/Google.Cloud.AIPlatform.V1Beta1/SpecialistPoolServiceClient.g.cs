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
    /// <summary>Settings for <see cref="SpecialistPoolServiceClient"/> instances.</summary>
    public sealed partial class SpecialistPoolServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SpecialistPoolServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SpecialistPoolServiceSettings"/>.</returns>
        public static SpecialistPoolServiceSettings GetDefault() => new SpecialistPoolServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SpecialistPoolServiceSettings"/> object with default settings.
        /// </summary>
        public SpecialistPoolServiceSettings()
        {
        }

        private SpecialistPoolServiceSettings(SpecialistPoolServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSpecialistPoolSettings = existing.CreateSpecialistPoolSettings;
            CreateSpecialistPoolOperationsSettings = existing.CreateSpecialistPoolOperationsSettings.Clone();
            GetSpecialistPoolSettings = existing.GetSpecialistPoolSettings;
            ListSpecialistPoolsSettings = existing.ListSpecialistPoolsSettings;
            DeleteSpecialistPoolSettings = existing.DeleteSpecialistPoolSettings;
            DeleteSpecialistPoolOperationsSettings = existing.DeleteSpecialistPoolOperationsSettings.Clone();
            UpdateSpecialistPoolSettings = existing.UpdateSpecialistPoolSettings;
            UpdateSpecialistPoolOperationsSettings = existing.UpdateSpecialistPoolOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpecialistPoolServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpecialistPoolServiceClient.CreateSpecialistPool</c> and
        /// <c>SpecialistPoolServiceClient.CreateSpecialistPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpecialistPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpecialistPoolServiceClient.CreateSpecialistPool</c> and
        /// <c>SpecialistPoolServiceClient.CreateSpecialistPoolAsync</c>.
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
        public lro::OperationsSettings CreateSpecialistPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpecialistPoolServiceClient.GetSpecialistPool</c> and
        /// <c>SpecialistPoolServiceClient.GetSpecialistPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSpecialistPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpecialistPoolServiceClient.ListSpecialistPools</c> and
        /// <c>SpecialistPoolServiceClient.ListSpecialistPoolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSpecialistPoolsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpecialistPoolServiceClient.DeleteSpecialistPool</c> and
        /// <c>SpecialistPoolServiceClient.DeleteSpecialistPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSpecialistPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpecialistPoolServiceClient.DeleteSpecialistPool</c> and
        /// <c>SpecialistPoolServiceClient.DeleteSpecialistPoolAsync</c>.
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
        public lro::OperationsSettings DeleteSpecialistPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpecialistPoolServiceClient.UpdateSpecialistPool</c> and
        /// <c>SpecialistPoolServiceClient.UpdateSpecialistPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpecialistPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpecialistPoolServiceClient.UpdateSpecialistPool</c> and
        /// <c>SpecialistPoolServiceClient.UpdateSpecialistPoolAsync</c>.
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
        public lro::OperationsSettings UpdateSpecialistPoolOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="SpecialistPoolServiceSettings"/> object.</returns>
        public SpecialistPoolServiceSettings Clone() => new SpecialistPoolServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SpecialistPoolServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SpecialistPoolServiceClientBuilder : gaxgrpc::ClientBuilderBase<SpecialistPoolServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SpecialistPoolServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SpecialistPoolServiceClientBuilder() : base(SpecialistPoolServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SpecialistPoolServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SpecialistPoolServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SpecialistPoolServiceClient Build()
        {
            SpecialistPoolServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SpecialistPoolServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SpecialistPoolServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SpecialistPoolServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SpecialistPoolServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SpecialistPoolServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SpecialistPoolServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SpecialistPoolServiceClient.ChannelPool;
    }

    /// <summary>SpecialistPoolService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Customer SpecialistPools.
    /// When customers start Data Labeling jobs, they can reuse/create Specialist
    /// Pools to bring their own Specialists to label the data.
    /// Customers can add/remove Managers for the Specialist Pool on Cloud console,
    /// then Managers will get email notifications to manage Specialists and tasks on
    /// CrowdCompute console.
    /// </remarks>
    public abstract partial class SpecialistPoolServiceClient
    {
        /// <summary>
        /// The default endpoint for the SpecialistPoolService service, which is a host of "aiplatform.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default SpecialistPoolService scopes.</summary>
        /// <remarks>
        /// The default SpecialistPoolService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SpecialistPoolService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SpecialistPoolServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SpecialistPoolServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SpecialistPoolServiceClient"/>.</returns>
        public static stt::Task<SpecialistPoolServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SpecialistPoolServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SpecialistPoolServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SpecialistPoolServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SpecialistPoolServiceClient"/>.</returns>
        public static SpecialistPoolServiceClient Create() => new SpecialistPoolServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SpecialistPoolServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SpecialistPoolServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SpecialistPoolServiceClient"/>.</returns>
        internal static SpecialistPoolServiceClient Create(grpccore::CallInvoker callInvoker, SpecialistPoolServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SpecialistPoolService.SpecialistPoolServiceClient grpcClient = new SpecialistPoolService.SpecialistPoolServiceClient(callInvoker);
            return new SpecialistPoolServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SpecialistPoolService client</summary>
        public virtual SpecialistPoolService.SpecialistPoolServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> CreateSpecialistPool(CreateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> CreateSpecialistPoolAsync(CreateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> CreateSpecialistPoolAsync(CreateSpecialistPoolRequest request, st::CancellationToken cancellationToken) =>
            CreateSpecialistPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSpecialistPool</c>.</summary>
        public virtual lro::OperationsClient CreateSpecialistPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSpecialistPool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> PollOnceCreateSpecialistPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSpecialistPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSpecialistPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> PollOnceCreateSpecialistPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSpecialistPoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Project name for the new SpecialistPool.
        /// The form is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> CreateSpecialistPool(string parent, SpecialistPool specialistPool, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpecialistPool(new CreateSpecialistPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpecialistPool = gax::GaxPreconditions.CheckNotNull(specialistPool, nameof(specialistPool)),
            }, callSettings);

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Project name for the new SpecialistPool.
        /// The form is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> CreateSpecialistPoolAsync(string parent, SpecialistPool specialistPool, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpecialistPoolAsync(new CreateSpecialistPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpecialistPool = gax::GaxPreconditions.CheckNotNull(specialistPool, nameof(specialistPool)),
            }, callSettings);

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Project name for the new SpecialistPool.
        /// The form is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> CreateSpecialistPoolAsync(string parent, SpecialistPool specialistPool, st::CancellationToken cancellationToken) =>
            CreateSpecialistPoolAsync(parent, specialistPool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Project name for the new SpecialistPool.
        /// The form is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> CreateSpecialistPool(gagr::LocationName parent, SpecialistPool specialistPool, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpecialistPool(new CreateSpecialistPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpecialistPool = gax::GaxPreconditions.CheckNotNull(specialistPool, nameof(specialistPool)),
            }, callSettings);

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Project name for the new SpecialistPool.
        /// The form is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> CreateSpecialistPoolAsync(gagr::LocationName parent, SpecialistPool specialistPool, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpecialistPoolAsync(new CreateSpecialistPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpecialistPool = gax::GaxPreconditions.CheckNotNull(specialistPool, nameof(specialistPool)),
            }, callSettings);

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Project name for the new SpecialistPool.
        /// The form is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> CreateSpecialistPoolAsync(gagr::LocationName parent, SpecialistPool specialistPool, st::CancellationToken cancellationToken) =>
            CreateSpecialistPoolAsync(parent, specialistPool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpecialistPool GetSpecialistPool(GetSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecialistPool> GetSpecialistPoolAsync(GetSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecialistPool> GetSpecialistPoolAsync(GetSpecialistPoolRequest request, st::CancellationToken cancellationToken) =>
            GetSpecialistPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SpecialistPool resource.
        /// The form is
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpecialistPool GetSpecialistPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecialistPool(new GetSpecialistPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SpecialistPool resource.
        /// The form is
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecialistPool> GetSpecialistPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecialistPoolAsync(new GetSpecialistPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SpecialistPool resource.
        /// The form is
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecialistPool> GetSpecialistPoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpecialistPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SpecialistPool resource.
        /// The form is
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpecialistPool GetSpecialistPool(SpecialistPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecialistPool(new GetSpecialistPoolRequest
            {
                SpecialistPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SpecialistPool resource.
        /// The form is
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecialistPool> GetSpecialistPoolAsync(SpecialistPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecialistPoolAsync(new GetSpecialistPoolRequest
            {
                SpecialistPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SpecialistPool resource.
        /// The form is
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecialistPool> GetSpecialistPoolAsync(SpecialistPoolName name, st::CancellationToken cancellationToken) =>
            GetSpecialistPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SpecialistPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPools(ListSpecialistPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SpecialistPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPoolsAsync(ListSpecialistPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the SpecialistPool's parent resource.
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
        /// <returns>A pageable sequence of <see cref="SpecialistPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecialistPoolsRequest request = new ListSpecialistPoolsRequest
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
            return ListSpecialistPools(request, callSettings);
        }

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the SpecialistPool's parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SpecialistPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecialistPoolsRequest request = new ListSpecialistPoolsRequest
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
            return ListSpecialistPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the SpecialistPool's parent resource.
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
        /// <returns>A pageable sequence of <see cref="SpecialistPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPools(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecialistPoolsRequest request = new ListSpecialistPoolsRequest
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
            return ListSpecialistPools(request, callSettings);
        }

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the SpecialistPool's parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SpecialistPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPoolsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecialistPoolsRequest request = new ListSpecialistPoolsRequest
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
            return ListSpecialistPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSpecialistPool(DeleteSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSpecialistPoolAsync(DeleteSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSpecialistPoolAsync(DeleteSpecialistPoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteSpecialistPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSpecialistPool</c>.</summary>
        public virtual lro::OperationsClient DeleteSpecialistPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSpecialistPool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteSpecialistPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSpecialistPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSpecialistPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteSpecialistPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSpecialistPoolOperationsClient, callSettings);

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SpecialistPool to delete. Format:
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSpecialistPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpecialistPool(new DeleteSpecialistPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SpecialistPool to delete. Format:
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSpecialistPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpecialistPoolAsync(new DeleteSpecialistPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SpecialistPool to delete. Format:
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSpecialistPoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSpecialistPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SpecialistPool to delete. Format:
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSpecialistPool(SpecialistPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpecialistPool(new DeleteSpecialistPoolRequest
            {
                SpecialistPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SpecialistPool to delete. Format:
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSpecialistPoolAsync(SpecialistPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpecialistPoolAsync(new DeleteSpecialistPoolRequest
            {
                SpecialistPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SpecialistPool to delete. Format:
        /// `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSpecialistPoolAsync(SpecialistPoolName name, st::CancellationToken cancellationToken) =>
            DeleteSpecialistPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> UpdateSpecialistPool(UpdateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>> UpdateSpecialistPoolAsync(UpdateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>> UpdateSpecialistPoolAsync(UpdateSpecialistPoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpecialistPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSpecialistPool</c>.</summary>
        public virtual lro::OperationsClient UpdateSpecialistPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSpecialistPool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> PollOnceUpdateSpecialistPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSpecialistPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSpecialistPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>> PollOnceUpdateSpecialistPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSpecialistPoolOperationsClient, callSettings);

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> UpdateSpecialistPool(SpecialistPool specialistPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpecialistPool(new UpdateSpecialistPoolRequest
            {
                SpecialistPool = gax::GaxPreconditions.CheckNotNull(specialistPool, nameof(specialistPool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>> UpdateSpecialistPoolAsync(SpecialistPool specialistPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpecialistPoolAsync(new UpdateSpecialistPoolRequest
            {
                SpecialistPool = gax::GaxPreconditions.CheckNotNull(specialistPool, nameof(specialistPool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="specialistPool">
        /// Required. The SpecialistPool which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>> UpdateSpecialistPoolAsync(SpecialistPool specialistPool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpecialistPoolAsync(specialistPool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SpecialistPoolService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Customer SpecialistPools.
    /// When customers start Data Labeling jobs, they can reuse/create Specialist
    /// Pools to bring their own Specialists to label the data.
    /// Customers can add/remove Managers for the Specialist Pool on Cloud console,
    /// then Managers will get email notifications to manage Specialists and tasks on
    /// CrowdCompute console.
    /// </remarks>
    public sealed partial class SpecialistPoolServiceClientImpl : SpecialistPoolServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSpecialistPoolRequest, lro::Operation> _callCreateSpecialistPool;

        private readonly gaxgrpc::ApiCall<GetSpecialistPoolRequest, SpecialistPool> _callGetSpecialistPool;

        private readonly gaxgrpc::ApiCall<ListSpecialistPoolsRequest, ListSpecialistPoolsResponse> _callListSpecialistPools;

        private readonly gaxgrpc::ApiCall<DeleteSpecialistPoolRequest, lro::Operation> _callDeleteSpecialistPool;

        private readonly gaxgrpc::ApiCall<UpdateSpecialistPoolRequest, lro::Operation> _callUpdateSpecialistPool;

        /// <summary>
        /// Constructs a client wrapper for the SpecialistPoolService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpecialistPoolServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SpecialistPoolServiceClientImpl(SpecialistPoolService.SpecialistPoolServiceClient grpcClient, SpecialistPoolServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SpecialistPoolServiceSettings effectiveSettings = settings ?? SpecialistPoolServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSpecialistPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSpecialistPoolOperationsSettings, logger);
            DeleteSpecialistPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSpecialistPoolOperationsSettings, logger);
            UpdateSpecialistPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSpecialistPoolOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateSpecialistPool = clientHelper.BuildApiCall<CreateSpecialistPoolRequest, lro::Operation>("CreateSpecialistPool", grpcClient.CreateSpecialistPoolAsync, grpcClient.CreateSpecialistPool, effectiveSettings.CreateSpecialistPoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSpecialistPool);
            Modify_CreateSpecialistPoolApiCall(ref _callCreateSpecialistPool);
            _callGetSpecialistPool = clientHelper.BuildApiCall<GetSpecialistPoolRequest, SpecialistPool>("GetSpecialistPool", grpcClient.GetSpecialistPoolAsync, grpcClient.GetSpecialistPool, effectiveSettings.GetSpecialistPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpecialistPool);
            Modify_GetSpecialistPoolApiCall(ref _callGetSpecialistPool);
            _callListSpecialistPools = clientHelper.BuildApiCall<ListSpecialistPoolsRequest, ListSpecialistPoolsResponse>("ListSpecialistPools", grpcClient.ListSpecialistPoolsAsync, grpcClient.ListSpecialistPools, effectiveSettings.ListSpecialistPoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSpecialistPools);
            Modify_ListSpecialistPoolsApiCall(ref _callListSpecialistPools);
            _callDeleteSpecialistPool = clientHelper.BuildApiCall<DeleteSpecialistPoolRequest, lro::Operation>("DeleteSpecialistPool", grpcClient.DeleteSpecialistPoolAsync, grpcClient.DeleteSpecialistPool, effectiveSettings.DeleteSpecialistPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSpecialistPool);
            Modify_DeleteSpecialistPoolApiCall(ref _callDeleteSpecialistPool);
            _callUpdateSpecialistPool = clientHelper.BuildApiCall<UpdateSpecialistPoolRequest, lro::Operation>("UpdateSpecialistPool", grpcClient.UpdateSpecialistPoolAsync, grpcClient.UpdateSpecialistPool, effectiveSettings.UpdateSpecialistPoolSettings).WithGoogleRequestParam("specialist_pool.name", request => request.SpecialistPool?.Name);
            Modify_ApiCall(ref _callUpdateSpecialistPool);
            Modify_UpdateSpecialistPoolApiCall(ref _callUpdateSpecialistPool);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSpecialistPoolApiCall(ref gaxgrpc::ApiCall<CreateSpecialistPoolRequest, lro::Operation> call);

        partial void Modify_GetSpecialistPoolApiCall(ref gaxgrpc::ApiCall<GetSpecialistPoolRequest, SpecialistPool> call);

        partial void Modify_ListSpecialistPoolsApiCall(ref gaxgrpc::ApiCall<ListSpecialistPoolsRequest, ListSpecialistPoolsResponse> call);

        partial void Modify_DeleteSpecialistPoolApiCall(ref gaxgrpc::ApiCall<DeleteSpecialistPoolRequest, lro::Operation> call);

        partial void Modify_UpdateSpecialistPoolApiCall(ref gaxgrpc::ApiCall<UpdateSpecialistPoolRequest, lro::Operation> call);

        partial void OnConstruction(SpecialistPoolService.SpecialistPoolServiceClient grpcClient, SpecialistPoolServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SpecialistPoolService client</summary>
        public override SpecialistPoolService.SpecialistPoolServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateSpecialistPoolRequest(ref CreateSpecialistPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpecialistPoolRequest(ref GetSpecialistPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSpecialistPoolsRequest(ref ListSpecialistPoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSpecialistPoolRequest(ref DeleteSpecialistPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpecialistPoolRequest(ref UpdateSpecialistPoolRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateSpecialistPool</c>.</summary>
        public override lro::OperationsClient CreateSpecialistPoolOperationsClient { get; }

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> CreateSpecialistPool(CreateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpecialistPoolRequest(ref request, ref callSettings);
            return new lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>(_callCreateSpecialistPool.Sync(request, callSettings), CreateSpecialistPoolOperationsClient);
        }

        /// <summary>
        /// Creates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>> CreateSpecialistPoolAsync(CreateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpecialistPoolRequest(ref request, ref callSettings);
            return new lro::Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata>(await _callCreateSpecialistPool.Async(request, callSettings).ConfigureAwait(false), CreateSpecialistPoolOperationsClient);
        }

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SpecialistPool GetSpecialistPool(GetSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpecialistPoolRequest(ref request, ref callSettings);
            return _callGetSpecialistPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SpecialistPool> GetSpecialistPoolAsync(GetSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpecialistPoolRequest(ref request, ref callSettings);
            return _callGetSpecialistPool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SpecialistPool"/> resources.</returns>
        public override gax::PagedEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPools(ListSpecialistPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpecialistPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSpecialistPoolsRequest, ListSpecialistPoolsResponse, SpecialistPool>(_callListSpecialistPools, request, callSettings);
        }

        /// <summary>
        /// Lists SpecialistPools in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SpecialistPool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSpecialistPoolsResponse, SpecialistPool> ListSpecialistPoolsAsync(ListSpecialistPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpecialistPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSpecialistPoolsRequest, ListSpecialistPoolsResponse, SpecialistPool>(_callListSpecialistPools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteSpecialistPool</c>.</summary>
        public override lro::OperationsClient DeleteSpecialistPoolOperationsClient { get; }

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSpecialistPool(DeleteSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpecialistPoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteSpecialistPool.Sync(request, callSettings), DeleteSpecialistPoolOperationsClient);
        }

        /// <summary>
        /// Deletes a SpecialistPool as well as all Specialists in the pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSpecialistPoolAsync(DeleteSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpecialistPoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteSpecialistPool.Async(request, callSettings).ConfigureAwait(false), DeleteSpecialistPoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSpecialistPool</c>.</summary>
        public override lro::OperationsClient UpdateSpecialistPoolOperationsClient { get; }

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> UpdateSpecialistPool(UpdateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpecialistPoolRequest(ref request, ref callSettings);
            return new lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>(_callUpdateSpecialistPool.Sync(request, callSettings), UpdateSpecialistPoolOperationsClient);
        }

        /// <summary>
        /// Updates a SpecialistPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>> UpdateSpecialistPoolAsync(UpdateSpecialistPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpecialistPoolRequest(ref request, ref callSettings);
            return new lro::Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata>(await _callUpdateSpecialistPool.Async(request, callSettings).ConfigureAwait(false), UpdateSpecialistPoolOperationsClient);
        }
    }

    public partial class ListSpecialistPoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSpecialistPoolsResponse : gaxgrpc::IPageResponse<SpecialistPool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SpecialistPool> GetEnumerator() => SpecialistPools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SpecialistPoolService
    {
        public partial class SpecialistPoolServiceClient
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

    public static partial class SpecialistPoolService
    {
        public partial class SpecialistPoolServiceClient
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
