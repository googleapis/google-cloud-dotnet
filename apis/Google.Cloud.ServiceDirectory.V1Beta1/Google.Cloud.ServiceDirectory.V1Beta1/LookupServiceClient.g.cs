// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.ServiceDirectory.V1Beta1
{
    /// <summary>Settings for <see cref="LookupServiceClient"/> instances.</summary>
    public sealed partial class LookupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LookupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LookupServiceSettings"/>.</returns>
        public static LookupServiceSettings GetDefault() => new LookupServiceSettings();

        /// <summary>Constructs a new <see cref="LookupServiceSettings"/> object with default settings.</summary>
        public LookupServiceSettings()
        {
        }

        private LookupServiceSettings(LookupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ResolveServiceSettings = existing.ResolveServiceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LookupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LookupServiceClient.ResolveService</c> and <c>LookupServiceClient.ResolveServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResolveServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LookupServiceSettings"/> object.</returns>
        public LookupServiceSettings Clone() => new LookupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LookupServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LookupServiceClientBuilder : gaxgrpc::ClientBuilderBase<LookupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LookupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LookupServiceClientBuilder()
        {
            UseJwtAccessWithScopes = LookupServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref LookupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LookupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LookupServiceClient Build()
        {
            LookupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LookupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LookupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LookupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LookupServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LookupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LookupServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LookupServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LookupServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LookupServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LookupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service Directory API for looking up service data at runtime.
    /// </remarks>
    public abstract partial class LookupServiceClient
    {
        /// <summary>
        /// The default endpoint for the LookupService service, which is a host of "servicedirectory.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "servicedirectory.googleapis.com:443";

        /// <summary>The default LookupService scopes.</summary>
        /// <remarks>
        /// The default LookupService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="LookupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LookupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LookupServiceClient"/>.</returns>
        public static stt::Task<LookupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LookupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LookupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LookupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LookupServiceClient"/>.</returns>
        public static LookupServiceClient Create() => new LookupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LookupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LookupServiceSettings"/>.</param>
        /// <returns>The created <see cref="LookupServiceClient"/>.</returns>
        internal static LookupServiceClient Create(grpccore::CallInvoker callInvoker, LookupServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LookupService.LookupServiceClient grpcClient = new LookupService.LookupServiceClient(callInvoker);
            return new LookupServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LookupService client</summary>
        public virtual LookupService.LookupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [service][google.cloud.servicedirectory.v1beta1.Service] and its
        /// associated endpoints.
        /// Resolving a service is not considered an active developer method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveServiceResponse ResolveService(ResolveServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [service][google.cloud.servicedirectory.v1beta1.Service] and its
        /// associated endpoints.
        /// Resolving a service is not considered an active developer method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveServiceResponse> ResolveServiceAsync(ResolveServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [service][google.cloud.servicedirectory.v1beta1.Service] and its
        /// associated endpoints.
        /// Resolving a service is not considered an active developer method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveServiceResponse> ResolveServiceAsync(ResolveServiceRequest request, st::CancellationToken cancellationToken) =>
            ResolveServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LookupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service Directory API for looking up service data at runtime.
    /// </remarks>
    public sealed partial class LookupServiceClientImpl : LookupServiceClient
    {
        private readonly gaxgrpc::ApiCall<ResolveServiceRequest, ResolveServiceResponse> _callResolveService;

        /// <summary>
        /// Constructs a client wrapper for the LookupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LookupServiceSettings"/> used within this client.</param>
        public LookupServiceClientImpl(LookupService.LookupServiceClient grpcClient, LookupServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LookupServiceSettings effectiveSettings = settings ?? LookupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callResolveService = clientHelper.BuildApiCall<ResolveServiceRequest, ResolveServiceResponse>(grpcClient.ResolveServiceAsync, grpcClient.ResolveService, effectiveSettings.ResolveServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResolveService);
            Modify_ResolveServiceApiCall(ref _callResolveService);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ResolveServiceApiCall(ref gaxgrpc::ApiCall<ResolveServiceRequest, ResolveServiceResponse> call);

        partial void OnConstruction(LookupService.LookupServiceClient grpcClient, LookupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LookupService client</summary>
        public override LookupService.LookupServiceClient GrpcClient { get; }

        partial void Modify_ResolveServiceRequest(ref ResolveServiceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a [service][google.cloud.servicedirectory.v1beta1.Service] and its
        /// associated endpoints.
        /// Resolving a service is not considered an active developer method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResolveServiceResponse ResolveService(ResolveServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveServiceRequest(ref request, ref callSettings);
            return _callResolveService.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a [service][google.cloud.servicedirectory.v1beta1.Service] and its
        /// associated endpoints.
        /// Resolving a service is not considered an active developer method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResolveServiceResponse> ResolveServiceAsync(ResolveServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveServiceRequest(ref request, ref callSettings);
            return _callResolveService.Async(request, callSettings);
        }
    }
}
