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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="ToolsClient"/> instances.</summary>
    public sealed partial class ToolsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ToolsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ToolsSettings"/>.</returns>
        public static ToolsSettings GetDefault() => new ToolsSettings();

        /// <summary>Constructs a new <see cref="ToolsSettings"/> object with default settings.</summary>
        public ToolsSettings()
        {
        }

        private ToolsSettings(ToolsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateToolSettings = existing.CreateToolSettings;
            ListToolsSettings = existing.ListToolsSettings;
            GetToolSettings = existing.GetToolSettings;
            UpdateToolSettings = existing.UpdateToolSettings;
            DeleteToolSettings = existing.DeleteToolSettings;
            ListToolVersionsSettings = existing.ListToolVersionsSettings;
            CreateToolVersionSettings = existing.CreateToolVersionSettings;
            GetToolVersionSettings = existing.GetToolVersionSettings;
            DeleteToolVersionSettings = existing.DeleteToolVersionSettings;
            RestoreToolVersionSettings = existing.RestoreToolVersionSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ToolsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ToolsClient.CreateTool</c>
        /// and <c>ToolsClient.CreateToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ToolsClient.ListTools</c>
        /// and <c>ToolsClient.ListToolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListToolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ToolsClient.GetTool</c> and
        /// <c>ToolsClient.GetToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ToolsClient.UpdateTool</c>
        /// and <c>ToolsClient.UpdateToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ToolsClient.DeleteTool</c>
        /// and <c>ToolsClient.DeleteToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ToolsClient.ListToolVersions</c> and <c>ToolsClient.ListToolVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListToolVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ToolsClient.CreateToolVersion</c> and <c>ToolsClient.CreateToolVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateToolVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ToolsClient.GetToolVersion</c>
        ///  and <c>ToolsClient.GetToolVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetToolVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ToolsClient.DeleteToolVersion</c> and <c>ToolsClient.DeleteToolVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteToolVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ToolsClient.RestoreToolVersion</c> and <c>ToolsClient.RestoreToolVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreToolVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ToolsSettings"/> object.</returns>
        public ToolsSettings Clone() => new ToolsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ToolsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ToolsClientBuilder : gaxgrpc::ClientBuilderBase<ToolsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ToolsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ToolsClientBuilder() : base(ToolsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ToolsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ToolsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ToolsClient Build()
        {
            ToolsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ToolsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ToolsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ToolsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ToolsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ToolsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ToolsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ToolsClient.ChannelPool;
    }

    /// <summary>Tools client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Tools][google.cloud.dialogflow.cx.v3.Tool].
    /// </remarks>
    public abstract partial class ToolsClient
    {
        /// <summary>
        /// The default endpoint for the Tools service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Tools scopes.</summary>
        /// <remarks>
        /// The default Tools scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Tools.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ToolsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ToolsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ToolsClient"/>.</returns>
        public static stt::Task<ToolsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ToolsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ToolsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ToolsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ToolsClient"/>.</returns>
        public static ToolsClient Create() => new ToolsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ToolsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ToolsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ToolsClient"/>.</returns>
        internal static ToolsClient Create(grpccore::CallInvoker callInvoker, ToolsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Tools.ToolsClient grpcClient = new Tools.ToolsClient(callInvoker);
            return new ToolsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Tools client</summary>
        public virtual Tools.ToolsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(CreateToolRequest request, st::CancellationToken cancellationToken) =>
            CreateToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a Tool for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="tool">
        /// Required. The Tool to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(string parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateTool(new CreateToolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a Tool for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="tool">
        /// Required. The Tool to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(string parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolAsync(new CreateToolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a Tool for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="tool">
        /// Required. The Tool to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(string parent, Tool tool, st::CancellationToken cancellationToken) =>
            CreateToolAsync(parent, tool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a Tool for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="tool">
        /// Required. The Tool to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool CreateTool(AgentName parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateTool(new CreateToolRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a Tool for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="tool">
        /// Required. The Tool to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(AgentName parent, Tool tool, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolAsync(new CreateToolRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
            }, callSettings);

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a Tool for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="tool">
        /// Required. The Tool to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> CreateToolAsync(AgentName parent, Tool tool, st::CancellationToken cancellationToken) =>
            CreateToolAsync(parent, tool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list the Tools from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
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
            return ListTools(request, callSettings);
        }

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list the Tools from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
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
            return ListToolsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list the Tools from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTools(request, callSettings);
        }

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list the Tools from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolsRequest request = new ListToolsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListToolsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool GetTool(GetToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(GetToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(GetToolRequest request, st::CancellationToken cancellationToken) =>
            GetToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool GetTool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTool(new GetToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolAsync(new GetToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(string name, st::CancellationToken cancellationToken) =>
            GetToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool GetTool(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTool(new GetToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolAsync(new GetToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> GetToolAsync(ToolName name, st::CancellationToken cancellationToken) =>
            GetToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool UpdateTool(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(UpdateToolRequest request, st::CancellationToken cancellationToken) =>
            UpdateToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="tool">
        /// Required. The Tool to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tool UpdateTool(Tool tool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTool(new UpdateToolRequest
            {
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="tool">
        /// Required. The Tool to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(Tool tool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateToolAsync(new UpdateToolRequest
            {
                Tool = gax::GaxPreconditions.CheckNotNull(tool, nameof(tool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="tool">
        /// Required. The Tool to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tool> UpdateToolAsync(Tool tool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateToolAsync(tool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTool(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(DeleteToolRequest request, st::CancellationToken cancellationToken) =>
            DeleteToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool to be deleted.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTool(new DeleteToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool to be deleted.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolAsync(new DeleteToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool to be deleted.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool to be deleted.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTool(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTool(new DeleteToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool to be deleted.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(ToolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolAsync(new DeleteToolRequest
            {
                ToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tool to be deleted.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolAsync(ToolName name, st::CancellationToken cancellationToken) =>
            DeleteToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ToolVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersions(ListToolVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ToolVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersionsAsync(ListToolVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tool versions.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="ToolVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolVersionsRequest request = new ListToolVersionsRequest
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
            return ListToolVersions(request, callSettings);
        }

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tool versions.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ToolVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolVersionsRequest request = new ListToolVersionsRequest
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
            return ListToolVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tool versions.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="ToolVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersions(ToolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolVersionsRequest request = new ListToolVersionsRequest
            {
                ParentAsToolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListToolVersions(request, callSettings);
        }

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tool versions.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ToolVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersionsAsync(ToolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListToolVersionsRequest request = new ListToolVersionsRequest
            {
                ParentAsToolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListToolVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ToolVersion CreateToolVersion(CreateToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> CreateToolVersionAsync(CreateToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> CreateToolVersionAsync(CreateToolVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateToolVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The tool to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="toolVersion">
        /// Required. The tool version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ToolVersion CreateToolVersion(string parent, ToolVersion toolVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolVersion(new CreateToolVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ToolVersion = gax::GaxPreconditions.CheckNotNull(toolVersion, nameof(toolVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The tool to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="toolVersion">
        /// Required. The tool version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> CreateToolVersionAsync(string parent, ToolVersion toolVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolVersionAsync(new CreateToolVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ToolVersion = gax::GaxPreconditions.CheckNotNull(toolVersion, nameof(toolVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The tool to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="toolVersion">
        /// Required. The tool version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> CreateToolVersionAsync(string parent, ToolVersion toolVersion, st::CancellationToken cancellationToken) =>
            CreateToolVersionAsync(parent, toolVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The tool to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="toolVersion">
        /// Required. The tool version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ToolVersion CreateToolVersion(ToolName parent, ToolVersion toolVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolVersion(new CreateToolVersionRequest
            {
                ParentAsToolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ToolVersion = gax::GaxPreconditions.CheckNotNull(toolVersion, nameof(toolVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The tool to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="toolVersion">
        /// Required. The tool version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> CreateToolVersionAsync(ToolName parent, ToolVersion toolVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreateToolVersionAsync(new CreateToolVersionRequest
            {
                ParentAsToolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ToolVersion = gax::GaxPreconditions.CheckNotNull(toolVersion, nameof(toolVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="parent">
        /// Required. The tool to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;`.
        /// </param>
        /// <param name="toolVersion">
        /// Required. The tool version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> CreateToolVersionAsync(ToolName parent, ToolVersion toolVersion, st::CancellationToken cancellationToken) =>
            CreateToolVersionAsync(parent, toolVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ToolVersion GetToolVersion(GetToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> GetToolVersionAsync(GetToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> GetToolVersionAsync(GetToolVersionRequest request, st::CancellationToken cancellationToken) =>
            GetToolVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ToolVersion GetToolVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolVersion(new GetToolVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> GetToolVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolVersionAsync(new GetToolVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> GetToolVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetToolVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ToolVersion GetToolVersion(ToolVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolVersion(new GetToolVersionRequest
            {
                ToolVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> GetToolVersionAsync(ToolVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetToolVersionAsync(new GetToolVersionRequest
            {
                ToolVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ToolVersion> GetToolVersionAsync(ToolVersionName name, st::CancellationToken cancellationToken) =>
            GetToolVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteToolVersion(DeleteToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolVersionAsync(DeleteToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolVersionAsync(DeleteToolVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteToolVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteToolVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolVersion(new DeleteToolVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolVersionAsync(new DeleteToolVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteToolVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteToolVersion(ToolVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolVersion(new DeleteToolVersionRequest
            {
                ToolVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolVersionAsync(ToolVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteToolVersionAsync(new DeleteToolVersionRequest
            {
                ToolVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteToolVersionAsync(ToolVersionName name, st::CancellationToken cancellationToken) =>
            DeleteToolVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestoreToolVersionResponse RestoreToolVersion(RestoreToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestoreToolVersionResponse> RestoreToolVersionAsync(RestoreToolVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestoreToolVersionResponse> RestoreToolVersionAsync(RestoreToolVersionRequest request, st::CancellationToken cancellationToken) =>
            RestoreToolVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestoreToolVersionResponse RestoreToolVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreToolVersion(new RestoreToolVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestoreToolVersionResponse> RestoreToolVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreToolVersionAsync(new RestoreToolVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestoreToolVersionResponse> RestoreToolVersionAsync(string name, st::CancellationToken cancellationToken) =>
            RestoreToolVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestoreToolVersionResponse RestoreToolVersion(ToolVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreToolVersion(new RestoreToolVersionRequest
            {
                ToolVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestoreToolVersionResponse> RestoreToolVersionAsync(ToolVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreToolVersionAsync(new RestoreToolVersionRequest
            {
                ToolVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tool version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/tools/&lt;ToolID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestoreToolVersionResponse> RestoreToolVersionAsync(ToolVersionName name, st::CancellationToken cancellationToken) =>
            RestoreToolVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Tools client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Tools][google.cloud.dialogflow.cx.v3.Tool].
    /// </remarks>
    public sealed partial class ToolsClientImpl : ToolsClient
    {
        private readonly gaxgrpc::ApiCall<CreateToolRequest, Tool> _callCreateTool;

        private readonly gaxgrpc::ApiCall<ListToolsRequest, ListToolsResponse> _callListTools;

        private readonly gaxgrpc::ApiCall<GetToolRequest, Tool> _callGetTool;

        private readonly gaxgrpc::ApiCall<UpdateToolRequest, Tool> _callUpdateTool;

        private readonly gaxgrpc::ApiCall<DeleteToolRequest, wkt::Empty> _callDeleteTool;

        private readonly gaxgrpc::ApiCall<ListToolVersionsRequest, ListToolVersionsResponse> _callListToolVersions;

        private readonly gaxgrpc::ApiCall<CreateToolVersionRequest, ToolVersion> _callCreateToolVersion;

        private readonly gaxgrpc::ApiCall<GetToolVersionRequest, ToolVersion> _callGetToolVersion;

        private readonly gaxgrpc::ApiCall<DeleteToolVersionRequest, wkt::Empty> _callDeleteToolVersion;

        private readonly gaxgrpc::ApiCall<RestoreToolVersionRequest, RestoreToolVersionResponse> _callRestoreToolVersion;

        /// <summary>
        /// Constructs a client wrapper for the Tools service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ToolsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ToolsClientImpl(Tools.ToolsClient grpcClient, ToolsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ToolsSettings effectiveSettings = settings ?? ToolsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateTool = clientHelper.BuildApiCall<CreateToolRequest, Tool>("CreateTool", grpcClient.CreateToolAsync, grpcClient.CreateTool, effectiveSettings.CreateToolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTool);
            Modify_CreateToolApiCall(ref _callCreateTool);
            _callListTools = clientHelper.BuildApiCall<ListToolsRequest, ListToolsResponse>("ListTools", grpcClient.ListToolsAsync, grpcClient.ListTools, effectiveSettings.ListToolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTools);
            Modify_ListToolsApiCall(ref _callListTools);
            _callGetTool = clientHelper.BuildApiCall<GetToolRequest, Tool>("GetTool", grpcClient.GetToolAsync, grpcClient.GetTool, effectiveSettings.GetToolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTool);
            Modify_GetToolApiCall(ref _callGetTool);
            _callUpdateTool = clientHelper.BuildApiCall<UpdateToolRequest, Tool>("UpdateTool", grpcClient.UpdateToolAsync, grpcClient.UpdateTool, effectiveSettings.UpdateToolSettings).WithGoogleRequestParam("tool.name", request => request.Tool?.Name);
            Modify_ApiCall(ref _callUpdateTool);
            Modify_UpdateToolApiCall(ref _callUpdateTool);
            _callDeleteTool = clientHelper.BuildApiCall<DeleteToolRequest, wkt::Empty>("DeleteTool", grpcClient.DeleteToolAsync, grpcClient.DeleteTool, effectiveSettings.DeleteToolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTool);
            Modify_DeleteToolApiCall(ref _callDeleteTool);
            _callListToolVersions = clientHelper.BuildApiCall<ListToolVersionsRequest, ListToolVersionsResponse>("ListToolVersions", grpcClient.ListToolVersionsAsync, grpcClient.ListToolVersions, effectiveSettings.ListToolVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListToolVersions);
            Modify_ListToolVersionsApiCall(ref _callListToolVersions);
            _callCreateToolVersion = clientHelper.BuildApiCall<CreateToolVersionRequest, ToolVersion>("CreateToolVersion", grpcClient.CreateToolVersionAsync, grpcClient.CreateToolVersion, effectiveSettings.CreateToolVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateToolVersion);
            Modify_CreateToolVersionApiCall(ref _callCreateToolVersion);
            _callGetToolVersion = clientHelper.BuildApiCall<GetToolVersionRequest, ToolVersion>("GetToolVersion", grpcClient.GetToolVersionAsync, grpcClient.GetToolVersion, effectiveSettings.GetToolVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetToolVersion);
            Modify_GetToolVersionApiCall(ref _callGetToolVersion);
            _callDeleteToolVersion = clientHelper.BuildApiCall<DeleteToolVersionRequest, wkt::Empty>("DeleteToolVersion", grpcClient.DeleteToolVersionAsync, grpcClient.DeleteToolVersion, effectiveSettings.DeleteToolVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteToolVersion);
            Modify_DeleteToolVersionApiCall(ref _callDeleteToolVersion);
            _callRestoreToolVersion = clientHelper.BuildApiCall<RestoreToolVersionRequest, RestoreToolVersionResponse>("RestoreToolVersion", grpcClient.RestoreToolVersionAsync, grpcClient.RestoreToolVersion, effectiveSettings.RestoreToolVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestoreToolVersion);
            Modify_RestoreToolVersionApiCall(ref _callRestoreToolVersion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateToolApiCall(ref gaxgrpc::ApiCall<CreateToolRequest, Tool> call);

        partial void Modify_ListToolsApiCall(ref gaxgrpc::ApiCall<ListToolsRequest, ListToolsResponse> call);

        partial void Modify_GetToolApiCall(ref gaxgrpc::ApiCall<GetToolRequest, Tool> call);

        partial void Modify_UpdateToolApiCall(ref gaxgrpc::ApiCall<UpdateToolRequest, Tool> call);

        partial void Modify_DeleteToolApiCall(ref gaxgrpc::ApiCall<DeleteToolRequest, wkt::Empty> call);

        partial void Modify_ListToolVersionsApiCall(ref gaxgrpc::ApiCall<ListToolVersionsRequest, ListToolVersionsResponse> call);

        partial void Modify_CreateToolVersionApiCall(ref gaxgrpc::ApiCall<CreateToolVersionRequest, ToolVersion> call);

        partial void Modify_GetToolVersionApiCall(ref gaxgrpc::ApiCall<GetToolVersionRequest, ToolVersion> call);

        partial void Modify_DeleteToolVersionApiCall(ref gaxgrpc::ApiCall<DeleteToolVersionRequest, wkt::Empty> call);

        partial void Modify_RestoreToolVersionApiCall(ref gaxgrpc::ApiCall<RestoreToolVersionRequest, RestoreToolVersionResponse> call);

        partial void OnConstruction(Tools.ToolsClient grpcClient, ToolsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Tools client</summary>
        public override Tools.ToolsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateToolRequest(ref CreateToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListToolsRequest(ref ListToolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetToolRequest(ref GetToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateToolRequest(ref UpdateToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteToolRequest(ref DeleteToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListToolVersionsRequest(ref ListToolVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateToolVersionRequest(ref CreateToolVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetToolVersionRequest(ref GetToolVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteToolVersionRequest(ref DeleteToolVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreToolVersionRequest(ref RestoreToolVersionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tool CreateTool(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolRequest(ref request, ref callSettings);
            return _callCreateTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a [Tool][google.cloud.dialogflow.cx.v3.Tool] in the specified
        /// agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tool> CreateToolAsync(CreateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolRequest(ref request, ref callSettings);
            return _callCreateTool.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tool"/> resources.</returns>
        public override gax::PagedEnumerable<ListToolsResponse, Tool> ListTools(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListToolsRequest, ListToolsResponse, Tool>(_callListTools, request, callSettings);
        }

        /// <summary>
        /// Returns a list of [Tools][google.cloud.dialogflow.cx.v3.Tool] in the
        /// specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListToolsResponse, Tool> ListToolsAsync(ListToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListToolsRequest, ListToolsResponse, Tool>(_callListTools, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tool GetTool(GetToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolRequest(ref request, ref callSettings);
            return _callGetTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tool> GetToolAsync(GetToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolRequest(ref request, ref callSettings);
            return _callGetTool.Async(request, callSettings);
        }

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tool UpdateTool(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateToolRequest(ref request, ref callSettings);
            return _callUpdateTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tool> UpdateToolAsync(UpdateToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateToolRequest(ref request, ref callSettings);
            return _callUpdateTool.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTool(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolRequest(ref request, ref callSettings);
            _callDeleteTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteToolAsync(DeleteToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolRequest(ref request, ref callSettings);
            return _callDeleteTool.Async(request, callSettings);
        }

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ToolVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersions(ListToolVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListToolVersionsRequest, ListToolVersionsResponse, ToolVersion>(_callListToolVersions, request, callSettings);
        }

        /// <summary>
        /// List versions of the specified [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ToolVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListToolVersionsResponse, ToolVersion> ListToolVersionsAsync(ListToolVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListToolVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListToolVersionsRequest, ListToolVersionsResponse, ToolVersion>(_callListToolVersions, request, callSettings);
        }

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ToolVersion CreateToolVersion(CreateToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolVersionRequest(ref request, ref callSettings);
            return _callCreateToolVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a version for the specified
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ToolVersion> CreateToolVersionAsync(CreateToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateToolVersionRequest(ref request, ref callSettings);
            return _callCreateToolVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ToolVersion GetToolVersion(GetToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolVersionRequest(ref request, ref callSettings);
            return _callGetToolVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ToolVersion> GetToolVersionAsync(GetToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetToolVersionRequest(ref request, ref callSettings);
            return _callGetToolVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteToolVersion(DeleteToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolVersionRequest(ref request, ref callSettings);
            _callDeleteToolVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified version of the
        /// [Tool][google.cloud.dialogflow.cx.v3.Tool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteToolVersionAsync(DeleteToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteToolVersionRequest(ref request, ref callSettings);
            return _callDeleteToolVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RestoreToolVersionResponse RestoreToolVersion(RestoreToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreToolVersionRequest(ref request, ref callSettings);
            return _callRestoreToolVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the Tool and stores it as the
        /// current tool draft, returning the tool with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RestoreToolVersionResponse> RestoreToolVersionAsync(RestoreToolVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreToolVersionRequest(ref request, ref callSettings);
            return _callRestoreToolVersion.Async(request, callSettings);
        }
    }

    public partial class ListToolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListToolVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListToolsResponse : gaxgrpc::IPageResponse<Tool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Tool> GetEnumerator() => Tools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListToolVersionsResponse : gaxgrpc::IPageResponse<ToolVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ToolVersion> GetEnumerator() => ToolVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Tools
    {
        public partial class ToolsClient
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
