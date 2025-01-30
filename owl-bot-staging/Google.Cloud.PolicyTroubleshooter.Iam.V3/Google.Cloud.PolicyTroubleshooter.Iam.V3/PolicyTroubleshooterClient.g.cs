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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.PolicyTroubleshooter.Iam.V3
{
    /// <summary>Settings for <see cref="PolicyTroubleshooterClient"/> instances.</summary>
    public sealed partial class PolicyTroubleshooterSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PolicyTroubleshooterSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PolicyTroubleshooterSettings"/>.</returns>
        public static PolicyTroubleshooterSettings GetDefault() => new PolicyTroubleshooterSettings();

        /// <summary>Constructs a new <see cref="PolicyTroubleshooterSettings"/> object with default settings.</summary>
        public PolicyTroubleshooterSettings()
        {
        }

        private PolicyTroubleshooterSettings(PolicyTroubleshooterSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            TroubleshootIamPolicySettings = existing.TroubleshootIamPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(PolicyTroubleshooterSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTroubleshooterClient.TroubleshootIamPolicy</c> and
        /// <c>PolicyTroubleshooterClient.TroubleshootIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings TroubleshootIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PolicyTroubleshooterSettings"/> object.</returns>
        public PolicyTroubleshooterSettings Clone() => new PolicyTroubleshooterSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PolicyTroubleshooterClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PolicyTroubleshooterClientBuilder : gaxgrpc::ClientBuilderBase<PolicyTroubleshooterClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PolicyTroubleshooterSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PolicyTroubleshooterClientBuilder() : base(PolicyTroubleshooterClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PolicyTroubleshooterClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PolicyTroubleshooterClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PolicyTroubleshooterClient Build()
        {
            PolicyTroubleshooterClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PolicyTroubleshooterClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PolicyTroubleshooterClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PolicyTroubleshooterClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PolicyTroubleshooterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PolicyTroubleshooterClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PolicyTroubleshooterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PolicyTroubleshooterClient.ChannelPool;
    }

    /// <summary>PolicyTroubleshooter client wrapper, for convenient use.</summary>
    /// <remarks>
    /// IAM Policy Troubleshooter service.
    /// 
    /// This service helps you troubleshoot access issues for Google Cloud resources.
    /// </remarks>
    public abstract partial class PolicyTroubleshooterClient
    {
        /// <summary>
        /// The default endpoint for the PolicyTroubleshooter service, which is a host of
        /// "policytroubleshooter.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "policytroubleshooter.googleapis.com:443";

        /// <summary>The default PolicyTroubleshooter scopes.</summary>
        /// <remarks>
        /// The default PolicyTroubleshooter scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PolicyTroubleshooter.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PolicyTroubleshooterClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PolicyTroubleshooterClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PolicyTroubleshooterClient"/>.</returns>
        public static stt::Task<PolicyTroubleshooterClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PolicyTroubleshooterClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PolicyTroubleshooterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="PolicyTroubleshooterClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PolicyTroubleshooterClient"/>.</returns>
        public static PolicyTroubleshooterClient Create() => new PolicyTroubleshooterClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PolicyTroubleshooterClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PolicyTroubleshooterSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PolicyTroubleshooterClient"/>.</returns>
        internal static PolicyTroubleshooterClient Create(grpccore::CallInvoker callInvoker, PolicyTroubleshooterSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PolicyTroubleshooter.PolicyTroubleshooterClient grpcClient = new PolicyTroubleshooter.PolicyTroubleshooterClient(callInvoker);
            return new PolicyTroubleshooterClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PolicyTroubleshooter client</summary>
        public virtual PolicyTroubleshooter.PolicyTroubleshooterClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or doesn't have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TroubleshootIamPolicyResponse TroubleshootIamPolicy(TroubleshootIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or doesn't have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TroubleshootIamPolicyResponse> TroubleshootIamPolicyAsync(TroubleshootIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or doesn't have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TroubleshootIamPolicyResponse> TroubleshootIamPolicyAsync(TroubleshootIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            TroubleshootIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PolicyTroubleshooter client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// IAM Policy Troubleshooter service.
    /// 
    /// This service helps you troubleshoot access issues for Google Cloud resources.
    /// </remarks>
    public sealed partial class PolicyTroubleshooterClientImpl : PolicyTroubleshooterClient
    {
        private readonly gaxgrpc::ApiCall<TroubleshootIamPolicyRequest, TroubleshootIamPolicyResponse> _callTroubleshootIamPolicy;

        /// <summary>
        /// Constructs a client wrapper for the PolicyTroubleshooter service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PolicyTroubleshooterSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PolicyTroubleshooterClientImpl(PolicyTroubleshooter.PolicyTroubleshooterClient grpcClient, PolicyTroubleshooterSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PolicyTroubleshooterSettings effectiveSettings = settings ?? PolicyTroubleshooterSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callTroubleshootIamPolicy = clientHelper.BuildApiCall<TroubleshootIamPolicyRequest, TroubleshootIamPolicyResponse>("TroubleshootIamPolicy", grpcClient.TroubleshootIamPolicyAsync, grpcClient.TroubleshootIamPolicy, effectiveSettings.TroubleshootIamPolicySettings);
            Modify_ApiCall(ref _callTroubleshootIamPolicy);
            Modify_TroubleshootIamPolicyApiCall(ref _callTroubleshootIamPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_TroubleshootIamPolicyApiCall(ref gaxgrpc::ApiCall<TroubleshootIamPolicyRequest, TroubleshootIamPolicyResponse> call);

        partial void OnConstruction(PolicyTroubleshooter.PolicyTroubleshooterClient grpcClient, PolicyTroubleshooterSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PolicyTroubleshooter client</summary>
        public override PolicyTroubleshooter.PolicyTroubleshooterClient GrpcClient { get; }

        partial void Modify_TroubleshootIamPolicyRequest(ref TroubleshootIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or doesn't have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TroubleshootIamPolicyResponse TroubleshootIamPolicy(TroubleshootIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TroubleshootIamPolicyRequest(ref request, ref callSettings);
            return _callTroubleshootIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or doesn't have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TroubleshootIamPolicyResponse> TroubleshootIamPolicyAsync(TroubleshootIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TroubleshootIamPolicyRequest(ref request, ref callSettings);
            return _callTroubleshootIamPolicy.Async(request, callSettings);
        }
    }
}
