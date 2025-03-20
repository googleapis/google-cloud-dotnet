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
    /// <summary>Settings for <see cref="VertexRagDataServiceClient"/> instances.</summary>
    public sealed partial class VertexRagDataServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VertexRagDataServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VertexRagDataServiceSettings"/>.</returns>
        public static VertexRagDataServiceSettings GetDefault() => new VertexRagDataServiceSettings();

        /// <summary>Constructs a new <see cref="VertexRagDataServiceSettings"/> object with default settings.</summary>
        public VertexRagDataServiceSettings()
        {
        }

        private VertexRagDataServiceSettings(VertexRagDataServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateRagCorpusSettings = existing.CreateRagCorpusSettings;
            CreateRagCorpusOperationsSettings = existing.CreateRagCorpusOperationsSettings.Clone();
            UpdateRagCorpusSettings = existing.UpdateRagCorpusSettings;
            UpdateRagCorpusOperationsSettings = existing.UpdateRagCorpusOperationsSettings.Clone();
            GetRagCorpusSettings = existing.GetRagCorpusSettings;
            ListRagCorporaSettings = existing.ListRagCorporaSettings;
            DeleteRagCorpusSettings = existing.DeleteRagCorpusSettings;
            DeleteRagCorpusOperationsSettings = existing.DeleteRagCorpusOperationsSettings.Clone();
            UploadRagFileSettings = existing.UploadRagFileSettings;
            ImportRagFilesSettings = existing.ImportRagFilesSettings;
            ImportRagFilesOperationsSettings = existing.ImportRagFilesOperationsSettings.Clone();
            GetRagFileSettings = existing.GetRagFileSettings;
            ListRagFilesSettings = existing.ListRagFilesSettings;
            DeleteRagFileSettings = existing.DeleteRagFileSettings;
            DeleteRagFileOperationsSettings = existing.DeleteRagFileOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(VertexRagDataServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.CreateRagCorpus</c> and <c>VertexRagDataServiceClient.CreateRagCorpusAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRagCorpusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VertexRagDataServiceClient.CreateRagCorpus</c> and
        /// <c>VertexRagDataServiceClient.CreateRagCorpusAsync</c>.
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
        public lro::OperationsSettings CreateRagCorpusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.UpdateRagCorpus</c> and <c>VertexRagDataServiceClient.UpdateRagCorpusAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRagCorpusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VertexRagDataServiceClient.UpdateRagCorpus</c> and
        /// <c>VertexRagDataServiceClient.UpdateRagCorpusAsync</c>.
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
        public lro::OperationsSettings UpdateRagCorpusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.GetRagCorpus</c> and <c>VertexRagDataServiceClient.GetRagCorpusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRagCorpusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.ListRagCorpora</c> and <c>VertexRagDataServiceClient.ListRagCorporaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRagCorporaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.DeleteRagCorpus</c> and <c>VertexRagDataServiceClient.DeleteRagCorpusAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRagCorpusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VertexRagDataServiceClient.DeleteRagCorpus</c> and
        /// <c>VertexRagDataServiceClient.DeleteRagCorpusAsync</c>.
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
        public lro::OperationsSettings DeleteRagCorpusOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.UploadRagFile</c> and <c>VertexRagDataServiceClient.UploadRagFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadRagFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.ImportRagFiles</c> and <c>VertexRagDataServiceClient.ImportRagFilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportRagFilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VertexRagDataServiceClient.ImportRagFiles</c> and
        /// <c>VertexRagDataServiceClient.ImportRagFilesAsync</c>.
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
        public lro::OperationsSettings ImportRagFilesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.GetRagFile</c> and <c>VertexRagDataServiceClient.GetRagFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRagFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.ListRagFiles</c> and <c>VertexRagDataServiceClient.ListRagFilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRagFilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagDataServiceClient.DeleteRagFile</c> and <c>VertexRagDataServiceClient.DeleteRagFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRagFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VertexRagDataServiceClient.DeleteRagFile</c> and
        /// <c>VertexRagDataServiceClient.DeleteRagFileAsync</c>.
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
        public lro::OperationsSettings DeleteRagFileOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="VertexRagDataServiceSettings"/> object.</returns>
        public VertexRagDataServiceSettings Clone() => new VertexRagDataServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VertexRagDataServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class VertexRagDataServiceClientBuilder : gaxgrpc::ClientBuilderBase<VertexRagDataServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VertexRagDataServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VertexRagDataServiceClientBuilder() : base(VertexRagDataServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VertexRagDataServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VertexRagDataServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VertexRagDataServiceClient Build()
        {
            VertexRagDataServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VertexRagDataServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VertexRagDataServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VertexRagDataServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VertexRagDataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VertexRagDataServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VertexRagDataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VertexRagDataServiceClient.ChannelPool;
    }

    /// <summary>VertexRagDataService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing user data for RAG.
    /// </remarks>
    public abstract partial class VertexRagDataServiceClient
    {
        /// <summary>
        /// The default endpoint for the VertexRagDataService service, which is a host of "aiplatform.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default VertexRagDataService scopes.</summary>
        /// <remarks>
        /// The default VertexRagDataService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VertexRagDataService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VertexRagDataServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="VertexRagDataServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VertexRagDataServiceClient"/>.</returns>
        public static stt::Task<VertexRagDataServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VertexRagDataServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VertexRagDataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="VertexRagDataServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VertexRagDataServiceClient"/>.</returns>
        public static VertexRagDataServiceClient Create() => new VertexRagDataServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VertexRagDataServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VertexRagDataServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VertexRagDataServiceClient"/>.</returns>
        internal static VertexRagDataServiceClient Create(grpccore::CallInvoker callInvoker, VertexRagDataServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VertexRagDataService.VertexRagDataServiceClient grpcClient = new VertexRagDataService.VertexRagDataServiceClient(callInvoker);
            return new VertexRagDataServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VertexRagDataService client</summary>
        public virtual VertexRagDataService.VertexRagDataServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata> CreateRagCorpus(CreateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> CreateRagCorpusAsync(CreateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> CreateRagCorpusAsync(CreateRagCorpusRequest request, st::CancellationToken cancellationToken) =>
            CreateRagCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRagCorpus</c>.</summary>
        public virtual lro::OperationsClient CreateRagCorpusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRagCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata> PollOnceCreateRagCorpus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRagCorpusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRagCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> PollOnceCreateRagCorpusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRagCorpusOperationsClient, callSettings);

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the RagCorpus in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata> CreateRagCorpus(string parent, RagCorpus ragCorpus, gaxgrpc::CallSettings callSettings = null) =>
            CreateRagCorpus(new CreateRagCorpusRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RagCorpus = gax::GaxPreconditions.CheckNotNull(ragCorpus, nameof(ragCorpus)),
            }, callSettings);

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the RagCorpus in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> CreateRagCorpusAsync(string parent, RagCorpus ragCorpus, gaxgrpc::CallSettings callSettings = null) =>
            CreateRagCorpusAsync(new CreateRagCorpusRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RagCorpus = gax::GaxPreconditions.CheckNotNull(ragCorpus, nameof(ragCorpus)),
            }, callSettings);

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the RagCorpus in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> CreateRagCorpusAsync(string parent, RagCorpus ragCorpus, st::CancellationToken cancellationToken) =>
            CreateRagCorpusAsync(parent, ragCorpus, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the RagCorpus in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata> CreateRagCorpus(gagr::LocationName parent, RagCorpus ragCorpus, gaxgrpc::CallSettings callSettings = null) =>
            CreateRagCorpus(new CreateRagCorpusRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RagCorpus = gax::GaxPreconditions.CheckNotNull(ragCorpus, nameof(ragCorpus)),
            }, callSettings);

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the RagCorpus in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> CreateRagCorpusAsync(gagr::LocationName parent, RagCorpus ragCorpus, gaxgrpc::CallSettings callSettings = null) =>
            CreateRagCorpusAsync(new CreateRagCorpusRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RagCorpus = gax::GaxPreconditions.CheckNotNull(ragCorpus, nameof(ragCorpus)),
            }, callSettings);

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the RagCorpus in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> CreateRagCorpusAsync(gagr::LocationName parent, RagCorpus ragCorpus, st::CancellationToken cancellationToken) =>
            CreateRagCorpusAsync(parent, ragCorpus, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata> UpdateRagCorpus(UpdateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>> UpdateRagCorpusAsync(UpdateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>> UpdateRagCorpusAsync(UpdateRagCorpusRequest request, st::CancellationToken cancellationToken) =>
            UpdateRagCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRagCorpus</c>.</summary>
        public virtual lro::OperationsClient UpdateRagCorpusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRagCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata> PollOnceUpdateRagCorpus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRagCorpusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRagCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>> PollOnceUpdateRagCorpusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRagCorpusOperationsClient, callSettings);

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus which replaces the resource on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata> UpdateRagCorpus(RagCorpus ragCorpus, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRagCorpus(new UpdateRagCorpusRequest
            {
                RagCorpus = gax::GaxPreconditions.CheckNotNull(ragCorpus, nameof(ragCorpus)),
            }, callSettings);

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus which replaces the resource on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>> UpdateRagCorpusAsync(RagCorpus ragCorpus, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRagCorpusAsync(new UpdateRagCorpusRequest
            {
                RagCorpus = gax::GaxPreconditions.CheckNotNull(ragCorpus, nameof(ragCorpus)),
            }, callSettings);

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="ragCorpus">
        /// Required. The RagCorpus which replaces the resource on the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>> UpdateRagCorpusAsync(RagCorpus ragCorpus, st::CancellationToken cancellationToken) =>
            UpdateRagCorpusAsync(ragCorpus, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RagCorpus GetRagCorpus(GetRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagCorpus> GetRagCorpusAsync(GetRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagCorpus> GetRagCorpusAsync(GetRagCorpusRequest request, st::CancellationToken cancellationToken) =>
            GetRagCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RagCorpus GetRagCorpus(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagCorpus(new GetRagCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagCorpus> GetRagCorpusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagCorpusAsync(new GetRagCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagCorpus> GetRagCorpusAsync(string name, st::CancellationToken cancellationToken) =>
            GetRagCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RagCorpus GetRagCorpus(RagCorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagCorpus(new GetRagCorpusRequest
            {
                RagCorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagCorpus> GetRagCorpusAsync(RagCorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagCorpusAsync(new GetRagCorpusRequest
            {
                RagCorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagCorpus> GetRagCorpusAsync(RagCorpusName name, st::CancellationToken cancellationToken) =>
            GetRagCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RagCorpus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorpora(ListRagCorporaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RagCorpus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorporaAsync(ListRagCorporaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// RagCorpora. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="RagCorpus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorpora(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagCorporaRequest request = new ListRagCorporaRequest
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
            return ListRagCorpora(request, callSettings);
        }

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// RagCorpora. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RagCorpus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorporaAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagCorporaRequest request = new ListRagCorporaRequest
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
            return ListRagCorporaAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// RagCorpora. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="RagCorpus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorpora(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagCorporaRequest request = new ListRagCorporaRequest
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
            return ListRagCorpora(request, callSettings);
        }

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// RagCorpora. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RagCorpus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorporaAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagCorporaRequest request = new ListRagCorporaRequest
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
            return ListRagCorporaAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagCorpus(DeleteRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagCorpusAsync(DeleteRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagCorpusAsync(DeleteRagCorpusRequest request, st::CancellationToken cancellationToken) =>
            DeleteRagCorpusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRagCorpus</c>.</summary>
        public virtual lro::OperationsClient DeleteRagCorpusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRagCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteRagCorpus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRagCorpusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRagCorpus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteRagCorpusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRagCorpusOperationsClient, callSettings);

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagCorpus(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagCorpus(new DeleteRagCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagCorpusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagCorpusAsync(new DeleteRagCorpusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagCorpusAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRagCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagCorpus(RagCorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagCorpus(new DeleteRagCorpusRequest
            {
                RagCorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagCorpusAsync(RagCorpusName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagCorpusAsync(new DeleteRagCorpusRequest
            {
                RagCorpusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagCorpus resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagCorpusAsync(RagCorpusName name, st::CancellationToken cancellationToken) =>
            DeleteRagCorpusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadRagFileResponse UploadRagFile(UploadRagFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRagFileResponse> UploadRagFileAsync(UploadRagFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRagFileResponse> UploadRagFileAsync(UploadRagFileRequest request, st::CancellationToken cancellationToken) =>
            UploadRagFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to upload the file.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="ragFile">
        /// Required. The RagFile to upload.
        /// </param>
        /// <param name="uploadRagFileConfig">
        /// Required. The config for the RagFiles to be uploaded into the RagCorpus.
        /// [VertexRagDataService.UploadRagFile][google.cloud.aiplatform.v1beta1.VertexRagDataService.UploadRagFile].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadRagFileResponse UploadRagFile(string parent, RagFile ragFile, UploadRagFileConfig uploadRagFileConfig, gaxgrpc::CallSettings callSettings = null) =>
            UploadRagFile(new UploadRagFileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RagFile = gax::GaxPreconditions.CheckNotNull(ragFile, nameof(ragFile)),
                UploadRagFileConfig = gax::GaxPreconditions.CheckNotNull(uploadRagFileConfig, nameof(uploadRagFileConfig)),
            }, callSettings);

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to upload the file.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="ragFile">
        /// Required. The RagFile to upload.
        /// </param>
        /// <param name="uploadRagFileConfig">
        /// Required. The config for the RagFiles to be uploaded into the RagCorpus.
        /// [VertexRagDataService.UploadRagFile][google.cloud.aiplatform.v1beta1.VertexRagDataService.UploadRagFile].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRagFileResponse> UploadRagFileAsync(string parent, RagFile ragFile, UploadRagFileConfig uploadRagFileConfig, gaxgrpc::CallSettings callSettings = null) =>
            UploadRagFileAsync(new UploadRagFileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RagFile = gax::GaxPreconditions.CheckNotNull(ragFile, nameof(ragFile)),
                UploadRagFileConfig = gax::GaxPreconditions.CheckNotNull(uploadRagFileConfig, nameof(uploadRagFileConfig)),
            }, callSettings);

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to upload the file.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="ragFile">
        /// Required. The RagFile to upload.
        /// </param>
        /// <param name="uploadRagFileConfig">
        /// Required. The config for the RagFiles to be uploaded into the RagCorpus.
        /// [VertexRagDataService.UploadRagFile][google.cloud.aiplatform.v1beta1.VertexRagDataService.UploadRagFile].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRagFileResponse> UploadRagFileAsync(string parent, RagFile ragFile, UploadRagFileConfig uploadRagFileConfig, st::CancellationToken cancellationToken) =>
            UploadRagFileAsync(parent, ragFile, uploadRagFileConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to upload the file.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="ragFile">
        /// Required. The RagFile to upload.
        /// </param>
        /// <param name="uploadRagFileConfig">
        /// Required. The config for the RagFiles to be uploaded into the RagCorpus.
        /// [VertexRagDataService.UploadRagFile][google.cloud.aiplatform.v1beta1.VertexRagDataService.UploadRagFile].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadRagFileResponse UploadRagFile(RagCorpusName parent, RagFile ragFile, UploadRagFileConfig uploadRagFileConfig, gaxgrpc::CallSettings callSettings = null) =>
            UploadRagFile(new UploadRagFileRequest
            {
                ParentAsRagCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RagFile = gax::GaxPreconditions.CheckNotNull(ragFile, nameof(ragFile)),
                UploadRagFileConfig = gax::GaxPreconditions.CheckNotNull(uploadRagFileConfig, nameof(uploadRagFileConfig)),
            }, callSettings);

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to upload the file.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="ragFile">
        /// Required. The RagFile to upload.
        /// </param>
        /// <param name="uploadRagFileConfig">
        /// Required. The config for the RagFiles to be uploaded into the RagCorpus.
        /// [VertexRagDataService.UploadRagFile][google.cloud.aiplatform.v1beta1.VertexRagDataService.UploadRagFile].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRagFileResponse> UploadRagFileAsync(RagCorpusName parent, RagFile ragFile, UploadRagFileConfig uploadRagFileConfig, gaxgrpc::CallSettings callSettings = null) =>
            UploadRagFileAsync(new UploadRagFileRequest
            {
                ParentAsRagCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RagFile = gax::GaxPreconditions.CheckNotNull(ragFile, nameof(ragFile)),
                UploadRagFileConfig = gax::GaxPreconditions.CheckNotNull(uploadRagFileConfig, nameof(uploadRagFileConfig)),
            }, callSettings);

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to upload the file.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="ragFile">
        /// Required. The RagFile to upload.
        /// </param>
        /// <param name="uploadRagFileConfig">
        /// Required. The config for the RagFiles to be uploaded into the RagCorpus.
        /// [VertexRagDataService.UploadRagFile][google.cloud.aiplatform.v1beta1.VertexRagDataService.UploadRagFile].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRagFileResponse> UploadRagFileAsync(RagCorpusName parent, RagFile ragFile, UploadRagFileConfig uploadRagFileConfig, st::CancellationToken cancellationToken) =>
            UploadRagFileAsync(parent, ragFile, uploadRagFileConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> ImportRagFiles(ImportRagFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> ImportRagFilesAsync(ImportRagFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> ImportRagFilesAsync(ImportRagFilesRequest request, st::CancellationToken cancellationToken) =>
            ImportRagFilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportRagFiles</c>.</summary>
        public virtual lro::OperationsClient ImportRagFilesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportRagFiles</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> PollOnceImportRagFiles(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportRagFilesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportRagFiles</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> PollOnceImportRagFilesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportRagFilesOperationsClient, callSettings);

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to import files.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="importRagFilesConfig">
        /// Required. The config for the RagFiles to be synced and imported into the
        /// RagCorpus.
        /// [VertexRagDataService.ImportRagFiles][google.cloud.aiplatform.v1beta1.VertexRagDataService.ImportRagFiles].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> ImportRagFiles(string parent, ImportRagFilesConfig importRagFilesConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportRagFiles(new ImportRagFilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ImportRagFilesConfig = gax::GaxPreconditions.CheckNotNull(importRagFilesConfig, nameof(importRagFilesConfig)),
            }, callSettings);

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to import files.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="importRagFilesConfig">
        /// Required. The config for the RagFiles to be synced and imported into the
        /// RagCorpus.
        /// [VertexRagDataService.ImportRagFiles][google.cloud.aiplatform.v1beta1.VertexRagDataService.ImportRagFiles].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> ImportRagFilesAsync(string parent, ImportRagFilesConfig importRagFilesConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportRagFilesAsync(new ImportRagFilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ImportRagFilesConfig = gax::GaxPreconditions.CheckNotNull(importRagFilesConfig, nameof(importRagFilesConfig)),
            }, callSettings);

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to import files.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="importRagFilesConfig">
        /// Required. The config for the RagFiles to be synced and imported into the
        /// RagCorpus.
        /// [VertexRagDataService.ImportRagFiles][google.cloud.aiplatform.v1beta1.VertexRagDataService.ImportRagFiles].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> ImportRagFilesAsync(string parent, ImportRagFilesConfig importRagFilesConfig, st::CancellationToken cancellationToken) =>
            ImportRagFilesAsync(parent, importRagFilesConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to import files.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="importRagFilesConfig">
        /// Required. The config for the RagFiles to be synced and imported into the
        /// RagCorpus.
        /// [VertexRagDataService.ImportRagFiles][google.cloud.aiplatform.v1beta1.VertexRagDataService.ImportRagFiles].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> ImportRagFiles(RagCorpusName parent, ImportRagFilesConfig importRagFilesConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportRagFiles(new ImportRagFilesRequest
            {
                ParentAsRagCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ImportRagFilesConfig = gax::GaxPreconditions.CheckNotNull(importRagFilesConfig, nameof(importRagFilesConfig)),
            }, callSettings);

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to import files.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="importRagFilesConfig">
        /// Required. The config for the RagFiles to be synced and imported into the
        /// RagCorpus.
        /// [VertexRagDataService.ImportRagFiles][google.cloud.aiplatform.v1beta1.VertexRagDataService.ImportRagFiles].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> ImportRagFilesAsync(RagCorpusName parent, ImportRagFilesConfig importRagFilesConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportRagFilesAsync(new ImportRagFilesRequest
            {
                ParentAsRagCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ImportRagFilesConfig = gax::GaxPreconditions.CheckNotNull(importRagFilesConfig, nameof(importRagFilesConfig)),
            }, callSettings);

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the RagCorpus resource into which to import files.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
        /// </param>
        /// <param name="importRagFilesConfig">
        /// Required. The config for the RagFiles to be synced and imported into the
        /// RagCorpus.
        /// [VertexRagDataService.ImportRagFiles][google.cloud.aiplatform.v1beta1.VertexRagDataService.ImportRagFiles].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> ImportRagFilesAsync(RagCorpusName parent, ImportRagFilesConfig importRagFilesConfig, st::CancellationToken cancellationToken) =>
            ImportRagFilesAsync(parent, importRagFilesConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RagFile GetRagFile(GetRagFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagFile> GetRagFileAsync(GetRagFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagFile> GetRagFileAsync(GetRagFileRequest request, st::CancellationToken cancellationToken) =>
            GetRagFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RagFile GetRagFile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagFile(new GetRagFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagFile> GetRagFileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagFileAsync(new GetRagFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagFile> GetRagFileAsync(string name, st::CancellationToken cancellationToken) =>
            GetRagFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RagFile GetRagFile(RagFileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagFile(new GetRagFileRequest
            {
                RagFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagFile> GetRagFileAsync(RagFileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRagFileAsync(new GetRagFileRequest
            {
                RagFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RagFile> GetRagFileAsync(RagFileName name, st::CancellationToken cancellationToken) =>
            GetRagFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RagFile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRagFilesResponse, RagFile> ListRagFiles(ListRagFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RagFile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRagFilesResponse, RagFile> ListRagFilesAsync(ListRagFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the RagCorpus from which to list the
        /// RagFiles. Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
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
        /// <returns>A pageable sequence of <see cref="RagFile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRagFilesResponse, RagFile> ListRagFiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagFilesRequest request = new ListRagFilesRequest
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
            return ListRagFiles(request, callSettings);
        }

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the RagCorpus from which to list the
        /// RagFiles. Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RagFile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRagFilesResponse, RagFile> ListRagFilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagFilesRequest request = new ListRagFilesRequest
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
            return ListRagFilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the RagCorpus from which to list the
        /// RagFiles. Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
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
        /// <returns>A pageable sequence of <see cref="RagFile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRagFilesResponse, RagFile> ListRagFiles(RagCorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagFilesRequest request = new ListRagFilesRequest
            {
                ParentAsRagCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRagFiles(request, callSettings);
        }

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the RagCorpus from which to list the
        /// RagFiles. Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RagFile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRagFilesResponse, RagFile> ListRagFilesAsync(RagCorpusName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRagFilesRequest request = new ListRagFilesRequest
            {
                ParentAsRagCorpusName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRagFilesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagFile(DeleteRagFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagFileAsync(DeleteRagFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagFileAsync(DeleteRagFileRequest request, st::CancellationToken cancellationToken) =>
            DeleteRagFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRagFile</c>.</summary>
        public virtual lro::OperationsClient DeleteRagFileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRagFile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteRagFile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRagFileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRagFile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteRagFileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRagFileOperationsClient, callSettings);

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagFile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagFile(new DeleteRagFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagFileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagFileAsync(new DeleteRagFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagFileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRagFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagFile(RagFileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagFile(new DeleteRagFileRequest
            {
                RagFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagFileAsync(RagFileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRagFileAsync(new DeleteRagFileRequest
            {
                RagFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RagFile resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagFileAsync(RagFileName name, st::CancellationToken cancellationToken) =>
            DeleteRagFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VertexRagDataService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing user data for RAG.
    /// </remarks>
    public sealed partial class VertexRagDataServiceClientImpl : VertexRagDataServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateRagCorpusRequest, lro::Operation> _callCreateRagCorpus;

        private readonly gaxgrpc::ApiCall<UpdateRagCorpusRequest, lro::Operation> _callUpdateRagCorpus;

        private readonly gaxgrpc::ApiCall<GetRagCorpusRequest, RagCorpus> _callGetRagCorpus;

        private readonly gaxgrpc::ApiCall<ListRagCorporaRequest, ListRagCorporaResponse> _callListRagCorpora;

        private readonly gaxgrpc::ApiCall<DeleteRagCorpusRequest, lro::Operation> _callDeleteRagCorpus;

        private readonly gaxgrpc::ApiCall<UploadRagFileRequest, UploadRagFileResponse> _callUploadRagFile;

        private readonly gaxgrpc::ApiCall<ImportRagFilesRequest, lro::Operation> _callImportRagFiles;

        private readonly gaxgrpc::ApiCall<GetRagFileRequest, RagFile> _callGetRagFile;

        private readonly gaxgrpc::ApiCall<ListRagFilesRequest, ListRagFilesResponse> _callListRagFiles;

        private readonly gaxgrpc::ApiCall<DeleteRagFileRequest, lro::Operation> _callDeleteRagFile;

        /// <summary>
        /// Constructs a client wrapper for the VertexRagDataService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VertexRagDataServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VertexRagDataServiceClientImpl(VertexRagDataService.VertexRagDataServiceClient grpcClient, VertexRagDataServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VertexRagDataServiceSettings effectiveSettings = settings ?? VertexRagDataServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateRagCorpusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRagCorpusOperationsSettings, logger);
            UpdateRagCorpusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRagCorpusOperationsSettings, logger);
            DeleteRagCorpusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRagCorpusOperationsSettings, logger);
            ImportRagFilesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportRagFilesOperationsSettings, logger);
            DeleteRagFileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRagFileOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateRagCorpus = clientHelper.BuildApiCall<CreateRagCorpusRequest, lro::Operation>("CreateRagCorpus", grpcClient.CreateRagCorpusAsync, grpcClient.CreateRagCorpus, effectiveSettings.CreateRagCorpusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRagCorpus);
            Modify_CreateRagCorpusApiCall(ref _callCreateRagCorpus);
            _callUpdateRagCorpus = clientHelper.BuildApiCall<UpdateRagCorpusRequest, lro::Operation>("UpdateRagCorpus", grpcClient.UpdateRagCorpusAsync, grpcClient.UpdateRagCorpus, effectiveSettings.UpdateRagCorpusSettings).WithGoogleRequestParam("rag_corpus.name", request => request.RagCorpus?.Name);
            Modify_ApiCall(ref _callUpdateRagCorpus);
            Modify_UpdateRagCorpusApiCall(ref _callUpdateRagCorpus);
            _callGetRagCorpus = clientHelper.BuildApiCall<GetRagCorpusRequest, RagCorpus>("GetRagCorpus", grpcClient.GetRagCorpusAsync, grpcClient.GetRagCorpus, effectiveSettings.GetRagCorpusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRagCorpus);
            Modify_GetRagCorpusApiCall(ref _callGetRagCorpus);
            _callListRagCorpora = clientHelper.BuildApiCall<ListRagCorporaRequest, ListRagCorporaResponse>("ListRagCorpora", grpcClient.ListRagCorporaAsync, grpcClient.ListRagCorpora, effectiveSettings.ListRagCorporaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRagCorpora);
            Modify_ListRagCorporaApiCall(ref _callListRagCorpora);
            _callDeleteRagCorpus = clientHelper.BuildApiCall<DeleteRagCorpusRequest, lro::Operation>("DeleteRagCorpus", grpcClient.DeleteRagCorpusAsync, grpcClient.DeleteRagCorpus, effectiveSettings.DeleteRagCorpusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRagCorpus);
            Modify_DeleteRagCorpusApiCall(ref _callDeleteRagCorpus);
            _callUploadRagFile = clientHelper.BuildApiCall<UploadRagFileRequest, UploadRagFileResponse>("UploadRagFile", grpcClient.UploadRagFileAsync, grpcClient.UploadRagFile, effectiveSettings.UploadRagFileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUploadRagFile);
            Modify_UploadRagFileApiCall(ref _callUploadRagFile);
            _callImportRagFiles = clientHelper.BuildApiCall<ImportRagFilesRequest, lro::Operation>("ImportRagFiles", grpcClient.ImportRagFilesAsync, grpcClient.ImportRagFiles, effectiveSettings.ImportRagFilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportRagFiles);
            Modify_ImportRagFilesApiCall(ref _callImportRagFiles);
            _callGetRagFile = clientHelper.BuildApiCall<GetRagFileRequest, RagFile>("GetRagFile", grpcClient.GetRagFileAsync, grpcClient.GetRagFile, effectiveSettings.GetRagFileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRagFile);
            Modify_GetRagFileApiCall(ref _callGetRagFile);
            _callListRagFiles = clientHelper.BuildApiCall<ListRagFilesRequest, ListRagFilesResponse>("ListRagFiles", grpcClient.ListRagFilesAsync, grpcClient.ListRagFiles, effectiveSettings.ListRagFilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRagFiles);
            Modify_ListRagFilesApiCall(ref _callListRagFiles);
            _callDeleteRagFile = clientHelper.BuildApiCall<DeleteRagFileRequest, lro::Operation>("DeleteRagFile", grpcClient.DeleteRagFileAsync, grpcClient.DeleteRagFile, effectiveSettings.DeleteRagFileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRagFile);
            Modify_DeleteRagFileApiCall(ref _callDeleteRagFile);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateRagCorpusApiCall(ref gaxgrpc::ApiCall<CreateRagCorpusRequest, lro::Operation> call);

        partial void Modify_UpdateRagCorpusApiCall(ref gaxgrpc::ApiCall<UpdateRagCorpusRequest, lro::Operation> call);

        partial void Modify_GetRagCorpusApiCall(ref gaxgrpc::ApiCall<GetRagCorpusRequest, RagCorpus> call);

        partial void Modify_ListRagCorporaApiCall(ref gaxgrpc::ApiCall<ListRagCorporaRequest, ListRagCorporaResponse> call);

        partial void Modify_DeleteRagCorpusApiCall(ref gaxgrpc::ApiCall<DeleteRagCorpusRequest, lro::Operation> call);

        partial void Modify_UploadRagFileApiCall(ref gaxgrpc::ApiCall<UploadRagFileRequest, UploadRagFileResponse> call);

        partial void Modify_ImportRagFilesApiCall(ref gaxgrpc::ApiCall<ImportRagFilesRequest, lro::Operation> call);

        partial void Modify_GetRagFileApiCall(ref gaxgrpc::ApiCall<GetRagFileRequest, RagFile> call);

        partial void Modify_ListRagFilesApiCall(ref gaxgrpc::ApiCall<ListRagFilesRequest, ListRagFilesResponse> call);

        partial void Modify_DeleteRagFileApiCall(ref gaxgrpc::ApiCall<DeleteRagFileRequest, lro::Operation> call);

        partial void OnConstruction(VertexRagDataService.VertexRagDataServiceClient grpcClient, VertexRagDataServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VertexRagDataService client</summary>
        public override VertexRagDataService.VertexRagDataServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateRagCorpusRequest(ref CreateRagCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRagCorpusRequest(ref UpdateRagCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRagCorpusRequest(ref GetRagCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRagCorporaRequest(ref ListRagCorporaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRagCorpusRequest(ref DeleteRagCorpusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UploadRagFileRequest(ref UploadRagFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportRagFilesRequest(ref ImportRagFilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRagFileRequest(ref GetRagFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRagFilesRequest(ref ListRagFilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRagFileRequest(ref DeleteRagFileRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateRagCorpus</c>.</summary>
        public override lro::OperationsClient CreateRagCorpusOperationsClient { get; }

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata> CreateRagCorpus(CreateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRagCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>(_callCreateRagCorpus.Sync(request, callSettings), CreateRagCorpusOperationsClient);
        }

        /// <summary>
        /// Creates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>> CreateRagCorpusAsync(CreateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRagCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<RagCorpus, CreateRagCorpusOperationMetadata>(await _callCreateRagCorpus.Async(request, callSettings).ConfigureAwait(false), CreateRagCorpusOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateRagCorpus</c>.</summary>
        public override lro::OperationsClient UpdateRagCorpusOperationsClient { get; }

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata> UpdateRagCorpus(UpdateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRagCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>(_callUpdateRagCorpus.Sync(request, callSettings), UpdateRagCorpusOperationsClient);
        }

        /// <summary>
        /// Updates a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>> UpdateRagCorpusAsync(UpdateRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRagCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<RagCorpus, UpdateRagCorpusOperationMetadata>(await _callUpdateRagCorpus.Async(request, callSettings).ConfigureAwait(false), UpdateRagCorpusOperationsClient);
        }

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RagCorpus GetRagCorpus(GetRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRagCorpusRequest(ref request, ref callSettings);
            return _callGetRagCorpus.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RagCorpus> GetRagCorpusAsync(GetRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRagCorpusRequest(ref request, ref callSettings);
            return _callGetRagCorpus.Async(request, callSettings);
        }

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RagCorpus"/> resources.</returns>
        public override gax::PagedEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorpora(ListRagCorporaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRagCorporaRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRagCorporaRequest, ListRagCorporaResponse, RagCorpus>(_callListRagCorpora, request, callSettings);
        }

        /// <summary>
        /// Lists RagCorpora in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RagCorpus"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRagCorporaResponse, RagCorpus> ListRagCorporaAsync(ListRagCorporaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRagCorporaRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRagCorporaRequest, ListRagCorporaResponse, RagCorpus>(_callListRagCorpora, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteRagCorpus</c>.</summary>
        public override lro::OperationsClient DeleteRagCorpusOperationsClient { get; }

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagCorpus(DeleteRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRagCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteRagCorpus.Sync(request, callSettings), DeleteRagCorpusOperationsClient);
        }

        /// <summary>
        /// Deletes a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagCorpusAsync(DeleteRagCorpusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRagCorpusRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteRagCorpus.Async(request, callSettings).ConfigureAwait(false), DeleteRagCorpusOperationsClient);
        }

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadRagFileResponse UploadRagFile(UploadRagFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadRagFileRequest(ref request, ref callSettings);
            return _callUploadRagFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Upload a file into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadRagFileResponse> UploadRagFileAsync(UploadRagFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadRagFileRequest(ref request, ref callSettings);
            return _callUploadRagFile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportRagFiles</c>.</summary>
        public override lro::OperationsClient ImportRagFilesOperationsClient { get; }

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata> ImportRagFiles(ImportRagFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportRagFilesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>(_callImportRagFiles.Sync(request, callSettings), ImportRagFilesOperationsClient);
        }

        /// <summary>
        /// Import files from Google Cloud Storage or Google Drive into a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>> ImportRagFilesAsync(ImportRagFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportRagFilesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportRagFilesResponse, ImportRagFilesOperationMetadata>(await _callImportRagFiles.Async(request, callSettings).ConfigureAwait(false), ImportRagFilesOperationsClient);
        }

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RagFile GetRagFile(GetRagFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRagFileRequest(ref request, ref callSettings);
            return _callGetRagFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RagFile> GetRagFileAsync(GetRagFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRagFileRequest(ref request, ref callSettings);
            return _callGetRagFile.Async(request, callSettings);
        }

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RagFile"/> resources.</returns>
        public override gax::PagedEnumerable<ListRagFilesResponse, RagFile> ListRagFiles(ListRagFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRagFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRagFilesRequest, ListRagFilesResponse, RagFile>(_callListRagFiles, request, callSettings);
        }

        /// <summary>
        /// Lists RagFiles in a RagCorpus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RagFile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRagFilesResponse, RagFile> ListRagFilesAsync(ListRagFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRagFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRagFilesRequest, ListRagFilesResponse, RagFile>(_callListRagFiles, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteRagFile</c>.</summary>
        public override lro::OperationsClient DeleteRagFileOperationsClient { get; }

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteRagFile(DeleteRagFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRagFileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteRagFile.Sync(request, callSettings), DeleteRagFileOperationsClient);
        }

        /// <summary>
        /// Deletes a RagFile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteRagFileAsync(DeleteRagFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRagFileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteRagFile.Async(request, callSettings).ConfigureAwait(false), DeleteRagFileOperationsClient);
        }
    }

    public partial class ListRagCorporaRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRagFilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRagCorporaResponse : gaxgrpc::IPageResponse<RagCorpus>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RagCorpus> GetEnumerator() => RagCorpora.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRagFilesResponse : gaxgrpc::IPageResponse<RagFile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RagFile> GetEnumerator() => RagFiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class VertexRagDataService
    {
        public partial class VertexRagDataServiceClient
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

    public static partial class VertexRagDataService
    {
        public partial class VertexRagDataServiceClient
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
