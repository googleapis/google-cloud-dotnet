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
    /// <summary>Settings for <see cref="NotebookServiceClient"/> instances.</summary>
    public sealed partial class NotebookServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NotebookServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NotebookServiceSettings"/>.</returns>
        public static NotebookServiceSettings GetDefault() => new NotebookServiceSettings();

        /// <summary>Constructs a new <see cref="NotebookServiceSettings"/> object with default settings.</summary>
        public NotebookServiceSettings()
        {
        }

        private NotebookServiceSettings(NotebookServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateNotebookRuntimeTemplateSettings = existing.CreateNotebookRuntimeTemplateSettings;
            CreateNotebookRuntimeTemplateOperationsSettings = existing.CreateNotebookRuntimeTemplateOperationsSettings.Clone();
            GetNotebookRuntimeTemplateSettings = existing.GetNotebookRuntimeTemplateSettings;
            ListNotebookRuntimeTemplatesSettings = existing.ListNotebookRuntimeTemplatesSettings;
            DeleteNotebookRuntimeTemplateSettings = existing.DeleteNotebookRuntimeTemplateSettings;
            DeleteNotebookRuntimeTemplateOperationsSettings = existing.DeleteNotebookRuntimeTemplateOperationsSettings.Clone();
            UpdateNotebookRuntimeTemplateSettings = existing.UpdateNotebookRuntimeTemplateSettings;
            AssignNotebookRuntimeSettings = existing.AssignNotebookRuntimeSettings;
            AssignNotebookRuntimeOperationsSettings = existing.AssignNotebookRuntimeOperationsSettings.Clone();
            GetNotebookRuntimeSettings = existing.GetNotebookRuntimeSettings;
            ListNotebookRuntimesSettings = existing.ListNotebookRuntimesSettings;
            DeleteNotebookRuntimeSettings = existing.DeleteNotebookRuntimeSettings;
            DeleteNotebookRuntimeOperationsSettings = existing.DeleteNotebookRuntimeOperationsSettings.Clone();
            UpgradeNotebookRuntimeSettings = existing.UpgradeNotebookRuntimeSettings;
            UpgradeNotebookRuntimeOperationsSettings = existing.UpgradeNotebookRuntimeOperationsSettings.Clone();
            StartNotebookRuntimeSettings = existing.StartNotebookRuntimeSettings;
            StartNotebookRuntimeOperationsSettings = existing.StartNotebookRuntimeOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(NotebookServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.CreateNotebookRuntimeTemplate</c> and
        /// <c>NotebookServiceClient.CreateNotebookRuntimeTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNotebookRuntimeTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.CreateNotebookRuntimeTemplate</c> and
        /// <c>NotebookServiceClient.CreateNotebookRuntimeTemplateAsync</c>.
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
        public lro::OperationsSettings CreateNotebookRuntimeTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.GetNotebookRuntimeTemplate</c> and
        /// <c>NotebookServiceClient.GetNotebookRuntimeTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNotebookRuntimeTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ListNotebookRuntimeTemplates</c> and
        /// <c>NotebookServiceClient.ListNotebookRuntimeTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNotebookRuntimeTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.DeleteNotebookRuntimeTemplate</c> and
        /// <c>NotebookServiceClient.DeleteNotebookRuntimeTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNotebookRuntimeTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.DeleteNotebookRuntimeTemplate</c> and
        /// <c>NotebookServiceClient.DeleteNotebookRuntimeTemplateAsync</c>.
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
        public lro::OperationsSettings DeleteNotebookRuntimeTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.UpdateNotebookRuntimeTemplate</c> and
        /// <c>NotebookServiceClient.UpdateNotebookRuntimeTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNotebookRuntimeTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.AssignNotebookRuntime</c> and <c>NotebookServiceClient.AssignNotebookRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AssignNotebookRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.AssignNotebookRuntime</c> and
        /// <c>NotebookServiceClient.AssignNotebookRuntimeAsync</c>.
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
        public lro::OperationsSettings AssignNotebookRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.GetNotebookRuntime</c> and <c>NotebookServiceClient.GetNotebookRuntimeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNotebookRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ListNotebookRuntimes</c> and <c>NotebookServiceClient.ListNotebookRuntimesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNotebookRuntimesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.DeleteNotebookRuntime</c> and <c>NotebookServiceClient.DeleteNotebookRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNotebookRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.DeleteNotebookRuntime</c> and
        /// <c>NotebookServiceClient.DeleteNotebookRuntimeAsync</c>.
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
        public lro::OperationsSettings DeleteNotebookRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.UpgradeNotebookRuntime</c> and <c>NotebookServiceClient.UpgradeNotebookRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpgradeNotebookRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.UpgradeNotebookRuntime</c> and
        /// <c>NotebookServiceClient.UpgradeNotebookRuntimeAsync</c>.
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
        public lro::OperationsSettings UpgradeNotebookRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.StartNotebookRuntime</c> and <c>NotebookServiceClient.StartNotebookRuntimeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartNotebookRuntimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.StartNotebookRuntime</c> and
        /// <c>NotebookServiceClient.StartNotebookRuntimeAsync</c>.
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
        public lro::OperationsSettings StartNotebookRuntimeOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="NotebookServiceSettings"/> object.</returns>
        public NotebookServiceSettings Clone() => new NotebookServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NotebookServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class NotebookServiceClientBuilder : gaxgrpc::ClientBuilderBase<NotebookServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NotebookServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NotebookServiceClientBuilder() : base(NotebookServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NotebookServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NotebookServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NotebookServiceClient Build()
        {
            NotebookServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NotebookServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NotebookServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NotebookServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NotebookServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NotebookServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NotebookServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NotebookServiceClient.ChannelPool;
    }

    /// <summary>NotebookService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The interface for Vertex Notebook service (a.k.a. Colab on Workbench).
    /// </remarks>
    public abstract partial class NotebookServiceClient
    {
        /// <summary>
        /// The default endpoint for the NotebookService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default NotebookService scopes.</summary>
        /// <remarks>
        /// The default NotebookService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NotebookService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NotebookServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NotebookServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NotebookServiceClient"/>.</returns>
        public static stt::Task<NotebookServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NotebookServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NotebookServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NotebookServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NotebookServiceClient"/>.</returns>
        public static NotebookServiceClient Create() => new NotebookServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NotebookServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NotebookServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NotebookServiceClient"/>.</returns>
        internal static NotebookServiceClient Create(grpccore::CallInvoker callInvoker, NotebookServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NotebookService.NotebookServiceClient grpcClient = new NotebookService.NotebookServiceClient(callInvoker);
            return new NotebookServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NotebookService client</summary>
        public virtual NotebookService.NotebookServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> CreateNotebookRuntimeTemplate(CreateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> CreateNotebookRuntimeTemplateAsync(CreateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> CreateNotebookRuntimeTemplateAsync(CreateNotebookRuntimeTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateNotebookRuntimeTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateNotebookRuntimeTemplate</c>.</summary>
        public virtual lro::OperationsClient CreateNotebookRuntimeTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateNotebookRuntimeTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> PollOnceCreateNotebookRuntimeTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNotebookRuntimeTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateNotebookRuntimeTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> PollOnceCreateNotebookRuntimeTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNotebookRuntimeTemplateOperationsClient, callSettings);

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// NotebookRuntimeTemplate. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to create.
        /// </param>
        /// <param name="notebookRuntimeTemplateId">
        /// Optional. User specified ID for the notebook runtime template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> CreateNotebookRuntimeTemplate(string parent, NotebookRuntimeTemplate notebookRuntimeTemplate, string notebookRuntimeTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotebookRuntimeTemplate(new CreateNotebookRuntimeTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntimeTemplateId = notebookRuntimeTemplateId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// NotebookRuntimeTemplate. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to create.
        /// </param>
        /// <param name="notebookRuntimeTemplateId">
        /// Optional. User specified ID for the notebook runtime template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> CreateNotebookRuntimeTemplateAsync(string parent, NotebookRuntimeTemplate notebookRuntimeTemplate, string notebookRuntimeTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotebookRuntimeTemplateAsync(new CreateNotebookRuntimeTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntimeTemplateId = notebookRuntimeTemplateId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// NotebookRuntimeTemplate. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to create.
        /// </param>
        /// <param name="notebookRuntimeTemplateId">
        /// Optional. User specified ID for the notebook runtime template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> CreateNotebookRuntimeTemplateAsync(string parent, NotebookRuntimeTemplate notebookRuntimeTemplate, string notebookRuntimeTemplateId, st::CancellationToken cancellationToken) =>
            CreateNotebookRuntimeTemplateAsync(parent, notebookRuntimeTemplate, notebookRuntimeTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// NotebookRuntimeTemplate. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to create.
        /// </param>
        /// <param name="notebookRuntimeTemplateId">
        /// Optional. User specified ID for the notebook runtime template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> CreateNotebookRuntimeTemplate(gagr::LocationName parent, NotebookRuntimeTemplate notebookRuntimeTemplate, string notebookRuntimeTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotebookRuntimeTemplate(new CreateNotebookRuntimeTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntimeTemplateId = notebookRuntimeTemplateId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// NotebookRuntimeTemplate. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to create.
        /// </param>
        /// <param name="notebookRuntimeTemplateId">
        /// Optional. User specified ID for the notebook runtime template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> CreateNotebookRuntimeTemplateAsync(gagr::LocationName parent, NotebookRuntimeTemplate notebookRuntimeTemplate, string notebookRuntimeTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotebookRuntimeTemplateAsync(new CreateNotebookRuntimeTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntimeTemplateId = notebookRuntimeTemplateId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// NotebookRuntimeTemplate. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to create.
        /// </param>
        /// <param name="notebookRuntimeTemplateId">
        /// Optional. User specified ID for the notebook runtime template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> CreateNotebookRuntimeTemplateAsync(gagr::LocationName parent, NotebookRuntimeTemplate notebookRuntimeTemplate, string notebookRuntimeTemplateId, st::CancellationToken cancellationToken) =>
            CreateNotebookRuntimeTemplateAsync(parent, notebookRuntimeTemplate, notebookRuntimeTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntimeTemplate GetNotebookRuntimeTemplate(GetNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> GetNotebookRuntimeTemplateAsync(GetNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> GetNotebookRuntimeTemplateAsync(GetNotebookRuntimeTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetNotebookRuntimeTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntimeTemplate GetNotebookRuntimeTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntimeTemplate(new GetNotebookRuntimeTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> GetNotebookRuntimeTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntimeTemplateAsync(new GetNotebookRuntimeTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> GetNotebookRuntimeTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotebookRuntimeTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntimeTemplate GetNotebookRuntimeTemplate(NotebookRuntimeTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntimeTemplate(new GetNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> GetNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntimeTemplateAsync(new GetNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> GetNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName name, st::CancellationToken cancellationToken) =>
            GetNotebookRuntimeTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplates(ListNotebookRuntimeTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplatesAsync(ListNotebookRuntimeTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimeTemplates.
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
        /// <returns>A pageable sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimeTemplates(new ListNotebookRuntimeTemplatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimeTemplates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimeTemplatesAsync(new ListNotebookRuntimeTemplatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimeTemplates.
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
        /// <returns>A pageable sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimeTemplates(new ListNotebookRuntimeTemplatesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimeTemplates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimeTemplatesAsync(new ListNotebookRuntimeTemplatesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntimeTemplate(DeleteNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeTemplateAsync(DeleteNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeTemplateAsync(DeleteNotebookRuntimeTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteNotebookRuntimeTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteNotebookRuntimeTemplate</c>.</summary>
        public virtual lro::OperationsClient DeleteNotebookRuntimeTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNotebookRuntimeTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteNotebookRuntimeTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNotebookRuntimeTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNotebookRuntimeTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteNotebookRuntimeTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNotebookRuntimeTemplateOperationsClient, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntimeTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntimeTemplate(new DeleteNotebookRuntimeTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntimeTemplateAsync(new DeleteNotebookRuntimeTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNotebookRuntimeTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntimeTemplate(NotebookRuntimeTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntimeTemplate(new DeleteNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntimeTemplateAsync(new DeleteNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntimeTemplate resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/notebookRuntimeTemplates/{notebook_runtime_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeTemplateAsync(NotebookRuntimeTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteNotebookRuntimeTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntimeTemplate UpdateNotebookRuntimeTemplate(UpdateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> UpdateNotebookRuntimeTemplateAsync(UpdateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> UpdateNotebookRuntimeTemplateAsync(UpdateNotebookRuntimeTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateNotebookRuntimeTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask]. Input format:
        /// `{paths: "${updated_filed}"}` Updatable fields:
        /// 
        /// * `encryption_spec.kms_key_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntimeTemplate UpdateNotebookRuntimeTemplate(NotebookRuntimeTemplate notebookRuntimeTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotebookRuntimeTemplate(new UpdateNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask]. Input format:
        /// `{paths: "${updated_filed}"}` Updatable fields:
        /// 
        /// * `encryption_spec.kms_key_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> UpdateNotebookRuntimeTemplateAsync(NotebookRuntimeTemplate notebookRuntimeTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotebookRuntimeTemplateAsync(new UpdateNotebookRuntimeTemplateRequest
            {
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The NotebookRuntimeTemplate to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask]. Input format:
        /// `{paths: "${updated_filed}"}` Updatable fields:
        /// 
        /// * `encryption_spec.kms_key_name`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntimeTemplate> UpdateNotebookRuntimeTemplateAsync(NotebookRuntimeTemplate notebookRuntimeTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNotebookRuntimeTemplateAsync(notebookRuntimeTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> AssignNotebookRuntime(AssignNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> AssignNotebookRuntimeAsync(AssignNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> AssignNotebookRuntimeAsync(AssignNotebookRuntimeRequest request, st::CancellationToken cancellationToken) =>
            AssignNotebookRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AssignNotebookRuntime</c>.</summary>
        public virtual lro::OperationsClient AssignNotebookRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AssignNotebookRuntime</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> PollOnceAssignNotebookRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AssignNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AssignNotebookRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> PollOnceAssignNotebookRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AssignNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the NotebookRuntime
        /// assignment. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The resource name of the NotebookRuntimeTemplate based on which a
        /// NotebookRuntime will be assigned (reuse or create a new one).
        /// </param>
        /// <param name="notebookRuntime">
        /// Required. Provide runtime specific information (e.g. runtime owner,
        /// notebook id) used for NotebookRuntime assignment.
        /// </param>
        /// <param name="notebookRuntimeId">
        /// Optional. User specified ID for the notebook runtime.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> AssignNotebookRuntime(string parent, string notebookRuntimeTemplate, NotebookRuntime notebookRuntime, string notebookRuntimeId, gaxgrpc::CallSettings callSettings = null) =>
            AssignNotebookRuntime(new AssignNotebookRuntimeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntime = gax::GaxPreconditions.CheckNotNull(notebookRuntime, nameof(notebookRuntime)),
                NotebookRuntimeId = notebookRuntimeId ?? "",
            }, callSettings);

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the NotebookRuntime
        /// assignment. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The resource name of the NotebookRuntimeTemplate based on which a
        /// NotebookRuntime will be assigned (reuse or create a new one).
        /// </param>
        /// <param name="notebookRuntime">
        /// Required. Provide runtime specific information (e.g. runtime owner,
        /// notebook id) used for NotebookRuntime assignment.
        /// </param>
        /// <param name="notebookRuntimeId">
        /// Optional. User specified ID for the notebook runtime.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> AssignNotebookRuntimeAsync(string parent, string notebookRuntimeTemplate, NotebookRuntime notebookRuntime, string notebookRuntimeId, gaxgrpc::CallSettings callSettings = null) =>
            AssignNotebookRuntimeAsync(new AssignNotebookRuntimeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotebookRuntimeTemplate = gax::GaxPreconditions.CheckNotNullOrEmpty(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntime = gax::GaxPreconditions.CheckNotNull(notebookRuntime, nameof(notebookRuntime)),
                NotebookRuntimeId = notebookRuntimeId ?? "",
            }, callSettings);

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the NotebookRuntime
        /// assignment. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The resource name of the NotebookRuntimeTemplate based on which a
        /// NotebookRuntime will be assigned (reuse or create a new one).
        /// </param>
        /// <param name="notebookRuntime">
        /// Required. Provide runtime specific information (e.g. runtime owner,
        /// notebook id) used for NotebookRuntime assignment.
        /// </param>
        /// <param name="notebookRuntimeId">
        /// Optional. User specified ID for the notebook runtime.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> AssignNotebookRuntimeAsync(string parent, string notebookRuntimeTemplate, NotebookRuntime notebookRuntime, string notebookRuntimeId, st::CancellationToken cancellationToken) =>
            AssignNotebookRuntimeAsync(parent, notebookRuntimeTemplate, notebookRuntime, notebookRuntimeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the NotebookRuntime
        /// assignment. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The resource name of the NotebookRuntimeTemplate based on which a
        /// NotebookRuntime will be assigned (reuse or create a new one).
        /// </param>
        /// <param name="notebookRuntime">
        /// Required. Provide runtime specific information (e.g. runtime owner,
        /// notebook id) used for NotebookRuntime assignment.
        /// </param>
        /// <param name="notebookRuntimeId">
        /// Optional. User specified ID for the notebook runtime.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> AssignNotebookRuntime(gagr::LocationName parent, NotebookRuntimeTemplateName notebookRuntimeTemplate, NotebookRuntime notebookRuntime, string notebookRuntimeId, gaxgrpc::CallSettings callSettings = null) =>
            AssignNotebookRuntime(new AssignNotebookRuntimeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotebookRuntimeTemplateAsNotebookRuntimeTemplateName = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntime = gax::GaxPreconditions.CheckNotNull(notebookRuntime, nameof(notebookRuntime)),
                NotebookRuntimeId = notebookRuntimeId ?? "",
            }, callSettings);

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the NotebookRuntime
        /// assignment. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The resource name of the NotebookRuntimeTemplate based on which a
        /// NotebookRuntime will be assigned (reuse or create a new one).
        /// </param>
        /// <param name="notebookRuntime">
        /// Required. Provide runtime specific information (e.g. runtime owner,
        /// notebook id) used for NotebookRuntime assignment.
        /// </param>
        /// <param name="notebookRuntimeId">
        /// Optional. User specified ID for the notebook runtime.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> AssignNotebookRuntimeAsync(gagr::LocationName parent, NotebookRuntimeTemplateName notebookRuntimeTemplate, NotebookRuntime notebookRuntime, string notebookRuntimeId, gaxgrpc::CallSettings callSettings = null) =>
            AssignNotebookRuntimeAsync(new AssignNotebookRuntimeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotebookRuntimeTemplateAsNotebookRuntimeTemplateName = gax::GaxPreconditions.CheckNotNull(notebookRuntimeTemplate, nameof(notebookRuntimeTemplate)),
                NotebookRuntime = gax::GaxPreconditions.CheckNotNull(notebookRuntime, nameof(notebookRuntime)),
                NotebookRuntimeId = notebookRuntimeId ?? "",
            }, callSettings);

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the NotebookRuntime
        /// assignment. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="notebookRuntimeTemplate">
        /// Required. The resource name of the NotebookRuntimeTemplate based on which a
        /// NotebookRuntime will be assigned (reuse or create a new one).
        /// </param>
        /// <param name="notebookRuntime">
        /// Required. Provide runtime specific information (e.g. runtime owner,
        /// notebook id) used for NotebookRuntime assignment.
        /// </param>
        /// <param name="notebookRuntimeId">
        /// Optional. User specified ID for the notebook runtime.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> AssignNotebookRuntimeAsync(gagr::LocationName parent, NotebookRuntimeTemplateName notebookRuntimeTemplate, NotebookRuntime notebookRuntime, string notebookRuntimeId, st::CancellationToken cancellationToken) =>
            AssignNotebookRuntimeAsync(parent, notebookRuntimeTemplate, notebookRuntime, notebookRuntimeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntime GetNotebookRuntime(GetNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntime> GetNotebookRuntimeAsync(GetNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntime> GetNotebookRuntimeAsync(GetNotebookRuntimeRequest request, st::CancellationToken cancellationToken) =>
            GetNotebookRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntime GetNotebookRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntime(new GetNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntime> GetNotebookRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntimeAsync(new GetNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntime> GetNotebookRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotebookRuntime GetNotebookRuntime(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntime(new GetNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntime> GetNotebookRuntimeAsync(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotebookRuntimeAsync(new GetNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotebookRuntime> GetNotebookRuntimeAsync(NotebookRuntimeName name, st::CancellationToken cancellationToken) =>
            GetNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimes(ListNotebookRuntimesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimesAsync(ListNotebookRuntimesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimes.
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
        /// <returns>A pageable sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimes(new ListNotebookRuntimesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimesAsync(new ListNotebookRuntimesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimes.
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
        /// <returns>A pageable sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimes(new ListNotebookRuntimesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// NotebookRuntimes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNotebookRuntimesAsync(new ListNotebookRuntimesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntime(DeleteNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeAsync(DeleteNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeAsync(DeleteNotebookRuntimeRequest request, st::CancellationToken cancellationToken) =>
            DeleteNotebookRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteNotebookRuntime</c>.</summary>
        public virtual lro::OperationsClient DeleteNotebookRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteNotebookRuntime</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteNotebookRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNotebookRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteNotebookRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be deleted.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntime(new DeleteNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be deleted.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntimeAsync(new DeleteNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be deleted.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be deleted.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntime(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntime(new DeleteNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be deleted.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeAsync(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotebookRuntimeAsync(new DeleteNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be deleted.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeAsync(NotebookRuntimeName name, st::CancellationToken cancellationToken) =>
            DeleteNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> UpgradeNotebookRuntime(UpgradeNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> UpgradeNotebookRuntimeAsync(UpgradeNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> UpgradeNotebookRuntimeAsync(UpgradeNotebookRuntimeRequest request, st::CancellationToken cancellationToken) =>
            UpgradeNotebookRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpgradeNotebookRuntime</c>.</summary>
        public virtual lro::OperationsClient UpgradeNotebookRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeNotebookRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> PollOnceUpgradeNotebookRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeNotebookRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> PollOnceUpgradeNotebookRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be upgrade.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> UpgradeNotebookRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeNotebookRuntime(new UpgradeNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be upgrade.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> UpgradeNotebookRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeNotebookRuntimeAsync(new UpgradeNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be upgrade.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> UpgradeNotebookRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            UpgradeNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be upgrade.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> UpgradeNotebookRuntime(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeNotebookRuntime(new UpgradeNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be upgrade.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> UpgradeNotebookRuntimeAsync(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeNotebookRuntimeAsync(new UpgradeNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be upgrade.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> UpgradeNotebookRuntimeAsync(NotebookRuntimeName name, st::CancellationToken cancellationToken) =>
            UpgradeNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> StartNotebookRuntime(StartNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> StartNotebookRuntimeAsync(StartNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> StartNotebookRuntimeAsync(StartNotebookRuntimeRequest request, st::CancellationToken cancellationToken) =>
            StartNotebookRuntimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartNotebookRuntime</c>.</summary>
        public virtual lro::OperationsClient StartNotebookRuntimeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartNotebookRuntime</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> PollOnceStartNotebookRuntime(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartNotebookRuntime</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> PollOnceStartNotebookRuntimeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartNotebookRuntimeOperationsClient, callSettings);

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be started.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> StartNotebookRuntime(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartNotebookRuntime(new StartNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be started.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> StartNotebookRuntimeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartNotebookRuntimeAsync(new StartNotebookRuntimeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be started.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> StartNotebookRuntimeAsync(string name, st::CancellationToken cancellationToken) =>
            StartNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be started.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> StartNotebookRuntime(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            StartNotebookRuntime(new StartNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be started.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> StartNotebookRuntimeAsync(NotebookRuntimeName name, gaxgrpc::CallSettings callSettings = null) =>
            StartNotebookRuntimeAsync(new StartNotebookRuntimeRequest
            {
                NotebookRuntimeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NotebookRuntime resource to be started.
        /// Instead of checking whether the name is in valid NotebookRuntime resource
        /// name format, directly throw NotFound exception if there is no such
        /// NotebookRuntime in spanner.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> StartNotebookRuntimeAsync(NotebookRuntimeName name, st::CancellationToken cancellationToken) =>
            StartNotebookRuntimeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NotebookService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The interface for Vertex Notebook service (a.k.a. Colab on Workbench).
    /// </remarks>
    public sealed partial class NotebookServiceClientImpl : NotebookServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateNotebookRuntimeTemplateRequest, lro::Operation> _callCreateNotebookRuntimeTemplate;

        private readonly gaxgrpc::ApiCall<GetNotebookRuntimeTemplateRequest, NotebookRuntimeTemplate> _callGetNotebookRuntimeTemplate;

        private readonly gaxgrpc::ApiCall<ListNotebookRuntimeTemplatesRequest, ListNotebookRuntimeTemplatesResponse> _callListNotebookRuntimeTemplates;

        private readonly gaxgrpc::ApiCall<DeleteNotebookRuntimeTemplateRequest, lro::Operation> _callDeleteNotebookRuntimeTemplate;

        private readonly gaxgrpc::ApiCall<UpdateNotebookRuntimeTemplateRequest, NotebookRuntimeTemplate> _callUpdateNotebookRuntimeTemplate;

        private readonly gaxgrpc::ApiCall<AssignNotebookRuntimeRequest, lro::Operation> _callAssignNotebookRuntime;

        private readonly gaxgrpc::ApiCall<GetNotebookRuntimeRequest, NotebookRuntime> _callGetNotebookRuntime;

        private readonly gaxgrpc::ApiCall<ListNotebookRuntimesRequest, ListNotebookRuntimesResponse> _callListNotebookRuntimes;

        private readonly gaxgrpc::ApiCall<DeleteNotebookRuntimeRequest, lro::Operation> _callDeleteNotebookRuntime;

        private readonly gaxgrpc::ApiCall<UpgradeNotebookRuntimeRequest, lro::Operation> _callUpgradeNotebookRuntime;

        private readonly gaxgrpc::ApiCall<StartNotebookRuntimeRequest, lro::Operation> _callStartNotebookRuntime;

        /// <summary>
        /// Constructs a client wrapper for the NotebookService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NotebookServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NotebookServiceClientImpl(NotebookService.NotebookServiceClient grpcClient, NotebookServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NotebookServiceSettings effectiveSettings = settings ?? NotebookServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateNotebookRuntimeTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateNotebookRuntimeTemplateOperationsSettings, logger);
            DeleteNotebookRuntimeTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteNotebookRuntimeTemplateOperationsSettings, logger);
            AssignNotebookRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AssignNotebookRuntimeOperationsSettings, logger);
            DeleteNotebookRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteNotebookRuntimeOperationsSettings, logger);
            UpgradeNotebookRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpgradeNotebookRuntimeOperationsSettings, logger);
            StartNotebookRuntimeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartNotebookRuntimeOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateNotebookRuntimeTemplate = clientHelper.BuildApiCall<CreateNotebookRuntimeTemplateRequest, lro::Operation>("CreateNotebookRuntimeTemplate", grpcClient.CreateNotebookRuntimeTemplateAsync, grpcClient.CreateNotebookRuntimeTemplate, effectiveSettings.CreateNotebookRuntimeTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNotebookRuntimeTemplate);
            Modify_CreateNotebookRuntimeTemplateApiCall(ref _callCreateNotebookRuntimeTemplate);
            _callGetNotebookRuntimeTemplate = clientHelper.BuildApiCall<GetNotebookRuntimeTemplateRequest, NotebookRuntimeTemplate>("GetNotebookRuntimeTemplate", grpcClient.GetNotebookRuntimeTemplateAsync, grpcClient.GetNotebookRuntimeTemplate, effectiveSettings.GetNotebookRuntimeTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotebookRuntimeTemplate);
            Modify_GetNotebookRuntimeTemplateApiCall(ref _callGetNotebookRuntimeTemplate);
            _callListNotebookRuntimeTemplates = clientHelper.BuildApiCall<ListNotebookRuntimeTemplatesRequest, ListNotebookRuntimeTemplatesResponse>("ListNotebookRuntimeTemplates", grpcClient.ListNotebookRuntimeTemplatesAsync, grpcClient.ListNotebookRuntimeTemplates, effectiveSettings.ListNotebookRuntimeTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNotebookRuntimeTemplates);
            Modify_ListNotebookRuntimeTemplatesApiCall(ref _callListNotebookRuntimeTemplates);
            _callDeleteNotebookRuntimeTemplate = clientHelper.BuildApiCall<DeleteNotebookRuntimeTemplateRequest, lro::Operation>("DeleteNotebookRuntimeTemplate", grpcClient.DeleteNotebookRuntimeTemplateAsync, grpcClient.DeleteNotebookRuntimeTemplate, effectiveSettings.DeleteNotebookRuntimeTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNotebookRuntimeTemplate);
            Modify_DeleteNotebookRuntimeTemplateApiCall(ref _callDeleteNotebookRuntimeTemplate);
            _callUpdateNotebookRuntimeTemplate = clientHelper.BuildApiCall<UpdateNotebookRuntimeTemplateRequest, NotebookRuntimeTemplate>("UpdateNotebookRuntimeTemplate", grpcClient.UpdateNotebookRuntimeTemplateAsync, grpcClient.UpdateNotebookRuntimeTemplate, effectiveSettings.UpdateNotebookRuntimeTemplateSettings).WithGoogleRequestParam("notebook_runtime_template.name", request => request.NotebookRuntimeTemplate?.Name);
            Modify_ApiCall(ref _callUpdateNotebookRuntimeTemplate);
            Modify_UpdateNotebookRuntimeTemplateApiCall(ref _callUpdateNotebookRuntimeTemplate);
            _callAssignNotebookRuntime = clientHelper.BuildApiCall<AssignNotebookRuntimeRequest, lro::Operation>("AssignNotebookRuntime", grpcClient.AssignNotebookRuntimeAsync, grpcClient.AssignNotebookRuntime, effectiveSettings.AssignNotebookRuntimeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAssignNotebookRuntime);
            Modify_AssignNotebookRuntimeApiCall(ref _callAssignNotebookRuntime);
            _callGetNotebookRuntime = clientHelper.BuildApiCall<GetNotebookRuntimeRequest, NotebookRuntime>("GetNotebookRuntime", grpcClient.GetNotebookRuntimeAsync, grpcClient.GetNotebookRuntime, effectiveSettings.GetNotebookRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotebookRuntime);
            Modify_GetNotebookRuntimeApiCall(ref _callGetNotebookRuntime);
            _callListNotebookRuntimes = clientHelper.BuildApiCall<ListNotebookRuntimesRequest, ListNotebookRuntimesResponse>("ListNotebookRuntimes", grpcClient.ListNotebookRuntimesAsync, grpcClient.ListNotebookRuntimes, effectiveSettings.ListNotebookRuntimesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNotebookRuntimes);
            Modify_ListNotebookRuntimesApiCall(ref _callListNotebookRuntimes);
            _callDeleteNotebookRuntime = clientHelper.BuildApiCall<DeleteNotebookRuntimeRequest, lro::Operation>("DeleteNotebookRuntime", grpcClient.DeleteNotebookRuntimeAsync, grpcClient.DeleteNotebookRuntime, effectiveSettings.DeleteNotebookRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNotebookRuntime);
            Modify_DeleteNotebookRuntimeApiCall(ref _callDeleteNotebookRuntime);
            _callUpgradeNotebookRuntime = clientHelper.BuildApiCall<UpgradeNotebookRuntimeRequest, lro::Operation>("UpgradeNotebookRuntime", grpcClient.UpgradeNotebookRuntimeAsync, grpcClient.UpgradeNotebookRuntime, effectiveSettings.UpgradeNotebookRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpgradeNotebookRuntime);
            Modify_UpgradeNotebookRuntimeApiCall(ref _callUpgradeNotebookRuntime);
            _callStartNotebookRuntime = clientHelper.BuildApiCall<StartNotebookRuntimeRequest, lro::Operation>("StartNotebookRuntime", grpcClient.StartNotebookRuntimeAsync, grpcClient.StartNotebookRuntime, effectiveSettings.StartNotebookRuntimeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartNotebookRuntime);
            Modify_StartNotebookRuntimeApiCall(ref _callStartNotebookRuntime);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateNotebookRuntimeTemplateApiCall(ref gaxgrpc::ApiCall<CreateNotebookRuntimeTemplateRequest, lro::Operation> call);

        partial void Modify_GetNotebookRuntimeTemplateApiCall(ref gaxgrpc::ApiCall<GetNotebookRuntimeTemplateRequest, NotebookRuntimeTemplate> call);

        partial void Modify_ListNotebookRuntimeTemplatesApiCall(ref gaxgrpc::ApiCall<ListNotebookRuntimeTemplatesRequest, ListNotebookRuntimeTemplatesResponse> call);

        partial void Modify_DeleteNotebookRuntimeTemplateApiCall(ref gaxgrpc::ApiCall<DeleteNotebookRuntimeTemplateRequest, lro::Operation> call);

        partial void Modify_UpdateNotebookRuntimeTemplateApiCall(ref gaxgrpc::ApiCall<UpdateNotebookRuntimeTemplateRequest, NotebookRuntimeTemplate> call);

        partial void Modify_AssignNotebookRuntimeApiCall(ref gaxgrpc::ApiCall<AssignNotebookRuntimeRequest, lro::Operation> call);

        partial void Modify_GetNotebookRuntimeApiCall(ref gaxgrpc::ApiCall<GetNotebookRuntimeRequest, NotebookRuntime> call);

        partial void Modify_ListNotebookRuntimesApiCall(ref gaxgrpc::ApiCall<ListNotebookRuntimesRequest, ListNotebookRuntimesResponse> call);

        partial void Modify_DeleteNotebookRuntimeApiCall(ref gaxgrpc::ApiCall<DeleteNotebookRuntimeRequest, lro::Operation> call);

        partial void Modify_UpgradeNotebookRuntimeApiCall(ref gaxgrpc::ApiCall<UpgradeNotebookRuntimeRequest, lro::Operation> call);

        partial void Modify_StartNotebookRuntimeApiCall(ref gaxgrpc::ApiCall<StartNotebookRuntimeRequest, lro::Operation> call);

        partial void OnConstruction(NotebookService.NotebookServiceClient grpcClient, NotebookServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NotebookService client</summary>
        public override NotebookService.NotebookServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateNotebookRuntimeTemplateRequest(ref CreateNotebookRuntimeTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotebookRuntimeTemplateRequest(ref GetNotebookRuntimeTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNotebookRuntimeTemplatesRequest(ref ListNotebookRuntimeTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNotebookRuntimeTemplateRequest(ref DeleteNotebookRuntimeTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNotebookRuntimeTemplateRequest(ref UpdateNotebookRuntimeTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AssignNotebookRuntimeRequest(ref AssignNotebookRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotebookRuntimeRequest(ref GetNotebookRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNotebookRuntimesRequest(ref ListNotebookRuntimesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNotebookRuntimeRequest(ref DeleteNotebookRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpgradeNotebookRuntimeRequest(ref UpgradeNotebookRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartNotebookRuntimeRequest(ref StartNotebookRuntimeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateNotebookRuntimeTemplate</c>.</summary>
        public override lro::OperationsClient CreateNotebookRuntimeTemplateOperationsClient { get; }

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata> CreateNotebookRuntimeTemplate(CreateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>(_callCreateNotebookRuntimeTemplate.Sync(request, callSettings), CreateNotebookRuntimeTemplateOperationsClient);
        }

        /// <summary>
        /// Creates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>> CreateNotebookRuntimeTemplateAsync(CreateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<NotebookRuntimeTemplate, CreateNotebookRuntimeTemplateOperationMetadata>(await _callCreateNotebookRuntimeTemplate.Async(request, callSettings).ConfigureAwait(false), CreateNotebookRuntimeTemplateOperationsClient);
        }

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotebookRuntimeTemplate GetNotebookRuntimeTemplate(GetNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return _callGetNotebookRuntimeTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotebookRuntimeTemplate> GetNotebookRuntimeTemplateAsync(GetNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return _callGetNotebookRuntimeTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplates(ListNotebookRuntimeTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotebookRuntimeTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotebookRuntimeTemplatesRequest, ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate>(_callListNotebookRuntimeTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists NotebookRuntimeTemplates in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntimeTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate> ListNotebookRuntimeTemplatesAsync(ListNotebookRuntimeTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotebookRuntimeTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotebookRuntimeTemplatesRequest, ListNotebookRuntimeTemplatesResponse, NotebookRuntimeTemplate>(_callListNotebookRuntimeTemplates, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteNotebookRuntimeTemplate</c>.</summary>
        public override lro::OperationsClient DeleteNotebookRuntimeTemplateOperationsClient { get; }

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntimeTemplate(DeleteNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteNotebookRuntimeTemplate.Sync(request, callSettings), DeleteNotebookRuntimeTemplateOperationsClient);
        }

        /// <summary>
        /// Deletes a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeTemplateAsync(DeleteNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteNotebookRuntimeTemplate.Async(request, callSettings).ConfigureAwait(false), DeleteNotebookRuntimeTemplateOperationsClient);
        }

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotebookRuntimeTemplate UpdateNotebookRuntimeTemplate(UpdateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return _callUpdateNotebookRuntimeTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a NotebookRuntimeTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotebookRuntimeTemplate> UpdateNotebookRuntimeTemplateAsync(UpdateNotebookRuntimeTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotebookRuntimeTemplateRequest(ref request, ref callSettings);
            return _callUpdateNotebookRuntimeTemplate.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>AssignNotebookRuntime</c>.</summary>
        public override lro::OperationsClient AssignNotebookRuntimeOperationsClient { get; }

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata> AssignNotebookRuntime(AssignNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AssignNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>(_callAssignNotebookRuntime.Sync(request, callSettings), AssignNotebookRuntimeOperationsClient);
        }

        /// <summary>
        /// Assigns a NotebookRuntime to a user for a particular Notebook file. This
        /// method will either returns an existing assignment or generates a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>> AssignNotebookRuntimeAsync(AssignNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AssignNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<NotebookRuntime, AssignNotebookRuntimeOperationMetadata>(await _callAssignNotebookRuntime.Async(request, callSettings).ConfigureAwait(false), AssignNotebookRuntimeOperationsClient);
        }

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotebookRuntime GetNotebookRuntime(GetNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotebookRuntimeRequest(ref request, ref callSettings);
            return _callGetNotebookRuntime.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotebookRuntime> GetNotebookRuntimeAsync(GetNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotebookRuntimeRequest(ref request, ref callSettings);
            return _callGetNotebookRuntime.Async(request, callSettings);
        }

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimes(ListNotebookRuntimesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotebookRuntimesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotebookRuntimesRequest, ListNotebookRuntimesResponse, NotebookRuntime>(_callListNotebookRuntimes, request, callSettings);
        }

        /// <summary>
        /// Lists NotebookRuntimes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotebookRuntime"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotebookRuntimesResponse, NotebookRuntime> ListNotebookRuntimesAsync(ListNotebookRuntimesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotebookRuntimesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotebookRuntimesRequest, ListNotebookRuntimesResponse, NotebookRuntime>(_callListNotebookRuntimes, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteNotebookRuntime</c>.</summary>
        public override lro::OperationsClient DeleteNotebookRuntimeOperationsClient { get; }

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNotebookRuntime(DeleteNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteNotebookRuntime.Sync(request, callSettings), DeleteNotebookRuntimeOperationsClient);
        }

        /// <summary>
        /// Deletes a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNotebookRuntimeAsync(DeleteNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteNotebookRuntime.Async(request, callSettings).ConfigureAwait(false), DeleteNotebookRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpgradeNotebookRuntime</c>.</summary>
        public override lro::OperationsClient UpgradeNotebookRuntimeOperationsClient { get; }

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata> UpgradeNotebookRuntime(UpgradeNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>(_callUpgradeNotebookRuntime.Sync(request, callSettings), UpgradeNotebookRuntimeOperationsClient);
        }

        /// <summary>
        /// Upgrades a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>> UpgradeNotebookRuntimeAsync(UpgradeNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<UpgradeNotebookRuntimeResponse, UpgradeNotebookRuntimeOperationMetadata>(await _callUpgradeNotebookRuntime.Async(request, callSettings).ConfigureAwait(false), UpgradeNotebookRuntimeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartNotebookRuntime</c>.</summary>
        public override lro::OperationsClient StartNotebookRuntimeOperationsClient { get; }

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata> StartNotebookRuntime(StartNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>(_callStartNotebookRuntime.Sync(request, callSettings), StartNotebookRuntimeOperationsClient);
        }

        /// <summary>
        /// Starts a NotebookRuntime.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>> StartNotebookRuntimeAsync(StartNotebookRuntimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartNotebookRuntimeRequest(ref request, ref callSettings);
            return new lro::Operation<StartNotebookRuntimeResponse, StartNotebookRuntimeOperationMetadata>(await _callStartNotebookRuntime.Async(request, callSettings).ConfigureAwait(false), StartNotebookRuntimeOperationsClient);
        }
    }

    public partial class ListNotebookRuntimeTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotebookRuntimesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotebookRuntimeTemplatesResponse : gaxgrpc::IPageResponse<NotebookRuntimeTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotebookRuntimeTemplate> GetEnumerator() => NotebookRuntimeTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotebookRuntimesResponse : gaxgrpc::IPageResponse<NotebookRuntime>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotebookRuntime> GetEnumerator() => NotebookRuntimes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NotebookService
    {
        public partial class NotebookServiceClient
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

    public static partial class NotebookService
    {
        public partial class NotebookServiceClient
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
