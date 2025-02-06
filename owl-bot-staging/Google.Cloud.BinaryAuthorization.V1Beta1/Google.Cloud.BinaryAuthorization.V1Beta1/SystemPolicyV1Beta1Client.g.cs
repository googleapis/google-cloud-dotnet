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

namespace Google.Cloud.BinaryAuthorization.V1Beta1
{
    /// <summary>Settings for <see cref="SystemPolicyV1Beta1Client"/> instances.</summary>
    public sealed partial class SystemPolicyV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SystemPolicyV1Beta1Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SystemPolicyV1Beta1Settings"/>.</returns>
        public static SystemPolicyV1Beta1Settings GetDefault() => new SystemPolicyV1Beta1Settings();

        /// <summary>Constructs a new <see cref="SystemPolicyV1Beta1Settings"/> object with default settings.</summary>
        public SystemPolicyV1Beta1Settings()
        {
        }

        private SystemPolicyV1Beta1Settings(SystemPolicyV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSystemPolicySettings = existing.GetSystemPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SystemPolicyV1Beta1Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SystemPolicyV1Beta1Client.GetSystemPolicy</c> and <c>SystemPolicyV1Beta1Client.GetSystemPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSystemPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SystemPolicyV1Beta1Settings"/> object.</returns>
        public SystemPolicyV1Beta1Settings Clone() => new SystemPolicyV1Beta1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SystemPolicyV1Beta1Client"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SystemPolicyV1Beta1ClientBuilder : gaxgrpc::ClientBuilderBase<SystemPolicyV1Beta1Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SystemPolicyV1Beta1Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SystemPolicyV1Beta1ClientBuilder() : base(SystemPolicyV1Beta1Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SystemPolicyV1Beta1Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SystemPolicyV1Beta1Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override SystemPolicyV1Beta1Client Build()
        {
            SystemPolicyV1Beta1Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SystemPolicyV1Beta1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SystemPolicyV1Beta1Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SystemPolicyV1Beta1Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SystemPolicyV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SystemPolicyV1Beta1Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SystemPolicyV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SystemPolicyV1Beta1Client.ChannelPool;
    }

    /// <summary>SystemPolicyV1Beta1 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API for working with the system policy.
    /// </remarks>
    public abstract partial class SystemPolicyV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the SystemPolicyV1Beta1 service, which is a host of
        /// "binaryauthorization.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "binaryauthorization.googleapis.com:443";

        /// <summary>The default SystemPolicyV1Beta1 scopes.</summary>
        /// <remarks>
        /// The default SystemPolicyV1Beta1 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SystemPolicyV1Beta1.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SystemPolicyV1Beta1Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SystemPolicyV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SystemPolicyV1Beta1Client"/>.</returns>
        public static stt::Task<SystemPolicyV1Beta1Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SystemPolicyV1Beta1ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SystemPolicyV1Beta1Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SystemPolicyV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SystemPolicyV1Beta1Client"/>.</returns>
        public static SystemPolicyV1Beta1Client Create() => new SystemPolicyV1Beta1ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SystemPolicyV1Beta1Client"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SystemPolicyV1Beta1Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SystemPolicyV1Beta1Client"/>.</returns>
        internal static SystemPolicyV1Beta1Client Create(grpccore::CallInvoker callInvoker, SystemPolicyV1Beta1Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SystemPolicyV1Beta1.SystemPolicyV1Beta1Client grpcClient = new SystemPolicyV1Beta1.SystemPolicyV1Beta1Client(callInvoker);
            return new SystemPolicyV1Beta1ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SystemPolicyV1Beta1 client</summary>
        public virtual SystemPolicyV1Beta1.SystemPolicyV1Beta1Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetSystemPolicy(GetSystemPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetSystemPolicyAsync(GetSystemPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetSystemPolicyAsync(GetSystemPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetSystemPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name, in the format `locations/*/policy`.
        /// Note that the system policy is not associated with a project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetSystemPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSystemPolicy(new GetSystemPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name, in the format `locations/*/policy`.
        /// Note that the system policy is not associated with a project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetSystemPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSystemPolicyAsync(new GetSystemPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name, in the format `locations/*/policy`.
        /// Note that the system policy is not associated with a project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetSystemPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetSystemPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name, in the format `locations/*/policy`.
        /// Note that the system policy is not associated with a project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetSystemPolicy(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSystemPolicy(new GetSystemPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name, in the format `locations/*/policy`.
        /// Note that the system policy is not associated with a project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetSystemPolicyAsync(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSystemPolicyAsync(new GetSystemPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name, in the format `locations/*/policy`.
        /// Note that the system policy is not associated with a project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetSystemPolicyAsync(PolicyName name, st::CancellationToken cancellationToken) =>
            GetSystemPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SystemPolicyV1Beta1 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API for working with the system policy.
    /// </remarks>
    public sealed partial class SystemPolicyV1Beta1ClientImpl : SystemPolicyV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<GetSystemPolicyRequest, Policy> _callGetSystemPolicy;

        /// <summary>
        /// Constructs a client wrapper for the SystemPolicyV1Beta1 service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SystemPolicyV1Beta1Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SystemPolicyV1Beta1ClientImpl(SystemPolicyV1Beta1.SystemPolicyV1Beta1Client grpcClient, SystemPolicyV1Beta1Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SystemPolicyV1Beta1Settings effectiveSettings = settings ?? SystemPolicyV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetSystemPolicy = clientHelper.BuildApiCall<GetSystemPolicyRequest, Policy>("GetSystemPolicy", grpcClient.GetSystemPolicyAsync, grpcClient.GetSystemPolicy, effectiveSettings.GetSystemPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSystemPolicy);
            Modify_GetSystemPolicyApiCall(ref _callGetSystemPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSystemPolicyApiCall(ref gaxgrpc::ApiCall<GetSystemPolicyRequest, Policy> call);

        partial void OnConstruction(SystemPolicyV1Beta1.SystemPolicyV1Beta1Client grpcClient, SystemPolicyV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SystemPolicyV1Beta1 client</summary>
        public override SystemPolicyV1Beta1.SystemPolicyV1Beta1Client GrpcClient { get; }

        partial void Modify_GetSystemPolicyRequest(ref GetSystemPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetSystemPolicy(GetSystemPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSystemPolicyRequest(ref request, ref callSettings);
            return _callGetSystemPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the current system policy in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetSystemPolicyAsync(GetSystemPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSystemPolicyRequest(ref request, ref callSettings);
            return _callGetSystemPolicy.Async(request, callSettings);
        }
    }
}
