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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Shell.V1
{
    /// <summary>Settings for <see cref="CloudShellServiceClient"/> instances.</summary>
    public sealed partial class CloudShellServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudShellServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudShellServiceSettings"/>.</returns>
        public static CloudShellServiceSettings GetDefault() => new CloudShellServiceSettings();

        /// <summary>Constructs a new <see cref="CloudShellServiceSettings"/> object with default settings.</summary>
        public CloudShellServiceSettings()
        {
        }

        private CloudShellServiceSettings(CloudShellServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetEnvironmentSettings = existing.GetEnvironmentSettings;
            StartEnvironmentSettings = existing.StartEnvironmentSettings;
            StartEnvironmentOperationsSettings = existing.StartEnvironmentOperationsSettings.Clone();
            AuthorizeEnvironmentSettings = existing.AuthorizeEnvironmentSettings;
            AuthorizeEnvironmentOperationsSettings = existing.AuthorizeEnvironmentOperationsSettings.Clone();
            AddPublicKeySettings = existing.AddPublicKeySettings;
            AddPublicKeyOperationsSettings = existing.AddPublicKeyOperationsSettings.Clone();
            RemovePublicKeySettings = existing.RemovePublicKeySettings;
            RemovePublicKeyOperationsSettings = existing.RemovePublicKeyOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(CloudShellServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudShellServiceClient.GetEnvironment</c> and <c>CloudShellServiceClient.GetEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudShellServiceClient.StartEnvironment</c> and <c>CloudShellServiceClient.StartEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudShellServiceClient.StartEnvironment</c> and
        /// <c>CloudShellServiceClient.StartEnvironmentAsync</c>.
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
        public lro::OperationsSettings StartEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudShellServiceClient.AuthorizeEnvironment</c> and <c>CloudShellServiceClient.AuthorizeEnvironmentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AuthorizeEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudShellServiceClient.AuthorizeEnvironment</c> and
        /// <c>CloudShellServiceClient.AuthorizeEnvironmentAsync</c>.
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
        public lro::OperationsSettings AuthorizeEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudShellServiceClient.AddPublicKey</c> and <c>CloudShellServiceClient.AddPublicKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddPublicKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudShellServiceClient.AddPublicKey</c> and
        /// <c>CloudShellServiceClient.AddPublicKeyAsync</c>.
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
        public lro::OperationsSettings AddPublicKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudShellServiceClient.RemovePublicKey</c> and <c>CloudShellServiceClient.RemovePublicKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemovePublicKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudShellServiceClient.RemovePublicKey</c> and
        /// <c>CloudShellServiceClient.RemovePublicKeyAsync</c>.
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
        public lro::OperationsSettings RemovePublicKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudShellServiceSettings"/> object.</returns>
        public CloudShellServiceSettings Clone() => new CloudShellServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudShellServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CloudShellServiceClientBuilder : gaxgrpc::ClientBuilderBase<CloudShellServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudShellServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudShellServiceClientBuilder() : base(CloudShellServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudShellServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudShellServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudShellServiceClient Build()
        {
            CloudShellServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudShellServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudShellServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudShellServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudShellServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudShellServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudShellServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudShellServiceClient.ChannelPool;
    }

    /// <summary>CloudShellService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API for interacting with Google Cloud Shell. Each user of Cloud Shell has at
    /// least one environment, which has the ID "default". Environment consists of a
    /// Docker image defining what is installed on the environment and a home
    /// directory containing the user's data that will remain across sessions.
    /// Clients use this API to start and fetch information about their environment,
    /// which can then be used to connect to that environment via a separate SSH
    /// client.
    /// </remarks>
    public abstract partial class CloudShellServiceClient
    {
        /// <summary>
        /// The default endpoint for the CloudShellService service, which is a host of "cloudshell.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudshell.googleapis.com:443";

        /// <summary>The default CloudShellService scopes.</summary>
        /// <remarks>
        /// The default CloudShellService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudShellService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudShellServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudShellServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudShellServiceClient"/>.</returns>
        public static stt::Task<CloudShellServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudShellServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudShellServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudShellServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudShellServiceClient"/>.</returns>
        public static CloudShellServiceClient Create() => new CloudShellServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudShellServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudShellServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudShellServiceClient"/>.</returns>
        internal static CloudShellServiceClient Create(grpccore::CallInvoker callInvoker, CloudShellServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudShellService.CloudShellServiceClient grpcClient = new CloudShellService.CloudShellServiceClient(callInvoker);
            return new CloudShellServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudShellService client</summary>
        public virtual CloudShellService.CloudShellServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource, for example `users/me/environments/default`
        /// or `users/someone@example.com/environments/default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource, for example `users/me/environments/default`
        /// or `users/someone@example.com/environments/default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource, for example `users/me/environments/default`
        /// or `users/someone@example.com/environments/default`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource, for example `users/me/environments/default`
        /// or `users/someone@example.com/environments/default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource, for example `users/me/environments/default`
        /// or `users/someone@example.com/environments/default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested resource, for example `users/me/environments/default`
        /// or `users/someone@example.com/environments/default`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(EnvironmentName name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts an existing environment, allowing clients to connect to it. The
        /// returned operation will contain an instance of StartEnvironmentMetadata in
        /// its metadata field. Users can wait for the environment to start by polling
        /// this operation via GetOperation. Once the environment has finished starting
        /// and is ready to accept connections, the operation will contain a
        /// StartEnvironmentResponse in its response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata> StartEnvironment(StartEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an existing environment, allowing clients to connect to it. The
        /// returned operation will contain an instance of StartEnvironmentMetadata in
        /// its metadata field. Users can wait for the environment to start by polling
        /// this operation via GetOperation. Once the environment has finished starting
        /// and is ready to accept connections, the operation will contain a
        /// StartEnvironmentResponse in its response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>> StartEnvironmentAsync(StartEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an existing environment, allowing clients to connect to it. The
        /// returned operation will contain an instance of StartEnvironmentMetadata in
        /// its metadata field. Users can wait for the environment to start by polling
        /// this operation via GetOperation. Once the environment has finished starting
        /// and is ready to accept connections, the operation will contain a
        /// StartEnvironmentResponse in its response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>> StartEnvironmentAsync(StartEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            StartEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartEnvironment</c>.</summary>
        public virtual lro::OperationsClient StartEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata> PollOnceStartEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>> PollOnceStartEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Sends OAuth credentials to a running environment on behalf of a user. When
        /// this completes, the environment will be authorized to run various Google
        /// Cloud command line tools without requiring the user to manually
        /// authenticate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> AuthorizeEnvironment(AuthorizeEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends OAuth credentials to a running environment on behalf of a user. When
        /// this completes, the environment will be authorized to run various Google
        /// Cloud command line tools without requiring the user to manually
        /// authenticate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>> AuthorizeEnvironmentAsync(AuthorizeEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends OAuth credentials to a running environment on behalf of a user. When
        /// this completes, the environment will be authorized to run various Google
        /// Cloud command line tools without requiring the user to manually
        /// authenticate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>> AuthorizeEnvironmentAsync(AuthorizeEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            AuthorizeEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AuthorizeEnvironment</c>.</summary>
        public virtual lro::OperationsClient AuthorizeEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AuthorizeEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> PollOnceAuthorizeEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AuthorizeEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AuthorizeEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>> PollOnceAuthorizeEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AuthorizeEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Adds a public SSH key to an environment, allowing clients with the
        /// corresponding private key to connect to that environment via SSH. If a key
        /// with the same content already exists, this will error with ALREADY_EXISTS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata> AddPublicKey(AddPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a public SSH key to an environment, allowing clients with the
        /// corresponding private key to connect to that environment via SSH. If a key
        /// with the same content already exists, this will error with ALREADY_EXISTS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>> AddPublicKeyAsync(AddPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a public SSH key to an environment, allowing clients with the
        /// corresponding private key to connect to that environment via SSH. If a key
        /// with the same content already exists, this will error with ALREADY_EXISTS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>> AddPublicKeyAsync(AddPublicKeyRequest request, st::CancellationToken cancellationToken) =>
            AddPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddPublicKey</c>.</summary>
        public virtual lro::OperationsClient AddPublicKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddPublicKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata> PollOnceAddPublicKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddPublicKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddPublicKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>> PollOnceAddPublicKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddPublicKeyOperationsClient, callSettings);

        /// <summary>
        /// Removes a public SSH key from an environment. Clients will no longer be
        /// able to connect to the environment using the corresponding private key.
        /// If a key with the same content is not present, this will error with
        /// NOT_FOUND.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> RemovePublicKey(RemovePublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a public SSH key from an environment. Clients will no longer be
        /// able to connect to the environment using the corresponding private key.
        /// If a key with the same content is not present, this will error with
        /// NOT_FOUND.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>> RemovePublicKeyAsync(RemovePublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a public SSH key from an environment. Clients will no longer be
        /// able to connect to the environment using the corresponding private key.
        /// If a key with the same content is not present, this will error with
        /// NOT_FOUND.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>> RemovePublicKeyAsync(RemovePublicKeyRequest request, st::CancellationToken cancellationToken) =>
            RemovePublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemovePublicKey</c>.</summary>
        public virtual lro::OperationsClient RemovePublicKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemovePublicKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> PollOnceRemovePublicKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemovePublicKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemovePublicKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>> PollOnceRemovePublicKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemovePublicKeyOperationsClient, callSettings);
    }

    /// <summary>CloudShellService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API for interacting with Google Cloud Shell. Each user of Cloud Shell has at
    /// least one environment, which has the ID "default". Environment consists of a
    /// Docker image defining what is installed on the environment and a home
    /// directory containing the user's data that will remain across sessions.
    /// Clients use this API to start and fetch information about their environment,
    /// which can then be used to connect to that environment via a separate SSH
    /// client.
    /// </remarks>
    public sealed partial class CloudShellServiceClientImpl : CloudShellServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> _callGetEnvironment;

        private readonly gaxgrpc::ApiCall<StartEnvironmentRequest, lro::Operation> _callStartEnvironment;

        private readonly gaxgrpc::ApiCall<AuthorizeEnvironmentRequest, lro::Operation> _callAuthorizeEnvironment;

        private readonly gaxgrpc::ApiCall<AddPublicKeyRequest, lro::Operation> _callAddPublicKey;

        private readonly gaxgrpc::ApiCall<RemovePublicKeyRequest, lro::Operation> _callRemovePublicKey;

        /// <summary>
        /// Constructs a client wrapper for the CloudShellService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudShellServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudShellServiceClientImpl(CloudShellService.CloudShellServiceClient grpcClient, CloudShellServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudShellServiceSettings effectiveSettings = settings ?? CloudShellServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            StartEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartEnvironmentOperationsSettings, logger);
            AuthorizeEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AuthorizeEnvironmentOperationsSettings, logger);
            AddPublicKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddPublicKeyOperationsSettings, logger);
            RemovePublicKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemovePublicKeyOperationsSettings, logger);
            _callGetEnvironment = clientHelper.BuildApiCall<GetEnvironmentRequest, Environment>("GetEnvironment", grpcClient.GetEnvironmentAsync, grpcClient.GetEnvironment, effectiveSettings.GetEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnvironment);
            Modify_GetEnvironmentApiCall(ref _callGetEnvironment);
            _callStartEnvironment = clientHelper.BuildApiCall<StartEnvironmentRequest, lro::Operation>("StartEnvironment", grpcClient.StartEnvironmentAsync, grpcClient.StartEnvironment, effectiveSettings.StartEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartEnvironment);
            Modify_StartEnvironmentApiCall(ref _callStartEnvironment);
            _callAuthorizeEnvironment = clientHelper.BuildApiCall<AuthorizeEnvironmentRequest, lro::Operation>("AuthorizeEnvironment", grpcClient.AuthorizeEnvironmentAsync, grpcClient.AuthorizeEnvironment, effectiveSettings.AuthorizeEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAuthorizeEnvironment);
            Modify_AuthorizeEnvironmentApiCall(ref _callAuthorizeEnvironment);
            _callAddPublicKey = clientHelper.BuildApiCall<AddPublicKeyRequest, lro::Operation>("AddPublicKey", grpcClient.AddPublicKeyAsync, grpcClient.AddPublicKey, effectiveSettings.AddPublicKeySettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callAddPublicKey);
            Modify_AddPublicKeyApiCall(ref _callAddPublicKey);
            _callRemovePublicKey = clientHelper.BuildApiCall<RemovePublicKeyRequest, lro::Operation>("RemovePublicKey", grpcClient.RemovePublicKeyAsync, grpcClient.RemovePublicKey, effectiveSettings.RemovePublicKeySettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callRemovePublicKey);
            Modify_RemovePublicKeyApiCall(ref _callRemovePublicKey);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetEnvironmentApiCall(ref gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> call);

        partial void Modify_StartEnvironmentApiCall(ref gaxgrpc::ApiCall<StartEnvironmentRequest, lro::Operation> call);

        partial void Modify_AuthorizeEnvironmentApiCall(ref gaxgrpc::ApiCall<AuthorizeEnvironmentRequest, lro::Operation> call);

        partial void Modify_AddPublicKeyApiCall(ref gaxgrpc::ApiCall<AddPublicKeyRequest, lro::Operation> call);

        partial void Modify_RemovePublicKeyApiCall(ref gaxgrpc::ApiCall<RemovePublicKeyRequest, lro::Operation> call);

        partial void OnConstruction(CloudShellService.CloudShellServiceClient grpcClient, CloudShellServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudShellService client</summary>
        public override CloudShellService.CloudShellServiceClient GrpcClient { get; }

        partial void Modify_GetEnvironmentRequest(ref GetEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartEnvironmentRequest(ref StartEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AuthorizeEnvironmentRequest(ref AuthorizeEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddPublicKeyRequest(ref AddPublicKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemovePublicKeyRequest(ref RemovePublicKeyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an environment. Returns NOT_FOUND if the environment does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>StartEnvironment</c>.</summary>
        public override lro::OperationsClient StartEnvironmentOperationsClient { get; }

        /// <summary>
        /// Starts an existing environment, allowing clients to connect to it. The
        /// returned operation will contain an instance of StartEnvironmentMetadata in
        /// its metadata field. Users can wait for the environment to start by polling
        /// this operation via GetOperation. Once the environment has finished starting
        /// and is ready to accept connections, the operation will contain a
        /// StartEnvironmentResponse in its response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata> StartEnvironment(StartEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>(_callStartEnvironment.Sync(request, callSettings), StartEnvironmentOperationsClient);
        }

        /// <summary>
        /// Starts an existing environment, allowing clients to connect to it. The
        /// returned operation will contain an instance of StartEnvironmentMetadata in
        /// its metadata field. Users can wait for the environment to start by polling
        /// this operation via GetOperation. Once the environment has finished starting
        /// and is ready to accept connections, the operation will contain a
        /// StartEnvironmentResponse in its response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>> StartEnvironmentAsync(StartEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<StartEnvironmentResponse, StartEnvironmentMetadata>(await _callStartEnvironment.Async(request, callSettings).ConfigureAwait(false), StartEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AuthorizeEnvironment</c>.</summary>
        public override lro::OperationsClient AuthorizeEnvironmentOperationsClient { get; }

        /// <summary>
        /// Sends OAuth credentials to a running environment on behalf of a user. When
        /// this completes, the environment will be authorized to run various Google
        /// Cloud command line tools without requiring the user to manually
        /// authenticate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata> AuthorizeEnvironment(AuthorizeEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AuthorizeEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>(_callAuthorizeEnvironment.Sync(request, callSettings), AuthorizeEnvironmentOperationsClient);
        }

        /// <summary>
        /// Sends OAuth credentials to a running environment on behalf of a user. When
        /// this completes, the environment will be authorized to run various Google
        /// Cloud command line tools without requiring the user to manually
        /// authenticate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>> AuthorizeEnvironmentAsync(AuthorizeEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AuthorizeEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<AuthorizeEnvironmentResponse, AuthorizeEnvironmentMetadata>(await _callAuthorizeEnvironment.Async(request, callSettings).ConfigureAwait(false), AuthorizeEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddPublicKey</c>.</summary>
        public override lro::OperationsClient AddPublicKeyOperationsClient { get; }

        /// <summary>
        /// Adds a public SSH key to an environment, allowing clients with the
        /// corresponding private key to connect to that environment via SSH. If a key
        /// with the same content already exists, this will error with ALREADY_EXISTS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata> AddPublicKey(AddPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddPublicKeyRequest(ref request, ref callSettings);
            return new lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>(_callAddPublicKey.Sync(request, callSettings), AddPublicKeyOperationsClient);
        }

        /// <summary>
        /// Adds a public SSH key to an environment, allowing clients with the
        /// corresponding private key to connect to that environment via SSH. If a key
        /// with the same content already exists, this will error with ALREADY_EXISTS.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>> AddPublicKeyAsync(AddPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddPublicKeyRequest(ref request, ref callSettings);
            return new lro::Operation<AddPublicKeyResponse, AddPublicKeyMetadata>(await _callAddPublicKey.Async(request, callSettings).ConfigureAwait(false), AddPublicKeyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemovePublicKey</c>.</summary>
        public override lro::OperationsClient RemovePublicKeyOperationsClient { get; }

        /// <summary>
        /// Removes a public SSH key from an environment. Clients will no longer be
        /// able to connect to the environment using the corresponding private key.
        /// If a key with the same content is not present, this will error with
        /// NOT_FOUND.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> RemovePublicKey(RemovePublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemovePublicKeyRequest(ref request, ref callSettings);
            return new lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>(_callRemovePublicKey.Sync(request, callSettings), RemovePublicKeyOperationsClient);
        }

        /// <summary>
        /// Removes a public SSH key from an environment. Clients will no longer be
        /// able to connect to the environment using the corresponding private key.
        /// If a key with the same content is not present, this will error with
        /// NOT_FOUND.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>> RemovePublicKeyAsync(RemovePublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemovePublicKeyRequest(ref request, ref callSettings);
            return new lro::Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata>(await _callRemovePublicKey.Async(request, callSettings).ConfigureAwait(false), RemovePublicKeyOperationsClient);
        }
    }

    public static partial class CloudShellService
    {
        public partial class CloudShellServiceClient
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
}
