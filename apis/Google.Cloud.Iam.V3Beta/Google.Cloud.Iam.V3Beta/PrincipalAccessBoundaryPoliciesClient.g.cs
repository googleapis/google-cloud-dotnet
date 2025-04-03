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
    /// <summary>Settings for <see cref="PrincipalAccessBoundaryPoliciesClient"/> instances.</summary>
    public sealed partial class PrincipalAccessBoundaryPoliciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PrincipalAccessBoundaryPoliciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PrincipalAccessBoundaryPoliciesSettings"/>.</returns>
        public static PrincipalAccessBoundaryPoliciesSettings GetDefault() => new PrincipalAccessBoundaryPoliciesSettings();

        /// <summary>
        /// Constructs a new <see cref="PrincipalAccessBoundaryPoliciesSettings"/> object with default settings.
        /// </summary>
        public PrincipalAccessBoundaryPoliciesSettings()
        {
        }

        private PrincipalAccessBoundaryPoliciesSettings(PrincipalAccessBoundaryPoliciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePrincipalAccessBoundaryPolicySettings = existing.CreatePrincipalAccessBoundaryPolicySettings;
            CreatePrincipalAccessBoundaryPolicyOperationsSettings = existing.CreatePrincipalAccessBoundaryPolicyOperationsSettings.Clone();
            GetPrincipalAccessBoundaryPolicySettings = existing.GetPrincipalAccessBoundaryPolicySettings;
            UpdatePrincipalAccessBoundaryPolicySettings = existing.UpdatePrincipalAccessBoundaryPolicySettings;
            UpdatePrincipalAccessBoundaryPolicyOperationsSettings = existing.UpdatePrincipalAccessBoundaryPolicyOperationsSettings.Clone();
            DeletePrincipalAccessBoundaryPolicySettings = existing.DeletePrincipalAccessBoundaryPolicySettings;
            DeletePrincipalAccessBoundaryPolicyOperationsSettings = existing.DeletePrincipalAccessBoundaryPolicyOperationsSettings.Clone();
            ListPrincipalAccessBoundaryPoliciesSettings = existing.ListPrincipalAccessBoundaryPoliciesSettings;
            SearchPrincipalAccessBoundaryPolicyBindingsSettings = existing.SearchPrincipalAccessBoundaryPolicyBindingsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PrincipalAccessBoundaryPoliciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicy</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrincipalAccessBoundaryPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicy</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicyAsync</c>.
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
        public lro::OperationsSettings CreatePrincipalAccessBoundaryPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicy</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetPrincipalAccessBoundaryPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicy</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePrincipalAccessBoundaryPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicy</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicyAsync</c>.
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
        public lro::OperationsSettings UpdatePrincipalAccessBoundaryPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicy</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePrincipalAccessBoundaryPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicy</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicyAsync</c>.
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
        public lro::OperationsSettings DeletePrincipalAccessBoundaryPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPolicies</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListPrincipalAccessBoundaryPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrincipalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindings</c> and
        /// <c>PrincipalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindingsAsync</c>.
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
        public gaxgrpc::CallSettings SearchPrincipalAccessBoundaryPolicyBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PrincipalAccessBoundaryPoliciesSettings"/> object.</returns>
        public PrincipalAccessBoundaryPoliciesSettings Clone() => new PrincipalAccessBoundaryPoliciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PrincipalAccessBoundaryPoliciesClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class PrincipalAccessBoundaryPoliciesClientBuilder : gaxgrpc::ClientBuilderBase<PrincipalAccessBoundaryPoliciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PrincipalAccessBoundaryPoliciesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PrincipalAccessBoundaryPoliciesClientBuilder() : base(PrincipalAccessBoundaryPoliciesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PrincipalAccessBoundaryPoliciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PrincipalAccessBoundaryPoliciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PrincipalAccessBoundaryPoliciesClient Build()
        {
            PrincipalAccessBoundaryPoliciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PrincipalAccessBoundaryPoliciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PrincipalAccessBoundaryPoliciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PrincipalAccessBoundaryPoliciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PrincipalAccessBoundaryPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PrincipalAccessBoundaryPoliciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PrincipalAccessBoundaryPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PrincipalAccessBoundaryPoliciesClient.ChannelPool;
    }

    /// <summary>PrincipalAccessBoundaryPolicies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Identity and Access Management (IAM) principal access boundary
    /// policies.
    /// </remarks>
    public abstract partial class PrincipalAccessBoundaryPoliciesClient
    {
        /// <summary>
        /// The default endpoint for the PrincipalAccessBoundaryPolicies service, which is a host of
        /// "iam.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iam.googleapis.com:443";

        /// <summary>The default PrincipalAccessBoundaryPolicies scopes.</summary>
        /// <remarks>
        /// The default PrincipalAccessBoundaryPolicies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PrincipalAccessBoundaryPolicies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PrincipalAccessBoundaryPoliciesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PrincipalAccessBoundaryPoliciesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PrincipalAccessBoundaryPoliciesClient"/>.</returns>
        public static stt::Task<PrincipalAccessBoundaryPoliciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PrincipalAccessBoundaryPoliciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PrincipalAccessBoundaryPoliciesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PrincipalAccessBoundaryPoliciesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PrincipalAccessBoundaryPoliciesClient"/>.</returns>
        public static PrincipalAccessBoundaryPoliciesClient Create() =>
            new PrincipalAccessBoundaryPoliciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PrincipalAccessBoundaryPoliciesClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PrincipalAccessBoundaryPoliciesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PrincipalAccessBoundaryPoliciesClient"/>.</returns>
        internal static PrincipalAccessBoundaryPoliciesClient Create(grpccore::CallInvoker callInvoker, PrincipalAccessBoundaryPoliciesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PrincipalAccessBoundaryPolicies.PrincipalAccessBoundaryPoliciesClient grpcClient = new PrincipalAccessBoundaryPolicies.PrincipalAccessBoundaryPoliciesClient(callInvoker);
            return new PrincipalAccessBoundaryPoliciesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PrincipalAccessBoundaryPolicies client</summary>
        public virtual PrincipalAccessBoundaryPolicies.PrincipalAccessBoundaryPoliciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> CreatePrincipalAccessBoundaryPolicy(CreatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> CreatePrincipalAccessBoundaryPolicyAsync(CreatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> CreatePrincipalAccessBoundaryPolicyAsync(CreatePrincipalAccessBoundaryPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreatePrincipalAccessBoundaryPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePrincipalAccessBoundaryPolicy</c>.</summary>
        public virtual lro::OperationsClient CreatePrincipalAccessBoundaryPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePrincipalAccessBoundaryPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> PollOnceCreatePrincipalAccessBoundaryPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrincipalAccessBoundaryPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePrincipalAccessBoundaryPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> PollOnceCreatePrincipalAccessBoundaryPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePrincipalAccessBoundaryPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this principal access boundary policy
        /// will be created. Only organizations are supported.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to create.
        /// </param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// Required. The ID to use for the principal access boundary policy, which
        /// will become the final component of the principal access boundary policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> CreatePrincipalAccessBoundaryPolicy(string parent, PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, string principalAccessBoundaryPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrincipalAccessBoundaryPolicy(new CreatePrincipalAccessBoundaryPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrincipalAccessBoundaryPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(principalAccessBoundaryPolicyId, nameof(principalAccessBoundaryPolicyId)),
                PrincipalAccessBoundaryPolicy = gax::GaxPreconditions.CheckNotNull(principalAccessBoundaryPolicy, nameof(principalAccessBoundaryPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this principal access boundary policy
        /// will be created. Only organizations are supported.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to create.
        /// </param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// Required. The ID to use for the principal access boundary policy, which
        /// will become the final component of the principal access boundary policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> CreatePrincipalAccessBoundaryPolicyAsync(string parent, PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, string principalAccessBoundaryPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrincipalAccessBoundaryPolicyAsync(new CreatePrincipalAccessBoundaryPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrincipalAccessBoundaryPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(principalAccessBoundaryPolicyId, nameof(principalAccessBoundaryPolicyId)),
                PrincipalAccessBoundaryPolicy = gax::GaxPreconditions.CheckNotNull(principalAccessBoundaryPolicy, nameof(principalAccessBoundaryPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this principal access boundary policy
        /// will be created. Only organizations are supported.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to create.
        /// </param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// Required. The ID to use for the principal access boundary policy, which
        /// will become the final component of the principal access boundary policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> CreatePrincipalAccessBoundaryPolicyAsync(string parent, PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, string principalAccessBoundaryPolicyId, st::CancellationToken cancellationToken) =>
            CreatePrincipalAccessBoundaryPolicyAsync(parent, principalAccessBoundaryPolicy, principalAccessBoundaryPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this principal access boundary policy
        /// will be created. Only organizations are supported.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to create.
        /// </param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// Required. The ID to use for the principal access boundary policy, which
        /// will become the final component of the principal access boundary policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> CreatePrincipalAccessBoundaryPolicy(OrganizationLocationName parent, PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, string principalAccessBoundaryPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrincipalAccessBoundaryPolicy(new CreatePrincipalAccessBoundaryPolicyRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrincipalAccessBoundaryPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(principalAccessBoundaryPolicyId, nameof(principalAccessBoundaryPolicyId)),
                PrincipalAccessBoundaryPolicy = gax::GaxPreconditions.CheckNotNull(principalAccessBoundaryPolicy, nameof(principalAccessBoundaryPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this principal access boundary policy
        /// will be created. Only organizations are supported.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to create.
        /// </param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// Required. The ID to use for the principal access boundary policy, which
        /// will become the final component of the principal access boundary policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> CreatePrincipalAccessBoundaryPolicyAsync(OrganizationLocationName parent, PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, string principalAccessBoundaryPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrincipalAccessBoundaryPolicyAsync(new CreatePrincipalAccessBoundaryPolicyRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrincipalAccessBoundaryPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(principalAccessBoundaryPolicyId, nameof(principalAccessBoundaryPolicyId)),
                PrincipalAccessBoundaryPolicy = gax::GaxPreconditions.CheckNotNull(principalAccessBoundaryPolicy, nameof(principalAccessBoundaryPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this principal access boundary policy
        /// will be created. Only organizations are supported.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to create.
        /// </param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// Required. The ID to use for the principal access boundary policy, which
        /// will become the final component of the principal access boundary policy's
        /// resource name.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, hyphens, or dots. Pattern,
        /// /[a-z][a-z0-9-\.]{2,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> CreatePrincipalAccessBoundaryPolicyAsync(OrganizationLocationName parent, PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, string principalAccessBoundaryPolicyId, st::CancellationToken cancellationToken) =>
            CreatePrincipalAccessBoundaryPolicyAsync(parent, principalAccessBoundaryPolicy, principalAccessBoundaryPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrincipalAccessBoundaryPolicy GetPrincipalAccessBoundaryPolicy(GetPrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrincipalAccessBoundaryPolicy> GetPrincipalAccessBoundaryPolicyAsync(GetPrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrincipalAccessBoundaryPolicy> GetPrincipalAccessBoundaryPolicyAsync(GetPrincipalAccessBoundaryPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetPrincipalAccessBoundaryPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to retrieve.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrincipalAccessBoundaryPolicy GetPrincipalAccessBoundaryPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrincipalAccessBoundaryPolicy(new GetPrincipalAccessBoundaryPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to retrieve.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrincipalAccessBoundaryPolicy> GetPrincipalAccessBoundaryPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrincipalAccessBoundaryPolicyAsync(new GetPrincipalAccessBoundaryPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to retrieve.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrincipalAccessBoundaryPolicy> GetPrincipalAccessBoundaryPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrincipalAccessBoundaryPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to retrieve.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrincipalAccessBoundaryPolicy GetPrincipalAccessBoundaryPolicy(PrincipalAccessBoundaryPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrincipalAccessBoundaryPolicy(new GetPrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to retrieve.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrincipalAccessBoundaryPolicy> GetPrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrincipalAccessBoundaryPolicyAsync(new GetPrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to retrieve.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrincipalAccessBoundaryPolicy> GetPrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName name, st::CancellationToken cancellationToken) =>
            GetPrincipalAccessBoundaryPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> UpdatePrincipalAccessBoundaryPolicy(UpdatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> UpdatePrincipalAccessBoundaryPolicyAsync(UpdatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> UpdatePrincipalAccessBoundaryPolicyAsync(UpdatePrincipalAccessBoundaryPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdatePrincipalAccessBoundaryPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePrincipalAccessBoundaryPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdatePrincipalAccessBoundaryPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePrincipalAccessBoundaryPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> PollOnceUpdatePrincipalAccessBoundaryPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePrincipalAccessBoundaryPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePrincipalAccessBoundaryPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> PollOnceUpdatePrincipalAccessBoundaryPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePrincipalAccessBoundaryPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to update.
        /// 
        /// The principal access boundary policy's `name` field is used to identify the
        /// policy to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> UpdatePrincipalAccessBoundaryPolicy(PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrincipalAccessBoundaryPolicy(new UpdatePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicy = gax::GaxPreconditions.CheckNotNull(principalAccessBoundaryPolicy, nameof(principalAccessBoundaryPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to update.
        /// 
        /// The principal access boundary policy's `name` field is used to identify the
        /// policy to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> UpdatePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrincipalAccessBoundaryPolicyAsync(new UpdatePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicy = gax::GaxPreconditions.CheckNotNull(principalAccessBoundaryPolicy, nameof(principalAccessBoundaryPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="principalAccessBoundaryPolicy">
        /// Required. The principal access boundary policy to update.
        /// 
        /// The principal access boundary policy's `name` field is used to identify the
        /// policy to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> UpdatePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePrincipalAccessBoundaryPolicyAsync(principalAccessBoundaryPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrincipalAccessBoundaryPolicy(DeletePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrincipalAccessBoundaryPolicyAsync(DeletePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrincipalAccessBoundaryPolicyAsync(DeletePrincipalAccessBoundaryPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeletePrincipalAccessBoundaryPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePrincipalAccessBoundaryPolicy</c>.</summary>
        public virtual lro::OperationsClient DeletePrincipalAccessBoundaryPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePrincipalAccessBoundaryPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePrincipalAccessBoundaryPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrincipalAccessBoundaryPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePrincipalAccessBoundaryPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePrincipalAccessBoundaryPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePrincipalAccessBoundaryPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to delete.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrincipalAccessBoundaryPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrincipalAccessBoundaryPolicy(new DeletePrincipalAccessBoundaryPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to delete.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrincipalAccessBoundaryPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrincipalAccessBoundaryPolicyAsync(new DeletePrincipalAccessBoundaryPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to delete.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrincipalAccessBoundaryPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePrincipalAccessBoundaryPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to delete.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePrincipalAccessBoundaryPolicy(PrincipalAccessBoundaryPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrincipalAccessBoundaryPolicy(new DeletePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to delete.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrincipalAccessBoundaryPolicyAsync(new DeletePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy to delete.
        /// 
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName name, st::CancellationToken cancellationToken) =>
            DeletePrincipalAccessBoundaryPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPolicies(ListPrincipalAccessBoundaryPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPoliciesAsync(ListPrincipalAccessBoundaryPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of principal
        /// access boundary policies.
        /// 
        /// Format:
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
        /// <returns>A pageable sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrincipalAccessBoundaryPoliciesRequest request = new ListPrincipalAccessBoundaryPoliciesRequest
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
            return ListPrincipalAccessBoundaryPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of principal
        /// access boundary policies.
        /// 
        /// Format:
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrincipalAccessBoundaryPoliciesRequest request = new ListPrincipalAccessBoundaryPoliciesRequest
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
            return ListPrincipalAccessBoundaryPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of principal
        /// access boundary policies.
        /// 
        /// Format:
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
        /// <returns>A pageable sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPolicies(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrincipalAccessBoundaryPoliciesRequest request = new ListPrincipalAccessBoundaryPoliciesRequest
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
            return ListPrincipalAccessBoundaryPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource, which owns the collection of principal
        /// access boundary policies.
        /// 
        /// Format:
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPoliciesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrincipalAccessBoundaryPoliciesRequest request = new ListPrincipalAccessBoundaryPoliciesRequest
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
            return ListPrincipalAccessBoundaryPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindings(SearchPrincipalAccessBoundaryPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindingsAsync(SearchPrincipalAccessBoundaryPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
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
        public virtual gax::PagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindings(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPrincipalAccessBoundaryPolicyBindingsRequest request = new SearchPrincipalAccessBoundaryPolicyBindingsRequest
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
            return SearchPrincipalAccessBoundaryPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
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
        public virtual gax::PagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindingsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPrincipalAccessBoundaryPolicyBindingsRequest request = new SearchPrincipalAccessBoundaryPolicyBindingsRequest
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
            return SearchPrincipalAccessBoundaryPolicyBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
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
        public virtual gax::PagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindings(PrincipalAccessBoundaryPolicyName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPrincipalAccessBoundaryPolicyBindingsRequest request = new SearchPrincipalAccessBoundaryPolicyBindingsRequest
            {
                PrincipalAccessBoundaryPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchPrincipalAccessBoundaryPolicyBindings(request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the principal access boundary policy.
        /// Format:
        /// `organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy_id}`
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
        public virtual gax::PagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindingsAsync(PrincipalAccessBoundaryPolicyName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPrincipalAccessBoundaryPolicyBindingsRequest request = new SearchPrincipalAccessBoundaryPolicyBindingsRequest
            {
                PrincipalAccessBoundaryPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchPrincipalAccessBoundaryPolicyBindingsAsync(request, callSettings);
        }
    }

    /// <summary>PrincipalAccessBoundaryPolicies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Identity and Access Management (IAM) principal access boundary
    /// policies.
    /// </remarks>
    public sealed partial class PrincipalAccessBoundaryPoliciesClientImpl : PrincipalAccessBoundaryPoliciesClient
    {
        private readonly gaxgrpc::ApiCall<CreatePrincipalAccessBoundaryPolicyRequest, lro::Operation> _callCreatePrincipalAccessBoundaryPolicy;

        private readonly gaxgrpc::ApiCall<GetPrincipalAccessBoundaryPolicyRequest, PrincipalAccessBoundaryPolicy> _callGetPrincipalAccessBoundaryPolicy;

        private readonly gaxgrpc::ApiCall<UpdatePrincipalAccessBoundaryPolicyRequest, lro::Operation> _callUpdatePrincipalAccessBoundaryPolicy;

        private readonly gaxgrpc::ApiCall<DeletePrincipalAccessBoundaryPolicyRequest, lro::Operation> _callDeletePrincipalAccessBoundaryPolicy;

        private readonly gaxgrpc::ApiCall<ListPrincipalAccessBoundaryPoliciesRequest, ListPrincipalAccessBoundaryPoliciesResponse> _callListPrincipalAccessBoundaryPolicies;

        private readonly gaxgrpc::ApiCall<SearchPrincipalAccessBoundaryPolicyBindingsRequest, SearchPrincipalAccessBoundaryPolicyBindingsResponse> _callSearchPrincipalAccessBoundaryPolicyBindings;

        /// <summary>
        /// Constructs a client wrapper for the PrincipalAccessBoundaryPolicies service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PrincipalAccessBoundaryPoliciesSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PrincipalAccessBoundaryPoliciesClientImpl(PrincipalAccessBoundaryPolicies.PrincipalAccessBoundaryPoliciesClient grpcClient, PrincipalAccessBoundaryPoliciesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PrincipalAccessBoundaryPoliciesSettings effectiveSettings = settings ?? PrincipalAccessBoundaryPoliciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreatePrincipalAccessBoundaryPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePrincipalAccessBoundaryPolicyOperationsSettings, logger);
            UpdatePrincipalAccessBoundaryPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePrincipalAccessBoundaryPolicyOperationsSettings, logger);
            DeletePrincipalAccessBoundaryPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePrincipalAccessBoundaryPolicyOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreatePrincipalAccessBoundaryPolicy = clientHelper.BuildApiCall<CreatePrincipalAccessBoundaryPolicyRequest, lro::Operation>("CreatePrincipalAccessBoundaryPolicy", grpcClient.CreatePrincipalAccessBoundaryPolicyAsync, grpcClient.CreatePrincipalAccessBoundaryPolicy, effectiveSettings.CreatePrincipalAccessBoundaryPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrincipalAccessBoundaryPolicy);
            Modify_CreatePrincipalAccessBoundaryPolicyApiCall(ref _callCreatePrincipalAccessBoundaryPolicy);
            _callGetPrincipalAccessBoundaryPolicy = clientHelper.BuildApiCall<GetPrincipalAccessBoundaryPolicyRequest, PrincipalAccessBoundaryPolicy>("GetPrincipalAccessBoundaryPolicy", grpcClient.GetPrincipalAccessBoundaryPolicyAsync, grpcClient.GetPrincipalAccessBoundaryPolicy, effectiveSettings.GetPrincipalAccessBoundaryPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrincipalAccessBoundaryPolicy);
            Modify_GetPrincipalAccessBoundaryPolicyApiCall(ref _callGetPrincipalAccessBoundaryPolicy);
            _callUpdatePrincipalAccessBoundaryPolicy = clientHelper.BuildApiCall<UpdatePrincipalAccessBoundaryPolicyRequest, lro::Operation>("UpdatePrincipalAccessBoundaryPolicy", grpcClient.UpdatePrincipalAccessBoundaryPolicyAsync, grpcClient.UpdatePrincipalAccessBoundaryPolicy, effectiveSettings.UpdatePrincipalAccessBoundaryPolicySettings).WithGoogleRequestParam("principal_access_boundary_policy.name", request => request.PrincipalAccessBoundaryPolicy?.Name);
            Modify_ApiCall(ref _callUpdatePrincipalAccessBoundaryPolicy);
            Modify_UpdatePrincipalAccessBoundaryPolicyApiCall(ref _callUpdatePrincipalAccessBoundaryPolicy);
            _callDeletePrincipalAccessBoundaryPolicy = clientHelper.BuildApiCall<DeletePrincipalAccessBoundaryPolicyRequest, lro::Operation>("DeletePrincipalAccessBoundaryPolicy", grpcClient.DeletePrincipalAccessBoundaryPolicyAsync, grpcClient.DeletePrincipalAccessBoundaryPolicy, effectiveSettings.DeletePrincipalAccessBoundaryPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePrincipalAccessBoundaryPolicy);
            Modify_DeletePrincipalAccessBoundaryPolicyApiCall(ref _callDeletePrincipalAccessBoundaryPolicy);
            _callListPrincipalAccessBoundaryPolicies = clientHelper.BuildApiCall<ListPrincipalAccessBoundaryPoliciesRequest, ListPrincipalAccessBoundaryPoliciesResponse>("ListPrincipalAccessBoundaryPolicies", grpcClient.ListPrincipalAccessBoundaryPoliciesAsync, grpcClient.ListPrincipalAccessBoundaryPolicies, effectiveSettings.ListPrincipalAccessBoundaryPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrincipalAccessBoundaryPolicies);
            Modify_ListPrincipalAccessBoundaryPoliciesApiCall(ref _callListPrincipalAccessBoundaryPolicies);
            _callSearchPrincipalAccessBoundaryPolicyBindings = clientHelper.BuildApiCall<SearchPrincipalAccessBoundaryPolicyBindingsRequest, SearchPrincipalAccessBoundaryPolicyBindingsResponse>("SearchPrincipalAccessBoundaryPolicyBindings", grpcClient.SearchPrincipalAccessBoundaryPolicyBindingsAsync, grpcClient.SearchPrincipalAccessBoundaryPolicyBindings, effectiveSettings.SearchPrincipalAccessBoundaryPolicyBindingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSearchPrincipalAccessBoundaryPolicyBindings);
            Modify_SearchPrincipalAccessBoundaryPolicyBindingsApiCall(ref _callSearchPrincipalAccessBoundaryPolicyBindings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePrincipalAccessBoundaryPolicyApiCall(ref gaxgrpc::ApiCall<CreatePrincipalAccessBoundaryPolicyRequest, lro::Operation> call);

        partial void Modify_GetPrincipalAccessBoundaryPolicyApiCall(ref gaxgrpc::ApiCall<GetPrincipalAccessBoundaryPolicyRequest, PrincipalAccessBoundaryPolicy> call);

        partial void Modify_UpdatePrincipalAccessBoundaryPolicyApiCall(ref gaxgrpc::ApiCall<UpdatePrincipalAccessBoundaryPolicyRequest, lro::Operation> call);

        partial void Modify_DeletePrincipalAccessBoundaryPolicyApiCall(ref gaxgrpc::ApiCall<DeletePrincipalAccessBoundaryPolicyRequest, lro::Operation> call);

        partial void Modify_ListPrincipalAccessBoundaryPoliciesApiCall(ref gaxgrpc::ApiCall<ListPrincipalAccessBoundaryPoliciesRequest, ListPrincipalAccessBoundaryPoliciesResponse> call);

        partial void Modify_SearchPrincipalAccessBoundaryPolicyBindingsApiCall(ref gaxgrpc::ApiCall<SearchPrincipalAccessBoundaryPolicyBindingsRequest, SearchPrincipalAccessBoundaryPolicyBindingsResponse> call);

        partial void OnConstruction(PrincipalAccessBoundaryPolicies.PrincipalAccessBoundaryPoliciesClient grpcClient, PrincipalAccessBoundaryPoliciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PrincipalAccessBoundaryPolicies client</summary>
        public override PrincipalAccessBoundaryPolicies.PrincipalAccessBoundaryPoliciesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreatePrincipalAccessBoundaryPolicyRequest(ref CreatePrincipalAccessBoundaryPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPrincipalAccessBoundaryPolicyRequest(ref GetPrincipalAccessBoundaryPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePrincipalAccessBoundaryPolicyRequest(ref UpdatePrincipalAccessBoundaryPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePrincipalAccessBoundaryPolicyRequest(ref DeletePrincipalAccessBoundaryPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrincipalAccessBoundaryPoliciesRequest(ref ListPrincipalAccessBoundaryPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchPrincipalAccessBoundaryPolicyBindingsRequest(ref SearchPrincipalAccessBoundaryPolicyBindingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreatePrincipalAccessBoundaryPolicy</c>.</summary>
        public override lro::OperationsClient CreatePrincipalAccessBoundaryPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> CreatePrincipalAccessBoundaryPolicy(CreatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>(_callCreatePrincipalAccessBoundaryPolicy.Sync(request, callSettings), CreatePrincipalAccessBoundaryPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a principal access boundary policy, and returns a long running
        /// operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> CreatePrincipalAccessBoundaryPolicyAsync(CreatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>(await _callCreatePrincipalAccessBoundaryPolicy.Async(request, callSettings).ConfigureAwait(false), CreatePrincipalAccessBoundaryPolicyOperationsClient);
        }

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrincipalAccessBoundaryPolicy GetPrincipalAccessBoundaryPolicy(GetPrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return _callGetPrincipalAccessBoundaryPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrincipalAccessBoundaryPolicy> GetPrincipalAccessBoundaryPolicyAsync(GetPrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return _callGetPrincipalAccessBoundaryPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdatePrincipalAccessBoundaryPolicy</c>.</summary>
        public override lro::OperationsClient UpdatePrincipalAccessBoundaryPolicyOperationsClient { get; }

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> UpdatePrincipalAccessBoundaryPolicy(UpdatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>(_callUpdatePrincipalAccessBoundaryPolicy.Sync(request, callSettings), UpdatePrincipalAccessBoundaryPolicyOperationsClient);
        }

        /// <summary>
        /// Updates a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>> UpdatePrincipalAccessBoundaryPolicyAsync(UpdatePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<PrincipalAccessBoundaryPolicy, OperationMetadata>(await _callUpdatePrincipalAccessBoundaryPolicy.Async(request, callSettings).ConfigureAwait(false), UpdatePrincipalAccessBoundaryPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePrincipalAccessBoundaryPolicy</c>.</summary>
        public override lro::OperationsClient DeletePrincipalAccessBoundaryPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePrincipalAccessBoundaryPolicy(DeletePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePrincipalAccessBoundaryPolicy.Sync(request, callSettings), DeletePrincipalAccessBoundaryPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a principal access boundary policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePrincipalAccessBoundaryPolicyAsync(DeletePrincipalAccessBoundaryPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrincipalAccessBoundaryPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePrincipalAccessBoundaryPolicy.Async(request, callSettings).ConfigureAwait(false), DeletePrincipalAccessBoundaryPolicyOperationsClient);
        }

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPolicies(ListPrincipalAccessBoundaryPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrincipalAccessBoundaryPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrincipalAccessBoundaryPoliciesRequest, ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy>(_callListPrincipalAccessBoundaryPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists principal access boundary policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PrincipalAccessBoundaryPolicy"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> ListPrincipalAccessBoundaryPoliciesAsync(ListPrincipalAccessBoundaryPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrincipalAccessBoundaryPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesRequest, ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy>(_callListPrincipalAccessBoundaryPolicies, request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindings(SearchPrincipalAccessBoundaryPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchPrincipalAccessBoundaryPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsRequest, SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding>(_callSearchPrincipalAccessBoundaryPolicyBindings, request, callSettings);
        }

        /// <summary>
        /// Returns all policy bindings that bind a specific policy if a user has
        /// searchPolicyBindings permission on that policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> SearchPrincipalAccessBoundaryPolicyBindingsAsync(SearchPrincipalAccessBoundaryPolicyBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchPrincipalAccessBoundaryPolicyBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsRequest, SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding>(_callSearchPrincipalAccessBoundaryPolicyBindings, request, callSettings);
        }
    }

    public partial class ListPrincipalAccessBoundaryPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchPrincipalAccessBoundaryPolicyBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrincipalAccessBoundaryPoliciesResponse : gaxgrpc::IPageResponse<PrincipalAccessBoundaryPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrincipalAccessBoundaryPolicy> GetEnumerator() =>
            PrincipalAccessBoundaryPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchPrincipalAccessBoundaryPolicyBindingsResponse : gaxgrpc::IPageResponse<PolicyBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PolicyBinding> GetEnumerator() => PolicyBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PrincipalAccessBoundaryPolicies
    {
        public partial class PrincipalAccessBoundaryPoliciesClient
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

    public static partial class PrincipalAccessBoundaryPolicies
    {
        public partial class PrincipalAccessBoundaryPoliciesClient
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
