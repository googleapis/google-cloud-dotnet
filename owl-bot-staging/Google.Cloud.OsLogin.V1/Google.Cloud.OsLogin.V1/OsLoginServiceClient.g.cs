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
using gcoc = Google.Cloud.OsLogin.Common;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.OsLogin.V1
{
    /// <summary>Settings for <see cref="OsLoginServiceClient"/> instances.</summary>
    public sealed partial class OsLoginServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OsLoginServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OsLoginServiceSettings"/>.</returns>
        public static OsLoginServiceSettings GetDefault() => new OsLoginServiceSettings();

        /// <summary>Constructs a new <see cref="OsLoginServiceSettings"/> object with default settings.</summary>
        public OsLoginServiceSettings()
        {
        }

        private OsLoginServiceSettings(OsLoginServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSshPublicKeySettings = existing.CreateSshPublicKeySettings;
            DeletePosixAccountSettings = existing.DeletePosixAccountSettings;
            DeleteSshPublicKeySettings = existing.DeleteSshPublicKeySettings;
            GetLoginProfileSettings = existing.GetLoginProfileSettings;
            GetSshPublicKeySettings = existing.GetSshPublicKeySettings;
            ImportSshPublicKeySettings = existing.ImportSshPublicKeySettings;
            UpdateSshPublicKeySettings = existing.UpdateSshPublicKeySettings;
            OnCopy(existing);
        }

        partial void OnCopy(OsLoginServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsLoginServiceClient.CreateSshPublicKey</c> and <c>OsLoginServiceClient.CreateSshPublicKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSshPublicKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsLoginServiceClient.DeletePosixAccount</c> and <c>OsLoginServiceClient.DeletePosixAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePosixAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsLoginServiceClient.DeleteSshPublicKey</c> and <c>OsLoginServiceClient.DeleteSshPublicKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSshPublicKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsLoginServiceClient.GetLoginProfile</c> and <c>OsLoginServiceClient.GetLoginProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLoginProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsLoginServiceClient.GetSshPublicKey</c> and <c>OsLoginServiceClient.GetSshPublicKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSshPublicKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsLoginServiceClient.ImportSshPublicKey</c> and <c>OsLoginServiceClient.ImportSshPublicKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportSshPublicKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsLoginServiceClient.UpdateSshPublicKey</c> and <c>OsLoginServiceClient.UpdateSshPublicKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSshPublicKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OsLoginServiceSettings"/> object.</returns>
        public OsLoginServiceSettings Clone() => new OsLoginServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OsLoginServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class OsLoginServiceClientBuilder : gaxgrpc::ClientBuilderBase<OsLoginServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OsLoginServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OsLoginServiceClientBuilder() : base(OsLoginServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OsLoginServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OsLoginServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OsLoginServiceClient Build()
        {
            OsLoginServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OsLoginServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OsLoginServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OsLoginServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OsLoginServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OsLoginServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OsLoginServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OsLoginServiceClient.ChannelPool;
    }

    /// <summary>OsLoginService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud OS Login API
    /// 
    /// The Cloud OS Login API allows you to manage users and their associated SSH
    /// public keys for logging into virtual machines on Google Cloud Platform.
    /// </remarks>
    public abstract partial class OsLoginServiceClient
    {
        /// <summary>
        /// The default endpoint for the OsLoginService service, which is a host of "oslogin.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "oslogin.googleapis.com:443";

        /// <summary>The default OsLoginService scopes.</summary>
        /// <remarks>
        /// The default OsLoginService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/compute.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OsLoginService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OsLoginServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OsLoginServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OsLoginServiceClient"/>.</returns>
        public static stt::Task<OsLoginServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OsLoginServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OsLoginServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OsLoginServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OsLoginServiceClient"/>.</returns>
        public static OsLoginServiceClient Create() => new OsLoginServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OsLoginServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OsLoginServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OsLoginServiceClient"/>.</returns>
        internal static OsLoginServiceClient Create(grpccore::CallInvoker callInvoker, OsLoginServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OsLoginService.OsLoginServiceClient grpcClient = new OsLoginService.OsLoginServiceClient(callInvoker);
            return new OsLoginServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OsLoginService client</summary>
        public virtual OsLoginService.OsLoginServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey CreateSshPublicKey(CreateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> CreateSshPublicKeyAsync(CreateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> CreateSshPublicKeyAsync(CreateSshPublicKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey CreateSshPublicKey(string parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateSshPublicKey(new CreateSshPublicKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> CreateSshPublicKeyAsync(string parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateSshPublicKeyAsync(new CreateSshPublicKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> CreateSshPublicKeyAsync(string parent, gcoc::SshPublicKey sshPublicKey, st::CancellationToken cancellationToken) =>
            CreateSshPublicKeyAsync(parent, sshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey CreateSshPublicKey(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateSshPublicKey(new CreateSshPublicKeyRequest
            {
                ParentAsUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> CreateSshPublicKeyAsync(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateSshPublicKeyAsync(new CreateSshPublicKeyRequest
            {
                ParentAsUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> CreateSshPublicKeyAsync(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, st::CancellationToken cancellationToken) =>
            CreateSshPublicKeyAsync(parent, sshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePosixAccount(DeletePosixAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePosixAccountAsync(DeletePosixAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePosixAccountAsync(DeletePosixAccountRequest request, st::CancellationToken cancellationToken) =>
            DeletePosixAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="name">
        /// Required. A reference to the POSIX account to update. POSIX accounts are
        /// identified by the project ID they are associated with. A reference to the
        /// POSIX account is in format `users/{user}/projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePosixAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePosixAccount(new DeletePosixAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="name">
        /// Required. A reference to the POSIX account to update. POSIX accounts are
        /// identified by the project ID they are associated with. A reference to the
        /// POSIX account is in format `users/{user}/projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePosixAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePosixAccountAsync(new DeletePosixAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="name">
        /// Required. A reference to the POSIX account to update. POSIX accounts are
        /// identified by the project ID they are associated with. A reference to the
        /// POSIX account is in format `users/{user}/projects/{project}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePosixAccountAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePosixAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="name">
        /// Required. A reference to the POSIX account to update. POSIX accounts are
        /// identified by the project ID they are associated with. A reference to the
        /// POSIX account is in format `users/{user}/projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePosixAccount(gcoc::PosixAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePosixAccount(new DeletePosixAccountRequest
            {
                PosixAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="name">
        /// Required. A reference to the POSIX account to update. POSIX accounts are
        /// identified by the project ID they are associated with. A reference to the
        /// POSIX account is in format `users/{user}/projects/{project}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePosixAccountAsync(gcoc::PosixAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePosixAccountAsync(new DeletePosixAccountRequest
            {
                PosixAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="name">
        /// Required. A reference to the POSIX account to update. POSIX accounts are
        /// identified by the project ID they are associated with. A reference to the
        /// POSIX account is in format `users/{user}/projects/{project}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePosixAccountAsync(gcoc::PosixAccountName name, st::CancellationToken cancellationToken) =>
            DeletePosixAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSshPublicKey(DeleteSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSshPublicKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSshPublicKey(new DeleteSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSshPublicKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSshPublicKeyAsync(new DeleteSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSshPublicKeyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSshPublicKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSshPublicKey(gcoc::SshPublicKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSshPublicKey(new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSshPublicKeyAsync(gcoc::SshPublicKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSshPublicKeyAsync(new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSshPublicKeyAsync(gcoc::SshPublicKeyName name, st::CancellationToken cancellationToken) =>
            DeleteSshPublicKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LoginProfile GetLoginProfile(GetLoginProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LoginProfile> GetLoginProfileAsync(GetLoginProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LoginProfile> GetLoginProfileAsync(GetLoginProfileRequest request, st::CancellationToken cancellationToken) =>
            GetLoginProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="name">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LoginProfile GetLoginProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLoginProfile(new GetLoginProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="name">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LoginProfile> GetLoginProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLoginProfileAsync(new GetLoginProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="name">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LoginProfile> GetLoginProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetLoginProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="name">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LoginProfile GetLoginProfile(gcoc::UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLoginProfile(new GetLoginProfileRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="name">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LoginProfile> GetLoginProfileAsync(gcoc::UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLoginProfileAsync(new GetLoginProfileRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="name">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LoginProfile> GetLoginProfileAsync(gcoc::UserName name, st::CancellationToken cancellationToken) =>
            GetLoginProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey GetSshPublicKey(GetSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> GetSshPublicKeyAsync(GetSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> GetSshPublicKeyAsync(GetSshPublicKeyRequest request, st::CancellationToken cancellationToken) =>
            GetSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to retrieve. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey GetSshPublicKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSshPublicKey(new GetSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to retrieve. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> GetSshPublicKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSshPublicKeyAsync(new GetSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to retrieve. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> GetSshPublicKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetSshPublicKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to retrieve. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey GetSshPublicKey(gcoc::SshPublicKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSshPublicKey(new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to retrieve. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> GetSshPublicKeyAsync(gcoc::SshPublicKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSshPublicKeyAsync(new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to retrieve. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> GetSshPublicKeyAsync(gcoc::SshPublicKeyName name, st::CancellationToken cancellationToken) =>
            GetSshPublicKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportSshPublicKeyResponse ImportSshPublicKey(ImportSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(ImportSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(ImportSshPublicKeyRequest request, st::CancellationToken cancellationToken) =>
            ImportSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportSshPublicKeyResponse ImportSshPublicKey(string parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKey(new ImportSshPublicKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(string parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKeyAsync(new ImportSshPublicKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(string parent, gcoc::SshPublicKey sshPublicKey, st::CancellationToken cancellationToken) =>
            ImportSshPublicKeyAsync(parent, sshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportSshPublicKeyResponse ImportSshPublicKey(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKey(new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKeyAsync(new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, st::CancellationToken cancellationToken) =>
            ImportSshPublicKeyAsync(parent, sshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the Google Cloud Platform project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportSshPublicKeyResponse ImportSshPublicKey(string parent, gcoc::SshPublicKey sshPublicKey, string projectId, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKey(new ImportSshPublicKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
                ProjectId = projectId ?? "",
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the Google Cloud Platform project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(string parent, gcoc::SshPublicKey sshPublicKey, string projectId, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKeyAsync(new ImportSshPublicKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
                ProjectId = projectId ?? "",
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the Google Cloud Platform project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(string parent, gcoc::SshPublicKey sshPublicKey, string projectId, st::CancellationToken cancellationToken) =>
            ImportSshPublicKeyAsync(parent, sshPublicKey, projectId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the Google Cloud Platform project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportSshPublicKeyResponse ImportSshPublicKey(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, string projectId, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKey(new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
                ProjectId = projectId ?? "",
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the Google Cloud Platform project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, string projectId, gaxgrpc::CallSettings callSettings = null) =>
            ImportSshPublicKeyAsync(new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SshPublicKey = sshPublicKey,
                ProjectId = projectId ?? "",
            }, callSettings);

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique ID for the user in format `users/{user}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Optional. The SSH public key and expiration time.
        /// </param>
        /// <param name="projectId">
        /// The project ID of the Google Cloud Platform project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(gcoc::UserName parent, gcoc::SshPublicKey sshPublicKey, string projectId, st::CancellationToken cancellationToken) =>
            ImportSshPublicKeyAsync(parent, sshPublicKey, projectId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey UpdateSshPublicKey(UpdateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest request, st::CancellationToken cancellationToken) =>
            UpdateSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey UpdateSshPublicKey(string name, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKey(new UpdateSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(string name, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKeyAsync(new UpdateSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(string name, gcoc::SshPublicKey sshPublicKey, st::CancellationToken cancellationToken) =>
            UpdateSshPublicKeyAsync(name, sshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey UpdateSshPublicKey(gcoc::SshPublicKeyName name, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKey(new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(gcoc::SshPublicKeyName name, gcoc::SshPublicKey sshPublicKey, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKeyAsync(new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(gcoc::SshPublicKeyName name, gcoc::SshPublicKey sshPublicKey, st::CancellationToken cancellationToken) =>
            UpdateSshPublicKeyAsync(name, sshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated. Updates all if not present.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey UpdateSshPublicKey(string name, gcoc::SshPublicKey sshPublicKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKey(new UpdateSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated. Updates all if not present.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(string name, gcoc::SshPublicKey sshPublicKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKeyAsync(new UpdateSshPublicKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated. Updates all if not present.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(string name, gcoc::SshPublicKey sshPublicKey, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSshPublicKeyAsync(name, sshPublicKey, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated. Updates all if not present.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gcoc::SshPublicKey UpdateSshPublicKey(gcoc::SshPublicKeyName name, gcoc::SshPublicKey sshPublicKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKey(new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated. Updates all if not present.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(gcoc::SshPublicKeyName name, gcoc::SshPublicKey sshPublicKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSshPublicKeyAsync(new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SshPublicKey = gax::GaxPreconditions.CheckNotNull(sshPublicKey, nameof(sshPublicKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="name">
        /// Required. The fingerprint of the public key to update. Public keys are
        /// identified by their SHA-256 fingerprint. The fingerprint of the public key
        /// is in format `users/{user}/sshPublicKeys/{fingerprint}`.
        /// </param>
        /// <param name="sshPublicKey">
        /// Required. The SSH public key and expiration time.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated. Updates all if not present.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(gcoc::SshPublicKeyName name, gcoc::SshPublicKey sshPublicKey, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSshPublicKeyAsync(name, sshPublicKey, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OsLoginService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud OS Login API
    /// 
    /// The Cloud OS Login API allows you to manage users and their associated SSH
    /// public keys for logging into virtual machines on Google Cloud Platform.
    /// </remarks>
    public sealed partial class OsLoginServiceClientImpl : OsLoginServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSshPublicKeyRequest, gcoc::SshPublicKey> _callCreateSshPublicKey;

        private readonly gaxgrpc::ApiCall<DeletePosixAccountRequest, wkt::Empty> _callDeletePosixAccount;

        private readonly gaxgrpc::ApiCall<DeleteSshPublicKeyRequest, wkt::Empty> _callDeleteSshPublicKey;

        private readonly gaxgrpc::ApiCall<GetLoginProfileRequest, LoginProfile> _callGetLoginProfile;

        private readonly gaxgrpc::ApiCall<GetSshPublicKeyRequest, gcoc::SshPublicKey> _callGetSshPublicKey;

        private readonly gaxgrpc::ApiCall<ImportSshPublicKeyRequest, ImportSshPublicKeyResponse> _callImportSshPublicKey;

        private readonly gaxgrpc::ApiCall<UpdateSshPublicKeyRequest, gcoc::SshPublicKey> _callUpdateSshPublicKey;

        /// <summary>
        /// Constructs a client wrapper for the OsLoginService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OsLoginServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OsLoginServiceClientImpl(OsLoginService.OsLoginServiceClient grpcClient, OsLoginServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OsLoginServiceSettings effectiveSettings = settings ?? OsLoginServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateSshPublicKey = clientHelper.BuildApiCall<CreateSshPublicKeyRequest, gcoc::SshPublicKey>("CreateSshPublicKey", grpcClient.CreateSshPublicKeyAsync, grpcClient.CreateSshPublicKey, effectiveSettings.CreateSshPublicKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSshPublicKey);
            Modify_CreateSshPublicKeyApiCall(ref _callCreateSshPublicKey);
            _callDeletePosixAccount = clientHelper.BuildApiCall<DeletePosixAccountRequest, wkt::Empty>("DeletePosixAccount", grpcClient.DeletePosixAccountAsync, grpcClient.DeletePosixAccount, effectiveSettings.DeletePosixAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePosixAccount);
            Modify_DeletePosixAccountApiCall(ref _callDeletePosixAccount);
            _callDeleteSshPublicKey = clientHelper.BuildApiCall<DeleteSshPublicKeyRequest, wkt::Empty>("DeleteSshPublicKey", grpcClient.DeleteSshPublicKeyAsync, grpcClient.DeleteSshPublicKey, effectiveSettings.DeleteSshPublicKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSshPublicKey);
            Modify_DeleteSshPublicKeyApiCall(ref _callDeleteSshPublicKey);
            _callGetLoginProfile = clientHelper.BuildApiCall<GetLoginProfileRequest, LoginProfile>("GetLoginProfile", grpcClient.GetLoginProfileAsync, grpcClient.GetLoginProfile, effectiveSettings.GetLoginProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLoginProfile);
            Modify_GetLoginProfileApiCall(ref _callGetLoginProfile);
            _callGetSshPublicKey = clientHelper.BuildApiCall<GetSshPublicKeyRequest, gcoc::SshPublicKey>("GetSshPublicKey", grpcClient.GetSshPublicKeyAsync, grpcClient.GetSshPublicKey, effectiveSettings.GetSshPublicKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSshPublicKey);
            Modify_GetSshPublicKeyApiCall(ref _callGetSshPublicKey);
            _callImportSshPublicKey = clientHelper.BuildApiCall<ImportSshPublicKeyRequest, ImportSshPublicKeyResponse>("ImportSshPublicKey", grpcClient.ImportSshPublicKeyAsync, grpcClient.ImportSshPublicKey, effectiveSettings.ImportSshPublicKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportSshPublicKey);
            Modify_ImportSshPublicKeyApiCall(ref _callImportSshPublicKey);
            _callUpdateSshPublicKey = clientHelper.BuildApiCall<UpdateSshPublicKeyRequest, gcoc::SshPublicKey>("UpdateSshPublicKey", grpcClient.UpdateSshPublicKeyAsync, grpcClient.UpdateSshPublicKey, effectiveSettings.UpdateSshPublicKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateSshPublicKey);
            Modify_UpdateSshPublicKeyApiCall(ref _callUpdateSshPublicKey);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSshPublicKeyApiCall(ref gaxgrpc::ApiCall<CreateSshPublicKeyRequest, gcoc::SshPublicKey> call);

        partial void Modify_DeletePosixAccountApiCall(ref gaxgrpc::ApiCall<DeletePosixAccountRequest, wkt::Empty> call);

        partial void Modify_DeleteSshPublicKeyApiCall(ref gaxgrpc::ApiCall<DeleteSshPublicKeyRequest, wkt::Empty> call);

        partial void Modify_GetLoginProfileApiCall(ref gaxgrpc::ApiCall<GetLoginProfileRequest, LoginProfile> call);

        partial void Modify_GetSshPublicKeyApiCall(ref gaxgrpc::ApiCall<GetSshPublicKeyRequest, gcoc::SshPublicKey> call);

        partial void Modify_ImportSshPublicKeyApiCall(ref gaxgrpc::ApiCall<ImportSshPublicKeyRequest, ImportSshPublicKeyResponse> call);

        partial void Modify_UpdateSshPublicKeyApiCall(ref gaxgrpc::ApiCall<UpdateSshPublicKeyRequest, gcoc::SshPublicKey> call);

        partial void OnConstruction(OsLoginService.OsLoginServiceClient grpcClient, OsLoginServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OsLoginService client</summary>
        public override OsLoginService.OsLoginServiceClient GrpcClient { get; }

        partial void Modify_CreateSshPublicKeyRequest(ref CreateSshPublicKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePosixAccountRequest(ref DeletePosixAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSshPublicKeyRequest(ref DeleteSshPublicKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLoginProfileRequest(ref GetLoginProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSshPublicKeyRequest(ref GetSshPublicKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportSshPublicKeyRequest(ref ImportSshPublicKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSshPublicKeyRequest(ref UpdateSshPublicKeyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gcoc::SshPublicKey CreateSshPublicKey(CreateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSshPublicKeyRequest(ref request, ref callSettings);
            return _callCreateSshPublicKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an SSH public key
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gcoc::SshPublicKey> CreateSshPublicKeyAsync(CreateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSshPublicKeyRequest(ref request, ref callSettings);
            return _callCreateSshPublicKey.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePosixAccount(DeletePosixAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePosixAccountRequest(ref request, ref callSettings);
            _callDeletePosixAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a POSIX account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePosixAccountAsync(DeletePosixAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePosixAccountRequest(ref request, ref callSettings);
            return _callDeletePosixAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSshPublicKey(DeleteSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSshPublicKeyRequest(ref request, ref callSettings);
            _callDeleteSshPublicKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSshPublicKeyRequest(ref request, ref callSettings);
            return _callDeleteSshPublicKey.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LoginProfile GetLoginProfile(GetLoginProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLoginProfileRequest(ref request, ref callSettings);
            return _callGetLoginProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the profile information used for logging in to a virtual machine
        /// on Google Compute Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LoginProfile> GetLoginProfileAsync(GetLoginProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLoginProfileRequest(ref request, ref callSettings);
            return _callGetLoginProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gcoc::SshPublicKey GetSshPublicKey(GetSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSshPublicKeyRequest(ref request, ref callSettings);
            return _callGetSshPublicKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an SSH public key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gcoc::SshPublicKey> GetSshPublicKeyAsync(GetSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSshPublicKeyRequest(ref request, ref callSettings);
            return _callGetSshPublicKey.Async(request, callSettings);
        }

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImportSshPublicKeyResponse ImportSshPublicKey(ImportSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportSshPublicKeyRequest(ref request, ref callSettings);
            return _callImportSshPublicKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds an SSH public key and returns the profile information. Default POSIX
        /// account information is set when no username and UID exist as part of the
        /// login profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(ImportSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportSshPublicKeyRequest(ref request, ref callSettings);
            return _callImportSshPublicKey.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gcoc::SshPublicKey UpdateSshPublicKey(UpdateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSshPublicKeyRequest(ref request, ref callSettings);
            return _callUpdateSshPublicKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an SSH public key and returns the profile information. This method
        /// supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gcoc::SshPublicKey> UpdateSshPublicKeyAsync(UpdateSshPublicKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSshPublicKeyRequest(ref request, ref callSettings);
            return _callUpdateSshPublicKey.Async(request, callSettings);
        }
    }
}
