// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>
    /// Settings for a <see cref="JobControllerClient"/>.
    /// </summary>
    public sealed partial class JobControllerSettings : ServiceSettingsBase
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
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
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
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="JobControllerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="JobControllerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

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
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
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
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(30000),
            maxDelay: TimeSpan.FromMilliseconds(30000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.SubmitJob</c> and <c>JobControllerClient.SubmitJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.SubmitJob</c> and
        /// <c>JobControllerClient.SubmitJobAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SubmitJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.GetJob</c> and <c>JobControllerClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.GetJob</c> and
        /// <c>JobControllerClient.GetJobAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.ListJobs</c> and <c>JobControllerClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.ListJobs</c> and
        /// <c>JobControllerClient.ListJobsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListJobsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.UpdateJob</c> and <c>JobControllerClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.UpdateJob</c> and
        /// <c>JobControllerClient.UpdateJobAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.CancelJob</c> and <c>JobControllerClient.CancelJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.CancelJob</c> and
        /// <c>JobControllerClient.CancelJobAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CancelJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.DeleteJob</c> and <c>JobControllerClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobControllerClient.DeleteJob</c> and
        /// <c>JobControllerClient.DeleteJobAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="JobControllerSettings"/> object.</returns>
        public JobControllerSettings Clone() => new JobControllerSettings(this);
    }

    /// <summary>
    /// JobController client wrapper, for convenient use.
    /// </summary>
    public abstract partial class JobControllerClient
    {
        /// <summary>
        /// The default endpoint for the JobController service, which is a host of "dataproc.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("dataproc.googleapis.com", 443);

        /// <summary>
        /// The default JobController scopes.
        /// </summary>
        /// <remarks>
        /// The default JobController scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="JobControllerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="JobControllerClient"/>.</returns>
        public static async Task<JobControllerClient> CreateAsync(ServiceEndpoint endpoint = null, JobControllerSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="JobControllerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The created <see cref="JobControllerClient"/>.</returns>
        public static JobControllerClient Create(ServiceEndpoint endpoint = null, JobControllerSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="JobControllerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The created <see cref="JobControllerClient"/>.</returns>
        public static JobControllerClient Create(Channel channel, JobControllerSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            JobController.JobControllerClient grpcClient = new JobController.JobControllerClient(channel);
            return new JobControllerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, JobControllerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, JobControllerSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, JobControllerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, JobControllerSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC JobController client.
        /// </summary>
        public virtual JobController.JobControllerClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
        public virtual Task<Job> SubmitJobAsync(
            string projectId,
            string region,
            Job job,
            CallSettings callSettings = null) => SubmitJobAsync(
                new SubmitJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Job = GaxPreconditions.CheckNotNull(job, nameof(job)),
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
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="job">
        /// Required. The job resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Job> SubmitJobAsync(
            string projectId,
            string region,
            Job job,
            CancellationToken cancellationToken) => SubmitJobAsync(
                projectId,
                region,
                job,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
            CallSettings callSettings = null) => SubmitJob(
                new SubmitJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    Job = GaxPreconditions.CheckNotNull(job, nameof(job)),
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
        public virtual Task<Job> SubmitJobAsync(
            SubmitJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Job> SubmitJobAsync(
            SubmitJobRequest request,
            CancellationToken cancellationToken) => SubmitJobAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
        public virtual Task<Job> GetJobAsync(
            string projectId,
            string region,
            string jobId,
            CallSettings callSettings = null) => GetJobAsync(
                new GetJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
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
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Job> GetJobAsync(
            string projectId,
            string region,
            string jobId,
            CancellationToken cancellationToken) => GetJobAsync(
                projectId,
                region,
                jobId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
            CallSettings callSettings = null) => GetJob(
                new GetJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
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
        public virtual Task<Job> GetJobAsync(
            GetJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Job> GetJobAsync(
            GetJobRequest request,
            CancellationToken cancellationToken) => GetJobAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
        public virtual PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(
            string projectId,
            string region,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListJobsAsync(
                new ListJobsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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
        /// Required. The Cloud Dataproc region in which to handle the request.
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
        public virtual PagedEnumerable<ListJobsResponse, Job> ListJobs(
            string projectId,
            string region,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListJobs(
                new ListJobsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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
        public virtual PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(
            ListJobsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual PagedEnumerable<ListJobsResponse, Job> ListJobs(
            ListJobsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual Task<Job> UpdateJobAsync(
            UpdateJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a job in a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Job> UpdateJobAsync(
            UpdateJobRequest request,
            CancellationToken cancellationToken) => UpdateJobAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
        public virtual Task<Job> CancelJobAsync(
            string projectId,
            string region,
            string jobId,
            CallSettings callSettings = null) => CancelJobAsync(
                new CancelJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Job> CancelJobAsync(
            string projectId,
            string region,
            string jobId,
            CancellationToken cancellationToken) => CancelJobAsync(
                projectId,
                region,
                jobId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
            CallSettings callSettings = null) => CancelJob(
                new CancelJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
                },
                callSettings);

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
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
        public virtual Task<Job> CancelJobAsync(
            CancelJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Job> CancelJobAsync(
            CancelJobRequest request,
            CancellationToken cancellationToken) => CancelJobAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// Required. The Cloud Dataproc region in which to handle the request.
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
        public virtual Task DeleteJobAsync(
            string projectId,
            string region,
            string jobId,
            CallSettings callSettings = null) => DeleteJobAsync(
                new DeleteJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
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
        /// Required. The Cloud Dataproc region in which to handle the request.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteJobAsync(
            string projectId,
            string region,
            string jobId,
            CancellationToken cancellationToken) => DeleteJobAsync(
                projectId,
                region,
                jobId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the job
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Cloud Dataproc region in which to handle the request.
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
            CallSettings callSettings = null) => DeleteJob(
                new DeleteJobRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Region = GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                    JobId = GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
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
        public virtual Task DeleteJobAsync(
            DeleteJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteJobAsync(
            DeleteJobRequest request,
            CancellationToken cancellationToken) => DeleteJobAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// JobController client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class JobControllerClientImpl : JobControllerClient
    {
        private readonly ApiCall<SubmitJobRequest, Job> _callSubmitJob;
        private readonly ApiCall<GetJobRequest, Job> _callGetJob;
        private readonly ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;
        private readonly ApiCall<UpdateJobRequest, Job> _callUpdateJob;
        private readonly ApiCall<CancelJobRequest, Job> _callCancelJob;
        private readonly ApiCall<DeleteJobRequest, Empty> _callDeleteJob;

        /// <summary>
        /// Constructs a client wrapper for the JobController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobControllerSettings"/> used within this client </param>
        public JobControllerClientImpl(JobController.JobControllerClient grpcClient, JobControllerSettings settings)
        {
            GrpcClient = grpcClient;
            JobControllerSettings effectiveSettings = settings ?? JobControllerSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
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
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, Empty>(
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
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_SubmitJobApiCall(ref ApiCall<SubmitJobRequest, Job> call);
        partial void Modify_GetJobApiCall(ref ApiCall<GetJobRequest, Job> call);
        partial void Modify_ListJobsApiCall(ref ApiCall<ListJobsRequest, ListJobsResponse> call);
        partial void Modify_UpdateJobApiCall(ref ApiCall<UpdateJobRequest, Job> call);
        partial void Modify_CancelJobApiCall(ref ApiCall<CancelJobRequest, Job> call);
        partial void Modify_DeleteJobApiCall(ref ApiCall<DeleteJobRequest, Empty> call);
        partial void OnConstruction(JobController.JobControllerClient grpcClient, JobControllerSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC JobController client.
        /// </summary>
        public override JobController.JobControllerClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_SubmitJobRequest(ref SubmitJobRequest request, ref CallSettings settings);
        partial void Modify_GetJobRequest(ref GetJobRequest request, ref CallSettings settings);
        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref CallSettings settings);
        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref CallSettings settings);
        partial void Modify_CancelJobRequest(ref CancelJobRequest request, ref CallSettings settings);
        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref CallSettings settings);

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
        public override Task<Job> SubmitJobAsync(
            SubmitJobRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
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
        public override Task<Job> GetJobAsync(
            GetJobRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
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
        public override PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(
            ListJobsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
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
        public override PagedEnumerable<ListJobsResponse, Job> ListJobs(
            ListJobsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
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
        public override Task<Job> UpdateJobAsync(
            UpdateJobRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
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
        public override Task<Job> CancelJobAsync(
            CancelJobRequest request,
            CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return _callCancelJob.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list) or
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
            CallSettings callSettings = null)
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
        public override Task DeleteJobAsync(
            DeleteJobRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            _callDeleteJob.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListJobsRequest : IPageRequest { }
    public partial class ListJobsResponse : IPageResponse<Job>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
