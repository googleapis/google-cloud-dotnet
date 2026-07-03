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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="FindingsRefinementServiceClient"/> instances.</summary>
    public sealed partial class FindingsRefinementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FindingsRefinementServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FindingsRefinementServiceSettings"/>.</returns>
        public static FindingsRefinementServiceSettings GetDefault() => new FindingsRefinementServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FindingsRefinementServiceSettings"/> object with default settings.
        /// </summary>
        public FindingsRefinementServiceSettings()
        {
        }

        private FindingsRefinementServiceSettings(FindingsRefinementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFindingsRefinementSettings = existing.GetFindingsRefinementSettings;
            ListFindingsRefinementsSettings = existing.ListFindingsRefinementsSettings;
            CreateFindingsRefinementSettings = existing.CreateFindingsRefinementSettings;
            UpdateFindingsRefinementSettings = existing.UpdateFindingsRefinementSettings;
            GetFindingsRefinementDeploymentSettings = existing.GetFindingsRefinementDeploymentSettings;
            UpdateFindingsRefinementDeploymentSettings = existing.UpdateFindingsRefinementDeploymentSettings;
            ListAllFindingsRefinementDeploymentsSettings = existing.ListAllFindingsRefinementDeploymentsSettings;
            ComputeFindingsRefinementActivitySettings = existing.ComputeFindingsRefinementActivitySettings;
            ComputeAllFindingsRefinementActivitiesSettings = existing.ComputeAllFindingsRefinementActivitiesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FindingsRefinementServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.GetFindingsRefinement</c> and
        /// <c>FindingsRefinementServiceClient.GetFindingsRefinementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFindingsRefinementSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.ListFindingsRefinements</c> and
        /// <c>FindingsRefinementServiceClient.ListFindingsRefinementsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFindingsRefinementsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.CreateFindingsRefinement</c> and
        /// <c>FindingsRefinementServiceClient.CreateFindingsRefinementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFindingsRefinementSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.UpdateFindingsRefinement</c> and
        /// <c>FindingsRefinementServiceClient.UpdateFindingsRefinementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFindingsRefinementSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.GetFindingsRefinementDeployment</c> and
        /// <c>FindingsRefinementServiceClient.GetFindingsRefinementDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFindingsRefinementDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.UpdateFindingsRefinementDeployment</c> and
        /// <c>FindingsRefinementServiceClient.UpdateFindingsRefinementDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFindingsRefinementDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.ListAllFindingsRefinementDeployments</c> and
        /// <c>FindingsRefinementServiceClient.ListAllFindingsRefinementDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAllFindingsRefinementDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.ComputeFindingsRefinementActivity</c> and
        /// <c>FindingsRefinementServiceClient.ComputeFindingsRefinementActivityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeFindingsRefinementActivitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(600000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FindingsRefinementServiceClient.ComputeAllFindingsRefinementActivities</c> and
        /// <c>FindingsRefinementServiceClient.ComputeAllFindingsRefinementActivitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeAllFindingsRefinementActivitiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(600000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FindingsRefinementServiceSettings"/> object.</returns>
        public FindingsRefinementServiceSettings Clone() => new FindingsRefinementServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FindingsRefinementServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class FindingsRefinementServiceClientBuilder : gaxgrpc::ClientBuilderBase<FindingsRefinementServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FindingsRefinementServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FindingsRefinementServiceClientBuilder() : base(FindingsRefinementServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FindingsRefinementServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FindingsRefinementServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FindingsRefinementServiceClient Build()
        {
            FindingsRefinementServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FindingsRefinementServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FindingsRefinementServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FindingsRefinementServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FindingsRefinementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FindingsRefinementServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FindingsRefinementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FindingsRefinementServiceClient.ChannelPool;
    }

    /// <summary>FindingsRefinementService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// FindingsRefinementService provides an interface for filtering out
    /// findings that are unlikely to be real threats to prevent them
    /// from triggering alerts or notifications.
    /// </remarks>
    public abstract partial class FindingsRefinementServiceClient
    {
        /// <summary>
        /// The default endpoint for the FindingsRefinementService service, which is a host of
        /// "chronicle.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default FindingsRefinementService scopes.</summary>
        /// <remarks>
        /// The default FindingsRefinementService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/chronicle</description></item>
        /// <item><description>https://www.googleapis.com/auth/chronicle.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/chronicle",
            "https://www.googleapis.com/auth/chronicle.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FindingsRefinementService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FindingsRefinementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FindingsRefinementServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FindingsRefinementServiceClient"/>.</returns>
        public static stt::Task<FindingsRefinementServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FindingsRefinementServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FindingsRefinementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FindingsRefinementServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FindingsRefinementServiceClient"/>.</returns>
        public static FindingsRefinementServiceClient Create() => new FindingsRefinementServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FindingsRefinementServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FindingsRefinementServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FindingsRefinementServiceClient"/>.</returns>
        internal static FindingsRefinementServiceClient Create(grpccore::CallInvoker callInvoker, FindingsRefinementServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FindingsRefinementService.FindingsRefinementServiceClient grpcClient = new FindingsRefinementService.FindingsRefinementServiceClient(callInvoker);
            return new FindingsRefinementServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FindingsRefinementService client</summary>
        public virtual FindingsRefinementService.FindingsRefinementServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement GetFindingsRefinement(GetFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> GetFindingsRefinementAsync(GetFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> GetFindingsRefinementAsync(GetFindingsRefinementRequest request, st::CancellationToken cancellationToken) =>
            GetFindingsRefinementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement GetFindingsRefinement(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinement(new GetFindingsRefinementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> GetFindingsRefinementAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinementAsync(new GetFindingsRefinementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> GetFindingsRefinementAsync(string name, st::CancellationToken cancellationToken) =>
            GetFindingsRefinementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement GetFindingsRefinement(FindingsRefinementName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinement(new GetFindingsRefinementRequest
            {
                FindingsRefinementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> GetFindingsRefinementAsync(FindingsRefinementName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinementAsync(new GetFindingsRefinementRequest
            {
                FindingsRefinementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> GetFindingsRefinementAsync(FindingsRefinementName name, st::CancellationToken cancellationToken) =>
            GetFindingsRefinementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinements(ListFindingsRefinementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinementsAsync(ListFindingsRefinementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of findings refinements.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinements(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRefinementsRequest request = new ListFindingsRefinementsRequest
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
            return ListFindingsRefinements(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of findings refinements.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinementsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRefinementsRequest request = new ListFindingsRefinementsRequest
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
            return ListFindingsRefinementsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of findings refinements.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinements(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRefinementsRequest request = new ListFindingsRefinementsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingsRefinements(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of findings refinements.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinementsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRefinementsRequest request = new ListFindingsRefinementsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingsRefinementsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement CreateFindingsRefinement(CreateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> CreateFindingsRefinementAsync(CreateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> CreateFindingsRefinementAsync(CreateFindingsRefinementRequest request, st::CancellationToken cancellationToken) =>
            CreateFindingsRefinementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this findings refinement will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement CreateFindingsRefinement(string parent, FindingsRefinement findingsRefinement, gaxgrpc::CallSettings callSettings = null) =>
            CreateFindingsRefinement(new CreateFindingsRefinementRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FindingsRefinement = gax::GaxPreconditions.CheckNotNull(findingsRefinement, nameof(findingsRefinement)),
            }, callSettings);

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this findings refinement will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> CreateFindingsRefinementAsync(string parent, FindingsRefinement findingsRefinement, gaxgrpc::CallSettings callSettings = null) =>
            CreateFindingsRefinementAsync(new CreateFindingsRefinementRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FindingsRefinement = gax::GaxPreconditions.CheckNotNull(findingsRefinement, nameof(findingsRefinement)),
            }, callSettings);

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this findings refinement will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> CreateFindingsRefinementAsync(string parent, FindingsRefinement findingsRefinement, st::CancellationToken cancellationToken) =>
            CreateFindingsRefinementAsync(parent, findingsRefinement, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this findings refinement will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement CreateFindingsRefinement(InstanceName parent, FindingsRefinement findingsRefinement, gaxgrpc::CallSettings callSettings = null) =>
            CreateFindingsRefinement(new CreateFindingsRefinementRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FindingsRefinement = gax::GaxPreconditions.CheckNotNull(findingsRefinement, nameof(findingsRefinement)),
            }, callSettings);

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this findings refinement will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> CreateFindingsRefinementAsync(InstanceName parent, FindingsRefinement findingsRefinement, gaxgrpc::CallSettings callSettings = null) =>
            CreateFindingsRefinementAsync(new CreateFindingsRefinementRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FindingsRefinement = gax::GaxPreconditions.CheckNotNull(findingsRefinement, nameof(findingsRefinement)),
            }, callSettings);

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this findings refinement will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> CreateFindingsRefinementAsync(InstanceName parent, FindingsRefinement findingsRefinement, st::CancellationToken cancellationToken) =>
            CreateFindingsRefinementAsync(parent, findingsRefinement, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement UpdateFindingsRefinement(UpdateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> UpdateFindingsRefinementAsync(UpdateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> UpdateFindingsRefinementAsync(UpdateFindingsRefinementRequest request, st::CancellationToken cancellationToken) =>
            UpdateFindingsRefinementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to update.
        /// 
        /// The findings refinement's `name` field is used to identify the findings
        /// refinement to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If `*` is provided, all fields will
        /// be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinement UpdateFindingsRefinement(FindingsRefinement findingsRefinement, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFindingsRefinement(new UpdateFindingsRefinementRequest
            {
                FindingsRefinement = gax::GaxPreconditions.CheckNotNull(findingsRefinement, nameof(findingsRefinement)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to update.
        /// 
        /// The findings refinement's `name` field is used to identify the findings
        /// refinement to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If `*` is provided, all fields will
        /// be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> UpdateFindingsRefinementAsync(FindingsRefinement findingsRefinement, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFindingsRefinementAsync(new UpdateFindingsRefinementRequest
            {
                FindingsRefinement = gax::GaxPreconditions.CheckNotNull(findingsRefinement, nameof(findingsRefinement)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="findingsRefinement">
        /// Required. The findings refinement to update.
        /// 
        /// The findings refinement's `name` field is used to identify the findings
        /// refinement to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If `*` is provided, all fields will
        /// be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinement> UpdateFindingsRefinementAsync(FindingsRefinement findingsRefinement, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFindingsRefinementAsync(findingsRefinement, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinementDeployment GetFindingsRefinementDeployment(GetFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> GetFindingsRefinementDeploymentAsync(GetFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> GetFindingsRefinementDeploymentAsync(GetFindingsRefinementDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetFindingsRefinementDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinementDeployment GetFindingsRefinementDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinementDeployment(new GetFindingsRefinementDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> GetFindingsRefinementDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinementDeploymentAsync(new GetFindingsRefinementDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> GetFindingsRefinementDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetFindingsRefinementDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinementDeployment GetFindingsRefinementDeployment(FindingsRefinementDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinementDeployment(new GetFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> GetFindingsRefinementDeploymentAsync(FindingsRefinementDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingsRefinementDeploymentAsync(new GetFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the findings refinement to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> GetFindingsRefinementDeploymentAsync(FindingsRefinementDeploymentName name, st::CancellationToken cancellationToken) =>
            GetFindingsRefinementDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinementDeployment UpdateFindingsRefinementDeployment(UpdateFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> UpdateFindingsRefinementDeploymentAsync(UpdateFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> UpdateFindingsRefinementDeploymentAsync(UpdateFindingsRefinementDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateFindingsRefinementDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="findingsRefinementDeployment">
        /// Required. The findings refinement deployment to update.
        /// 
        /// The findings refinement deployment's `name` field is used to identify the
        /// findings refinement deployment to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. If `*` is provided, all fields will
        /// be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindingsRefinementDeployment UpdateFindingsRefinementDeployment(FindingsRefinementDeployment findingsRefinementDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFindingsRefinementDeployment(new UpdateFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeployment = gax::GaxPreconditions.CheckNotNull(findingsRefinementDeployment, nameof(findingsRefinementDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="findingsRefinementDeployment">
        /// Required. The findings refinement deployment to update.
        /// 
        /// The findings refinement deployment's `name` field is used to identify the
        /// findings refinement deployment to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. If `*` is provided, all fields will
        /// be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> UpdateFindingsRefinementDeploymentAsync(FindingsRefinementDeployment findingsRefinementDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFindingsRefinementDeploymentAsync(new UpdateFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeployment = gax::GaxPreconditions.CheckNotNull(findingsRefinementDeployment, nameof(findingsRefinementDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="findingsRefinementDeployment">
        /// Required. The findings refinement deployment to update.
        /// 
        /// The findings refinement deployment's `name` field is used to identify the
        /// findings refinement deployment to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. If `*` is provided, all fields will
        /// be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindingsRefinementDeployment> UpdateFindingsRefinementDeploymentAsync(FindingsRefinementDeployment findingsRefinementDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFindingsRefinementDeploymentAsync(findingsRefinementDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeployments(ListAllFindingsRefinementDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeploymentsAsync(ListAllFindingsRefinementDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="instance">
        /// Required. The name of the parent resource, which is the SecOps instance to
        /// list all findings refinement deployments over. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeployments(string instance, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFindingsRefinementDeploymentsRequest request = new ListAllFindingsRefinementDeploymentsRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAllFindingsRefinementDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="instance">
        /// Required. The name of the parent resource, which is the SecOps instance to
        /// list all findings refinement deployments over. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeploymentsAsync(string instance, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFindingsRefinementDeploymentsRequest request = new ListAllFindingsRefinementDeploymentsRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAllFindingsRefinementDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="instance">
        /// Required. The name of the parent resource, which is the SecOps instance to
        /// list all findings refinement deployments over. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeployments(InstanceName instance, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFindingsRefinementDeploymentsRequest request = new ListAllFindingsRefinementDeploymentsRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAllFindingsRefinementDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="instance">
        /// Required. The name of the parent resource, which is the SecOps instance to
        /// list all findings refinement deployments over. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeploymentsAsync(InstanceName instance, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAllFindingsRefinementDeploymentsRequest request = new ListAllFindingsRefinementDeploymentsRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAllFindingsRefinementDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeFindingsRefinementActivityResponse ComputeFindingsRefinementActivity(ComputeFindingsRefinementActivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeFindingsRefinementActivityResponse> ComputeFindingsRefinementActivityAsync(ComputeFindingsRefinementActivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeFindingsRefinementActivityResponse> ComputeFindingsRefinementActivityAsync(ComputeFindingsRefinementActivityRequest request, st::CancellationToken cancellationToken) =>
            ComputeFindingsRefinementActivityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name for the findings refinement to fetch the
        /// activity for. Format:
        /// projects/{project}/locations/{region}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeFindingsRefinementActivityResponse ComputeFindingsRefinementActivity(string name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeFindingsRefinementActivity(new ComputeFindingsRefinementActivityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name for the findings refinement to fetch the
        /// activity for. Format:
        /// projects/{project}/locations/{region}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeFindingsRefinementActivityResponse> ComputeFindingsRefinementActivityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeFindingsRefinementActivityAsync(new ComputeFindingsRefinementActivityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name for the findings refinement to fetch the
        /// activity for. Format:
        /// projects/{project}/locations/{region}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeFindingsRefinementActivityResponse> ComputeFindingsRefinementActivityAsync(string name, st::CancellationToken cancellationToken) =>
            ComputeFindingsRefinementActivityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name for the findings refinement to fetch the
        /// activity for. Format:
        /// projects/{project}/locations/{region}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeFindingsRefinementActivityResponse ComputeFindingsRefinementActivity(FindingsRefinementName name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeFindingsRefinementActivity(new ComputeFindingsRefinementActivityRequest
            {
                FindingsRefinementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name for the findings refinement to fetch the
        /// activity for. Format:
        /// projects/{project}/locations/{region}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeFindingsRefinementActivityResponse> ComputeFindingsRefinementActivityAsync(FindingsRefinementName name, gaxgrpc::CallSettings callSettings = null) =>
            ComputeFindingsRefinementActivityAsync(new ComputeFindingsRefinementActivityRequest
            {
                FindingsRefinementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name for the findings refinement to fetch the
        /// activity for. Format:
        /// projects/{project}/locations/{region}/instances/{instance}/findingsRefinements/{findings_refinement}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeFindingsRefinementActivityResponse> ComputeFindingsRefinementActivityAsync(FindingsRefinementName name, st::CancellationToken cancellationToken) =>
            ComputeFindingsRefinementActivityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeAllFindingsRefinementActivitiesResponse ComputeAllFindingsRefinementActivities(ComputeAllFindingsRefinementActivitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeAllFindingsRefinementActivitiesResponse> ComputeAllFindingsRefinementActivitiesAsync(ComputeAllFindingsRefinementActivitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeAllFindingsRefinementActivitiesResponse> ComputeAllFindingsRefinementActivitiesAsync(ComputeAllFindingsRefinementActivitiesRequest request, st::CancellationToken cancellationToken) =>
            ComputeAllFindingsRefinementActivitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="instance">
        /// Required. The ID of the Instance to retrieve counts for.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeAllFindingsRefinementActivitiesResponse ComputeAllFindingsRefinementActivities(string instance, gaxgrpc::CallSettings callSettings = null) =>
            ComputeAllFindingsRefinementActivities(new ComputeAllFindingsRefinementActivitiesRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="instance">
        /// Required. The ID of the Instance to retrieve counts for.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeAllFindingsRefinementActivitiesResponse> ComputeAllFindingsRefinementActivitiesAsync(string instance, gaxgrpc::CallSettings callSettings = null) =>
            ComputeAllFindingsRefinementActivitiesAsync(new ComputeAllFindingsRefinementActivitiesRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="instance">
        /// Required. The ID of the Instance to retrieve counts for.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeAllFindingsRefinementActivitiesResponse> ComputeAllFindingsRefinementActivitiesAsync(string instance, st::CancellationToken cancellationToken) =>
            ComputeAllFindingsRefinementActivitiesAsync(instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="instance">
        /// Required. The ID of the Instance to retrieve counts for.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeAllFindingsRefinementActivitiesResponse ComputeAllFindingsRefinementActivities(InstanceName instance, gaxgrpc::CallSettings callSettings = null) =>
            ComputeAllFindingsRefinementActivities(new ComputeAllFindingsRefinementActivitiesRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="instance">
        /// Required. The ID of the Instance to retrieve counts for.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeAllFindingsRefinementActivitiesResponse> ComputeAllFindingsRefinementActivitiesAsync(InstanceName instance, gaxgrpc::CallSettings callSettings = null) =>
            ComputeAllFindingsRefinementActivitiesAsync(new ComputeAllFindingsRefinementActivitiesRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="instance">
        /// Required. The ID of the Instance to retrieve counts for.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeAllFindingsRefinementActivitiesResponse> ComputeAllFindingsRefinementActivitiesAsync(InstanceName instance, st::CancellationToken cancellationToken) =>
            ComputeAllFindingsRefinementActivitiesAsync(instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FindingsRefinementService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// FindingsRefinementService provides an interface for filtering out
    /// findings that are unlikely to be real threats to prevent them
    /// from triggering alerts or notifications.
    /// </remarks>
    public sealed partial class FindingsRefinementServiceClientImpl : FindingsRefinementServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFindingsRefinementRequest, FindingsRefinement> _callGetFindingsRefinement;

        private readonly gaxgrpc::ApiCall<ListFindingsRefinementsRequest, ListFindingsRefinementsResponse> _callListFindingsRefinements;

        private readonly gaxgrpc::ApiCall<CreateFindingsRefinementRequest, FindingsRefinement> _callCreateFindingsRefinement;

        private readonly gaxgrpc::ApiCall<UpdateFindingsRefinementRequest, FindingsRefinement> _callUpdateFindingsRefinement;

        private readonly gaxgrpc::ApiCall<GetFindingsRefinementDeploymentRequest, FindingsRefinementDeployment> _callGetFindingsRefinementDeployment;

        private readonly gaxgrpc::ApiCall<UpdateFindingsRefinementDeploymentRequest, FindingsRefinementDeployment> _callUpdateFindingsRefinementDeployment;

        private readonly gaxgrpc::ApiCall<ListAllFindingsRefinementDeploymentsRequest, ListAllFindingsRefinementDeploymentsResponse> _callListAllFindingsRefinementDeployments;

        private readonly gaxgrpc::ApiCall<ComputeFindingsRefinementActivityRequest, ComputeFindingsRefinementActivityResponse> _callComputeFindingsRefinementActivity;

        private readonly gaxgrpc::ApiCall<ComputeAllFindingsRefinementActivitiesRequest, ComputeAllFindingsRefinementActivitiesResponse> _callComputeAllFindingsRefinementActivities;

        /// <summary>
        /// Constructs a client wrapper for the FindingsRefinementService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FindingsRefinementServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FindingsRefinementServiceClientImpl(FindingsRefinementService.FindingsRefinementServiceClient grpcClient, FindingsRefinementServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FindingsRefinementServiceSettings effectiveSettings = settings ?? FindingsRefinementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetFindingsRefinement = clientHelper.BuildApiCall<GetFindingsRefinementRequest, FindingsRefinement>("GetFindingsRefinement", grpcClient.GetFindingsRefinementAsync, grpcClient.GetFindingsRefinement, effectiveSettings.GetFindingsRefinementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFindingsRefinement);
            Modify_GetFindingsRefinementApiCall(ref _callGetFindingsRefinement);
            _callListFindingsRefinements = clientHelper.BuildApiCall<ListFindingsRefinementsRequest, ListFindingsRefinementsResponse>("ListFindingsRefinements", grpcClient.ListFindingsRefinementsAsync, grpcClient.ListFindingsRefinements, effectiveSettings.ListFindingsRefinementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFindingsRefinements);
            Modify_ListFindingsRefinementsApiCall(ref _callListFindingsRefinements);
            _callCreateFindingsRefinement = clientHelper.BuildApiCall<CreateFindingsRefinementRequest, FindingsRefinement>("CreateFindingsRefinement", grpcClient.CreateFindingsRefinementAsync, grpcClient.CreateFindingsRefinement, effectiveSettings.CreateFindingsRefinementSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFindingsRefinement);
            Modify_CreateFindingsRefinementApiCall(ref _callCreateFindingsRefinement);
            _callUpdateFindingsRefinement = clientHelper.BuildApiCall<UpdateFindingsRefinementRequest, FindingsRefinement>("UpdateFindingsRefinement", grpcClient.UpdateFindingsRefinementAsync, grpcClient.UpdateFindingsRefinement, effectiveSettings.UpdateFindingsRefinementSettings).WithGoogleRequestParam("findings_refinement.name", request => request.FindingsRefinement?.Name);
            Modify_ApiCall(ref _callUpdateFindingsRefinement);
            Modify_UpdateFindingsRefinementApiCall(ref _callUpdateFindingsRefinement);
            _callGetFindingsRefinementDeployment = clientHelper.BuildApiCall<GetFindingsRefinementDeploymentRequest, FindingsRefinementDeployment>("GetFindingsRefinementDeployment", grpcClient.GetFindingsRefinementDeploymentAsync, grpcClient.GetFindingsRefinementDeployment, effectiveSettings.GetFindingsRefinementDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFindingsRefinementDeployment);
            Modify_GetFindingsRefinementDeploymentApiCall(ref _callGetFindingsRefinementDeployment);
            _callUpdateFindingsRefinementDeployment = clientHelper.BuildApiCall<UpdateFindingsRefinementDeploymentRequest, FindingsRefinementDeployment>("UpdateFindingsRefinementDeployment", grpcClient.UpdateFindingsRefinementDeploymentAsync, grpcClient.UpdateFindingsRefinementDeployment, effectiveSettings.UpdateFindingsRefinementDeploymentSettings).WithGoogleRequestParam("findings_refinement_deployment.name", request => request.FindingsRefinementDeployment?.Name);
            Modify_ApiCall(ref _callUpdateFindingsRefinementDeployment);
            Modify_UpdateFindingsRefinementDeploymentApiCall(ref _callUpdateFindingsRefinementDeployment);
            _callListAllFindingsRefinementDeployments = clientHelper.BuildApiCall<ListAllFindingsRefinementDeploymentsRequest, ListAllFindingsRefinementDeploymentsResponse>("ListAllFindingsRefinementDeployments", grpcClient.ListAllFindingsRefinementDeploymentsAsync, grpcClient.ListAllFindingsRefinementDeployments, effectiveSettings.ListAllFindingsRefinementDeploymentsSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callListAllFindingsRefinementDeployments);
            Modify_ListAllFindingsRefinementDeploymentsApiCall(ref _callListAllFindingsRefinementDeployments);
            _callComputeFindingsRefinementActivity = clientHelper.BuildApiCall<ComputeFindingsRefinementActivityRequest, ComputeFindingsRefinementActivityResponse>("ComputeFindingsRefinementActivity", grpcClient.ComputeFindingsRefinementActivityAsync, grpcClient.ComputeFindingsRefinementActivity, effectiveSettings.ComputeFindingsRefinementActivitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callComputeFindingsRefinementActivity);
            Modify_ComputeFindingsRefinementActivityApiCall(ref _callComputeFindingsRefinementActivity);
            _callComputeAllFindingsRefinementActivities = clientHelper.BuildApiCall<ComputeAllFindingsRefinementActivitiesRequest, ComputeAllFindingsRefinementActivitiesResponse>("ComputeAllFindingsRefinementActivities", grpcClient.ComputeAllFindingsRefinementActivitiesAsync, grpcClient.ComputeAllFindingsRefinementActivities, effectiveSettings.ComputeAllFindingsRefinementActivitiesSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callComputeAllFindingsRefinementActivities);
            Modify_ComputeAllFindingsRefinementActivitiesApiCall(ref _callComputeAllFindingsRefinementActivities);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFindingsRefinementApiCall(ref gaxgrpc::ApiCall<GetFindingsRefinementRequest, FindingsRefinement> call);

        partial void Modify_ListFindingsRefinementsApiCall(ref gaxgrpc::ApiCall<ListFindingsRefinementsRequest, ListFindingsRefinementsResponse> call);

        partial void Modify_CreateFindingsRefinementApiCall(ref gaxgrpc::ApiCall<CreateFindingsRefinementRequest, FindingsRefinement> call);

        partial void Modify_UpdateFindingsRefinementApiCall(ref gaxgrpc::ApiCall<UpdateFindingsRefinementRequest, FindingsRefinement> call);

        partial void Modify_GetFindingsRefinementDeploymentApiCall(ref gaxgrpc::ApiCall<GetFindingsRefinementDeploymentRequest, FindingsRefinementDeployment> call);

        partial void Modify_UpdateFindingsRefinementDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateFindingsRefinementDeploymentRequest, FindingsRefinementDeployment> call);

        partial void Modify_ListAllFindingsRefinementDeploymentsApiCall(ref gaxgrpc::ApiCall<ListAllFindingsRefinementDeploymentsRequest, ListAllFindingsRefinementDeploymentsResponse> call);

        partial void Modify_ComputeFindingsRefinementActivityApiCall(ref gaxgrpc::ApiCall<ComputeFindingsRefinementActivityRequest, ComputeFindingsRefinementActivityResponse> call);

        partial void Modify_ComputeAllFindingsRefinementActivitiesApiCall(ref gaxgrpc::ApiCall<ComputeAllFindingsRefinementActivitiesRequest, ComputeAllFindingsRefinementActivitiesResponse> call);

        partial void OnConstruction(FindingsRefinementService.FindingsRefinementServiceClient grpcClient, FindingsRefinementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FindingsRefinementService client</summary>
        public override FindingsRefinementService.FindingsRefinementServiceClient GrpcClient { get; }

        partial void Modify_GetFindingsRefinementRequest(ref GetFindingsRefinementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFindingsRefinementsRequest(ref ListFindingsRefinementsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFindingsRefinementRequest(ref CreateFindingsRefinementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFindingsRefinementRequest(ref UpdateFindingsRefinementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFindingsRefinementDeploymentRequest(ref GetFindingsRefinementDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFindingsRefinementDeploymentRequest(ref UpdateFindingsRefinementDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAllFindingsRefinementDeploymentsRequest(ref ListAllFindingsRefinementDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComputeFindingsRefinementActivityRequest(ref ComputeFindingsRefinementActivityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComputeAllFindingsRefinementActivitiesRequest(ref ComputeAllFindingsRefinementActivitiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindingsRefinement GetFindingsRefinement(GetFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingsRefinementRequest(ref request, ref callSettings);
            return _callGetFindingsRefinement.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindingsRefinement> GetFindingsRefinementAsync(GetFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingsRefinementRequest(ref request, ref callSettings);
            return _callGetFindingsRefinement.Async(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public override gax::PagedEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinements(ListFindingsRefinementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRefinementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFindingsRefinementsRequest, ListFindingsRefinementsResponse, FindingsRefinement>(_callListFindingsRefinements, request, callSettings);
        }

        /// <summary>
        /// Lists a collection of findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinement"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> ListFindingsRefinementsAsync(ListFindingsRefinementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRefinementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFindingsRefinementsRequest, ListFindingsRefinementsResponse, FindingsRefinement>(_callListFindingsRefinements, request, callSettings);
        }

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindingsRefinement CreateFindingsRefinement(CreateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFindingsRefinementRequest(ref request, ref callSettings);
            return _callCreateFindingsRefinement.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindingsRefinement> CreateFindingsRefinementAsync(CreateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFindingsRefinementRequest(ref request, ref callSettings);
            return _callCreateFindingsRefinement.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindingsRefinement UpdateFindingsRefinement(UpdateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingsRefinementRequest(ref request, ref callSettings);
            return _callUpdateFindingsRefinement.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindingsRefinement> UpdateFindingsRefinementAsync(UpdateFindingsRefinementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingsRefinementRequest(ref request, ref callSettings);
            return _callUpdateFindingsRefinement.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindingsRefinementDeployment GetFindingsRefinementDeployment(GetFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingsRefinementDeploymentRequest(ref request, ref callSettings);
            return _callGetFindingsRefinementDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindingsRefinementDeployment> GetFindingsRefinementDeploymentAsync(GetFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingsRefinementDeploymentRequest(ref request, ref callSettings);
            return _callGetFindingsRefinementDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindingsRefinementDeployment UpdateFindingsRefinementDeployment(UpdateFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingsRefinementDeploymentRequest(ref request, ref callSettings);
            return _callUpdateFindingsRefinementDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a findings refinement deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindingsRefinementDeployment> UpdateFindingsRefinementDeploymentAsync(UpdateFindingsRefinementDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingsRefinementDeploymentRequest(ref request, ref callSettings);
            return _callUpdateFindingsRefinementDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeployments(ListAllFindingsRefinementDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAllFindingsRefinementDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAllFindingsRefinementDeploymentsRequest, ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment>(_callListAllFindingsRefinementDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists all findings refinement deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FindingsRefinementDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> ListAllFindingsRefinementDeploymentsAsync(ListAllFindingsRefinementDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAllFindingsRefinementDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsRequest, ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment>(_callListAllFindingsRefinementDeployments, request, callSettings);
        }

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeFindingsRefinementActivityResponse ComputeFindingsRefinementActivity(ComputeFindingsRefinementActivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeFindingsRefinementActivityRequest(ref request, ref callSettings);
            return _callComputeFindingsRefinementActivity.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns findings refinement activity for a specific findings refinement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeFindingsRefinementActivityResponse> ComputeFindingsRefinementActivityAsync(ComputeFindingsRefinementActivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeFindingsRefinementActivityRequest(ref request, ref callSettings);
            return _callComputeFindingsRefinementActivity.Async(request, callSettings);
        }

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeAllFindingsRefinementActivitiesResponse ComputeAllFindingsRefinementActivities(ComputeAllFindingsRefinementActivitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeAllFindingsRefinementActivitiesRequest(ref request, ref callSettings);
            return _callComputeAllFindingsRefinementActivities.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns findings refinement activity for all findings refinements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeAllFindingsRefinementActivitiesResponse> ComputeAllFindingsRefinementActivitiesAsync(ComputeAllFindingsRefinementActivitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeAllFindingsRefinementActivitiesRequest(ref request, ref callSettings);
            return _callComputeAllFindingsRefinementActivities.Async(request, callSettings);
        }
    }

    public partial class ListFindingsRefinementsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAllFindingsRefinementDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFindingsRefinementsResponse : gaxgrpc::IPageResponse<FindingsRefinement>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FindingsRefinement> GetEnumerator() => FindingsRefinements.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAllFindingsRefinementDeploymentsResponse : gaxgrpc::IPageResponse<FindingsRefinementDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FindingsRefinementDeployment> GetEnumerator() =>
            AllFindingsRefinementDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
