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

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>
    /// Settings for a <see cref="ResumeServiceClient"/>.
    /// </summary>
    public sealed partial class ResumeServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ResumeServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ResumeServiceSettings"/>.
        /// </returns>
        public static ResumeServiceSettings GetDefault() => new ResumeServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ResumeServiceSettings"/> object with default settings.
        /// </summary>
        public ResumeServiceSettings() { }

        private ResumeServiceSettings(ResumeServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ParseResumeSettings = existing.ParseResumeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ResumeServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ResumeServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ResumeServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ResumeServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ResumeServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ResumeServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ResumeServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ResumeServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ResumeServiceClient"/> RPC methods is defined as:
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
        /// <c>ResumeServiceClient.ParseResume</c> and <c>ResumeServiceClient.ParseResumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ResumeServiceClient.ParseResume</c> and
        /// <c>ResumeServiceClient.ParseResumeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ParseResumeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ResumeServiceSettings"/> object.</returns>
        public ResumeServiceSettings Clone() => new ResumeServiceSettings(this);
    }

    /// <summary>
    /// ResumeService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ResumeServiceClient
    {
        /// <summary>
        /// The default endpoint for the ResumeService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>
        /// The default ResumeService scopes.
        /// </summary>
        /// <remarks>
        /// The default ResumeService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/jobs"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ResumeServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ResumeServiceClient client = await ResumeServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ResumeServiceClient.DefaultEndpoint.Host, ResumeServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ResumeServiceClient client = ResumeServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ResumeServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ResumeServiceClient"/>.</returns>
        public static async stt::Task<ResumeServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ResumeServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ResumeServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ResumeServiceClient client = ResumeServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ResumeServiceClient.DefaultEndpoint.Host, ResumeServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ResumeServiceClient client = ResumeServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ResumeServiceSettings"/>.</param>
        /// <returns>The created <see cref="ResumeServiceClient"/>.</returns>
        public static ResumeServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ResumeServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ResumeServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ResumeServiceSettings"/>.</param>
        /// <returns>The created <see cref="ResumeServiceClient"/>.</returns>
        public static ResumeServiceClient Create(grpccore::Channel channel, ResumeServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ResumeServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ResumeServiceSettings"/>.</param>
        /// <returns>The created <see cref="ResumeServiceClient"/>.</returns>
        public static ResumeServiceClient Create(grpccore::CallInvoker callInvoker, ResumeServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ResumeService.ResumeServiceClient grpcClient = new ResumeService.ResumeServiceClient(callInvoker);
            return new ResumeServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ResumeServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ResumeServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ResumeServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ResumeServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ResumeService client.
        /// </summary>
        public virtual ResumeService.ResumeServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The resource name of the project.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="resume">
        /// Required.
        ///
        /// The bytes of the resume file in common format. Currently the API supports
        /// the following formats:
        /// PDF, TXT, DOC, RTF and DOCX.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ParseResumeResponse> ParseResumeAsync(
            string parent,
            pb::ByteString resume,
            gaxgrpc::CallSettings callSettings = null) => ParseResumeAsync(
                new ParseResumeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Resume = gax::GaxPreconditions.CheckNotNull(resume, nameof(resume)),
                },
                callSettings);

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The resource name of the project.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="resume">
        /// Required.
        ///
        /// The bytes of the resume file in common format. Currently the API supports
        /// the following formats:
        /// PDF, TXT, DOC, RTF and DOCX.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ParseResumeResponse> ParseResumeAsync(
            string parent,
            pb::ByteString resume,
            st::CancellationToken cancellationToken) => ParseResumeAsync(
                parent,
                resume,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The resource name of the project.
        ///
        /// The format is "projects/{project_id}", for example,
        /// "projects/api-test-project".
        /// </param>
        /// <param name="resume">
        /// Required.
        ///
        /// The bytes of the resume file in common format. Currently the API supports
        /// the following formats:
        /// PDF, TXT, DOC, RTF and DOCX.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ParseResumeResponse ParseResume(
            string parent,
            pb::ByteString resume,
            gaxgrpc::CallSettings callSettings = null) => ParseResume(
                new ParseResumeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Resume = gax::GaxPreconditions.CheckNotNull(resume, nameof(resume)),
                },
                callSettings);

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
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
        public virtual stt::Task<ParseResumeResponse> ParseResumeAsync(
            ParseResumeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
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
        public virtual stt::Task<ParseResumeResponse> ParseResumeAsync(
            ParseResumeRequest request,
            st::CancellationToken cancellationToken) => ParseResumeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
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
        public virtual ParseResumeResponse ParseResume(
            ParseResumeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ResumeService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ResumeServiceClientImpl : ResumeServiceClient
    {
        private readonly gaxgrpc::ApiCall<ParseResumeRequest, ParseResumeResponse> _callParseResume;

        /// <summary>
        /// Constructs a client wrapper for the ResumeService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ResumeServiceSettings"/> used within this client </param>
        public ResumeServiceClientImpl(ResumeService.ResumeServiceClient grpcClient, ResumeServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ResumeServiceSettings effectiveSettings = settings ?? ResumeServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callParseResume = clientHelper.BuildApiCall<ParseResumeRequest, ParseResumeResponse>(
                GrpcClient.ParseResumeAsync, GrpcClient.ParseResume, effectiveSettings.ParseResumeSettings);
            Modify_ApiCall(ref _callParseResume);
            Modify_ParseResumeApiCall(ref _callParseResume);
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
        partial void Modify_ParseResumeApiCall(ref gaxgrpc::ApiCall<ParseResumeRequest, ParseResumeResponse> call);
        partial void OnConstruction(ResumeService.ResumeServiceClient grpcClient, ResumeServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ResumeService client.
        /// </summary>
        public override ResumeService.ResumeServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ParseResumeRequest(ref ParseResumeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
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
        public override stt::Task<ParseResumeResponse> ParseResumeAsync(
            ParseResumeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ParseResumeRequest(ref request, ref callSettings);
            return _callParseResume.Async(request, callSettings);
        }

        /// <summary>
        /// Parses a resume into a [Profile][google.cloud.talent.v4beta1.Profile]. The API attempts to fill out the
        /// following profile fields if present within the resume:
        ///
        /// * personNames
        /// * addresses
        /// * emailAddress
        /// * phoneNumbers
        /// * personalUris
        /// * employmentRecords
        /// * educationRecords
        /// * skills
        ///
        /// Note that some attributes in these fields may not be populated if they're
        /// not present within the resume or unrecognizable by the resume parser.
        ///
        /// This API does not save the resume or profile. To create a profile from this
        /// resume, clients need to call the CreateProfile method again with the
        /// profile returned.
        ///
        /// This API supports the following list of formats:
        ///
        /// * PDF
        /// * TXT
        /// * DOC
        /// * RTF
        /// * DOCX
        ///
        /// An error is thrown if the input format is not supported.
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
        public override ParseResumeResponse ParseResume(
            ParseResumeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ParseResumeRequest(ref request, ref callSettings);
            return _callParseResume.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
