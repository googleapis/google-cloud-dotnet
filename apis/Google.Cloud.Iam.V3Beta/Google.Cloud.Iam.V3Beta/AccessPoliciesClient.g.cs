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
    /// <summary>Settings for <see cref="AccessPoliciesClient"/> instances.</summary>
    public sealed partial class AccessPoliciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccessPoliciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccessPoliciesSettings"/>.</returns>
        public static AccessPoliciesSettings GetDefault() => new AccessPoliciesSettings();

        /// <summary>Constructs a new <see cref="AccessPoliciesSettings"/> object with default settings.</summary>
        public AccessPoliciesSettings()
        {
        }

        private AccessPoliciesSettings(AccessPoliciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAccessPolicySettings = existing.CreateAccessPolicySettings;
            CreateAccessPolicyOperationsSettings = existing.CreateAccessPolicyOperationsSettings.Clone();
            GetAccessPolicySettings = existing.GetAccessPolicySettings;
            UpdateAccessPolicySettings = existing.UpdateAccessPolicySettings;
            UpdateAccessPolicyOperationsSettings = existing.UpdateAccessPolicyOperationsSettings.Clone();
            DeleteAccessPolicySettings = existing.DeleteAccessPolicySettings;
            DeleteAccessPolicyOperationsSettings = existing.DeleteAccessPolicyOperationsSettings.Clone();
            ListAccessPoliciesSettings = existing.ListAccessPoliciesSettings;
            SearchAccessPolicyBindingsSettings = existing.SearchAccessPolicyBindingsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccessPoliciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessPoliciesClient.CreateAccessPolicy</c> and <c>AccessPoliciesClient.CreateAccessPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAccessPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessPoliciesClient.CreateAccessPolicy</c> and
        /// <c>AccessPoliciesClient.CreateAccessPolicyAsync</c>.
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
        public lro::OperationsSettings CreateAccessPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessPoliciesClient.GetAccessPolicy</c> and <c>AccessPoliciesClient.GetAccessPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetAccessPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessPoliciesClient.UpdateAccessPolicy</c> and <c>AccessPoliciesClient.UpdateAccessPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccessPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessPoliciesClient.UpdateAccessPolicy</c> and
        /// <c>AccessPoliciesClient.UpdateAccessPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateAccessPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessPoliciesClient.DeleteAccessPolicy</c> and <c>AccessPoliciesClient.DeleteAccessPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccessPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AccessPoliciesClient.DeleteAccessPolicy</c> and
        /// <c>AccessPoliciesClient.DeleteAccessPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteAccessPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessPoliciesClient.ListAccessPolicies</c> and <c>AccessPoliciesClient.ListAccessPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListAccessPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessPoliciesClient.SearchAccessPolicyBindings</c> and
        /// <c>AccessPoliciesClient.SearchAccessPolicyBindingsAsync</c>.
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
        public gaxgrpc::CallSettings SearchAccessPolicyBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccessPoliciesSettings"/> object.</returns>
        public AccessPoliciesSettings Clone() => new AccessPoliciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccessPoliciesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AccessPoliciesClientBuilder : gaxgrpc::ClientBuilderBase<AccessPoliciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccessPoliciesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccessPoliciesClientBuilder() : base(AccessPoliciesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccessPoliciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccessPoliciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccessPoliciesClient Build()
        {
            AccessPoliciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccessPoliciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccessPoliciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccessPoliciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccessPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccessPoliciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccessPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccessPoliciesClient.ChannelPool;
    }

    /// <summary>AccessPolicies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Identity and Access Management (IAM) access policies.
    /// </remarks>
    public abstract partial class AccessPoliciesClient
    {
        /// <summary>
        /// The default endpoint for the AccessPolicies service, which is a host of "iam.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iam.googleapis.com:443";

        /// <summary>The default AccessPolicies scopes.</summary>
        /// <remarks>
        /// The default AccessPolicies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccessPolicies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccessPoliciesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccessPoliciesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccessPoliciesClient"/>.</returns>
        public static stt::Task<AccessPoliciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccessPoliciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccessPoliciesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccessPoliciesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccessPoliciesClient"/>.</returns>
        public static AccessPoliciesClient Create() => new AccessPoliciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccessPoliciesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccessPoliciesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccessPoliciesClient"/>.</returns>
        internal static AccessPoliciesClient Create(grpccore::CallInvoker callInvoker, AccessPoliciesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccessPolicies.AccessPoliciesClient grpcClient = new AccessPolicies.AccessPoliciesClient(callInvoker);
            return new AccessPoliciesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccessPolicies client</summary>
        public virtual AccessPolicies.AccessPoliciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> CreateAccessPolicy(CreateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(CreateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(CreateAccessPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAccessPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateAccessPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAccessPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> PollOnceCreateAccessPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAccessPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> PollOnceCreateAccessPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> CreateAccessPolicy(string parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicy(new CreateAccessPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(string parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicyAsync(new CreateAccessPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(string parent, AccessPolicy accessPolicy, string accessPolicyId, st::CancellationToken cancellationToken) =>
            CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> CreateAccessPolicy(OrganizationLocationName parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicy(new CreateAccessPolicyRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(OrganizationLocationName parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicyAsync(new CreateAccessPolicyRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(OrganizationLocationName parent, AccessPolicy accessPolicy, string accessPolicyId, st::CancellationToken cancellationToken) =>
            CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> CreateAccessPolicy(FolderLocationName parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicy(new CreateAccessPolicyRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(FolderLocationName parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicyAsync(new CreateAccessPolicyRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(FolderLocationName parent, AccessPolicy accessPolicy, string accessPolicyId, st::CancellationToken cancellationToken) =>
            CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> CreateAccessPolicy(gagr::LocationName parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicy(new CreateAccessPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(gagr::LocationName parent, AccessPolicy accessPolicy, string accessPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccessPolicyAsync(new CreateAccessPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccessPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)),
                AccessPolicy = gax::GaxPreconditions.CheckNotNull(accessPolicy, nameof(accessPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this access policy will be created.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="accessPolicy">
        /// Required. The access policy to create.
        /// </param>
        /// <param name="accessPolicyId">
        /// Required. The ID to use for the access policy, which
        /// will become the final component of the access policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// 
        /// This value must be unique among all access policies with the same parent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(gagr::LocationName parent, AccessPolicy accessPolicy, string accessPolicyId, st::CancellationToken cancellationToken) =>
            CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessPolicy GetAccessPolicy(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(GetAccessPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to retrieve.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessPolicy GetAccessPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicy(new GetAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to retrieve.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicyAsync(new GetAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to retrieve.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to retrieve.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessPolicy GetAccessPolicy(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicy(new GetAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to retrieve.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessPolicyAsync(new GetAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to retrieve.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessPolicy> GetAccessPolicyAsync(AccessPolicyName name, st::CancellationToken cancellationToken) =>
            GetAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> UpdateAccessPolicy(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAccessPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateAccessPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAccessPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AccessPolicy, OperationMetadata> PollOnceUpdateAccessPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAccessPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> PollOnceUpdateAccessPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AccessPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAccessPolicy(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccessPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAccessPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteAccessPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAccessPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAccessPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAccessPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAccessPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAccessPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to delete.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAccessPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicy(new DeleteAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to delete.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAccessPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicyAsync(new DeleteAccessPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to delete.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAccessPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to delete.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAccessPolicy(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicy(new DeleteAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to delete.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAccessPolicyAsync(AccessPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessPolicyAsync(new DeleteAccessPolicyRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy to delete.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAccessPolicyAsync(AccessPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteAccessPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of access policy
        /// resources.
        /// 
        /// Format:
        /// `projects/{project_id}/locations/{location}`
        /// `projects/{project_number}/locations/{location}`
        /// `folders/{folder_id}/locations/{location}`
        /// `organizations/{organization_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
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
            return ListAccessPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindings(SearchAccessPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindingsAsync(SearchAccessPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
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
        public virtual gax::PagedEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindings(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAccessPolicyBindingsRequest request = new SearchAccessPolicyBindingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAccessPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
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
        public virtual gax::PagedAsyncEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindingsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAccessPolicyBindingsRequest request = new SearchAccessPolicyBindingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAccessPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
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
        public virtual gax::PagedEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindings(AccessPolicyName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAccessPolicyBindingsRequest request = new SearchAccessPolicyBindingsRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAccessPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the access policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `folders/{folder_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_id}/locations/{location}/accessPolicies/{access_policy_id}`
        /// `projects/{project_number}/locations/{location}/accessPolicies/{access_policy_id}`
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
        public virtual gax::PagedAsyncEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindingsAsync(AccessPolicyName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAccessPolicyBindingsRequest request = new SearchAccessPolicyBindingsRequest
            {
                AccessPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAccessPolicyBindingsAsync(request, callSettings);
        }
    }

    /// <summary>AccessPolicies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Identity and Access Management (IAM) access policies.
    /// </remarks>
    public sealed partial class AccessPoliciesClientImpl : AccessPoliciesClient
    {
        private readonly gaxgrpc::ApiCall<CreateAccessPolicyRequest, lro::Operation> _callCreateAccessPolicy;

        private readonly gaxgrpc::ApiCall<GetAccessPolicyRequest, AccessPolicy> _callGetAccessPolicy;

        private readonly gaxgrpc::ApiCall<UpdateAccessPolicyRequest, lro::Operation> _callUpdateAccessPolicy;

        private readonly gaxgrpc::ApiCall<DeleteAccessPolicyRequest, lro::Operation> _callDeleteAccessPolicy;

        private readonly gaxgrpc::ApiCall<ListAccessPoliciesRequest, ListAccessPoliciesResponse> _callListAccessPolicies;

        private readonly gaxgrpc::ApiCall<SearchAccessPolicyBindingsRequest, SearchAccessPolicyBindingsResponse> _callSearchAccessPolicyBindings;

        /// <summary>
        /// Constructs a client wrapper for the AccessPolicies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccessPoliciesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccessPoliciesClientImpl(AccessPolicies.AccessPoliciesClient grpcClient, AccessPoliciesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccessPoliciesSettings effectiveSettings = settings ?? AccessPoliciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAccessPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAccessPolicyOperationsSettings, logger);
            UpdateAccessPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAccessPolicyOperationsSettings, logger);
            DeleteAccessPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAccessPolicyOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateAccessPolicy = clientHelper.BuildApiCall<CreateAccessPolicyRequest, lro::Operation>("CreateAccessPolicy", grpcClient.CreateAccessPolicyAsync, grpcClient.CreateAccessPolicy, effectiveSettings.CreateAccessPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAccessPolicy);
            Modify_CreateAccessPolicyApiCall(ref _callCreateAccessPolicy);
            _callGetAccessPolicy = clientHelper.BuildApiCall<GetAccessPolicyRequest, AccessPolicy>("GetAccessPolicy", grpcClient.GetAccessPolicyAsync, grpcClient.GetAccessPolicy, effectiveSettings.GetAccessPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccessPolicy);
            Modify_GetAccessPolicyApiCall(ref _callGetAccessPolicy);
            _callUpdateAccessPolicy = clientHelper.BuildApiCall<UpdateAccessPolicyRequest, lro::Operation>("UpdateAccessPolicy", grpcClient.UpdateAccessPolicyAsync, grpcClient.UpdateAccessPolicy, effectiveSettings.UpdateAccessPolicySettings).WithGoogleRequestParam("access_policy.name", request => request.AccessPolicy?.Name);
            Modify_ApiCall(ref _callUpdateAccessPolicy);
            Modify_UpdateAccessPolicyApiCall(ref _callUpdateAccessPolicy);
            _callDeleteAccessPolicy = clientHelper.BuildApiCall<DeleteAccessPolicyRequest, lro::Operation>("DeleteAccessPolicy", grpcClient.DeleteAccessPolicyAsync, grpcClient.DeleteAccessPolicy, effectiveSettings.DeleteAccessPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAccessPolicy);
            Modify_DeleteAccessPolicyApiCall(ref _callDeleteAccessPolicy);
            _callListAccessPolicies = clientHelper.BuildApiCall<ListAccessPoliciesRequest, ListAccessPoliciesResponse>("ListAccessPolicies", grpcClient.ListAccessPoliciesAsync, grpcClient.ListAccessPolicies, effectiveSettings.ListAccessPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccessPolicies);
            Modify_ListAccessPoliciesApiCall(ref _callListAccessPolicies);
            _callSearchAccessPolicyBindings = clientHelper.BuildApiCall<SearchAccessPolicyBindingsRequest, SearchAccessPolicyBindingsResponse>("SearchAccessPolicyBindings", grpcClient.SearchAccessPolicyBindingsAsync, grpcClient.SearchAccessPolicyBindings, effectiveSettings.SearchAccessPolicyBindingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSearchAccessPolicyBindings);
            Modify_SearchAccessPolicyBindingsApiCall(ref _callSearchAccessPolicyBindings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAccessPolicyApiCall(ref gaxgrpc::ApiCall<CreateAccessPolicyRequest, lro::Operation> call);

        partial void Modify_GetAccessPolicyApiCall(ref gaxgrpc::ApiCall<GetAccessPolicyRequest, AccessPolicy> call);

        partial void Modify_UpdateAccessPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAccessPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteAccessPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAccessPolicyRequest, lro::Operation> call);

        partial void Modify_ListAccessPoliciesApiCall(ref gaxgrpc::ApiCall<ListAccessPoliciesRequest, ListAccessPoliciesResponse> call);

        partial void Modify_SearchAccessPolicyBindingsApiCall(ref gaxgrpc::ApiCall<SearchAccessPolicyBindingsRequest, SearchAccessPolicyBindingsResponse> call);

        partial void OnConstruction(AccessPolicies.AccessPoliciesClient grpcClient, AccessPoliciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccessPolicies client</summary>
        public override AccessPolicies.AccessPoliciesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateAccessPolicyRequest(ref CreateAccessPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAccessPolicyRequest(ref GetAccessPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccessPolicyRequest(ref UpdateAccessPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccessPolicyRequest(ref DeleteAccessPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccessPoliciesRequest(ref ListAccessPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAccessPolicyBindingsRequest(ref SearchAccessPolicyBindingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateAccessPolicy</c>.</summary>
        public override lro::OperationsClient CreateAccessPolicyOperationsClient { get; }

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AccessPolicy, OperationMetadata> CreateAccessPolicy(CreateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, OperationMetadata>(_callCreateAccessPolicy.Sync(request, callSettings), CreateAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Creates an access policy, and returns a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> CreateAccessPolicyAsync(CreateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, OperationMetadata>(await _callCreateAccessPolicy.Async(request, callSettings).ConfigureAwait(false), CreateAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccessPolicy GetAccessPolicy(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessPolicyRequest(ref request, ref callSettings);
            return _callGetAccessPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccessPolicy> GetAccessPolicyAsync(GetAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessPolicyRequest(ref request, ref callSettings);
            return _callGetAccessPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateAccessPolicy</c>.</summary>
        public override lro::OperationsClient UpdateAccessPolicyOperationsClient { get; }

        /// <summary>
        /// Updates an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AccessPolicy, OperationMetadata> UpdateAccessPolicy(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, OperationMetadata>(_callUpdateAccessPolicy.Sync(request, callSettings), UpdateAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Updates an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AccessPolicy, OperationMetadata>> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AccessPolicy, OperationMetadata>(await _callUpdateAccessPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateAccessPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAccessPolicy</c>.</summary>
        public override lro::OperationsClient DeleteAccessPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAccessPolicy(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAccessPolicy.Sync(request, callSettings), DeleteAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes an access policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAccessPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteAccessPolicyOperationsClient);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPolicies(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccessPoliciesRequest, ListAccessPoliciesResponse, AccessPolicy>(_callListAccessPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists access policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccessPoliciesRequest, ListAccessPoliciesResponse, AccessPolicy>(_callListAccessPolicies, request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindings(SearchAccessPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAccessPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAccessPolicyBindingsRequest, SearchAccessPolicyBindingsResponse, PolicyBinding>(_callSearchAccessPolicyBindings, request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> SearchAccessPolicyBindingsAsync(SearchAccessPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAccessPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAccessPolicyBindingsRequest, SearchAccessPolicyBindingsResponse, PolicyBinding>(_callSearchAccessPolicyBindings, request, callSettings);
        }
    }

    public partial class ListAccessPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAccessPolicyBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccessPoliciesResponse : gaxgrpc::IPageResponse<AccessPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccessPolicy> GetEnumerator() => AccessPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchAccessPolicyBindingsResponse : gaxgrpc::IPageResponse<PolicyBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PolicyBinding> GetEnumerator() => PolicyBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AccessPolicies
    {
        public partial class AccessPoliciesClient
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

    public static partial class AccessPolicies
    {
        public partial class AccessPoliciesClient
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
