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
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.PhishingProtection.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="PhishingProtectionServiceV1Beta1Client"/>.
    /// </summary>
    public sealed partial class PhishingProtectionServiceV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PhishingProtectionServiceV1Beta1Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="PhishingProtectionServiceV1Beta1Settings"/>.
        /// </returns>
        public static PhishingProtectionServiceV1Beta1Settings GetDefault() => new PhishingProtectionServiceV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="PhishingProtectionServiceV1Beta1Settings"/> object with default settings.
        /// </summary>
        public PhishingProtectionServiceV1Beta1Settings() { }

        private PhishingProtectionServiceV1Beta1Settings(PhishingProtectionServiceV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReportPhishingSettings = existing.ReportPhishingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PhishingProtectionServiceV1Beta1Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="PhishingProtectionServiceV1Beta1Client"/> RPC methods is defined as:
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
        /// <c>PhishingProtectionServiceV1Beta1Client.ReportPhishing</c> and <c>PhishingProtectionServiceV1Beta1Client.ReportPhishingAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PhishingProtectionServiceV1Beta1Client.ReportPhishing</c> and
        /// <c>PhishingProtectionServiceV1Beta1Client.ReportPhishingAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ReportPhishingSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="PhishingProtectionServiceV1Beta1Settings"/> object.</returns>
        public PhishingProtectionServiceV1Beta1Settings Clone() => new PhishingProtectionServiceV1Beta1Settings(this);
    }

    /// <summary>
    /// PhishingProtectionServiceV1Beta1 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class PhishingProtectionServiceV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the PhishingProtectionServiceV1Beta1 service, which is a host of "phishingprotection.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("phishingprotection.googleapis.com", 443);

        /// <summary>
        /// The default PhishingProtectionServiceV1Beta1 scopes.
        /// </summary>
        /// <remarks>
        /// The default PhishingProtectionServiceV1Beta1 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PhishingProtectionServiceV1Beta1Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.PhishingProtection.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// PhishingProtectionServiceV1Beta1Client client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.PhishingProtection.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     PhishingProtectionServiceV1Beta1Client.DefaultEndpoint.Host, PhishingProtectionServiceV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PhishingProtectionServiceV1Beta1Client client = PhishingProtectionServiceV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PhishingProtectionServiceV1Beta1Settings"/>.</param>
        /// <returns>The task representing the created <see cref="PhishingProtectionServiceV1Beta1Client"/>.</returns>
        public static async stt::Task<PhishingProtectionServiceV1Beta1Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, PhishingProtectionServiceV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="PhishingProtectionServiceV1Beta1Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.PhishingProtection.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// PhishingProtectionServiceV1Beta1Client client = PhishingProtectionServiceV1Beta1Client.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.PhishingProtection.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     PhishingProtectionServiceV1Beta1Client.DefaultEndpoint.Host, PhishingProtectionServiceV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PhishingProtectionServiceV1Beta1Client client = PhishingProtectionServiceV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PhishingProtectionServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="PhishingProtectionServiceV1Beta1Client"/>.</returns>
        public static PhishingProtectionServiceV1Beta1Client Create(gaxgrpc::ServiceEndpoint endpoint = null, PhishingProtectionServiceV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="PhishingProtectionServiceV1Beta1Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PhishingProtectionServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="PhishingProtectionServiceV1Beta1Client"/>.</returns>
        public static PhishingProtectionServiceV1Beta1Client Create(grpccore::Channel channel, PhishingProtectionServiceV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="PhishingProtectionServiceV1Beta1Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PhishingProtectionServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="PhishingProtectionServiceV1Beta1Client"/>.</returns>
        public static PhishingProtectionServiceV1Beta1Client Create(grpccore::CallInvoker callInvoker, PhishingProtectionServiceV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client grpcClient = new PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client(callInvoker);
            return new PhishingProtectionServiceV1Beta1ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, PhishingProtectionServiceV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PhishingProtectionServiceV1Beta1Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, PhishingProtectionServiceV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PhishingProtectionServiceV1Beta1Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC PhishingProtectionServiceV1Beta1 client.
        /// </summary>
        public virtual PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(
            string parent,
            string uri,
            gaxgrpc::CallSettings callSettings = null) => ReportPhishingAsync(
                new ReportPhishingRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
                },
                callSettings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(
            string parent,
            string uri,
            st::CancellationToken cancellationToken) => ReportPhishingAsync(
                parent,
                uri,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReportPhishingResponse ReportPhishing(
            string parent,
            string uri,
            gaxgrpc::CallSettings callSettings = null) => ReportPhishing(
                new ReportPhishingRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
                },
                callSettings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
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
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(
            ReportPhishingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
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
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(
            ReportPhishingRequest request,
            st::CancellationToken cancellationToken) => ReportPhishingAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
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
        public virtual ReportPhishingResponse ReportPhishing(
            ReportPhishingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// PhishingProtectionServiceV1Beta1 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class PhishingProtectionServiceV1Beta1ClientImpl : PhishingProtectionServiceV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<ReportPhishingRequest, ReportPhishingResponse> _callReportPhishing;

        /// <summary>
        /// Constructs a client wrapper for the PhishingProtectionServiceV1Beta1 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PhishingProtectionServiceV1Beta1Settings"/> used within this client </param>
        public PhishingProtectionServiceV1Beta1ClientImpl(PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client grpcClient, PhishingProtectionServiceV1Beta1Settings settings)
        {
            GrpcClient = grpcClient;
            PhishingProtectionServiceV1Beta1Settings effectiveSettings = settings ?? PhishingProtectionServiceV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callReportPhishing = clientHelper.BuildApiCall<ReportPhishingRequest, ReportPhishingResponse>(
                GrpcClient.ReportPhishingAsync, GrpcClient.ReportPhishing, effectiveSettings.ReportPhishingSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            Modify_ApiCall(ref _callReportPhishing);
            Modify_ReportPhishingApiCall(ref _callReportPhishing);
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
        partial void Modify_ReportPhishingApiCall(ref gaxgrpc::ApiCall<ReportPhishingRequest, ReportPhishingResponse> call);
        partial void OnConstruction(PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client grpcClient, PhishingProtectionServiceV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC PhishingProtectionServiceV1Beta1 client.
        /// </summary>
        public override PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ReportPhishingRequest(ref ReportPhishingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
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
        public override stt::Task<ReportPhishingResponse> ReportPhishingAsync(
            ReportPhishingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportPhishingRequest(ref request, ref callSettings);
            return _callReportPhishing.Async(request, callSettings);
        }

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is completed, if its result verifies the existince of
        /// malicious phishing content, the site will be added the to [Google's Social
        /// Engineering lists](https://support.google.com/webmasters/answer/6350487/)
        /// in order to protect users that could get exposed to this threat in
        /// the future.
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
        public override ReportPhishingResponse ReportPhishing(
            ReportPhishingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportPhishingRequest(ref request, ref callSettings);
            return _callReportPhishing.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
