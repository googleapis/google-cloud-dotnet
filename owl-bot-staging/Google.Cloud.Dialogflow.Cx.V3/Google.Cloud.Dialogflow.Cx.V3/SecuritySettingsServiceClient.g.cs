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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="SecuritySettingsServiceClient"/> instances.</summary>
    public sealed partial class SecuritySettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SecuritySettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SecuritySettingsServiceSettings"/>.</returns>
        public static SecuritySettingsServiceSettings GetDefault() => new SecuritySettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SecuritySettingsServiceSettings"/> object with default settings.
        /// </summary>
        public SecuritySettingsServiceSettings()
        {
        }

        private SecuritySettingsServiceSettings(SecuritySettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSecuritySettingsSettings = existing.CreateSecuritySettingsSettings;
            GetSecuritySettingsSettings = existing.GetSecuritySettingsSettings;
            UpdateSecuritySettingsSettings = existing.UpdateSecuritySettingsSettings;
            ListSecuritySettingsSettings = existing.ListSecuritySettingsSettings;
            DeleteSecuritySettingsSettings = existing.DeleteSecuritySettingsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SecuritySettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecuritySettingsServiceClient.CreateSecuritySettings</c> and
        /// <c>SecuritySettingsServiceClient.CreateSecuritySettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSecuritySettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecuritySettingsServiceClient.GetSecuritySettings</c> and
        /// <c>SecuritySettingsServiceClient.GetSecuritySettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSecuritySettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecuritySettingsServiceClient.UpdateSecuritySettings</c> and
        /// <c>SecuritySettingsServiceClient.UpdateSecuritySettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSecuritySettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecuritySettingsServiceClient.ListSecuritySettings</c> and
        /// <c>SecuritySettingsServiceClient.ListSecuritySettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSecuritySettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecuritySettingsServiceClient.DeleteSecuritySettings</c> and
        /// <c>SecuritySettingsServiceClient.DeleteSecuritySettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSecuritySettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SecuritySettingsServiceSettings"/> object.</returns>
        public SecuritySettingsServiceSettings Clone() => new SecuritySettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SecuritySettingsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SecuritySettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SecuritySettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SecuritySettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SecuritySettingsServiceClientBuilder() : base(SecuritySettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SecuritySettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SecuritySettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SecuritySettingsServiceClient Build()
        {
            SecuritySettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SecuritySettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SecuritySettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SecuritySettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SecuritySettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SecuritySettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SecuritySettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SecuritySettingsServiceClient.ChannelPool;
    }

    /// <summary>SecuritySettingsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing security settings for Dialogflow.
    /// </remarks>
    public abstract partial class SecuritySettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SecuritySettingsService service, which is a host of "dialogflow.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default SecuritySettingsService scopes.</summary>
        /// <remarks>
        /// The default SecuritySettingsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SecuritySettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SecuritySettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SecuritySettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SecuritySettingsServiceClient"/>.</returns>
        public static stt::Task<SecuritySettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SecuritySettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SecuritySettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SecuritySettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SecuritySettingsServiceClient"/>.</returns>
        public static SecuritySettingsServiceClient Create() => new SecuritySettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SecuritySettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SecuritySettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SecuritySettingsServiceClient"/>.</returns>
        internal static SecuritySettingsServiceClient Create(grpccore::CallInvoker callInvoker, SecuritySettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SecuritySettingsService.SecuritySettingsServiceClient grpcClient = new SecuritySettingsService.SecuritySettingsServiceClient(callInvoker);
            return new SecuritySettingsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SecuritySettingsService client</summary>
        public virtual SecuritySettingsService.SecuritySettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings CreateSecuritySettings(CreateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> CreateSecuritySettingsAsync(CreateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> CreateSecuritySettingsAsync(CreateSecuritySettingsRequest request, st::CancellationToken cancellationToken) =>
            CreateSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create an
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
        /// </param>
        /// <param name="securitySettings">
        /// Required. The security settings to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings CreateSecuritySettings(string parent, SecuritySettings securitySettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecuritySettings(new CreateSecuritySettingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecuritySettings = gax::GaxPreconditions.CheckNotNull(securitySettings, nameof(securitySettings)),
            }, callSettings);

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create an
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
        /// </param>
        /// <param name="securitySettings">
        /// Required. The security settings to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> CreateSecuritySettingsAsync(string parent, SecuritySettings securitySettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecuritySettingsAsync(new CreateSecuritySettingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecuritySettings = gax::GaxPreconditions.CheckNotNull(securitySettings, nameof(securitySettings)),
            }, callSettings);

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create an
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
        /// </param>
        /// <param name="securitySettings">
        /// Required. The security settings to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> CreateSecuritySettingsAsync(string parent, SecuritySettings securitySettings, st::CancellationToken cancellationToken) =>
            CreateSecuritySettingsAsync(parent, securitySettings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create an
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
        /// </param>
        /// <param name="securitySettings">
        /// Required. The security settings to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings CreateSecuritySettings(gagr::LocationName parent, SecuritySettings securitySettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecuritySettings(new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecuritySettings = gax::GaxPreconditions.CheckNotNull(securitySettings, nameof(securitySettings)),
            }, callSettings);

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create an
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
        /// </param>
        /// <param name="securitySettings">
        /// Required. The security settings to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> CreateSecuritySettingsAsync(gagr::LocationName parent, SecuritySettings securitySettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecuritySettingsAsync(new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecuritySettings = gax::GaxPreconditions.CheckNotNull(securitySettings, nameof(securitySettings)),
            }, callSettings);

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create an
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
        /// </param>
        /// <param name="securitySettings">
        /// Required. The security settings to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> CreateSecuritySettingsAsync(gagr::LocationName parent, SecuritySettings securitySettings, st::CancellationToken cancellationToken) =>
            CreateSecuritySettingsAsync(parent, securitySettings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings GetSecuritySettings(GetSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> GetSecuritySettingsAsync(GetSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> GetSecuritySettingsAsync(GetSecuritySettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the settings.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;securitysettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings GetSecuritySettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecuritySettings(new GetSecuritySettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the settings.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;securitysettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> GetSecuritySettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecuritySettingsAsync(new GetSecuritySettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the settings.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;securitysettingsID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> GetSecuritySettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSecuritySettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the settings.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;securitysettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings GetSecuritySettings(SecuritySettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecuritySettings(new GetSecuritySettingsRequest
            {
                SecuritySettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the settings.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;securitysettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> GetSecuritySettingsAsync(SecuritySettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecuritySettingsAsync(new GetSecuritySettingsRequest
            {
                SecuritySettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the settings.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;securitysettingsID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> GetSecuritySettingsAsync(SecuritySettingsName name, st::CancellationToken cancellationToken) =>
            GetSecuritySettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings UpdateSecuritySettings(UpdateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> UpdateSecuritySettingsAsync(UpdateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> UpdateSecuritySettingsAsync(UpdateSecuritySettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="securitySettings">
        /// Required. [SecuritySettings] object that contains values for each of the
        /// fields to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecuritySettings UpdateSecuritySettings(SecuritySettings securitySettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecuritySettings(new UpdateSecuritySettingsRequest
            {
                SecuritySettings = gax::GaxPreconditions.CheckNotNull(securitySettings, nameof(securitySettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="securitySettings">
        /// Required. [SecuritySettings] object that contains values for each of the
        /// fields to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> UpdateSecuritySettingsAsync(SecuritySettings securitySettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecuritySettingsAsync(new UpdateSecuritySettingsRequest
            {
                SecuritySettings = gax::GaxPreconditions.CheckNotNull(securitySettings, nameof(securitySettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="securitySettings">
        /// Required. [SecuritySettings] object that contains values for each of the
        /// fields to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecuritySettings> UpdateSecuritySettingsAsync(SecuritySettings securitySettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSecuritySettingsAsync(securitySettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecuritySettings"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettings(ListSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecuritySettings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettingsAsync(ListSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all security settings for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="SecuritySettings"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecuritySettingsRequest request = new ListSecuritySettingsRequest
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
            return ListSecuritySettings(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all security settings for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecuritySettings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecuritySettingsRequest request = new ListSecuritySettingsRequest
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
            return ListSecuritySettingsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all security settings for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="SecuritySettings"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettings(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecuritySettingsRequest request = new ListSecuritySettingsRequest
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
            return ListSecuritySettings(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all security settings for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecuritySettings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettingsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecuritySettingsRequest request = new ListSecuritySettingsRequest
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
            return ListSecuritySettingsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecuritySettings(DeleteSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecuritySettingsAsync(DeleteSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecuritySettingsAsync(DeleteSecuritySettingsRequest request, st::CancellationToken cancellationToken) =>
            DeleteSecuritySettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] to
        /// delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;SecuritySettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecuritySettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecuritySettings(new DeleteSecuritySettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] to
        /// delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;SecuritySettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecuritySettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecuritySettingsAsync(new DeleteSecuritySettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] to
        /// delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;SecuritySettingsID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecuritySettingsAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSecuritySettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] to
        /// delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;SecuritySettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecuritySettings(SecuritySettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecuritySettings(new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] to
        /// delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;SecuritySettingsID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecuritySettingsAsync(SecuritySettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecuritySettingsAsync(new DeleteSecuritySettingsRequest
            {
                SecuritySettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings] to
        /// delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/securitySettings/&lt;SecuritySettingsID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecuritySettingsAsync(SecuritySettingsName name, st::CancellationToken cancellationToken) =>
            DeleteSecuritySettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SecuritySettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing security settings for Dialogflow.
    /// </remarks>
    public sealed partial class SecuritySettingsServiceClientImpl : SecuritySettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSecuritySettingsRequest, SecuritySettings> _callCreateSecuritySettings;

        private readonly gaxgrpc::ApiCall<GetSecuritySettingsRequest, SecuritySettings> _callGetSecuritySettings;

        private readonly gaxgrpc::ApiCall<UpdateSecuritySettingsRequest, SecuritySettings> _callUpdateSecuritySettings;

        private readonly gaxgrpc::ApiCall<ListSecuritySettingsRequest, ListSecuritySettingsResponse> _callListSecuritySettings;

        private readonly gaxgrpc::ApiCall<DeleteSecuritySettingsRequest, wkt::Empty> _callDeleteSecuritySettings;

        /// <summary>
        /// Constructs a client wrapper for the SecuritySettingsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SecuritySettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SecuritySettingsServiceClientImpl(SecuritySettingsService.SecuritySettingsServiceClient grpcClient, SecuritySettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SecuritySettingsServiceSettings effectiveSettings = settings ?? SecuritySettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateSecuritySettings = clientHelper.BuildApiCall<CreateSecuritySettingsRequest, SecuritySettings>("CreateSecuritySettings", grpcClient.CreateSecuritySettingsAsync, grpcClient.CreateSecuritySettings, effectiveSettings.CreateSecuritySettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSecuritySettings);
            Modify_CreateSecuritySettingsApiCall(ref _callCreateSecuritySettings);
            _callGetSecuritySettings = clientHelper.BuildApiCall<GetSecuritySettingsRequest, SecuritySettings>("GetSecuritySettings", grpcClient.GetSecuritySettingsAsync, grpcClient.GetSecuritySettings, effectiveSettings.GetSecuritySettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSecuritySettings);
            Modify_GetSecuritySettingsApiCall(ref _callGetSecuritySettings);
            _callUpdateSecuritySettings = clientHelper.BuildApiCall<UpdateSecuritySettingsRequest, SecuritySettings>("UpdateSecuritySettings", grpcClient.UpdateSecuritySettingsAsync, grpcClient.UpdateSecuritySettings, effectiveSettings.UpdateSecuritySettingsSettings).WithGoogleRequestParam("security_settings.name", request => request.SecuritySettings?.Name);
            Modify_ApiCall(ref _callUpdateSecuritySettings);
            Modify_UpdateSecuritySettingsApiCall(ref _callUpdateSecuritySettings);
            _callListSecuritySettings = clientHelper.BuildApiCall<ListSecuritySettingsRequest, ListSecuritySettingsResponse>("ListSecuritySettings", grpcClient.ListSecuritySettingsAsync, grpcClient.ListSecuritySettings, effectiveSettings.ListSecuritySettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSecuritySettings);
            Modify_ListSecuritySettingsApiCall(ref _callListSecuritySettings);
            _callDeleteSecuritySettings = clientHelper.BuildApiCall<DeleteSecuritySettingsRequest, wkt::Empty>("DeleteSecuritySettings", grpcClient.DeleteSecuritySettingsAsync, grpcClient.DeleteSecuritySettings, effectiveSettings.DeleteSecuritySettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSecuritySettings);
            Modify_DeleteSecuritySettingsApiCall(ref _callDeleteSecuritySettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSecuritySettingsApiCall(ref gaxgrpc::ApiCall<CreateSecuritySettingsRequest, SecuritySettings> call);

        partial void Modify_GetSecuritySettingsApiCall(ref gaxgrpc::ApiCall<GetSecuritySettingsRequest, SecuritySettings> call);

        partial void Modify_UpdateSecuritySettingsApiCall(ref gaxgrpc::ApiCall<UpdateSecuritySettingsRequest, SecuritySettings> call);

        partial void Modify_ListSecuritySettingsApiCall(ref gaxgrpc::ApiCall<ListSecuritySettingsRequest, ListSecuritySettingsResponse> call);

        partial void Modify_DeleteSecuritySettingsApiCall(ref gaxgrpc::ApiCall<DeleteSecuritySettingsRequest, wkt::Empty> call);

        partial void OnConstruction(SecuritySettingsService.SecuritySettingsServiceClient grpcClient, SecuritySettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SecuritySettingsService client</summary>
        public override SecuritySettingsService.SecuritySettingsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateSecuritySettingsRequest(ref CreateSecuritySettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSecuritySettingsRequest(ref GetSecuritySettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSecuritySettingsRequest(ref UpdateSecuritySettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSecuritySettingsRequest(ref ListSecuritySettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSecuritySettingsRequest(ref DeleteSecuritySettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecuritySettings CreateSecuritySettings(CreateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecuritySettingsRequest(ref request, ref callSettings);
            return _callCreateSecuritySettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Create security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecuritySettings> CreateSecuritySettingsAsync(CreateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecuritySettingsRequest(ref request, ref callSettings);
            return _callCreateSecuritySettings.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecuritySettings GetSecuritySettings(GetSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecuritySettingsRequest(ref request, ref callSettings);
            return _callGetSecuritySettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings]. The
        /// returned settings may be stale by up to 1 minute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecuritySettings> GetSecuritySettingsAsync(GetSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecuritySettingsRequest(ref request, ref callSettings);
            return _callGetSecuritySettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecuritySettings UpdateSecuritySettings(UpdateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecuritySettingsRequest(ref request, ref callSettings);
            return _callUpdateSecuritySettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecuritySettings> UpdateSecuritySettingsAsync(UpdateSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecuritySettingsRequest(ref request, ref callSettings);
            return _callUpdateSecuritySettings.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecuritySettings"/> resources.</returns>
        public override gax::PagedEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettings(ListSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecuritySettingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSecuritySettingsRequest, ListSecuritySettingsResponse, SecuritySettings>(_callListSecuritySettings, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all security settings in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecuritySettings"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSecuritySettingsResponse, SecuritySettings> ListSecuritySettingsAsync(ListSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecuritySettingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSecuritySettingsRequest, ListSecuritySettingsResponse, SecuritySettings>(_callListSecuritySettings, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSecuritySettings(DeleteSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecuritySettingsRequest(ref request, ref callSettings);
            _callDeleteSecuritySettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [SecuritySettings][google.cloud.dialogflow.cx.v3.SecuritySettings].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSecuritySettingsAsync(DeleteSecuritySettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecuritySettingsRequest(ref request, ref callSettings);
            return _callDeleteSecuritySettings.Async(request, callSettings);
        }
    }

    public partial class ListSecuritySettingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSecuritySettingsResponse : gaxgrpc::IPageResponse<SecuritySettings>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SecuritySettings> GetEnumerator() => SecuritySettings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SecuritySettingsService
    {
        public partial class SecuritySettingsServiceClient
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
