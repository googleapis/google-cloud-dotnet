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

namespace Google.Cloud.PolicyTroubleshooter.V1
{
    /// <summary>Settings for <see cref="IamCheckerClient"/> instances.</summary>
    public sealed partial class IamCheckerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IamCheckerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IamCheckerSettings"/>.</returns>
        public static IamCheckerSettings GetDefault() => new IamCheckerSettings();

        /// <summary>Constructs a new <see cref="IamCheckerSettings"/> object with default settings.</summary>
        public IamCheckerSettings()
        {
        }

        private IamCheckerSettings(IamCheckerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            TroubleshootIamPolicySettings = existing.TroubleshootIamPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(IamCheckerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IamCheckerClient.TroubleshootIamPolicy</c> and <c>IamCheckerClient.TroubleshootIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TroubleshootIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IamCheckerSettings"/> object.</returns>
        public IamCheckerSettings Clone() => new IamCheckerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IamCheckerClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class IamCheckerClientBuilder : gaxgrpc::ClientBuilderBase<IamCheckerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IamCheckerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IamCheckerClientBuilder() : base(IamCheckerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IamCheckerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IamCheckerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IamCheckerClient Build()
        {
            IamCheckerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IamCheckerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IamCheckerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IamCheckerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IamCheckerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IamCheckerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IamCheckerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IamCheckerClient.ChannelPool;
    }

    /// <summary>IamChecker client wrapper, for convenient use.</summary>
    /// <remarks>
    /// IAM Policy Troubleshooter service.
    /// 
    /// This service helps you troubleshoot access issues for Google Cloud resources.
    /// </remarks>
    public abstract partial class IamCheckerClient
    {
        /// <summary>
        /// The default endpoint for the IamChecker service, which is a host of "policytroubleshooter.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "policytroubleshooter.googleapis.com:443";

        /// <summary>The default IamChecker scopes.</summary>
        /// <remarks>
        /// The default IamChecker scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IamChecker.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IamCheckerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IamCheckerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IamCheckerClient"/>.</returns>
        public static stt::Task<IamCheckerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IamCheckerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IamCheckerClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="IamCheckerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IamCheckerClient"/>.</returns>
        public static IamCheckerClient Create() => new IamCheckerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IamCheckerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IamCheckerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IamCheckerClient"/>.</returns>
        internal static IamCheckerClient Create(grpccore::CallInvoker callInvoker, IamCheckerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IamChecker.IamCheckerClient grpcClient = new IamChecker.IamCheckerClient(callInvoker);
            return new IamCheckerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IamChecker client</summary>
        public virtual IamChecker.IamCheckerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or does not have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TroubleshootIamPolicyResponse TroubleshootIamPolicy(TroubleshootIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or does not have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TroubleshootIamPolicyResponse> TroubleshootIamPolicyAsync(TroubleshootIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or does not have that
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TroubleshootIamPolicyResponse> TroubleshootIamPolicyAsync(TroubleshootIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            TroubleshootIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IamChecker client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// IAM Policy Troubleshooter service.
    /// 
    /// This service helps you troubleshoot access issues for Google Cloud resources.
    /// </remarks>
    public sealed partial class IamCheckerClientImpl : IamCheckerClient
    {
        private readonly gaxgrpc::ApiCall<TroubleshootIamPolicyRequest, TroubleshootIamPolicyResponse> _callTroubleshootIamPolicy;

        /// <summary>
        /// Constructs a client wrapper for the IamChecker service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IamCheckerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IamCheckerClientImpl(IamChecker.IamCheckerClient grpcClient, IamCheckerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IamCheckerSettings effectiveSettings = settings ?? IamCheckerSettings.GetDefault();
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

        partial void OnConstruction(IamChecker.IamCheckerClient grpcClient, IamCheckerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IamChecker client</summary>
        public override IamChecker.IamCheckerClient GrpcClient { get; }

        partial void Modify_TroubleshootIamPolicyRequest(ref TroubleshootIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Checks whether a principal has a specific permission for a specific
        /// resource, and explains why the principal does or does not have that
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
        /// resource, and explains why the principal does or does not have that
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
