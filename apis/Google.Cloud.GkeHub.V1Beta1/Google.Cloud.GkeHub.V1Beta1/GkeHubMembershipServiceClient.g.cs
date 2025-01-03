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

namespace Google.Cloud.GkeHub.V1Beta1
{
    /// <summary>Settings for <see cref="GkeHubMembershipServiceClient"/> instances.</summary>
    public sealed partial class GkeHubMembershipServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GkeHubMembershipServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GkeHubMembershipServiceSettings"/>.</returns>
        public static GkeHubMembershipServiceSettings GetDefault() => new GkeHubMembershipServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GkeHubMembershipServiceSettings"/> object with default settings.
        /// </summary>
        public GkeHubMembershipServiceSettings()
        {
        }

        private GkeHubMembershipServiceSettings(GkeHubMembershipServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMembershipsSettings = existing.ListMembershipsSettings;
            GetMembershipSettings = existing.GetMembershipSettings;
            CreateMembershipSettings = existing.CreateMembershipSettings;
            CreateMembershipOperationsSettings = existing.CreateMembershipOperationsSettings.Clone();
            DeleteMembershipSettings = existing.DeleteMembershipSettings;
            DeleteMembershipOperationsSettings = existing.DeleteMembershipOperationsSettings.Clone();
            UpdateMembershipSettings = existing.UpdateMembershipSettings;
            UpdateMembershipOperationsSettings = existing.UpdateMembershipOperationsSettings.Clone();
            GenerateConnectManifestSettings = existing.GenerateConnectManifestSettings;
            ValidateExclusivitySettings = existing.ValidateExclusivitySettings;
            GenerateExclusivityManifestSettings = existing.GenerateExclusivityManifestSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(GkeHubMembershipServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.ListMemberships</c> and
        /// <c>GkeHubMembershipServiceClient.ListMembershipsAsync</c>.
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
        public gaxgrpc::CallSettings ListMembershipsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.GetMembership</c> and <c>GkeHubMembershipServiceClient.GetMembershipAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.CreateMembership</c> and
        /// <c>GkeHubMembershipServiceClient.CreateMembershipAsync</c>.
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
        public gaxgrpc::CallSettings CreateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubMembershipServiceClient.CreateMembership</c> and
        /// <c>GkeHubMembershipServiceClient.CreateMembershipAsync</c>.
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
        public lro::OperationsSettings CreateMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.DeleteMembership</c> and
        /// <c>GkeHubMembershipServiceClient.DeleteMembershipAsync</c>.
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
        public gaxgrpc::CallSettings DeleteMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubMembershipServiceClient.DeleteMembership</c> and
        /// <c>GkeHubMembershipServiceClient.DeleteMembershipAsync</c>.
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
        public lro::OperationsSettings DeleteMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.UpdateMembership</c> and
        /// <c>GkeHubMembershipServiceClient.UpdateMembershipAsync</c>.
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
        public gaxgrpc::CallSettings UpdateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubMembershipServiceClient.UpdateMembership</c> and
        /// <c>GkeHubMembershipServiceClient.UpdateMembershipAsync</c>.
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
        public lro::OperationsSettings UpdateMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.GenerateConnectManifest</c> and
        /// <c>GkeHubMembershipServiceClient.GenerateConnectManifestAsync</c>.
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
        public gaxgrpc::CallSettings GenerateConnectManifestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.ValidateExclusivity</c> and
        /// <c>GkeHubMembershipServiceClient.ValidateExclusivityAsync</c>.
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
        public gaxgrpc::CallSettings ValidateExclusivitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubMembershipServiceClient.GenerateExclusivityManifest</c> and
        /// <c>GkeHubMembershipServiceClient.GenerateExclusivityManifestAsync</c>.
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
        public gaxgrpc::CallSettings GenerateExclusivityManifestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GkeHubMembershipServiceSettings"/> object.</returns>
        public GkeHubMembershipServiceSettings Clone() => new GkeHubMembershipServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GkeHubMembershipServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GkeHubMembershipServiceClientBuilder : gaxgrpc::ClientBuilderBase<GkeHubMembershipServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GkeHubMembershipServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GkeHubMembershipServiceClientBuilder() : base(GkeHubMembershipServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GkeHubMembershipServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GkeHubMembershipServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GkeHubMembershipServiceClient Build()
        {
            GkeHubMembershipServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GkeHubMembershipServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GkeHubMembershipServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GkeHubMembershipServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GkeHubMembershipServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GkeHubMembershipServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GkeHubMembershipServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GkeHubMembershipServiceClient.ChannelPool;
    }

    /// <summary>GkeHubMembershipService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The GKE Hub MembershipService handles the registration of many Kubernetes
    /// clusters to Google Cloud, represented with the
    /// [Membership][google.cloud.gkehub.v1beta1.Membership] resource.
    /// 
    /// GKE Hub is currently available in the global region and all regions in
    /// https://cloud.google.com/compute/docs/regions-zones.
    /// 
    /// **Membership management may be non-trivial:** it is recommended to use one
    /// of the Google-provided client libraries or tools where possible when working
    /// with Membership resources.
    /// </remarks>
    public abstract partial class GkeHubMembershipServiceClient
    {
        /// <summary>
        /// The default endpoint for the GkeHubMembershipService service, which is a host of "gkehub.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkehub.googleapis.com:443";

        /// <summary>The default GkeHubMembershipService scopes.</summary>
        /// <remarks>
        /// The default GkeHubMembershipService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GkeHubMembershipService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GkeHubMembershipServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GkeHubMembershipServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GkeHubMembershipServiceClient"/>.</returns>
        public static stt::Task<GkeHubMembershipServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GkeHubMembershipServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GkeHubMembershipServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GkeHubMembershipServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GkeHubMembershipServiceClient"/>.</returns>
        public static GkeHubMembershipServiceClient Create() => new GkeHubMembershipServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GkeHubMembershipServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GkeHubMembershipServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GkeHubMembershipServiceClient"/>.</returns>
        internal static GkeHubMembershipServiceClient Create(grpccore::CallInvoker callInvoker, GkeHubMembershipServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GkeHubMembershipService.GkeHubMembershipServiceClient grpcClient = new GkeHubMembershipService.GkeHubMembershipServiceClient(callInvoker);
            return new GkeHubMembershipServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GkeHubMembershipService client</summary>
        public virtual GkeHubMembershipService.GkeHubMembershipServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
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
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
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
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// listed. Specified in the format `projects/*/locations/*`.
        /// `projects/*/locations/-` list memberships in all the regions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMembership</c>.</summary>
        public virtual lro::OperationsClient CreateMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> PollOnceCreateMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> PollOnceCreateMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(string parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(string parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(string parent, Membership resource, string membershipId, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, resource, membershipId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(gagr::LocationName parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(gagr::LocationName parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be
        /// created. Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a
        /// valid RFC 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(gagr::LocationName parent, Membership resource, string membershipId, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, resource, membershipId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMembership</c>.</summary>
        public virtual lro::OperationsClient DeleteMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipOperationsClient, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMembership</c>.</summary>
        public virtual lro::OperationsClient UpdateMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> PollOnceUpdateMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> PollOnceUpdateMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The membership resource name in the format:
        /// `projects/[project_id]/locations/global/memberships/[membership_id]`
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one field path must be
        /// specified in this mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(string name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembership(new UpdateMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The membership resource name in the format:
        /// `projects/[project_id]/locations/global/memberships/[membership_id]`
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one field path must be
        /// specified in this mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(string name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipAsync(new UpdateMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The membership resource name in the format:
        /// `projects/[project_id]/locations/global/memberships/[membership_id]`
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one field path must be
        /// specified in this mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(string name, Membership resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The membership resource name in the format:
        /// `projects/[project_id]/locations/global/memberships/[membership_id]`
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one field path must be
        /// specified in this mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(MembershipName name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembership(new UpdateMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The membership resource name in the format:
        /// `projects/[project_id]/locations/global/memberships/[membership_id]`
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one field path must be
        /// specified in this mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(MembershipName name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipAsync(new UpdateMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The membership resource name in the format:
        /// `projects/[project_id]/locations/global/memberships/[membership_id]`
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one field path must be
        /// specified in this mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(MembershipName name, Membership resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConnectManifestResponse GenerateConnectManifest(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, st::CancellationToken cancellationToken) =>
            GenerateConnectManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ValidateExclusivity validates the state of exclusivity in the cluster.
        /// The validation does not depend on an existing Hub membership resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateExclusivityResponse ValidateExclusivity(ValidateExclusivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ValidateExclusivity validates the state of exclusivity in the cluster.
        /// The validation does not depend on an existing Hub membership resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateExclusivityResponse> ValidateExclusivityAsync(ValidateExclusivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ValidateExclusivity validates the state of exclusivity in the cluster.
        /// The validation does not depend on an existing Hub membership resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateExclusivityResponse> ValidateExclusivityAsync(ValidateExclusivityRequest request, st::CancellationToken cancellationToken) =>
            ValidateExclusivityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GenerateExclusivityManifest generates the manifests to update the
        /// exclusivity artifacts in the cluster if needed.
        /// 
        /// Exclusivity artifacts include the Membership custom resource definition
        /// (CRD) and the singleton Membership custom resource (CR). Combined with
        /// ValidateExclusivity, exclusivity artifacts guarantee that a Kubernetes
        /// cluster is only registered to a single GKE Hub.
        /// 
        /// The Membership CRD is versioned, and may require conversion when the GKE
        /// Hub API server begins serving a newer version of the CRD and
        /// corresponding CR. The response will be the converted CRD and CR if there
        /// are any differences between the versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateExclusivityManifestResponse GenerateExclusivityManifest(GenerateExclusivityManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GenerateExclusivityManifest generates the manifests to update the
        /// exclusivity artifacts in the cluster if needed.
        /// 
        /// Exclusivity artifacts include the Membership custom resource definition
        /// (CRD) and the singleton Membership custom resource (CR). Combined with
        /// ValidateExclusivity, exclusivity artifacts guarantee that a Kubernetes
        /// cluster is only registered to a single GKE Hub.
        /// 
        /// The Membership CRD is versioned, and may require conversion when the GKE
        /// Hub API server begins serving a newer version of the CRD and
        /// corresponding CR. The response will be the converted CRD and CR if there
        /// are any differences between the versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateExclusivityManifestResponse> GenerateExclusivityManifestAsync(GenerateExclusivityManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GenerateExclusivityManifest generates the manifests to update the
        /// exclusivity artifacts in the cluster if needed.
        /// 
        /// Exclusivity artifacts include the Membership custom resource definition
        /// (CRD) and the singleton Membership custom resource (CR). Combined with
        /// ValidateExclusivity, exclusivity artifacts guarantee that a Kubernetes
        /// cluster is only registered to a single GKE Hub.
        /// 
        /// The Membership CRD is versioned, and may require conversion when the GKE
        /// Hub API server begins serving a newer version of the CRD and
        /// corresponding CR. The response will be the converted CRD and CR if there
        /// are any differences between the versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateExclusivityManifestResponse> GenerateExclusivityManifestAsync(GenerateExclusivityManifestRequest request, st::CancellationToken cancellationToken) =>
            GenerateExclusivityManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GkeHubMembershipService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GKE Hub MembershipService handles the registration of many Kubernetes
    /// clusters to Google Cloud, represented with the
    /// [Membership][google.cloud.gkehub.v1beta1.Membership] resource.
    /// 
    /// GKE Hub is currently available in the global region and all regions in
    /// https://cloud.google.com/compute/docs/regions-zones.
    /// 
    /// **Membership management may be non-trivial:** it is recommended to use one
    /// of the Google-provided client libraries or tools where possible when working
    /// with Membership resources.
    /// </remarks>
    public sealed partial class GkeHubMembershipServiceClientImpl : GkeHubMembershipServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> _callListMemberships;

        private readonly gaxgrpc::ApiCall<GetMembershipRequest, Membership> _callGetMembership;

        private readonly gaxgrpc::ApiCall<CreateMembershipRequest, lro::Operation> _callCreateMembership;

        private readonly gaxgrpc::ApiCall<DeleteMembershipRequest, lro::Operation> _callDeleteMembership;

        private readonly gaxgrpc::ApiCall<UpdateMembershipRequest, lro::Operation> _callUpdateMembership;

        private readonly gaxgrpc::ApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse> _callGenerateConnectManifest;

        private readonly gaxgrpc::ApiCall<ValidateExclusivityRequest, ValidateExclusivityResponse> _callValidateExclusivity;

        private readonly gaxgrpc::ApiCall<GenerateExclusivityManifestRequest, GenerateExclusivityManifestResponse> _callGenerateExclusivityManifest;

        /// <summary>
        /// Constructs a client wrapper for the GkeHubMembershipService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GkeHubMembershipServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GkeHubMembershipServiceClientImpl(GkeHubMembershipService.GkeHubMembershipServiceClient grpcClient, GkeHubMembershipServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GkeHubMembershipServiceSettings effectiveSettings = settings ?? GkeHubMembershipServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMembershipOperationsSettings, logger);
            DeleteMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMembershipOperationsSettings, logger);
            UpdateMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMembershipOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListMemberships = clientHelper.BuildApiCall<ListMembershipsRequest, ListMembershipsResponse>("ListMemberships", grpcClient.ListMembershipsAsync, grpcClient.ListMemberships, effectiveSettings.ListMembershipsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMemberships);
            Modify_ListMembershipsApiCall(ref _callListMemberships);
            _callGetMembership = clientHelper.BuildApiCall<GetMembershipRequest, Membership>("GetMembership", grpcClient.GetMembershipAsync, grpcClient.GetMembership, effectiveSettings.GetMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMembership);
            Modify_GetMembershipApiCall(ref _callGetMembership);
            _callCreateMembership = clientHelper.BuildApiCall<CreateMembershipRequest, lro::Operation>("CreateMembership", grpcClient.CreateMembershipAsync, grpcClient.CreateMembership, effectiveSettings.CreateMembershipSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMembership);
            Modify_CreateMembershipApiCall(ref _callCreateMembership);
            _callDeleteMembership = clientHelper.BuildApiCall<DeleteMembershipRequest, lro::Operation>("DeleteMembership", grpcClient.DeleteMembershipAsync, grpcClient.DeleteMembership, effectiveSettings.DeleteMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMembership);
            Modify_DeleteMembershipApiCall(ref _callDeleteMembership);
            _callUpdateMembership = clientHelper.BuildApiCall<UpdateMembershipRequest, lro::Operation>("UpdateMembership", grpcClient.UpdateMembershipAsync, grpcClient.UpdateMembership, effectiveSettings.UpdateMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateMembership);
            Modify_UpdateMembershipApiCall(ref _callUpdateMembership);
            _callGenerateConnectManifest = clientHelper.BuildApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse>("GenerateConnectManifest", grpcClient.GenerateConnectManifestAsync, grpcClient.GenerateConnectManifest, effectiveSettings.GenerateConnectManifestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateConnectManifest);
            Modify_GenerateConnectManifestApiCall(ref _callGenerateConnectManifest);
            _callValidateExclusivity = clientHelper.BuildApiCall<ValidateExclusivityRequest, ValidateExclusivityResponse>("ValidateExclusivity", grpcClient.ValidateExclusivityAsync, grpcClient.ValidateExclusivity, effectiveSettings.ValidateExclusivitySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callValidateExclusivity);
            Modify_ValidateExclusivityApiCall(ref _callValidateExclusivity);
            _callGenerateExclusivityManifest = clientHelper.BuildApiCall<GenerateExclusivityManifestRequest, GenerateExclusivityManifestResponse>("GenerateExclusivityManifest", grpcClient.GenerateExclusivityManifestAsync, grpcClient.GenerateExclusivityManifest, effectiveSettings.GenerateExclusivityManifestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateExclusivityManifest);
            Modify_GenerateExclusivityManifestApiCall(ref _callGenerateExclusivityManifest);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMembershipsApiCall(ref gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> call);

        partial void Modify_GetMembershipApiCall(ref gaxgrpc::ApiCall<GetMembershipRequest, Membership> call);

        partial void Modify_CreateMembershipApiCall(ref gaxgrpc::ApiCall<CreateMembershipRequest, lro::Operation> call);

        partial void Modify_DeleteMembershipApiCall(ref gaxgrpc::ApiCall<DeleteMembershipRequest, lro::Operation> call);

        partial void Modify_UpdateMembershipApiCall(ref gaxgrpc::ApiCall<UpdateMembershipRequest, lro::Operation> call);

        partial void Modify_GenerateConnectManifestApiCall(ref gaxgrpc::ApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse> call);

        partial void Modify_ValidateExclusivityApiCall(ref gaxgrpc::ApiCall<ValidateExclusivityRequest, ValidateExclusivityResponse> call);

        partial void Modify_GenerateExclusivityManifestApiCall(ref gaxgrpc::ApiCall<GenerateExclusivityManifestRequest, GenerateExclusivityManifestResponse> call);

        partial void OnConstruction(GkeHubMembershipService.GkeHubMembershipServiceClient grpcClient, GkeHubMembershipServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GkeHubMembershipService client</summary>
        public override GkeHubMembershipService.GkeHubMembershipServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListMembershipsRequest(ref ListMembershipsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMembershipRequest(ref GetMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMembershipRequest(ref CreateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMembershipRequest(ref DeleteMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMembershipRequest(ref UpdateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateConnectManifestRequest(ref GenerateConnectManifestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateExclusivityRequest(ref ValidateExclusivityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateExclusivityManifestRequest(ref GenerateExclusivityManifestRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMembership</c>.</summary>
        public override lro::OperationsClient CreateMembershipOperationsClient { get; }

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Membership, OperationMetadata> CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(_callCreateMembership.Sync(request, callSettings), CreateMembershipOperationsClient);
        }

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(await _callCreateMembership.Async(request, callSettings).ConfigureAwait(false), CreateMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMembership</c>.</summary>
        public override lro::OperationsClient DeleteMembershipOperationsClient { get; }

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMembership.Sync(request, callSettings), DeleteMembershipOperationsClient);
        }

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMembership.Async(request, callSettings).ConfigureAwait(false), DeleteMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMembership</c>.</summary>
        public override lro::OperationsClient UpdateMembershipOperationsClient { get; }

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Membership, OperationMetadata> UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(_callUpdateMembership.Sync(request, callSettings), UpdateMembershipOperationsClient);
        }

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(await _callUpdateMembership.Async(request, callSettings).ConfigureAwait(false), UpdateMembershipOperationsClient);
        }

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateConnectManifestResponse GenerateConnectManifest(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConnectManifestRequest(ref request, ref callSettings);
            return _callGenerateConnectManifest.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConnectManifestRequest(ref request, ref callSettings);
            return _callGenerateConnectManifest.Async(request, callSettings);
        }

        /// <summary>
        /// ValidateExclusivity validates the state of exclusivity in the cluster.
        /// The validation does not depend on an existing Hub membership resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValidateExclusivityResponse ValidateExclusivity(ValidateExclusivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateExclusivityRequest(ref request, ref callSettings);
            return _callValidateExclusivity.Sync(request, callSettings);
        }

        /// <summary>
        /// ValidateExclusivity validates the state of exclusivity in the cluster.
        /// The validation does not depend on an existing Hub membership resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValidateExclusivityResponse> ValidateExclusivityAsync(ValidateExclusivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateExclusivityRequest(ref request, ref callSettings);
            return _callValidateExclusivity.Async(request, callSettings);
        }

        /// <summary>
        /// GenerateExclusivityManifest generates the manifests to update the
        /// exclusivity artifacts in the cluster if needed.
        /// 
        /// Exclusivity artifacts include the Membership custom resource definition
        /// (CRD) and the singleton Membership custom resource (CR). Combined with
        /// ValidateExclusivity, exclusivity artifacts guarantee that a Kubernetes
        /// cluster is only registered to a single GKE Hub.
        /// 
        /// The Membership CRD is versioned, and may require conversion when the GKE
        /// Hub API server begins serving a newer version of the CRD and
        /// corresponding CR. The response will be the converted CRD and CR if there
        /// are any differences between the versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateExclusivityManifestResponse GenerateExclusivityManifest(GenerateExclusivityManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateExclusivityManifestRequest(ref request, ref callSettings);
            return _callGenerateExclusivityManifest.Sync(request, callSettings);
        }

        /// <summary>
        /// GenerateExclusivityManifest generates the manifests to update the
        /// exclusivity artifacts in the cluster if needed.
        /// 
        /// Exclusivity artifacts include the Membership custom resource definition
        /// (CRD) and the singleton Membership custom resource (CR). Combined with
        /// ValidateExclusivity, exclusivity artifacts guarantee that a Kubernetes
        /// cluster is only registered to a single GKE Hub.
        /// 
        /// The Membership CRD is versioned, and may require conversion when the GKE
        /// Hub API server begins serving a newer version of the CRD and
        /// corresponding CR. The response will be the converted CRD and CR if there
        /// are any differences between the versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateExclusivityManifestResponse> GenerateExclusivityManifestAsync(GenerateExclusivityManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateExclusivityManifestRequest(ref request, ref callSettings);
            return _callGenerateExclusivityManifest.Async(request, callSettings);
        }
    }

    public partial class ListMembershipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMembershipsResponse : gaxgrpc::IPageResponse<Membership>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Membership> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GkeHubMembershipService
    {
        public partial class GkeHubMembershipServiceClient
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

    public static partial class GkeHubMembershipService
    {
        public partial class GkeHubMembershipServiceClient
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
