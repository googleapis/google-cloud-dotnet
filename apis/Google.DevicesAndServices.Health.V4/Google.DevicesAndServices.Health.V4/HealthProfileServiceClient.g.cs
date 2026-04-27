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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.DevicesAndServices.Health.V4
{
    /// <summary>Settings for <see cref="HealthProfileServiceClient"/> instances.</summary>
    public sealed partial class HealthProfileServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HealthProfileServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HealthProfileServiceSettings"/>.</returns>
        public static HealthProfileServiceSettings GetDefault() => new HealthProfileServiceSettings();

        /// <summary>Constructs a new <see cref="HealthProfileServiceSettings"/> object with default settings.</summary>
        public HealthProfileServiceSettings()
        {
        }

        private HealthProfileServiceSettings(HealthProfileServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProfileSettings = existing.GetProfileSettings;
            UpdateProfileSettings = existing.UpdateProfileSettings;
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            GetIdentitySettings = existing.GetIdentitySettings;
            OnCopy(existing);
        }

        partial void OnCopy(HealthProfileServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HealthProfileServiceClient.GetProfile</c> and <c>HealthProfileServiceClient.GetProfileAsync</c>.
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
        public gaxgrpc::CallSettings GetProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HealthProfileServiceClient.UpdateProfile</c> and <c>HealthProfileServiceClient.UpdateProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HealthProfileServiceClient.GetSettings</c> and <c>HealthProfileServiceClient.GetSettingsAsync</c>.
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
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HealthProfileServiceClient.UpdateSettings</c> and <c>HealthProfileServiceClient.UpdateSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HealthProfileServiceClient.GetIdentity</c> and <c>HealthProfileServiceClient.GetIdentityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIdentitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HealthProfileServiceSettings"/> object.</returns>
        public HealthProfileServiceSettings Clone() => new HealthProfileServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HealthProfileServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class HealthProfileServiceClientBuilder : gaxgrpc::ClientBuilderBase<HealthProfileServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HealthProfileServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HealthProfileServiceClientBuilder() : base(HealthProfileServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HealthProfileServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HealthProfileServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HealthProfileServiceClient Build()
        {
            HealthProfileServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HealthProfileServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HealthProfileServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HealthProfileServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HealthProfileServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HealthProfileServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HealthProfileServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HealthProfileServiceClient.ChannelPool;
    }

    /// <summary>HealthProfileService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Health Profile Service
    /// </remarks>
    public abstract partial class HealthProfileServiceClient
    {
        /// <summary>
        /// The default endpoint for the HealthProfileService service, which is a host of "health.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "health.googleapis.com:443";

        /// <summary>The default HealthProfileService scopes.</summary>
        /// <remarks>
        /// The default HealthProfileService scopes are:
        /// <list type="bullet">
        /// <item>
        /// <description>https://www.googleapis.com/auth/googlehealth.activity_and_fitness.readonly</description>
        /// </item>
        /// <item>
        /// <description>
        /// https://www.googleapis.com/auth/googlehealth.health_metrics_and_measurements.readonly
        /// </description>
        /// </item>
        /// <item><description>https://www.googleapis.com/auth/googlehealth.profile.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/googlehealth.settings.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/googlehealth.sleep.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/googlehealth.activity_and_fitness.readonly",
            "https://www.googleapis.com/auth/googlehealth.health_metrics_and_measurements.readonly",
            "https://www.googleapis.com/auth/googlehealth.profile.readonly",
            "https://www.googleapis.com/auth/googlehealth.settings.readonly",
            "https://www.googleapis.com/auth/googlehealth.sleep.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(HealthProfileService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HealthProfileServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="HealthProfileServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HealthProfileServiceClient"/>.</returns>
        public static stt::Task<HealthProfileServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HealthProfileServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HealthProfileServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="HealthProfileServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HealthProfileServiceClient"/>.</returns>
        public static HealthProfileServiceClient Create() => new HealthProfileServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HealthProfileServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HealthProfileServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HealthProfileServiceClient"/>.</returns>
        internal static HealthProfileServiceClient Create(grpccore::CallInvoker callInvoker, HealthProfileServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HealthProfileService.HealthProfileServiceClient grpcClient = new HealthProfileService.HealthProfileServiceClient(callInvoker);
            return new HealthProfileServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC HealthProfileService client</summary>
        public virtual HealthProfileService.HealthProfileServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile GetProfile(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(GetProfileRequest request, st::CancellationToken cancellationToken) =>
            GetProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Profile.
        /// Format: `users/me/profile`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile GetProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfile(new GetProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Profile.
        /// Format: `users/me/profile`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfileAsync(new GetProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Profile.
        /// Format: `users/me/profile`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Profile.
        /// Format: `users/me/profile`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile GetProfile(ProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfile(new GetProfileRequest
            {
                ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Profile.
        /// Format: `users/me/profile`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(ProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProfileAsync(new GetProfileRequest
            {
                ProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Profile.
        /// Format: `users/me/profile`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> GetProfileAsync(ProfileName name, st::CancellationToken cancellationToken) =>
            GetProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile UpdateProfile(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="profile">
        /// Required. Profile details.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile UpdateProfile(Profile profile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProfile(new UpdateProfileRequest
            {
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="profile">
        /// Required. Profile details.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(Profile profile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProfileAsync(new UpdateProfileRequest
            {
                Profile = gax::GaxPreconditions.CheckNotNull(profile, nameof(profile)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="profile">
        /// Required. Profile details.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(Profile profile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProfileAsync(profile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Settings.
        /// Format: `users/me/settings`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Settings.
        /// Format: `users/me/settings`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Settings.
        /// Format: `users/me/settings`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Settings.
        /// Format: `users/me/settings`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Settings.
        /// Format: `users/me/settings`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Settings.
        /// Format: `users/me/settings`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="settings">
        /// Required. Settings details
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="settings">
        /// Required. Settings details
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="settings">
        /// Required. Settings details
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Identity GetIdentity(GetIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Identity> GetIdentityAsync(GetIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Identity> GetIdentityAsync(GetIdentityRequest request, st::CancellationToken cancellationToken) =>
            GetIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Identity.
        /// Format: `users/me/identity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Identity GetIdentity(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentity(new GetIdentityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Identity.
        /// Format: `users/me/identity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Identity> GetIdentityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityAsync(new GetIdentityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Identity.
        /// Format: `users/me/identity`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Identity> GetIdentityAsync(string name, st::CancellationToken cancellationToken) =>
            GetIdentityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Identity.
        /// Format: `users/me/identity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Identity GetIdentity(IdentityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentity(new GetIdentityRequest
            {
                IdentityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Identity.
        /// Format: `users/me/identity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Identity> GetIdentityAsync(IdentityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityAsync(new GetIdentityRequest
            {
                IdentityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Identity.
        /// Format: `users/me/identity`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Identity> GetIdentityAsync(IdentityName name, st::CancellationToken cancellationToken) =>
            GetIdentityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HealthProfileService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Health Profile Service
    /// </remarks>
    public sealed partial class HealthProfileServiceClientImpl : HealthProfileServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProfileRequest, Profile> _callGetProfile;

        private readonly gaxgrpc::ApiCall<UpdateProfileRequest, Profile> _callUpdateProfile;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> _callUpdateSettings;

        private readonly gaxgrpc::ApiCall<GetIdentityRequest, Identity> _callGetIdentity;

        /// <summary>
        /// Constructs a client wrapper for the HealthProfileService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HealthProfileServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HealthProfileServiceClientImpl(HealthProfileService.HealthProfileServiceClient grpcClient, HealthProfileServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HealthProfileServiceSettings effectiveSettings = settings ?? HealthProfileServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProfile = clientHelper.BuildApiCall<GetProfileRequest, Profile>("GetProfile", grpcClient.GetProfileAsync, grpcClient.GetProfile, effectiveSettings.GetProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProfile);
            Modify_GetProfileApiCall(ref _callGetProfile);
            _callUpdateProfile = clientHelper.BuildApiCall<UpdateProfileRequest, Profile>("UpdateProfile", grpcClient.UpdateProfileAsync, grpcClient.UpdateProfile, effectiveSettings.UpdateProfileSettings).WithGoogleRequestParam("profile.name", request => request.Profile?.Name);
            Modify_ApiCall(ref _callUpdateProfile);
            Modify_UpdateProfileApiCall(ref _callUpdateProfile);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>("GetSettings", grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, Settings>("UpdateSettings", grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            _callGetIdentity = clientHelper.BuildApiCall<GetIdentityRequest, Identity>("GetIdentity", grpcClient.GetIdentityAsync, grpcClient.GetIdentity, effectiveSettings.GetIdentitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIdentity);
            Modify_GetIdentityApiCall(ref _callGetIdentity);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProfileApiCall(ref gaxgrpc::ApiCall<GetProfileRequest, Profile> call);

        partial void Modify_UpdateProfileApiCall(ref gaxgrpc::ApiCall<UpdateProfileRequest, Profile> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> call);

        partial void Modify_GetIdentityApiCall(ref gaxgrpc::ApiCall<GetIdentityRequest, Identity> call);

        partial void OnConstruction(HealthProfileService.HealthProfileServiceClient grpcClient, HealthProfileServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HealthProfileService client</summary>
        public override HealthProfileService.HealthProfileServiceClient GrpcClient { get; }

        partial void Modify_GetProfileRequest(ref GetProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProfileRequest(ref UpdateProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIdentityRequest(ref GetIdentityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Profile GetProfile(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProfileRequest(ref request, ref callSettings);
            return _callGetProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns user Profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> GetProfileAsync(GetProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProfileRequest(ref request, ref callSettings);
            return _callGetProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Profile UpdateProfile(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProfileRequest(ref request, ref callSettings);
            return _callUpdateProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the user's profile details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProfileRequest(ref request, ref callSettings);
            return _callUpdateProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns user settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the user's settings details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Identity GetIdentity(GetIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityRequest(ref request, ref callSettings);
            return _callGetIdentity.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the user's identity.
        /// 
        /// It includes the legacy Fitbit user ID and the Google user ID and it can be
        /// used by migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Identity> GetIdentityAsync(GetIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityRequest(ref request, ref callSettings);
            return _callGetIdentity.Async(request, callSettings);
        }
    }
}
