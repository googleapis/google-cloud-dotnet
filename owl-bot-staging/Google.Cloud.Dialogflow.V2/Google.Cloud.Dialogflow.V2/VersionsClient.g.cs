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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="VersionsClient"/> instances.</summary>
    public sealed partial class VersionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VersionsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VersionsSettings"/>.</returns>
        public static VersionsSettings GetDefault() => new VersionsSettings();

        /// <summary>Constructs a new <see cref="VersionsSettings"/> object with default settings.</summary>
        public VersionsSettings()
        {
        }

        private VersionsSettings(VersionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListVersionsSettings = existing.ListVersionsSettings;
            GetVersionSettings = existing.GetVersionSettings;
            CreateVersionSettings = existing.CreateVersionSettings;
            UpdateVersionSettings = existing.UpdateVersionSettings;
            DeleteVersionSettings = existing.DeleteVersionSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VersionsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VersionsClient.ListVersions</c>
        ///  and <c>VersionsClient.ListVersionsAsync</c>.
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
        public gaxgrpc::CallSettings ListVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VersionsClient.GetVersion</c>
        ///  and <c>VersionsClient.GetVersionAsync</c>.
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
        public gaxgrpc::CallSettings GetVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VersionsClient.CreateVersion</c> and <c>VersionsClient.CreateVersionAsync</c>.
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
        public gaxgrpc::CallSettings CreateVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VersionsClient.UpdateVersion</c> and <c>VersionsClient.UpdateVersionAsync</c>.
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
        public gaxgrpc::CallSettings UpdateVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VersionsClient.DeleteVersion</c> and <c>VersionsClient.DeleteVersionAsync</c>.
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
        public gaxgrpc::CallSettings DeleteVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VersionsSettings"/> object.</returns>
        public VersionsSettings Clone() => new VersionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VersionsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class VersionsClientBuilder : gaxgrpc::ClientBuilderBase<VersionsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VersionsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VersionsClientBuilder() : base(VersionsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VersionsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VersionsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VersionsClient Build()
        {
            VersionsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VersionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VersionsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VersionsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VersionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VersionsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VersionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VersionsClient.ChannelPool;
    }

    /// <summary>Versions client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Versions][google.cloud.dialogflow.v2.Version].
    /// </remarks>
    public abstract partial class VersionsClient
    {
        /// <summary>
        /// The default endpoint for the Versions service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Versions scopes.</summary>
        /// <remarks>
        /// The default Versions scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Versions.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VersionsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="VersionsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VersionsClient"/>.</returns>
        public static stt::Task<VersionsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VersionsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VersionsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="VersionsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VersionsClient"/>.</returns>
        public static VersionsClient Create() => new VersionsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VersionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VersionsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VersionsClient"/>.</returns>
        internal static VersionsClient Create(grpccore::CallInvoker callInvoker, VersionsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Versions.VersionsClient grpcClient = new Versions.VersionsClient(callInvoker);
            return new VersionsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Versions client</summary>
        public virtual Versions.VersionsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all versions from.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
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
            return ListVersions(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all versions from.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
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
            return ListVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all versions from.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
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
            return ListVersions(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all versions from.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
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
            return ListVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, st::CancellationToken cancellationToken) =>
            GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersion(new GetVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersionAsync(new GetVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersion(new GetVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersionAsync(new GetVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(VersionName name, st::CancellationToken cancellationToken) =>
            GetVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version CreateVersion(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(CreateVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a version for.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version CreateVersion(string parent, Version version, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersion(new CreateVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a version for.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(string parent, Version version, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersionAsync(new CreateVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a version for.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(string parent, Version version, st::CancellationToken cancellationToken) =>
            CreateVersionAsync(parent, version, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a version for.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version CreateVersion(AgentName parent, Version version, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersion(new CreateVersionRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a version for.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(AgentName parent, Version version, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersionAsync(new CreateVersionRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a version for.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(AgentName parent, Version version, st::CancellationToken cancellationToken) =>
            CreateVersionAsync(parent, version, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, st::CancellationToken cancellationToken) =>
            UpdateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="version">
        /// Required. The version to update.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version UpdateVersion(Version version, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVersion(new UpdateVersionRequest
            {
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="version">
        /// Required. The version to update.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(Version version, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVersionAsync(new UpdateVersionRequest
            {
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="version">
        /// Required. The version to update.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(Version version, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVersionAsync(version, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(DeleteVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersion(new DeleteVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersionAsync(new DeleteVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVersion(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersion(new DeleteVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersionAsync(new DeleteVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Supported formats:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent/versions/&lt;Version ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/versions/&lt;Version
        /// ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(VersionName name, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Versions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Versions][google.cloud.dialogflow.v2.Version].
    /// </remarks>
    public sealed partial class VersionsClientImpl : VersionsClient
    {
        private readonly gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> _callListVersions;

        private readonly gaxgrpc::ApiCall<GetVersionRequest, Version> _callGetVersion;

        private readonly gaxgrpc::ApiCall<CreateVersionRequest, Version> _callCreateVersion;

        private readonly gaxgrpc::ApiCall<UpdateVersionRequest, Version> _callUpdateVersion;

        private readonly gaxgrpc::ApiCall<DeleteVersionRequest, wkt::Empty> _callDeleteVersion;

        /// <summary>
        /// Constructs a client wrapper for the Versions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VersionsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VersionsClientImpl(Versions.VersionsClient grpcClient, VersionsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VersionsSettings effectiveSettings = settings ?? VersionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListVersions = clientHelper.BuildApiCall<ListVersionsRequest, ListVersionsResponse>("ListVersions", grpcClient.ListVersionsAsync, grpcClient.ListVersions, effectiveSettings.ListVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVersions);
            Modify_ListVersionsApiCall(ref _callListVersions);
            _callGetVersion = clientHelper.BuildApiCall<GetVersionRequest, Version>("GetVersion", grpcClient.GetVersionAsync, grpcClient.GetVersion, effectiveSettings.GetVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVersion);
            Modify_GetVersionApiCall(ref _callGetVersion);
            _callCreateVersion = clientHelper.BuildApiCall<CreateVersionRequest, Version>("CreateVersion", grpcClient.CreateVersionAsync, grpcClient.CreateVersion, effectiveSettings.CreateVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVersion);
            Modify_CreateVersionApiCall(ref _callCreateVersion);
            _callUpdateVersion = clientHelper.BuildApiCall<UpdateVersionRequest, Version>("UpdateVersion", grpcClient.UpdateVersionAsync, grpcClient.UpdateVersion, effectiveSettings.UpdateVersionSettings).WithGoogleRequestParam("version.name", request => request.Version?.Name);
            Modify_ApiCall(ref _callUpdateVersion);
            Modify_UpdateVersionApiCall(ref _callUpdateVersion);
            _callDeleteVersion = clientHelper.BuildApiCall<DeleteVersionRequest, wkt::Empty>("DeleteVersion", grpcClient.DeleteVersionAsync, grpcClient.DeleteVersion, effectiveSettings.DeleteVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVersion);
            Modify_DeleteVersionApiCall(ref _callDeleteVersion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListVersionsApiCall(ref gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> call);

        partial void Modify_GetVersionApiCall(ref gaxgrpc::ApiCall<GetVersionRequest, Version> call);

        partial void Modify_CreateVersionApiCall(ref gaxgrpc::ApiCall<CreateVersionRequest, Version> call);

        partial void Modify_UpdateVersionApiCall(ref gaxgrpc::ApiCall<UpdateVersionRequest, Version> call);

        partial void Modify_DeleteVersionApiCall(ref gaxgrpc::ApiCall<DeleteVersionRequest, wkt::Empty> call);

        partial void OnConstruction(Versions.VersionsClient grpcClient, VersionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Versions client</summary>
        public override Versions.VersionsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListVersionsRequest(ref ListVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVersionRequest(ref GetVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVersionRequest(ref CreateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVersionRequest(ref UpdateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVersionRequest(ref DeleteVersionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all versions of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version CreateVersion(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVersionRequest(ref request, ref callSettings);
            return _callCreateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an agent version.
        /// 
        /// The new version points to the agent instance in the "default" environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> CreateVersionAsync(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVersionRequest(ref request, ref callSettings);
            return _callCreateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return _callUpdateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent version.
        /// 
        /// Note that this method does not allow you to update the state of the agent
        /// the given version points to. It allows you to update only mutable
        /// properties of the version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return _callUpdateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            _callDeleteVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete the specified agent version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            return _callDeleteVersion.Async(request, callSettings);
        }
    }

    public partial class ListVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVersionsResponse : gaxgrpc::IPageResponse<Version>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Version> GetEnumerator() => Versions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Versions
    {
        public partial class VersionsClient
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
