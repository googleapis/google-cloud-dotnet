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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Profiler.V2
{
    /// <summary>Settings for <see cref="ProfilerServiceClient"/> instances.</summary>
    public sealed partial class ProfilerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProfilerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProfilerServiceSettings"/>.</returns>
        public static ProfilerServiceSettings GetDefault() => new ProfilerServiceSettings();

        /// <summary>Constructs a new <see cref="ProfilerServiceSettings"/> object with default settings.</summary>
        public ProfilerServiceSettings()
        {
        }

        private ProfilerServiceSettings(ProfilerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateProfileSettings = existing.CreateProfileSettings;
            CreateOfflineProfileSettings = existing.CreateOfflineProfileSettings;
            UpdateProfileSettings = existing.UpdateProfileSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProfilerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfilerServiceClient.CreateProfile</c> and <c>ProfilerServiceClient.CreateProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3610 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3610000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfilerServiceClient.CreateOfflineProfile</c> and <c>ProfilerServiceClient.CreateOfflineProfileAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOfflineProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProfilerServiceClient.UpdateProfile</c> and <c>ProfilerServiceClient.UpdateProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProfilerServiceSettings"/> object.</returns>
        public ProfilerServiceSettings Clone() => new ProfilerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProfilerServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProfilerServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProfilerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProfilerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProfilerServiceClientBuilder() : base(ProfilerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProfilerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProfilerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProfilerServiceClient Build()
        {
            ProfilerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProfilerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProfilerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProfilerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProfilerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProfilerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProfilerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProfilerServiceClient.ChannelPool;
    }

    /// <summary>ProfilerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manage the collection of continuous profiling data provided by profiling
    /// agents running in the cloud or by an offline provider of profiling data.
    /// 
    /// __The APIs listed in this service are intended for use within our profiler
    /// agents only.__
    /// </remarks>
    public abstract partial class ProfilerServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProfilerService service, which is a host of "cloudprofiler.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudprofiler.googleapis.com:443";

        /// <summary>The default ProfilerService scopes.</summary>
        /// <remarks>
        /// The default ProfilerService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProfilerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProfilerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProfilerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProfilerServiceClient"/>.</returns>
        public static stt::Task<ProfilerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProfilerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProfilerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProfilerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProfilerServiceClient"/>.</returns>
        public static ProfilerServiceClient Create() => new ProfilerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProfilerServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProfilerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProfilerServiceClient"/>.</returns>
        internal static ProfilerServiceClient Create(grpccore::CallInvoker callInvoker, ProfilerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProfilerService.ProfilerServiceClient grpcClient = new ProfilerService.ProfilerServiceClient(callInvoker);
            return new ProfilerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProfilerService client</summary>
        public virtual ProfilerService.ProfilerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// CreateProfile creates a new profile resource in the online mode.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// 
        /// The server ensures that the new profiles are created at a constant rate per
        /// deployment, so the creation request may hang for some time until the next
        /// profile session is available.
        /// 
        /// The request may fail with ABORTED error if the creation is not available
        /// within ~1m, the response will indicate the duration of the backoff the
        /// client should take before attempting creating a profile again. The backoff
        /// duration is returned in google.rpc.RetryInfo extension on the response
        /// status. To a gRPC client, the extension will be return as a
        /// binary-serialized proto in the trailing metadata item named
        /// "google.rpc.retryinfo-bin".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile CreateProfile(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateProfile creates a new profile resource in the online mode.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// 
        /// The server ensures that the new profiles are created at a constant rate per
        /// deployment, so the creation request may hang for some time until the next
        /// profile session is available.
        /// 
        /// The request may fail with ABORTED error if the creation is not available
        /// within ~1m, the response will indicate the duration of the backoff the
        /// client should take before attempting creating a profile again. The backoff
        /// duration is returned in google.rpc.RetryInfo extension on the response
        /// status. To a gRPC client, the extension will be return as a
        /// binary-serialized proto in the trailing metadata item named
        /// "google.rpc.retryinfo-bin".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateProfile creates a new profile resource in the online mode.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// 
        /// The server ensures that the new profiles are created at a constant rate per
        /// deployment, so the creation request may hang for some time until the next
        /// profile session is available.
        /// 
        /// The request may fail with ABORTED error if the creation is not available
        /// within ~1m, the response will indicate the duration of the backoff the
        /// client should take before attempting creating a profile again. The backoff
        /// duration is returned in google.rpc.RetryInfo extension on the response
        /// status. To a gRPC client, the extension will be return as a
        /// binary-serialized proto in the trailing metadata item named
        /// "google.rpc.retryinfo-bin".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateProfileAsync(CreateProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile CreateOfflineProfile(CreateOfflineProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateOfflineProfileAsync(CreateOfflineProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateOfflineProfileAsync(CreateOfflineProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateOfflineProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="parent">
        /// Parent project to create the profile in.
        /// </param>
        /// <param name="profile">
        /// Contents of the profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile CreateOfflineProfile(string parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateOfflineProfile(new CreateOfflineProfileRequest
            {
                Parent = parent ?? "",
                Profile = profile,
            }, callSettings);

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="parent">
        /// Parent project to create the profile in.
        /// </param>
        /// <param name="profile">
        /// Contents of the profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateOfflineProfileAsync(string parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateOfflineProfileAsync(new CreateOfflineProfileRequest
            {
                Parent = parent ?? "",
                Profile = profile,
            }, callSettings);

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="parent">
        /// Parent project to create the profile in.
        /// </param>
        /// <param name="profile">
        /// Contents of the profile to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateOfflineProfileAsync(string parent, Profile profile, st::CancellationToken cancellationToken) =>
            CreateOfflineProfileAsync(parent, profile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="parent">
        /// Parent project to create the profile in.
        /// </param>
        /// <param name="profile">
        /// Contents of the profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile CreateOfflineProfile(gagr::ProjectName parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateOfflineProfile(new CreateOfflineProfileRequest
            {
                ParentAsProjectName = parent,
                Profile = profile,
            }, callSettings);

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="parent">
        /// Parent project to create the profile in.
        /// </param>
        /// <param name="profile">
        /// Contents of the profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateOfflineProfileAsync(gagr::ProjectName parent, Profile profile, gaxgrpc::CallSettings callSettings = null) =>
            CreateOfflineProfileAsync(new CreateOfflineProfileRequest
            {
                ParentAsProjectName = parent,
                Profile = profile,
            }, callSettings);

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="parent">
        /// Parent project to create the profile in.
        /// </param>
        /// <param name="profile">
        /// Contents of the profile to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> CreateOfflineProfileAsync(gagr::ProjectName parent, Profile profile, st::CancellationToken cancellationToken) =>
            CreateOfflineProfileAsync(parent, profile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile UpdateProfile(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="profile">
        /// Profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Field mask used to specify the fields to be overwritten. Currently only
        /// profile_bytes and labels fields are supported by UpdateProfile, so only
        /// those fields can be specified in the mask. When no mask is provided, all
        /// fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Profile UpdateProfile(Profile profile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProfile(new UpdateProfileRequest
            {
                Profile = profile,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="profile">
        /// Profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Field mask used to specify the fields to be overwritten. Currently only
        /// profile_bytes and labels fields are supported by UpdateProfile, so only
        /// those fields can be specified in the mask. When no mask is provided, all
        /// fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(Profile profile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProfileAsync(new UpdateProfileRequest
            {
                Profile = profile,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="profile">
        /// Profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Field mask used to specify the fields to be overwritten. Currently only
        /// profile_bytes and labels fields are supported by UpdateProfile, so only
        /// those fields can be specified in the mask. When no mask is provided, all
        /// fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Profile> UpdateProfileAsync(Profile profile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProfileAsync(profile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProfilerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manage the collection of continuous profiling data provided by profiling
    /// agents running in the cloud or by an offline provider of profiling data.
    /// 
    /// __The APIs listed in this service are intended for use within our profiler
    /// agents only.__
    /// </remarks>
    public sealed partial class ProfilerServiceClientImpl : ProfilerServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateProfileRequest, Profile> _callCreateProfile;

        private readonly gaxgrpc::ApiCall<CreateOfflineProfileRequest, Profile> _callCreateOfflineProfile;

        private readonly gaxgrpc::ApiCall<UpdateProfileRequest, Profile> _callUpdateProfile;

        /// <summary>
        /// Constructs a client wrapper for the ProfilerService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProfilerServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProfilerServiceClientImpl(ProfilerService.ProfilerServiceClient grpcClient, ProfilerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProfilerServiceSettings effectiveSettings = settings ?? ProfilerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateProfile = clientHelper.BuildApiCall<CreateProfileRequest, Profile>("CreateProfile", grpcClient.CreateProfileAsync, grpcClient.CreateProfile, effectiveSettings.CreateProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProfile);
            Modify_CreateProfileApiCall(ref _callCreateProfile);
            _callCreateOfflineProfile = clientHelper.BuildApiCall<CreateOfflineProfileRequest, Profile>("CreateOfflineProfile", grpcClient.CreateOfflineProfileAsync, grpcClient.CreateOfflineProfile, effectiveSettings.CreateOfflineProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOfflineProfile);
            Modify_CreateOfflineProfileApiCall(ref _callCreateOfflineProfile);
            _callUpdateProfile = clientHelper.BuildApiCall<UpdateProfileRequest, Profile>("UpdateProfile", grpcClient.UpdateProfileAsync, grpcClient.UpdateProfile, effectiveSettings.UpdateProfileSettings).WithGoogleRequestParam("profile.name", request => request.Profile?.Name);
            Modify_ApiCall(ref _callUpdateProfile);
            Modify_UpdateProfileApiCall(ref _callUpdateProfile);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateProfileApiCall(ref gaxgrpc::ApiCall<CreateProfileRequest, Profile> call);

        partial void Modify_CreateOfflineProfileApiCall(ref gaxgrpc::ApiCall<CreateOfflineProfileRequest, Profile> call);

        partial void Modify_UpdateProfileApiCall(ref gaxgrpc::ApiCall<UpdateProfileRequest, Profile> call);

        partial void OnConstruction(ProfilerService.ProfilerServiceClient grpcClient, ProfilerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProfilerService client</summary>
        public override ProfilerService.ProfilerServiceClient GrpcClient { get; }

        partial void Modify_CreateProfileRequest(ref CreateProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOfflineProfileRequest(ref CreateOfflineProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProfileRequest(ref UpdateProfileRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// CreateProfile creates a new profile resource in the online mode.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// 
        /// The server ensures that the new profiles are created at a constant rate per
        /// deployment, so the creation request may hang for some time until the next
        /// profile session is available.
        /// 
        /// The request may fail with ABORTED error if the creation is not available
        /// within ~1m, the response will indicate the duration of the backoff the
        /// client should take before attempting creating a profile again. The backoff
        /// duration is returned in google.rpc.RetryInfo extension on the response
        /// status. To a gRPC client, the extension will be return as a
        /// binary-serialized proto in the trailing metadata item named
        /// "google.rpc.retryinfo-bin".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Profile CreateProfile(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProfileRequest(ref request, ref callSettings);
            return _callCreateProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// CreateProfile creates a new profile resource in the online mode.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// 
        /// The server ensures that the new profiles are created at a constant rate per
        /// deployment, so the creation request may hang for some time until the next
        /// profile session is available.
        /// 
        /// The request may fail with ABORTED error if the creation is not available
        /// within ~1m, the response will indicate the duration of the backoff the
        /// client should take before attempting creating a profile again. The backoff
        /// duration is returned in google.rpc.RetryInfo extension on the response
        /// status. To a gRPC client, the extension will be return as a
        /// binary-serialized proto in the trailing metadata item named
        /// "google.rpc.retryinfo-bin".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> CreateProfileAsync(CreateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProfileRequest(ref request, ref callSettings);
            return _callCreateProfile.Async(request, callSettings);
        }

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Profile CreateOfflineProfile(CreateOfflineProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOfflineProfileRequest(ref request, ref callSettings);
            return _callCreateOfflineProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// CreateOfflineProfile creates a new profile resource in the offline
        /// mode. The client provides the profile to create along with the profile
        /// bytes, the server records it.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> CreateOfflineProfileAsync(CreateOfflineProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOfflineProfileRequest(ref request, ref callSettings);
            return _callCreateOfflineProfile.Async(request, callSettings);
        }

        /// <summary>
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
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
        /// UpdateProfile updates the profile bytes and labels on the profile resource
        /// created in the online mode. Updating the bytes for profiles created in the
        /// offline mode is currently not supported: the profile content must be
        /// provided at the time of the profile creation.
        /// 
        /// _Direct use of this API is discouraged, please use a [supported
        /// profiler
        /// agent](https://cloud.google.com/profiler/docs/about-profiler#profiling_agent)
        /// instead for profile collection._
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Profile> UpdateProfileAsync(UpdateProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProfileRequest(ref request, ref callSettings);
            return _callUpdateProfile.Async(request, callSettings);
        }
    }
}
