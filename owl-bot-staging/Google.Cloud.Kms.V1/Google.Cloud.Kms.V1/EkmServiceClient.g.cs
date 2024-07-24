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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Kms.V1
{
    /// <summary>Settings for <see cref="EkmServiceClient"/> instances.</summary>
    public sealed partial class EkmServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EkmServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EkmServiceSettings"/>.</returns>
        public static EkmServiceSettings GetDefault() => new EkmServiceSettings();

        /// <summary>Constructs a new <see cref="EkmServiceSettings"/> object with default settings.</summary>
        public EkmServiceSettings()
        {
        }

        private EkmServiceSettings(EkmServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEkmConnectionsSettings = existing.ListEkmConnectionsSettings;
            GetEkmConnectionSettings = existing.GetEkmConnectionSettings;
            CreateEkmConnectionSettings = existing.CreateEkmConnectionSettings;
            UpdateEkmConnectionSettings = existing.UpdateEkmConnectionSettings;
            GetEkmConfigSettings = existing.GetEkmConfigSettings;
            UpdateEkmConfigSettings = existing.UpdateEkmConfigSettings;
            VerifyConnectivitySettings = existing.VerifyConnectivitySettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(EkmServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.ListEkmConnections</c> and <c>EkmServiceClient.ListEkmConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEkmConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.GetEkmConnection</c> and <c>EkmServiceClient.GetEkmConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEkmConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.CreateEkmConnection</c> and <c>EkmServiceClient.CreateEkmConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEkmConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.UpdateEkmConnection</c> and <c>EkmServiceClient.UpdateEkmConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEkmConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.GetEkmConfig</c> and <c>EkmServiceClient.GetEkmConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEkmConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.UpdateEkmConfig</c> and <c>EkmServiceClient.UpdateEkmConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEkmConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.VerifyConnectivity</c> and <c>EkmServiceClient.VerifyConnectivityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyConnectivitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EkmServiceSettings"/> object.</returns>
        public EkmServiceSettings Clone() => new EkmServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EkmServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EkmServiceClientBuilder : gaxgrpc::ClientBuilderBase<EkmServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EkmServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EkmServiceClientBuilder() : base(EkmServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EkmServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EkmServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EkmServiceClient Build()
        {
            EkmServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EkmServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EkmServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EkmServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EkmServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EkmServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EkmServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EkmServiceClient.ChannelPool;
    }

    /// <summary>EkmService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Key Management EKM Service
    /// 
    /// Manages external cryptographic keys and operations using those keys.
    /// Implements a REST model with the following objects:
    /// * [EkmConnection][google.cloud.kms.v1.EkmConnection]
    /// </remarks>
    public abstract partial class EkmServiceClient
    {
        /// <summary>
        /// The default endpoint for the EkmService service, which is a host of "cloudkms.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudkms.googleapis.com:443";

        /// <summary>The default EkmService scopes.</summary>
        /// <remarks>
        /// The default EkmService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloudkms</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloudkms",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EkmService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EkmServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EkmServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EkmServiceClient"/>.</returns>
        public static stt::Task<EkmServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EkmServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EkmServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="EkmServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EkmServiceClient"/>.</returns>
        public static EkmServiceClient Create() => new EkmServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EkmServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EkmServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EkmServiceClient"/>.</returns>
        internal static EkmServiceClient Create(grpccore::CallInvoker callInvoker, EkmServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EkmService.EkmServiceClient grpcClient = new EkmService.EkmServiceClient(callInvoker);
            return new EkmServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EkmService client</summary>
        public virtual EkmService.EkmServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEkmConnectionsRequest request = new ListEkmConnectionsRequest
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
            return ListEkmConnections(request, callSettings);
        }

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEkmConnectionsRequest request = new ListEkmConnectionsRequest
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
            return ListEkmConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEkmConnectionsRequest request = new ListEkmConnectionsRequest
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
            return ListEkmConnections(request, callSettings);
        }

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEkmConnectionsRequest request = new ListEkmConnectionsRequest
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
            return ListEkmConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection GetEkmConnection(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(GetEkmConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection GetEkmConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnection(new GetEkmConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnectionAsync(new GetEkmConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetEkmConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection GetEkmConnection(EkmConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnection(new GetEkmConnectionRequest
            {
                EkmConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(EkmConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnectionAsync(new GetEkmConnectionRequest
            {
                EkmConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(EkmConnectionName name, st::CancellationToken cancellationToken) =>
            GetEkmConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection CreateEkmConnection(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(CreateEkmConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection CreateEkmConnection(string parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnection(new CreateEkmConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(string parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnectionAsync(new CreateEkmConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(string parent, string ekmConnectionId, EkmConnection ekmConnection, st::CancellationToken cancellationToken) =>
            CreateEkmConnectionAsync(parent, ekmConnectionId, ekmConnection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection CreateEkmConnection(gagr::LocationName parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnection(new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(gagr::LocationName parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnectionAsync(new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(gagr::LocationName parent, string ekmConnectionId, EkmConnection ekmConnection, st::CancellationToken cancellationToken) =>
            CreateEkmConnectionAsync(parent, ekmConnectionId, ekmConnection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection UpdateEkmConnection(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(UpdateEkmConnectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="ekmConnection">
        /// Required. [EkmConnection][google.cloud.kms.v1.EkmConnection] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection UpdateEkmConnection(EkmConnection ekmConnection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEkmConnection(new UpdateEkmConnectionRequest
            {
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="ekmConnection">
        /// Required. [EkmConnection][google.cloud.kms.v1.EkmConnection] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(EkmConnection ekmConnection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEkmConnectionAsync(new UpdateEkmConnectionRequest
            {
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="ekmConnection">
        /// Required. [EkmConnection][google.cloud.kms.v1.EkmConnection] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(EkmConnection ekmConnection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEkmConnectionAsync(ekmConnection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConfig GetEkmConfig(GetEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> GetEkmConfigAsync(GetEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> GetEkmConfigAsync(GetEkmConfigRequest request, st::CancellationToken cancellationToken) =>
            GetEkmConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConfig.name] of the
        /// [EkmConfig][google.cloud.kms.v1.EkmConfig] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConfig GetEkmConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConfig(new GetEkmConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConfig.name] of the
        /// [EkmConfig][google.cloud.kms.v1.EkmConfig] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> GetEkmConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConfigAsync(new GetEkmConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConfig.name] of the
        /// [EkmConfig][google.cloud.kms.v1.EkmConfig] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> GetEkmConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetEkmConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConfig.name] of the
        /// [EkmConfig][google.cloud.kms.v1.EkmConfig] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConfig GetEkmConfig(EkmConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConfig(new GetEkmConfigRequest
            {
                EkmConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConfig.name] of the
        /// [EkmConfig][google.cloud.kms.v1.EkmConfig] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> GetEkmConfigAsync(EkmConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConfigAsync(new GetEkmConfigRequest
            {
                EkmConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConfig.name] of the
        /// [EkmConfig][google.cloud.kms.v1.EkmConfig] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> GetEkmConfigAsync(EkmConfigName name, st::CancellationToken cancellationToken) =>
            GetEkmConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConfig UpdateEkmConfig(UpdateEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> UpdateEkmConfigAsync(UpdateEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> UpdateEkmConfigAsync(UpdateEkmConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateEkmConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="ekmConfig">
        /// Required. [EkmConfig][google.cloud.kms.v1.EkmConfig] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConfig UpdateEkmConfig(EkmConfig ekmConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEkmConfig(new UpdateEkmConfigRequest
            {
                EkmConfig = gax::GaxPreconditions.CheckNotNull(ekmConfig, nameof(ekmConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="ekmConfig">
        /// Required. [EkmConfig][google.cloud.kms.v1.EkmConfig] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> UpdateEkmConfigAsync(EkmConfig ekmConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEkmConfigAsync(new UpdateEkmConfigRequest
            {
                EkmConfig = gax::GaxPreconditions.CheckNotNull(ekmConfig, nameof(ekmConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="ekmConfig">
        /// Required. [EkmConfig][google.cloud.kms.v1.EkmConfig] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConfig> UpdateEkmConfigAsync(EkmConfig ekmConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEkmConfigAsync(ekmConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VerifyConnectivityResponse VerifyConnectivity(VerifyConnectivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyConnectivityResponse> VerifyConnectivityAsync(VerifyConnectivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyConnectivityResponse> VerifyConnectivityAsync(VerifyConnectivityRequest request, st::CancellationToken cancellationToken) =>
            VerifyConnectivityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to verify.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VerifyConnectivityResponse VerifyConnectivity(string name, gaxgrpc::CallSettings callSettings = null) =>
            VerifyConnectivity(new VerifyConnectivityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to verify.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyConnectivityResponse> VerifyConnectivityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            VerifyConnectivityAsync(new VerifyConnectivityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to verify.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyConnectivityResponse> VerifyConnectivityAsync(string name, st::CancellationToken cancellationToken) =>
            VerifyConnectivityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to verify.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VerifyConnectivityResponse VerifyConnectivity(EkmConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            VerifyConnectivity(new VerifyConnectivityRequest
            {
                EkmConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to verify.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyConnectivityResponse> VerifyConnectivityAsync(EkmConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            VerifyConnectivityAsync(new VerifyConnectivityRequest
            {
                EkmConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to verify.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyConnectivityResponse> VerifyConnectivityAsync(EkmConnectionName name, st::CancellationToken cancellationToken) =>
            VerifyConnectivityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EkmService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Key Management EKM Service
    /// 
    /// Manages external cryptographic keys and operations using those keys.
    /// Implements a REST model with the following objects:
    /// * [EkmConnection][google.cloud.kms.v1.EkmConnection]
    /// </remarks>
    public sealed partial class EkmServiceClientImpl : EkmServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListEkmConnectionsRequest, ListEkmConnectionsResponse> _callListEkmConnections;

        private readonly gaxgrpc::ApiCall<GetEkmConnectionRequest, EkmConnection> _callGetEkmConnection;

        private readonly gaxgrpc::ApiCall<CreateEkmConnectionRequest, EkmConnection> _callCreateEkmConnection;

        private readonly gaxgrpc::ApiCall<UpdateEkmConnectionRequest, EkmConnection> _callUpdateEkmConnection;

        private readonly gaxgrpc::ApiCall<GetEkmConfigRequest, EkmConfig> _callGetEkmConfig;

        private readonly gaxgrpc::ApiCall<UpdateEkmConfigRequest, EkmConfig> _callUpdateEkmConfig;

        private readonly gaxgrpc::ApiCall<VerifyConnectivityRequest, VerifyConnectivityResponse> _callVerifyConnectivity;

        /// <summary>
        /// Constructs a client wrapper for the EkmService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EkmServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EkmServiceClientImpl(EkmService.EkmServiceClient grpcClient, EkmServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EkmServiceSettings effectiveSettings = settings ?? EkmServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListEkmConnections = clientHelper.BuildApiCall<ListEkmConnectionsRequest, ListEkmConnectionsResponse>("ListEkmConnections", grpcClient.ListEkmConnectionsAsync, grpcClient.ListEkmConnections, effectiveSettings.ListEkmConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEkmConnections);
            Modify_ListEkmConnectionsApiCall(ref _callListEkmConnections);
            _callGetEkmConnection = clientHelper.BuildApiCall<GetEkmConnectionRequest, EkmConnection>("GetEkmConnection", grpcClient.GetEkmConnectionAsync, grpcClient.GetEkmConnection, effectiveSettings.GetEkmConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEkmConnection);
            Modify_GetEkmConnectionApiCall(ref _callGetEkmConnection);
            _callCreateEkmConnection = clientHelper.BuildApiCall<CreateEkmConnectionRequest, EkmConnection>("CreateEkmConnection", grpcClient.CreateEkmConnectionAsync, grpcClient.CreateEkmConnection, effectiveSettings.CreateEkmConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEkmConnection);
            Modify_CreateEkmConnectionApiCall(ref _callCreateEkmConnection);
            _callUpdateEkmConnection = clientHelper.BuildApiCall<UpdateEkmConnectionRequest, EkmConnection>("UpdateEkmConnection", grpcClient.UpdateEkmConnectionAsync, grpcClient.UpdateEkmConnection, effectiveSettings.UpdateEkmConnectionSettings).WithGoogleRequestParam("ekm_connection.name", request => request.EkmConnection?.Name);
            Modify_ApiCall(ref _callUpdateEkmConnection);
            Modify_UpdateEkmConnectionApiCall(ref _callUpdateEkmConnection);
            _callGetEkmConfig = clientHelper.BuildApiCall<GetEkmConfigRequest, EkmConfig>("GetEkmConfig", grpcClient.GetEkmConfigAsync, grpcClient.GetEkmConfig, effectiveSettings.GetEkmConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEkmConfig);
            Modify_GetEkmConfigApiCall(ref _callGetEkmConfig);
            _callUpdateEkmConfig = clientHelper.BuildApiCall<UpdateEkmConfigRequest, EkmConfig>("UpdateEkmConfig", grpcClient.UpdateEkmConfigAsync, grpcClient.UpdateEkmConfig, effectiveSettings.UpdateEkmConfigSettings).WithGoogleRequestParam("ekm_config.name", request => request.EkmConfig?.Name);
            Modify_ApiCall(ref _callUpdateEkmConfig);
            Modify_UpdateEkmConfigApiCall(ref _callUpdateEkmConfig);
            _callVerifyConnectivity = clientHelper.BuildApiCall<VerifyConnectivityRequest, VerifyConnectivityResponse>("VerifyConnectivity", grpcClient.VerifyConnectivityAsync, grpcClient.VerifyConnectivity, effectiveSettings.VerifyConnectivitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callVerifyConnectivity);
            Modify_VerifyConnectivityApiCall(ref _callVerifyConnectivity);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEkmConnectionsApiCall(ref gaxgrpc::ApiCall<ListEkmConnectionsRequest, ListEkmConnectionsResponse> call);

        partial void Modify_GetEkmConnectionApiCall(ref gaxgrpc::ApiCall<GetEkmConnectionRequest, EkmConnection> call);

        partial void Modify_CreateEkmConnectionApiCall(ref gaxgrpc::ApiCall<CreateEkmConnectionRequest, EkmConnection> call);

        partial void Modify_UpdateEkmConnectionApiCall(ref gaxgrpc::ApiCall<UpdateEkmConnectionRequest, EkmConnection> call);

        partial void Modify_GetEkmConfigApiCall(ref gaxgrpc::ApiCall<GetEkmConfigRequest, EkmConfig> call);

        partial void Modify_UpdateEkmConfigApiCall(ref gaxgrpc::ApiCall<UpdateEkmConfigRequest, EkmConfig> call);

        partial void Modify_VerifyConnectivityApiCall(ref gaxgrpc::ApiCall<VerifyConnectivityRequest, VerifyConnectivityResponse> call);

        partial void OnConstruction(EkmService.EkmServiceClient grpcClient, EkmServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EkmService client</summary>
        public override EkmService.EkmServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListEkmConnectionsRequest(ref ListEkmConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEkmConnectionRequest(ref GetEkmConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEkmConnectionRequest(ref CreateEkmConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEkmConnectionRequest(ref UpdateEkmConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEkmConfigRequest(ref GetEkmConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEkmConfigRequest(ref UpdateEkmConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_VerifyConnectivityRequest(ref VerifyConnectivityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public override gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEkmConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEkmConnectionsRequest, ListEkmConnectionsResponse, EkmConnection>(_callListEkmConnections, request, callSettings);
        }

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEkmConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEkmConnectionsRequest, ListEkmConnectionsResponse, EkmConnection>(_callListEkmConnections, request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConnection GetEkmConnection(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConnectionRequest(ref request, ref callSettings);
            return _callGetEkmConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConnection> GetEkmConnectionAsync(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConnectionRequest(ref request, ref callSettings);
            return _callGetEkmConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConnection CreateEkmConnection(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEkmConnectionRequest(ref request, ref callSettings);
            return _callCreateEkmConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConnection> CreateEkmConnectionAsync(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEkmConnectionRequest(ref request, ref callSettings);
            return _callCreateEkmConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConnection UpdateEkmConnection(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEkmConnectionRequest(ref request, ref callSettings);
            return _callUpdateEkmConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConnection> UpdateEkmConnectionAsync(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEkmConnectionRequest(ref request, ref callSettings);
            return _callUpdateEkmConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConfig GetEkmConfig(GetEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConfigRequest(ref request, ref callSettings);
            return _callGetEkmConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConfig> GetEkmConfigAsync(GetEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConfigRequest(ref request, ref callSettings);
            return _callGetEkmConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConfig UpdateEkmConfig(UpdateEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEkmConfigRequest(ref request, ref callSettings);
            return _callUpdateEkmConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the [EkmConfig][google.cloud.kms.v1.EkmConfig] singleton resource
        /// for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConfig> UpdateEkmConfigAsync(UpdateEkmConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEkmConfigRequest(ref request, ref callSettings);
            return _callUpdateEkmConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VerifyConnectivityResponse VerifyConnectivity(VerifyConnectivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyConnectivityRequest(ref request, ref callSettings);
            return _callVerifyConnectivity.Sync(request, callSettings);
        }

        /// <summary>
        /// Verifies that Cloud KMS can successfully connect to the external key
        /// manager specified by an [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// If there is an error connecting to the EKM, this method returns a
        /// FAILED_PRECONDITION status containing structured information as described
        /// at https://cloud.google.com/kms/docs/reference/ekm_errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VerifyConnectivityResponse> VerifyConnectivityAsync(VerifyConnectivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyConnectivityRequest(ref request, ref callSettings);
            return _callVerifyConnectivity.Async(request, callSettings);
        }
    }

    public partial class ListEkmConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEkmConnectionsResponse : gaxgrpc::IPageResponse<EkmConnection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EkmConnection> GetEnumerator() => EkmConnections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class EkmService
    {
        public partial class EkmServiceClient
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
