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
using gagr = Google.Api.Gax.ResourceNames;
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

namespace Google.Cloud.ApiRegistry.V1Beta
{
    /// <summary>Settings for <see cref="CloudApiRegistryClient"/> instances.</summary>
    public sealed partial class CloudApiRegistrySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudApiRegistrySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudApiRegistrySettings"/>.</returns>
        public static CloudApiRegistrySettings GetDefault() => new CloudApiRegistrySettings();

        /// <summary>Constructs a new <see cref="CloudApiRegistrySettings"/> object with default settings.</summary>
        public CloudApiRegistrySettings()
        {
        }

        private CloudApiRegistrySettings(CloudApiRegistrySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMcpServerSettings = existing.GetMcpServerSettings;
            ListMcpServersSettings = existing.ListMcpServersSettings;
            GetMcpToolSettings = existing.GetMcpToolSettings;
            ListMcpToolsSettings = existing.ListMcpToolsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudApiRegistrySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudApiRegistryClient.GetMcpServer</c> and <c>CloudApiRegistryClient.GetMcpServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMcpServerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudApiRegistryClient.ListMcpServers</c> and <c>CloudApiRegistryClient.ListMcpServersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMcpServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudApiRegistryClient.GetMcpTool</c> and <c>CloudApiRegistryClient.GetMcpToolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMcpToolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudApiRegistryClient.ListMcpTools</c> and <c>CloudApiRegistryClient.ListMcpToolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMcpToolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudApiRegistrySettings"/> object.</returns>
        public CloudApiRegistrySettings Clone() => new CloudApiRegistrySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudApiRegistryClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CloudApiRegistryClientBuilder : gaxgrpc::ClientBuilderBase<CloudApiRegistryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudApiRegistrySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudApiRegistryClientBuilder() : base(CloudApiRegistryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudApiRegistryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudApiRegistryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudApiRegistryClient Build()
        {
            CloudApiRegistryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudApiRegistryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudApiRegistryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudApiRegistryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudApiRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudApiRegistryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudApiRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudApiRegistryClient.ChannelPool;
    }

    /// <summary>CloudApiRegistry client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Cloud API Registry service provides a central registry for managing API
    /// Data.
    /// </remarks>
    public abstract partial class CloudApiRegistryClient
    {
        /// <summary>
        /// The default endpoint for the CloudApiRegistry service, which is a host of "cloudapiregistry.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudapiregistry.googleapis.com:443";

        /// <summary>The default CloudApiRegistry scopes.</summary>
        /// <remarks>
        /// The default CloudApiRegistry scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudApiRegistry.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudApiRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudApiRegistryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudApiRegistryClient"/>.</returns>
        public static stt::Task<CloudApiRegistryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudApiRegistryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudApiRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudApiRegistryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudApiRegistryClient"/>.</returns>
        public static CloudApiRegistryClient Create() => new CloudApiRegistryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudApiRegistryClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudApiRegistrySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudApiRegistryClient"/>.</returns>
        internal static CloudApiRegistryClient Create(grpccore::CallInvoker callInvoker, CloudApiRegistrySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudApiRegistry.CloudApiRegistryClient grpcClient = new CloudApiRegistry.CloudApiRegistryClient(callInvoker);
            return new CloudApiRegistryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudApiRegistry client</summary>
        public virtual CloudApiRegistry.CloudApiRegistryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetMcpServer(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(GetMcpServerRequest request, st::CancellationToken cancellationToken) =>
            GetMcpServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetMcpServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServer(new GetMcpServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServerAsync(new GetMcpServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(string name, st::CancellationToken cancellationToken) =>
            GetMcpServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpServer GetMcpServer(McpServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServer(new GetMcpServerRequest
            {
                McpServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(McpServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpServerAsync(new GetMcpServerRequest
            {
                McpServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpServer> GetMcpServerAsync(McpServerName name, st::CancellationToken cancellationToken) =>
            GetMcpServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest
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
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServers(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest
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
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServers(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpServersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpServersRequest request = new ListMcpServersRequest
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
            return ListMcpServersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpTool GetMcpTool(GetMcpToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpTool> GetMcpToolAsync(GetMcpToolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpTool> GetMcpToolAsync(GetMcpToolRequest request, st::CancellationToken cancellationToken) =>
            GetMcpToolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpTool GetMcpTool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpTool(new GetMcpToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpTool> GetMcpToolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpToolAsync(new GetMcpToolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpTool> GetMcpToolAsync(string name, st::CancellationToken cancellationToken) =>
            GetMcpToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual McpTool GetMcpTool(McpToolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpTool(new GetMcpToolRequest
            {
                McpToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpTool> GetMcpToolAsync(McpToolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMcpToolAsync(new GetMcpToolRequest
            {
                McpToolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<McpTool> GetMcpToolAsync(McpToolName name, st::CancellationToken cancellationToken) =>
            GetMcpToolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpTool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpToolsResponse, McpTool> ListMcpTools(ListMcpToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpTool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpToolsResponse, McpTool> ListMcpToolsAsync(ListMcpToolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpToolsRequest
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
        /// <returns>A pageable sequence of <see cref="McpTool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpToolsResponse, McpTool> ListMcpTools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpToolsRequest request = new ListMcpToolsRequest
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
            return ListMcpTools(request, callSettings);
        }

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpToolsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpTool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpToolsResponse, McpTool> ListMcpToolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpToolsRequest request = new ListMcpToolsRequest
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
            return ListMcpToolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpToolsRequest
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
        /// <returns>A pageable sequence of <see cref="McpTool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMcpToolsResponse, McpTool> ListMcpTools(McpServerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpToolsRequest request = new ListMcpToolsRequest
            {
                ParentAsMcpServerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMcpTools(request, callSettings);
        }

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListMcpToolsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="McpTool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMcpToolsResponse, McpTool> ListMcpToolsAsync(McpServerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMcpToolsRequest request = new ListMcpToolsRequest
            {
                ParentAsMcpServerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMcpToolsAsync(request, callSettings);
        }
    }

    /// <summary>CloudApiRegistry client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Cloud API Registry service provides a central registry for managing API
    /// Data.
    /// </remarks>
    public sealed partial class CloudApiRegistryClientImpl : CloudApiRegistryClient
    {
        private readonly gaxgrpc::ApiCall<GetMcpServerRequest, McpServer> _callGetMcpServer;

        private readonly gaxgrpc::ApiCall<ListMcpServersRequest, ListMcpServersResponse> _callListMcpServers;

        private readonly gaxgrpc::ApiCall<GetMcpToolRequest, McpTool> _callGetMcpTool;

        private readonly gaxgrpc::ApiCall<ListMcpToolsRequest, ListMcpToolsResponse> _callListMcpTools;

        /// <summary>
        /// Constructs a client wrapper for the CloudApiRegistry service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudApiRegistrySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudApiRegistryClientImpl(CloudApiRegistry.CloudApiRegistryClient grpcClient, CloudApiRegistrySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudApiRegistrySettings effectiveSettings = settings ?? CloudApiRegistrySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetMcpServer = clientHelper.BuildApiCall<GetMcpServerRequest, McpServer>("GetMcpServer", grpcClient.GetMcpServerAsync, grpcClient.GetMcpServer, effectiveSettings.GetMcpServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMcpServer);
            Modify_GetMcpServerApiCall(ref _callGetMcpServer);
            _callListMcpServers = clientHelper.BuildApiCall<ListMcpServersRequest, ListMcpServersResponse>("ListMcpServers", grpcClient.ListMcpServersAsync, grpcClient.ListMcpServers, effectiveSettings.ListMcpServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMcpServers);
            Modify_ListMcpServersApiCall(ref _callListMcpServers);
            _callGetMcpTool = clientHelper.BuildApiCall<GetMcpToolRequest, McpTool>("GetMcpTool", grpcClient.GetMcpToolAsync, grpcClient.GetMcpTool, effectiveSettings.GetMcpToolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMcpTool);
            Modify_GetMcpToolApiCall(ref _callGetMcpTool);
            _callListMcpTools = clientHelper.BuildApiCall<ListMcpToolsRequest, ListMcpToolsResponse>("ListMcpTools", grpcClient.ListMcpToolsAsync, grpcClient.ListMcpTools, effectiveSettings.ListMcpToolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMcpTools);
            Modify_ListMcpToolsApiCall(ref _callListMcpTools);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMcpServerApiCall(ref gaxgrpc::ApiCall<GetMcpServerRequest, McpServer> call);

        partial void Modify_ListMcpServersApiCall(ref gaxgrpc::ApiCall<ListMcpServersRequest, ListMcpServersResponse> call);

        partial void Modify_GetMcpToolApiCall(ref gaxgrpc::ApiCall<GetMcpToolRequest, McpTool> call);

        partial void Modify_ListMcpToolsApiCall(ref gaxgrpc::ApiCall<ListMcpToolsRequest, ListMcpToolsResponse> call);

        partial void OnConstruction(CloudApiRegistry.CloudApiRegistryClient grpcClient, CloudApiRegistrySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudApiRegistry client</summary>
        public override CloudApiRegistry.CloudApiRegistryClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetMcpServerRequest(ref GetMcpServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMcpServersRequest(ref ListMcpServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMcpToolRequest(ref GetMcpToolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMcpToolsRequest(ref ListMcpToolsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override McpServer GetMcpServer(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMcpServerRequest(ref request, ref callSettings);
            return _callGetMcpServer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<McpServer> GetMcpServerAsync(GetMcpServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMcpServerRequest(ref request, ref callSettings);
            return _callGetMcpServer.Async(request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedEnumerable<ListMcpServersResponse, McpServer> ListMcpServers(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMcpServersRequest, ListMcpServersResponse, McpServer>(_callListMcpServers, request, callSettings);
        }

        /// <summary>
        /// Lists McpServers in a given Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpServer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMcpServersResponse, McpServer> ListMcpServersAsync(ListMcpServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMcpServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMcpServersRequest, ListMcpServersResponse, McpServer>(_callListMcpServers, request, callSettings);
        }

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override McpTool GetMcpTool(GetMcpToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMcpToolRequest(ref request, ref callSettings);
            return _callGetMcpTool.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single McpTool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<McpTool> GetMcpToolAsync(GetMcpToolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMcpToolRequest(ref request, ref callSettings);
            return _callGetMcpTool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McpTool"/> resources.</returns>
        public override gax::PagedEnumerable<ListMcpToolsResponse, McpTool> ListMcpTools(ListMcpToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMcpToolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMcpToolsRequest, ListMcpToolsResponse, McpTool>(_callListMcpTools, request, callSettings);
        }

        /// <summary>
        /// Lists McpTools in a given McpServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McpTool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMcpToolsResponse, McpTool> ListMcpToolsAsync(ListMcpToolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMcpToolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMcpToolsRequest, ListMcpToolsResponse, McpTool>(_callListMcpTools, request, callSettings);
        }
    }

    public partial class ListMcpServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMcpToolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMcpServersResponse : gaxgrpc::IPageResponse<McpServer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<McpServer> GetEnumerator() => McpServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMcpToolsResponse : gaxgrpc::IPageResponse<McpTool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<McpTool> GetEnumerator() => McpTools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudApiRegistry
    {
        public partial class CloudApiRegistryClient
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
