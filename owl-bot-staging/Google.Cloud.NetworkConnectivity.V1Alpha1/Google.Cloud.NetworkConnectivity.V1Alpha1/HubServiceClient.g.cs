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

namespace Google.Cloud.NetworkConnectivity.V1Alpha1
{
    /// <summary>Settings for <see cref="HubServiceClient"/> instances.</summary>
    public sealed partial class HubServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HubServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HubServiceSettings"/>.</returns>
        public static HubServiceSettings GetDefault() => new HubServiceSettings();

        /// <summary>Constructs a new <see cref="HubServiceSettings"/> object with default settings.</summary>
        public HubServiceSettings()
        {
        }

        private HubServiceSettings(HubServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListHubsSettings = existing.ListHubsSettings;
            GetHubSettings = existing.GetHubSettings;
            CreateHubSettings = existing.CreateHubSettings;
            CreateHubOperationsSettings = existing.CreateHubOperationsSettings.Clone();
            UpdateHubSettings = existing.UpdateHubSettings;
            UpdateHubOperationsSettings = existing.UpdateHubOperationsSettings.Clone();
            DeleteHubSettings = existing.DeleteHubSettings;
            DeleteHubOperationsSettings = existing.DeleteHubOperationsSettings.Clone();
            ListSpokesSettings = existing.ListSpokesSettings;
            GetSpokeSettings = existing.GetSpokeSettings;
            CreateSpokeSettings = existing.CreateSpokeSettings;
            CreateSpokeOperationsSettings = existing.CreateSpokeOperationsSettings.Clone();
            UpdateSpokeSettings = existing.UpdateSpokeSettings;
            UpdateSpokeOperationsSettings = existing.UpdateSpokeOperationsSettings.Clone();
            DeleteSpokeSettings = existing.DeleteSpokeSettings;
            DeleteSpokeOperationsSettings = existing.DeleteSpokeOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(HubServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.ListHubs</c>
        ///  and <c>HubServiceClient.ListHubsAsync</c>.
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
        public gaxgrpc::CallSettings ListHubsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.GetHub</c>
        /// and <c>HubServiceClient.GetHubAsync</c>.
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
        public gaxgrpc::CallSettings GetHubSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.CreateHub</c>
        ///  and <c>HubServiceClient.CreateHubAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHubSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.CreateHub</c> and
        /// <c>HubServiceClient.CreateHubAsync</c>.
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
        public lro::OperationsSettings CreateHubOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.UpdateHub</c>
        ///  and <c>HubServiceClient.UpdateHubAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateHubSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.UpdateHub</c> and
        /// <c>HubServiceClient.UpdateHubAsync</c>.
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
        public lro::OperationsSettings UpdateHubOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.DeleteHub</c>
        ///  and <c>HubServiceClient.DeleteHubAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteHubSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.DeleteHub</c> and
        /// <c>HubServiceClient.DeleteHubAsync</c>.
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
        public lro::OperationsSettings DeleteHubOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.ListSpokes</c>
        ///  and <c>HubServiceClient.ListSpokesAsync</c>.
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
        public gaxgrpc::CallSettings ListSpokesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HubServiceClient.GetSpoke</c>
        ///  and <c>HubServiceClient.GetSpokeAsync</c>.
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
        public gaxgrpc::CallSettings GetSpokeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.CreateSpoke</c> and <c>HubServiceClient.CreateSpokeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpokeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.CreateSpoke</c> and
        /// <c>HubServiceClient.CreateSpokeAsync</c>.
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
        public lro::OperationsSettings CreateSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.UpdateSpoke</c> and <c>HubServiceClient.UpdateSpokeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpokeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.UpdateSpoke</c> and
        /// <c>HubServiceClient.UpdateSpokeAsync</c>.
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
        public lro::OperationsSettings UpdateSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HubServiceClient.DeleteSpoke</c> and <c>HubServiceClient.DeleteSpokeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSpokeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HubServiceClient.DeleteSpoke</c> and
        /// <c>HubServiceClient.DeleteSpokeAsync</c>.
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
        public lro::OperationsSettings DeleteSpokeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HubServiceSettings"/> object.</returns>
        public HubServiceSettings Clone() => new HubServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HubServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class HubServiceClientBuilder : gaxgrpc::ClientBuilderBase<HubServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HubServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HubServiceClientBuilder() : base(HubServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HubServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HubServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HubServiceClient Build()
        {
            HubServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HubServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HubServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HubServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HubServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HubServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HubServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HubServiceClient.ChannelPool;
    }

    /// <summary>HubService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Network Connectivity Center is a hub-and-spoke abstraction for
    /// network connectivity management in Google Cloud. It reduces
    /// operational complexity through a simple, centralized connectivity management
    /// model.
    /// </remarks>
    public abstract partial class HubServiceClient
    {
        /// <summary>
        /// The default endpoint for the HubService service, which is a host of "networkconnectivity.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkconnectivity.googleapis.com:443";

        /// <summary>The default HubService scopes.</summary>
        /// <remarks>
        /// The default HubService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(HubService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HubServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HubServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HubServiceClient"/>.</returns>
        public static stt::Task<HubServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HubServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HubServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="HubServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HubServiceClient"/>.</returns>
        public static HubServiceClient Create() => new HubServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HubServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HubServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HubServiceClient"/>.</returns>
        internal static HubServiceClient Create(grpccore::CallInvoker callInvoker, HubServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HubService.HubServiceClient grpcClient = new HubService.HubServiceClient(callInvoker);
            return new HubServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC HubService client</summary>
        public virtual HubService.HubServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubs(request, callSettings);
        }

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubs(request, callSettings);
        }

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHubsRequest request = new ListHubsRequest
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
            return ListHubsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hub GetHub(GetHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(GetHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(GetHubRequest request, st::CancellationToken cancellationToken) =>
            GetHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hub GetHub(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHub(new GetHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHubAsync(new GetHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Hub resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(string name, st::CancellationToken cancellationToken) =>
            GetHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Hub GetHub(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHub(new GetHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Hub resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHubAsync(new GetHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Hub resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Hub> GetHubAsync(HubName name, st::CancellationToken cancellationToken) =>
            GetHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> CreateHub(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(CreateHubRequest request, st::CancellationToken cancellationToken) =>
            CreateHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateHub</c>.</summary>
        public virtual lro::OperationsClient CreateHubOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> PollOnceCreateHub(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHubOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> PollOnceCreateHubAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateHubOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the Hub.
        /// </param>
        /// <param name="hub">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="hubId">
        /// Optional. Unique id for the Hub to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> CreateHub(string parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHub(new CreateHubRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HubId = hubId ?? "",
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the Hub.
        /// </param>
        /// <param name="hub">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="hubId">
        /// Optional. Unique id for the Hub to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(string parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHubAsync(new CreateHubRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HubId = hubId ?? "",
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the Hub.
        /// </param>
        /// <param name="hub">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="hubId">
        /// Optional. Unique id for the Hub to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(string parent, Hub hub, string hubId, st::CancellationToken cancellationToken) =>
            CreateHubAsync(parent, hub, hubId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the Hub.
        /// </param>
        /// <param name="hub">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="hubId">
        /// Optional. Unique id for the Hub to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> CreateHub(gagr::LocationName parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHub(new CreateHubRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HubId = hubId ?? "",
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the Hub.
        /// </param>
        /// <param name="hub">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="hubId">
        /// Optional. Unique id for the Hub to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(gagr::LocationName parent, Hub hub, string hubId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHubAsync(new CreateHubRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HubId = hubId ?? "",
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the Hub.
        /// </param>
        /// <param name="hub">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="hubId">
        /// Optional. Unique id for the Hub to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(gagr::LocationName parent, Hub hub, string hubId, st::CancellationToken cancellationToken) =>
            CreateHubAsync(parent, hub, hubId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> UpdateHub(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(UpdateHubRequest request, st::CancellationToken cancellationToken) =>
            UpdateHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateHub</c>.</summary>
        public virtual lro::OperationsClient UpdateHubOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> PollOnceUpdateHub(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHubOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> PollOnceUpdateHubAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Hub, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateHubOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="hub">
        /// Required. The state that the Hub should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Hub resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Hub, OperationMetadata> UpdateHub(Hub hub, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHub(new UpdateHubRequest
            {
                UpdateMask = updateMask,
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="hub">
        /// Required. The state that the Hub should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Hub resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(Hub hub, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHubAsync(new UpdateHubRequest
            {
                UpdateMask = updateMask,
                Hub = gax::GaxPreconditions.CheckNotNull(hub, nameof(hub)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="hub">
        /// Required. The state that the Hub should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Hub resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(Hub hub, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHubAsync(hub, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(DeleteHubRequest request, st::CancellationToken cancellationToken) =>
            DeleteHubAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteHub</c>.</summary>
        public virtual lro::OperationsClient DeleteHubOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteHub(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHubOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHub</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteHubAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHubOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHub(new DeleteHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHubAsync(new DeleteHubRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Hub to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHub(new DeleteHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Hub to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(HubName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHubAsync(new DeleteHubRequest
            {
                HubName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Hub to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(HubName name, st::CancellationToken cancellationToken) =>
            DeleteHubAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name.
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
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokes(request, callSettings);
        }

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name.
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
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokes(request, callSettings);
        }

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpokesRequest request = new ListSpokesRequest
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
            return ListSpokesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spoke GetSpoke(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(GetSpokeRequest request, st::CancellationToken cancellationToken) =>
            GetSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of Spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spoke GetSpoke(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpoke(new GetSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of Spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpokeAsync(new GetSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of Spoke resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of Spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spoke GetSpoke(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpoke(new GetSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of Spoke resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpokeAsync(new GetSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of Spoke resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spoke> GetSpokeAsync(SpokeName name, st::CancellationToken cancellationToken) =>
            GetSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> CreateSpoke(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(CreateSpokeRequest request, st::CancellationToken cancellationToken) =>
            CreateSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSpoke</c>.</summary>
        public virtual lro::OperationsClient CreateSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> PollOnceCreateSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> PollOnceCreateSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name of the Spoke.
        /// </param>
        /// <param name="spoke">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="spokeId">
        /// Optional. Unique id for the Spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> CreateSpoke(string parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpoke(new CreateSpokeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpokeId = spokeId ?? "",
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name of the Spoke.
        /// </param>
        /// <param name="spoke">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="spokeId">
        /// Optional. Unique id for the Spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(string parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpokeAsync(new CreateSpokeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpokeId = spokeId ?? "",
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name of the Spoke.
        /// </param>
        /// <param name="spoke">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="spokeId">
        /// Optional. Unique id for the Spoke to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(string parent, Spoke spoke, string spokeId, st::CancellationToken cancellationToken) =>
            CreateSpokeAsync(parent, spoke, spokeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name of the Spoke.
        /// </param>
        /// <param name="spoke">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="spokeId">
        /// Optional. Unique id for the Spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> CreateSpoke(gagr::LocationName parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpoke(new CreateSpokeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpokeId = spokeId ?? "",
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name of the Spoke.
        /// </param>
        /// <param name="spoke">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="spokeId">
        /// Optional. Unique id for the Spoke to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(gagr::LocationName parent, Spoke spoke, string spokeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpokeAsync(new CreateSpokeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpokeId = spokeId ?? "",
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent's resource name of the Spoke.
        /// </param>
        /// <param name="spoke">
        /// Required. Initial values for a new Hub.
        /// </param>
        /// <param name="spokeId">
        /// Optional. Unique id for the Spoke to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(gagr::LocationName parent, Spoke spoke, string spokeId, st::CancellationToken cancellationToken) =>
            CreateSpokeAsync(parent, spoke, spokeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> UpdateSpoke(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(UpdateSpokeRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSpoke</c>.</summary>
        public virtual lro::OperationsClient UpdateSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> PollOnceUpdateSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> PollOnceUpdateSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Spoke, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSpokeOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="spoke">
        /// Required. The state that the Spoke should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Spoke resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Spoke, OperationMetadata> UpdateSpoke(Spoke spoke, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpoke(new UpdateSpokeRequest
            {
                UpdateMask = updateMask,
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="spoke">
        /// Required. The state that the Spoke should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Spoke resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(Spoke spoke, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpokeAsync(new UpdateSpokeRequest
            {
                UpdateMask = updateMask,
                Spoke = gax::GaxPreconditions.CheckNotNull(spoke, nameof(spoke)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="spoke">
        /// Required. The state that the Spoke should be in after the update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Spoke resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(Spoke spoke, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpokeAsync(spoke, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(DeleteSpokeRequest request, st::CancellationToken cancellationToken) =>
            DeleteSpokeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSpoke</c>.</summary>
        public virtual lro::OperationsClient DeleteSpokeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSpoke(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSpokeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSpoke</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSpokeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSpokeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpoke(new DeleteSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpokeAsync(new DeleteSpokeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Spoke to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpoke(new DeleteSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Spoke to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(SpokeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpokeAsync(new DeleteSpokeRequest
            {
                SpokeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Spoke to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(SpokeName name, st::CancellationToken cancellationToken) =>
            DeleteSpokeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HubService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Network Connectivity Center is a hub-and-spoke abstraction for
    /// network connectivity management in Google Cloud. It reduces
    /// operational complexity through a simple, centralized connectivity management
    /// model.
    /// </remarks>
    public sealed partial class HubServiceClientImpl : HubServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListHubsRequest, ListHubsResponse> _callListHubs;

        private readonly gaxgrpc::ApiCall<GetHubRequest, Hub> _callGetHub;

        private readonly gaxgrpc::ApiCall<CreateHubRequest, lro::Operation> _callCreateHub;

        private readonly gaxgrpc::ApiCall<UpdateHubRequest, lro::Operation> _callUpdateHub;

        private readonly gaxgrpc::ApiCall<DeleteHubRequest, lro::Operation> _callDeleteHub;

        private readonly gaxgrpc::ApiCall<ListSpokesRequest, ListSpokesResponse> _callListSpokes;

        private readonly gaxgrpc::ApiCall<GetSpokeRequest, Spoke> _callGetSpoke;

        private readonly gaxgrpc::ApiCall<CreateSpokeRequest, lro::Operation> _callCreateSpoke;

        private readonly gaxgrpc::ApiCall<UpdateSpokeRequest, lro::Operation> _callUpdateSpoke;

        private readonly gaxgrpc::ApiCall<DeleteSpokeRequest, lro::Operation> _callDeleteSpoke;

        /// <summary>
        /// Constructs a client wrapper for the HubService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HubServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HubServiceClientImpl(HubService.HubServiceClient grpcClient, HubServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HubServiceSettings effectiveSettings = settings ?? HubServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateHubOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateHubOperationsSettings, logger);
            UpdateHubOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateHubOperationsSettings, logger);
            DeleteHubOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteHubOperationsSettings, logger);
            CreateSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSpokeOperationsSettings, logger);
            UpdateSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSpokeOperationsSettings, logger);
            DeleteSpokeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSpokeOperationsSettings, logger);
            _callListHubs = clientHelper.BuildApiCall<ListHubsRequest, ListHubsResponse>("ListHubs", grpcClient.ListHubsAsync, grpcClient.ListHubs, effectiveSettings.ListHubsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHubs);
            Modify_ListHubsApiCall(ref _callListHubs);
            _callGetHub = clientHelper.BuildApiCall<GetHubRequest, Hub>("GetHub", grpcClient.GetHubAsync, grpcClient.GetHub, effectiveSettings.GetHubSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHub);
            Modify_GetHubApiCall(ref _callGetHub);
            _callCreateHub = clientHelper.BuildApiCall<CreateHubRequest, lro::Operation>("CreateHub", grpcClient.CreateHubAsync, grpcClient.CreateHub, effectiveSettings.CreateHubSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHub);
            Modify_CreateHubApiCall(ref _callCreateHub);
            _callUpdateHub = clientHelper.BuildApiCall<UpdateHubRequest, lro::Operation>("UpdateHub", grpcClient.UpdateHubAsync, grpcClient.UpdateHub, effectiveSettings.UpdateHubSettings).WithGoogleRequestParam("hub.name", request => request.Hub?.Name);
            Modify_ApiCall(ref _callUpdateHub);
            Modify_UpdateHubApiCall(ref _callUpdateHub);
            _callDeleteHub = clientHelper.BuildApiCall<DeleteHubRequest, lro::Operation>("DeleteHub", grpcClient.DeleteHubAsync, grpcClient.DeleteHub, effectiveSettings.DeleteHubSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteHub);
            Modify_DeleteHubApiCall(ref _callDeleteHub);
            _callListSpokes = clientHelper.BuildApiCall<ListSpokesRequest, ListSpokesResponse>("ListSpokes", grpcClient.ListSpokesAsync, grpcClient.ListSpokes, effectiveSettings.ListSpokesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSpokes);
            Modify_ListSpokesApiCall(ref _callListSpokes);
            _callGetSpoke = clientHelper.BuildApiCall<GetSpokeRequest, Spoke>("GetSpoke", grpcClient.GetSpokeAsync, grpcClient.GetSpoke, effectiveSettings.GetSpokeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpoke);
            Modify_GetSpokeApiCall(ref _callGetSpoke);
            _callCreateSpoke = clientHelper.BuildApiCall<CreateSpokeRequest, lro::Operation>("CreateSpoke", grpcClient.CreateSpokeAsync, grpcClient.CreateSpoke, effectiveSettings.CreateSpokeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSpoke);
            Modify_CreateSpokeApiCall(ref _callCreateSpoke);
            _callUpdateSpoke = clientHelper.BuildApiCall<UpdateSpokeRequest, lro::Operation>("UpdateSpoke", grpcClient.UpdateSpokeAsync, grpcClient.UpdateSpoke, effectiveSettings.UpdateSpokeSettings).WithGoogleRequestParam("spoke.name", request => request.Spoke?.Name);
            Modify_ApiCall(ref _callUpdateSpoke);
            Modify_UpdateSpokeApiCall(ref _callUpdateSpoke);
            _callDeleteSpoke = clientHelper.BuildApiCall<DeleteSpokeRequest, lro::Operation>("DeleteSpoke", grpcClient.DeleteSpokeAsync, grpcClient.DeleteSpoke, effectiveSettings.DeleteSpokeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSpoke);
            Modify_DeleteSpokeApiCall(ref _callDeleteSpoke);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListHubsApiCall(ref gaxgrpc::ApiCall<ListHubsRequest, ListHubsResponse> call);

        partial void Modify_GetHubApiCall(ref gaxgrpc::ApiCall<GetHubRequest, Hub> call);

        partial void Modify_CreateHubApiCall(ref gaxgrpc::ApiCall<CreateHubRequest, lro::Operation> call);

        partial void Modify_UpdateHubApiCall(ref gaxgrpc::ApiCall<UpdateHubRequest, lro::Operation> call);

        partial void Modify_DeleteHubApiCall(ref gaxgrpc::ApiCall<DeleteHubRequest, lro::Operation> call);

        partial void Modify_ListSpokesApiCall(ref gaxgrpc::ApiCall<ListSpokesRequest, ListSpokesResponse> call);

        partial void Modify_GetSpokeApiCall(ref gaxgrpc::ApiCall<GetSpokeRequest, Spoke> call);

        partial void Modify_CreateSpokeApiCall(ref gaxgrpc::ApiCall<CreateSpokeRequest, lro::Operation> call);

        partial void Modify_UpdateSpokeApiCall(ref gaxgrpc::ApiCall<UpdateSpokeRequest, lro::Operation> call);

        partial void Modify_DeleteSpokeApiCall(ref gaxgrpc::ApiCall<DeleteSpokeRequest, lro::Operation> call);

        partial void OnConstruction(HubService.HubServiceClient grpcClient, HubServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HubService client</summary>
        public override HubService.HubServiceClient GrpcClient { get; }

        partial void Modify_ListHubsRequest(ref ListHubsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHubRequest(ref GetHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHubRequest(ref CreateHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHubRequest(ref UpdateHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHubRequest(ref DeleteHubRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSpokesRequest(ref ListSpokesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpokeRequest(ref GetSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSpokeRequest(ref CreateSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpokeRequest(ref UpdateSpokeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSpokeRequest(ref DeleteSpokeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Hub"/> resources.</returns>
        public override gax::PagedEnumerable<ListHubsResponse, Hub> ListHubs(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHubsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHubsRequest, ListHubsResponse, Hub>(_callListHubs, request, callSettings);
        }

        /// <summary>
        /// Lists Hubs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Hub"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHubsResponse, Hub> ListHubsAsync(ListHubsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHubsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHubsRequest, ListHubsResponse, Hub>(_callListHubs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Hub GetHub(GetHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHubRequest(ref request, ref callSettings);
            return _callGetHub.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Hub> GetHubAsync(GetHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHubRequest(ref request, ref callSettings);
            return _callGetHub.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateHub</c>.</summary>
        public override lro::OperationsClient CreateHubOperationsClient { get; }

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hub, OperationMetadata> CreateHub(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(_callCreateHub.Sync(request, callSettings), CreateHubOperationsClient);
        }

        /// <summary>
        /// Creates a new Hub in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hub, OperationMetadata>> CreateHubAsync(CreateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(await _callCreateHub.Async(request, callSettings).ConfigureAwait(false), CreateHubOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateHub</c>.</summary>
        public override lro::OperationsClient UpdateHubOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Hub, OperationMetadata> UpdateHub(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(_callUpdateHub.Sync(request, callSettings), UpdateHubOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Hub, OperationMetadata>> UpdateHubAsync(UpdateHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHubRequest(ref request, ref callSettings);
            return new lro::Operation<Hub, OperationMetadata>(await _callUpdateHub.Async(request, callSettings).ConfigureAwait(false), UpdateHubOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteHub</c>.</summary>
        public override lro::OperationsClient DeleteHubOperationsClient { get; }

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteHub(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHubRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteHub.Sync(request, callSettings), DeleteHubOperationsClient);
        }

        /// <summary>
        /// Deletes a single Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteHubAsync(DeleteHubRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHubRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteHub.Async(request, callSettings).ConfigureAwait(false), DeleteHubOperationsClient);
        }

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spoke"/> resources.</returns>
        public override gax::PagedEnumerable<ListSpokesResponse, Spoke> ListSpokes(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpokesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSpokesRequest, ListSpokesResponse, Spoke>(_callListSpokes, request, callSettings);
        }

        /// <summary>
        /// Lists Spokes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spoke"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSpokesResponse, Spoke> ListSpokesAsync(ListSpokesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpokesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSpokesRequest, ListSpokesResponse, Spoke>(_callListSpokes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Spoke GetSpoke(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpokeRequest(ref request, ref callSettings);
            return _callGetSpoke.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Spoke> GetSpokeAsync(GetSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpokeRequest(ref request, ref callSettings);
            return _callGetSpoke.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSpoke</c>.</summary>
        public override lro::OperationsClient CreateSpokeOperationsClient { get; }

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Spoke, OperationMetadata> CreateSpoke(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(_callCreateSpoke.Sync(request, callSettings), CreateSpokeOperationsClient);
        }

        /// <summary>
        /// Creates a new Spoke in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Spoke, OperationMetadata>> CreateSpokeAsync(CreateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(await _callCreateSpoke.Async(request, callSettings).ConfigureAwait(false), CreateSpokeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSpoke</c>.</summary>
        public override lro::OperationsClient UpdateSpokeOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Spoke, OperationMetadata> UpdateSpoke(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(_callUpdateSpoke.Sync(request, callSettings), UpdateSpokeOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Spoke, OperationMetadata>> UpdateSpokeAsync(UpdateSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<Spoke, OperationMetadata>(await _callUpdateSpoke.Async(request, callSettings).ConfigureAwait(false), UpdateSpokeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSpoke</c>.</summary>
        public override lro::OperationsClient DeleteSpokeOperationsClient { get; }

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSpoke(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSpoke.Sync(request, callSettings), DeleteSpokeOperationsClient);
        }

        /// <summary>
        /// Deletes a single Spoke.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSpokeAsync(DeleteSpokeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpokeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSpoke.Async(request, callSettings).ConfigureAwait(false), DeleteSpokeOperationsClient);
        }
    }

    public partial class ListHubsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSpokesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHubsResponse : gaxgrpc::IPageResponse<Hub>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Hub> GetEnumerator() => Hubs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSpokesResponse : gaxgrpc::IPageResponse<Spoke>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Spoke> GetEnumerator() => Spokes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class HubService
    {
        public partial class HubServiceClient
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
}
