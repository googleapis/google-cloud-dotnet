// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Video.Stitcher.V1
{
    /// <summary>Settings for <see cref="VideoStitcherServiceClient"/> instances.</summary>
    public sealed partial class VideoStitcherServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VideoStitcherServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VideoStitcherServiceSettings"/>.</returns>
        public static VideoStitcherServiceSettings GetDefault() => new VideoStitcherServiceSettings();

        /// <summary>Constructs a new <see cref="VideoStitcherServiceSettings"/> object with default settings.</summary>
        public VideoStitcherServiceSettings()
        {
        }

        private VideoStitcherServiceSettings(VideoStitcherServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCdnKeySettings = existing.CreateCdnKeySettings;
            ListCdnKeysSettings = existing.ListCdnKeysSettings;
            GetCdnKeySettings = existing.GetCdnKeySettings;
            DeleteCdnKeySettings = existing.DeleteCdnKeySettings;
            UpdateCdnKeySettings = existing.UpdateCdnKeySettings;
            CreateVodSessionSettings = existing.CreateVodSessionSettings;
            GetVodSessionSettings = existing.GetVodSessionSettings;
            ListVodStitchDetailsSettings = existing.ListVodStitchDetailsSettings;
            GetVodStitchDetailSettings = existing.GetVodStitchDetailSettings;
            ListVodAdTagDetailsSettings = existing.ListVodAdTagDetailsSettings;
            GetVodAdTagDetailSettings = existing.GetVodAdTagDetailSettings;
            ListLiveAdTagDetailsSettings = existing.ListLiveAdTagDetailsSettings;
            GetLiveAdTagDetailSettings = existing.GetLiveAdTagDetailSettings;
            CreateSlateSettings = existing.CreateSlateSettings;
            ListSlatesSettings = existing.ListSlatesSettings;
            GetSlateSettings = existing.GetSlateSettings;
            UpdateSlateSettings = existing.UpdateSlateSettings;
            DeleteSlateSettings = existing.DeleteSlateSettings;
            CreateLiveSessionSettings = existing.CreateLiveSessionSettings;
            GetLiveSessionSettings = existing.GetLiveSessionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VideoStitcherServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.CreateCdnKey</c> and <c>VideoStitcherServiceClient.CreateCdnKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCdnKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.ListCdnKeys</c> and <c>VideoStitcherServiceClient.ListCdnKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCdnKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.GetCdnKey</c> and <c>VideoStitcherServiceClient.GetCdnKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCdnKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.DeleteCdnKey</c> and <c>VideoStitcherServiceClient.DeleteCdnKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCdnKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.UpdateCdnKey</c> and <c>VideoStitcherServiceClient.UpdateCdnKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCdnKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.CreateVodSession</c> and <c>VideoStitcherServiceClient.CreateVodSessionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVodSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.GetVodSession</c> and <c>VideoStitcherServiceClient.GetVodSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVodSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.ListVodStitchDetails</c> and
        /// <c>VideoStitcherServiceClient.ListVodStitchDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVodStitchDetailsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.GetVodStitchDetail</c> and
        /// <c>VideoStitcherServiceClient.GetVodStitchDetailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVodStitchDetailSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.ListVodAdTagDetails</c> and
        /// <c>VideoStitcherServiceClient.ListVodAdTagDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVodAdTagDetailsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.GetVodAdTagDetail</c> and <c>VideoStitcherServiceClient.GetVodAdTagDetailAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVodAdTagDetailSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.ListLiveAdTagDetails</c> and
        /// <c>VideoStitcherServiceClient.ListLiveAdTagDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLiveAdTagDetailsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.GetLiveAdTagDetail</c> and
        /// <c>VideoStitcherServiceClient.GetLiveAdTagDetailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLiveAdTagDetailSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.CreateSlate</c> and <c>VideoStitcherServiceClient.CreateSlateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSlateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.ListSlates</c> and <c>VideoStitcherServiceClient.ListSlatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSlatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.GetSlate</c> and <c>VideoStitcherServiceClient.GetSlateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSlateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.UpdateSlate</c> and <c>VideoStitcherServiceClient.UpdateSlateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSlateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.DeleteSlate</c> and <c>VideoStitcherServiceClient.DeleteSlateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSlateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.CreateLiveSession</c> and <c>VideoStitcherServiceClient.CreateLiveSessionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLiveSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoStitcherServiceClient.GetLiveSession</c> and <c>VideoStitcherServiceClient.GetLiveSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLiveSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VideoStitcherServiceSettings"/> object.</returns>
        public VideoStitcherServiceSettings Clone() => new VideoStitcherServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VideoStitcherServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class VideoStitcherServiceClientBuilder : gaxgrpc::ClientBuilderBase<VideoStitcherServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VideoStitcherServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VideoStitcherServiceClientBuilder() : base(VideoStitcherServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VideoStitcherServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VideoStitcherServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VideoStitcherServiceClient Build()
        {
            VideoStitcherServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VideoStitcherServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VideoStitcherServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VideoStitcherServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VideoStitcherServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<VideoStitcherServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VideoStitcherServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VideoStitcherServiceClient.ChannelPool;
    }

    /// <summary>VideoStitcherService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Video-On-Demand content stitching API allows you to insert ads
    /// into (VoD) video on demand files. You will be able to render custom
    /// scrubber bars with highlighted ads, enforce ad policies, allow
    /// seamless playback and tracking on native players and monetize
    /// content with any standard VMAP compliant ad server.
    /// </remarks>
    public abstract partial class VideoStitcherServiceClient
    {
        /// <summary>
        /// The default endpoint for the VideoStitcherService service, which is a host of "videostitcher.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "videostitcher.googleapis.com:443";

        /// <summary>The default VideoStitcherService scopes.</summary>
        /// <remarks>
        /// The default VideoStitcherService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        internal static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VideoStitcherService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VideoStitcherServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="VideoStitcherServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VideoStitcherServiceClient"/>.</returns>
        public static stt::Task<VideoStitcherServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VideoStitcherServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VideoStitcherServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="VideoStitcherServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VideoStitcherServiceClient"/>.</returns>
        public static VideoStitcherServiceClient Create() => new VideoStitcherServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VideoStitcherServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VideoStitcherServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VideoStitcherServiceClient"/>.</returns>
        internal static VideoStitcherServiceClient Create(grpccore::CallInvoker callInvoker, VideoStitcherServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VideoStitcherService.VideoStitcherServiceClient grpcClient = new VideoStitcherService.VideoStitcherServiceClient(callInvoker);
            return new VideoStitcherServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VideoStitcherService client</summary>
        public virtual VideoStitcherService.VideoStitcherServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey CreateCdnKey(CreateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> CreateCdnKeyAsync(CreateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> CreateCdnKeyAsync(CreateCdnKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the CDN key should be created, in the form of
        /// `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="cdnKey">
        /// Required. The CDN key resource to create.
        /// </param>
        /// <param name="cdnKeyId">
        /// Required. The ID to use for the CDN key, which will become the final component of
        /// the CDN key's resource name.
        /// 
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey CreateCdnKey(string parent, CdnKey cdnKey, string cdnKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnKey(new CreateCdnKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CdnKey = gax::GaxPreconditions.CheckNotNull(cdnKey, nameof(cdnKey)),
                CdnKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(cdnKeyId, nameof(cdnKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the CDN key should be created, in the form of
        /// `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="cdnKey">
        /// Required. The CDN key resource to create.
        /// </param>
        /// <param name="cdnKeyId">
        /// Required. The ID to use for the CDN key, which will become the final component of
        /// the CDN key's resource name.
        /// 
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> CreateCdnKeyAsync(string parent, CdnKey cdnKey, string cdnKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnKeyAsync(new CreateCdnKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CdnKey = gax::GaxPreconditions.CheckNotNull(cdnKey, nameof(cdnKey)),
                CdnKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(cdnKeyId, nameof(cdnKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the CDN key should be created, in the form of
        /// `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="cdnKey">
        /// Required. The CDN key resource to create.
        /// </param>
        /// <param name="cdnKeyId">
        /// Required. The ID to use for the CDN key, which will become the final component of
        /// the CDN key's resource name.
        /// 
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> CreateCdnKeyAsync(string parent, CdnKey cdnKey, string cdnKeyId, st::CancellationToken cancellationToken) =>
            CreateCdnKeyAsync(parent, cdnKey, cdnKeyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the CDN key should be created, in the form of
        /// `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="cdnKey">
        /// Required. The CDN key resource to create.
        /// </param>
        /// <param name="cdnKeyId">
        /// Required. The ID to use for the CDN key, which will become the final component of
        /// the CDN key's resource name.
        /// 
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey CreateCdnKey(gagr::LocationName parent, CdnKey cdnKey, string cdnKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnKey(new CreateCdnKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnKey = gax::GaxPreconditions.CheckNotNull(cdnKey, nameof(cdnKey)),
                CdnKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(cdnKeyId, nameof(cdnKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the CDN key should be created, in the form of
        /// `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="cdnKey">
        /// Required. The CDN key resource to create.
        /// </param>
        /// <param name="cdnKeyId">
        /// Required. The ID to use for the CDN key, which will become the final component of
        /// the CDN key's resource name.
        /// 
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> CreateCdnKeyAsync(gagr::LocationName parent, CdnKey cdnKey, string cdnKeyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnKeyAsync(new CreateCdnKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnKey = gax::GaxPreconditions.CheckNotNull(cdnKey, nameof(cdnKey)),
                CdnKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(cdnKeyId, nameof(cdnKeyId)),
            }, callSettings);

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the CDN key should be created, in the form of
        /// `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="cdnKey">
        /// Required. The CDN key resource to create.
        /// </param>
        /// <param name="cdnKeyId">
        /// Required. The ID to use for the CDN key, which will become the final component of
        /// the CDN key's resource name.
        /// 
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> CreateCdnKeyAsync(gagr::LocationName parent, CdnKey cdnKey, string cdnKeyId, st::CancellationToken cancellationToken) =>
            CreateCdnKeyAsync(parent, cdnKey, cdnKeyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CdnKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeys(ListCdnKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CdnKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeysAsync(ListCdnKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that contains the list of CDN keys, in the form of
        /// `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="CdnKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCdnKeys(new ListCdnKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that contains the list of CDN keys, in the form of
        /// `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CdnKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCdnKeysAsync(new ListCdnKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that contains the list of CDN keys, in the form of
        /// `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="CdnKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeys(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCdnKeys(new ListCdnKeysRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that contains the list of CDN keys, in the form of
        /// `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CdnKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeysAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCdnKeysAsync(new ListCdnKeysRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey GetCdnKey(GetCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> GetCdnKeyAsync(GetCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> GetCdnKeyAsync(GetCdnKeyRequest request, st::CancellationToken cancellationToken) =>
            GetCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be retrieved, in the form of
        /// `projects/{project}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey GetCdnKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnKey(new GetCdnKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be retrieved, in the form of
        /// `projects/{project}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> GetCdnKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnKeyAsync(new GetCdnKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be retrieved, in the form of
        /// `projects/{project}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> GetCdnKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetCdnKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be retrieved, in the form of
        /// `projects/{project}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey GetCdnKey(CdnKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnKey(new GetCdnKeyRequest
            {
                CdnKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be retrieved, in the form of
        /// `projects/{project}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> GetCdnKeyAsync(CdnKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnKeyAsync(new GetCdnKeyRequest
            {
                CdnKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be retrieved, in the form of
        /// `projects/{project}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> GetCdnKeyAsync(CdnKeyName name, st::CancellationToken cancellationToken) =>
            GetCdnKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCdnKey(DeleteCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCdnKeyAsync(DeleteCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCdnKeyAsync(DeleteCdnKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCdnKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCdnKey(new DeleteCdnKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCdnKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCdnKeyAsync(new DeleteCdnKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCdnKeyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCdnKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCdnKey(CdnKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCdnKey(new DeleteCdnKeyRequest
            {
                CdnKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCdnKeyAsync(CdnKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCdnKeyAsync(new DeleteCdnKeyRequest
            {
                CdnKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CDN key to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/cdnKeys/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCdnKeyAsync(CdnKeyName name, st::CancellationToken cancellationToken) =>
            DeleteCdnKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey UpdateCdnKey(UpdateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> UpdateCdnKeyAsync(UpdateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> UpdateCdnKeyAsync(UpdateCdnKeyRequest request, st::CancellationToken cancellationToken) =>
            UpdateCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="cdnKey">
        /// Required. The CDN key resource which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnKey UpdateCdnKey(CdnKey cdnKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCdnKey(new UpdateCdnKeyRequest
            {
                CdnKey = gax::GaxPreconditions.CheckNotNull(cdnKey, nameof(cdnKey)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="cdnKey">
        /// Required. The CDN key resource which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> UpdateCdnKeyAsync(CdnKey cdnKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCdnKeyAsync(new UpdateCdnKeyRequest
            {
                CdnKey = gax::GaxPreconditions.CheckNotNull(cdnKey, nameof(cdnKey)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="cdnKey">
        /// Required. The CDN key resource which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnKey> UpdateCdnKeyAsync(CdnKey cdnKey, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCdnKeyAsync(cdnKey, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodSession CreateVodSession(CreateVodSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> CreateVodSessionAsync(CreateVodSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> CreateVodSessionAsync(CreateVodSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateVodSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the VOD session should be created, in the
        /// form of `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="vodSession">
        /// Required. Parameters for creating a session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodSession CreateVodSession(string parent, VodSession vodSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateVodSession(new CreateVodSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VodSession = gax::GaxPreconditions.CheckNotNull(vodSession, nameof(vodSession)),
            }, callSettings);

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the VOD session should be created, in the
        /// form of `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="vodSession">
        /// Required. Parameters for creating a session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> CreateVodSessionAsync(string parent, VodSession vodSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateVodSessionAsync(new CreateVodSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VodSession = gax::GaxPreconditions.CheckNotNull(vodSession, nameof(vodSession)),
            }, callSettings);

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the VOD session should be created, in the
        /// form of `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="vodSession">
        /// Required. Parameters for creating a session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> CreateVodSessionAsync(string parent, VodSession vodSession, st::CancellationToken cancellationToken) =>
            CreateVodSessionAsync(parent, vodSession, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the VOD session should be created, in the
        /// form of `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="vodSession">
        /// Required. Parameters for creating a session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodSession CreateVodSession(gagr::LocationName parent, VodSession vodSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateVodSession(new CreateVodSessionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VodSession = gax::GaxPreconditions.CheckNotNull(vodSession, nameof(vodSession)),
            }, callSettings);

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the VOD session should be created, in the
        /// form of `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="vodSession">
        /// Required. Parameters for creating a session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> CreateVodSessionAsync(gagr::LocationName parent, VodSession vodSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateVodSessionAsync(new CreateVodSessionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VodSession = gax::GaxPreconditions.CheckNotNull(vodSession, nameof(vodSession)),
            }, callSettings);

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the VOD session should be created, in the
        /// form of `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="vodSession">
        /// Required. Parameters for creating a session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> CreateVodSessionAsync(gagr::LocationName parent, VodSession vodSession, st::CancellationToken cancellationToken) =>
            CreateVodSessionAsync(parent, vodSession, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodSession GetVodSession(GetVodSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> GetVodSessionAsync(GetVodSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> GetVodSessionAsync(GetVodSessionRequest request, st::CancellationToken cancellationToken) =>
            GetVodSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VOD session to be retrieved, in the form of
        /// `projects/{project_number}/locations/{location}/vodSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodSession GetVodSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodSession(new GetVodSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VOD session to be retrieved, in the form of
        /// `projects/{project_number}/locations/{location}/vodSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> GetVodSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodSessionAsync(new GetVodSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VOD session to be retrieved, in the form of
        /// `projects/{project_number}/locations/{location}/vodSessions/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> GetVodSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetVodSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VOD session to be retrieved, in the form of
        /// `projects/{project_number}/locations/{location}/vodSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodSession GetVodSession(VodSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodSession(new GetVodSessionRequest
            {
                VodSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VOD session to be retrieved, in the form of
        /// `projects/{project_number}/locations/{location}/vodSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> GetVodSessionAsync(VodSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodSessionAsync(new GetVodSessionRequest
            {
                VodSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VOD session to be retrieved, in the form of
        /// `projects/{project_number}/locations/{location}/vodSessions/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodSession> GetVodSessionAsync(VodSessionName name, st::CancellationToken cancellationToken) =>
            GetVodSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetails(ListVodStitchDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetailsAsync(ListVodStitchDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session where the stitch details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{id}`.
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
        /// <returns>A pageable sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodStitchDetails(new ListVodStitchDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session where the stitch details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodStitchDetailsAsync(new ListVodStitchDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session where the stitch details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{id}`.
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
        /// <returns>A pageable sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetails(VodSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodStitchDetails(new ListVodStitchDetailsRequest
            {
                ParentAsVodSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session where the stitch details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetailsAsync(VodSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodStitchDetailsAsync(new ListVodStitchDetailsRequest
            {
                ParentAsVodSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodStitchDetail GetVodStitchDetail(GetVodStitchDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodStitchDetail> GetVodStitchDetailAsync(GetVodStitchDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodStitchDetail> GetVodStitchDetailAsync(GetVodStitchDetailRequest request, st::CancellationToken cancellationToken) =>
            GetVodStitchDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stitch detail in the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodStitchDetails/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodStitchDetail GetVodStitchDetail(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodStitchDetail(new GetVodStitchDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stitch detail in the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodStitchDetails/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodStitchDetail> GetVodStitchDetailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodStitchDetailAsync(new GetVodStitchDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stitch detail in the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodStitchDetails/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodStitchDetail> GetVodStitchDetailAsync(string name, st::CancellationToken cancellationToken) =>
            GetVodStitchDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stitch detail in the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodStitchDetails/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodStitchDetail GetVodStitchDetail(VodStitchDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodStitchDetail(new GetVodStitchDetailRequest
            {
                VodStitchDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stitch detail in the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodStitchDetails/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodStitchDetail> GetVodStitchDetailAsync(VodStitchDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodStitchDetailAsync(new GetVodStitchDetailRequest
            {
                VodStitchDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the stitch detail in the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodStitchDetails/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodStitchDetail> GetVodStitchDetailAsync(VodStitchDetailName name, st::CancellationToken cancellationToken) =>
            GetVodStitchDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetails(ListVodAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetailsAsync(ListVodAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session which the ad tag details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}`.
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
        /// <returns>A pageable sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodAdTagDetails(new ListVodAdTagDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session which the ad tag details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodAdTagDetailsAsync(new ListVodAdTagDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session which the ad tag details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}`.
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
        /// <returns>A pageable sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetails(VodSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodAdTagDetails(new ListVodAdTagDetailsRequest
            {
                ParentAsVodSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="parent">
        /// Required. The VOD session which the ad tag details belong to, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetailsAsync(VodSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVodAdTagDetailsAsync(new ListVodAdTagDetailsRequest
            {
                ParentAsVodSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodAdTagDetail GetVodAdTagDetail(GetVodAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodAdTagDetail> GetVodAdTagDetailAsync(GetVodAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodAdTagDetail> GetVodAdTagDetailAsync(GetVodAdTagDetailRequest request, st::CancellationToken cancellationToken) =>
            GetVodAdTagDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad tag detail for the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodAdTagDetails/{vod_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodAdTagDetail GetVodAdTagDetail(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodAdTagDetail(new GetVodAdTagDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad tag detail for the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodAdTagDetails/{vod_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodAdTagDetail> GetVodAdTagDetailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodAdTagDetailAsync(new GetVodAdTagDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad tag detail for the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodAdTagDetails/{vod_ad_tag_detail}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodAdTagDetail> GetVodAdTagDetailAsync(string name, st::CancellationToken cancellationToken) =>
            GetVodAdTagDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad tag detail for the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodAdTagDetails/{vod_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VodAdTagDetail GetVodAdTagDetail(VodAdTagDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodAdTagDetail(new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad tag detail for the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodAdTagDetails/{vod_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodAdTagDetail> GetVodAdTagDetailAsync(VodAdTagDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVodAdTagDetailAsync(new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad tag detail for the specified VOD session, in the form of
        /// `projects/{project}/locations/{location}/vodSessions/{vod_session_id}/vodAdTagDetails/{vod_ad_tag_detail}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VodAdTagDetail> GetVodAdTagDetailAsync(VodAdTagDetailName name, st::CancellationToken cancellationToken) =>
            GetVodAdTagDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetails(ListLiveAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetailsAsync(ListLiveAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource parent in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}`.
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
        /// <returns>A pageable sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLiveAdTagDetails(new ListLiveAdTagDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource parent in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLiveAdTagDetailsAsync(new ListLiveAdTagDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource parent in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}`.
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
        /// <returns>A pageable sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetails(LiveSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLiveAdTagDetails(new ListLiveAdTagDetailsRequest
            {
                ParentAsLiveSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource parent in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetailsAsync(LiveSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLiveAdTagDetailsAsync(new ListLiveAdTagDetailsRequest
            {
                ParentAsLiveSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveAdTagDetail GetLiveAdTagDetail(GetLiveAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveAdTagDetail> GetLiveAdTagDetailAsync(GetLiveAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveAdTagDetail> GetLiveAdTagDetailAsync(GetLiveAdTagDetailRequest request, st::CancellationToken cancellationToken) =>
            GetLiveAdTagDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveAdTagDetail GetLiveAdTagDetail(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveAdTagDetail(new GetLiveAdTagDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveAdTagDetail> GetLiveAdTagDetailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveAdTagDetailAsync(new GetLiveAdTagDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveAdTagDetail> GetLiveAdTagDetailAsync(string name, st::CancellationToken cancellationToken) =>
            GetLiveAdTagDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveAdTagDetail GetLiveAdTagDetail(LiveAdTagDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveAdTagDetail(new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveAdTagDetail> GetLiveAdTagDetailAsync(LiveAdTagDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveAdTagDetailAsync(new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name in the form of
        /// `projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveAdTagDetail> GetLiveAdTagDetailAsync(LiveAdTagDetailName name, st::CancellationToken cancellationToken) =>
            GetLiveAdTagDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate CreateSlate(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(CreateSlateRequest request, st::CancellationToken cancellationToken) =>
            CreateSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the slate should be created, in the form of
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="slate">
        /// Required. The slate to create.
        /// </param>
        /// <param name="slateId">
        /// Required. The unique identifier for the slate.
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate CreateSlate(string parent, Slate slate, string slateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlate(new CreateSlateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SlateId = gax::GaxPreconditions.CheckNotNullOrEmpty(slateId, nameof(slateId)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the slate should be created, in the form of
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="slate">
        /// Required. The slate to create.
        /// </param>
        /// <param name="slateId">
        /// Required. The unique identifier for the slate.
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(string parent, Slate slate, string slateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlateAsync(new CreateSlateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SlateId = gax::GaxPreconditions.CheckNotNullOrEmpty(slateId, nameof(slateId)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the slate should be created, in the form of
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="slate">
        /// Required. The slate to create.
        /// </param>
        /// <param name="slateId">
        /// Required. The unique identifier for the slate.
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(string parent, Slate slate, string slateId, st::CancellationToken cancellationToken) =>
            CreateSlateAsync(parent, slate, slateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the slate should be created, in the form of
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="slate">
        /// Required. The slate to create.
        /// </param>
        /// <param name="slateId">
        /// Required. The unique identifier for the slate.
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate CreateSlate(gagr::LocationName parent, Slate slate, string slateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlate(new CreateSlateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SlateId = gax::GaxPreconditions.CheckNotNullOrEmpty(slateId, nameof(slateId)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the slate should be created, in the form of
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="slate">
        /// Required. The slate to create.
        /// </param>
        /// <param name="slateId">
        /// Required. The unique identifier for the slate.
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(gagr::LocationName parent, Slate slate, string slateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlateAsync(new CreateSlateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SlateId = gax::GaxPreconditions.CheckNotNullOrEmpty(slateId, nameof(slateId)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the slate should be created, in the form of
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="slate">
        /// Required. The slate to create.
        /// </param>
        /// <param name="slateId">
        /// Required. The unique identifier for the slate.
        /// This value should conform to RFC-1034, which restricts to
        /// lower-case letters, numbers, and hyphen, with the first character a
        /// letter, the last a letter or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(gagr::LocationName parent, Slate slate, string slateId, st::CancellationToken cancellationToken) =>
            CreateSlateAsync(parent, slate, slateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list slates, in the form of `projects/{project_number}`.
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
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSlates(new ListSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list slates, in the form of `projects/{project_number}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSlatesAsync(new ListSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list slates, in the form of `projects/{project_number}`.
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
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSlates(new ListSlatesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list slates, in the form of `projects/{project_number}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSlatesAsync(new ListSlatesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate GetSlate(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(GetSlateRequest request, st::CancellationToken cancellationToken) =>
            GetSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be retrieved, of the slate, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate GetSlate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlate(new GetSlateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be retrieved, of the slate, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlateAsync(new GetSlateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be retrieved, of the slate, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(string name, st::CancellationToken cancellationToken) =>
            GetSlateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be retrieved, of the slate, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate GetSlate(SlateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlate(new GetSlateRequest
            {
                SlateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be retrieved, of the slate, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(SlateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlateAsync(new GetSlateRequest
            {
                SlateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be retrieved, of the slate, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(SlateName name, st::CancellationToken cancellationToken) =>
            GetSlateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate UpdateSlate(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(UpdateSlateRequest request, st::CancellationToken cancellationToken) =>
            UpdateSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="slate">
        /// Required. The resource with updated fields.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask which specifies fields which should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate UpdateSlate(Slate slate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSlate(new UpdateSlateRequest
            {
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="slate">
        /// Required. The resource with updated fields.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask which specifies fields which should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(Slate slate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSlateAsync(new UpdateSlateRequest
            {
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="slate">
        /// Required. The resource with updated fields.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask which specifies fields which should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(Slate slate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSlateAsync(slate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSlate(DeleteSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSlateAsync(DeleteSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSlateAsync(DeleteSlateRequest request, st::CancellationToken cancellationToken) =>
            DeleteSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSlate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSlate(new DeleteSlateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSlateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSlateAsync(new DeleteSlateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSlateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSlateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSlate(SlateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSlate(new DeleteSlateRequest
            {
                SlateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSlateAsync(SlateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSlateAsync(new DeleteSlateRequest
            {
                SlateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the slate to be deleted, in the form of
        /// `projects/{project_number}/locations/{location}/slates/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSlateAsync(SlateName name, st::CancellationToken cancellationToken) =>
            DeleteSlateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveSession CreateLiveSession(CreateLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> CreateLiveSessionAsync(CreateLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> CreateLiveSessionAsync(CreateLiveSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateLiveSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the live session should be created,
        /// in the form of `projects/{project_number}/locations/{location}`.
        /// 
        /// Valid locations:
        /// 
        /// * `-` (Video Stitcher API will pick a location that is closest to the
        /// caller.)
        /// * `us-east1`
        /// * `us-west1`
        /// * `us-central1`
        /// * `europe-west1`
        /// </param>
        /// <param name="liveSession">
        /// Required. Parameters for creating a live session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveSession CreateLiveSession(string parent, LiveSession liveSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveSession(new CreateLiveSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LiveSession = gax::GaxPreconditions.CheckNotNull(liveSession, nameof(liveSession)),
            }, callSettings);

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the live session should be created,
        /// in the form of `projects/{project_number}/locations/{location}`.
        /// 
        /// Valid locations:
        /// 
        /// * `-` (Video Stitcher API will pick a location that is closest to the
        /// caller.)
        /// * `us-east1`
        /// * `us-west1`
        /// * `us-central1`
        /// * `europe-west1`
        /// </param>
        /// <param name="liveSession">
        /// Required. Parameters for creating a live session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> CreateLiveSessionAsync(string parent, LiveSession liveSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveSessionAsync(new CreateLiveSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LiveSession = gax::GaxPreconditions.CheckNotNull(liveSession, nameof(liveSession)),
            }, callSettings);

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the live session should be created,
        /// in the form of `projects/{project_number}/locations/{location}`.
        /// 
        /// Valid locations:
        /// 
        /// * `-` (Video Stitcher API will pick a location that is closest to the
        /// caller.)
        /// * `us-east1`
        /// * `us-west1`
        /// * `us-central1`
        /// * `europe-west1`
        /// </param>
        /// <param name="liveSession">
        /// Required. Parameters for creating a live session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> CreateLiveSessionAsync(string parent, LiveSession liveSession, st::CancellationToken cancellationToken) =>
            CreateLiveSessionAsync(parent, liveSession, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the live session should be created,
        /// in the form of `projects/{project_number}/locations/{location}`.
        /// 
        /// Valid locations:
        /// 
        /// * `-` (Video Stitcher API will pick a location that is closest to the
        /// caller.)
        /// * `us-east1`
        /// * `us-west1`
        /// * `us-central1`
        /// * `europe-west1`
        /// </param>
        /// <param name="liveSession">
        /// Required. Parameters for creating a live session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveSession CreateLiveSession(LiveSessionName parent, LiveSession liveSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveSession(new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveSession = gax::GaxPreconditions.CheckNotNull(liveSession, nameof(liveSession)),
            }, callSettings);

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the live session should be created,
        /// in the form of `projects/{project_number}/locations/{location}`.
        /// 
        /// Valid locations:
        /// 
        /// * `-` (Video Stitcher API will pick a location that is closest to the
        /// caller.)
        /// * `us-east1`
        /// * `us-west1`
        /// * `us-central1`
        /// * `europe-west1`
        /// </param>
        /// <param name="liveSession">
        /// Required. Parameters for creating a live session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> CreateLiveSessionAsync(LiveSessionName parent, LiveSession liveSession, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveSessionAsync(new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveSession = gax::GaxPreconditions.CheckNotNull(liveSession, nameof(liveSession)),
            }, callSettings);

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the live session should be created,
        /// in the form of `projects/{project_number}/locations/{location}`.
        /// 
        /// Valid locations:
        /// 
        /// * `-` (Video Stitcher API will pick a location that is closest to the
        /// caller.)
        /// * `us-east1`
        /// * `us-west1`
        /// * `us-central1`
        /// * `europe-west1`
        /// </param>
        /// <param name="liveSession">
        /// Required. Parameters for creating a live session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> CreateLiveSessionAsync(LiveSessionName parent, LiveSession liveSession, st::CancellationToken cancellationToken) =>
            CreateLiveSessionAsync(parent, liveSession, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveSession GetLiveSession(GetLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> GetLiveSessionAsync(GetLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> GetLiveSessionAsync(GetLiveSessionRequest request, st::CancellationToken cancellationToken) =>
            GetLiveSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the live session, in the form of
        /// `projects/{project_number}/locations/{location}/liveSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveSession GetLiveSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveSession(new GetLiveSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the live session, in the form of
        /// `projects/{project_number}/locations/{location}/liveSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> GetLiveSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveSessionAsync(new GetLiveSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the live session, in the form of
        /// `projects/{project_number}/locations/{location}/liveSessions/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> GetLiveSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetLiveSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the live session, in the form of
        /// `projects/{project_number}/locations/{location}/liveSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveSession GetLiveSession(LiveSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveSession(new GetLiveSessionRequest
            {
                LiveSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the live session, in the form of
        /// `projects/{project_number}/locations/{location}/liveSessions/{id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> GetLiveSessionAsync(LiveSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveSessionAsync(new GetLiveSessionRequest
            {
                LiveSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the live session, in the form of
        /// `projects/{project_number}/locations/{location}/liveSessions/{id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveSession> GetLiveSessionAsync(LiveSessionName name, st::CancellationToken cancellationToken) =>
            GetLiveSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VideoStitcherService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Video-On-Demand content stitching API allows you to insert ads
    /// into (VoD) video on demand files. You will be able to render custom
    /// scrubber bars with highlighted ads, enforce ad policies, allow
    /// seamless playback and tracking on native players and monetize
    /// content with any standard VMAP compliant ad server.
    /// </remarks>
    public sealed partial class VideoStitcherServiceClientImpl : VideoStitcherServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateCdnKeyRequest, CdnKey> _callCreateCdnKey;

        private readonly gaxgrpc::ApiCall<ListCdnKeysRequest, ListCdnKeysResponse> _callListCdnKeys;

        private readonly gaxgrpc::ApiCall<GetCdnKeyRequest, CdnKey> _callGetCdnKey;

        private readonly gaxgrpc::ApiCall<DeleteCdnKeyRequest, wkt::Empty> _callDeleteCdnKey;

        private readonly gaxgrpc::ApiCall<UpdateCdnKeyRequest, CdnKey> _callUpdateCdnKey;

        private readonly gaxgrpc::ApiCall<CreateVodSessionRequest, VodSession> _callCreateVodSession;

        private readonly gaxgrpc::ApiCall<GetVodSessionRequest, VodSession> _callGetVodSession;

        private readonly gaxgrpc::ApiCall<ListVodStitchDetailsRequest, ListVodStitchDetailsResponse> _callListVodStitchDetails;

        private readonly gaxgrpc::ApiCall<GetVodStitchDetailRequest, VodStitchDetail> _callGetVodStitchDetail;

        private readonly gaxgrpc::ApiCall<ListVodAdTagDetailsRequest, ListVodAdTagDetailsResponse> _callListVodAdTagDetails;

        private readonly gaxgrpc::ApiCall<GetVodAdTagDetailRequest, VodAdTagDetail> _callGetVodAdTagDetail;

        private readonly gaxgrpc::ApiCall<ListLiveAdTagDetailsRequest, ListLiveAdTagDetailsResponse> _callListLiveAdTagDetails;

        private readonly gaxgrpc::ApiCall<GetLiveAdTagDetailRequest, LiveAdTagDetail> _callGetLiveAdTagDetail;

        private readonly gaxgrpc::ApiCall<CreateSlateRequest, Slate> _callCreateSlate;

        private readonly gaxgrpc::ApiCall<ListSlatesRequest, ListSlatesResponse> _callListSlates;

        private readonly gaxgrpc::ApiCall<GetSlateRequest, Slate> _callGetSlate;

        private readonly gaxgrpc::ApiCall<UpdateSlateRequest, Slate> _callUpdateSlate;

        private readonly gaxgrpc::ApiCall<DeleteSlateRequest, wkt::Empty> _callDeleteSlate;

        private readonly gaxgrpc::ApiCall<CreateLiveSessionRequest, LiveSession> _callCreateLiveSession;

        private readonly gaxgrpc::ApiCall<GetLiveSessionRequest, LiveSession> _callGetLiveSession;

        /// <summary>
        /// Constructs a client wrapper for the VideoStitcherService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VideoStitcherServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VideoStitcherServiceClientImpl(VideoStitcherService.VideoStitcherServiceClient grpcClient, VideoStitcherServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VideoStitcherServiceSettings effectiveSettings = settings ?? VideoStitcherServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callCreateCdnKey = clientHelper.BuildApiCall<CreateCdnKeyRequest, CdnKey>("CreateCdnKey", grpcClient.CreateCdnKeyAsync, grpcClient.CreateCdnKey, effectiveSettings.CreateCdnKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCdnKey);
            Modify_CreateCdnKeyApiCall(ref _callCreateCdnKey);
            _callListCdnKeys = clientHelper.BuildApiCall<ListCdnKeysRequest, ListCdnKeysResponse>("ListCdnKeys", grpcClient.ListCdnKeysAsync, grpcClient.ListCdnKeys, effectiveSettings.ListCdnKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCdnKeys);
            Modify_ListCdnKeysApiCall(ref _callListCdnKeys);
            _callGetCdnKey = clientHelper.BuildApiCall<GetCdnKeyRequest, CdnKey>("GetCdnKey", grpcClient.GetCdnKeyAsync, grpcClient.GetCdnKey, effectiveSettings.GetCdnKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCdnKey);
            Modify_GetCdnKeyApiCall(ref _callGetCdnKey);
            _callDeleteCdnKey = clientHelper.BuildApiCall<DeleteCdnKeyRequest, wkt::Empty>("DeleteCdnKey", grpcClient.DeleteCdnKeyAsync, grpcClient.DeleteCdnKey, effectiveSettings.DeleteCdnKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCdnKey);
            Modify_DeleteCdnKeyApiCall(ref _callDeleteCdnKey);
            _callUpdateCdnKey = clientHelper.BuildApiCall<UpdateCdnKeyRequest, CdnKey>("UpdateCdnKey", grpcClient.UpdateCdnKeyAsync, grpcClient.UpdateCdnKey, effectiveSettings.UpdateCdnKeySettings).WithGoogleRequestParam("cdn_key.name", request => request.CdnKey?.Name);
            Modify_ApiCall(ref _callUpdateCdnKey);
            Modify_UpdateCdnKeyApiCall(ref _callUpdateCdnKey);
            _callCreateVodSession = clientHelper.BuildApiCall<CreateVodSessionRequest, VodSession>("CreateVodSession", grpcClient.CreateVodSessionAsync, grpcClient.CreateVodSession, effectiveSettings.CreateVodSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVodSession);
            Modify_CreateVodSessionApiCall(ref _callCreateVodSession);
            _callGetVodSession = clientHelper.BuildApiCall<GetVodSessionRequest, VodSession>("GetVodSession", grpcClient.GetVodSessionAsync, grpcClient.GetVodSession, effectiveSettings.GetVodSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVodSession);
            Modify_GetVodSessionApiCall(ref _callGetVodSession);
            _callListVodStitchDetails = clientHelper.BuildApiCall<ListVodStitchDetailsRequest, ListVodStitchDetailsResponse>("ListVodStitchDetails", grpcClient.ListVodStitchDetailsAsync, grpcClient.ListVodStitchDetails, effectiveSettings.ListVodStitchDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVodStitchDetails);
            Modify_ListVodStitchDetailsApiCall(ref _callListVodStitchDetails);
            _callGetVodStitchDetail = clientHelper.BuildApiCall<GetVodStitchDetailRequest, VodStitchDetail>("GetVodStitchDetail", grpcClient.GetVodStitchDetailAsync, grpcClient.GetVodStitchDetail, effectiveSettings.GetVodStitchDetailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVodStitchDetail);
            Modify_GetVodStitchDetailApiCall(ref _callGetVodStitchDetail);
            _callListVodAdTagDetails = clientHelper.BuildApiCall<ListVodAdTagDetailsRequest, ListVodAdTagDetailsResponse>("ListVodAdTagDetails", grpcClient.ListVodAdTagDetailsAsync, grpcClient.ListVodAdTagDetails, effectiveSettings.ListVodAdTagDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVodAdTagDetails);
            Modify_ListVodAdTagDetailsApiCall(ref _callListVodAdTagDetails);
            _callGetVodAdTagDetail = clientHelper.BuildApiCall<GetVodAdTagDetailRequest, VodAdTagDetail>("GetVodAdTagDetail", grpcClient.GetVodAdTagDetailAsync, grpcClient.GetVodAdTagDetail, effectiveSettings.GetVodAdTagDetailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVodAdTagDetail);
            Modify_GetVodAdTagDetailApiCall(ref _callGetVodAdTagDetail);
            _callListLiveAdTagDetails = clientHelper.BuildApiCall<ListLiveAdTagDetailsRequest, ListLiveAdTagDetailsResponse>("ListLiveAdTagDetails", grpcClient.ListLiveAdTagDetailsAsync, grpcClient.ListLiveAdTagDetails, effectiveSettings.ListLiveAdTagDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLiveAdTagDetails);
            Modify_ListLiveAdTagDetailsApiCall(ref _callListLiveAdTagDetails);
            _callGetLiveAdTagDetail = clientHelper.BuildApiCall<GetLiveAdTagDetailRequest, LiveAdTagDetail>("GetLiveAdTagDetail", grpcClient.GetLiveAdTagDetailAsync, grpcClient.GetLiveAdTagDetail, effectiveSettings.GetLiveAdTagDetailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLiveAdTagDetail);
            Modify_GetLiveAdTagDetailApiCall(ref _callGetLiveAdTagDetail);
            _callCreateSlate = clientHelper.BuildApiCall<CreateSlateRequest, Slate>("CreateSlate", grpcClient.CreateSlateAsync, grpcClient.CreateSlate, effectiveSettings.CreateSlateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSlate);
            Modify_CreateSlateApiCall(ref _callCreateSlate);
            _callListSlates = clientHelper.BuildApiCall<ListSlatesRequest, ListSlatesResponse>("ListSlates", grpcClient.ListSlatesAsync, grpcClient.ListSlates, effectiveSettings.ListSlatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSlates);
            Modify_ListSlatesApiCall(ref _callListSlates);
            _callGetSlate = clientHelper.BuildApiCall<GetSlateRequest, Slate>("GetSlate", grpcClient.GetSlateAsync, grpcClient.GetSlate, effectiveSettings.GetSlateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSlate);
            Modify_GetSlateApiCall(ref _callGetSlate);
            _callUpdateSlate = clientHelper.BuildApiCall<UpdateSlateRequest, Slate>("UpdateSlate", grpcClient.UpdateSlateAsync, grpcClient.UpdateSlate, effectiveSettings.UpdateSlateSettings).WithGoogleRequestParam("slate.name", request => request.Slate?.Name);
            Modify_ApiCall(ref _callUpdateSlate);
            Modify_UpdateSlateApiCall(ref _callUpdateSlate);
            _callDeleteSlate = clientHelper.BuildApiCall<DeleteSlateRequest, wkt::Empty>("DeleteSlate", grpcClient.DeleteSlateAsync, grpcClient.DeleteSlate, effectiveSettings.DeleteSlateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSlate);
            Modify_DeleteSlateApiCall(ref _callDeleteSlate);
            _callCreateLiveSession = clientHelper.BuildApiCall<CreateLiveSessionRequest, LiveSession>("CreateLiveSession", grpcClient.CreateLiveSessionAsync, grpcClient.CreateLiveSession, effectiveSettings.CreateLiveSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLiveSession);
            Modify_CreateLiveSessionApiCall(ref _callCreateLiveSession);
            _callGetLiveSession = clientHelper.BuildApiCall<GetLiveSessionRequest, LiveSession>("GetLiveSession", grpcClient.GetLiveSessionAsync, grpcClient.GetLiveSession, effectiveSettings.GetLiveSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLiveSession);
            Modify_GetLiveSessionApiCall(ref _callGetLiveSession);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCdnKeyApiCall(ref gaxgrpc::ApiCall<CreateCdnKeyRequest, CdnKey> call);

        partial void Modify_ListCdnKeysApiCall(ref gaxgrpc::ApiCall<ListCdnKeysRequest, ListCdnKeysResponse> call);

        partial void Modify_GetCdnKeyApiCall(ref gaxgrpc::ApiCall<GetCdnKeyRequest, CdnKey> call);

        partial void Modify_DeleteCdnKeyApiCall(ref gaxgrpc::ApiCall<DeleteCdnKeyRequest, wkt::Empty> call);

        partial void Modify_UpdateCdnKeyApiCall(ref gaxgrpc::ApiCall<UpdateCdnKeyRequest, CdnKey> call);

        partial void Modify_CreateVodSessionApiCall(ref gaxgrpc::ApiCall<CreateVodSessionRequest, VodSession> call);

        partial void Modify_GetVodSessionApiCall(ref gaxgrpc::ApiCall<GetVodSessionRequest, VodSession> call);

        partial void Modify_ListVodStitchDetailsApiCall(ref gaxgrpc::ApiCall<ListVodStitchDetailsRequest, ListVodStitchDetailsResponse> call);

        partial void Modify_GetVodStitchDetailApiCall(ref gaxgrpc::ApiCall<GetVodStitchDetailRequest, VodStitchDetail> call);

        partial void Modify_ListVodAdTagDetailsApiCall(ref gaxgrpc::ApiCall<ListVodAdTagDetailsRequest, ListVodAdTagDetailsResponse> call);

        partial void Modify_GetVodAdTagDetailApiCall(ref gaxgrpc::ApiCall<GetVodAdTagDetailRequest, VodAdTagDetail> call);

        partial void Modify_ListLiveAdTagDetailsApiCall(ref gaxgrpc::ApiCall<ListLiveAdTagDetailsRequest, ListLiveAdTagDetailsResponse> call);

        partial void Modify_GetLiveAdTagDetailApiCall(ref gaxgrpc::ApiCall<GetLiveAdTagDetailRequest, LiveAdTagDetail> call);

        partial void Modify_CreateSlateApiCall(ref gaxgrpc::ApiCall<CreateSlateRequest, Slate> call);

        partial void Modify_ListSlatesApiCall(ref gaxgrpc::ApiCall<ListSlatesRequest, ListSlatesResponse> call);

        partial void Modify_GetSlateApiCall(ref gaxgrpc::ApiCall<GetSlateRequest, Slate> call);

        partial void Modify_UpdateSlateApiCall(ref gaxgrpc::ApiCall<UpdateSlateRequest, Slate> call);

        partial void Modify_DeleteSlateApiCall(ref gaxgrpc::ApiCall<DeleteSlateRequest, wkt::Empty> call);

        partial void Modify_CreateLiveSessionApiCall(ref gaxgrpc::ApiCall<CreateLiveSessionRequest, LiveSession> call);

        partial void Modify_GetLiveSessionApiCall(ref gaxgrpc::ApiCall<GetLiveSessionRequest, LiveSession> call);

        partial void OnConstruction(VideoStitcherService.VideoStitcherServiceClient grpcClient, VideoStitcherServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VideoStitcherService client</summary>
        public override VideoStitcherService.VideoStitcherServiceClient GrpcClient { get; }

        partial void Modify_CreateCdnKeyRequest(ref CreateCdnKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCdnKeysRequest(ref ListCdnKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCdnKeyRequest(ref GetCdnKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCdnKeyRequest(ref DeleteCdnKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCdnKeyRequest(ref UpdateCdnKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVodSessionRequest(ref CreateVodSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVodSessionRequest(ref GetVodSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVodStitchDetailsRequest(ref ListVodStitchDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVodStitchDetailRequest(ref GetVodStitchDetailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVodAdTagDetailsRequest(ref ListVodAdTagDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVodAdTagDetailRequest(ref GetVodAdTagDetailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLiveAdTagDetailsRequest(ref ListLiveAdTagDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLiveAdTagDetailRequest(ref GetLiveAdTagDetailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSlateRequest(ref CreateSlateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSlatesRequest(ref ListSlatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSlateRequest(ref GetSlateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSlateRequest(ref UpdateSlateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSlateRequest(ref DeleteSlateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLiveSessionRequest(ref CreateLiveSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLiveSessionRequest(ref GetLiveSessionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CdnKey CreateCdnKey(CreateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCdnKeyRequest(ref request, ref callSettings);
            return _callCreateCdnKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CdnKey> CreateCdnKeyAsync(CreateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCdnKeyRequest(ref request, ref callSettings);
            return _callCreateCdnKey.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CdnKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeys(ListCdnKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCdnKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCdnKeysRequest, ListCdnKeysResponse, CdnKey>(_callListCdnKeys, request, callSettings);
        }

        /// <summary>
        /// Lists all CDN keys in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CdnKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCdnKeysResponse, CdnKey> ListCdnKeysAsync(ListCdnKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCdnKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCdnKeysRequest, ListCdnKeysResponse, CdnKey>(_callListCdnKeys, request, callSettings);
        }

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CdnKey GetCdnKey(GetCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCdnKeyRequest(ref request, ref callSettings);
            return _callGetCdnKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CdnKey> GetCdnKeyAsync(GetCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCdnKeyRequest(ref request, ref callSettings);
            return _callGetCdnKey.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCdnKey(DeleteCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCdnKeyRequest(ref request, ref callSettings);
            _callDeleteCdnKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified CDN key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCdnKeyAsync(DeleteCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCdnKeyRequest(ref request, ref callSettings);
            return _callDeleteCdnKey.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CdnKey UpdateCdnKey(UpdateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCdnKeyRequest(ref request, ref callSettings);
            return _callUpdateCdnKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified CDN key. Only update fields specified
        /// in the call method body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CdnKey> UpdateCdnKeyAsync(UpdateCdnKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCdnKeyRequest(ref request, ref callSettings);
            return _callUpdateCdnKey.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VodSession CreateVodSession(CreateVodSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVodSessionRequest(ref request, ref callSettings);
            return _callCreateVodSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a client side playback VOD session and returns the full
        /// tracking and playback metadata of the session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VodSession> CreateVodSessionAsync(CreateVodSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVodSessionRequest(ref request, ref callSettings);
            return _callCreateVodSession.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VodSession GetVodSession(GetVodSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVodSessionRequest(ref request, ref callSettings);
            return _callGetVodSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the full tracking, playback metadata, and relevant ad-ops
        /// logs for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VodSession> GetVodSessionAsync(GetVodSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVodSessionRequest(ref request, ref callSettings);
            return _callGetVodSession.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public override gax::PagedEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetails(ListVodStitchDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVodStitchDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVodStitchDetailsRequest, ListVodStitchDetailsResponse, VodStitchDetail>(_callListVodStitchDetails, request, callSettings);
        }

        /// <summary>
        /// Returns a list of detailed stitching information of the specified VOD
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VodStitchDetail"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVodStitchDetailsResponse, VodStitchDetail> ListVodStitchDetailsAsync(ListVodStitchDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVodStitchDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVodStitchDetailsRequest, ListVodStitchDetailsResponse, VodStitchDetail>(_callListVodStitchDetails, request, callSettings);
        }

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VodStitchDetail GetVodStitchDetail(GetVodStitchDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVodStitchDetailRequest(ref request, ref callSettings);
            return _callGetVodStitchDetail.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified stitching information for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VodStitchDetail> GetVodStitchDetailAsync(GetVodStitchDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVodStitchDetailRequest(ref request, ref callSettings);
            return _callGetVodStitchDetail.Async(request, callSettings);
        }

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public override gax::PagedEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetails(ListVodAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVodAdTagDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVodAdTagDetailsRequest, ListVodAdTagDetailsResponse, VodAdTagDetail>(_callListVodAdTagDetails, request, callSettings);
        }

        /// <summary>
        /// Return the list of ad tag details for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VodAdTagDetail"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVodAdTagDetailsResponse, VodAdTagDetail> ListVodAdTagDetailsAsync(ListVodAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVodAdTagDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVodAdTagDetailsRequest, ListVodAdTagDetailsResponse, VodAdTagDetail>(_callListVodAdTagDetails, request, callSettings);
        }

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VodAdTagDetail GetVodAdTagDetail(GetVodAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVodAdTagDetailRequest(ref request, ref callSettings);
            return _callGetVodAdTagDetail.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified ad tag detail for the specified VOD session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VodAdTagDetail> GetVodAdTagDetailAsync(GetVodAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVodAdTagDetailRequest(ref request, ref callSettings);
            return _callGetVodAdTagDetail.Async(request, callSettings);
        }

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public override gax::PagedEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetails(ListLiveAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLiveAdTagDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLiveAdTagDetailsRequest, ListLiveAdTagDetailsResponse, LiveAdTagDetail>(_callListLiveAdTagDetails, request, callSettings);
        }

        /// <summary>
        /// Return the list of ad tag details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LiveAdTagDetail"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLiveAdTagDetailsResponse, LiveAdTagDetail> ListLiveAdTagDetailsAsync(ListLiveAdTagDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLiveAdTagDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLiveAdTagDetailsRequest, ListLiveAdTagDetailsResponse, LiveAdTagDetail>(_callListLiveAdTagDetails, request, callSettings);
        }

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LiveAdTagDetail GetLiveAdTagDetail(GetLiveAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLiveAdTagDetailRequest(ref request, ref callSettings);
            return _callGetLiveAdTagDetail.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified ad tag detail for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LiveAdTagDetail> GetLiveAdTagDetailAsync(GetLiveAdTagDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLiveAdTagDetailRequest(ref request, ref callSettings);
            return _callGetLiveAdTagDetail.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Slate CreateSlate(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSlateRequest(ref request, ref callSettings);
            return _callCreateSlate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Slate> CreateSlateAsync(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSlateRequest(ref request, ref callSettings);
            return _callCreateSlate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public override gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSlatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSlatesRequest, ListSlatesResponse, Slate>(_callListSlates, request, callSettings);
        }

        /// <summary>
        /// Lists all slates in the specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSlatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSlatesRequest, ListSlatesResponse, Slate>(_callListSlates, request, callSettings);
        }

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Slate GetSlate(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSlateRequest(ref request, ref callSettings);
            return _callGetSlate.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Slate> GetSlateAsync(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSlateRequest(ref request, ref callSettings);
            return _callGetSlate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Slate UpdateSlate(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSlateRequest(ref request, ref callSettings);
            return _callUpdateSlate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Slate> UpdateSlateAsync(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSlateRequest(ref request, ref callSettings);
            return _callUpdateSlate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSlate(DeleteSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSlateRequest(ref request, ref callSettings);
            _callDeleteSlate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified slate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSlateAsync(DeleteSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSlateRequest(ref request, ref callSettings);
            return _callDeleteSlate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LiveSession CreateLiveSession(CreateLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLiveSessionRequest(ref request, ref callSettings);
            return _callCreateLiveSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LiveSession> CreateLiveSessionAsync(CreateLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLiveSessionRequest(ref request, ref callSettings);
            return _callCreateLiveSession.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LiveSession GetLiveSession(GetLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLiveSessionRequest(ref request, ref callSettings);
            return _callGetLiveSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the details for the specified live session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LiveSession> GetLiveSessionAsync(GetLiveSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLiveSessionRequest(ref request, ref callSettings);
            return _callGetLiveSession.Async(request, callSettings);
        }
    }

    public partial class ListCdnKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVodStitchDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVodAdTagDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLiveAdTagDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSlatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCdnKeysResponse : gaxgrpc::IPageResponse<CdnKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CdnKey> GetEnumerator() => CdnKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVodStitchDetailsResponse : gaxgrpc::IPageResponse<VodStitchDetail>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VodStitchDetail> GetEnumerator() => VodStitchDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVodAdTagDetailsResponse : gaxgrpc::IPageResponse<VodAdTagDetail>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VodAdTagDetail> GetEnumerator() => VodAdTagDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLiveAdTagDetailsResponse : gaxgrpc::IPageResponse<LiveAdTagDetail>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LiveAdTagDetail> GetEnumerator() => LiveAdTagDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSlatesResponse : gaxgrpc::IPageResponse<Slate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Slate> GetEnumerator() => Slates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
