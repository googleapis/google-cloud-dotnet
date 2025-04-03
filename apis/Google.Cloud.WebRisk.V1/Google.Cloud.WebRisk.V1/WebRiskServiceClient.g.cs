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

namespace Google.Cloud.WebRisk.V1
{
    /// <summary>Settings for <see cref="WebRiskServiceClient"/> instances.</summary>
    public sealed partial class WebRiskServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WebRiskServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WebRiskServiceSettings"/>.</returns>
        public static WebRiskServiceSettings GetDefault() => new WebRiskServiceSettings();

        /// <summary>Constructs a new <see cref="WebRiskServiceSettings"/> object with default settings.</summary>
        public WebRiskServiceSettings()
        {
        }

        private WebRiskServiceSettings(WebRiskServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ComputeThreatListDiffSettings = existing.ComputeThreatListDiffSettings;
            SearchUrisSettings = existing.SearchUrisSettings;
            SearchHashesSettings = existing.SearchHashesSettings;
            CreateSubmissionSettings = existing.CreateSubmissionSettings;
            SubmitUriSettings = existing.SubmitUriSettings;
            SubmitUriOperationsSettings = existing.SubmitUriOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(WebRiskServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceClient.ComputeThreatListDiff</c> and <c>WebRiskServiceClient.ComputeThreatListDiffAsync</c>
        /// .
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
        /// <c>WebRiskServiceClient.SearchUris</c> and <c>WebRiskServiceClient.SearchUrisAsync</c>.
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
        /// <c>WebRiskServiceClient.SearchHashes</c> and <c>WebRiskServiceClient.SearchHashesAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceClient.CreateSubmission</c> and <c>WebRiskServiceClient.CreateSubmissionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSubmissionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceClient.SubmitUri</c> and <c>WebRiskServiceClient.SubmitUriAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubmitUriSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>WebRiskServiceClient.SubmitUri</c> and
        /// <c>WebRiskServiceClient.SubmitUriAsync</c>.
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
        public lro::OperationsSettings SubmitUriOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WebRiskServiceSettings"/> object.</returns>
        public WebRiskServiceSettings Clone() => new WebRiskServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WebRiskServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class WebRiskServiceClientBuilder : gaxgrpc::ClientBuilderBase<WebRiskServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WebRiskServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WebRiskServiceClientBuilder() : base(WebRiskServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WebRiskServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WebRiskServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WebRiskServiceClient Build()
        {
            WebRiskServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WebRiskServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WebRiskServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WebRiskServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WebRiskServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WebRiskServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WebRiskServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WebRiskServiceClient.ChannelPool;
    }

    /// <summary>WebRiskService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Web Risk API defines an interface to detect malicious URLs on your
    /// website and in client applications.
    /// </remarks>
    public abstract partial class WebRiskServiceClient
    {
        /// <summary>
        /// The default endpoint for the WebRiskService service, which is a host of "webrisk.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "webrisk.googleapis.com:443";

        /// <summary>The default WebRiskService scopes.</summary>
        /// <remarks>
        /// The default WebRiskService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WebRiskService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WebRiskServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WebRiskServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WebRiskServiceClient"/>.</returns>
        public static stt::Task<WebRiskServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WebRiskServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WebRiskServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WebRiskServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WebRiskServiceClient"/>.</returns>
        public static WebRiskServiceClient Create() => new WebRiskServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WebRiskServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WebRiskServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WebRiskServiceClient"/>.</returns>
        internal static WebRiskServiceClient Create(grpccore::CallInvoker callInvoker, WebRiskServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WebRiskService.WebRiskServiceClient grpcClient = new WebRiskService.WebRiskServiceClient(callInvoker);
            return new WebRiskServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WebRiskService client</summary>
        public virtual WebRiskService.WebRiskServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeThreatListDiffResponse ComputeThreatListDiff(ComputeThreatListDiffRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(ComputeThreatListDiffRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(ComputeThreatListDiffRequest request, st::CancellationToken cancellationToken) =>
            ComputeThreatListDiffAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
        /// </summary>
        /// <param name="threatType">
        /// Required. The threat list to update. Only a single ThreatType should be
        /// specified per request. If you want to handle multiple ThreatTypes, you must
        /// make one request per ThreatType.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// If the client does not have a version token (this is the first time calling
        /// ComputeThreatListDiff), this may be left empty and a full database
        /// snapshot will be returned.
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
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
        /// </summary>
        /// <param name="threatType">
        /// Required. The threat list to update. Only a single ThreatType should be
        /// specified per request. If you want to handle multiple ThreatTypes, you must
        /// make one request per ThreatType.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// If the client does not have a version token (this is the first time calling
        /// ComputeThreatListDiff), this may be left empty and a full database
        /// snapshot will be returned.
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
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
        /// </summary>
        /// <param name="threatType">
        /// Required. The threat list to update. Only a single ThreatType should be
        /// specified per request. If you want to handle multiple ThreatTypes, you must
        /// make one request per ThreatType.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// If the client does not have a version token (this is the first time calling
        /// ComputeThreatListDiff), this may be left empty and a full database
        /// snapshot will be returned.
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
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchUrisResponse SearchUris(SearchUrisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(SearchUrisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(SearchUrisRequest request, st::CancellationToken cancellationToken) =>
            SearchUrisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
        /// </summary>
        /// <param name="uri">
        /// Required. The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in. Multiple ThreatLists may be
        /// specified.
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
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
        /// </summary>
        /// <param name="uri">
        /// Required. The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in. Multiple ThreatLists may be
        /// specified.
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
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
        /// </summary>
        /// <param name="uri">
        /// Required. The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in. Multiple ThreatLists may be
        /// specified.
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
        /// Note that if this parameter is provided by a URI, it must be encoded using
        /// the web safe base64 variant (RFC 4648).
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in. Multiple ThreatLists may be
        /// specified.
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
        /// Note that if this parameter is provided by a URI, it must be encoded using
        /// the web safe base64 variant (RFC 4648).
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in. Multiple ThreatLists may be
        /// specified.
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
        /// Note that if this parameter is provided by a URI, it must be encoded using
        /// the web safe base64 variant (RFC 4648).
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in. Multiple ThreatLists may be
        /// specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(proto::ByteString hashPrefix, scg::IEnumerable<ThreatType> threatTypes, st::CancellationToken cancellationToken) =>
            SearchHashesAsync(hashPrefix, threatTypes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Submission CreateSubmission(CreateSubmissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Submission> CreateSubmissionAsync(CreateSubmissionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Submission> CreateSubmissionAsync(CreateSubmissionRequest request, st::CancellationToken cancellationToken) =>
            CreateSubmissionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the content of the phishing report.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Submission CreateSubmission(string parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubmission(new CreateSubmissionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the content of the phishing report.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Submission> CreateSubmissionAsync(string parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubmissionAsync(new CreateSubmissionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the content of the phishing report.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Submission> CreateSubmissionAsync(string parent, Submission submission, st::CancellationToken cancellationToken) =>
            CreateSubmissionAsync(parent, submission, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the content of the phishing report.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Submission CreateSubmission(gagr::ProjectName parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubmission(new CreateSubmissionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the content of the phishing report.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Submission> CreateSubmissionAsync(gagr::ProjectName parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubmissionAsync(new CreateSubmissionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the content of the phishing report.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Submission> CreateSubmissionAsync(gagr::ProjectName parent, Submission submission, st::CancellationToken cancellationToken) =>
            CreateSubmissionAsync(parent, submission, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Submission, SubmitUriMetadata> SubmitUri(SubmitUriRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Submission, SubmitUriMetadata>> SubmitUriAsync(SubmitUriRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Submission, SubmitUriMetadata>> SubmitUriAsync(SubmitUriRequest request, st::CancellationToken cancellationToken) =>
            SubmitUriAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SubmitUri</c>.</summary>
        public virtual lro::OperationsClient SubmitUriOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SubmitUri</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Submission, SubmitUriMetadata> PollOnceSubmitUri(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Submission, SubmitUriMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubmitUriOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SubmitUri</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Submission, SubmitUriMetadata>> PollOnceSubmitUriAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Submission, SubmitUriMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubmitUriOperationsClient, callSettings);

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the URI to be scanned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Submission, SubmitUriMetadata> SubmitUri(string parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            SubmitUri(new SubmitUriRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the URI to be scanned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Submission, SubmitUriMetadata>> SubmitUriAsync(string parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            SubmitUriAsync(new SubmitUriRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the URI to be scanned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Submission, SubmitUriMetadata>> SubmitUriAsync(string parent, Submission submission, st::CancellationToken cancellationToken) =>
            SubmitUriAsync(parent, submission, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the URI to be scanned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Submission, SubmitUriMetadata> SubmitUri(gagr::ProjectName parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            SubmitUri(new SubmitUriRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the URI to be scanned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Submission, SubmitUriMetadata>> SubmitUriAsync(gagr::ProjectName parent, Submission submission, gaxgrpc::CallSettings callSettings = null) =>
            SubmitUriAsync(new SubmitUriRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Submission = gax::GaxPreconditions.CheckNotNull(submission, nameof(submission)),
            }, callSettings);

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project that is making the submission. This
        /// string is in the format "projects/{project_number}".
        /// </param>
        /// <param name="submission">
        /// Required. The submission that contains the URI to be scanned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Submission, SubmitUriMetadata>> SubmitUriAsync(gagr::ProjectName parent, Submission submission, st::CancellationToken cancellationToken) =>
            SubmitUriAsync(parent, submission, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WebRiskService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Web Risk API defines an interface to detect malicious URLs on your
    /// website and in client applications.
    /// </remarks>
    public sealed partial class WebRiskServiceClientImpl : WebRiskServiceClient
    {
        private readonly gaxgrpc::ApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse> _callComputeThreatListDiff;

        private readonly gaxgrpc::ApiCall<SearchUrisRequest, SearchUrisResponse> _callSearchUris;

        private readonly gaxgrpc::ApiCall<SearchHashesRequest, SearchHashesResponse> _callSearchHashes;

        private readonly gaxgrpc::ApiCall<CreateSubmissionRequest, Submission> _callCreateSubmission;

        private readonly gaxgrpc::ApiCall<SubmitUriRequest, lro::Operation> _callSubmitUri;

        /// <summary>
        /// Constructs a client wrapper for the WebRiskService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WebRiskServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WebRiskServiceClientImpl(WebRiskService.WebRiskServiceClient grpcClient, WebRiskServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WebRiskServiceSettings effectiveSettings = settings ?? WebRiskServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SubmitUriOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SubmitUriOperationsSettings, logger);
            _callComputeThreatListDiff = clientHelper.BuildApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse>("ComputeThreatListDiff", grpcClient.ComputeThreatListDiffAsync, grpcClient.ComputeThreatListDiff, effectiveSettings.ComputeThreatListDiffSettings);
            Modify_ApiCall(ref _callComputeThreatListDiff);
            Modify_ComputeThreatListDiffApiCall(ref _callComputeThreatListDiff);
            _callSearchUris = clientHelper.BuildApiCall<SearchUrisRequest, SearchUrisResponse>("SearchUris", grpcClient.SearchUrisAsync, grpcClient.SearchUris, effectiveSettings.SearchUrisSettings);
            Modify_ApiCall(ref _callSearchUris);
            Modify_SearchUrisApiCall(ref _callSearchUris);
            _callSearchHashes = clientHelper.BuildApiCall<SearchHashesRequest, SearchHashesResponse>("SearchHashes", grpcClient.SearchHashesAsync, grpcClient.SearchHashes, effectiveSettings.SearchHashesSettings);
            Modify_ApiCall(ref _callSearchHashes);
            Modify_SearchHashesApiCall(ref _callSearchHashes);
            _callCreateSubmission = clientHelper.BuildApiCall<CreateSubmissionRequest, Submission>("CreateSubmission", grpcClient.CreateSubmissionAsync, grpcClient.CreateSubmission, effectiveSettings.CreateSubmissionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSubmission);
            Modify_CreateSubmissionApiCall(ref _callCreateSubmission);
            _callSubmitUri = clientHelper.BuildApiCall<SubmitUriRequest, lro::Operation>("SubmitUri", grpcClient.SubmitUriAsync, grpcClient.SubmitUri, effectiveSettings.SubmitUriSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSubmitUri);
            Modify_SubmitUriApiCall(ref _callSubmitUri);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ComputeThreatListDiffApiCall(ref gaxgrpc::ApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse> call);

        partial void Modify_SearchUrisApiCall(ref gaxgrpc::ApiCall<SearchUrisRequest, SearchUrisResponse> call);

        partial void Modify_SearchHashesApiCall(ref gaxgrpc::ApiCall<SearchHashesRequest, SearchHashesResponse> call);

        partial void Modify_CreateSubmissionApiCall(ref gaxgrpc::ApiCall<CreateSubmissionRequest, Submission> call);

        partial void Modify_SubmitUriApiCall(ref gaxgrpc::ApiCall<SubmitUriRequest, lro::Operation> call);

        partial void OnConstruction(WebRiskService.WebRiskServiceClient grpcClient, WebRiskServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WebRiskService client</summary>
        public override WebRiskService.WebRiskServiceClient GrpcClient { get; }

        partial void Modify_ComputeThreatListDiffRequest(ref ComputeThreatListDiffRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchUrisRequest(ref SearchUrisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchHashesRequest(ref SearchHashesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSubmissionRequest(ref CreateSubmissionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SubmitUriRequest(ref SubmitUriRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
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
        /// Gets the most recent threat list diffs. These diffs should be applied to
        /// a local database of hashes to keep it up-to-date. If the local database is
        /// empty or excessively out-of-date, a complete snapshot of the database will
        /// be returned. This Method only updates a single ThreatList at a time. To
        /// update multiple ThreatList databases, this method needs to be called once
        /// for each list.
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
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
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
        /// Multiple threatLists may be searched in a single query.
        /// The response will list all requested threatLists the URI was found to
        /// match. If the URI is not found on any of the requested ThreatList an
        /// empty response will be returned.
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

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Submission CreateSubmission(CreateSubmissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubmissionRequest(ref request, ref callSettings);
            return _callCreateSubmission.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Submission of a URI suspected of containing phishing content to
        /// be reviewed. If the result verifies the existence of malicious phishing
        /// content, the site will be added to the [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Submission> CreateSubmissionAsync(CreateSubmissionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubmissionRequest(ref request, ref callSettings);
            return _callCreateSubmission.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SubmitUri</c>.</summary>
        public override lro::OperationsClient SubmitUriOperationsClient { get; }

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Submission, SubmitUriMetadata> SubmitUri(SubmitUriRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitUriRequest(ref request, ref callSettings);
            return new lro::Operation<Submission, SubmitUriMetadata>(_callSubmitUri.Sync(request, callSettings), SubmitUriOperationsClient);
        }

        /// <summary>
        /// Submits a URI suspected of containing malicious content to be reviewed.
        /// Returns a google.longrunning.Operation which, once the review is complete,
        /// is updated with its result. You can use the [Pub/Sub API]
        /// (https://cloud.google.com/pubsub) to receive notifications for the returned
        /// Operation. If the result verifies the existence of malicious content, the
        /// site will be added to the [Google's Social Engineering lists]
        /// (https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future. Only
        /// allowlisted projects can use this method during Early Access. Please reach
        /// out to Sales or your customer engineer to obtain access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Submission, SubmitUriMetadata>> SubmitUriAsync(SubmitUriRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitUriRequest(ref request, ref callSettings);
            return new lro::Operation<Submission, SubmitUriMetadata>(await _callSubmitUri.Async(request, callSettings).ConfigureAwait(false), SubmitUriOperationsClient);
        }
    }

    public static partial class WebRiskService
    {
        public partial class WebRiskServiceClient
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
