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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.BinaryAuthorization.V1
{
    /// <summary>Settings for <see cref="BinauthzManagementServiceV1Client"/> instances.</summary>
    public sealed partial class BinauthzManagementServiceV1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BinauthzManagementServiceV1Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BinauthzManagementServiceV1Settings"/>.</returns>
        public static BinauthzManagementServiceV1Settings GetDefault() => new BinauthzManagementServiceV1Settings();

        /// <summary>
        /// Constructs a new <see cref="BinauthzManagementServiceV1Settings"/> object with default settings.
        /// </summary>
        public BinauthzManagementServiceV1Settings()
        {
        }

        private BinauthzManagementServiceV1Settings(BinauthzManagementServiceV1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPolicySettings = existing.GetPolicySettings;
            UpdatePolicySettings = existing.UpdatePolicySettings;
            CreateAttestorSettings = existing.CreateAttestorSettings;
            GetAttestorSettings = existing.GetAttestorSettings;
            UpdateAttestorSettings = existing.UpdateAttestorSettings;
            ListAttestorsSettings = existing.ListAttestorsSettings;
            DeleteAttestorSettings = existing.DeleteAttestorSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BinauthzManagementServiceV1Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BinauthzManagementServiceV1Client.GetPolicy</c> and <c>BinauthzManagementServiceV1Client.GetPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BinauthzManagementServiceV1Client.UpdatePolicy</c> and
        /// <c>BinauthzManagementServiceV1Client.UpdatePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BinauthzManagementServiceV1Client.CreateAttestor</c> and
        /// <c>BinauthzManagementServiceV1Client.CreateAttestorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAttestorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BinauthzManagementServiceV1Client.GetAttestor</c> and
        /// <c>BinauthzManagementServiceV1Client.GetAttestorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAttestorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BinauthzManagementServiceV1Client.UpdateAttestor</c> and
        /// <c>BinauthzManagementServiceV1Client.UpdateAttestorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAttestorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BinauthzManagementServiceV1Client.ListAttestors</c> and
        /// <c>BinauthzManagementServiceV1Client.ListAttestorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAttestorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BinauthzManagementServiceV1Client.DeleteAttestor</c> and
        /// <c>BinauthzManagementServiceV1Client.DeleteAttestorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAttestorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BinauthzManagementServiceV1Settings"/> object.</returns>
        public BinauthzManagementServiceV1Settings Clone() => new BinauthzManagementServiceV1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BinauthzManagementServiceV1Client"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class BinauthzManagementServiceV1ClientBuilder : gaxgrpc::ClientBuilderBase<BinauthzManagementServiceV1Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BinauthzManagementServiceV1Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BinauthzManagementServiceV1ClientBuilder() : base(BinauthzManagementServiceV1Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BinauthzManagementServiceV1Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BinauthzManagementServiceV1Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override BinauthzManagementServiceV1Client Build()
        {
            BinauthzManagementServiceV1Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BinauthzManagementServiceV1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BinauthzManagementServiceV1Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BinauthzManagementServiceV1Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BinauthzManagementServiceV1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BinauthzManagementServiceV1Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BinauthzManagementServiceV1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BinauthzManagementServiceV1Client.ChannelPool;
    }

    /// <summary>BinauthzManagementServiceV1 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Management Service for Binary Authorization admission policies
    /// and attestation authorities.
    /// 
    /// This API implements a REST model with the following objects:
    /// 
    /// * [Policy][google.cloud.binaryauthorization.v1.Policy]
    /// * [Attestor][google.cloud.binaryauthorization.v1.Attestor]
    /// </remarks>
    public abstract partial class BinauthzManagementServiceV1Client
    {
        /// <summary>
        /// The default endpoint for the BinauthzManagementServiceV1 service, which is a host of
        /// "binaryauthorization.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "binaryauthorization.googleapis.com:443";

        /// <summary>The default BinauthzManagementServiceV1 scopes.</summary>
        /// <remarks>
        /// The default BinauthzManagementServiceV1 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BinauthzManagementServiceV1.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BinauthzManagementServiceV1Client"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BinauthzManagementServiceV1ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BinauthzManagementServiceV1Client"/>.</returns>
        public static stt::Task<BinauthzManagementServiceV1Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BinauthzManagementServiceV1ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BinauthzManagementServiceV1Client"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BinauthzManagementServiceV1ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BinauthzManagementServiceV1Client"/>.</returns>
        public static BinauthzManagementServiceV1Client Create() => new BinauthzManagementServiceV1ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BinauthzManagementServiceV1Client"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BinauthzManagementServiceV1Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BinauthzManagementServiceV1Client"/>.</returns>
        internal static BinauthzManagementServiceV1Client Create(grpccore::CallInvoker callInvoker, BinauthzManagementServiceV1Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BinauthzManagementServiceV1.BinauthzManagementServiceV1Client grpcClient = new BinauthzManagementServiceV1.BinauthzManagementServiceV1Client(callInvoker);
            return new BinauthzManagementServiceV1ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BinauthzManagementServiceV1 client</summary>
        public virtual BinauthzManagementServiceV1.BinauthzManagementServiceV1Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [policy][google.cloud.binaryauthorization.v1.Policy] to retrieve,
        /// in the format `projects/*/policy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicy(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [policy][google.cloud.binaryauthorization.v1.Policy] to retrieve,
        /// in the format `projects/*/policy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyAsync(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [policy][google.cloud.binaryauthorization.v1.Policy] to retrieve,
        /// in the format `projects/*/policy`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [policy][google.cloud.binaryauthorization.v1.Policy] to retrieve,
        /// in the format `projects/*/policy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicy(new GetPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [policy][google.cloud.binaryauthorization.v1.Policy] to retrieve,
        /// in the format `projects/*/policy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyAsync(new GetPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [policy][google.cloud.binaryauthorization.v1.Policy] to retrieve,
        /// in the format `projects/*/policy`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(PolicyName name, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="policy">
        /// Required. A new or updated [policy][google.cloud.binaryauthorization.v1.Policy] value. The service will
        /// overwrite the [policy name][google.cloud.binaryauthorization.v1.Policy.name] field with the resource name in
        /// the request URL, in the format `projects/*/policy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy UpdatePolicy(Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicy(new UpdatePolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="policy">
        /// Required. A new or updated [policy][google.cloud.binaryauthorization.v1.Policy] value. The service will
        /// overwrite the [policy name][google.cloud.binaryauthorization.v1.Policy.name] field with the resource name in
        /// the request URL, in the format `projects/*/policy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicyAsync(new UpdatePolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="policy">
        /// Required. A new or updated [policy][google.cloud.binaryauthorization.v1.Policy] value. The service will
        /// overwrite the [policy name][google.cloud.binaryauthorization.v1.Policy.name] field with the resource name in
        /// the request URL, in the format `projects/*/policy`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(Policy policy, st::CancellationToken cancellationToken) =>
            UpdatePolicyAsync(policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor CreateAttestor(CreateAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> CreateAttestorAsync(CreateAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> CreateAttestorAsync(CreateAttestorRequest request, st::CancellationToken cancellationToken) =>
            CreateAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of this [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// </param>
        /// <param name="attestorId">
        /// Required. The [attestors][google.cloud.binaryauthorization.v1.Attestor] ID.
        /// </param>
        /// <param name="attestor">
        /// Required. The initial [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name,
        /// in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor CreateAttestor(string parent, string attestorId, Attestor attestor, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttestor(new CreateAttestorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttestorId = gax::GaxPreconditions.CheckNotNullOrEmpty(attestorId, nameof(attestorId)),
                Attestor = gax::GaxPreconditions.CheckNotNull(attestor, nameof(attestor)),
            }, callSettings);

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of this [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// </param>
        /// <param name="attestorId">
        /// Required. The [attestors][google.cloud.binaryauthorization.v1.Attestor] ID.
        /// </param>
        /// <param name="attestor">
        /// Required. The initial [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name,
        /// in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> CreateAttestorAsync(string parent, string attestorId, Attestor attestor, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttestorAsync(new CreateAttestorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttestorId = gax::GaxPreconditions.CheckNotNullOrEmpty(attestorId, nameof(attestorId)),
                Attestor = gax::GaxPreconditions.CheckNotNull(attestor, nameof(attestor)),
            }, callSettings);

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of this [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// </param>
        /// <param name="attestorId">
        /// Required. The [attestors][google.cloud.binaryauthorization.v1.Attestor] ID.
        /// </param>
        /// <param name="attestor">
        /// Required. The initial [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name,
        /// in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> CreateAttestorAsync(string parent, string attestorId, Attestor attestor, st::CancellationToken cancellationToken) =>
            CreateAttestorAsync(parent, attestorId, attestor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of this [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// </param>
        /// <param name="attestorId">
        /// Required. The [attestors][google.cloud.binaryauthorization.v1.Attestor] ID.
        /// </param>
        /// <param name="attestor">
        /// Required. The initial [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name,
        /// in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor CreateAttestor(gagr::ProjectName parent, string attestorId, Attestor attestor, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttestor(new CreateAttestorRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttestorId = gax::GaxPreconditions.CheckNotNullOrEmpty(attestorId, nameof(attestorId)),
                Attestor = gax::GaxPreconditions.CheckNotNull(attestor, nameof(attestor)),
            }, callSettings);

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of this [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// </param>
        /// <param name="attestorId">
        /// Required. The [attestors][google.cloud.binaryauthorization.v1.Attestor] ID.
        /// </param>
        /// <param name="attestor">
        /// Required. The initial [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name,
        /// in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> CreateAttestorAsync(gagr::ProjectName parent, string attestorId, Attestor attestor, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttestorAsync(new CreateAttestorRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttestorId = gax::GaxPreconditions.CheckNotNullOrEmpty(attestorId, nameof(attestorId)),
                Attestor = gax::GaxPreconditions.CheckNotNull(attestor, nameof(attestor)),
            }, callSettings);

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of this [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// </param>
        /// <param name="attestorId">
        /// Required. The [attestors][google.cloud.binaryauthorization.v1.Attestor] ID.
        /// </param>
        /// <param name="attestor">
        /// Required. The initial [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name,
        /// in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> CreateAttestorAsync(gagr::ProjectName parent, string attestorId, Attestor attestor, st::CancellationToken cancellationToken) =>
            CreateAttestorAsync(parent, attestorId, attestor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor GetAttestor(GetAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> GetAttestorAsync(GetAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> GetAttestorAsync(GetAttestorRequest request, st::CancellationToken cancellationToken) =>
            GetAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestor][google.cloud.binaryauthorization.v1.Attestor] to retrieve, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor GetAttestor(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttestor(new GetAttestorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestor][google.cloud.binaryauthorization.v1.Attestor] to retrieve, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> GetAttestorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttestorAsync(new GetAttestorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestor][google.cloud.binaryauthorization.v1.Attestor] to retrieve, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> GetAttestorAsync(string name, st::CancellationToken cancellationToken) =>
            GetAttestorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestor][google.cloud.binaryauthorization.v1.Attestor] to retrieve, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor GetAttestor(AttestorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttestor(new GetAttestorRequest
            {
                AttestorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestor][google.cloud.binaryauthorization.v1.Attestor] to retrieve, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> GetAttestorAsync(AttestorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttestorAsync(new GetAttestorRequest
            {
                AttestorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestor][google.cloud.binaryauthorization.v1.Attestor] to retrieve, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> GetAttestorAsync(AttestorName name, st::CancellationToken cancellationToken) =>
            GetAttestorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor UpdateAttestor(UpdateAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> UpdateAttestorAsync(UpdateAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> UpdateAttestorAsync(UpdateAttestorRequest request, st::CancellationToken cancellationToken) =>
            UpdateAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="attestor">
        /// Required. The updated [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name
        /// in the request URL, in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attestor UpdateAttestor(Attestor attestor, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttestor(new UpdateAttestorRequest
            {
                Attestor = gax::GaxPreconditions.CheckNotNull(attestor, nameof(attestor)),
            }, callSettings);

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="attestor">
        /// Required. The updated [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name
        /// in the request URL, in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> UpdateAttestorAsync(Attestor attestor, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttestorAsync(new UpdateAttestorRequest
            {
                Attestor = gax::GaxPreconditions.CheckNotNull(attestor, nameof(attestor)),
            }, callSettings);

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="attestor">
        /// Required. The updated [attestor][google.cloud.binaryauthorization.v1.Attestor] value. The service will
        /// overwrite the [attestor name][google.cloud.binaryauthorization.v1.Attestor.name] field with the resource name
        /// in the request URL, in the format `projects/*/attestors/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attestor> UpdateAttestorAsync(Attestor attestor, st::CancellationToken cancellationToken) =>
            UpdateAttestorAsync(attestor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attestor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttestorsResponse, Attestor> ListAttestors(ListAttestorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attestor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttestorsResponse, Attestor> ListAttestorsAsync(ListAttestorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [attestors][google.cloud.binaryauthorization.v1.Attestor], in the format `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="Attestor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttestorsResponse, Attestor> ListAttestors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttestorsRequest request = new ListAttestorsRequest
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
            return ListAttestors(request, callSettings);
        }

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [attestors][google.cloud.binaryauthorization.v1.Attestor], in the format `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attestor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttestorsResponse, Attestor> ListAttestorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttestorsRequest request = new ListAttestorsRequest
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
            return ListAttestorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [attestors][google.cloud.binaryauthorization.v1.Attestor], in the format `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="Attestor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttestorsResponse, Attestor> ListAttestors(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttestorsRequest request = new ListAttestorsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttestors(request, callSettings);
        }

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [attestors][google.cloud.binaryauthorization.v1.Attestor], in the format `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attestor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttestorsResponse, Attestor> ListAttestorsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttestorsRequest request = new ListAttestorsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttestorsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAttestor(DeleteAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttestorAsync(DeleteAttestorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttestorAsync(DeleteAttestorRequest request, st::CancellationToken cancellationToken) =>
            DeleteAttestorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestors][google.cloud.binaryauthorization.v1.Attestor] to delete, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAttestor(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttestor(new DeleteAttestorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestors][google.cloud.binaryauthorization.v1.Attestor] to delete, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttestorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttestorAsync(new DeleteAttestorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestors][google.cloud.binaryauthorization.v1.Attestor] to delete, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttestorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAttestorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestors][google.cloud.binaryauthorization.v1.Attestor] to delete, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAttestor(AttestorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttestor(new DeleteAttestorRequest
            {
                AttestorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestors][google.cloud.binaryauthorization.v1.Attestor] to delete, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttestorAsync(AttestorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttestorAsync(new DeleteAttestorRequest
            {
                AttestorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [attestors][google.cloud.binaryauthorization.v1.Attestor] to delete, in the format
        /// `projects/*/attestors/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttestorAsync(AttestorName name, st::CancellationToken cancellationToken) =>
            DeleteAttestorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BinauthzManagementServiceV1 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Management Service for Binary Authorization admission policies
    /// and attestation authorities.
    /// 
    /// This API implements a REST model with the following objects:
    /// 
    /// * [Policy][google.cloud.binaryauthorization.v1.Policy]
    /// * [Attestor][google.cloud.binaryauthorization.v1.Attestor]
    /// </remarks>
    public sealed partial class BinauthzManagementServiceV1ClientImpl : BinauthzManagementServiceV1Client
    {
        private readonly gaxgrpc::ApiCall<GetPolicyRequest, Policy> _callGetPolicy;

        private readonly gaxgrpc::ApiCall<UpdatePolicyRequest, Policy> _callUpdatePolicy;

        private readonly gaxgrpc::ApiCall<CreateAttestorRequest, Attestor> _callCreateAttestor;

        private readonly gaxgrpc::ApiCall<GetAttestorRequest, Attestor> _callGetAttestor;

        private readonly gaxgrpc::ApiCall<UpdateAttestorRequest, Attestor> _callUpdateAttestor;

        private readonly gaxgrpc::ApiCall<ListAttestorsRequest, ListAttestorsResponse> _callListAttestors;

        private readonly gaxgrpc::ApiCall<DeleteAttestorRequest, wkt::Empty> _callDeleteAttestor;

        /// <summary>
        /// Constructs a client wrapper for the BinauthzManagementServiceV1 service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BinauthzManagementServiceV1Settings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BinauthzManagementServiceV1ClientImpl(BinauthzManagementServiceV1.BinauthzManagementServiceV1Client grpcClient, BinauthzManagementServiceV1Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BinauthzManagementServiceV1Settings effectiveSettings = settings ?? BinauthzManagementServiceV1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetPolicy = clientHelper.BuildApiCall<GetPolicyRequest, Policy>("GetPolicy", grpcClient.GetPolicyAsync, grpcClient.GetPolicy, effectiveSettings.GetPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPolicy);
            Modify_GetPolicyApiCall(ref _callGetPolicy);
            _callUpdatePolicy = clientHelper.BuildApiCall<UpdatePolicyRequest, Policy>("UpdatePolicy", grpcClient.UpdatePolicyAsync, grpcClient.UpdatePolicy, effectiveSettings.UpdatePolicySettings).WithGoogleRequestParam("policy.name", request => request.Policy?.Name);
            Modify_ApiCall(ref _callUpdatePolicy);
            Modify_UpdatePolicyApiCall(ref _callUpdatePolicy);
            _callCreateAttestor = clientHelper.BuildApiCall<CreateAttestorRequest, Attestor>("CreateAttestor", grpcClient.CreateAttestorAsync, grpcClient.CreateAttestor, effectiveSettings.CreateAttestorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAttestor);
            Modify_CreateAttestorApiCall(ref _callCreateAttestor);
            _callGetAttestor = clientHelper.BuildApiCall<GetAttestorRequest, Attestor>("GetAttestor", grpcClient.GetAttestorAsync, grpcClient.GetAttestor, effectiveSettings.GetAttestorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAttestor);
            Modify_GetAttestorApiCall(ref _callGetAttestor);
            _callUpdateAttestor = clientHelper.BuildApiCall<UpdateAttestorRequest, Attestor>("UpdateAttestor", grpcClient.UpdateAttestorAsync, grpcClient.UpdateAttestor, effectiveSettings.UpdateAttestorSettings).WithGoogleRequestParam("attestor.name", request => request.Attestor?.Name);
            Modify_ApiCall(ref _callUpdateAttestor);
            Modify_UpdateAttestorApiCall(ref _callUpdateAttestor);
            _callListAttestors = clientHelper.BuildApiCall<ListAttestorsRequest, ListAttestorsResponse>("ListAttestors", grpcClient.ListAttestorsAsync, grpcClient.ListAttestors, effectiveSettings.ListAttestorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAttestors);
            Modify_ListAttestorsApiCall(ref _callListAttestors);
            _callDeleteAttestor = clientHelper.BuildApiCall<DeleteAttestorRequest, wkt::Empty>("DeleteAttestor", grpcClient.DeleteAttestorAsync, grpcClient.DeleteAttestor, effectiveSettings.DeleteAttestorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAttestor);
            Modify_DeleteAttestorApiCall(ref _callDeleteAttestor);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPolicyApiCall(ref gaxgrpc::ApiCall<GetPolicyRequest, Policy> call);

        partial void Modify_UpdatePolicyApiCall(ref gaxgrpc::ApiCall<UpdatePolicyRequest, Policy> call);

        partial void Modify_CreateAttestorApiCall(ref gaxgrpc::ApiCall<CreateAttestorRequest, Attestor> call);

        partial void Modify_GetAttestorApiCall(ref gaxgrpc::ApiCall<GetAttestorRequest, Attestor> call);

        partial void Modify_UpdateAttestorApiCall(ref gaxgrpc::ApiCall<UpdateAttestorRequest, Attestor> call);

        partial void Modify_ListAttestorsApiCall(ref gaxgrpc::ApiCall<ListAttestorsRequest, ListAttestorsResponse> call);

        partial void Modify_DeleteAttestorApiCall(ref gaxgrpc::ApiCall<DeleteAttestorRequest, wkt::Empty> call);

        partial void OnConstruction(BinauthzManagementServiceV1.BinauthzManagementServiceV1Client grpcClient, BinauthzManagementServiceV1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BinauthzManagementServiceV1 client</summary>
        public override BinauthzManagementServiceV1.BinauthzManagementServiceV1Client GrpcClient { get; }

        partial void Modify_GetPolicyRequest(ref GetPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePolicyRequest(ref UpdatePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAttestorRequest(ref CreateAttestorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAttestorRequest(ref GetAttestorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAttestorRequest(ref UpdateAttestorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAttestorsRequest(ref ListAttestorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAttestorRequest(ref DeleteAttestorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// A [policy][google.cloud.binaryauthorization.v1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1.Attestor] that must attest to
        /// a container image, before the project is allowed to deploy that
        /// image. There is at most one policy per project. All image admission
        /// requests are permitted if a project has no policy.
        /// 
        /// Gets the [policy][google.cloud.binaryauthorization.v1.Policy] for this project. Returns a default
        /// [policy][google.cloud.binaryauthorization.v1.Policy] if the project does not have one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return _callUpdatePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a project's [policy][google.cloud.binaryauthorization.v1.Policy], and returns a copy of the
        /// new [policy][google.cloud.binaryauthorization.v1.Policy]. A policy is always updated as a whole, to avoid race
        /// conditions with concurrent policy enforcement (or management!)
        /// requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
        /// if the request is malformed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return _callUpdatePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attestor CreateAttestor(CreateAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttestorRequest(ref request, ref callSettings);
            return _callCreateAttestor.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an [attestor][google.cloud.binaryauthorization.v1.Attestor], and returns a copy of the new
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the project does not exist,
        /// INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] already exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attestor> CreateAttestorAsync(CreateAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttestorRequest(ref request, ref callSettings);
            return _callCreateAttestor.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attestor GetAttestor(GetAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttestorRequest(ref request, ref callSettings);
            return _callGetAttestor.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attestor> GetAttestorAsync(GetAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttestorRequest(ref request, ref callSettings);
            return _callGetAttestor.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attestor UpdateAttestor(UpdateAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttestorRequest(ref request, ref callSettings);
            return _callUpdateAttestor.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an [attestor][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attestor> UpdateAttestorAsync(UpdateAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttestorRequest(ref request, ref callSettings);
            return _callUpdateAttestor.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attestor"/> resources.</returns>
        public override gax::PagedEnumerable<ListAttestorsResponse, Attestor> ListAttestors(ListAttestorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttestorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAttestorsRequest, ListAttestorsResponse, Attestor>(_callListAttestors, request, callSettings);
        }

        /// <summary>
        /// Lists [attestors][google.cloud.binaryauthorization.v1.Attestor].
        /// Returns INVALID_ARGUMENT if the project does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attestor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAttestorsResponse, Attestor> ListAttestorsAsync(ListAttestorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttestorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAttestorsRequest, ListAttestorsResponse, Attestor>(_callListAttestors, request, callSettings);
        }

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAttestor(DeleteAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttestorRequest(ref request, ref callSettings);
            _callDeleteAttestor.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an [attestor][google.cloud.binaryauthorization.v1.Attestor]. Returns NOT_FOUND if the
        /// [attestor][google.cloud.binaryauthorization.v1.Attestor] does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAttestorAsync(DeleteAttestorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttestorRequest(ref request, ref callSettings);
            return _callDeleteAttestor.Async(request, callSettings);
        }
    }

    public partial class ListAttestorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAttestorsResponse : gaxgrpc::IPageResponse<Attestor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Attestor> GetEnumerator() => Attestors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
