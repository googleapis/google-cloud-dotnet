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

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="EvaluationServiceClient"/> instances.</summary>
    public sealed partial class EvaluationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EvaluationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EvaluationServiceSettings"/>.</returns>
        public static EvaluationServiceSettings GetDefault() => new EvaluationServiceSettings();

        /// <summary>Constructs a new <see cref="EvaluationServiceSettings"/> object with default settings.</summary>
        public EvaluationServiceSettings()
        {
        }

        private EvaluationServiceSettings(EvaluationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetEvaluationSettings = existing.GetEvaluationSettings;
            ListEvaluationsSettings = existing.ListEvaluationsSettings;
            CreateEvaluationSettings = existing.CreateEvaluationSettings;
            CreateEvaluationOperationsSettings = existing.CreateEvaluationOperationsSettings.Clone();
            ListEvaluationResultsSettings = existing.ListEvaluationResultsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EvaluationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GetEvaluation</c> and <c>EvaluationServiceClient.GetEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListEvaluations</c> and <c>EvaluationServiceClient.ListEvaluationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.CreateEvaluation</c> and <c>EvaluationServiceClient.CreateEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EvaluationServiceClient.CreateEvaluation</c> and
        /// <c>EvaluationServiceClient.CreateEvaluationAsync</c>.
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
        public lro::OperationsSettings CreateEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListEvaluationResults</c> and
        /// <c>EvaluationServiceClient.ListEvaluationResultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationResultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EvaluationServiceSettings"/> object.</returns>
        public EvaluationServiceSettings Clone() => new EvaluationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EvaluationServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class EvaluationServiceClientBuilder : gaxgrpc::ClientBuilderBase<EvaluationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EvaluationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EvaluationServiceClientBuilder() : base(EvaluationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EvaluationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EvaluationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EvaluationServiceClient Build()
        {
            EvaluationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EvaluationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EvaluationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EvaluationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EvaluationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EvaluationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EvaluationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EvaluationServiceClient.ChannelPool;
    }

    /// <summary>EvaluationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s,
    /// </remarks>
    public abstract partial class EvaluationServiceClient
    {
        /// <summary>
        /// The default endpoint for the EvaluationService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default EvaluationService scopes.</summary>
        /// <remarks>
        /// The default EvaluationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EvaluationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EvaluationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EvaluationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EvaluationServiceClient"/>.</returns>
        public static stt::Task<EvaluationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EvaluationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EvaluationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EvaluationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EvaluationServiceClient"/>.</returns>
        public static EvaluationServiceClient Create() => new EvaluationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EvaluationServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EvaluationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EvaluationServiceClient"/>.</returns>
        internal static EvaluationServiceClient Create(grpccore::CallInvoker callInvoker, EvaluationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EvaluationService.EvaluationServiceClient grpcClient = new EvaluationService.EvaluationServiceClient(callInvoker);
            return new EvaluationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EvaluationService client</summary>
        public virtual EvaluationService.EvaluationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s under this
        /// location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluations(new ListEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s under this
        /// location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationsAsync(new ListEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s under this
        /// location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluations(new ListEvaluationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s under this
        /// location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationsAsync(new ListEvaluationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, CreateEvaluationMetadata> CreateEvaluation(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> CreateEvaluationAsync(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> CreateEvaluationAsync(CreateEvaluationRequest request, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEvaluation</c>.</summary>
        public virtual lro::OperationsClient CreateEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Evaluation, CreateEvaluationMetadata> PollOnceCreateEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, CreateEvaluationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> PollOnceCreateEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, CreateEvaluationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, CreateEvaluationMetadata> CreateEvaluation(string parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> CreateEvaluationAsync(string parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]
        /// to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> CreateEvaluationAsync(string parent, Evaluation evaluation, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, CreateEvaluationMetadata> CreateEvaluation(LocationName parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> CreateEvaluationAsync(LocationName parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="evaluation">
        /// Required. The [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]
        /// to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> CreateEvaluationAsync(LocationName parent, Evaluation evaluation, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResults(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResultsAsync(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="evaluation">
        /// Required. The evaluation resource name, such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to list [EvaluationResult][]
        /// under this evaluation, regardless of whether or not this evaluation
        /// set exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>
        /// A pageable sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResults(string evaluation, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationResults(new ListEvaluationResultsRequest
            {
                Evaluation = gax::GaxPreconditions.CheckNotNullOrEmpty(evaluation, nameof(evaluation)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="evaluation">
        /// Required. The evaluation resource name, such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to list [EvaluationResult][]
        /// under this evaluation, regardless of whether or not this evaluation
        /// set exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResultsAsync(string evaluation, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationResultsAsync(new ListEvaluationResultsRequest
            {
                Evaluation = gax::GaxPreconditions.CheckNotNullOrEmpty(evaluation, nameof(evaluation)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="evaluation">
        /// Required. The evaluation resource name, such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to list [EvaluationResult][]
        /// under this evaluation, regardless of whether or not this evaluation
        /// set exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>
        /// A pageable sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResults(EvaluationName evaluation, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationResults(new ListEvaluationResultsRequest
            {
                EvaluationAsEvaluationName = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="evaluation">
        /// Required. The evaluation resource name, such as
        /// `projects/{project}/locations/{location}/evaluations/{evaluation}`.
        /// 
        /// If the caller does not have permission to list [EvaluationResult][]
        /// under this evaluation, regardless of whether or not this evaluation
        /// set exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResultsAsync(EvaluationName evaluation, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationResultsAsync(new ListEvaluationResultsRequest
            {
                EvaluationAsEvaluationName = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>EvaluationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s,
    /// </remarks>
    public sealed partial class EvaluationServiceClientImpl : EvaluationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> _callGetEvaluation;

        private readonly gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> _callListEvaluations;

        private readonly gaxgrpc::ApiCall<CreateEvaluationRequest, lro::Operation> _callCreateEvaluation;

        private readonly gaxgrpc::ApiCall<ListEvaluationResultsRequest, ListEvaluationResultsResponse> _callListEvaluationResults;

        /// <summary>
        /// Constructs a client wrapper for the EvaluationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EvaluationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EvaluationServiceClientImpl(EvaluationService.EvaluationServiceClient grpcClient, EvaluationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EvaluationServiceSettings effectiveSettings = settings ?? EvaluationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEvaluationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetEvaluation = clientHelper.BuildApiCall<GetEvaluationRequest, Evaluation>("GetEvaluation", grpcClient.GetEvaluationAsync, grpcClient.GetEvaluation, effectiveSettings.GetEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluation);
            Modify_GetEvaluationApiCall(ref _callGetEvaluation);
            _callListEvaluations = clientHelper.BuildApiCall<ListEvaluationsRequest, ListEvaluationsResponse>("ListEvaluations", grpcClient.ListEvaluationsAsync, grpcClient.ListEvaluations, effectiveSettings.ListEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluations);
            Modify_ListEvaluationsApiCall(ref _callListEvaluations);
            _callCreateEvaluation = clientHelper.BuildApiCall<CreateEvaluationRequest, lro::Operation>("CreateEvaluation", grpcClient.CreateEvaluationAsync, grpcClient.CreateEvaluation, effectiveSettings.CreateEvaluationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEvaluation);
            Modify_CreateEvaluationApiCall(ref _callCreateEvaluation);
            _callListEvaluationResults = clientHelper.BuildApiCall<ListEvaluationResultsRequest, ListEvaluationResultsResponse>("ListEvaluationResults", grpcClient.ListEvaluationResultsAsync, grpcClient.ListEvaluationResults, effectiveSettings.ListEvaluationResultsSettings).WithGoogleRequestParam("evaluation", request => request.Evaluation);
            Modify_ApiCall(ref _callListEvaluationResults);
            Modify_ListEvaluationResultsApiCall(ref _callListEvaluationResults);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetEvaluationApiCall(ref gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> call);

        partial void Modify_ListEvaluationsApiCall(ref gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> call);

        partial void Modify_CreateEvaluationApiCall(ref gaxgrpc::ApiCall<CreateEvaluationRequest, lro::Operation> call);

        partial void Modify_ListEvaluationResultsApiCall(ref gaxgrpc::ApiCall<ListEvaluationResultsRequest, ListEvaluationResultsResponse> call);

        partial void OnConstruction(EvaluationService.EvaluationServiceClient grpcClient, EvaluationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EvaluationService client</summary>
        public override EvaluationService.EvaluationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetEvaluationRequest(ref GetEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationsRequest(ref ListEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEvaluationRequest(ref CreateEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationResultsRequest(ref ListEvaluationResultsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRequest(ref request, ref callSettings);
            return _callGetEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRequest(ref request, ref callSettings);
            return _callGetEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationsRequest, ListEvaluationsResponse, Evaluation>(_callListEvaluations, request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationsRequest, ListEvaluationsResponse, Evaluation>(_callListEvaluations, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEvaluation</c>.</summary>
        public override lro::OperationsClient CreateEvaluationOperationsClient { get; }

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Evaluation, CreateEvaluationMetadata> CreateEvaluation(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, CreateEvaluationMetadata>(_callCreateEvaluation.Sync(request, callSettings), CreateEvaluationOperationsClient);
        }

        /// <summary>
        /// Creates a [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// 
        /// Upon creation, the evaluation will be automatically triggered and begin
        /// execution.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Evaluation, CreateEvaluationMetadata>> CreateEvaluationAsync(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, CreateEvaluationMetadata>(await _callCreateEvaluation.Async(request, callSettings).ConfigureAwait(false), CreateEvaluationOperationsClient);
        }

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResults(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationResultsRequest, ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult>(_callListEvaluationResults, request, callSettings);
        }

        /// <summary>
        /// Gets a list of results for a given a
        /// [Evaluation][google.cloud.discoveryengine.v1beta.Evaluation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListEvaluationResultsResponse.Types.EvaluationResult"/>
        /// resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult> ListEvaluationResultsAsync(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationResultsRequest, ListEvaluationResultsResponse, ListEvaluationResultsResponse.Types.EvaluationResult>(_callListEvaluationResults, request, callSettings);
        }
    }

    public partial class ListEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationsResponse : gaxgrpc::IPageResponse<Evaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Evaluation> GetEnumerator() => Evaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEvaluationResultsResponse : gaxgrpc::IPageResponse<ListEvaluationResultsResponse.Types.EvaluationResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.EvaluationResult> GetEnumerator() => EvaluationResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class EvaluationService
    {
        public partial class EvaluationServiceClient
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

    public static partial class EvaluationService
    {
        public partial class EvaluationServiceClient
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
