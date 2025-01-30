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
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Iam.Credentials.V1
{
    /// <summary>Settings for <see cref="IAMCredentialsClient"/> instances.</summary>
    public sealed partial class IAMCredentialsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IAMCredentialsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IAMCredentialsSettings"/>.</returns>
        public static IAMCredentialsSettings GetDefault() => new IAMCredentialsSettings();

        /// <summary>Constructs a new <see cref="IAMCredentialsSettings"/> object with default settings.</summary>
        public IAMCredentialsSettings()
        {
        }

        private IAMCredentialsSettings(IAMCredentialsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateAccessTokenSettings = existing.GenerateAccessTokenSettings;
            GenerateIdTokenSettings = existing.GenerateIdTokenSettings;
            SignBlobSettings = existing.SignBlobSettings;
            SignJwtSettings = existing.SignJwtSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IAMCredentialsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMCredentialsClient.GenerateAccessToken</c> and <c>IAMCredentialsClient.GenerateAccessTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateAccessTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMCredentialsClient.GenerateIdToken</c> and <c>IAMCredentialsClient.GenerateIdTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateIdTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMCredentialsClient.SignBlob</c> and <c>IAMCredentialsClient.SignBlobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SignBlobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IAMCredentialsClient.SignJwt</c> and <c>IAMCredentialsClient.SignJwtAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SignJwtSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IAMCredentialsSettings"/> object.</returns>
        public IAMCredentialsSettings Clone() => new IAMCredentialsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IAMCredentialsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class IAMCredentialsClientBuilder : gaxgrpc::ClientBuilderBase<IAMCredentialsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IAMCredentialsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IAMCredentialsClientBuilder() : base(IAMCredentialsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IAMCredentialsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IAMCredentialsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IAMCredentialsClient Build()
        {
            IAMCredentialsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IAMCredentialsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IAMCredentialsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IAMCredentialsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IAMCredentialsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IAMCredentialsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IAMCredentialsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IAMCredentialsClient.ChannelPool;
    }

    /// <summary>IAMCredentials client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service account is a special type of Google account that belongs to your
    /// application or a virtual machine (VM), instead of to an individual end user.
    /// Your application assumes the identity of the service account to call Google
    /// APIs, so that the users aren't directly involved.
    /// 
    /// Service account credentials are used to temporarily assume the identity
    /// of the service account. Supported credential types include OAuth 2.0 access
    /// tokens, OpenID Connect ID tokens, self-signed JSON Web Tokens (JWTs), and
    /// more.
    /// </remarks>
    public abstract partial class IAMCredentialsClient
    {
        /// <summary>
        /// The default endpoint for the IAMCredentials service, which is a host of "iamcredentials.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iamcredentials.googleapis.com:443";

        /// <summary>The default IAMCredentials scopes.</summary>
        /// <remarks>
        /// The default IAMCredentials scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IAMCredentials.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IAMCredentialsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IAMCredentialsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IAMCredentialsClient"/>.</returns>
        public static stt::Task<IAMCredentialsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IAMCredentialsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IAMCredentialsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IAMCredentialsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IAMCredentialsClient"/>.</returns>
        public static IAMCredentialsClient Create() => new IAMCredentialsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IAMCredentialsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IAMCredentialsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IAMCredentialsClient"/>.</returns>
        internal static IAMCredentialsClient Create(grpccore::CallInvoker callInvoker, IAMCredentialsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IAMCredentials.IAMCredentialsClient grpcClient = new IAMCredentials.IAMCredentialsClient(callInvoker);
            return new IAMCredentialsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IAMCredentials client</summary>
        public virtual IAMCredentials.IAMCredentialsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAccessTokenResponse GenerateAccessToken(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(GenerateAccessTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateAccessTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="scope">
        /// Required. Code to identify the scopes to be included in the OAuth 2.0 access token.
        /// See https://developers.google.com/identity/protocols/googlescopes for more
        /// information.
        /// At least one value required.
        /// </param>
        /// <param name="lifetime">
        /// The desired lifetime duration of the access token in seconds.
        /// Must be set to a value less than or equal to 3600 (1 hour). If a value is
        /// not specified, the token's lifetime will be set to a default value of one
        /// hour.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAccessTokenResponse GenerateAccessToken(string name, scg::IEnumerable<string> delegates, scg::IEnumerable<string> scope, wkt::Duration lifetime, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessToken(new GenerateAccessTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Scope =
                {
                    gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                },
                Lifetime = lifetime,
            }, callSettings);

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="scope">
        /// Required. Code to identify the scopes to be included in the OAuth 2.0 access token.
        /// See https://developers.google.com/identity/protocols/googlescopes for more
        /// information.
        /// At least one value required.
        /// </param>
        /// <param name="lifetime">
        /// The desired lifetime duration of the access token in seconds.
        /// Must be set to a value less than or equal to 3600 (1 hour). If a value is
        /// not specified, the token's lifetime will be set to a default value of one
        /// hour.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(string name, scg::IEnumerable<string> delegates, scg::IEnumerable<string> scope, wkt::Duration lifetime, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessTokenAsync(new GenerateAccessTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Scope =
                {
                    gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                },
                Lifetime = lifetime,
            }, callSettings);

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="scope">
        /// Required. Code to identify the scopes to be included in the OAuth 2.0 access token.
        /// See https://developers.google.com/identity/protocols/googlescopes for more
        /// information.
        /// At least one value required.
        /// </param>
        /// <param name="lifetime">
        /// The desired lifetime duration of the access token in seconds.
        /// Must be set to a value less than or equal to 3600 (1 hour). If a value is
        /// not specified, the token's lifetime will be set to a default value of one
        /// hour.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(string name, scg::IEnumerable<string> delegates, scg::IEnumerable<string> scope, wkt::Duration lifetime, st::CancellationToken cancellationToken) =>
            GenerateAccessTokenAsync(name, delegates, scope, lifetime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="scope">
        /// Required. Code to identify the scopes to be included in the OAuth 2.0 access token.
        /// See https://developers.google.com/identity/protocols/googlescopes for more
        /// information.
        /// At least one value required.
        /// </param>
        /// <param name="lifetime">
        /// The desired lifetime duration of the access token in seconds.
        /// Must be set to a value less than or equal to 3600 (1 hour). If a value is
        /// not specified, the token's lifetime will be set to a default value of one
        /// hour.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAccessTokenResponse GenerateAccessToken(ServiceAccountName name, scg::IEnumerable<string> delegates, scg::IEnumerable<string> scope, wkt::Duration lifetime, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessToken(new GenerateAccessTokenRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Scope =
                {
                    gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                },
                Lifetime = lifetime,
            }, callSettings);

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="scope">
        /// Required. Code to identify the scopes to be included in the OAuth 2.0 access token.
        /// See https://developers.google.com/identity/protocols/googlescopes for more
        /// information.
        /// At least one value required.
        /// </param>
        /// <param name="lifetime">
        /// The desired lifetime duration of the access token in seconds.
        /// Must be set to a value less than or equal to 3600 (1 hour). If a value is
        /// not specified, the token's lifetime will be set to a default value of one
        /// hour.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, scg::IEnumerable<string> scope, wkt::Duration lifetime, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAccessTokenAsync(new GenerateAccessTokenRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Scope =
                {
                    gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                },
                Lifetime = lifetime,
            }, callSettings);

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="scope">
        /// Required. Code to identify the scopes to be included in the OAuth 2.0 access token.
        /// See https://developers.google.com/identity/protocols/googlescopes for more
        /// information.
        /// At least one value required.
        /// </param>
        /// <param name="lifetime">
        /// The desired lifetime duration of the access token in seconds.
        /// Must be set to a value less than or equal to 3600 (1 hour). If a value is
        /// not specified, the token's lifetime will be set to a default value of one
        /// hour.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, scg::IEnumerable<string> scope, wkt::Duration lifetime, st::CancellationToken cancellationToken) =>
            GenerateAccessTokenAsync(name, delegates, scope, lifetime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateIdTokenResponse GenerateIdToken(GenerateIdTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIdTokenResponse> GenerateIdTokenAsync(GenerateIdTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIdTokenResponse> GenerateIdTokenAsync(GenerateIdTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateIdTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="audience">
        /// Required. The audience for the token, such as the API or account that this token
        /// grants access to.
        /// </param>
        /// <param name="includeEmail">
        /// Include the service account email in the token. If set to `true`, the
        /// token will contain `email` and `email_verified` claims.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateIdTokenResponse GenerateIdToken(string name, scg::IEnumerable<string> delegates, string audience, bool includeEmail, gaxgrpc::CallSettings callSettings = null) =>
            GenerateIdToken(new GenerateIdTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Audience = gax::GaxPreconditions.CheckNotNullOrEmpty(audience, nameof(audience)),
                IncludeEmail = includeEmail,
            }, callSettings);

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="audience">
        /// Required. The audience for the token, such as the API or account that this token
        /// grants access to.
        /// </param>
        /// <param name="includeEmail">
        /// Include the service account email in the token. If set to `true`, the
        /// token will contain `email` and `email_verified` claims.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIdTokenResponse> GenerateIdTokenAsync(string name, scg::IEnumerable<string> delegates, string audience, bool includeEmail, gaxgrpc::CallSettings callSettings = null) =>
            GenerateIdTokenAsync(new GenerateIdTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Audience = gax::GaxPreconditions.CheckNotNullOrEmpty(audience, nameof(audience)),
                IncludeEmail = includeEmail,
            }, callSettings);

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="audience">
        /// Required. The audience for the token, such as the API or account that this token
        /// grants access to.
        /// </param>
        /// <param name="includeEmail">
        /// Include the service account email in the token. If set to `true`, the
        /// token will contain `email` and `email_verified` claims.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIdTokenResponse> GenerateIdTokenAsync(string name, scg::IEnumerable<string> delegates, string audience, bool includeEmail, st::CancellationToken cancellationToken) =>
            GenerateIdTokenAsync(name, delegates, audience, includeEmail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="audience">
        /// Required. The audience for the token, such as the API or account that this token
        /// grants access to.
        /// </param>
        /// <param name="includeEmail">
        /// Include the service account email in the token. If set to `true`, the
        /// token will contain `email` and `email_verified` claims.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateIdTokenResponse GenerateIdToken(ServiceAccountName name, scg::IEnumerable<string> delegates, string audience, bool includeEmail, gaxgrpc::CallSettings callSettings = null) =>
            GenerateIdToken(new GenerateIdTokenRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Audience = gax::GaxPreconditions.CheckNotNullOrEmpty(audience, nameof(audience)),
                IncludeEmail = includeEmail,
            }, callSettings);

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="audience">
        /// Required. The audience for the token, such as the API or account that this token
        /// grants access to.
        /// </param>
        /// <param name="includeEmail">
        /// Include the service account email in the token. If set to `true`, the
        /// token will contain `email` and `email_verified` claims.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIdTokenResponse> GenerateIdTokenAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, string audience, bool includeEmail, gaxgrpc::CallSettings callSettings = null) =>
            GenerateIdTokenAsync(new GenerateIdTokenRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Audience = gax::GaxPreconditions.CheckNotNullOrEmpty(audience, nameof(audience)),
                IncludeEmail = includeEmail,
            }, callSettings);

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="audience">
        /// Required. The audience for the token, such as the API or account that this token
        /// grants access to.
        /// </param>
        /// <param name="includeEmail">
        /// Include the service account email in the token. If set to `true`, the
        /// token will contain `email` and `email_verified` claims.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIdTokenResponse> GenerateIdTokenAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, string audience, bool includeEmail, st::CancellationToken cancellationToken) =>
            GenerateIdTokenAsync(name, delegates, audience, includeEmail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SignBlobResponse SignBlob(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(SignBlobRequest request, st::CancellationToken cancellationToken) =>
            SignBlobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SignBlobResponse SignBlob(string name, scg::IEnumerable<string> delegates, proto::ByteString payload, gaxgrpc::CallSettings callSettings = null) =>
            SignBlob(new SignBlobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(string name, scg::IEnumerable<string> delegates, proto::ByteString payload, gaxgrpc::CallSettings callSettings = null) =>
            SignBlobAsync(new SignBlobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The bytes to sign.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(string name, scg::IEnumerable<string> delegates, proto::ByteString payload, st::CancellationToken cancellationToken) =>
            SignBlobAsync(name, delegates, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SignBlobResponse SignBlob(ServiceAccountName name, scg::IEnumerable<string> delegates, proto::ByteString payload, gaxgrpc::CallSettings callSettings = null) =>
            SignBlob(new SignBlobRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The bytes to sign.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, proto::ByteString payload, gaxgrpc::CallSettings callSettings = null) =>
            SignBlobAsync(new SignBlobRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The bytes to sign.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignBlobResponse> SignBlobAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, proto::ByteString payload, st::CancellationToken cancellationToken) =>
            SignBlobAsync(name, delegates, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SignJwtResponse SignJwt(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(SignJwtRequest request, st::CancellationToken cancellationToken) =>
            SignJwtAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The JWT payload to sign: a JSON object that contains a JWT Claims Set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SignJwtResponse SignJwt(string name, scg::IEnumerable<string> delegates, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwt(new SignJwtRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The JWT payload to sign: a JSON object that contains a JWT Claims Set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(string name, scg::IEnumerable<string> delegates, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwtAsync(new SignJwtRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The JWT payload to sign: a JSON object that contains a JWT Claims Set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(string name, scg::IEnumerable<string> delegates, string payload, st::CancellationToken cancellationToken) =>
            SignJwtAsync(name, delegates, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The JWT payload to sign: a JSON object that contains a JWT Claims Set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SignJwtResponse SignJwt(ServiceAccountName name, scg::IEnumerable<string> delegates, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwt(new SignJwtRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The JWT payload to sign: a JSON object that contains a JWT Claims Set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, string payload, gaxgrpc::CallSettings callSettings = null) =>
            SignJwtAsync(new SignJwtRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Delegates =
                {
                    delegates ?? linq::Enumerable.Empty<string>(),
                },
                Payload = gax::GaxPreconditions.CheckNotNullOrEmpty(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the service account for which the credentials
        /// are requested, in the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="delegates">
        /// The sequence of service accounts in a delegation chain. Each service
        /// account must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on its next service account in the chain. The last service account in the
        /// chain must be granted the `roles/iam.serviceAccountTokenCreator` role
        /// on the service account that is specified in the `name` field of the
        /// request.
        /// 
        /// The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
        /// character is required; replacing it with a project ID is invalid.
        /// </param>
        /// <param name="payload">
        /// Required. The JWT payload to sign: a JSON object that contains a JWT Claims Set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SignJwtResponse> SignJwtAsync(ServiceAccountName name, scg::IEnumerable<string> delegates, string payload, st::CancellationToken cancellationToken) =>
            SignJwtAsync(name, delegates, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IAMCredentials client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service account is a special type of Google account that belongs to your
    /// application or a virtual machine (VM), instead of to an individual end user.
    /// Your application assumes the identity of the service account to call Google
    /// APIs, so that the users aren't directly involved.
    /// 
    /// Service account credentials are used to temporarily assume the identity
    /// of the service account. Supported credential types include OAuth 2.0 access
    /// tokens, OpenID Connect ID tokens, self-signed JSON Web Tokens (JWTs), and
    /// more.
    /// </remarks>
    public sealed partial class IAMCredentialsClientImpl : IAMCredentialsClient
    {
        private readonly gaxgrpc::ApiCall<GenerateAccessTokenRequest, GenerateAccessTokenResponse> _callGenerateAccessToken;

        private readonly gaxgrpc::ApiCall<GenerateIdTokenRequest, GenerateIdTokenResponse> _callGenerateIdToken;

        private readonly gaxgrpc::ApiCall<SignBlobRequest, SignBlobResponse> _callSignBlob;

        private readonly gaxgrpc::ApiCall<SignJwtRequest, SignJwtResponse> _callSignJwt;

        /// <summary>
        /// Constructs a client wrapper for the IAMCredentials service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IAMCredentialsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IAMCredentialsClientImpl(IAMCredentials.IAMCredentialsClient grpcClient, IAMCredentialsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IAMCredentialsSettings effectiveSettings = settings ?? IAMCredentialsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGenerateAccessToken = clientHelper.BuildApiCall<GenerateAccessTokenRequest, GenerateAccessTokenResponse>("GenerateAccessToken", grpcClient.GenerateAccessTokenAsync, grpcClient.GenerateAccessToken, effectiveSettings.GenerateAccessTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateAccessToken);
            Modify_GenerateAccessTokenApiCall(ref _callGenerateAccessToken);
            _callGenerateIdToken = clientHelper.BuildApiCall<GenerateIdTokenRequest, GenerateIdTokenResponse>("GenerateIdToken", grpcClient.GenerateIdTokenAsync, grpcClient.GenerateIdToken, effectiveSettings.GenerateIdTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateIdToken);
            Modify_GenerateIdTokenApiCall(ref _callGenerateIdToken);
            _callSignBlob = clientHelper.BuildApiCall<SignBlobRequest, SignBlobResponse>("SignBlob", grpcClient.SignBlobAsync, grpcClient.SignBlob, effectiveSettings.SignBlobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSignBlob);
            Modify_SignBlobApiCall(ref _callSignBlob);
            _callSignJwt = clientHelper.BuildApiCall<SignJwtRequest, SignJwtResponse>("SignJwt", grpcClient.SignJwtAsync, grpcClient.SignJwt, effectiveSettings.SignJwtSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSignJwt);
            Modify_SignJwtApiCall(ref _callSignJwt);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateAccessTokenApiCall(ref gaxgrpc::ApiCall<GenerateAccessTokenRequest, GenerateAccessTokenResponse> call);

        partial void Modify_GenerateIdTokenApiCall(ref gaxgrpc::ApiCall<GenerateIdTokenRequest, GenerateIdTokenResponse> call);

        partial void Modify_SignBlobApiCall(ref gaxgrpc::ApiCall<SignBlobRequest, SignBlobResponse> call);

        partial void Modify_SignJwtApiCall(ref gaxgrpc::ApiCall<SignJwtRequest, SignJwtResponse> call);

        partial void OnConstruction(IAMCredentials.IAMCredentialsClient grpcClient, IAMCredentialsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IAMCredentials client</summary>
        public override IAMCredentials.IAMCredentialsClient GrpcClient { get; }

        partial void Modify_GenerateAccessTokenRequest(ref GenerateAccessTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateIdTokenRequest(ref GenerateIdTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SignBlobRequest(ref SignBlobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SignJwtRequest(ref SignJwtRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAccessTokenResponse GenerateAccessToken(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAccessToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates an OAuth 2.0 access token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAccessTokenResponse> GenerateAccessTokenAsync(GenerateAccessTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAccessTokenRequest(ref request, ref callSettings);
            return _callGenerateAccessToken.Async(request, callSettings);
        }

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateIdTokenResponse GenerateIdToken(GenerateIdTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateIdTokenRequest(ref request, ref callSettings);
            return _callGenerateIdToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates an OpenID Connect ID token for a service account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateIdTokenResponse> GenerateIdTokenAsync(GenerateIdTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateIdTokenRequest(ref request, ref callSettings);
            return _callGenerateIdToken.Async(request, callSettings);
        }

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SignBlobResponse SignBlob(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignBlobRequest(ref request, ref callSettings);
            return _callSignBlob.Sync(request, callSettings);
        }

        /// <summary>
        /// Signs a blob using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SignBlobResponse> SignBlobAsync(SignBlobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignBlobRequest(ref request, ref callSettings);
            return _callSignBlob.Async(request, callSettings);
        }

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SignJwtResponse SignJwt(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignJwtRequest(ref request, ref callSettings);
            return _callSignJwt.Sync(request, callSettings);
        }

        /// <summary>
        /// Signs a JWT using a service account's system-managed private key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SignJwtResponse> SignJwtAsync(SignJwtRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SignJwtRequest(ref request, ref callSettings);
            return _callSignJwt.Async(request, callSettings);
        }
    }
}
