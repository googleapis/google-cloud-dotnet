// Copyright 2020 Google LLC
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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Settings for <see cref="JobControllerClient"/> instances.</summary>
    public sealed partial class JobControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="JobControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="JobControllerSettings"/>.</returns>
        public static JobControllerSettings GetDefault() => new JobControllerSettings();

        /// <summary>Constructs a new <see cref="JobControllerSettings"/> object with default settings.</summary>
        public JobControllerSettings()
        {
        }

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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.SubmitJob</c> and <c>JobControllerClient.SubmitJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 900 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubmitJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobControllerClient.GetJob</c>
        ///  and <c>JobControllerClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 900 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.ListJobs</c> and <c>JobControllerClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 900 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.UpdateJob</c> and <c>JobControllerClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 900 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.CancelJob</c> and <c>JobControllerClient.CancelJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 900 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobControllerClient.DeleteJob</c> and <c>JobControllerClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 900 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="JobControllerSettings"/> object.</returns>
        public JobControllerSettings Clone() => new JobControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="JobControllerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class JobControllerClientBuilder : gaxgrpc::ClientBuilderBase<JobControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public JobControllerSettings Settings { get; set; }

        /// <inheritdoc/>
        public override JobControllerClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return JobControllerClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<JobControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return JobControllerClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => JobControllerClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => JobControllerClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => JobControllerClient.ChannelPool;
    }

    /// <summary>JobController client wrapper, for convenient use.</summary>
    public abstract partial class JobControllerClient
    {
        /// <summary>
        /// The default endpoint for the JobController service, which is a host of "dataproc.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dataproc.googleapis.com", 443);

        /// <summary>The default JobController scopes.</summary>
        /// <remarks>
        /// The default JobController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="JobControllerClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
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
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
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
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
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
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
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
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="JobControllerSettings"/>.</param>
        /// <returns>The created <see cref="JobControllerClient"/>.</returns>
        public static JobControllerClient Create(grpccore::CallInvoker callInvoker, JobControllerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            JobController.JobControllerClient grpcClient = new JobController.JobControllerClient(callInvoker);
            return new JobControllerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,JobControllerSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,JobControllerSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to
        /// <see cref="Create(grpccore::CallInvoker,JobControllerSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,JobControllerSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC JobController client</summary>
        public virtual JobController.JobControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job SubmitJob(SubmitJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> SubmitJobAsync(SubmitJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> SubmitJobAsync(SubmitJobRequest request, st::CancellationToken cancellationToken) =>
            SubmitJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job SubmitJob(string projectId, string region, Job job, gaxgrpc::CallSettings callSettings = null) =>
            SubmitJob(new SubmitJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> SubmitJobAsync(string projectId, string region, Job job, gaxgrpc::CallSettings callSettings = null) =>
            SubmitJobAsync(new SubmitJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> SubmitJobAsync(string projectId, string region, Job job, st::CancellationToken cancellationToken) =>
            SubmitJobAsync(projectId, region, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(string projectId, string region, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string projectId, string region, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string projectId, string region, string jobId, st::CancellationToken cancellationToken) =>
            GetJobAsync(projectId, region, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(string projectId, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobs(new ListJobsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(string projectId, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobsAsync(new ListJobsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(string projectId, string region, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobs(new ListJobsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(string projectId, string region, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobsAsync(new ListJobsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CancelJob(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CancelJobAsync(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CancelJobAsync(CancelJobRequest request, st::CancellationToken cancellationToken) =>
            CancelJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CancelJob(string projectId, string region, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CancelJob(new CancelJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CancelJobAsync(string projectId, string region, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CancelJobAsync(new CancelJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CancelJobAsync(string projectId, string region, string jobId, st::CancellationToken cancellationToken) =>
            CancelJobAsync(projectId, region, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(DeleteJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(string projectId, string region, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(string projectId, string region, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(string projectId, string region, string jobId, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(projectId, region, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>JobController client wrapper implementation, for convenient use.</summary>
    public sealed partial class JobControllerClientImpl : JobControllerClient
    {
        private readonly gaxgrpc::ApiCall<SubmitJobRequest, Job> _callSubmitJob;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;

        private readonly gaxgrpc::ApiCall<CancelJobRequest, Job> _callCancelJob;

        private readonly gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> _callDeleteJob;

        /// <summary>
        /// Constructs a client wrapper for the JobController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobControllerSettings"/> used within this client.</param>
        public JobControllerClientImpl(JobController.JobControllerClient grpcClient, JobControllerSettings settings)
        {
            GrpcClient = grpcClient;
            JobControllerSettings effectiveSettings = settings ?? JobControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSubmitJob = clientHelper.BuildApiCall<SubmitJobRequest, Job>(grpcClient.SubmitJobAsync, grpcClient.SubmitJob, effectiveSettings.SubmitJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callSubmitJob);
            Modify_SubmitJobApiCall(ref _callSubmitJob);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>(grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>(grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>(grpcClient.UpdateJobAsync, grpcClient.UpdateJob, effectiveSettings.UpdateJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            _callCancelJob = clientHelper.BuildApiCall<CancelJobRequest, Job>(grpcClient.CancelJobAsync, grpcClient.CancelJob, effectiveSettings.CancelJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callCancelJob);
            Modify_CancelJobApiCall(ref _callCancelJob);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, wkt::Empty>(grpcClient.DeleteJobAsync, grpcClient.DeleteJob, effectiveSettings.DeleteJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SubmitJobApiCall(ref gaxgrpc::ApiCall<SubmitJobRequest, Job> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);

        partial void Modify_CancelJobApiCall(ref gaxgrpc::ApiCall<CancelJobRequest, Job> call);

        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> call);

        partial void OnConstruction(JobController.JobControllerClient grpcClient, JobControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC JobController client</summary>
        public override JobController.JobControllerClient GrpcClient { get; }

        partial void Modify_SubmitJobRequest(ref SubmitJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelJobRequest(ref CancelJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job SubmitJob(SubmitJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitJobRequest(ref request, ref callSettings);
            return _callSubmitJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Submits a job to a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> SubmitJobAsync(SubmitJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitJobRequest(ref request, ref callSettings);
            return _callSubmitJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// Lists regions/{region}/jobs in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// Updates a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a job in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job CancelJob(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return _callCancelJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a job cancellation request. To access the job resource
        /// after cancellation, call
        /// [regions/{region}/jobs.list](/dataproc/docs/reference/rest/v1/projects.regions.jobs/list)
        /// or
        /// [regions/{region}/jobs.get](/dataproc/docs/reference/rest/v1/projects.regions.jobs/get).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> CancelJobAsync(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return _callCancelJob.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            _callDeleteJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the job from the project. If the job is active, the delete fails,
        /// and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            return _callDeleteJob.Async(request, callSettings);
        }
    }

    public partial class ListJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobsResponse : gaxgrpc::IPageResponse<Job>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
