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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Apps.Meet.V2Beta
{
    /// <summary>Settings for <see cref="SpacesServiceClient"/> instances.</summary>
    public sealed partial class SpacesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SpacesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SpacesServiceSettings"/>.</returns>
        public static SpacesServiceSettings GetDefault() => new SpacesServiceSettings();

        /// <summary>Constructs a new <see cref="SpacesServiceSettings"/> object with default settings.</summary>
        public SpacesServiceSettings()
        {
        }

        private SpacesServiceSettings(SpacesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSpaceSettings = existing.CreateSpaceSettings;
            GetSpaceSettings = existing.GetSpaceSettings;
            UpdateSpaceSettings = existing.UpdateSpaceSettings;
            ConnectActiveConferenceSettings = existing.ConnectActiveConferenceSettings;
            EndActiveConferenceSettings = existing.EndActiveConferenceSettings;
            CreateMemberSettings = existing.CreateMemberSettings;
            GetMemberSettings = existing.GetMemberSettings;
            ListMembersSettings = existing.ListMembersSettings;
            DeleteMemberSettings = existing.DeleteMemberSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpacesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.CreateSpace</c> and <c>SpacesServiceClient.CreateSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.GetSpace</c> and <c>SpacesServiceClient.GetSpaceAsync</c>.
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
        public gaxgrpc::CallSettings GetSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.UpdateSpace</c> and <c>SpacesServiceClient.UpdateSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.ConnectActiveConference</c> and <c>SpacesServiceClient.ConnectActiveConferenceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ConnectActiveConferenceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.EndActiveConference</c> and <c>SpacesServiceClient.EndActiveConferenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EndActiveConferenceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.CreateMember</c> and <c>SpacesServiceClient.CreateMemberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMemberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.GetMember</c> and <c>SpacesServiceClient.GetMemberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMemberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.ListMembers</c> and <c>SpacesServiceClient.ListMembersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMembersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpacesServiceClient.DeleteMember</c> and <c>SpacesServiceClient.DeleteMemberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMemberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SpacesServiceSettings"/> object.</returns>
        public SpacesServiceSettings Clone() => new SpacesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SpacesServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SpacesServiceClientBuilder : gaxgrpc::ClientBuilderBase<SpacesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SpacesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SpacesServiceClientBuilder() : base(SpacesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SpacesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SpacesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SpacesServiceClient Build()
        {
            SpacesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SpacesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SpacesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SpacesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SpacesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SpacesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SpacesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SpacesServiceClient.ChannelPool;
    }

    /// <summary>SpacesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// REST API for services dealing with spaces.
    /// </remarks>
    public abstract partial class SpacesServiceClient
    {
        /// <summary>
        /// The default endpoint for the SpacesService service, which is a host of "meet.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "meet.googleapis.com:443";

        /// <summary>The default SpacesService scopes.</summary>
        /// <remarks>
        /// The default SpacesService scopes are:
        /// <list type="bullet">
        /// <item>
        /// <description>https://www.googleapis.com/auth/meetings.conference.media.audio.readonly</description>
        /// </item>
        /// <item><description>https://www.googleapis.com/auth/meetings.conference.media.readonly</description></item>
        /// <item>
        /// <description>https://www.googleapis.com/auth/meetings.conference.media.video.readonly</description>
        /// </item>
        /// <item><description>https://www.googleapis.com/auth/meetings.space.created</description></item>
        /// <item><description>https://www.googleapis.com/auth/meetings.space.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/meetings.space.settings</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/meetings.conference.media.audio.readonly",
            "https://www.googleapis.com/auth/meetings.conference.media.readonly",
            "https://www.googleapis.com/auth/meetings.conference.media.video.readonly",
            "https://www.googleapis.com/auth/meetings.space.created",
            "https://www.googleapis.com/auth/meetings.space.readonly",
            "https://www.googleapis.com/auth/meetings.space.settings",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SpacesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SpacesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SpacesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SpacesServiceClient"/>.</returns>
        public static stt::Task<SpacesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SpacesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SpacesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SpacesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SpacesServiceClient"/>.</returns>
        public static SpacesServiceClient Create() => new SpacesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SpacesServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SpacesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SpacesServiceClient"/>.</returns>
        internal static SpacesServiceClient Create(grpccore::CallInvoker callInvoker, SpacesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SpacesService.SpacesServiceClient grpcClient = new SpacesService.SpacesServiceClient(callInvoker);
            return new SpacesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SpacesService client</summary>
        public virtual SpacesService.SpacesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space CreateSpace(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, st::CancellationToken cancellationToken) =>
            CreateSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="space">
        /// Space to be created. As of May 2023, the input space can be empty. Later on
        /// the input space can be non-empty when space configuration is introduced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space CreateSpace(Space space, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpace(new CreateSpaceRequest { Space = space, }, callSettings);

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="space">
        /// Space to be created. As of May 2023, the input space can be empty. Later on
        /// the input space can be non-empty when space configuration is introduced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(Space space, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpaceAsync(new CreateSpaceRequest { Space = space, }, callSettings);

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="space">
        /// Space to be created. As of May 2023, the input space can be empty. Later on
        /// the input space can be non-empty when space configuration is introduced.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(Space space, st::CancellationToken cancellationToken) =>
            CreateSpaceAsync(space, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}` or `spaces/{meetingCode}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// `{meetingCode}` is an alias for the space. It's a typeable, unique
        /// character string and is non-case sensitive. For example, `abc-mnop-xyz`.
        /// The maximum length is 128 characters.
        /// 
        /// A `meetingCode` shouldn't be stored long term as it can become
        /// dissociated from a meeting space and can be reused for different meeting
        /// spaces in the future. Generally, a `meetingCode` expires 365 days after
        /// last use. For more information, see [Learn about meeting codes in Google
        /// Meet](https://support.google.com/meet/answer/10710509).
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpace(new GetSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}` or `spaces/{meetingCode}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// `{meetingCode}` is an alias for the space. It's a typeable, unique
        /// character string and is non-case sensitive. For example, `abc-mnop-xyz`.
        /// The maximum length is 128 characters.
        /// 
        /// A `meetingCode` shouldn't be stored long term as it can become
        /// dissociated from a meeting space and can be reused for different meeting
        /// spaces in the future. Generally, a `meetingCode` expires 365 days after
        /// last use. For more information, see [Learn about meeting codes in Google
        /// Meet](https://support.google.com/meet/answer/10710509).
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceAsync(new GetSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}` or `spaces/{meetingCode}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// `{meetingCode}` is an alias for the space. It's a typeable, unique
        /// character string and is non-case sensitive. For example, `abc-mnop-xyz`.
        /// The maximum length is 128 characters.
        /// 
        /// A `meetingCode` shouldn't be stored long term as it can become
        /// dissociated from a meeting space and can be reused for different meeting
        /// spaces in the future. Generally, a `meetingCode` expires 365 days after
        /// last use. For more information, see [Learn about meeting codes in Google
        /// Meet](https://support.google.com/meet/answer/10710509).
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}` or `spaces/{meetingCode}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// `{meetingCode}` is an alias for the space. It's a typeable, unique
        /// character string and is non-case sensitive. For example, `abc-mnop-xyz`.
        /// The maximum length is 128 characters.
        /// 
        /// A `meetingCode` shouldn't be stored long term as it can become
        /// dissociated from a meeting space and can be reused for different meeting
        /// spaces in the future. Generally, a `meetingCode` expires 365 days after
        /// last use. For more information, see [Learn about meeting codes in Google
        /// Meet](https://support.google.com/meet/answer/10710509).
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpace(new GetSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}` or `spaces/{meetingCode}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// `{meetingCode}` is an alias for the space. It's a typeable, unique
        /// character string and is non-case sensitive. For example, `abc-mnop-xyz`.
        /// The maximum length is 128 characters.
        /// 
        /// A `meetingCode` shouldn't be stored long term as it can become
        /// dissociated from a meeting space and can be reused for different meeting
        /// spaces in the future. Generally, a `meetingCode` expires 365 days after
        /// last use. For more information, see [Learn about meeting codes in Google
        /// Meet](https://support.google.com/meet/answer/10710509).
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceAsync(new GetSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}` or `spaces/{meetingCode}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// `{meetingCode}` is an alias for the space. It's a typeable, unique
        /// character string and is non-case sensitive. For example, `abc-mnop-xyz`.
        /// The maximum length is 128 characters.
        /// 
        /// A `meetingCode` shouldn't be stored long term as it can become
        /// dissociated from a meeting space and can be reused for different meeting
        /// spaces in the future. Generally, a `meetingCode` expires 365 days after
        /// last use. For more information, see [Learn about meeting codes in Google
        /// Meet](https://support.google.com/meet/answer/10710509).
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(SpaceName name, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space UpdateSpace(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="space">
        /// Required. Space to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask used to specify the fields to be updated in the space.
        /// If update_mask isn't provided(not set, set with empty paths, or only has ""
        /// as paths), it defaults to update all fields provided with values in the
        /// request.
        /// Using "*" as update_mask will update all fields, including deleting fields
        /// not set in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space UpdateSpace(Space space, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpace(new UpdateSpaceRequest
            {
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="space">
        /// Required. Space to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask used to specify the fields to be updated in the space.
        /// If update_mask isn't provided(not set, set with empty paths, or only has ""
        /// as paths), it defaults to update all fields provided with values in the
        /// request.
        /// Using "*" as update_mask will update all fields, including deleting fields
        /// not set in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(Space space, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpaceAsync(new UpdateSpaceRequest
            {
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="space">
        /// Required. Space to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask used to specify the fields to be updated in the space.
        /// If update_mask isn't provided(not set, set with empty paths, or only has ""
        /// as paths), it defaults to update all fields provided with values in the
        /// request.
        /// Using "*" as update_mask will update all fields, including deleting fields
        /// not set in the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(Space space, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpaceAsync(space, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectActiveConferenceResponse ConnectActiveConference(ConnectActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectActiveConferenceResponse> ConnectActiveConferenceAsync(ConnectActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectActiveConferenceResponse> ConnectActiveConferenceAsync(ConnectActiveConferenceRequest request, st::CancellationToken cancellationToken) =>
            ConnectActiveConferenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// Format: spaces/{spaceId}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectActiveConferenceResponse ConnectActiveConference(string name, gaxgrpc::CallSettings callSettings = null) =>
            ConnectActiveConference(new ConnectActiveConferenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// Format: spaces/{spaceId}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectActiveConferenceResponse> ConnectActiveConferenceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ConnectActiveConferenceAsync(new ConnectActiveConferenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// Format: spaces/{spaceId}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectActiveConferenceResponse> ConnectActiveConferenceAsync(string name, st::CancellationToken cancellationToken) =>
            ConnectActiveConferenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// Format: spaces/{spaceId}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectActiveConferenceResponse ConnectActiveConference(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            ConnectActiveConference(new ConnectActiveConferenceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// Format: spaces/{spaceId}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectActiveConferenceResponse> ConnectActiveConferenceAsync(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            ConnectActiveConferenceAsync(new ConnectActiveConferenceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// Format: spaces/{spaceId}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectActiveConferenceResponse> ConnectActiveConferenceAsync(SpaceName name, st::CancellationToken cancellationToken) =>
            ConnectActiveConferenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndActiveConference(EndActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndActiveConferenceAsync(EndActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndActiveConferenceAsync(EndActiveConferenceRequest request, st::CancellationToken cancellationToken) =>
            EndActiveConferenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndActiveConference(string name, gaxgrpc::CallSettings callSettings = null) =>
            EndActiveConference(new EndActiveConferenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndActiveConferenceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EndActiveConferenceAsync(new EndActiveConferenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndActiveConferenceAsync(string name, st::CancellationToken cancellationToken) =>
            EndActiveConferenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndActiveConference(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            EndActiveConference(new EndActiveConferenceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndActiveConferenceAsync(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            EndActiveConferenceAsync(new EndActiveConferenceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space.
        /// 
        /// Format: `spaces/{space}`.
        /// 
        /// `{space}` is the resource identifier for the space. It's a unique,
        /// server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
        /// 
        /// For more information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndActiveConferenceAsync(SpaceName name, st::CancellationToken cancellationToken) =>
            EndActiveConferenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Member CreateMember(CreateMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> CreateMemberAsync(CreateMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> CreateMemberAsync(CreateMemberRequest request, st::CancellationToken cancellationToken) =>
            CreateMemberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
        /// </param>
        /// <param name="member">
        /// Required. The member to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Member CreateMember(string parent, Member member, gaxgrpc::CallSettings callSettings = null) =>
            CreateMember(new CreateMemberRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Member = gax::GaxPreconditions.CheckNotNull(member, nameof(member)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
        /// </param>
        /// <param name="member">
        /// Required. The member to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> CreateMemberAsync(string parent, Member member, gaxgrpc::CallSettings callSettings = null) =>
            CreateMemberAsync(new CreateMemberRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Member = gax::GaxPreconditions.CheckNotNull(member, nameof(member)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
        /// </param>
        /// <param name="member">
        /// Required. The member to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> CreateMemberAsync(string parent, Member member, st::CancellationToken cancellationToken) =>
            CreateMemberAsync(parent, member, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
        /// </param>
        /// <param name="member">
        /// Required. The member to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Member CreateMember(SpaceName parent, Member member, gaxgrpc::CallSettings callSettings = null) =>
            CreateMember(new CreateMemberRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Member = gax::GaxPreconditions.CheckNotNull(member, nameof(member)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
        /// </param>
        /// <param name="member">
        /// Required. The member to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> CreateMemberAsync(SpaceName parent, Member member, gaxgrpc::CallSettings callSettings = null) =>
            CreateMemberAsync(new CreateMemberRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Member = gax::GaxPreconditions.CheckNotNull(member, nameof(member)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
        /// </param>
        /// <param name="member">
        /// Required. The member to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> CreateMemberAsync(SpaceName parent, Member member, st::CancellationToken cancellationToken) =>
            CreateMemberAsync(parent, member, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Member GetMember(GetMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> GetMemberAsync(GetMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> GetMemberAsync(GetMemberRequest request, st::CancellationToken cancellationToken) =>
            GetMemberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Member GetMember(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMember(new GetMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> GetMemberAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMemberAsync(new GetMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> GetMemberAsync(string name, st::CancellationToken cancellationToken) =>
            GetMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Member GetMember(MemberName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMember(new GetMemberRequest
            {
                MemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> GetMemberAsync(MemberName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMemberAsync(new GetMemberRequest
            {
                MemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Member> GetMemberAsync(MemberName name, st::CancellationToken cancellationToken) =>
            GetMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Member"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembersResponse, Member> ListMembers(ListMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Member"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembersResponse, Member> ListMembersAsync(ListMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
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
        /// <returns>A pageable sequence of <see cref="Member"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembersResponse, Member> ListMembers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembersRequest request = new ListMembersRequest
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
            return ListMembers(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Member"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembersResponse, Member> ListMembersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembersRequest request = new ListMembersRequest
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
            return ListMembersAsync(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
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
        /// <returns>A pageable sequence of <see cref="Member"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembersResponse, Member> ListMembers(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembersRequest request = new ListMembersRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembers(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="parent">
        /// Required. Format: spaces/{space}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Member"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembersResponse, Member> ListMembersAsync(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembersRequest request = new ListMembersRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembersAsync(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMember(DeleteMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMemberAsync(DeleteMemberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMemberAsync(DeleteMemberRequest request, st::CancellationToken cancellationToken) =>
            DeleteMemberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMember(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMember(new DeleteMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMemberAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMemberAsync(new DeleteMemberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMemberAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMember(MemberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMember(new DeleteMemberRequest
            {
                MemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMemberAsync(MemberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMemberAsync(new DeleteMemberRequest
            {
                MemberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="name">
        /// Required. Format: “spaces/{space}/members/{member}”
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMemberAsync(MemberName name, st::CancellationToken cancellationToken) =>
            DeleteMemberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SpacesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// REST API for services dealing with spaces.
    /// </remarks>
    public sealed partial class SpacesServiceClientImpl : SpacesServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSpaceRequest, Space> _callCreateSpace;

        private readonly gaxgrpc::ApiCall<GetSpaceRequest, Space> _callGetSpace;

        private readonly gaxgrpc::ApiCall<UpdateSpaceRequest, Space> _callUpdateSpace;

        private readonly gaxgrpc::ApiCall<ConnectActiveConferenceRequest, ConnectActiveConferenceResponse> _callConnectActiveConference;

        private readonly gaxgrpc::ApiCall<EndActiveConferenceRequest, wkt::Empty> _callEndActiveConference;

        private readonly gaxgrpc::ApiCall<CreateMemberRequest, Member> _callCreateMember;

        private readonly gaxgrpc::ApiCall<GetMemberRequest, Member> _callGetMember;

        private readonly gaxgrpc::ApiCall<ListMembersRequest, ListMembersResponse> _callListMembers;

        private readonly gaxgrpc::ApiCall<DeleteMemberRequest, wkt::Empty> _callDeleteMember;

        /// <summary>
        /// Constructs a client wrapper for the SpacesService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpacesServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SpacesServiceClientImpl(SpacesService.SpacesServiceClient grpcClient, SpacesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SpacesServiceSettings effectiveSettings = settings ?? SpacesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateSpace = clientHelper.BuildApiCall<CreateSpaceRequest, Space>("CreateSpace", grpcClient.CreateSpaceAsync, grpcClient.CreateSpace, effectiveSettings.CreateSpaceSettings);
            Modify_ApiCall(ref _callCreateSpace);
            Modify_CreateSpaceApiCall(ref _callCreateSpace);
            _callGetSpace = clientHelper.BuildApiCall<GetSpaceRequest, Space>("GetSpace", grpcClient.GetSpaceAsync, grpcClient.GetSpace, effectiveSettings.GetSpaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpace);
            Modify_GetSpaceApiCall(ref _callGetSpace);
            _callUpdateSpace = clientHelper.BuildApiCall<UpdateSpaceRequest, Space>("UpdateSpace", grpcClient.UpdateSpaceAsync, grpcClient.UpdateSpace, effectiveSettings.UpdateSpaceSettings).WithGoogleRequestParam("space.name", request => request.Space?.Name);
            Modify_ApiCall(ref _callUpdateSpace);
            Modify_UpdateSpaceApiCall(ref _callUpdateSpace);
            _callConnectActiveConference = clientHelper.BuildApiCall<ConnectActiveConferenceRequest, ConnectActiveConferenceResponse>("ConnectActiveConference", grpcClient.ConnectActiveConferenceAsync, grpcClient.ConnectActiveConference, effectiveSettings.ConnectActiveConferenceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callConnectActiveConference);
            Modify_ConnectActiveConferenceApiCall(ref _callConnectActiveConference);
            _callEndActiveConference = clientHelper.BuildApiCall<EndActiveConferenceRequest, wkt::Empty>("EndActiveConference", grpcClient.EndActiveConferenceAsync, grpcClient.EndActiveConference, effectiveSettings.EndActiveConferenceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEndActiveConference);
            Modify_EndActiveConferenceApiCall(ref _callEndActiveConference);
            _callCreateMember = clientHelper.BuildApiCall<CreateMemberRequest, Member>("CreateMember", grpcClient.CreateMemberAsync, grpcClient.CreateMember, effectiveSettings.CreateMemberSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMember);
            Modify_CreateMemberApiCall(ref _callCreateMember);
            _callGetMember = clientHelper.BuildApiCall<GetMemberRequest, Member>("GetMember", grpcClient.GetMemberAsync, grpcClient.GetMember, effectiveSettings.GetMemberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMember);
            Modify_GetMemberApiCall(ref _callGetMember);
            _callListMembers = clientHelper.BuildApiCall<ListMembersRequest, ListMembersResponse>("ListMembers", grpcClient.ListMembersAsync, grpcClient.ListMembers, effectiveSettings.ListMembersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMembers);
            Modify_ListMembersApiCall(ref _callListMembers);
            _callDeleteMember = clientHelper.BuildApiCall<DeleteMemberRequest, wkt::Empty>("DeleteMember", grpcClient.DeleteMemberAsync, grpcClient.DeleteMember, effectiveSettings.DeleteMemberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMember);
            Modify_DeleteMemberApiCall(ref _callDeleteMember);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSpaceApiCall(ref gaxgrpc::ApiCall<CreateSpaceRequest, Space> call);

        partial void Modify_GetSpaceApiCall(ref gaxgrpc::ApiCall<GetSpaceRequest, Space> call);

        partial void Modify_UpdateSpaceApiCall(ref gaxgrpc::ApiCall<UpdateSpaceRequest, Space> call);

        partial void Modify_ConnectActiveConferenceApiCall(ref gaxgrpc::ApiCall<ConnectActiveConferenceRequest, ConnectActiveConferenceResponse> call);

        partial void Modify_EndActiveConferenceApiCall(ref gaxgrpc::ApiCall<EndActiveConferenceRequest, wkt::Empty> call);

        partial void Modify_CreateMemberApiCall(ref gaxgrpc::ApiCall<CreateMemberRequest, Member> call);

        partial void Modify_GetMemberApiCall(ref gaxgrpc::ApiCall<GetMemberRequest, Member> call);

        partial void Modify_ListMembersApiCall(ref gaxgrpc::ApiCall<ListMembersRequest, ListMembersResponse> call);

        partial void Modify_DeleteMemberApiCall(ref gaxgrpc::ApiCall<DeleteMemberRequest, wkt::Empty> call);

        partial void OnConstruction(SpacesService.SpacesServiceClient grpcClient, SpacesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SpacesService client</summary>
        public override SpacesService.SpacesServiceClient GrpcClient { get; }

        partial void Modify_CreateSpaceRequest(ref CreateSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpaceRequest(ref GetSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpaceRequest(ref UpdateSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ConnectActiveConferenceRequest(ref ConnectActiveConferenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EndActiveConferenceRequest(ref EndActiveConferenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMemberRequest(ref CreateMemberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMemberRequest(ref GetMemberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMembersRequest(ref ListMembersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMemberRequest(ref DeleteMemberRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space CreateSpace(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpaceRequest(ref request, ref callSettings);
            return _callCreateSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpaceRequest(ref request, ref callSettings);
            return _callCreateSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space GetSpace(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceRequest(ref request, ref callSettings);
            return _callGetSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a meeting space.
        /// 
        /// For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceRequest(ref request, ref callSettings);
            return _callGetSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space UpdateSpace(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceRequest(ref request, ref callSettings);
            return _callUpdateSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates details about a meeting space.
        /// 
        /// For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceRequest(ref request, ref callSettings);
            return _callUpdateSpace.Async(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectActiveConferenceResponse ConnectActiveConference(ConnectActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConnectActiveConferenceRequest(ref request, ref callSettings);
            return _callConnectActiveConference.Sync(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Broker a WebRTC connection to the active conference of a space.
        /// 
        /// On success, clients must use the resulting SDP (Session Description
        /// Protocol) answer to establish a WebRTC connection. Once connected,
        /// additional functionality is available across WebRTC data channels.
        /// 
        /// See [Meet Media API
        /// overview](https://developers.google.com/meet/media-api/guides/overview) for
        /// more details about this connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectActiveConferenceResponse> ConnectActiveConferenceAsync(ConnectActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConnectActiveConferenceRequest(ref request, ref callSettings);
            return _callConnectActiveConference.Async(request, callSettings);
        }

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void EndActiveConference(EndActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndActiveConferenceRequest(ref request, ref callSettings);
            _callEndActiveConference.Sync(request, callSettings);
        }

        /// <summary>
        /// Ends an active conference (if there's one).
        /// 
        /// For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task EndActiveConferenceAsync(EndActiveConferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndActiveConferenceRequest(ref request, ref callSettings);
            return _callEndActiveConference.Async(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Member CreateMember(CreateMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMemberRequest(ref request, ref callSettings);
            return _callCreateMember.Sync(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Create a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Member> CreateMemberAsync(CreateMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMemberRequest(ref request, ref callSettings);
            return _callCreateMember.Async(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Member GetMember(GetMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMemberRequest(ref request, ref callSettings);
            return _callGetMember.Sync(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Get a member.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted, this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Member> GetMemberAsync(GetMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMemberRequest(ref request, ref callSettings);
            return _callGetMember.Async(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Member"/> resources.</returns>
        public override gax::PagedEnumerable<ListMembersResponse, Member> ListMembers(ListMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMembersRequest, ListMembersResponse, Member>(_callListMembers, request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// List members.
        /// 
        /// This API supports the `fields` parameter in
        /// [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters).
        /// When the `fields` parameter is omitted this API response will default to
        /// "name,email,role,user".
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Member"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMembersResponse, Member> ListMembersAsync(ListMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMembersRequest, ListMembersResponse, Member>(_callListMembers, request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMember(DeleteMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMemberRequest(ref request, ref callSettings);
            _callDeleteMember.Sync(request, callSettings);
        }

        /// <summary>
        /// [Developer Preview](https://developers.google.com/workspace/preview):
        /// Delete the member who was previously assigned roles in the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMemberAsync(DeleteMemberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMemberRequest(ref request, ref callSettings);
            return _callDeleteMember.Async(request, callSettings);
        }
    }

    public partial class ListMembersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMembersResponse : gaxgrpc::IPageResponse<Member>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Member> GetEnumerator() => Members.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
