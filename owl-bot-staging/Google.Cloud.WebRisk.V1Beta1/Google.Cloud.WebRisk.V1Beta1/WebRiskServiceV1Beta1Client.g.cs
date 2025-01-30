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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.WebRisk.V1Beta1
{
    /// <summary>Settings for <see cref="WebRiskServiceV1Beta1Client"/> instances.</summary>
    public sealed partial class WebRiskServiceV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WebRiskServiceV1Beta1Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WebRiskServiceV1Beta1Settings"/>.</returns>
        public static WebRiskServiceV1Beta1Settings GetDefault() => new WebRiskServiceV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="WebRiskServiceV1Beta1Settings"/> object with default settings.
        /// </summary>
        public WebRiskServiceV1Beta1Settings()
        {
        }

        private WebRiskServiceV1Beta1Settings(WebRiskServiceV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ComputeThreatListDiffSettings = existing.ComputeThreatListDiffSettings;
            SearchUrisSettings = existing.SearchUrisSettings;
            SearchHashesSettings = existing.SearchHashesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WebRiskServiceV1Beta1Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceV1Beta1Client.ComputeThreatListDiff</c> and
        /// <c>WebRiskServiceV1Beta1Client.ComputeThreatListDiffAsync</c>.
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
        public gaxgrpc::CallSettings ComputeThreatListDiffSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceV1Beta1Client.SearchUris</c> and <c>WebRiskServiceV1Beta1Client.SearchUrisAsync</c>.
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
        public gaxgrpc::CallSettings SearchUrisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceV1Beta1Client.SearchHashes</c> and <c>WebRiskServiceV1Beta1Client.SearchHashesAsync</c>.
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
        public gaxgrpc::CallSettings SearchHashesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WebRiskServiceV1Beta1Settings"/> object.</returns>
        public WebRiskServiceV1Beta1Settings Clone() => new WebRiskServiceV1Beta1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WebRiskServiceV1Beta1Client"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class WebRiskServiceV1Beta1ClientBuilder : gaxgrpc::ClientBuilderBase<WebRiskServiceV1Beta1Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WebRiskServiceV1Beta1Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WebRiskServiceV1Beta1ClientBuilder() : base(WebRiskServiceV1Beta1Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WebRiskServiceV1Beta1Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WebRiskServiceV1Beta1Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override WebRiskServiceV1Beta1Client Build()
        {
            WebRiskServiceV1Beta1Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WebRiskServiceV1Beta1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WebRiskServiceV1Beta1Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WebRiskServiceV1Beta1Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WebRiskServiceV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WebRiskServiceV1Beta1Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WebRiskServiceV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WebRiskServiceV1Beta1Client.ChannelPool;
    }

    /// <summary>WebRiskServiceV1Beta1 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Web Risk v1beta1 API defines an interface to detect malicious URLs on your
    /// website and in client applications.
    /// </remarks>
    public abstract partial class WebRiskServiceV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the WebRiskServiceV1Beta1 service, which is a host of "webrisk.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "webrisk.googleapis.com:443";

        /// <summary>The default WebRiskServiceV1Beta1 scopes.</summary>
        /// <remarks>
        /// The default WebRiskServiceV1Beta1 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WebRiskServiceV1Beta1.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WebRiskServiceV1Beta1Client"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WebRiskServiceV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WebRiskServiceV1Beta1Client"/>.</returns>
        public static stt::Task<WebRiskServiceV1Beta1Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WebRiskServiceV1Beta1ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WebRiskServiceV1Beta1Client"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WebRiskServiceV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WebRiskServiceV1Beta1Client"/>.</returns>
        public static WebRiskServiceV1Beta1Client Create() => new WebRiskServiceV1Beta1ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WebRiskServiceV1Beta1Client"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WebRiskServiceV1Beta1Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WebRiskServiceV1Beta1Client"/>.</returns>
        internal static WebRiskServiceV1Beta1Client Create(grpccore::CallInvoker callInvoker, WebRiskServiceV1Beta1Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client grpcClient = new WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client(callInvoker);
            return new WebRiskServiceV1Beta1ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WebRiskServiceV1Beta1 client</summary>
        public virtual WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeThreatListDiffResponse ComputeThreatListDiff(ComputeThreatListDiffRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(ComputeThreatListDiffRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(ComputeThreatListDiffRequest request, st::CancellationToken cancellationToken) =>
            ComputeThreatListDiffAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="threatType">
        /// The ThreatList to update.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// </param>
        /// <param name="constraints">
        /// Required. The constraints associated with this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeThreatListDiffResponse ComputeThreatListDiff(ThreatType threatType, proto::ByteString versionToken, ComputeThreatListDiffRequest.Types.Constraints constraints, gaxgrpc::CallSettings callSettings = null) =>
            ComputeThreatListDiff(new ComputeThreatListDiffRequest
            {
                ThreatType = threatType,
                VersionToken = versionToken ?? proto::ByteString.Empty,
                Constraints = gax::GaxPreconditions.CheckNotNull(constraints, nameof(constraints)),
            }, callSettings);

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="threatType">
        /// The ThreatList to update.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// </param>
        /// <param name="constraints">
        /// Required. The constraints associated with this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(ThreatType threatType, proto::ByteString versionToken, ComputeThreatListDiffRequest.Types.Constraints constraints, gaxgrpc::CallSettings callSettings = null) =>
            ComputeThreatListDiffAsync(new ComputeThreatListDiffRequest
            {
                ThreatType = threatType,
                VersionToken = versionToken ?? proto::ByteString.Empty,
                Constraints = gax::GaxPreconditions.CheckNotNull(constraints, nameof(constraints)),
            }, callSettings);

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="threatType">
        /// The ThreatList to update.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// </param>
        /// <param name="constraints">
        /// Required. The constraints associated with this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(ThreatType threatType, proto::ByteString versionToken, ComputeThreatListDiffRequest.Types.Constraints constraints, st::CancellationToken cancellationToken) =>
            ComputeThreatListDiffAsync(threatType, versionToken, constraints, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchUrisResponse SearchUris(SearchUrisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(SearchUrisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(SearchUrisRequest request, st::CancellationToken cancellationToken) =>
            SearchUrisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="uri">
        /// Required. The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchUrisResponse SearchUris(string uri, scg::IEnumerable<ThreatType> threatTypes, gaxgrpc::CallSettings callSettings = null) =>
            SearchUris(new SearchUrisRequest
            {
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
                ThreatTypes =
                {
                    gax::GaxPreconditions.CheckNotNull(threatTypes, nameof(threatTypes)),
                },
            }, callSettings);

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="uri">
        /// Required. The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(string uri, scg::IEnumerable<ThreatType> threatTypes, gaxgrpc::CallSettings callSettings = null) =>
            SearchUrisAsync(new SearchUrisRequest
            {
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
                ThreatTypes =
                {
                    gax::GaxPreconditions.CheckNotNull(threatTypes, nameof(threatTypes)),
                },
            }, callSettings);

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="uri">
        /// Required. The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(string uri, scg::IEnumerable<ThreatType> threatTypes, st::CancellationToken cancellationToken) =>
            SearchUrisAsync(uri, threatTypes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHashesResponse SearchHashes(SearchHashesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(SearchHashesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(SearchHashesRequest request, st::CancellationToken cancellationToken) =>
            SearchHashesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="hashPrefix">
        /// A hash prefix, consisting of the most significant 4-32 bytes of a SHA256
        /// hash. For JSON requests, this field is base64-encoded.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchHashesResponse SearchHashes(proto::ByteString hashPrefix, scg::IEnumerable<ThreatType> threatTypes, gaxgrpc::CallSettings callSettings = null) =>
            SearchHashes(new SearchHashesRequest
            {
                HashPrefix = hashPrefix ?? proto::ByteString.Empty,
                ThreatTypes =
                {
                    gax::GaxPreconditions.CheckNotNull(threatTypes, nameof(threatTypes)),
                },
            }, callSettings);

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="hashPrefix">
        /// A hash prefix, consisting of the most significant 4-32 bytes of a SHA256
        /// hash. For JSON requests, this field is base64-encoded.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(proto::ByteString hashPrefix, scg::IEnumerable<ThreatType> threatTypes, gaxgrpc::CallSettings callSettings = null) =>
            SearchHashesAsync(new SearchHashesRequest
            {
                HashPrefix = hashPrefix ?? proto::ByteString.Empty,
                ThreatTypes =
                {
                    gax::GaxPreconditions.CheckNotNull(threatTypes, nameof(threatTypes)),
                },
            }, callSettings);

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="hashPrefix">
        /// A hash prefix, consisting of the most significant 4-32 bytes of a SHA256
        /// hash. For JSON requests, this field is base64-encoded.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(proto::ByteString hashPrefix, scg::IEnumerable<ThreatType> threatTypes, st::CancellationToken cancellationToken) =>
            SearchHashesAsync(hashPrefix, threatTypes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WebRiskServiceV1Beta1 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Web Risk v1beta1 API defines an interface to detect malicious URLs on your
    /// website and in client applications.
    /// </remarks>
    public sealed partial class WebRiskServiceV1Beta1ClientImpl : WebRiskServiceV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse> _callComputeThreatListDiff;

        private readonly gaxgrpc::ApiCall<SearchUrisRequest, SearchUrisResponse> _callSearchUris;

        private readonly gaxgrpc::ApiCall<SearchHashesRequest, SearchHashesResponse> _callSearchHashes;

        /// <summary>
        /// Constructs a client wrapper for the WebRiskServiceV1Beta1 service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WebRiskServiceV1Beta1Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WebRiskServiceV1Beta1ClientImpl(WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client grpcClient, WebRiskServiceV1Beta1Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WebRiskServiceV1Beta1Settings effectiveSettings = settings ?? WebRiskServiceV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callComputeThreatListDiff = clientHelper.BuildApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse>("ComputeThreatListDiff", grpcClient.ComputeThreatListDiffAsync, grpcClient.ComputeThreatListDiff, effectiveSettings.ComputeThreatListDiffSettings);
            Modify_ApiCall(ref _callComputeThreatListDiff);
            Modify_ComputeThreatListDiffApiCall(ref _callComputeThreatListDiff);
            _callSearchUris = clientHelper.BuildApiCall<SearchUrisRequest, SearchUrisResponse>("SearchUris", grpcClient.SearchUrisAsync, grpcClient.SearchUris, effectiveSettings.SearchUrisSettings);
            Modify_ApiCall(ref _callSearchUris);
            Modify_SearchUrisApiCall(ref _callSearchUris);
            _callSearchHashes = clientHelper.BuildApiCall<SearchHashesRequest, SearchHashesResponse>("SearchHashes", grpcClient.SearchHashesAsync, grpcClient.SearchHashes, effectiveSettings.SearchHashesSettings);
            Modify_ApiCall(ref _callSearchHashes);
            Modify_SearchHashesApiCall(ref _callSearchHashes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ComputeThreatListDiffApiCall(ref gaxgrpc::ApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse> call);

        partial void Modify_SearchUrisApiCall(ref gaxgrpc::ApiCall<SearchUrisRequest, SearchUrisResponse> call);

        partial void Modify_SearchHashesApiCall(ref gaxgrpc::ApiCall<SearchHashesRequest, SearchHashesResponse> call);

        partial void OnConstruction(WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client grpcClient, WebRiskServiceV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WebRiskServiceV1Beta1 client</summary>
        public override WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client GrpcClient { get; }

        partial void Modify_ComputeThreatListDiffRequest(ref ComputeThreatListDiffRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchUrisRequest(ref SearchUrisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchHashesRequest(ref SearchHashesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeThreatListDiffResponse ComputeThreatListDiff(ComputeThreatListDiffRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeThreatListDiffRequest(ref request, ref callSettings);
            return _callComputeThreatListDiff.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(ComputeThreatListDiffRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeThreatListDiffRequest(ref request, ref callSettings);
            return _callComputeThreatListDiff.Async(request, callSettings);
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchUrisResponse SearchUris(SearchUrisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchUrisRequest(ref request, ref callSettings);
            return _callSearchUris.Sync(request, callSettings);
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchUrisResponse> SearchUrisAsync(SearchUrisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchUrisRequest(ref request, ref callSettings);
            return _callSearchUris.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchHashesResponse SearchHashes(SearchHashesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchHashesRequest(ref request, ref callSettings);
            return _callSearchHashes.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchHashesResponse> SearchHashesAsync(SearchHashesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchHashesRequest(ref request, ref callSettings);
            return _callSearchHashes.Async(request, callSettings);
        }
    }
}
