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

namespace Google.Cloud.Iam.V3Beta
{
    /// <summary>Settings for <see cref="PolicyBindingsClient"/> instances.</summary>
    public sealed partial class PolicyBindingsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PolicyBindingsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PolicyBindingsSettings"/>.</returns>
        public static PolicyBindingsSettings GetDefault() => new PolicyBindingsSettings();

        /// <summary>Constructs a new <see cref="PolicyBindingsSettings"/> object with default settings.</summary>
        public PolicyBindingsSettings()
        {
        }

        private PolicyBindingsSettings(PolicyBindingsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePolicyBindingSettings = existing.CreatePolicyBindingSettings;
            CreatePolicyBindingOperationsSettings = existing.CreatePolicyBindingOperationsSettings.Clone();
            GetPolicyBindingSettings = existing.GetPolicyBindingSettings;
            UpdatePolicyBindingSettings = existing.UpdatePolicyBindingSettings;
            UpdatePolicyBindingOperationsSettings = existing.UpdatePolicyBindingOperationsSettings.Clone();
            DeletePolicyBindingSettings = existing.DeletePolicyBindingSettings;
            DeletePolicyBindingOperationsSettings = existing.DeletePolicyBindingOperationsSettings.Clone();
            ListPolicyBindingsSettings = existing.ListPolicyBindingsSettings;
            SearchTargetPolicyBindingsSettings = existing.SearchTargetPolicyBindingsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PolicyBindingsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBindingsClient.CreatePolicyBinding</c> and <c>PolicyBindingsClient.CreatePolicyBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePolicyBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PolicyBindingsClient.CreatePolicyBinding</c> and
        /// <c>PolicyBindingsClient.CreatePolicyBindingAsync</c>.
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
        public lro::OperationsSettings CreatePolicyBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBindingsClient.GetPolicyBinding</c> and <c>PolicyBindingsClient.GetPolicyBindingAsync</c>.
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
        public gaxgrpc::CallSettings GetPolicyBindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBindingsClient.UpdatePolicyBinding</c> and <c>PolicyBindingsClient.UpdatePolicyBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePolicyBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PolicyBindingsClient.UpdatePolicyBinding</c> and
        /// <c>PolicyBindingsClient.UpdatePolicyBindingAsync</c>.
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
        public lro::OperationsSettings UpdatePolicyBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBindingsClient.DeletePolicyBinding</c> and <c>PolicyBindingsClient.DeletePolicyBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePolicyBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PolicyBindingsClient.DeletePolicyBinding</c> and
        /// <c>PolicyBindingsClient.DeletePolicyBindingAsync</c>.
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
        public lro::OperationsSettings DeletePolicyBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBindingsClient.ListPolicyBindings</c> and <c>PolicyBindingsClient.ListPolicyBindingsAsync</c>.
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
        public gaxgrpc::CallSettings ListPolicyBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBindingsClient.SearchTargetPolicyBindings</c> and
        /// <c>PolicyBindingsClient.SearchTargetPolicyBindingsAsync</c>.
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
        public gaxgrpc::CallSettings SearchTargetPolicyBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PolicyBindingsSettings"/> object.</returns>
        public PolicyBindingsSettings Clone() => new PolicyBindingsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PolicyBindingsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PolicyBindingsClientBuilder : gaxgrpc::ClientBuilderBase<PolicyBindingsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PolicyBindingsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PolicyBindingsClientBuilder() : base(PolicyBindingsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PolicyBindingsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PolicyBindingsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PolicyBindingsClient Build()
        {
            PolicyBindingsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PolicyBindingsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PolicyBindingsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PolicyBindingsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PolicyBindingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PolicyBindingsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PolicyBindingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PolicyBindingsClient.ChannelPool;
    }

    /// <summary>PolicyBindings client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An interface for managing Identity and Access Management (IAM) policy
    /// bindings.
    /// </remarks>
    public abstract partial class PolicyBindingsClient
    {
        /// <summary>
        /// The default endpoint for the PolicyBindings service, which is a host of "iam.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iam.googleapis.com:443";

        /// <summary>The default PolicyBindings scopes.</summary>
        /// <remarks>
        /// The default PolicyBindings scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PolicyBindings.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PolicyBindingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PolicyBindingsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PolicyBindingsClient"/>.</returns>
        public static stt::Task<PolicyBindingsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PolicyBindingsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PolicyBindingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PolicyBindingsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PolicyBindingsClient"/>.</returns>
        public static PolicyBindingsClient Create() => new PolicyBindingsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PolicyBindingsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PolicyBindingsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PolicyBindingsClient"/>.</returns>
        internal static PolicyBindingsClient Create(grpccore::CallInvoker callInvoker, PolicyBindingsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PolicyBindings.PolicyBindingsClient grpcClient = new PolicyBindings.PolicyBindingsClient(callInvoker);
            return new PolicyBindingsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PolicyBindings client</summary>
        public virtual PolicyBindings.PolicyBindingsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> CreatePolicyBinding(CreatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(CreatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(CreatePolicyBindingRequest request, st::CancellationToken cancellationToken) =>
            CreatePolicyBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePolicyBinding</c>.</summary>
        public virtual lro::OperationsClient CreatePolicyBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePolicyBinding</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> PollOnceCreatePolicyBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PolicyBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePolicyBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePolicyBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> PollOnceCreatePolicyBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PolicyBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePolicyBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> CreatePolicyBinding(string parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBinding(new CreatePolicyBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(string parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBindingAsync(new CreatePolicyBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(string parent, PolicyBinding policyBinding, string policyBindingId, st::CancellationToken cancellationToken) =>
            CreatePolicyBindingAsync(parent, policyBinding, policyBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> CreatePolicyBinding(OrganizationLocationName parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBinding(new CreatePolicyBindingRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(OrganizationLocationName parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBindingAsync(new CreatePolicyBindingRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(OrganizationLocationName parent, PolicyBinding policyBinding, string policyBindingId, st::CancellationToken cancellationToken) =>
            CreatePolicyBindingAsync(parent, policyBinding, policyBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> CreatePolicyBinding(FolderLocationName parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBinding(new CreatePolicyBindingRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(FolderLocationName parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBindingAsync(new CreatePolicyBindingRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(FolderLocationName parent, PolicyBinding policyBinding, string policyBindingId, st::CancellationToken cancellationToken) =>
            CreatePolicyBindingAsync(parent, policyBinding, policyBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> CreatePolicyBinding(gagr::LocationName parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBinding(new CreatePolicyBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(gagr::LocationName parent, PolicyBinding policyBinding, string policyBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBindingAsync(new CreatePolicyBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)),
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this policy binding will be created.
        /// The binding parent is the closest Resource Manager resource (project,
        /// folder or organization) to the binding target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="policyBinding">
        /// Required. The policy binding to create.
        /// </param>
        /// <param name="policyBindingId">
        /// Required. The ID to use for the policy binding, which will become the final
        /// component of the policy binding's resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(gagr::LocationName parent, PolicyBinding policyBinding, string policyBindingId, st::CancellationToken cancellationToken) =>
            CreatePolicyBindingAsync(parent, policyBinding, policyBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyBinding GetPolicyBinding(GetPolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBinding> GetPolicyBindingAsync(GetPolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBinding> GetPolicyBindingAsync(GetPolicyBindingRequest request, st::CancellationToken cancellationToken) =>
            GetPolicyBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to retrieve.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyBinding GetPolicyBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBinding(new GetPolicyBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to retrieve.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBinding> GetPolicyBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBindingAsync(new GetPolicyBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to retrieve.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBinding> GetPolicyBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetPolicyBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to retrieve.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyBinding GetPolicyBinding(PolicyBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBinding(new GetPolicyBindingRequest
            {
                PolicyBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to retrieve.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBinding> GetPolicyBindingAsync(PolicyBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBindingAsync(new GetPolicyBindingRequest
            {
                PolicyBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to retrieve.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBinding> GetPolicyBindingAsync(PolicyBindingName name, st::CancellationToken cancellationToken) =>
            GetPolicyBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> UpdatePolicyBinding(UpdatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> UpdatePolicyBindingAsync(UpdatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> UpdatePolicyBindingAsync(UpdatePolicyBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdatePolicyBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePolicyBinding</c>.</summary>
        public virtual lro::OperationsClient UpdatePolicyBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdatePolicyBinding</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> PollOnceUpdatePolicyBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PolicyBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePolicyBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePolicyBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> PollOnceUpdatePolicyBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PolicyBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePolicyBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="policyBinding">
        /// Required. The policy binding to update.
        /// 
        /// The policy binding's `name` field is used to identify the policy binding to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBinding, OperationMetadata> UpdatePolicyBinding(PolicyBinding policyBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicyBinding(new UpdatePolicyBindingRequest
            {
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="policyBinding">
        /// Required. The policy binding to update.
        /// 
        /// The policy binding's `name` field is used to identify the policy binding to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> UpdatePolicyBindingAsync(PolicyBinding policyBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicyBindingAsync(new UpdatePolicyBindingRequest
            {
                PolicyBinding = gax::GaxPreconditions.CheckNotNull(policyBinding, nameof(policyBinding)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="policyBinding">
        /// Required. The policy binding to update.
        /// 
        /// The policy binding's `name` field is used to identify the policy binding to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> UpdatePolicyBindingAsync(PolicyBinding policyBinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePolicyBindingAsync(policyBinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBinding(DeletePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBindingAsync(DeletePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBindingAsync(DeletePolicyBindingRequest request, st::CancellationToken cancellationToken) =>
            DeletePolicyBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePolicyBinding</c>.</summary>
        public virtual lro::OperationsClient DeletePolicyBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePolicyBinding</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePolicyBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePolicyBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePolicyBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePolicyBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePolicyBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to delete.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBinding(new DeletePolicyBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to delete.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBindingAsync(new DeletePolicyBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to delete.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePolicyBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to delete.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBinding(PolicyBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBinding(new DeletePolicyBindingRequest
            {
                PolicyBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to delete.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBindingAsync(PolicyBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBindingAsync(new DeletePolicyBindingRequest
            {
                PolicyBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the policy binding to delete.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `projects/{project_number}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `folders/{folder_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// * `organizations/{organization_id}/locations/{location}/policyBindings/{policy_binding_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBindingAsync(PolicyBindingName name, st::CancellationToken cancellationToken) =>
            DeletePolicyBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindings(ListPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindingsAsync(ListPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
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
            return ListPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
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
            return ListPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindings(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindingsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindings(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindingsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindings(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
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
            return ListPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of policy
        /// bindings.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindingsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
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
            return ListPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindings(SearchTargetPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindingsAsync(SearchTargetPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindings(string parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
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
            return SearchTargetPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindingsAsync(string parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
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
            return SearchTargetPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindings(OrganizationLocationName parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchTargetPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindingsAsync(OrganizationLocationName parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchTargetPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindings(FolderLocationName parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchTargetPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindingsAsync(FolderLocationName parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchTargetPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindings(gagr::LocationName parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
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
            return SearchTargetPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this search will be performed. This
        /// should be the nearest Resource Manager resource (project, folder, or
        /// organization) to the target.
        /// 
        /// Format:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `projects/{project_number}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="target">
        /// Required. The target resource, which is bound to the policy in the binding.
        /// 
        /// Format:
        /// 
        /// * `//iam.googleapis.com/locations/global/workforcePools/POOL_ID`
        /// * `//iam.googleapis.com/projects/PROJECT_NUMBER/locations/global/workloadIdentityPools/POOL_ID`
        /// * `//iam.googleapis.com/locations/global/workspace/WORKSPACE_ID`
        /// * `//cloudresourcemanager.googleapis.com/projects/{project_number}`
        /// * `//cloudresourcemanager.googleapis.com/folders/{folder_id}`
        /// * `//cloudresourcemanager.googleapis.com/organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindingsAsync(gagr::LocationName parent, string target, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = gax::GaxPreconditions.CheckNotNullOrEmpty(target, nameof(target)),
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
            return SearchTargetPolicyBindingsAsync(request, callSettings);
        }
    }

    /// <summary>PolicyBindings client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An interface for managing Identity and Access Management (IAM) policy
    /// bindings.
    /// </remarks>
    public sealed partial class PolicyBindingsClientImpl : PolicyBindingsClient
    {
        private readonly gaxgrpc::ApiCall<CreatePolicyBindingRequest, lro::Operation> _callCreatePolicyBinding;

        private readonly gaxgrpc::ApiCall<GetPolicyBindingRequest, PolicyBinding> _callGetPolicyBinding;

        private readonly gaxgrpc::ApiCall<UpdatePolicyBindingRequest, lro::Operation> _callUpdatePolicyBinding;

        private readonly gaxgrpc::ApiCall<DeletePolicyBindingRequest, lro::Operation> _callDeletePolicyBinding;

        private readonly gaxgrpc::ApiCall<ListPolicyBindingsRequest, ListPolicyBindingsResponse> _callListPolicyBindings;

        private readonly gaxgrpc::ApiCall<SearchTargetPolicyBindingsRequest, SearchTargetPolicyBindingsResponse> _callSearchTargetPolicyBindings;

        /// <summary>
        /// Constructs a client wrapper for the PolicyBindings service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PolicyBindingsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PolicyBindingsClientImpl(PolicyBindings.PolicyBindingsClient grpcClient, PolicyBindingsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PolicyBindingsSettings effectiveSettings = settings ?? PolicyBindingsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreatePolicyBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePolicyBindingOperationsSettings, logger);
            UpdatePolicyBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePolicyBindingOperationsSettings, logger);
            DeletePolicyBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePolicyBindingOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreatePolicyBinding = clientHelper.BuildApiCall<CreatePolicyBindingRequest, lro::Operation>("CreatePolicyBinding", grpcClient.CreatePolicyBindingAsync, grpcClient.CreatePolicyBinding, effectiveSettings.CreatePolicyBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePolicyBinding);
            Modify_CreatePolicyBindingApiCall(ref _callCreatePolicyBinding);
            _callGetPolicyBinding = clientHelper.BuildApiCall<GetPolicyBindingRequest, PolicyBinding>("GetPolicyBinding", grpcClient.GetPolicyBindingAsync, grpcClient.GetPolicyBinding, effectiveSettings.GetPolicyBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPolicyBinding);
            Modify_GetPolicyBindingApiCall(ref _callGetPolicyBinding);
            _callUpdatePolicyBinding = clientHelper.BuildApiCall<UpdatePolicyBindingRequest, lro::Operation>("UpdatePolicyBinding", grpcClient.UpdatePolicyBindingAsync, grpcClient.UpdatePolicyBinding, effectiveSettings.UpdatePolicyBindingSettings).WithGoogleRequestParam("policy_binding.name", request => request.PolicyBinding?.Name);
            Modify_ApiCall(ref _callUpdatePolicyBinding);
            Modify_UpdatePolicyBindingApiCall(ref _callUpdatePolicyBinding);
            _callDeletePolicyBinding = clientHelper.BuildApiCall<DeletePolicyBindingRequest, lro::Operation>("DeletePolicyBinding", grpcClient.DeletePolicyBindingAsync, grpcClient.DeletePolicyBinding, effectiveSettings.DeletePolicyBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePolicyBinding);
            Modify_DeletePolicyBindingApiCall(ref _callDeletePolicyBinding);
            _callListPolicyBindings = clientHelper.BuildApiCall<ListPolicyBindingsRequest, ListPolicyBindingsResponse>("ListPolicyBindings", grpcClient.ListPolicyBindingsAsync, grpcClient.ListPolicyBindings, effectiveSettings.ListPolicyBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPolicyBindings);
            Modify_ListPolicyBindingsApiCall(ref _callListPolicyBindings);
            _callSearchTargetPolicyBindings = clientHelper.BuildApiCall<SearchTargetPolicyBindingsRequest, SearchTargetPolicyBindingsResponse>("SearchTargetPolicyBindings", grpcClient.SearchTargetPolicyBindingsAsync, grpcClient.SearchTargetPolicyBindings, effectiveSettings.SearchTargetPolicyBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchTargetPolicyBindings);
            Modify_SearchTargetPolicyBindingsApiCall(ref _callSearchTargetPolicyBindings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePolicyBindingApiCall(ref gaxgrpc::ApiCall<CreatePolicyBindingRequest, lro::Operation> call);

        partial void Modify_GetPolicyBindingApiCall(ref gaxgrpc::ApiCall<GetPolicyBindingRequest, PolicyBinding> call);

        partial void Modify_UpdatePolicyBindingApiCall(ref gaxgrpc::ApiCall<UpdatePolicyBindingRequest, lro::Operation> call);

        partial void Modify_DeletePolicyBindingApiCall(ref gaxgrpc::ApiCall<DeletePolicyBindingRequest, lro::Operation> call);

        partial void Modify_ListPolicyBindingsApiCall(ref gaxgrpc::ApiCall<ListPolicyBindingsRequest, ListPolicyBindingsResponse> call);

        partial void Modify_SearchTargetPolicyBindingsApiCall(ref gaxgrpc::ApiCall<SearchTargetPolicyBindingsRequest, SearchTargetPolicyBindingsResponse> call);

        partial void OnConstruction(PolicyBindings.PolicyBindingsClient grpcClient, PolicyBindingsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PolicyBindings client</summary>
        public override PolicyBindings.PolicyBindingsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreatePolicyBindingRequest(ref CreatePolicyBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPolicyBindingRequest(ref GetPolicyBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePolicyBindingRequest(ref UpdatePolicyBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePolicyBindingRequest(ref DeletePolicyBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPolicyBindingsRequest(ref ListPolicyBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchTargetPolicyBindingsRequest(ref SearchTargetPolicyBindingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreatePolicyBinding</c>.</summary>
        public override lro::OperationsClient CreatePolicyBindingOperationsClient { get; }

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PolicyBinding, OperationMetadata> CreatePolicyBinding(CreatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyBindingRequest(ref request, ref callSettings);
            return new lro::Operation<PolicyBinding, OperationMetadata>(_callCreatePolicyBinding.Sync(request, callSettings), CreatePolicyBindingOperationsClient);
        }

        /// <summary>
        /// Creates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is created, the policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> CreatePolicyBindingAsync(CreatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyBindingRequest(ref request, ref callSettings);
            return new lro::Operation<PolicyBinding, OperationMetadata>(await _callCreatePolicyBinding.Async(request, callSettings).ConfigureAwait(false), CreatePolicyBindingOperationsClient);
        }

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PolicyBinding GetPolicyBinding(GetPolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyBindingRequest(ref request, ref callSettings);
            return _callGetPolicyBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a policy binding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PolicyBinding> GetPolicyBindingAsync(GetPolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyBindingRequest(ref request, ref callSettings);
            return _callGetPolicyBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdatePolicyBinding</c>.</summary>
        public override lro::OperationsClient UpdatePolicyBindingOperationsClient { get; }

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PolicyBinding, OperationMetadata> UpdatePolicyBinding(UpdatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyBindingRequest(ref request, ref callSettings);
            return new lro::Operation<PolicyBinding, OperationMetadata>(_callUpdatePolicyBinding.Sync(request, callSettings), UpdatePolicyBindingOperationsClient);
        }

        /// <summary>
        /// Updates a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on the policy and target in the
        /// binding to update, and the IAM permission to remove the existing policy
        /// from the binding. Target is immutable and cannot be updated. Once the
        /// binding is updated, the new policy is applied to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PolicyBinding, OperationMetadata>> UpdatePolicyBindingAsync(UpdatePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyBindingRequest(ref request, ref callSettings);
            return new lro::Operation<PolicyBinding, OperationMetadata>(await _callUpdatePolicyBinding.Async(request, callSettings).ConfigureAwait(false), UpdatePolicyBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePolicyBinding</c>.</summary>
        public override lro::OperationsClient DeletePolicyBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBinding(DeletePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePolicyBinding.Sync(request, callSettings), DeletePolicyBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a policy binding and returns a long-running operation.
        /// Callers will need the IAM permissions on both the policy and target.
        /// Once the binding is deleted, the policy no longer applies to the target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBindingAsync(DeletePolicyBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePolicyBinding.Async(request, callSettings).ConfigureAwait(false), DeletePolicyBindingOperationsClient);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindings(ListPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPolicyBindingsRequest, ListPolicyBindingsResponse, PolicyBinding>(_callListPolicyBindings, request, callSettings);
        }

        /// <summary>
        /// Lists policy bindings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> ListPolicyBindingsAsync(ListPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPolicyBindingsRequest, ListPolicyBindingsResponse, PolicyBinding>(_callListPolicyBindings, request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindings(SearchTargetPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTargetPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchTargetPolicyBindingsRequest, SearchTargetPolicyBindingsResponse, PolicyBinding>(_callSearchTargetPolicyBindings, request, callSettings);
        }

        /// <summary>
        /// Search policy bindings by target. Returns all policy binding objects bound
        /// directly to target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> SearchTargetPolicyBindingsAsync(SearchTargetPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTargetPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchTargetPolicyBindingsRequest, SearchTargetPolicyBindingsResponse, PolicyBinding>(_callSearchTargetPolicyBindings, request, callSettings);
        }
    }

    public partial class ListPolicyBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchTargetPolicyBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPolicyBindingsResponse : gaxgrpc::IPageResponse<PolicyBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PolicyBinding> GetEnumerator() => PolicyBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchTargetPolicyBindingsResponse : gaxgrpc::IPageResponse<PolicyBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PolicyBinding> GetEnumerator() => PolicyBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PolicyBindings
    {
        public partial class PolicyBindingsClient
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

    public static partial class PolicyBindings
    {
        public partial class PolicyBindingsClient
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
