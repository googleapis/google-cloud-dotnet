// Copyright 2022 Google LLC
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

namespace Google.Cloud.ServiceControl.V1
{
    /// <summary>Settings for <see cref="QuotaControllerClient"/> instances.</summary>
    public sealed partial class QuotaControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="QuotaControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="QuotaControllerSettings"/>.</returns>
        public static QuotaControllerSettings GetDefault() => new QuotaControllerSettings();

        /// <summary>Constructs a new <see cref="QuotaControllerSettings"/> object with default settings.</summary>
        public QuotaControllerSettings()
        {
        }

        private QuotaControllerSettings(QuotaControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AllocateQuotaSettings = existing.AllocateQuotaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(QuotaControllerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuotaControllerClient.AllocateQuota</c> and <c>QuotaControllerClient.AllocateQuotaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AllocateQuotaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="QuotaControllerSettings"/> object.</returns>
        public QuotaControllerSettings Clone() => new QuotaControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="QuotaControllerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class QuotaControllerClientBuilder : gaxgrpc::ClientBuilderBase<QuotaControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public QuotaControllerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public QuotaControllerClientBuilder()
        {
            UseJwtAccessWithScopes = QuotaControllerClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref QuotaControllerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<QuotaControllerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override QuotaControllerClient Build()
        {
            QuotaControllerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<QuotaControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<QuotaControllerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private QuotaControllerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return QuotaControllerClient.Create(callInvoker, Settings);
        }

        private async stt::Task<QuotaControllerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return QuotaControllerClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => QuotaControllerClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => QuotaControllerClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => QuotaControllerClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>QuotaController client wrapper, for convenient use.</summary>
    /// <remarks>
    /// [Google Quota Control API](/service-control/overview)
    /// 
    /// Allows clients to allocate and release quota against a [managed
    /// service](https://cloud.google.com/service-management/reference/rpc/google.api/servicemanagement.v1#google.api.servicemanagement.v1.ManagedService).
    /// </remarks>
    public abstract partial class QuotaControllerClient
    {
        /// <summary>
        /// The default endpoint for the QuotaController service, which is a host of "servicecontrol.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "servicecontrol.googleapis.com:443";

        /// <summary>The default QuotaController scopes.</summary>
        /// <remarks>
        /// The default QuotaController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/servicecontrol</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/servicecontrol",
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
        /// Asynchronously creates a <see cref="QuotaControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QuotaControllerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="QuotaControllerClient"/>.</returns>
        public static stt::Task<QuotaControllerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new QuotaControllerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="QuotaControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QuotaControllerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="QuotaControllerClient"/>.</returns>
        public static QuotaControllerClient Create() => new QuotaControllerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="QuotaControllerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="QuotaControllerSettings"/>.</param>
        /// <returns>The created <see cref="QuotaControllerClient"/>.</returns>
        internal static QuotaControllerClient Create(grpccore::CallInvoker callInvoker, QuotaControllerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            QuotaController.QuotaControllerClient grpcClient = new QuotaController.QuotaControllerClient(callInvoker);
            return new QuotaControllerClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC QuotaController client</summary>
        public virtual QuotaController.QuotaControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be called
        /// before the operation is executed.
        /// 
        /// This method requires the `servicemanagement.services.quota`
        /// permission on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// 
        /// **NOTE:** The client **must** fail-open on server errors `INTERNAL`,
        /// `UNKNOWN`, `DEADLINE_EXCEEDED`, and `UNAVAILABLE`. To ensure system
        /// reliability, the server may inject these errors to prohibit any hard
        /// dependency on the quota functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AllocateQuotaResponse AllocateQuota(AllocateQuotaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be called
        /// before the operation is executed.
        /// 
        /// This method requires the `servicemanagement.services.quota`
        /// permission on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// 
        /// **NOTE:** The client **must** fail-open on server errors `INTERNAL`,
        /// `UNKNOWN`, `DEADLINE_EXCEEDED`, and `UNAVAILABLE`. To ensure system
        /// reliability, the server may inject these errors to prohibit any hard
        /// dependency on the quota functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocateQuotaResponse> AllocateQuotaAsync(AllocateQuotaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be called
        /// before the operation is executed.
        /// 
        /// This method requires the `servicemanagement.services.quota`
        /// permission on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// 
        /// **NOTE:** The client **must** fail-open on server errors `INTERNAL`,
        /// `UNKNOWN`, `DEADLINE_EXCEEDED`, and `UNAVAILABLE`. To ensure system
        /// reliability, the server may inject these errors to prohibit any hard
        /// dependency on the quota functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocateQuotaResponse> AllocateQuotaAsync(AllocateQuotaRequest request, st::CancellationToken cancellationToken) =>
            AllocateQuotaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>QuotaController client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// [Google Quota Control API](/service-control/overview)
    /// 
    /// Allows clients to allocate and release quota against a [managed
    /// service](https://cloud.google.com/service-management/reference/rpc/google.api/servicemanagement.v1#google.api.servicemanagement.v1.ManagedService).
    /// </remarks>
    public sealed partial class QuotaControllerClientImpl : QuotaControllerClient
    {
        private readonly gaxgrpc::ApiCall<AllocateQuotaRequest, AllocateQuotaResponse> _callAllocateQuota;

        /// <summary>
        /// Constructs a client wrapper for the QuotaController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="QuotaControllerSettings"/> used within this client.</param>
        public QuotaControllerClientImpl(QuotaController.QuotaControllerClient grpcClient, QuotaControllerSettings settings)
        {
            GrpcClient = grpcClient;
            QuotaControllerSettings effectiveSettings = settings ?? QuotaControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAllocateQuota = clientHelper.BuildApiCall<AllocateQuotaRequest, AllocateQuotaResponse>(grpcClient.AllocateQuotaAsync, grpcClient.AllocateQuota, effectiveSettings.AllocateQuotaSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callAllocateQuota);
            Modify_AllocateQuotaApiCall(ref _callAllocateQuota);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AllocateQuotaApiCall(ref gaxgrpc::ApiCall<AllocateQuotaRequest, AllocateQuotaResponse> call);

        partial void OnConstruction(QuotaController.QuotaControllerClient grpcClient, QuotaControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC QuotaController client</summary>
        public override QuotaController.QuotaControllerClient GrpcClient { get; }

        partial void Modify_AllocateQuotaRequest(ref AllocateQuotaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be called
        /// before the operation is executed.
        /// 
        /// This method requires the `servicemanagement.services.quota`
        /// permission on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// 
        /// **NOTE:** The client **must** fail-open on server errors `INTERNAL`,
        /// `UNKNOWN`, `DEADLINE_EXCEEDED`, and `UNAVAILABLE`. To ensure system
        /// reliability, the server may inject these errors to prohibit any hard
        /// dependency on the quota functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AllocateQuotaResponse AllocateQuota(AllocateQuotaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AllocateQuotaRequest(ref request, ref callSettings);
            return _callAllocateQuota.Sync(request, callSettings);
        }

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be called
        /// before the operation is executed.
        /// 
        /// This method requires the `servicemanagement.services.quota`
        /// permission on the specified service. For more information, see
        /// [Cloud IAM](https://cloud.google.com/iam).
        /// 
        /// **NOTE:** The client **must** fail-open on server errors `INTERNAL`,
        /// `UNKNOWN`, `DEADLINE_EXCEEDED`, and `UNAVAILABLE`. To ensure system
        /// reliability, the server may inject these errors to prohibit any hard
        /// dependency on the quota functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AllocateQuotaResponse> AllocateQuotaAsync(AllocateQuotaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AllocateQuotaRequest(ref request, ref callSettings);
            return _callAllocateQuota.Async(request, callSettings);
        }
    }
}
