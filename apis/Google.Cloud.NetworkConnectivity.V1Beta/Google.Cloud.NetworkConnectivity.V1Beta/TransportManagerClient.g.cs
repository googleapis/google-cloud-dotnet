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

namespace Google.Cloud.NetworkConnectivity.V1Beta
{
    /// <summary>Settings for <see cref="TransportManagerClient"/> instances.</summary>
    public sealed partial class TransportManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TransportManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TransportManagerSettings"/>.</returns>
        public static TransportManagerSettings GetDefault() => new TransportManagerSettings();

        /// <summary>Constructs a new <see cref="TransportManagerSettings"/> object with default settings.</summary>
        public TransportManagerSettings()
        {
        }

        private TransportManagerSettings(TransportManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListRemoteTransportProfilesSettings = existing.ListRemoteTransportProfilesSettings;
            GetRemoteTransportProfileSettings = existing.GetRemoteTransportProfileSettings;
            ListTransportsSettings = existing.ListTransportsSettings;
            GetTransportSettings = existing.GetTransportSettings;
            GetStatusSettings = existing.GetStatusSettings;
            CreateTransportSettings = existing.CreateTransportSettings;
            CreateTransportOperationsSettings = existing.CreateTransportOperationsSettings.Clone();
            UpdateTransportSettings = existing.UpdateTransportSettings;
            UpdateTransportOperationsSettings = existing.UpdateTransportOperationsSettings.Clone();
            DeleteTransportSettings = existing.DeleteTransportSettings;
            DeleteTransportOperationsSettings = existing.DeleteTransportOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(TransportManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.ListRemoteTransportProfiles</c> and
        /// <c>TransportManagerClient.ListRemoteTransportProfilesAsync</c>.
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
        public gaxgrpc::CallSettings ListRemoteTransportProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.GetRemoteTransportProfile</c> and
        /// <c>TransportManagerClient.GetRemoteTransportProfileAsync</c>.
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
        public gaxgrpc::CallSettings GetRemoteTransportProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.ListTransports</c> and <c>TransportManagerClient.ListTransportsAsync</c>.
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
        public gaxgrpc::CallSettings ListTransportsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.GetTransport</c> and <c>TransportManagerClient.GetTransportAsync</c>.
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
        public gaxgrpc::CallSettings GetTransportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.GetStatus</c> and <c>TransportManagerClient.GetStatusAsync</c>.
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
        public gaxgrpc::CallSettings GetStatusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.CreateTransport</c> and <c>TransportManagerClient.CreateTransportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTransportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TransportManagerClient.CreateTransport</c> and
        /// <c>TransportManagerClient.CreateTransportAsync</c>.
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
        public lro::OperationsSettings CreateTransportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.UpdateTransport</c> and <c>TransportManagerClient.UpdateTransportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTransportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TransportManagerClient.UpdateTransport</c> and
        /// <c>TransportManagerClient.UpdateTransportAsync</c>.
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
        public lro::OperationsSettings UpdateTransportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransportManagerClient.DeleteTransport</c> and <c>TransportManagerClient.DeleteTransportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTransportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TransportManagerClient.DeleteTransport</c> and
        /// <c>TransportManagerClient.DeleteTransportAsync</c>.
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
        public lro::OperationsSettings DeleteTransportOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="TransportManagerSettings"/> object.</returns>
        public TransportManagerSettings Clone() => new TransportManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TransportManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TransportManagerClientBuilder : gaxgrpc::ClientBuilderBase<TransportManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TransportManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TransportManagerClientBuilder() : base(TransportManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TransportManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TransportManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TransportManagerClient Build()
        {
            TransportManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TransportManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TransportManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TransportManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TransportManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TransportManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TransportManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TransportManagerClient.ChannelPool;
    }

    /// <summary>TransportManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The CLH based service for managing RemoteTransportProfiles and Transports.
    /// </remarks>
    public abstract partial class TransportManagerClient
    {
        /// <summary>
        /// The default endpoint for the TransportManager service, which is a host of
        /// "networkconnectivity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkconnectivity.googleapis.com:443";

        /// <summary>The default TransportManager scopes.</summary>
        /// <remarks>
        /// The default TransportManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TransportManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TransportManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TransportManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TransportManagerClient"/>.</returns>
        public static stt::Task<TransportManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TransportManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TransportManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TransportManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TransportManagerClient"/>.</returns>
        public static TransportManagerClient Create() => new TransportManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TransportManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TransportManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TransportManagerClient"/>.</returns>
        internal static TransportManagerClient Create(grpccore::CallInvoker callInvoker, TransportManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TransportManager.TransportManagerClient grpcClient = new TransportManager.TransportManagerClient(callInvoker);
            return new TransportManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TransportManager client</summary>
        public virtual TransportManager.TransportManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfiles(ListRemoteTransportProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfilesAsync(ListRemoteTransportProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRemoteTransportProfilesRequest.
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
        /// <returns>A pageable sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRemoteTransportProfilesRequest request = new ListRemoteTransportProfilesRequest
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
            return ListRemoteTransportProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRemoteTransportProfilesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRemoteTransportProfilesRequest request = new ListRemoteTransportProfilesRequest
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
            return ListRemoteTransportProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRemoteTransportProfilesRequest.
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
        /// <returns>A pageable sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRemoteTransportProfilesRequest request = new ListRemoteTransportProfilesRequest
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
            return ListRemoteTransportProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRemoteTransportProfilesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRemoteTransportProfilesRequest request = new ListRemoteTransportProfilesRequest
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
            return ListRemoteTransportProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoteTransportProfile GetRemoteTransportProfile(GetRemoteTransportProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoteTransportProfile> GetRemoteTransportProfileAsync(GetRemoteTransportProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoteTransportProfile> GetRemoteTransportProfileAsync(GetRemoteTransportProfileRequest request, st::CancellationToken cancellationToken) =>
            GetRemoteTransportProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoteTransportProfile GetRemoteTransportProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRemoteTransportProfile(new GetRemoteTransportProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoteTransportProfile> GetRemoteTransportProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRemoteTransportProfileAsync(new GetRemoteTransportProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoteTransportProfile> GetRemoteTransportProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetRemoteTransportProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoteTransportProfile GetRemoteTransportProfile(RemoteTransportProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRemoteTransportProfile(new GetRemoteTransportProfileRequest
            {
                RemoteTransportProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoteTransportProfile> GetRemoteTransportProfileAsync(RemoteTransportProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRemoteTransportProfileAsync(new GetRemoteTransportProfileRequest
            {
                RemoteTransportProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoteTransportProfile> GetRemoteTransportProfileAsync(RemoteTransportProfileName name, st::CancellationToken cancellationToken) =>
            GetRemoteTransportProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Transport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransportsResponse, Transport> ListTransports(ListTransportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Transport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransportsResponse, Transport> ListTransportsAsync(ListTransportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTransportsRequest.
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
        /// <returns>A pageable sequence of <see cref="Transport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransportsResponse, Transport> ListTransports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransportsRequest request = new ListTransportsRequest
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
            return ListTransports(request, callSettings);
        }

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTransportsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Transport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransportsResponse, Transport> ListTransportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransportsRequest request = new ListTransportsRequest
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
            return ListTransportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTransportsRequest.
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
        /// <returns>A pageable sequence of <see cref="Transport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransportsResponse, Transport> ListTransports(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransportsRequest request = new ListTransportsRequest
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
            return ListTransports(request, callSettings);
        }

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTransportsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Transport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransportsResponse, Transport> ListTransportsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransportsRequest request = new ListTransportsRequest
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
            return ListTransportsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transport GetTransport(GetTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transport> GetTransportAsync(GetTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transport> GetTransportAsync(GetTransportRequest request, st::CancellationToken cancellationToken) =>
            GetTransportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transport GetTransport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransport(new GetTransportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transport> GetTransportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransportAsync(new GetTransportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transport> GetTransportAsync(string name, st::CancellationToken cancellationToken) =>
            GetTransportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transport GetTransport(TransportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransport(new GetTransportRequest
            {
                TransportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transport> GetTransportAsync(TransportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransportAsync(new GetTransportRequest
            {
                TransportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transport> GetTransportAsync(TransportName name, st::CancellationToken cancellationToken) =>
            GetTransportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetStatusResponse GetStatus(GetStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request, st::CancellationToken cancellationToken) =>
            GetStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetStatusResponse GetStatus(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStatus(new GetStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetStatusResponse> GetStatusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStatusAsync(new GetStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetStatusResponse> GetStatusAsync(string name, st::CancellationToken cancellationToken) =>
            GetStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetStatusResponse GetStatus(TransportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStatus(new GetStatusRequest
            {
                TransportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetStatusResponse> GetStatusAsync(TransportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStatusAsync(new GetStatusRequest
            {
                TransportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetStatusResponse> GetStatusAsync(TransportName name, st::CancellationToken cancellationToken) =>
            GetStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Transport, OperationMetadata> CreateTransport(CreateTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> CreateTransportAsync(CreateTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> CreateTransportAsync(CreateTransportRequest request, st::CancellationToken cancellationToken) =>
            CreateTransportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTransport</c>.</summary>
        public virtual lro::OperationsClient CreateTransportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTransport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Transport, OperationMetadata> PollOnceCreateTransport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Transport, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTransportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTransport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> PollOnceCreateTransportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Transport, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTransportOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="transport">
        /// Required. The resource being created
        /// </param>
        /// <param name="transportId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Transport, OperationMetadata> CreateTransport(string parent, Transport transport, string transportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransport(new CreateTransportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TransportId = gax::GaxPreconditions.CheckNotNullOrEmpty(transportId, nameof(transportId)),
                Transport = gax::GaxPreconditions.CheckNotNull(transport, nameof(transport)),
            }, callSettings);

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="transport">
        /// Required. The resource being created
        /// </param>
        /// <param name="transportId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> CreateTransportAsync(string parent, Transport transport, string transportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransportAsync(new CreateTransportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TransportId = gax::GaxPreconditions.CheckNotNullOrEmpty(transportId, nameof(transportId)),
                Transport = gax::GaxPreconditions.CheckNotNull(transport, nameof(transport)),
            }, callSettings);

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="transport">
        /// Required. The resource being created
        /// </param>
        /// <param name="transportId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> CreateTransportAsync(string parent, Transport transport, string transportId, st::CancellationToken cancellationToken) =>
            CreateTransportAsync(parent, transport, transportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="transport">
        /// Required. The resource being created
        /// </param>
        /// <param name="transportId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Transport, OperationMetadata> CreateTransport(gagr::LocationName parent, Transport transport, string transportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransport(new CreateTransportRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransportId = gax::GaxPreconditions.CheckNotNullOrEmpty(transportId, nameof(transportId)),
                Transport = gax::GaxPreconditions.CheckNotNull(transport, nameof(transport)),
            }, callSettings);

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="transport">
        /// Required. The resource being created
        /// </param>
        /// <param name="transportId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> CreateTransportAsync(gagr::LocationName parent, Transport transport, string transportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransportAsync(new CreateTransportRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransportId = gax::GaxPreconditions.CheckNotNullOrEmpty(transportId, nameof(transportId)),
                Transport = gax::GaxPreconditions.CheckNotNull(transport, nameof(transport)),
            }, callSettings);

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="transport">
        /// Required. The resource being created
        /// </param>
        /// <param name="transportId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> CreateTransportAsync(gagr::LocationName parent, Transport transport, string transportId, st::CancellationToken cancellationToken) =>
            CreateTransportAsync(parent, transport, transportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Transport, OperationMetadata> UpdateTransport(UpdateTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> UpdateTransportAsync(UpdateTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> UpdateTransportAsync(UpdateTransportRequest request, st::CancellationToken cancellationToken) =>
            UpdateTransportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTransport</c>.</summary>
        public virtual lro::OperationsClient UpdateTransportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTransport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Transport, OperationMetadata> PollOnceUpdateTransport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Transport, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTransportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTransport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> PollOnceUpdateTransportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Transport, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTransportOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="transport">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Transport resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Transport, OperationMetadata> UpdateTransport(Transport transport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTransport(new UpdateTransportRequest
            {
                UpdateMask = updateMask,
                Transport = gax::GaxPreconditions.CheckNotNull(transport, nameof(transport)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="transport">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Transport resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> UpdateTransportAsync(Transport transport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTransportAsync(new UpdateTransportRequest
            {
                UpdateMask = updateMask,
                Transport = gax::GaxPreconditions.CheckNotNull(transport, nameof(transport)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="transport">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Transport resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Transport, OperationMetadata>> UpdateTransportAsync(Transport transport, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTransportAsync(transport, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTransport(DeleteTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTransportAsync(DeleteTransportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTransportAsync(DeleteTransportRequest request, st::CancellationToken cancellationToken) =>
            DeleteTransportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTransport</c>.</summary>
        public virtual lro::OperationsClient DeleteTransportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTransport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTransport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTransportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTransport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTransportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTransportOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTransport(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransport(new DeleteTransportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTransportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransportAsync(new DeleteTransportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTransportAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTransportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTransport(TransportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransport(new DeleteTransportRequest
            {
                TransportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTransportAsync(TransportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransportAsync(new DeleteTransportRequest
            {
                TransportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTransportAsync(TransportName name, st::CancellationToken cancellationToken) =>
            DeleteTransportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TransportManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The CLH based service for managing RemoteTransportProfiles and Transports.
    /// </remarks>
    public sealed partial class TransportManagerClientImpl : TransportManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListRemoteTransportProfilesRequest, ListRemoteTransportProfilesResponse> _callListRemoteTransportProfiles;

        private readonly gaxgrpc::ApiCall<GetRemoteTransportProfileRequest, RemoteTransportProfile> _callGetRemoteTransportProfile;

        private readonly gaxgrpc::ApiCall<ListTransportsRequest, ListTransportsResponse> _callListTransports;

        private readonly gaxgrpc::ApiCall<GetTransportRequest, Transport> _callGetTransport;

        private readonly gaxgrpc::ApiCall<GetStatusRequest, GetStatusResponse> _callGetStatus;

        private readonly gaxgrpc::ApiCall<CreateTransportRequest, lro::Operation> _callCreateTransport;

        private readonly gaxgrpc::ApiCall<UpdateTransportRequest, lro::Operation> _callUpdateTransport;

        private readonly gaxgrpc::ApiCall<DeleteTransportRequest, lro::Operation> _callDeleteTransport;

        /// <summary>
        /// Constructs a client wrapper for the TransportManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TransportManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TransportManagerClientImpl(TransportManager.TransportManagerClient grpcClient, TransportManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TransportManagerSettings effectiveSettings = settings ?? TransportManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTransportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTransportOperationsSettings, logger);
            UpdateTransportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTransportOperationsSettings, logger);
            DeleteTransportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTransportOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListRemoteTransportProfiles = clientHelper.BuildApiCall<ListRemoteTransportProfilesRequest, ListRemoteTransportProfilesResponse>("ListRemoteTransportProfiles", grpcClient.ListRemoteTransportProfilesAsync, grpcClient.ListRemoteTransportProfiles, effectiveSettings.ListRemoteTransportProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRemoteTransportProfiles);
            Modify_ListRemoteTransportProfilesApiCall(ref _callListRemoteTransportProfiles);
            _callGetRemoteTransportProfile = clientHelper.BuildApiCall<GetRemoteTransportProfileRequest, RemoteTransportProfile>("GetRemoteTransportProfile", grpcClient.GetRemoteTransportProfileAsync, grpcClient.GetRemoteTransportProfile, effectiveSettings.GetRemoteTransportProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRemoteTransportProfile);
            Modify_GetRemoteTransportProfileApiCall(ref _callGetRemoteTransportProfile);
            _callListTransports = clientHelper.BuildApiCall<ListTransportsRequest, ListTransportsResponse>("ListTransports", grpcClient.ListTransportsAsync, grpcClient.ListTransports, effectiveSettings.ListTransportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransports);
            Modify_ListTransportsApiCall(ref _callListTransports);
            _callGetTransport = clientHelper.BuildApiCall<GetTransportRequest, Transport>("GetTransport", grpcClient.GetTransportAsync, grpcClient.GetTransport, effectiveSettings.GetTransportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTransport);
            Modify_GetTransportApiCall(ref _callGetTransport);
            _callGetStatus = clientHelper.BuildApiCall<GetStatusRequest, GetStatusResponse>("GetStatus", grpcClient.GetStatusAsync, grpcClient.GetStatus, effectiveSettings.GetStatusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStatus);
            Modify_GetStatusApiCall(ref _callGetStatus);
            _callCreateTransport = clientHelper.BuildApiCall<CreateTransportRequest, lro::Operation>("CreateTransport", grpcClient.CreateTransportAsync, grpcClient.CreateTransport, effectiveSettings.CreateTransportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTransport);
            Modify_CreateTransportApiCall(ref _callCreateTransport);
            _callUpdateTransport = clientHelper.BuildApiCall<UpdateTransportRequest, lro::Operation>("UpdateTransport", grpcClient.UpdateTransportAsync, grpcClient.UpdateTransport, effectiveSettings.UpdateTransportSettings).WithGoogleRequestParam("transport.name", request => request.Transport?.Name);
            Modify_ApiCall(ref _callUpdateTransport);
            Modify_UpdateTransportApiCall(ref _callUpdateTransport);
            _callDeleteTransport = clientHelper.BuildApiCall<DeleteTransportRequest, lro::Operation>("DeleteTransport", grpcClient.DeleteTransportAsync, grpcClient.DeleteTransport, effectiveSettings.DeleteTransportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTransport);
            Modify_DeleteTransportApiCall(ref _callDeleteTransport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListRemoteTransportProfilesApiCall(ref gaxgrpc::ApiCall<ListRemoteTransportProfilesRequest, ListRemoteTransportProfilesResponse> call);

        partial void Modify_GetRemoteTransportProfileApiCall(ref gaxgrpc::ApiCall<GetRemoteTransportProfileRequest, RemoteTransportProfile> call);

        partial void Modify_ListTransportsApiCall(ref gaxgrpc::ApiCall<ListTransportsRequest, ListTransportsResponse> call);

        partial void Modify_GetTransportApiCall(ref gaxgrpc::ApiCall<GetTransportRequest, Transport> call);

        partial void Modify_GetStatusApiCall(ref gaxgrpc::ApiCall<GetStatusRequest, GetStatusResponse> call);

        partial void Modify_CreateTransportApiCall(ref gaxgrpc::ApiCall<CreateTransportRequest, lro::Operation> call);

        partial void Modify_UpdateTransportApiCall(ref gaxgrpc::ApiCall<UpdateTransportRequest, lro::Operation> call);

        partial void Modify_DeleteTransportApiCall(ref gaxgrpc::ApiCall<DeleteTransportRequest, lro::Operation> call);

        partial void OnConstruction(TransportManager.TransportManagerClient grpcClient, TransportManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TransportManager client</summary>
        public override TransportManager.TransportManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListRemoteTransportProfilesRequest(ref ListRemoteTransportProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRemoteTransportProfileRequest(ref GetRemoteTransportProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTransportsRequest(ref ListTransportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTransportRequest(ref GetTransportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStatusRequest(ref GetStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTransportRequest(ref CreateTransportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTransportRequest(ref UpdateTransportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTransportRequest(ref DeleteTransportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfiles(ListRemoteTransportProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRemoteTransportProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRemoteTransportProfilesRequest, ListRemoteTransportProfilesResponse, RemoteTransportProfile>(_callListRemoteTransportProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists RemoteTransportProfiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RemoteTransportProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> ListRemoteTransportProfilesAsync(ListRemoteTransportProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRemoteTransportProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRemoteTransportProfilesRequest, ListRemoteTransportProfilesResponse, RemoteTransportProfile>(_callListRemoteTransportProfiles, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoteTransportProfile GetRemoteTransportProfile(GetRemoteTransportProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRemoteTransportProfileRequest(ref request, ref callSettings);
            return _callGetRemoteTransportProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single RemoteTransportProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoteTransportProfile> GetRemoteTransportProfileAsync(GetRemoteTransportProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRemoteTransportProfileRequest(ref request, ref callSettings);
            return _callGetRemoteTransportProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Transport"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransportsResponse, Transport> ListTransports(ListTransportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransportsRequest, ListTransportsResponse, Transport>(_callListTransports, request, callSettings);
        }

        /// <summary>
        /// Lists Transports in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Transport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransportsResponse, Transport> ListTransportsAsync(ListTransportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransportsRequest, ListTransportsResponse, Transport>(_callListTransports, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Transport GetTransport(GetTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransportRequest(ref request, ref callSettings);
            return _callGetTransport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Transport> GetTransportAsync(GetTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransportRequest(ref request, ref callSettings);
            return _callGetTransport.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetStatusResponse GetStatus(GetStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStatusRequest(ref request, ref callSettings);
            return _callGetStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the operational status of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStatusRequest(ref request, ref callSettings);
            return _callGetStatus.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTransport</c>.</summary>
        public override lro::OperationsClient CreateTransportOperationsClient { get; }

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Transport, OperationMetadata> CreateTransport(CreateTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransportRequest(ref request, ref callSettings);
            return new lro::Operation<Transport, OperationMetadata>(_callCreateTransport.Sync(request, callSettings), CreateTransportOperationsClient);
        }

        /// <summary>
        /// Creates a new Transport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Transport, OperationMetadata>> CreateTransportAsync(CreateTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransportRequest(ref request, ref callSettings);
            return new lro::Operation<Transport, OperationMetadata>(await _callCreateTransport.Async(request, callSettings).ConfigureAwait(false), CreateTransportOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTransport</c>.</summary>
        public override lro::OperationsClient UpdateTransportOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Transport, OperationMetadata> UpdateTransport(UpdateTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransportRequest(ref request, ref callSettings);
            return new lro::Operation<Transport, OperationMetadata>(_callUpdateTransport.Sync(request, callSettings), UpdateTransportOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Transport, OperationMetadata>> UpdateTransportAsync(UpdateTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransportRequest(ref request, ref callSettings);
            return new lro::Operation<Transport, OperationMetadata>(await _callUpdateTransport.Async(request, callSettings).ConfigureAwait(false), UpdateTransportOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTransport</c>.</summary>
        public override lro::OperationsClient DeleteTransportOperationsClient { get; }

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTransport(DeleteTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransportRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTransport.Sync(request, callSettings), DeleteTransportOperationsClient);
        }

        /// <summary>
        /// Deletes a single Transport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTransportAsync(DeleteTransportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransportRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTransport.Async(request, callSettings).ConfigureAwait(false), DeleteTransportOperationsClient);
        }
    }

    public partial class ListRemoteTransportProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRemoteTransportProfilesResponse : gaxgrpc::IPageResponse<RemoteTransportProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RemoteTransportProfile> GetEnumerator() => RemoteTransportProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransportsResponse : gaxgrpc::IPageResponse<Transport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Transport> GetEnumerator() => Transports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TransportManager
    {
        public partial class TransportManagerClient
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

    public static partial class TransportManager
    {
        public partial class TransportManagerClient
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
