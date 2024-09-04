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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="LintingServiceClient"/> instances.</summary>
    public sealed partial class LintingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LintingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LintingServiceSettings"/>.</returns>
        public static LintingServiceSettings GetDefault() => new LintingServiceSettings();

        /// <summary>Constructs a new <see cref="LintingServiceSettings"/> object with default settings.</summary>
        public LintingServiceSettings()
        {
        }

        private LintingServiceSettings(LintingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetStyleGuideSettings = existing.GetStyleGuideSettings;
            UpdateStyleGuideSettings = existing.UpdateStyleGuideSettings;
            GetStyleGuideContentsSettings = existing.GetStyleGuideContentsSettings;
            LintSpecSettings = existing.LintSpecSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LintingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LintingServiceClient.GetStyleGuide</c> and <c>LintingServiceClient.GetStyleGuideAsync</c>.
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
        public gaxgrpc::CallSettings GetStyleGuideSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LintingServiceClient.UpdateStyleGuide</c> and <c>LintingServiceClient.UpdateStyleGuideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateStyleGuideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LintingServiceClient.GetStyleGuideContents</c> and <c>LintingServiceClient.GetStyleGuideContentsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetStyleGuideContentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LintingServiceClient.LintSpec</c> and <c>LintingServiceClient.LintSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LintSpecSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LintingServiceSettings"/> object.</returns>
        public LintingServiceSettings Clone() => new LintingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LintingServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LintingServiceClientBuilder : gaxgrpc::ClientBuilderBase<LintingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LintingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LintingServiceClientBuilder() : base(LintingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LintingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LintingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LintingServiceClient Build()
        {
            LintingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LintingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LintingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LintingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LintingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LintingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LintingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LintingServiceClient.ChannelPool;
    }

    /// <summary>LintingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service provides all methods related to the 1p Linter.
    /// </remarks>
    public abstract partial class LintingServiceClient
    {
        /// <summary>
        /// The default endpoint for the LintingService service, which is a host of "apihub.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default LintingService scopes.</summary>
        /// <remarks>
        /// The default LintingService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LintingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LintingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LintingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LintingServiceClient"/>.</returns>
        public static stt::Task<LintingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LintingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LintingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LintingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LintingServiceClient"/>.</returns>
        public static LintingServiceClient Create() => new LintingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LintingServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LintingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LintingServiceClient"/>.</returns>
        internal static LintingServiceClient Create(grpccore::CallInvoker callInvoker, LintingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LintingService.LintingServiceClient grpcClient = new LintingService.LintingServiceClient(callInvoker);
            return new LintingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LintingService client</summary>
        public virtual LintingService.LintingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuide GetStyleGuide(GetStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> GetStyleGuideAsync(GetStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> GetStyleGuideAsync(GetStyleGuideRequest request, st::CancellationToken cancellationToken) =>
            GetStyleGuideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuide GetStyleGuide(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuide(new GetStyleGuideRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> GetStyleGuideAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuideAsync(new GetStyleGuideRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> GetStyleGuideAsync(string name, st::CancellationToken cancellationToken) =>
            GetStyleGuideAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuide GetStyleGuide(StyleGuideName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuide(new GetStyleGuideRequest
            {
                StyleGuideName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> GetStyleGuideAsync(StyleGuideName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuideAsync(new GetStyleGuideRequest
            {
                StyleGuideName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> GetStyleGuideAsync(StyleGuideName name, st::CancellationToken cancellationToken) =>
            GetStyleGuideAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuide UpdateStyleGuide(UpdateStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> UpdateStyleGuideAsync(UpdateStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> UpdateStyleGuideAsync(UpdateStyleGuideRequest request, st::CancellationToken cancellationToken) =>
            UpdateStyleGuideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="styleGuide">
        /// Required. The Style guide resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuide UpdateStyleGuide(StyleGuide styleGuide, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStyleGuide(new UpdateStyleGuideRequest
            {
                StyleGuide = gax::GaxPreconditions.CheckNotNull(styleGuide, nameof(styleGuide)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="styleGuide">
        /// Required. The Style guide resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> UpdateStyleGuideAsync(StyleGuide styleGuide, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStyleGuideAsync(new UpdateStyleGuideRequest
            {
                StyleGuide = gax::GaxPreconditions.CheckNotNull(styleGuide, nameof(styleGuide)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="styleGuide">
        /// Required. The Style guide resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuide> UpdateStyleGuideAsync(StyleGuide styleGuide, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateStyleGuideAsync(styleGuide, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuideContents GetStyleGuideContents(GetStyleGuideContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuideContents> GetStyleGuideContentsAsync(GetStyleGuideContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuideContents> GetStyleGuideContentsAsync(GetStyleGuideContentsRequest request, st::CancellationToken cancellationToken) =>
            GetStyleGuideContentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StyleGuide whose contents need to be retrieved.
        /// There is exactly one style guide resource per project per location.
        /// The expected format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuideContents GetStyleGuideContents(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuideContents(new GetStyleGuideContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StyleGuide whose contents need to be retrieved.
        /// There is exactly one style guide resource per project per location.
        /// The expected format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuideContents> GetStyleGuideContentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuideContentsAsync(new GetStyleGuideContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StyleGuide whose contents need to be retrieved.
        /// There is exactly one style guide resource per project per location.
        /// The expected format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuideContents> GetStyleGuideContentsAsync(string name, st::CancellationToken cancellationToken) =>
            GetStyleGuideContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StyleGuide whose contents need to be retrieved.
        /// There is exactly one style guide resource per project per location.
        /// The expected format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleGuideContents GetStyleGuideContents(StyleGuideName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuideContents(new GetStyleGuideContentsRequest
            {
                StyleGuideName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StyleGuide whose contents need to be retrieved.
        /// There is exactly one style guide resource per project per location.
        /// The expected format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuideContents> GetStyleGuideContentsAsync(StyleGuideName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleGuideContentsAsync(new GetStyleGuideContentsRequest
            {
                StyleGuideName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StyleGuide whose contents need to be retrieved.
        /// There is exactly one style guide resource per project per location.
        /// The expected format is
        /// `projects/{project}/locations/{location}/plugins/{plugin}/styleGuide`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleGuideContents> GetStyleGuideContentsAsync(StyleGuideName name, st::CancellationToken cancellationToken) =>
            GetStyleGuideContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lints the requested spec and updates the corresponding API Spec with the
        /// lint response. This lint response will be available in all subsequent
        /// Get and List Spec calls to Core service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void LintSpec(LintSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lints the requested spec and updates the corresponding API Spec with the
        /// lint response. This lint response will be available in all subsequent
        /// Get and List Spec calls to Core service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task LintSpecAsync(LintSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lints the requested spec and updates the corresponding API Spec with the
        /// lint response. This lint response will be available in all subsequent
        /// Get and List Spec calls to Core service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task LintSpecAsync(LintSpecRequest request, st::CancellationToken cancellationToken) =>
            LintSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LintingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service provides all methods related to the 1p Linter.
    /// </remarks>
    public sealed partial class LintingServiceClientImpl : LintingServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetStyleGuideRequest, StyleGuide> _callGetStyleGuide;

        private readonly gaxgrpc::ApiCall<UpdateStyleGuideRequest, StyleGuide> _callUpdateStyleGuide;

        private readonly gaxgrpc::ApiCall<GetStyleGuideContentsRequest, StyleGuideContents> _callGetStyleGuideContents;

        private readonly gaxgrpc::ApiCall<LintSpecRequest, wkt::Empty> _callLintSpec;

        /// <summary>
        /// Constructs a client wrapper for the LintingService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LintingServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LintingServiceClientImpl(LintingService.LintingServiceClient grpcClient, LintingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LintingServiceSettings effectiveSettings = settings ?? LintingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetStyleGuide = clientHelper.BuildApiCall<GetStyleGuideRequest, StyleGuide>("GetStyleGuide", grpcClient.GetStyleGuideAsync, grpcClient.GetStyleGuide, effectiveSettings.GetStyleGuideSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStyleGuide);
            Modify_GetStyleGuideApiCall(ref _callGetStyleGuide);
            _callUpdateStyleGuide = clientHelper.BuildApiCall<UpdateStyleGuideRequest, StyleGuide>("UpdateStyleGuide", grpcClient.UpdateStyleGuideAsync, grpcClient.UpdateStyleGuide, effectiveSettings.UpdateStyleGuideSettings).WithGoogleRequestParam("style_guide.name", request => request.StyleGuide?.Name);
            Modify_ApiCall(ref _callUpdateStyleGuide);
            Modify_UpdateStyleGuideApiCall(ref _callUpdateStyleGuide);
            _callGetStyleGuideContents = clientHelper.BuildApiCall<GetStyleGuideContentsRequest, StyleGuideContents>("GetStyleGuideContents", grpcClient.GetStyleGuideContentsAsync, grpcClient.GetStyleGuideContents, effectiveSettings.GetStyleGuideContentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStyleGuideContents);
            Modify_GetStyleGuideContentsApiCall(ref _callGetStyleGuideContents);
            _callLintSpec = clientHelper.BuildApiCall<LintSpecRequest, wkt::Empty>("LintSpec", grpcClient.LintSpecAsync, grpcClient.LintSpec, effectiveSettings.LintSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLintSpec);
            Modify_LintSpecApiCall(ref _callLintSpec);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetStyleGuideApiCall(ref gaxgrpc::ApiCall<GetStyleGuideRequest, StyleGuide> call);

        partial void Modify_UpdateStyleGuideApiCall(ref gaxgrpc::ApiCall<UpdateStyleGuideRequest, StyleGuide> call);

        partial void Modify_GetStyleGuideContentsApiCall(ref gaxgrpc::ApiCall<GetStyleGuideContentsRequest, StyleGuideContents> call);

        partial void Modify_LintSpecApiCall(ref gaxgrpc::ApiCall<LintSpecRequest, wkt::Empty> call);

        partial void OnConstruction(LintingService.LintingServiceClient grpcClient, LintingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LintingService client</summary>
        public override LintingService.LintingServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetStyleGuideRequest(ref GetStyleGuideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateStyleGuideRequest(ref UpdateStyleGuideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStyleGuideContentsRequest(ref GetStyleGuideContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LintSpecRequest(ref LintSpecRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StyleGuide GetStyleGuide(GetStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStyleGuideRequest(ref request, ref callSettings);
            return _callGetStyleGuide.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the style guide being used for linting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StyleGuide> GetStyleGuideAsync(GetStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStyleGuideRequest(ref request, ref callSettings);
            return _callGetStyleGuide.Async(request, callSettings);
        }

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StyleGuide UpdateStyleGuide(UpdateStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStyleGuideRequest(ref request, ref callSettings);
            return _callUpdateStyleGuide.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the styleGuide to be used for liniting in by API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StyleGuide> UpdateStyleGuideAsync(UpdateStyleGuideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStyleGuideRequest(ref request, ref callSettings);
            return _callUpdateStyleGuide.Async(request, callSettings);
        }

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StyleGuideContents GetStyleGuideContents(GetStyleGuideContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStyleGuideContentsRequest(ref request, ref callSettings);
            return _callGetStyleGuideContents.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the contents of the style guide.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StyleGuideContents> GetStyleGuideContentsAsync(GetStyleGuideContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStyleGuideContentsRequest(ref request, ref callSettings);
            return _callGetStyleGuideContents.Async(request, callSettings);
        }

        /// <summary>
        /// Lints the requested spec and updates the corresponding API Spec with the
        /// lint response. This lint response will be available in all subsequent
        /// Get and List Spec calls to Core service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void LintSpec(LintSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LintSpecRequest(ref request, ref callSettings);
            _callLintSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Lints the requested spec and updates the corresponding API Spec with the
        /// lint response. This lint response will be available in all subsequent
        /// Get and List Spec calls to Core service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task LintSpecAsync(LintSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LintSpecRequest(ref request, ref callSettings);
            return _callLintSpec.Async(request, callSettings);
        }
    }

    public static partial class LintingService
    {
        public partial class LintingServiceClient
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
