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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Iam.V1
{
    /// <summary>Settings for <see cref="IAMPolicyClient"/> instances.</summary>
    public sealed partial class IAMPolicySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IAMPolicySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IAMPolicySettings"/>.</returns>
        public static IAMPolicySettings GetDefault() => new IAMPolicySettings();

        /// <summary>Constructs a new <see cref="IAMPolicySettings"/> object with default settings.</summary>
        public IAMPolicySettings()
        {
        }

        private IAMPolicySettings(IAMPolicySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IAMPolicySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMPolicyClient.SetIamPolicy</c> and <c>IAMPolicyClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMPolicyClient.GetIamPolicy</c> and <c>IAMPolicyClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMPolicyClient.TestIamPermissions</c> and <c>IAMPolicyClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IAMPolicySettings"/> object.</returns>
        public IAMPolicySettings Clone() => new IAMPolicySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IAMPolicyClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class IAMPolicyClientBuilder : gaxgrpc::ClientBuilderBase<IAMPolicyClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IAMPolicySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IAMPolicyClientBuilder() : base(IAMPolicyClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IAMPolicyClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IAMPolicyClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IAMPolicyClient Build()
        {
            IAMPolicyClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IAMPolicyClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IAMPolicyClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IAMPolicyClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IAMPolicyClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IAMPolicyClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IAMPolicyClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IAMPolicyClient.ChannelPool;
    }

    /// <summary>IAMPolicy client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API Overview
    /// 
    /// Manages Identity and Access Management (IAM) policies.
    /// 
    /// Any implementation of an API that offers access control features
    /// implements the google.iam.v1.IAMPolicy interface.
    /// 
    /// ## Data model
    /// 
    /// Access control is applied when a principal (user or service account), takes
    /// some action on a resource exposed by a service. Resources, identified by
    /// URI-like names, are the unit of access control specification. Service
    /// implementations can choose the granularity of access control and the
    /// supported permissions for their resources.
    /// For example one database service may allow access control to be
    /// specified only at the Table level, whereas another might allow access control
    /// to also be specified at the Column level.
    /// 
    /// ## Policy Structure
    /// 
    /// See google.iam.v1.Policy
    /// 
    /// This is intentionally not a CRUD style API because access control policies
    /// are created and deleted implicitly with the resources to which they are
    /// attached.
    /// </remarks>
    public abstract partial class IAMPolicyClient
    {
        /// <summary>
        /// The default endpoint for the IAMPolicy service, which is a host of "iam-meta-api.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iam-meta-api.googleapis.com:443";

        /// <summary>The default IAMPolicy scopes.</summary>
        /// <remarks>The default IAMPolicy scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IAMPolicy.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IAMPolicyClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="IAMPolicyClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IAMPolicyClient"/>.</returns>
        public static stt::Task<IAMPolicyClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IAMPolicyClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IAMPolicyClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="IAMPolicyClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IAMPolicyClient"/>.</returns>
        public static IAMPolicyClient Create() => new IAMPolicyClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IAMPolicyClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IAMPolicySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IAMPolicyClient"/>.</returns>
        internal static IAMPolicyClient Create(grpccore::CallInvoker callInvoker, IAMPolicySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IAMPolicy.IAMPolicyClient grpcClient = new IAMPolicy.IAMPolicyClient(callInvoker);
            return new IAMPolicyClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IAMPolicy client</summary>
        public virtual IAMPolicy.IAMPolicyClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestIamPermissionsResponse TestIamPermissions(TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestIamPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestIamPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IAMPolicy client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API Overview
    /// 
    /// Manages Identity and Access Management (IAM) policies.
    /// 
    /// Any implementation of an API that offers access control features
    /// implements the google.iam.v1.IAMPolicy interface.
    /// 
    /// ## Data model
    /// 
    /// Access control is applied when a principal (user or service account), takes
    /// some action on a resource exposed by a service. Resources, identified by
    /// URI-like names, are the unit of access control specification. Service
    /// implementations can choose the granularity of access control and the
    /// supported permissions for their resources.
    /// For example one database service may allow access control to be
    /// specified only at the Table level, whereas another might allow access control
    /// to also be specified at the Column level.
    /// 
    /// ## Policy Structure
    /// 
    /// See google.iam.v1.Policy
    /// 
    /// This is intentionally not a CRUD style API because access control policies
    /// are created and deleted implicitly with the resources to which they are
    /// attached.
    /// </remarks>
    public sealed partial class IAMPolicyClientImpl : IAMPolicyClient
    {
        private readonly gaxgrpc::ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the IAMPolicy service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IAMPolicySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IAMPolicyClientImpl(IAMPolicy.IAMPolicyClient grpcClient, IAMPolicySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IAMPolicySettings effectiveSettings = settings ?? IAMPolicySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<SetIamPolicyRequest, Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<GetIamPolicyRequest, Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> call);

        partial void OnConstruction(IAMPolicy.IAMPolicyClient grpcClient, IAMPolicySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IAMPolicy client</summary>
        public override IAMPolicy.IAMPolicyClient GrpcClient { get; }

        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy SetIamPolicy(SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> SetIamPolicyAsync(SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetIamPolicyAsync(GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestIamPermissionsResponse TestIamPermissions(TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestIamPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }
}
