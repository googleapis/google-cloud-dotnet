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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>
    /// Settings for a <see cref="JobControllerClient"/>.
    /// </summary>
    public sealed partial class JobControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="JobControllerSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="JobControllerSettings"/>.
        /// </returns>
        public static JobControllerSettings GetDefault() => new JobControllerSettings();

        /// <summary>
        /// Constructs a new <see cref="JobControllerSettings"/> object with default settings.
        /// </summary>
        public JobControllerSettings() { }

        private JobControllerSettings(JobControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SubmitJobSettings = existing.SubmitJobSettings;
            GetJobSettings = existing.GetJobSettings;
            ListJobsSettings = existing.ListJobsSettings;
            UpdateJobSettings = existing.UpdateJobSettings;
            CancelJobSettings = existing.CancelJobSettings;
            DeleteJobSettings = existing.DeleteJobSettings;
            OnCopy(existing);
        }

        partial void OnCopy(JobControllerSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="JobControllerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="JobControllerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "NonIdempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="JobControllerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="JobControllerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="JobControllerClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="JobControllerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="JobControllerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="JobControllerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(30000),
            maxDelay: sys::TimeSpan.FromMilliseconds(30000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.SubmitJob</c> and <c>JobControllerClient.SubmitJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.SubmitJob</c> and
        /// <c>JobControllerClient.SubmitJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 900000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SubmitJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.GetJob</c> and <c>JobControllerClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.GetJob</c> and
        /// <c>JobControllerClient.GetJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 900000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.ListJobs</c> and <c>JobControllerClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.ListJobs</c> and
        /// <c>JobControllerClient.ListJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 900000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.UpdateJob</c> and <c>JobControllerClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.UpdateJob</c> and
        /// <c>JobControllerClient.UpdateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 900000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.CancelJob</c> and <c>JobControllerClient.CancelJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.CancelJob</c> and
        /// <c>JobControllerClient.CancelJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 900000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CancelJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.DeleteJob</c> and <c>JobControllerClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.DeleteJob</c> and
        /// <c>JobControllerClient.DeleteJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 900000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="JobControllerSettings"/> object.</returns>
        public JobControllerSettings Clone() => new JobControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="JobControllerClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class JobControllerClientBuilder : gaxgrpc::ClientBuilderBase<JobControllerClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public JobControllerSettings Settings { get; set; }

        /// <inheritdoc/>
        public override JobControllerClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return JobControllerClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<JobControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return JobControllerClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => JobControllerClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => JobControllerClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => JobControllerClient.ChannelPool;
    }

    /// <summary>
    /// JobController client wrapper, for convenient use.
    /// </summary>
    public abstract partial class JobControllerClient
    {
        /// <summary>
        /// The default endpoint for the JobController service, which is a host of "dataproc.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dataproc.googleapis.com", 443);

        /// <summary>
        /// The default JobController scopes.
        /// </summary>
        /// <remarks>
        /// The default JobController scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="JobControllerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// JobControllerClient client = await JobControllerClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     JobControllerClient.DefaultEndpoint.Host, JobControllerClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// JobControllerClient client = JobControllerClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="JobControllerClient"/>.</returns>
        public static async stt::Task<JobControllerClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, JobControllerSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="JobControllerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// JobControllerClient client = JobControllerClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     JobControllerClient.DefaultEndpoint.Host, JobControllerClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// JobControllerClient client = JobControllerClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The created <see cref="JobControllerClient"/>.</returns>
        public static JobControllerClient Create(gaxgrpc::ServiceEndpoint endpoint = null, JobControllerSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="JobControllerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The created <see cref="JobControllerClient"/>.</returns>
        public static JobControllerClient Create(grpccore::Channel channel, JobControllerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="JobControllerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The created <see cref="JobControllerClient"/>.</returns>
        public static JobControllerClient Create(grpccore::CallInvoker callInvoker, JobControllerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            JobController.JobControllerClient grpcClient = new JobController.JobControllerClient(callInvoker);
            return new JobControllerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, JobControllerSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, JobControllerSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, JobControllerSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, JobControllerSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC JobController client.
        /// </summary>
        public virtual JobController.JobControllerClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="job">
        /// Required. The job resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> SubmitJobAsync(
            string projectId,
            string region,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => SubmitJobAsync(
                new SubmitJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="job">
        /// Required. The job resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> SubmitJobAsync(
            string projectId,
            string region,
            Job job,
            st::CancellationToken cancellationToken) => SubmitJobAsync(
                projectId,
                region,
                job,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="job">
        /// Required. The job resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job SubmitJob(
            string projectId,
            string region,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => SubmitJob(
                new SubmitJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Submits a job to a cluster.
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
        public virtual stt::Task<Job> SubmitJobAsync(
            SubmitJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Submits a job to a cluster.
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
        public virtual stt::Task<Job> SubmitJobAsync(
            SubmitJobRequest request,
            st::CancellationToken cancellationToken) => SubmitJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a job to a cluster.
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
        public virtual Job SubmitJob(
            SubmitJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            string projectId,
            string region,
            string jobId,
            gaxgrpc::CallSettings callSettings = null) => GetJobAsync(
                new GetJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            string projectId,
            string region,
            string jobId,
            st::CancellationToken cancellationToken) => GetJobAsync(
                projectId,
                region,
                jobId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job GetJob(
            string projectId,
            string region,
            string jobId,
            gaxgrpc::CallSettings callSettings = null) => GetJob(
                new GetJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Gets the resource representation for a job in a project.
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
        public virtual stt::Task<Job> GetJobAsync(
            GetJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
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
        public virtual stt::Task<Job> GetJobAsync(
            GetJobRequest request,
            st::CancellationToken cancellationToken) => GetJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a job in a project.
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
        public virtual Job GetJob(
            GetJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Job"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(
            string projectId,
            string region,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobsAsync(
                new ListJobsRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Job"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(
            string projectId,
            string region,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobs(
                new ListJobsRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter constraining the jobs to list. Filters are
        /// case-sensitive and have the following syntax:
        ///
        /// [field = value] AND [field [= value]] ...
        ///
        /// where **field** is `status.state` or `labels.[KEY]`, and `[KEY]` is a label
        /// key. **value** can be `*` to match all values.
        /// `status.state` can be either `ACTIVE` or `NON_ACTIVE`.
        /// Only the logical `AND` operator is supported; space-separated items are
        /// treated as having an implicit `AND` operator.
        ///
        /// Example filter:
        ///
        /// status.state = ACTIVE AND labels.env = staging AND labels.starred = *
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Job"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(
            string projectId,
            string region,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobsAsync(
                new ListJobsRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter constraining the jobs to list. Filters are
        /// case-sensitive and have the following syntax:
        ///
        /// [field = value] AND [field [= value]] ...
        ///
        /// where **field** is `status.state` or `labels.[KEY]`, and `[KEY]` is a label
        /// key. **value** can be `*` to match all values.
        /// `status.state` can be either `ACTIVE` or `NON_ACTIVE`.
        /// Only the logical `AND` operator is supported; space-separated items are
        /// treated as having an implicit `AND` operator.
        ///
        /// Example filter:
        ///
        /// status.state = ACTIVE AND labels.env = staging AND labels.starred = *
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Job"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(
            string projectId,
            string region,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobs(
                new ListJobsRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Job"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(
            ListJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Job"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(
            ListJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a job in a project.
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
        public virtual stt::Task<Job> UpdateJobAsync(
            UpdateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a job in a project.
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
        public virtual stt::Task<Job> UpdateJobAsync(
            UpdateJobRequest request,
            st::CancellationToken cancellationToken) => UpdateJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job in a project.
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
        public virtual Job UpdateJob(
            UpdateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CancelJobAsync(
            string projectId,
            string region,
            string jobId,
            gaxgrpc::CallSettings callSettings = null) => CancelJobAsync(
                new CancelJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CancelJobAsync(
            string projectId,
            string region,
            string jobId,
            st::CancellationToken cancellationToken) => CancelJobAsync(
                projectId,
                region,
                jobId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job CancelJob(
            string projectId,
            string region,
            string jobId,
            gaxgrpc::CallSettings callSettings = null) => CancelJob(
                new CancelJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
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
        public virtual stt::Task<Job> CancelJobAsync(
            CancelJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
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
        public virtual stt::Task<Job> CancelJobAsync(
            CancelJobRequest request,
            st::CancellationToken cancellationToken) => CancelJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
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
        public virtual Job CancelJob(
            CancelJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            string projectId,
            string region,
            string jobId,
            gaxgrpc::CallSettings callSettings = null) => DeleteJobAsync(
                new DeleteJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            string projectId,
            string region,
            string jobId,
            st::CancellationToken cancellationToken) => DeleteJobAsync(
                projectId,
                region,
                jobId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteJob(
            string projectId,
            string region,
            string jobId,
            gaxgrpc::CallSettings callSettings = null) => DeleteJob(
                new DeleteJobRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            DeleteJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            DeleteJobRequest request,
            st::CancellationToken cancellationToken) => DeleteJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteJob(
            DeleteJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// JobController client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class JobControllerClientImpl : JobControllerClient
    {
        private readonly gaxgrpc::ApiCall<SubmitJobRequest, Job> _callSubmitJob;
        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;
        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;
        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;
        private readonly gaxgrpc::ApiCall<CancelJobRequest, Job> _callCancelJob;
        private readonly gaxgrpc::ApiCall<DeleteJobRequest, pbwkt::Empty> _callDeleteJob;

        /// <summary>
        /// Constructs a client wrapper for the JobController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobControllerSettings"/> used within this client </param>
        public JobControllerClientImpl(JobController.JobControllerClient grpcClient, JobControllerSettings settings)
        {
            GrpcClient = grpcClient;
            JobControllerSettings effectiveSettings = settings ?? JobControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSubmitJob = clientHelper.BuildApiCall<SubmitJobRequest, Job>(
                GrpcClient.SubmitJobAsync, GrpcClient.SubmitJob, effectiveSettings.SubmitJobSettings);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>(
                GrpcClient.GetJobAsync, GrpcClient.GetJob, effectiveSettings.GetJobSettings);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>(
                GrpcClient.ListJobsAsync, GrpcClient.ListJobs, effectiveSettings.ListJobsSettings);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>(
                GrpcClient.UpdateJobAsync, GrpcClient.UpdateJob, effectiveSettings.UpdateJobSettings);
            _callCancelJob = clientHelper.BuildApiCall<CancelJobRequest, Job>(
                GrpcClient.CancelJobAsync, GrpcClient.CancelJob, effectiveSettings.CancelJobSettings);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, pbwkt::Empty>(
                GrpcClient.DeleteJobAsync, GrpcClient.DeleteJob, effectiveSettings.DeleteJobSettings);
            Modify_ApiCall(ref _callSubmitJob);
            Modify_SubmitJobApiCall(ref _callSubmitJob);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            Modify_ApiCall(ref _callCancelJob);
            Modify_CancelJobApiCall(ref _callCancelJob);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
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
        partial void Modify_SubmitJobApiCall(ref gaxgrpc::ApiCall<SubmitJobRequest, Job> call);
        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);
        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);
        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);
        partial void Modify_CancelJobApiCall(ref gaxgrpc::ApiCall<CancelJobRequest, Job> call);
        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, pbwkt::Empty> call);
        partial void OnConstruction(JobController.JobControllerClient grpcClient, JobControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC JobController client.
        /// </summary>
        public override JobController.JobControllerClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_SubmitJobRequest(ref SubmitJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CancelJobRequest(ref CancelJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Submits a job to a cluster.
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
        public override stt::Task<Job> SubmitJobAsync(
            SubmitJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitJobRequest(ref request, ref callSettings);
            return _callSubmitJob.Async(request, callSettings);
        }

        /// <summary>
        /// Submits a job to a cluster.
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
        public override Job SubmitJob(
            SubmitJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitJobRequest(ref request, ref callSettings);
            return _callSubmitJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
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
        public override stt::Task<Job> GetJobAsync(
            GetJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
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
        public override Job GetJob(
            GetJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Job"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(
            ListJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Job"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(
            ListJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// Updates a job in a project.
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
        public override stt::Task<Job> UpdateJobAsync(
            UpdateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a job in a project.
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
        public override Job UpdateJob(
            UpdateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
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
        public override stt::Task<Job> CancelJobAsync(
            CancelJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return _callCancelJob.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
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
        public override Job CancelJob(
            CancelJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return _callCancelJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteJobAsync(
            DeleteJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            return _callDeleteJob.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteJob(
            DeleteJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            _callDeleteJob.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListJobsRequest : gaxgrpc::IPageRequest { }
    public partial class ListJobsResponse : gaxgrpc::IPageResponse<Job>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
