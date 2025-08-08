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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1
{
    /// <summary>Settings for <see cref="SaasRolloutsClient"/> instances.</summary>
    public sealed partial class SaasRolloutsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SaasRolloutsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SaasRolloutsSettings"/>.</returns>
        public static SaasRolloutsSettings GetDefault() => new SaasRolloutsSettings();

        /// <summary>Constructs a new <see cref="SaasRolloutsSettings"/> object with default settings.</summary>
        public SaasRolloutsSettings()
        {
        }

        private SaasRolloutsSettings(SaasRolloutsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListRolloutsSettings = existing.ListRolloutsSettings;
            GetRolloutSettings = existing.GetRolloutSettings;
            CreateRolloutSettings = existing.CreateRolloutSettings;
            UpdateRolloutSettings = existing.UpdateRolloutSettings;
            DeleteRolloutSettings = existing.DeleteRolloutSettings;
            ListRolloutKindsSettings = existing.ListRolloutKindsSettings;
            GetRolloutKindSettings = existing.GetRolloutKindSettings;
            CreateRolloutKindSettings = existing.CreateRolloutKindSettings;
            UpdateRolloutKindSettings = existing.UpdateRolloutKindSettings;
            DeleteRolloutKindSettings = existing.DeleteRolloutKindSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SaasRolloutsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.ListRollouts</c> and <c>SaasRolloutsClient.ListRolloutsAsync</c>.
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
        public gaxgrpc::CallSettings ListRolloutsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.GetRollout</c> and <c>SaasRolloutsClient.GetRolloutAsync</c>.
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
        public gaxgrpc::CallSettings GetRolloutSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.CreateRollout</c> and <c>SaasRolloutsClient.CreateRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.UpdateRollout</c> and <c>SaasRolloutsClient.UpdateRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.DeleteRollout</c> and <c>SaasRolloutsClient.DeleteRolloutAsync</c>.
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
        /// <item><description>Timeout: 540 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRolloutSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(540000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.ListRolloutKinds</c> and <c>SaasRolloutsClient.ListRolloutKindsAsync</c>.
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
        public gaxgrpc::CallSettings ListRolloutKindsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.GetRolloutKind</c> and <c>SaasRolloutsClient.GetRolloutKindAsync</c>.
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
        public gaxgrpc::CallSettings GetRolloutKindSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.CreateRolloutKind</c> and <c>SaasRolloutsClient.CreateRolloutKindAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRolloutKindSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.UpdateRolloutKind</c> and <c>SaasRolloutsClient.UpdateRolloutKindAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRolloutKindSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasRolloutsClient.DeleteRolloutKind</c> and <c>SaasRolloutsClient.DeleteRolloutKindAsync</c>.
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
        public gaxgrpc::CallSettings DeleteRolloutKindSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SaasRolloutsSettings"/> object.</returns>
        public SaasRolloutsSettings Clone() => new SaasRolloutsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SaasRolloutsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SaasRolloutsClientBuilder : gaxgrpc::ClientBuilderBase<SaasRolloutsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SaasRolloutsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SaasRolloutsClientBuilder() : base(SaasRolloutsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SaasRolloutsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SaasRolloutsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SaasRolloutsClient Build()
        {
            SaasRolloutsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SaasRolloutsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SaasRolloutsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SaasRolloutsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SaasRolloutsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SaasRolloutsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SaasRolloutsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SaasRolloutsClient.ChannelPool;
    }

    /// <summary>SaasRollouts client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages the rollout of SaaS services.
    /// </remarks>
    public abstract partial class SaasRolloutsClient
    {
        /// <summary>
        /// The default endpoint for the SaasRollouts service, which is a host of "saasservicemgmt.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "saasservicemgmt.googleapis.com:443";

        /// <summary>The default SaasRollouts scopes.</summary>
        /// <remarks>
        /// The default SaasRollouts scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SaasRollouts.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SaasRolloutsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SaasRolloutsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SaasRolloutsClient"/>.</returns>
        public static stt::Task<SaasRolloutsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SaasRolloutsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SaasRolloutsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SaasRolloutsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SaasRolloutsClient"/>.</returns>
        public static SaasRolloutsClient Create() => new SaasRolloutsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SaasRolloutsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SaasRolloutsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SaasRolloutsClient"/>.</returns>
        internal static SaasRolloutsClient Create(grpccore::CallInvoker callInvoker, SaasRolloutsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SaasRollouts.SaasRolloutsClient grpcClient = new SaasRollouts.SaasRolloutsClient(callInvoker);
            return new SaasRolloutsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SaasRollouts client</summary>
        public virtual SaasRollouts.SaasRolloutsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
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
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
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
            return ListRollouts(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
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
            return ListRolloutsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
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
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
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
            return ListRollouts(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
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
            return ListRolloutsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRollout(new GetRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutAsync(new GetRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRollout(new GetRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutAsync(new GetRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout CreateRollout(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> CreateRolloutAsync(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> CreateRolloutAsync(CreateRolloutRequest request, st::CancellationToken cancellationToken) =>
            CreateRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
        /// </param>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The ID value for the new rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout CreateRollout(string parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRollout(new CreateRolloutRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
        /// </param>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The ID value for the new rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> CreateRolloutAsync(string parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutAsync(new CreateRolloutRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
        /// </param>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The ID value for the new rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> CreateRolloutAsync(string parent, Rollout rollout, string rolloutId, st::CancellationToken cancellationToken) =>
            CreateRolloutAsync(parent, rollout, rolloutId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
        /// </param>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The ID value for the new rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout CreateRollout(gagr::LocationName parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRollout(new CreateRolloutRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
        /// </param>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The ID value for the new rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> CreateRolloutAsync(gagr::LocationName parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutAsync(new CreateRolloutRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout.
        /// </param>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The ID value for the new rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> CreateRolloutAsync(gagr::LocationName parent, Rollout rollout, string rolloutId, st::CancellationToken cancellationToken) =>
            CreateRolloutAsync(parent, rollout, rolloutId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout UpdateRollout(UpdateRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> UpdateRolloutAsync(UpdateRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> UpdateRolloutAsync(UpdateRolloutRequest request, st::CancellationToken cancellationToken) =>
            UpdateRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Rollout resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Rollout will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout UpdateRollout(Rollout rollout, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRollout(new UpdateRolloutRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Rollout resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Rollout will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> UpdateRolloutAsync(Rollout rollout, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRolloutAsync(new UpdateRolloutRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. The desired state for the rollout.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Rollout resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Rollout will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> UpdateRolloutAsync(Rollout rollout, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRolloutAsync(rollout, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRollout(DeleteRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutAsync(DeleteRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutAsync(DeleteRolloutRequest request, st::CancellationToken cancellationToken) =>
            DeleteRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRollout(new DeleteRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRolloutAsync(new DeleteRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRollout(new DeleteRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRolloutAsync(new DeleteRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            DeleteRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RolloutKind"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKinds(ListRolloutKindsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RolloutKind"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKindsAsync(ListRolloutKindsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
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
        /// <returns>A pageable sequence of <see cref="RolloutKind"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKinds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutKindsRequest request = new ListRolloutKindsRequest
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
            return ListRolloutKinds(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RolloutKind"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKindsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutKindsRequest request = new ListRolloutKindsRequest
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
            return ListRolloutKindsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
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
        /// <returns>A pageable sequence of <see cref="RolloutKind"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKinds(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutKindsRequest request = new ListRolloutKindsRequest
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
            return ListRolloutKinds(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RolloutKind"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKindsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutKindsRequest request = new ListRolloutKindsRequest
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
            return ListRolloutKindsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind GetRolloutKind(GetRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> GetRolloutKindAsync(GetRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> GetRolloutKindAsync(GetRolloutKindRequest request, st::CancellationToken cancellationToken) =>
            GetRolloutKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind GetRolloutKind(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutKind(new GetRolloutKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> GetRolloutKindAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutKindAsync(new GetRolloutKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> GetRolloutKindAsync(string name, st::CancellationToken cancellationToken) =>
            GetRolloutKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind GetRolloutKind(RolloutKindName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutKind(new GetRolloutKindRequest
            {
                RolloutKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> GetRolloutKindAsync(RolloutKindName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutKindAsync(new GetRolloutKindRequest
            {
                RolloutKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> GetRolloutKindAsync(RolloutKindName name, st::CancellationToken cancellationToken) =>
            GetRolloutKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind CreateRolloutKind(CreateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> CreateRolloutKindAsync(CreateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> CreateRolloutKindAsync(CreateRolloutKindRequest request, st::CancellationToken cancellationToken) =>
            CreateRolloutKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
        /// </param>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="rolloutKindId">
        /// Required. The ID value for the new rollout kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind CreateRolloutKind(string parent, RolloutKind rolloutKind, string rolloutKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutKind(new CreateRolloutKindRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RolloutKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutKindId, nameof(rolloutKindId)),
                RolloutKind = gax::GaxPreconditions.CheckNotNull(rolloutKind, nameof(rolloutKind)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
        /// </param>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="rolloutKindId">
        /// Required. The ID value for the new rollout kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> CreateRolloutKindAsync(string parent, RolloutKind rolloutKind, string rolloutKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutKindAsync(new CreateRolloutKindRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RolloutKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutKindId, nameof(rolloutKindId)),
                RolloutKind = gax::GaxPreconditions.CheckNotNull(rolloutKind, nameof(rolloutKind)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
        /// </param>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="rolloutKindId">
        /// Required. The ID value for the new rollout kind.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> CreateRolloutKindAsync(string parent, RolloutKind rolloutKind, string rolloutKindId, st::CancellationToken cancellationToken) =>
            CreateRolloutKindAsync(parent, rolloutKind, rolloutKindId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
        /// </param>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="rolloutKindId">
        /// Required. The ID value for the new rollout kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind CreateRolloutKind(gagr::LocationName parent, RolloutKind rolloutKind, string rolloutKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutKind(new CreateRolloutKindRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RolloutKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutKindId, nameof(rolloutKindId)),
                RolloutKind = gax::GaxPreconditions.CheckNotNull(rolloutKind, nameof(rolloutKind)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
        /// </param>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="rolloutKindId">
        /// Required. The ID value for the new rollout kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> CreateRolloutKindAsync(gagr::LocationName parent, RolloutKind rolloutKind, string rolloutKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutKindAsync(new CreateRolloutKindRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RolloutKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutKindId, nameof(rolloutKindId)),
                RolloutKind = gax::GaxPreconditions.CheckNotNull(rolloutKind, nameof(rolloutKind)),
            }, callSettings);

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the rollout kind.
        /// </param>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="rolloutKindId">
        /// Required. The ID value for the new rollout kind.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> CreateRolloutKindAsync(gagr::LocationName parent, RolloutKind rolloutKind, string rolloutKindId, st::CancellationToken cancellationToken) =>
            CreateRolloutKindAsync(parent, rolloutKind, rolloutKindId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind UpdateRolloutKind(UpdateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> UpdateRolloutKindAsync(UpdateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> UpdateRolloutKindAsync(UpdateRolloutKindRequest request, st::CancellationToken cancellationToken) =>
            UpdateRolloutKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// RolloutKind resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// RolloutKind will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutKind UpdateRolloutKind(RolloutKind rolloutKind, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRolloutKind(new UpdateRolloutKindRequest
            {
                RolloutKind = gax::GaxPreconditions.CheckNotNull(rolloutKind, nameof(rolloutKind)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// RolloutKind resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// RolloutKind will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> UpdateRolloutKindAsync(RolloutKind rolloutKind, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRolloutKindAsync(new UpdateRolloutKindRequest
            {
                RolloutKind = gax::GaxPreconditions.CheckNotNull(rolloutKind, nameof(rolloutKind)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="rolloutKind">
        /// Required. The desired state for the rollout kind.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// RolloutKind resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// RolloutKind will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutKind> UpdateRolloutKindAsync(RolloutKind rolloutKind, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRolloutKindAsync(rolloutKind, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRolloutKind(DeleteRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutKindAsync(DeleteRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutKindAsync(DeleteRolloutKindRequest request, st::CancellationToken cancellationToken) =>
            DeleteRolloutKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRolloutKind(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRolloutKind(new DeleteRolloutKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutKindAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRolloutKindAsync(new DeleteRolloutKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutKindAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRolloutKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRolloutKind(RolloutKindName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRolloutKind(new DeleteRolloutKindRequest
            {
                RolloutKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutKindAsync(RolloutKindName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRolloutKindAsync(new DeleteRolloutKindRequest
            {
                RolloutKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRolloutKindAsync(RolloutKindName name, st::CancellationToken cancellationToken) =>
            DeleteRolloutKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SaasRollouts client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages the rollout of SaaS services.
    /// </remarks>
    public sealed partial class SaasRolloutsClientImpl : SaasRolloutsClient
    {
        private readonly gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> _callListRollouts;

        private readonly gaxgrpc::ApiCall<GetRolloutRequest, Rollout> _callGetRollout;

        private readonly gaxgrpc::ApiCall<CreateRolloutRequest, Rollout> _callCreateRollout;

        private readonly gaxgrpc::ApiCall<UpdateRolloutRequest, Rollout> _callUpdateRollout;

        private readonly gaxgrpc::ApiCall<DeleteRolloutRequest, wkt::Empty> _callDeleteRollout;

        private readonly gaxgrpc::ApiCall<ListRolloutKindsRequest, ListRolloutKindsResponse> _callListRolloutKinds;

        private readonly gaxgrpc::ApiCall<GetRolloutKindRequest, RolloutKind> _callGetRolloutKind;

        private readonly gaxgrpc::ApiCall<CreateRolloutKindRequest, RolloutKind> _callCreateRolloutKind;

        private readonly gaxgrpc::ApiCall<UpdateRolloutKindRequest, RolloutKind> _callUpdateRolloutKind;

        private readonly gaxgrpc::ApiCall<DeleteRolloutKindRequest, wkt::Empty> _callDeleteRolloutKind;

        /// <summary>
        /// Constructs a client wrapper for the SaasRollouts service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SaasRolloutsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SaasRolloutsClientImpl(SaasRollouts.SaasRolloutsClient grpcClient, SaasRolloutsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SaasRolloutsSettings effectiveSettings = settings ?? SaasRolloutsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListRollouts = clientHelper.BuildApiCall<ListRolloutsRequest, ListRolloutsResponse>("ListRollouts", grpcClient.ListRolloutsAsync, grpcClient.ListRollouts, effectiveSettings.ListRolloutsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRollouts);
            Modify_ListRolloutsApiCall(ref _callListRollouts);
            _callGetRollout = clientHelper.BuildApiCall<GetRolloutRequest, Rollout>("GetRollout", grpcClient.GetRolloutAsync, grpcClient.GetRollout, effectiveSettings.GetRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRollout);
            Modify_GetRolloutApiCall(ref _callGetRollout);
            _callCreateRollout = clientHelper.BuildApiCall<CreateRolloutRequest, Rollout>("CreateRollout", grpcClient.CreateRolloutAsync, grpcClient.CreateRollout, effectiveSettings.CreateRolloutSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRollout);
            Modify_CreateRolloutApiCall(ref _callCreateRollout);
            _callUpdateRollout = clientHelper.BuildApiCall<UpdateRolloutRequest, Rollout>("UpdateRollout", grpcClient.UpdateRolloutAsync, grpcClient.UpdateRollout, effectiveSettings.UpdateRolloutSettings).WithGoogleRequestParam("rollout.name", request => request.Rollout?.Name);
            Modify_ApiCall(ref _callUpdateRollout);
            Modify_UpdateRolloutApiCall(ref _callUpdateRollout);
            _callDeleteRollout = clientHelper.BuildApiCall<DeleteRolloutRequest, wkt::Empty>("DeleteRollout", grpcClient.DeleteRolloutAsync, grpcClient.DeleteRollout, effectiveSettings.DeleteRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRollout);
            Modify_DeleteRolloutApiCall(ref _callDeleteRollout);
            _callListRolloutKinds = clientHelper.BuildApiCall<ListRolloutKindsRequest, ListRolloutKindsResponse>("ListRolloutKinds", grpcClient.ListRolloutKindsAsync, grpcClient.ListRolloutKinds, effectiveSettings.ListRolloutKindsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRolloutKinds);
            Modify_ListRolloutKindsApiCall(ref _callListRolloutKinds);
            _callGetRolloutKind = clientHelper.BuildApiCall<GetRolloutKindRequest, RolloutKind>("GetRolloutKind", grpcClient.GetRolloutKindAsync, grpcClient.GetRolloutKind, effectiveSettings.GetRolloutKindSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRolloutKind);
            Modify_GetRolloutKindApiCall(ref _callGetRolloutKind);
            _callCreateRolloutKind = clientHelper.BuildApiCall<CreateRolloutKindRequest, RolloutKind>("CreateRolloutKind", grpcClient.CreateRolloutKindAsync, grpcClient.CreateRolloutKind, effectiveSettings.CreateRolloutKindSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRolloutKind);
            Modify_CreateRolloutKindApiCall(ref _callCreateRolloutKind);
            _callUpdateRolloutKind = clientHelper.BuildApiCall<UpdateRolloutKindRequest, RolloutKind>("UpdateRolloutKind", grpcClient.UpdateRolloutKindAsync, grpcClient.UpdateRolloutKind, effectiveSettings.UpdateRolloutKindSettings).WithGoogleRequestParam("rollout_kind.name", request => request.RolloutKind?.Name);
            Modify_ApiCall(ref _callUpdateRolloutKind);
            Modify_UpdateRolloutKindApiCall(ref _callUpdateRolloutKind);
            _callDeleteRolloutKind = clientHelper.BuildApiCall<DeleteRolloutKindRequest, wkt::Empty>("DeleteRolloutKind", grpcClient.DeleteRolloutKindAsync, grpcClient.DeleteRolloutKind, effectiveSettings.DeleteRolloutKindSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRolloutKind);
            Modify_DeleteRolloutKindApiCall(ref _callDeleteRolloutKind);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListRolloutsApiCall(ref gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> call);

        partial void Modify_GetRolloutApiCall(ref gaxgrpc::ApiCall<GetRolloutRequest, Rollout> call);

        partial void Modify_CreateRolloutApiCall(ref gaxgrpc::ApiCall<CreateRolloutRequest, Rollout> call);

        partial void Modify_UpdateRolloutApiCall(ref gaxgrpc::ApiCall<UpdateRolloutRequest, Rollout> call);

        partial void Modify_DeleteRolloutApiCall(ref gaxgrpc::ApiCall<DeleteRolloutRequest, wkt::Empty> call);

        partial void Modify_ListRolloutKindsApiCall(ref gaxgrpc::ApiCall<ListRolloutKindsRequest, ListRolloutKindsResponse> call);

        partial void Modify_GetRolloutKindApiCall(ref gaxgrpc::ApiCall<GetRolloutKindRequest, RolloutKind> call);

        partial void Modify_CreateRolloutKindApiCall(ref gaxgrpc::ApiCall<CreateRolloutKindRequest, RolloutKind> call);

        partial void Modify_UpdateRolloutKindApiCall(ref gaxgrpc::ApiCall<UpdateRolloutKindRequest, RolloutKind> call);

        partial void Modify_DeleteRolloutKindApiCall(ref gaxgrpc::ApiCall<DeleteRolloutKindRequest, wkt::Empty> call);

        partial void OnConstruction(SaasRollouts.SaasRolloutsClient grpcClient, SaasRolloutsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SaasRollouts client</summary>
        public override SaasRollouts.SaasRolloutsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListRolloutsRequest(ref ListRolloutsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRolloutRequest(ref GetRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRolloutRequest(ref CreateRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRolloutRequest(ref UpdateRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRolloutRequest(ref DeleteRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRolloutKindsRequest(ref ListRolloutKindsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRolloutKindRequest(ref GetRolloutKindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRolloutKindRequest(ref CreateRolloutKindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRolloutKindRequest(ref UpdateRolloutKindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRolloutKindRequest(ref DeleteRolloutKindRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRolloutsRequest, ListRolloutsResponse, Rollout>(_callListRollouts, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollouts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRolloutsRequest, ListRolloutsResponse, Rollout>(_callListRollouts, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rollout GetRollout(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutRequest(ref request, ref callSettings);
            return _callGetRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutRequest(ref request, ref callSettings);
            return _callGetRollout.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rollout CreateRollout(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRolloutRequest(ref request, ref callSettings);
            return _callCreateRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rollout> CreateRolloutAsync(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRolloutRequest(ref request, ref callSettings);
            return _callCreateRollout.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rollout UpdateRollout(UpdateRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRolloutRequest(ref request, ref callSettings);
            return _callUpdateRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rollout> UpdateRolloutAsync(UpdateRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRolloutRequest(ref request, ref callSettings);
            return _callUpdateRollout.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRollout(DeleteRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRolloutRequest(ref request, ref callSettings);
            _callDeleteRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRolloutAsync(DeleteRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRolloutRequest(ref request, ref callSettings);
            return _callDeleteRollout.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RolloutKind"/> resources.</returns>
        public override gax::PagedEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKinds(ListRolloutKindsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutKindsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRolloutKindsRequest, ListRolloutKindsResponse, RolloutKind>(_callListRolloutKinds, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of rollout kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RolloutKind"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRolloutKindsResponse, RolloutKind> ListRolloutKindsAsync(ListRolloutKindsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutKindsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRolloutKindsRequest, ListRolloutKindsResponse, RolloutKind>(_callListRolloutKinds, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RolloutKind GetRolloutKind(GetRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutKindRequest(ref request, ref callSettings);
            return _callGetRolloutKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RolloutKind> GetRolloutKindAsync(GetRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutKindRequest(ref request, ref callSettings);
            return _callGetRolloutKind.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RolloutKind CreateRolloutKind(CreateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRolloutKindRequest(ref request, ref callSettings);
            return _callCreateRolloutKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RolloutKind> CreateRolloutKindAsync(CreateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRolloutKindRequest(ref request, ref callSettings);
            return _callCreateRolloutKind.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RolloutKind UpdateRolloutKind(UpdateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRolloutKindRequest(ref request, ref callSettings);
            return _callUpdateRolloutKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RolloutKind> UpdateRolloutKindAsync(UpdateRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRolloutKindRequest(ref request, ref callSettings);
            return _callUpdateRolloutKind.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRolloutKind(DeleteRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRolloutKindRequest(ref request, ref callSettings);
            _callDeleteRolloutKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single rollout kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRolloutKindAsync(DeleteRolloutKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRolloutKindRequest(ref request, ref callSettings);
            return _callDeleteRolloutKind.Async(request, callSettings);
        }
    }

    public partial class ListRolloutsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRolloutKindsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRolloutsResponse : gaxgrpc::IPageResponse<Rollout>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rollout> GetEnumerator() => Rollouts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRolloutKindsResponse : gaxgrpc::IPageResponse<RolloutKind>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RolloutKind> GetEnumerator() => RolloutKinds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SaasRollouts
    {
        public partial class SaasRolloutsClient
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
