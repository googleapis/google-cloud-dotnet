// Copyright 2019 Google LLC
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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.WebRisk.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="WebRiskServiceV1Beta1Client"/>.
    /// </summary>
    public sealed partial class WebRiskServiceV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="WebRiskServiceV1Beta1Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="WebRiskServiceV1Beta1Settings"/>.
        /// </returns>
        public static WebRiskServiceV1Beta1Settings GetDefault() => new WebRiskServiceV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="WebRiskServiceV1Beta1Settings"/> object with default settings.
        /// </summary>
        public WebRiskServiceV1Beta1Settings() { }

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
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="WebRiskServiceV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="WebRiskServiceV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="WebRiskServiceV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="WebRiskServiceV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="WebRiskServiceV1Beta1Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="WebRiskServiceV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="WebRiskServiceV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="WebRiskServiceV1Beta1Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceV1Beta1Client.ComputeThreatListDiff</c> and <c>WebRiskServiceV1Beta1Client.ComputeThreatListDiffAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WebRiskServiceV1Beta1Client.ComputeThreatListDiff</c> and
        /// <c>WebRiskServiceV1Beta1Client.ComputeThreatListDiffAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ComputeThreatListDiffSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceV1Beta1Client.SearchUris</c> and <c>WebRiskServiceV1Beta1Client.SearchUrisAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WebRiskServiceV1Beta1Client.SearchUris</c> and
        /// <c>WebRiskServiceV1Beta1Client.SearchUrisAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SearchUrisSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebRiskServiceV1Beta1Client.SearchHashes</c> and <c>WebRiskServiceV1Beta1Client.SearchHashesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WebRiskServiceV1Beta1Client.SearchHashes</c> and
        /// <c>WebRiskServiceV1Beta1Client.SearchHashesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SearchHashesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="WebRiskServiceV1Beta1Settings"/> object.</returns>
        public WebRiskServiceV1Beta1Settings Clone() => new WebRiskServiceV1Beta1Settings(this);
    }

    /// <summary>
    /// WebRiskServiceV1Beta1 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class WebRiskServiceV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the WebRiskServiceV1Beta1 service, which is a host of "webrisk.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("webrisk.googleapis.com", 443);

        /// <summary>
        /// The default WebRiskServiceV1Beta1 scopes.
        /// </summary>
        /// <remarks>
        /// The default WebRiskServiceV1Beta1 scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="WebRiskServiceV1Beta1Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.WebRisk.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// WebRiskServiceV1Beta1Client client = await WebRiskServiceV1Beta1Client.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.WebRisk.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     WebRiskServiceV1Beta1Client.DefaultEndpoint.Host, WebRiskServiceV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// WebRiskServiceV1Beta1Client client = WebRiskServiceV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="WebRiskServiceV1Beta1Settings"/>.</param>
        /// <returns>The task representing the created <see cref="WebRiskServiceV1Beta1Client"/>.</returns>
        public static async stt::Task<WebRiskServiceV1Beta1Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, WebRiskServiceV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="WebRiskServiceV1Beta1Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.WebRisk.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// WebRiskServiceV1Beta1Client client = WebRiskServiceV1Beta1Client.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.WebRisk.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     WebRiskServiceV1Beta1Client.DefaultEndpoint.Host, WebRiskServiceV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// WebRiskServiceV1Beta1Client client = WebRiskServiceV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="WebRiskServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="WebRiskServiceV1Beta1Client"/>.</returns>
        public static WebRiskServiceV1Beta1Client Create(gaxgrpc::ServiceEndpoint endpoint = null, WebRiskServiceV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="WebRiskServiceV1Beta1Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="WebRiskServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="WebRiskServiceV1Beta1Client"/>.</returns>
        public static WebRiskServiceV1Beta1Client Create(grpccore::Channel channel, WebRiskServiceV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="WebRiskServiceV1Beta1Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="WebRiskServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="WebRiskServiceV1Beta1Client"/>.</returns>
        public static WebRiskServiceV1Beta1Client Create(grpccore::CallInvoker callInvoker, WebRiskServiceV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client grpcClient = new WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client(callInvoker);
            return new WebRiskServiceV1Beta1ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, WebRiskServiceV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, WebRiskServiceV1Beta1Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, WebRiskServiceV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, WebRiskServiceV1Beta1Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC WebRiskServiceV1Beta1 client.
        /// </summary>
        public virtual WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="threatType">
        /// Required. The ThreatList to update.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// </param>
        /// <param name="constraints">
        /// The constraints associated with this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(
            ThreatType threatType,
            pb::ByteString versionToken,
            ComputeThreatListDiffRequest.Types.Constraints constraints,
            gaxgrpc::CallSettings callSettings = null) => ComputeThreatListDiffAsync(
                new ComputeThreatListDiffRequest
                {
                    ThreatType = threatType,
                    VersionToken = versionToken ?? pb::ByteString.Empty, // Optional
                    Constraints = gax::GaxPreconditions.CheckNotNull(constraints, nameof(constraints)),
                },
                callSettings);

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="threatType">
        /// Required. The ThreatList to update.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// </param>
        /// <param name="constraints">
        /// The constraints associated with this request.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(
            ThreatType threatType,
            pb::ByteString versionToken,
            ComputeThreatListDiffRequest.Types.Constraints constraints,
            st::CancellationToken cancellationToken) => ComputeThreatListDiffAsync(
                threatType,
                versionToken,
                constraints,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="threatType">
        /// Required. The ThreatList to update.
        /// </param>
        /// <param name="versionToken">
        /// The current version token of the client for the requested list (the
        /// client version that was received from the last successful diff).
        /// </param>
        /// <param name="constraints">
        /// The constraints associated with this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ComputeThreatListDiffResponse ComputeThreatListDiff(
            ThreatType threatType,
            pb::ByteString versionToken,
            ComputeThreatListDiffRequest.Types.Constraints constraints,
            gaxgrpc::CallSettings callSettings = null) => ComputeThreatListDiff(
                new ComputeThreatListDiffRequest
                {
                    ThreatType = threatType,
                    VersionToken = versionToken ?? pb::ByteString.Empty, // Optional
                    Constraints = gax::GaxPreconditions.CheckNotNull(constraints, nameof(constraints)),
                },
                callSettings);

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(
            ComputeThreatListDiffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(
            ComputeThreatListDiffRequest request,
            st::CancellationToken cancellationToken) => ComputeThreatListDiffAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ComputeThreatListDiffResponse ComputeThreatListDiff(
            ComputeThreatListDiffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="uri">
        /// The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(
            string uri,
            scg::IEnumerable<ThreatType> threatTypes,
            gaxgrpc::CallSettings callSettings = null) => SearchUrisAsync(
                new SearchUrisRequest
                {
                    Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
                    ThreatTypes = { gax::GaxPreconditions.CheckNotNull(threatTypes, nameof(threatTypes)) },
                },
                callSettings);

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="uri">
        /// The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(
            string uri,
            scg::IEnumerable<ThreatType> threatTypes,
            st::CancellationToken cancellationToken) => SearchUrisAsync(
                uri,
                threatTypes,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="uri">
        /// The URI to be checked for matches.
        /// </param>
        /// <param name="threatTypes">
        /// Required. The ThreatLists to search in.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SearchUrisResponse SearchUris(
            string uri,
            scg::IEnumerable<ThreatType> threatTypes,
            gaxgrpc::CallSettings callSettings = null) => SearchUris(
                new SearchUrisRequest
                {
                    Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
                    ThreatTypes = { gax::GaxPreconditions.CheckNotNull(threatTypes, nameof(threatTypes)) },
                },
                callSettings);

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(
            SearchUrisRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchUrisResponse> SearchUrisAsync(
            SearchUrisRequest request,
            st::CancellationToken cancellationToken) => SearchUrisAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SearchUrisResponse SearchUris(
            SearchUrisRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(
            pb::ByteString hashPrefix,
            scg::IEnumerable<ThreatType> threatTypes,
            gaxgrpc::CallSettings callSettings = null) => SearchHashesAsync(
                new SearchHashesRequest
                {
                    HashPrefix = hashPrefix ?? pb::ByteString.Empty, // Optional
                    ThreatTypes = { threatTypes ?? linq::Enumerable.Empty<ThreatType>() }, // Optional
                },
                callSettings);

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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(
            pb::ByteString hashPrefix,
            scg::IEnumerable<ThreatType> threatTypes,
            st::CancellationToken cancellationToken) => SearchHashesAsync(
                hashPrefix,
                threatTypes,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SearchHashesResponse SearchHashes(
            pb::ByteString hashPrefix,
            scg::IEnumerable<ThreatType> threatTypes,
            gaxgrpc::CallSettings callSettings = null) => SearchHashes(
                new SearchHashesRequest
                {
                    HashPrefix = hashPrefix ?? pb::ByteString.Empty, // Optional
                    ThreatTypes = { threatTypes ?? linq::Enumerable.Empty<ThreatType>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(
            SearchHashesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SearchHashesResponse> SearchHashesAsync(
            SearchHashesRequest request,
            st::CancellationToken cancellationToken) => SearchHashesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SearchHashesResponse SearchHashes(
            SearchHashesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// WebRiskServiceV1Beta1 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class WebRiskServiceV1Beta1ClientImpl : WebRiskServiceV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse> _callComputeThreatListDiff;
        private readonly gaxgrpc::ApiCall<SearchUrisRequest, SearchUrisResponse> _callSearchUris;
        private readonly gaxgrpc::ApiCall<SearchHashesRequest, SearchHashesResponse> _callSearchHashes;

        /// <summary>
        /// Constructs a client wrapper for the WebRiskServiceV1Beta1 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WebRiskServiceV1Beta1Settings"/> used within this client </param>
        public WebRiskServiceV1Beta1ClientImpl(WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client grpcClient, WebRiskServiceV1Beta1Settings settings)
        {
            GrpcClient = grpcClient;
            WebRiskServiceV1Beta1Settings effectiveSettings = settings ?? WebRiskServiceV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callComputeThreatListDiff = clientHelper.BuildApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse>(
                GrpcClient.ComputeThreatListDiffAsync, GrpcClient.ComputeThreatListDiff, effectiveSettings.ComputeThreatListDiffSettings);
            _callSearchUris = clientHelper.BuildApiCall<SearchUrisRequest, SearchUrisResponse>(
                GrpcClient.SearchUrisAsync, GrpcClient.SearchUris, effectiveSettings.SearchUrisSettings);
            _callSearchHashes = clientHelper.BuildApiCall<SearchHashesRequest, SearchHashesResponse>(
                GrpcClient.SearchHashesAsync, GrpcClient.SearchHashes, effectiveSettings.SearchHashesSettings);
            Modify_ApiCall(ref _callComputeThreatListDiff);
            Modify_ComputeThreatListDiffApiCall(ref _callComputeThreatListDiff);
            Modify_ApiCall(ref _callSearchUris);
            Modify_SearchUrisApiCall(ref _callSearchUris);
            Modify_ApiCall(ref _callSearchHashes);
            Modify_SearchHashesApiCall(ref _callSearchHashes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ComputeThreatListDiffApiCall(ref gaxgrpc::ApiCall<ComputeThreatListDiffRequest, ComputeThreatListDiffResponse> call);
        partial void Modify_SearchUrisApiCall(ref gaxgrpc::ApiCall<SearchUrisRequest, SearchUrisResponse> call);
        partial void Modify_SearchHashesApiCall(ref gaxgrpc::ApiCall<SearchHashesRequest, SearchHashesResponse> call);
        partial void OnConstruction(WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client grpcClient, WebRiskServiceV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC WebRiskServiceV1Beta1 client.
        /// </summary>
        public override WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ComputeThreatListDiffRequest(ref ComputeThreatListDiffRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchUrisRequest(ref SearchUrisRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchHashesRequest(ref SearchHashesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(
            ComputeThreatListDiffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeThreatListDiffRequest(ref request, ref callSettings);
            return _callComputeThreatListDiff.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the most recent threat list diffs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ComputeThreatListDiffResponse ComputeThreatListDiff(
            ComputeThreatListDiffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeThreatListDiffRequest(ref request, ref callSettings);
            return _callComputeThreatListDiff.Sync(request, callSettings);
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<SearchUrisResponse> SearchUrisAsync(
            SearchUrisRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchUrisRequest(ref request, ref callSettings);
            return _callSearchUris.Async(request, callSettings);
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override SearchUrisResponse SearchUris(
            SearchUrisRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchUrisRequest(ref request, ref callSettings);
            return _callSearchUris.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<SearchHashesResponse> SearchHashesAsync(
            SearchHashesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchHashesRequest(ref request, ref callSettings);
            return _callSearchHashes.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix.
        /// This is used after a hash prefix is looked up in a threatList
        /// and there is a match. The client side threatList only holds partial hashes
        /// so the client must query this method to determine if there is a full
        /// hash match of a threat.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override SearchHashesResponse SearchHashes(
            SearchHashesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchHashesRequest(ref request, ref callSettings);
            return _callSearchHashes.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
