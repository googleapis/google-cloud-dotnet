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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Dataflow.V1Beta3
{
    /// <summary>Settings for <see cref="FlexTemplatesServiceClient"/> instances.</summary>
    public sealed partial class FlexTemplatesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FlexTemplatesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FlexTemplatesServiceSettings"/>.</returns>
        public static FlexTemplatesServiceSettings GetDefault() => new FlexTemplatesServiceSettings();

        /// <summary>Constructs a new <see cref="FlexTemplatesServiceSettings"/> object with default settings.</summary>
        public FlexTemplatesServiceSettings()
        {
        }

        private FlexTemplatesServiceSettings(FlexTemplatesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            LaunchFlexTemplateSettings = existing.LaunchFlexTemplateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FlexTemplatesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FlexTemplatesServiceClient.LaunchFlexTemplate</c> and
        /// <c>FlexTemplatesServiceClient.LaunchFlexTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LaunchFlexTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FlexTemplatesServiceSettings"/> object.</returns>
        public FlexTemplatesServiceSettings Clone() => new FlexTemplatesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FlexTemplatesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class FlexTemplatesServiceClientBuilder : gaxgrpc::ClientBuilderBase<FlexTemplatesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FlexTemplatesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FlexTemplatesServiceClientBuilder() : base(FlexTemplatesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FlexTemplatesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FlexTemplatesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FlexTemplatesServiceClient Build()
        {
            FlexTemplatesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FlexTemplatesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FlexTemplatesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FlexTemplatesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FlexTemplatesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FlexTemplatesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FlexTemplatesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FlexTemplatesServiceClient.ChannelPool;
    }

    /// <summary>FlexTemplatesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides a service for Flex templates.
    /// </remarks>
    public abstract partial class FlexTemplatesServiceClient
    {
        /// <summary>
        /// The default endpoint for the FlexTemplatesService service, which is a host of "dataflow.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataflow.googleapis.com:443";

        /// <summary>The default FlexTemplatesService scopes.</summary>
        /// <remarks>
        /// The default FlexTemplatesService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/compute",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FlexTemplatesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FlexTemplatesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="FlexTemplatesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FlexTemplatesServiceClient"/>.</returns>
        public static stt::Task<FlexTemplatesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FlexTemplatesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FlexTemplatesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="FlexTemplatesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FlexTemplatesServiceClient"/>.</returns>
        public static FlexTemplatesServiceClient Create() => new FlexTemplatesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FlexTemplatesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FlexTemplatesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FlexTemplatesServiceClient"/>.</returns>
        internal static FlexTemplatesServiceClient Create(grpccore::CallInvoker callInvoker, FlexTemplatesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FlexTemplatesService.FlexTemplatesServiceClient grpcClient = new FlexTemplatesService.FlexTemplatesServiceClient(callInvoker);
            return new FlexTemplatesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FlexTemplatesService client</summary>
        public virtual FlexTemplatesService.FlexTemplatesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Launch a job with a FlexTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LaunchFlexTemplateResponse LaunchFlexTemplate(LaunchFlexTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Launch a job with a FlexTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LaunchFlexTemplateResponse> LaunchFlexTemplateAsync(LaunchFlexTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Launch a job with a FlexTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LaunchFlexTemplateResponse> LaunchFlexTemplateAsync(LaunchFlexTemplateRequest request, st::CancellationToken cancellationToken) =>
            LaunchFlexTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FlexTemplatesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides a service for Flex templates.
    /// </remarks>
    public sealed partial class FlexTemplatesServiceClientImpl : FlexTemplatesServiceClient
    {
        private readonly gaxgrpc::ApiCall<LaunchFlexTemplateRequest, LaunchFlexTemplateResponse> _callLaunchFlexTemplate;

        /// <summary>
        /// Constructs a client wrapper for the FlexTemplatesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FlexTemplatesServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FlexTemplatesServiceClientImpl(FlexTemplatesService.FlexTemplatesServiceClient grpcClient, FlexTemplatesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FlexTemplatesServiceSettings effectiveSettings = settings ?? FlexTemplatesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callLaunchFlexTemplate = clientHelper.BuildApiCall<LaunchFlexTemplateRequest, LaunchFlexTemplateResponse>("LaunchFlexTemplate", grpcClient.LaunchFlexTemplateAsync, grpcClient.LaunchFlexTemplate, effectiveSettings.LaunchFlexTemplateSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callLaunchFlexTemplate);
            Modify_LaunchFlexTemplateApiCall(ref _callLaunchFlexTemplate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_LaunchFlexTemplateApiCall(ref gaxgrpc::ApiCall<LaunchFlexTemplateRequest, LaunchFlexTemplateResponse> call);

        partial void OnConstruction(FlexTemplatesService.FlexTemplatesServiceClient grpcClient, FlexTemplatesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FlexTemplatesService client</summary>
        public override FlexTemplatesService.FlexTemplatesServiceClient GrpcClient { get; }

        partial void Modify_LaunchFlexTemplateRequest(ref LaunchFlexTemplateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Launch a job with a FlexTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LaunchFlexTemplateResponse LaunchFlexTemplate(LaunchFlexTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LaunchFlexTemplateRequest(ref request, ref callSettings);
            return _callLaunchFlexTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Launch a job with a FlexTemplate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LaunchFlexTemplateResponse> LaunchFlexTemplateAsync(LaunchFlexTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LaunchFlexTemplateRequest(ref request, ref callSettings);
            return _callLaunchFlexTemplate.Async(request, callSettings);
        }
    }
}
