// Copyright 2026 Google LLC
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

namespace Google.Cloud.Ces.V1
{
    /// <summary>Settings for <see cref="ToolServiceClient"/> instances.</summary>
    public sealed partial class ToolServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ToolServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ToolServiceSettings"/>.</returns>
        public static ToolServiceSettings GetDefault() => new ToolServiceSettings();

        /// <summary>Constructs a new <see cref="ToolServiceSettings"/> object with default settings.</summary>
        public ToolServiceSettings()
        {
        }

        private ToolServiceSettings(ToolServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExecuteToolSettings = existing.ExecuteToolSettings;
            RetrieveToolSchemaSettings = existing.RetrieveToolSchemaSettings;
            RetrieveToolsSettings = existing.RetrieveToolsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ToolServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ToolServiceClient.ExecuteTool</c> and <c>ToolServiceClient.ExecuteToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ToolServiceClient.RetrieveToolSchema</c> and <c>ToolServiceClient.RetrieveToolSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveToolSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ToolServiceClient.RetrieveTools</c> and <c>ToolServiceClient.RetrieveToolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveToolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ToolServiceSettings"/> object.</returns>
        public ToolServiceSettings Clone() => new ToolServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ToolServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ToolServiceClientBuilder : gaxgrpc::ClientBuilderBase<ToolServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ToolServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ToolServiceClientBuilder() : base(ToolServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ToolServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ToolServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ToolServiceClient Build()
        {
            ToolServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ToolServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ToolServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ToolServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ToolServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ToolServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ToolServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ToolServiceClient.ChannelPool;
    }

    /// <summary>ToolService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Tool service provides APIs for interacting with CES tools.
    /// </remarks>
    public abstract partial class ToolServiceClient
    {
        /// <summary>
        /// The default endpoint for the ToolService service, which is a host of "ces.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ces.googleapis.com:443";

        /// <summary>The default ToolService scopes.</summary>
        /// <remarks>
        /// The default ToolService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/ces</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/ces",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ToolService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ToolServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ToolServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ToolServiceClient"/>.</returns>
        public static stt::Task<ToolServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ToolServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ToolServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ToolServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ToolServiceClient"/>.</returns>
        public static ToolServiceClient Create() => new ToolServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ToolServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ToolServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ToolServiceClient"/>.</returns>
        internal static ToolServiceClient Create(grpccore::CallInvoker callInvoker, ToolServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ToolService.ToolServiceClient grpcClient = new ToolService.ToolServiceClient(callInvoker);
            return new ToolServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ToolService client</summary>
        public virtual ToolService.ToolServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Executes the given tool with the given arguments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteToolResponse ExecuteTool(ExecuteToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes the given tool with the given arguments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteToolResponse> ExecuteToolAsync(ExecuteToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes the given tool with the given arguments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteToolResponse> ExecuteToolAsync(ExecuteToolRequest request, st::CancellationToken cancellationToken) =>
            ExecuteToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the schema of the given tool. The schema is computed on the fly
        /// for the given instance of the tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveToolSchemaResponse RetrieveToolSchema(RetrieveToolSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the schema of the given tool. The schema is computed on the fly
        /// for the given instance of the tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveToolSchemaResponse> RetrieveToolSchemaAsync(RetrieveToolSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the schema of the given tool. The schema is computed on the fly
        /// for the given instance of the tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveToolSchemaResponse> RetrieveToolSchemaAsync(RetrieveToolSchemaRequest request, st::CancellationToken cancellationToken) =>
            RetrieveToolSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the list of tools included in the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveToolsResponse RetrieveTools(RetrieveToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the list of tools included in the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveToolsResponse> RetrieveToolsAsync(RetrieveToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the list of tools included in the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveToolsResponse> RetrieveToolsAsync(RetrieveToolsRequest request, st::CancellationToken cancellationToken) =>
            RetrieveToolsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ToolService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Tool service provides APIs for interacting with CES tools.
    /// </remarks>
    public sealed partial class ToolServiceClientImpl : ToolServiceClient
    {
        private readonly gaxgrpc::ApiCall<ExecuteToolRequest, ExecuteToolResponse> _callExecuteTool;

        private readonly gaxgrpc::ApiCall<RetrieveToolSchemaRequest, RetrieveToolSchemaResponse> _callRetrieveToolSchema;

        private readonly gaxgrpc::ApiCall<RetrieveToolsRequest, RetrieveToolsResponse> _callRetrieveTools;

        /// <summary>
        /// Constructs a client wrapper for the ToolService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ToolServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ToolServiceClientImpl(ToolService.ToolServiceClient grpcClient, ToolServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ToolServiceSettings effectiveSettings = settings ?? ToolServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callExecuteTool = clientHelper.BuildApiCall<ExecuteToolRequest, ExecuteToolResponse>("ExecuteTool", grpcClient.ExecuteToolAsync, grpcClient.ExecuteTool, effectiveSettings.ExecuteToolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExecuteTool);
            Modify_ExecuteToolApiCall(ref _callExecuteTool);
            _callRetrieveToolSchema = clientHelper.BuildApiCall<RetrieveToolSchemaRequest, RetrieveToolSchemaResponse>("RetrieveToolSchema", grpcClient.RetrieveToolSchemaAsync, grpcClient.RetrieveToolSchema, effectiveSettings.RetrieveToolSchemaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveToolSchema);
            Modify_RetrieveToolSchemaApiCall(ref _callRetrieveToolSchema);
            _callRetrieveTools = clientHelper.BuildApiCall<RetrieveToolsRequest, RetrieveToolsResponse>("RetrieveTools", grpcClient.RetrieveToolsAsync, grpcClient.RetrieveTools, effectiveSettings.RetrieveToolsSettings).WithGoogleRequestParam("toolset", request => request.Toolset);
            Modify_ApiCall(ref _callRetrieveTools);
            Modify_RetrieveToolsApiCall(ref _callRetrieveTools);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExecuteToolApiCall(ref gaxgrpc::ApiCall<ExecuteToolRequest, ExecuteToolResponse> call);

        partial void Modify_RetrieveToolSchemaApiCall(ref gaxgrpc::ApiCall<RetrieveToolSchemaRequest, RetrieveToolSchemaResponse> call);

        partial void Modify_RetrieveToolsApiCall(ref gaxgrpc::ApiCall<RetrieveToolsRequest, RetrieveToolsResponse> call);

        partial void OnConstruction(ToolService.ToolServiceClient grpcClient, ToolServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ToolService client</summary>
        public override ToolService.ToolServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ExecuteToolRequest(ref ExecuteToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveToolSchemaRequest(ref RetrieveToolSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveToolsRequest(ref RetrieveToolsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Executes the given tool with the given arguments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExecuteToolResponse ExecuteTool(ExecuteToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteToolRequest(ref request, ref callSettings);
            return _callExecuteTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes the given tool with the given arguments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExecuteToolResponse> ExecuteToolAsync(ExecuteToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteToolRequest(ref request, ref callSettings);
            return _callExecuteTool.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve the schema of the given tool. The schema is computed on the fly
        /// for the given instance of the tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveToolSchemaResponse RetrieveToolSchema(RetrieveToolSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveToolSchemaRequest(ref request, ref callSettings);
            return _callRetrieveToolSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the schema of the given tool. The schema is computed on the fly
        /// for the given instance of the tool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveToolSchemaResponse> RetrieveToolSchemaAsync(RetrieveToolSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveToolSchemaRequest(ref request, ref callSettings);
            return _callRetrieveToolSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve the list of tools included in the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveToolsResponse RetrieveTools(RetrieveToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveToolsRequest(ref request, ref callSettings);
            return _callRetrieveTools.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the list of tools included in the specified toolset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveToolsResponse> RetrieveToolsAsync(RetrieveToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveToolsRequest(ref request, ref callSettings);
            return _callRetrieveTools.Async(request, callSettings);
        }
    }

    public static partial class ToolService
    {
        public partial class ToolServiceClient
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
