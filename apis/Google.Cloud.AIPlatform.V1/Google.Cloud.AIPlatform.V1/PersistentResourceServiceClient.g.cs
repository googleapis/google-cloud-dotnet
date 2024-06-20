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
    /// <summary>Settings for <see cref="PersistentResourceServiceClient"/> instances.</summary>
    public sealed partial class PersistentResourceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PersistentResourceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PersistentResourceServiceSettings"/>.</returns>
        public static PersistentResourceServiceSettings GetDefault() => new PersistentResourceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PersistentResourceServiceSettings"/> object with default settings.
        /// </summary>
        public PersistentResourceServiceSettings()
        {
        }

        private PersistentResourceServiceSettings(PersistentResourceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePersistentResourceSettings = existing.CreatePersistentResourceSettings;
            CreatePersistentResourceOperationsSettings = existing.CreatePersistentResourceOperationsSettings.Clone();
            GetPersistentResourceSettings = existing.GetPersistentResourceSettings;
            ListPersistentResourcesSettings = existing.ListPersistentResourcesSettings;
            DeletePersistentResourceSettings = existing.DeletePersistentResourceSettings;
            DeletePersistentResourceOperationsSettings = existing.DeletePersistentResourceOperationsSettings.Clone();
            UpdatePersistentResourceSettings = existing.UpdatePersistentResourceSettings;
            UpdatePersistentResourceOperationsSettings = existing.UpdatePersistentResourceOperationsSettings.Clone();
            RebootPersistentResourceSettings = existing.RebootPersistentResourceSettings;
            RebootPersistentResourceOperationsSettings = existing.RebootPersistentResourceOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(PersistentResourceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PersistentResourceServiceClient.CreatePersistentResource</c> and
        /// <c>PersistentResourceServiceClient.CreatePersistentResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePersistentResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PersistentResourceServiceClient.CreatePersistentResource</c>
        /// and <c>PersistentResourceServiceClient.CreatePersistentResourceAsync</c>.
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
        public lro::OperationsSettings CreatePersistentResourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PersistentResourceServiceClient.GetPersistentResource</c> and
        /// <c>PersistentResourceServiceClient.GetPersistentResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPersistentResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PersistentResourceServiceClient.ListPersistentResources</c> and
        /// <c>PersistentResourceServiceClient.ListPersistentResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPersistentResourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PersistentResourceServiceClient.DeletePersistentResource</c> and
        /// <c>PersistentResourceServiceClient.DeletePersistentResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePersistentResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PersistentResourceServiceClient.DeletePersistentResource</c>
        /// and <c>PersistentResourceServiceClient.DeletePersistentResourceAsync</c>.
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
        public lro::OperationsSettings DeletePersistentResourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PersistentResourceServiceClient.UpdatePersistentResource</c> and
        /// <c>PersistentResourceServiceClient.UpdatePersistentResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePersistentResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PersistentResourceServiceClient.UpdatePersistentResource</c>
        /// and <c>PersistentResourceServiceClient.UpdatePersistentResourceAsync</c>.
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
        public lro::OperationsSettings UpdatePersistentResourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PersistentResourceServiceClient.RebootPersistentResource</c> and
        /// <c>PersistentResourceServiceClient.RebootPersistentResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RebootPersistentResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PersistentResourceServiceClient.RebootPersistentResource</c>
        /// and <c>PersistentResourceServiceClient.RebootPersistentResourceAsync</c>.
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
        public lro::OperationsSettings RebootPersistentResourceOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="PersistentResourceServiceSettings"/> object.</returns>
        public PersistentResourceServiceSettings Clone() => new PersistentResourceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PersistentResourceServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PersistentResourceServiceClientBuilder : gaxgrpc::ClientBuilderBase<PersistentResourceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PersistentResourceServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PersistentResourceServiceClientBuilder() : base(PersistentResourceServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PersistentResourceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PersistentResourceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PersistentResourceServiceClient Build()
        {
            PersistentResourceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PersistentResourceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PersistentResourceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PersistentResourceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PersistentResourceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PersistentResourceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PersistentResourceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PersistentResourceServiceClient.ChannelPool;
    }

    /// <summary>PersistentResourceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's machine learning PersistentResource.
    /// </remarks>
    public abstract partial class PersistentResourceServiceClient
    {
        /// <summary>
        /// The default endpoint for the PersistentResourceService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default PersistentResourceService scopes.</summary>
        /// <remarks>
        /// The default PersistentResourceService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PersistentResourceService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PersistentResourceServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PersistentResourceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PersistentResourceServiceClient"/>.</returns>
        public static stt::Task<PersistentResourceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PersistentResourceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PersistentResourceServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PersistentResourceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PersistentResourceServiceClient"/>.</returns>
        public static PersistentResourceServiceClient Create() => new PersistentResourceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PersistentResourceServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PersistentResourceServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PersistentResourceServiceClient"/>.</returns>
        internal static PersistentResourceServiceClient Create(grpccore::CallInvoker callInvoker, PersistentResourceServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PersistentResourceService.PersistentResourceServiceClient grpcClient = new PersistentResourceService.PersistentResourceServiceClient(callInvoker);
            return new PersistentResourceServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PersistentResourceService client</summary>
        public virtual PersistentResourceService.PersistentResourceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata> CreatePersistentResource(CreatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> CreatePersistentResourceAsync(CreatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> CreatePersistentResourceAsync(CreatePersistentResourceRequest request, st::CancellationToken cancellationToken) =>
            CreatePersistentResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePersistentResource</c>.</summary>
        public virtual lro::OperationsClient CreatePersistentResourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata> PollOnceCreatePersistentResource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> PollOnceCreatePersistentResourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// PersistentResource in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to create.
        /// </param>
        /// <param name="persistentResourceId">
        /// Required. The ID to use for the PersistentResource, which become the final
        /// component of the PersistentResource's resource name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata> CreatePersistentResource(string parent, PersistentResource persistentResource, string persistentResourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePersistentResource(new CreatePersistentResourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PersistentResource = gax::GaxPreconditions.CheckNotNull(persistentResource, nameof(persistentResource)),
                PersistentResourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(persistentResourceId, nameof(persistentResourceId)),
            }, callSettings);

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// PersistentResource in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to create.
        /// </param>
        /// <param name="persistentResourceId">
        /// Required. The ID to use for the PersistentResource, which become the final
        /// component of the PersistentResource's resource name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> CreatePersistentResourceAsync(string parent, PersistentResource persistentResource, string persistentResourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePersistentResourceAsync(new CreatePersistentResourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PersistentResource = gax::GaxPreconditions.CheckNotNull(persistentResource, nameof(persistentResource)),
                PersistentResourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(persistentResourceId, nameof(persistentResourceId)),
            }, callSettings);

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// PersistentResource in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to create.
        /// </param>
        /// <param name="persistentResourceId">
        /// Required. The ID to use for the PersistentResource, which become the final
        /// component of the PersistentResource's resource name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> CreatePersistentResourceAsync(string parent, PersistentResource persistentResource, string persistentResourceId, st::CancellationToken cancellationToken) =>
            CreatePersistentResourceAsync(parent, persistentResource, persistentResourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// PersistentResource in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to create.
        /// </param>
        /// <param name="persistentResourceId">
        /// Required. The ID to use for the PersistentResource, which become the final
        /// component of the PersistentResource's resource name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata> CreatePersistentResource(gagr::LocationName parent, PersistentResource persistentResource, string persistentResourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePersistentResource(new CreatePersistentResourceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PersistentResource = gax::GaxPreconditions.CheckNotNull(persistentResource, nameof(persistentResource)),
                PersistentResourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(persistentResourceId, nameof(persistentResourceId)),
            }, callSettings);

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// PersistentResource in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to create.
        /// </param>
        /// <param name="persistentResourceId">
        /// Required. The ID to use for the PersistentResource, which become the final
        /// component of the PersistentResource's resource name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> CreatePersistentResourceAsync(gagr::LocationName parent, PersistentResource persistentResource, string persistentResourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePersistentResourceAsync(new CreatePersistentResourceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PersistentResource = gax::GaxPreconditions.CheckNotNull(persistentResource, nameof(persistentResource)),
                PersistentResourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(persistentResourceId, nameof(persistentResourceId)),
            }, callSettings);

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// PersistentResource in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to create.
        /// </param>
        /// <param name="persistentResourceId">
        /// Required. The ID to use for the PersistentResource, which become the final
        /// component of the PersistentResource's resource name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> CreatePersistentResourceAsync(gagr::LocationName parent, PersistentResource persistentResource, string persistentResourceId, st::CancellationToken cancellationToken) =>
            CreatePersistentResourceAsync(parent, persistentResource, persistentResourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PersistentResource GetPersistentResource(GetPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PersistentResource> GetPersistentResourceAsync(GetPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PersistentResource> GetPersistentResourceAsync(GetPersistentResourceRequest request, st::CancellationToken cancellationToken) =>
            GetPersistentResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PersistentResource GetPersistentResource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPersistentResource(new GetPersistentResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PersistentResource> GetPersistentResourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPersistentResourceAsync(new GetPersistentResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PersistentResource> GetPersistentResourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetPersistentResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PersistentResource GetPersistentResource(PersistentResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPersistentResource(new GetPersistentResourceRequest
            {
                PersistentResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PersistentResource> GetPersistentResourceAsync(PersistentResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPersistentResourceAsync(new GetPersistentResourceRequest
            {
                PersistentResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PersistentResource> GetPersistentResourceAsync(PersistentResourceName name, st::CancellationToken cancellationToken) =>
            GetPersistentResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PersistentResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResources(ListPersistentResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PersistentResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResourcesAsync(ListPersistentResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the PersistentResources
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="PersistentResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPersistentResources(new ListPersistentResourcesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the PersistentResources
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PersistentResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPersistentResourcesAsync(new ListPersistentResourcesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the PersistentResources
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="PersistentResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResources(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPersistentResources(new ListPersistentResourcesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the PersistentResources
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PersistentResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResourcesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPersistentResourcesAsync(new ListPersistentResourcesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeletePersistentResource(DeletePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeletePersistentResourceAsync(DeletePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeletePersistentResourceAsync(DeletePersistentResourceRequest request, st::CancellationToken cancellationToken) =>
            DeletePersistentResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePersistentResource</c>.</summary>
        public virtual lro::OperationsClient DeletePersistentResourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeletePersistentResource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeletePersistentResourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeletePersistentResource(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePersistentResource(new DeletePersistentResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeletePersistentResourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePersistentResourceAsync(new DeletePersistentResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeletePersistentResourceAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePersistentResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeletePersistentResource(PersistentResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePersistentResource(new DeletePersistentResourceRequest
            {
                PersistentResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeletePersistentResourceAsync(PersistentResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePersistentResourceAsync(new DeletePersistentResourceRequest
            {
                PersistentResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeletePersistentResourceAsync(PersistentResourceName name, st::CancellationToken cancellationToken) =>
            DeletePersistentResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> UpdatePersistentResource(UpdatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>> UpdatePersistentResourceAsync(UpdatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>> UpdatePersistentResourceAsync(UpdatePersistentResourceRequest request, st::CancellationToken cancellationToken) =>
            UpdatePersistentResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePersistentResource</c>.</summary>
        public virtual lro::OperationsClient UpdatePersistentResourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> PollOnceUpdatePersistentResource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>> PollOnceUpdatePersistentResourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to update.
        /// 
        /// The PersistentResource's `name` field is used to identify the
        /// PersistentResource to update. Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Specify the fields to be overwritten in the PersistentResource by
        /// the update method.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> UpdatePersistentResource(PersistentResource persistentResource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePersistentResource(new UpdatePersistentResourceRequest
            {
                PersistentResource = gax::GaxPreconditions.CheckNotNull(persistentResource, nameof(persistentResource)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to update.
        /// 
        /// The PersistentResource's `name` field is used to identify the
        /// PersistentResource to update. Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Specify the fields to be overwritten in the PersistentResource by
        /// the update method.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>> UpdatePersistentResourceAsync(PersistentResource persistentResource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePersistentResourceAsync(new UpdatePersistentResourceRequest
            {
                PersistentResource = gax::GaxPreconditions.CheckNotNull(persistentResource, nameof(persistentResource)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="persistentResource">
        /// Required. The PersistentResource to update.
        /// 
        /// The PersistentResource's `name` field is used to identify the
        /// PersistentResource to update. Format:
        /// `projects/{project}/locations/{location}/persistentResources/{persistent_resource}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Specify the fields to be overwritten in the PersistentResource by
        /// the update method.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>> UpdatePersistentResourceAsync(PersistentResource persistentResource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePersistentResourceAsync(persistentResource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata> RebootPersistentResource(RebootPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> RebootPersistentResourceAsync(RebootPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> RebootPersistentResourceAsync(RebootPersistentResourceRequest request, st::CancellationToken cancellationToken) =>
            RebootPersistentResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RebootPersistentResource</c>.</summary>
        public virtual lro::OperationsClient RebootPersistentResourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RebootPersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata> PollOnceRebootPersistentResource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RebootPersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RebootPersistentResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> PollOnceRebootPersistentResourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RebootPersistentResourceOperationsClient, callSettings);

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata> RebootPersistentResource(string name, gaxgrpc::CallSettings callSettings = null) =>
            RebootPersistentResource(new RebootPersistentResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> RebootPersistentResourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RebootPersistentResourceAsync(new RebootPersistentResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> RebootPersistentResourceAsync(string name, st::CancellationToken cancellationToken) =>
            RebootPersistentResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata> RebootPersistentResource(PersistentResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            RebootPersistentResource(new RebootPersistentResourceRequest
            {
                PersistentResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> RebootPersistentResourceAsync(PersistentResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            RebootPersistentResourceAsync(new RebootPersistentResourceRequest
            {
                PersistentResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PersistentResource resource.
        /// Format:
        /// `projects/{project_id_or_number}/locations/{location_id}/persistentResources/{persistent_resource_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> RebootPersistentResourceAsync(PersistentResourceName name, st::CancellationToken cancellationToken) =>
            RebootPersistentResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PersistentResourceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's machine learning PersistentResource.
    /// </remarks>
    public sealed partial class PersistentResourceServiceClientImpl : PersistentResourceServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreatePersistentResourceRequest, lro::Operation> _callCreatePersistentResource;

        private readonly gaxgrpc::ApiCall<GetPersistentResourceRequest, PersistentResource> _callGetPersistentResource;

        private readonly gaxgrpc::ApiCall<ListPersistentResourcesRequest, ListPersistentResourcesResponse> _callListPersistentResources;

        private readonly gaxgrpc::ApiCall<DeletePersistentResourceRequest, lro::Operation> _callDeletePersistentResource;

        private readonly gaxgrpc::ApiCall<UpdatePersistentResourceRequest, lro::Operation> _callUpdatePersistentResource;

        private readonly gaxgrpc::ApiCall<RebootPersistentResourceRequest, lro::Operation> _callRebootPersistentResource;

        /// <summary>
        /// Constructs a client wrapper for the PersistentResourceService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PersistentResourceServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PersistentResourceServiceClientImpl(PersistentResourceService.PersistentResourceServiceClient grpcClient, PersistentResourceServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PersistentResourceServiceSettings effectiveSettings = settings ?? PersistentResourceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreatePersistentResourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePersistentResourceOperationsSettings, logger);
            DeletePersistentResourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePersistentResourceOperationsSettings, logger);
            UpdatePersistentResourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePersistentResourceOperationsSettings, logger);
            RebootPersistentResourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RebootPersistentResourceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreatePersistentResource = clientHelper.BuildApiCall<CreatePersistentResourceRequest, lro::Operation>("CreatePersistentResource", grpcClient.CreatePersistentResourceAsync, grpcClient.CreatePersistentResource, effectiveSettings.CreatePersistentResourceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePersistentResource);
            Modify_CreatePersistentResourceApiCall(ref _callCreatePersistentResource);
            _callGetPersistentResource = clientHelper.BuildApiCall<GetPersistentResourceRequest, PersistentResource>("GetPersistentResource", grpcClient.GetPersistentResourceAsync, grpcClient.GetPersistentResource, effectiveSettings.GetPersistentResourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPersistentResource);
            Modify_GetPersistentResourceApiCall(ref _callGetPersistentResource);
            _callListPersistentResources = clientHelper.BuildApiCall<ListPersistentResourcesRequest, ListPersistentResourcesResponse>("ListPersistentResources", grpcClient.ListPersistentResourcesAsync, grpcClient.ListPersistentResources, effectiveSettings.ListPersistentResourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPersistentResources);
            Modify_ListPersistentResourcesApiCall(ref _callListPersistentResources);
            _callDeletePersistentResource = clientHelper.BuildApiCall<DeletePersistentResourceRequest, lro::Operation>("DeletePersistentResource", grpcClient.DeletePersistentResourceAsync, grpcClient.DeletePersistentResource, effectiveSettings.DeletePersistentResourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePersistentResource);
            Modify_DeletePersistentResourceApiCall(ref _callDeletePersistentResource);
            _callUpdatePersistentResource = clientHelper.BuildApiCall<UpdatePersistentResourceRequest, lro::Operation>("UpdatePersistentResource", grpcClient.UpdatePersistentResourceAsync, grpcClient.UpdatePersistentResource, effectiveSettings.UpdatePersistentResourceSettings).WithGoogleRequestParam("persistent_resource.name", request => request.PersistentResource?.Name);
            Modify_ApiCall(ref _callUpdatePersistentResource);
            Modify_UpdatePersistentResourceApiCall(ref _callUpdatePersistentResource);
            _callRebootPersistentResource = clientHelper.BuildApiCall<RebootPersistentResourceRequest, lro::Operation>("RebootPersistentResource", grpcClient.RebootPersistentResourceAsync, grpcClient.RebootPersistentResource, effectiveSettings.RebootPersistentResourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRebootPersistentResource);
            Modify_RebootPersistentResourceApiCall(ref _callRebootPersistentResource);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePersistentResourceApiCall(ref gaxgrpc::ApiCall<CreatePersistentResourceRequest, lro::Operation> call);

        partial void Modify_GetPersistentResourceApiCall(ref gaxgrpc::ApiCall<GetPersistentResourceRequest, PersistentResource> call);

        partial void Modify_ListPersistentResourcesApiCall(ref gaxgrpc::ApiCall<ListPersistentResourcesRequest, ListPersistentResourcesResponse> call);

        partial void Modify_DeletePersistentResourceApiCall(ref gaxgrpc::ApiCall<DeletePersistentResourceRequest, lro::Operation> call);

        partial void Modify_UpdatePersistentResourceApiCall(ref gaxgrpc::ApiCall<UpdatePersistentResourceRequest, lro::Operation> call);

        partial void Modify_RebootPersistentResourceApiCall(ref gaxgrpc::ApiCall<RebootPersistentResourceRequest, lro::Operation> call);

        partial void OnConstruction(PersistentResourceService.PersistentResourceServiceClient grpcClient, PersistentResourceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PersistentResourceService client</summary>
        public override PersistentResourceService.PersistentResourceServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreatePersistentResourceRequest(ref CreatePersistentResourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPersistentResourceRequest(ref GetPersistentResourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPersistentResourcesRequest(ref ListPersistentResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePersistentResourceRequest(ref DeletePersistentResourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePersistentResourceRequest(ref UpdatePersistentResourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RebootPersistentResourceRequest(ref RebootPersistentResourceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreatePersistentResource</c>.</summary>
        public override lro::OperationsClient CreatePersistentResourceOperationsClient { get; }

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata> CreatePersistentResource(CreatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>(_callCreatePersistentResource.Sync(request, callSettings), CreatePersistentResourceOperationsClient);
        }

        /// <summary>
        /// Creates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>> CreatePersistentResourceAsync(CreatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<PersistentResource, CreatePersistentResourceOperationMetadata>(await _callCreatePersistentResource.Async(request, callSettings).ConfigureAwait(false), CreatePersistentResourceOperationsClient);
        }

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PersistentResource GetPersistentResource(GetPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPersistentResourceRequest(ref request, ref callSettings);
            return _callGetPersistentResource.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PersistentResource> GetPersistentResourceAsync(GetPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPersistentResourceRequest(ref request, ref callSettings);
            return _callGetPersistentResource.Async(request, callSettings);
        }

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PersistentResource"/> resources.</returns>
        public override gax::PagedEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResources(ListPersistentResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPersistentResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPersistentResourcesRequest, ListPersistentResourcesResponse, PersistentResource>(_callListPersistentResources, request, callSettings);
        }

        /// <summary>
        /// Lists PersistentResources in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PersistentResource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPersistentResourcesResponse, PersistentResource> ListPersistentResourcesAsync(ListPersistentResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPersistentResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPersistentResourcesRequest, ListPersistentResourcesResponse, PersistentResource>(_callListPersistentResources, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeletePersistentResource</c>.</summary>
        public override lro::OperationsClient DeletePersistentResourceOperationsClient { get; }

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeletePersistentResource(DeletePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeletePersistentResource.Sync(request, callSettings), DeletePersistentResourceOperationsClient);
        }

        /// <summary>
        /// Deletes a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeletePersistentResourceAsync(DeletePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeletePersistentResource.Async(request, callSettings).ConfigureAwait(false), DeletePersistentResourceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdatePersistentResource</c>.</summary>
        public override lro::OperationsClient UpdatePersistentResourceOperationsClient { get; }

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata> UpdatePersistentResource(UpdatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>(_callUpdatePersistentResource.Sync(request, callSettings), UpdatePersistentResourceOperationsClient);
        }

        /// <summary>
        /// Updates a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>> UpdatePersistentResourceAsync(UpdatePersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<PersistentResource, UpdatePersistentResourceOperationMetadata>(await _callUpdatePersistentResource.Async(request, callSettings).ConfigureAwait(false), UpdatePersistentResourceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RebootPersistentResource</c>.</summary>
        public override lro::OperationsClient RebootPersistentResourceOperationsClient { get; }

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata> RebootPersistentResource(RebootPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RebootPersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>(_callRebootPersistentResource.Sync(request, callSettings), RebootPersistentResourceOperationsClient);
        }

        /// <summary>
        /// Reboots a PersistentResource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>> RebootPersistentResourceAsync(RebootPersistentResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RebootPersistentResourceRequest(ref request, ref callSettings);
            return new lro::Operation<PersistentResource, RebootPersistentResourceOperationMetadata>(await _callRebootPersistentResource.Async(request, callSettings).ConfigureAwait(false), RebootPersistentResourceOperationsClient);
        }
    }

    public partial class ListPersistentResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPersistentResourcesResponse : gaxgrpc::IPageResponse<PersistentResource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PersistentResource> GetEnumerator() => PersistentResources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PersistentResourceService
    {
        public partial class PersistentResourceServiceClient
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

    public static partial class PersistentResourceService
    {
        public partial class PersistentResourceServiceClient
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
