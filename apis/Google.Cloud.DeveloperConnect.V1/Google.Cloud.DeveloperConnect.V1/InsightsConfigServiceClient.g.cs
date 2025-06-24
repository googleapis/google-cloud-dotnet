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

namespace Google.Cloud.DeveloperConnect.V1
{
    /// <summary>Settings for <see cref="InsightsConfigServiceClient"/> instances.</summary>
    public sealed partial class InsightsConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="InsightsConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="InsightsConfigServiceSettings"/>.</returns>
        public static InsightsConfigServiceSettings GetDefault() => new InsightsConfigServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="InsightsConfigServiceSettings"/> object with default settings.
        /// </summary>
        public InsightsConfigServiceSettings()
        {
        }

        private InsightsConfigServiceSettings(InsightsConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInsightsConfigsSettings = existing.ListInsightsConfigsSettings;
            CreateInsightsConfigSettings = existing.CreateInsightsConfigSettings;
            CreateInsightsConfigOperationsSettings = existing.CreateInsightsConfigOperationsSettings.Clone();
            GetInsightsConfigSettings = existing.GetInsightsConfigSettings;
            UpdateInsightsConfigSettings = existing.UpdateInsightsConfigSettings;
            UpdateInsightsConfigOperationsSettings = existing.UpdateInsightsConfigOperationsSettings.Clone();
            DeleteInsightsConfigSettings = existing.DeleteInsightsConfigSettings;
            DeleteInsightsConfigOperationsSettings = existing.DeleteInsightsConfigOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(InsightsConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InsightsConfigServiceClient.ListInsightsConfigs</c> and
        /// <c>InsightsConfigServiceClient.ListInsightsConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInsightsConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InsightsConfigServiceClient.CreateInsightsConfig</c> and
        /// <c>InsightsConfigServiceClient.CreateInsightsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInsightsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InsightsConfigServiceClient.CreateInsightsConfig</c> and
        /// <c>InsightsConfigServiceClient.CreateInsightsConfigAsync</c>.
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
        public lro::OperationsSettings CreateInsightsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InsightsConfigServiceClient.GetInsightsConfig</c> and
        /// <c>InsightsConfigServiceClient.GetInsightsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInsightsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InsightsConfigServiceClient.UpdateInsightsConfig</c> and
        /// <c>InsightsConfigServiceClient.UpdateInsightsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInsightsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InsightsConfigServiceClient.UpdateInsightsConfig</c> and
        /// <c>InsightsConfigServiceClient.UpdateInsightsConfigAsync</c>.
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
        public lro::OperationsSettings UpdateInsightsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InsightsConfigServiceClient.DeleteInsightsConfig</c> and
        /// <c>InsightsConfigServiceClient.DeleteInsightsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInsightsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>InsightsConfigServiceClient.DeleteInsightsConfig</c> and
        /// <c>InsightsConfigServiceClient.DeleteInsightsConfigAsync</c>.
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
        public lro::OperationsSettings DeleteInsightsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="InsightsConfigServiceSettings"/> object.</returns>
        public InsightsConfigServiceSettings Clone() => new InsightsConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InsightsConfigServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class InsightsConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<InsightsConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InsightsConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public InsightsConfigServiceClientBuilder() : base(InsightsConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref InsightsConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InsightsConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InsightsConfigServiceClient Build()
        {
            InsightsConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InsightsConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InsightsConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InsightsConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InsightsConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<InsightsConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InsightsConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InsightsConfigServiceClient.ChannelPool;
    }

    /// <summary>InsightsConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Creates and manages InsightsConfigs.
    /// 
    /// The InsightsConfig resource is the core configuration object to capture
    /// events from your Software Development Lifecycle. It acts as the central hub
    /// for managing how Developer connect understands your application, its runtime
    /// environments, and the artifacts deployed within them.
    /// A user can create an InsightsConfig, list previously-requested
    /// InsightsConfigs or get InsightsConfigs by their ID to determine the status of
    /// the InsightsConfig.
    /// </remarks>
    public abstract partial class InsightsConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the InsightsConfigService service, which is a host of
        /// "developerconnect.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "developerconnect.googleapis.com:443";

        /// <summary>The default InsightsConfigService scopes.</summary>
        /// <remarks>
        /// The default InsightsConfigService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(InsightsConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="InsightsConfigServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="InsightsConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InsightsConfigServiceClient"/>.</returns>
        public static stt::Task<InsightsConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InsightsConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InsightsConfigServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="InsightsConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InsightsConfigServiceClient"/>.</returns>
        public static InsightsConfigServiceClient Create() => new InsightsConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InsightsConfigServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InsightsConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="InsightsConfigServiceClient"/>.</returns>
        internal static InsightsConfigServiceClient Create(grpccore::CallInvoker callInvoker, InsightsConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InsightsConfigService.InsightsConfigServiceClient grpcClient = new InsightsConfigService.InsightsConfigServiceClient(callInvoker);
            return new InsightsConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC InsightsConfigService client</summary>
        public virtual InsightsConfigService.InsightsConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InsightsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigs(ListInsightsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InsightsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigsAsync(ListInsightsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInsightsConfigsRequest.
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
        /// <returns>A pageable sequence of <see cref="InsightsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsConfigsRequest request = new ListInsightsConfigsRequest
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
            return ListInsightsConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInsightsConfigsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InsightsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsConfigsRequest request = new ListInsightsConfigsRequest
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
            return ListInsightsConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInsightsConfigsRequest.
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
        /// <returns>A pageable sequence of <see cref="InsightsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsConfigsRequest request = new ListInsightsConfigsRequest
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
            return ListInsightsConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInsightsConfigsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InsightsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsConfigsRequest request = new ListInsightsConfigsRequest
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
            return ListInsightsConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InsightsConfig, OperationMetadata> CreateInsightsConfig(CreateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> CreateInsightsConfigAsync(CreateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> CreateInsightsConfigAsync(CreateInsightsConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateInsightsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInsightsConfig</c>.</summary>
        public virtual lro::OperationsClient CreateInsightsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInsightsConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InsightsConfig, OperationMetadata> PollOnceCreateInsightsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InsightsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInsightsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInsightsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> PollOnceCreateInsightsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InsightsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInsightsConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="insightsConfig">
        /// Required. The resource being created.
        /// </param>
        /// <param name="insightsConfigId">
        /// Required. ID of the requesting InsightsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InsightsConfig, OperationMetadata> CreateInsightsConfig(string parent, InsightsConfig insightsConfig, string insightsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInsightsConfig(new CreateInsightsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InsightsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(insightsConfigId, nameof(insightsConfigId)),
                InsightsConfig = gax::GaxPreconditions.CheckNotNull(insightsConfig, nameof(insightsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="insightsConfig">
        /// Required. The resource being created.
        /// </param>
        /// <param name="insightsConfigId">
        /// Required. ID of the requesting InsightsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> CreateInsightsConfigAsync(string parent, InsightsConfig insightsConfig, string insightsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInsightsConfigAsync(new CreateInsightsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InsightsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(insightsConfigId, nameof(insightsConfigId)),
                InsightsConfig = gax::GaxPreconditions.CheckNotNull(insightsConfig, nameof(insightsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="insightsConfig">
        /// Required. The resource being created.
        /// </param>
        /// <param name="insightsConfigId">
        /// Required. ID of the requesting InsightsConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> CreateInsightsConfigAsync(string parent, InsightsConfig insightsConfig, string insightsConfigId, st::CancellationToken cancellationToken) =>
            CreateInsightsConfigAsync(parent, insightsConfig, insightsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="insightsConfig">
        /// Required. The resource being created.
        /// </param>
        /// <param name="insightsConfigId">
        /// Required. ID of the requesting InsightsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InsightsConfig, OperationMetadata> CreateInsightsConfig(gagr::LocationName parent, InsightsConfig insightsConfig, string insightsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInsightsConfig(new CreateInsightsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InsightsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(insightsConfigId, nameof(insightsConfigId)),
                InsightsConfig = gax::GaxPreconditions.CheckNotNull(insightsConfig, nameof(insightsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="insightsConfig">
        /// Required. The resource being created.
        /// </param>
        /// <param name="insightsConfigId">
        /// Required. ID of the requesting InsightsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> CreateInsightsConfigAsync(gagr::LocationName parent, InsightsConfig insightsConfig, string insightsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInsightsConfigAsync(new CreateInsightsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InsightsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(insightsConfigId, nameof(insightsConfigId)),
                InsightsConfig = gax::GaxPreconditions.CheckNotNull(insightsConfig, nameof(insightsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="insightsConfig">
        /// Required. The resource being created.
        /// </param>
        /// <param name="insightsConfigId">
        /// Required. ID of the requesting InsightsConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> CreateInsightsConfigAsync(gagr::LocationName parent, InsightsConfig insightsConfig, string insightsConfigId, st::CancellationToken cancellationToken) =>
            CreateInsightsConfigAsync(parent, insightsConfig, insightsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightsConfig GetInsightsConfig(GetInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightsConfig> GetInsightsConfigAsync(GetInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightsConfig> GetInsightsConfigAsync(GetInsightsConfigRequest request, st::CancellationToken cancellationToken) =>
            GetInsightsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightsConfig GetInsightsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightsConfig(new GetInsightsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightsConfig> GetInsightsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightsConfigAsync(new GetInsightsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightsConfig> GetInsightsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetInsightsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightsConfig GetInsightsConfig(InsightsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightsConfig(new GetInsightsConfigRequest
            {
                InsightsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightsConfig> GetInsightsConfigAsync(InsightsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightsConfigAsync(new GetInsightsConfigRequest
            {
                InsightsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightsConfig> GetInsightsConfigAsync(InsightsConfigName name, st::CancellationToken cancellationToken) =>
            GetInsightsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single InsightsConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InsightsConfig, OperationMetadata> UpdateInsightsConfig(UpdateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single InsightsConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> UpdateInsightsConfigAsync(UpdateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single InsightsConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> UpdateInsightsConfigAsync(UpdateInsightsConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateInsightsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInsightsConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateInsightsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInsightsConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InsightsConfig, OperationMetadata> PollOnceUpdateInsightsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InsightsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInsightsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInsightsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> PollOnceUpdateInsightsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InsightsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInsightsConfigOperationsClient, callSettings);

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInsightsConfig(DeleteInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInsightsConfigAsync(DeleteInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInsightsConfigAsync(DeleteInsightsConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteInsightsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInsightsConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteInsightsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInsightsConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInsightsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInsightsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInsightsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInsightsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInsightsConfigOperationsClient, callSettings);

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Value for parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInsightsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInsightsConfig(new DeleteInsightsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Value for parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInsightsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInsightsConfigAsync(new DeleteInsightsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Value for parent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInsightsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInsightsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Value for parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInsightsConfig(InsightsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInsightsConfig(new DeleteInsightsConfigRequest
            {
                InsightsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Value for parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInsightsConfigAsync(InsightsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInsightsConfigAsync(new DeleteInsightsConfigRequest
            {
                InsightsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="name">
        /// Required. Value for parent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInsightsConfigAsync(InsightsConfigName name, st::CancellationToken cancellationToken) =>
            DeleteInsightsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>InsightsConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Creates and manages InsightsConfigs.
    /// 
    /// The InsightsConfig resource is the core configuration object to capture
    /// events from your Software Development Lifecycle. It acts as the central hub
    /// for managing how Developer connect understands your application, its runtime
    /// environments, and the artifacts deployed within them.
    /// A user can create an InsightsConfig, list previously-requested
    /// InsightsConfigs or get InsightsConfigs by their ID to determine the status of
    /// the InsightsConfig.
    /// </remarks>
    public sealed partial class InsightsConfigServiceClientImpl : InsightsConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListInsightsConfigsRequest, ListInsightsConfigsResponse> _callListInsightsConfigs;

        private readonly gaxgrpc::ApiCall<CreateInsightsConfigRequest, lro::Operation> _callCreateInsightsConfig;

        private readonly gaxgrpc::ApiCall<GetInsightsConfigRequest, InsightsConfig> _callGetInsightsConfig;

        private readonly gaxgrpc::ApiCall<UpdateInsightsConfigRequest, lro::Operation> _callUpdateInsightsConfig;

        private readonly gaxgrpc::ApiCall<DeleteInsightsConfigRequest, lro::Operation> _callDeleteInsightsConfig;

        /// <summary>
        /// Constructs a client wrapper for the InsightsConfigService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InsightsConfigServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public InsightsConfigServiceClientImpl(InsightsConfigService.InsightsConfigServiceClient grpcClient, InsightsConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            InsightsConfigServiceSettings effectiveSettings = settings ?? InsightsConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInsightsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInsightsConfigOperationsSettings, logger);
            UpdateInsightsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInsightsConfigOperationsSettings, logger);
            DeleteInsightsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInsightsConfigOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListInsightsConfigs = clientHelper.BuildApiCall<ListInsightsConfigsRequest, ListInsightsConfigsResponse>("ListInsightsConfigs", grpcClient.ListInsightsConfigsAsync, grpcClient.ListInsightsConfigs, effectiveSettings.ListInsightsConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInsightsConfigs);
            Modify_ListInsightsConfigsApiCall(ref _callListInsightsConfigs);
            _callCreateInsightsConfig = clientHelper.BuildApiCall<CreateInsightsConfigRequest, lro::Operation>("CreateInsightsConfig", grpcClient.CreateInsightsConfigAsync, grpcClient.CreateInsightsConfig, effectiveSettings.CreateInsightsConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInsightsConfig);
            Modify_CreateInsightsConfigApiCall(ref _callCreateInsightsConfig);
            _callGetInsightsConfig = clientHelper.BuildApiCall<GetInsightsConfigRequest, InsightsConfig>("GetInsightsConfig", grpcClient.GetInsightsConfigAsync, grpcClient.GetInsightsConfig, effectiveSettings.GetInsightsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInsightsConfig);
            Modify_GetInsightsConfigApiCall(ref _callGetInsightsConfig);
            _callUpdateInsightsConfig = clientHelper.BuildApiCall<UpdateInsightsConfigRequest, lro::Operation>("UpdateInsightsConfig", grpcClient.UpdateInsightsConfigAsync, grpcClient.UpdateInsightsConfig, effectiveSettings.UpdateInsightsConfigSettings).WithGoogleRequestParam("insights_config.name", request => request.InsightsConfig?.Name);
            Modify_ApiCall(ref _callUpdateInsightsConfig);
            Modify_UpdateInsightsConfigApiCall(ref _callUpdateInsightsConfig);
            _callDeleteInsightsConfig = clientHelper.BuildApiCall<DeleteInsightsConfigRequest, lro::Operation>("DeleteInsightsConfig", grpcClient.DeleteInsightsConfigAsync, grpcClient.DeleteInsightsConfig, effectiveSettings.DeleteInsightsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInsightsConfig);
            Modify_DeleteInsightsConfigApiCall(ref _callDeleteInsightsConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInsightsConfigsApiCall(ref gaxgrpc::ApiCall<ListInsightsConfigsRequest, ListInsightsConfigsResponse> call);

        partial void Modify_CreateInsightsConfigApiCall(ref gaxgrpc::ApiCall<CreateInsightsConfigRequest, lro::Operation> call);

        partial void Modify_GetInsightsConfigApiCall(ref gaxgrpc::ApiCall<GetInsightsConfigRequest, InsightsConfig> call);

        partial void Modify_UpdateInsightsConfigApiCall(ref gaxgrpc::ApiCall<UpdateInsightsConfigRequest, lro::Operation> call);

        partial void Modify_DeleteInsightsConfigApiCall(ref gaxgrpc::ApiCall<DeleteInsightsConfigRequest, lro::Operation> call);

        partial void OnConstruction(InsightsConfigService.InsightsConfigServiceClient grpcClient, InsightsConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC InsightsConfigService client</summary>
        public override InsightsConfigService.InsightsConfigServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListInsightsConfigsRequest(ref ListInsightsConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInsightsConfigRequest(ref CreateInsightsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInsightsConfigRequest(ref GetInsightsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInsightsConfigRequest(ref UpdateInsightsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInsightsConfigRequest(ref DeleteInsightsConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InsightsConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigs(ListInsightsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInsightsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInsightsConfigsRequest, ListInsightsConfigsResponse, InsightsConfig>(_callListInsightsConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists InsightsConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InsightsConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInsightsConfigsResponse, InsightsConfig> ListInsightsConfigsAsync(ListInsightsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInsightsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInsightsConfigsRequest, ListInsightsConfigsResponse, InsightsConfig>(_callListInsightsConfigs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInsightsConfig</c>.</summary>
        public override lro::OperationsClient CreateInsightsConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InsightsConfig, OperationMetadata> CreateInsightsConfig(CreateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInsightsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InsightsConfig, OperationMetadata>(_callCreateInsightsConfig.Sync(request, callSettings), CreateInsightsConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new InsightsConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> CreateInsightsConfigAsync(CreateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInsightsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InsightsConfig, OperationMetadata>(await _callCreateInsightsConfig.Async(request, callSettings).ConfigureAwait(false), CreateInsightsConfigOperationsClient);
        }

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InsightsConfig GetInsightsConfig(GetInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInsightsConfigRequest(ref request, ref callSettings);
            return _callGetInsightsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InsightsConfig> GetInsightsConfigAsync(GetInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInsightsConfigRequest(ref request, ref callSettings);
            return _callGetInsightsConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateInsightsConfig</c>.</summary>
        public override lro::OperationsClient UpdateInsightsConfigOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single InsightsConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InsightsConfig, OperationMetadata> UpdateInsightsConfig(UpdateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInsightsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InsightsConfig, OperationMetadata>(_callUpdateInsightsConfig.Sync(request, callSettings), UpdateInsightsConfigOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single InsightsConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InsightsConfig, OperationMetadata>> UpdateInsightsConfigAsync(UpdateInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInsightsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<InsightsConfig, OperationMetadata>(await _callUpdateInsightsConfig.Async(request, callSettings).ConfigureAwait(false), UpdateInsightsConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInsightsConfig</c>.</summary>
        public override lro::OperationsClient DeleteInsightsConfigOperationsClient { get; }

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInsightsConfig(DeleteInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInsightsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInsightsConfig.Sync(request, callSettings), DeleteInsightsConfigOperationsClient);
        }

        /// <summary>
        /// Delete a single Insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInsightsConfigAsync(DeleteInsightsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInsightsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInsightsConfig.Async(request, callSettings).ConfigureAwait(false), DeleteInsightsConfigOperationsClient);
        }
    }

    public partial class ListInsightsConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInsightsConfigsResponse : gaxgrpc::IPageResponse<InsightsConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InsightsConfig> GetEnumerator() => InsightsConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class InsightsConfigService
    {
        public partial class InsightsConfigServiceClient
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

    public static partial class InsightsConfigService
    {
        public partial class InsightsConfigServiceClient
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
