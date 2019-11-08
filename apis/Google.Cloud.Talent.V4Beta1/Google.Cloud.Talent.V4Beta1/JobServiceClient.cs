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
using lro = Google.LongRunning;
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
    /// Settings for a <see cref="JobServiceClient"/>.
    /// </summary>
    public sealed partial class JobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="JobServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="JobServiceSettings"/>.
        /// </returns>
        public static JobServiceSettings GetDefault() => new JobServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="JobServiceSettings"/> object with default settings.
        /// </summary>
        public JobServiceSettings() { }

        private JobServiceSettings(JobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateJobSettings = existing.CreateJobSettings;
            GetJobSettings = existing.GetJobSettings;
            UpdateJobSettings = existing.UpdateJobSettings;
            DeleteJobSettings = existing.DeleteJobSettings;
            ListJobsSettings = existing.ListJobsSettings;
            BatchDeleteJobsSettings = existing.BatchDeleteJobsSettings;
            SearchJobsSettings = existing.SearchJobsSettings;
            SearchJobsForAlertSettings = existing.SearchJobsForAlertSettings;
            BatchCreateJobsSettings = existing.BatchCreateJobsSettings;
            BatchCreateJobsOperationsSettings = existing.BatchCreateJobsOperationsSettings?.Clone();
            BatchUpdateJobsSettings = existing.BatchUpdateJobsSettings;
            BatchUpdateJobsOperationsSettings = existing.BatchUpdateJobsOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(JobServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="JobServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="JobServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="JobServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="JobServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="JobServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="JobServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="JobServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="JobServiceClient"/> RPC methods is defined as:
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
        /// <c>JobServiceClient.CreateJob</c> and <c>JobServiceClient.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.CreateJob</c> and
        /// <c>JobServiceClient.CreateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.GetJob</c> and <c>JobServiceClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.GetJob</c> and
        /// <c>JobServiceClient.GetJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.UpdateJob</c> and <c>JobServiceClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.UpdateJob</c> and
        /// <c>JobServiceClient.UpdateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.DeleteJob</c> and <c>JobServiceClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.DeleteJob</c> and
        /// <c>JobServiceClient.DeleteJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListJobs</c> and <c>JobServiceClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.ListJobs</c> and
        /// <c>JobServiceClient.ListJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.BatchDeleteJobs</c> and <c>JobServiceClient.BatchDeleteJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.BatchDeleteJobs</c> and
        /// <c>JobServiceClient.BatchDeleteJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchDeleteJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.SearchJobs</c> and <c>JobServiceClient.SearchJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.SearchJobs</c> and
        /// <c>JobServiceClient.SearchJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SearchJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.SearchJobsForAlert</c> and <c>JobServiceClient.SearchJobsForAlertAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.SearchJobsForAlert</c> and
        /// <c>JobServiceClient.SearchJobsForAlertAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SearchJobsForAlertSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.BatchCreateJobs</c> and <c>JobServiceClient.BatchCreateJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.BatchCreateJobs</c> and
        /// <c>JobServiceClient.BatchCreateJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchCreateJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.BatchCreateJobs</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchCreateJobsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.BatchUpdateJobs</c> and <c>JobServiceClient.BatchUpdateJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>JobServiceClient.BatchUpdateJobs</c> and
        /// <c>JobServiceClient.BatchUpdateJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchUpdateJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.BatchUpdateJobs</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchUpdateJobsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="JobServiceSettings"/> object.</returns>
        public JobServiceSettings Clone() => new JobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="JobServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class JobServiceClientBuilder : gaxgrpc::ClientBuilderBase<JobServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public JobServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override JobServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return JobServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<JobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return JobServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => JobServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => JobServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => JobServiceClient.ChannelPool;
    }

    /// <summary>
    /// JobService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class JobServiceClient
    {
        /// <summary>
        /// The default endpoint for the JobService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>
        /// The default JobService scopes.
        /// </summary>
        /// <remarks>
        /// The default JobService scopes are:
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

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="JobServiceClient"/>, applying defaults for all unspecified settings,
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
        /// JobServiceClient client = await JobServiceClient.CreateAsync();
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
        ///     JobServiceClient.DefaultEndpoint.Host, JobServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// JobServiceClient client = JobServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="JobServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="JobServiceClient"/>.</returns>
        public static async stt::Task<JobServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, JobServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="JobServiceClient"/>, applying defaults for all unspecified settings,
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
        /// JobServiceClient client = JobServiceClient.Create();
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
        ///     JobServiceClient.DefaultEndpoint.Host, JobServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// JobServiceClient client = JobServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="JobServiceSettings"/>.</param>
        /// <returns>The created <see cref="JobServiceClient"/>.</returns>
        public static JobServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, JobServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="JobServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="JobServiceSettings"/>.</param>
        /// <returns>The created <see cref="JobServiceClient"/>.</returns>
        public static JobServiceClient Create(grpccore::Channel channel, JobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="JobServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="JobServiceSettings"/>.</param>
        /// <returns>The created <see cref="JobServiceClient"/>.</returns>
        public static JobServiceClient Create(grpccore::CallInvoker callInvoker, JobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            JobService.JobServiceClient grpcClient = new JobService.JobServiceClient(callInvoker);
            return new JobServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, JobServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, JobServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, JobServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, JobServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC JobService client.
        /// </summary>
        public virtual JobService.JobServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CreateJobAsync(
            TenantOrProjectNameOneof parent,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => CreateJobAsync(
                new CreateJobRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CreateJobAsync(
            TenantOrProjectNameOneof parent,
            Job job,
            st::CancellationToken cancellationToken) => CreateJobAsync(
                parent,
                job,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job CreateJob(
            TenantOrProjectNameOneof parent,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => CreateJob(
                new CreateJobRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CreateJobAsync(
            string parent,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => CreateJobAsync(
                new CreateJobRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CreateJobAsync(
            string parent,
            Job job,
            st::CancellationToken cancellationToken) => CreateJobAsync(
                parent,
                job,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job CreateJob(
            string parent,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => CreateJob(
                new CreateJobRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        public virtual stt::Task<Job> CreateJobAsync(
            CreateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        public virtual stt::Task<Job> CreateJobAsync(
            CreateJobRequest request,
            st::CancellationToken cancellationToken) => CreateJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        public virtual Job CreateJob(
            CreateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            JobNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => GetJobAsync(
                new GetJobRequest
                {
                    JobNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            JobNameOneof name,
            st::CancellationToken cancellationToken) => GetJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job GetJob(
            JobNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => GetJob(
                new GetJobRequest
                {
                    JobNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetJobAsync(
                new GetJobRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            string name,
            st::CancellationToken cancellationToken) => GetJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job GetJob(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetJob(
                new GetJobRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
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
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
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
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
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
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> UpdateJobAsync(
            Job job,
            gaxgrpc::CallSettings callSettings = null) => UpdateJobAsync(
                new UpdateJobRequest
                {
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> UpdateJobAsync(
            Job job,
            st::CancellationToken cancellationToken) => UpdateJobAsync(
                job,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job UpdateJob(
            Job job,
            gaxgrpc::CallSettings callSettings = null) => UpdateJob(
                new UpdateJobRequest
                {
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
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
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
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
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
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
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            JobNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => DeleteJobAsync(
                new DeleteJobRequest
                {
                    JobNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            JobNameOneof name,
            st::CancellationToken cancellationToken) => DeleteJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteJob(
            JobNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => DeleteJob(
                new DeleteJobRequest
                {
                    JobNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteJobAsync(
                new DeleteJobRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        ///
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteJob(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteJob(
                new DeleteJobRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
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

        /// <summary>
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        ///
        /// Sample Query:
        ///
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
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
            TenantOrProjectNameOneof parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobsAsync(
                new ListJobsRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        ///
        /// Sample Query:
        ///
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
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
            TenantOrProjectNameOneof parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobs(
                new ListJobsRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        ///
        /// Sample Query:
        ///
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
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
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobsAsync(
                new ListJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        ///
        /// Sample Query:
        ///
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
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
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobs(
                new ListJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists jobs by filter.
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
        /// Lists jobs by filter.
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
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        ///
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task BatchDeleteJobsAsync(
            TenantOrProjectNameOneof parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteJobsAsync(
                new BatchDeleteJobsRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                },
                callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        ///
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task BatchDeleteJobsAsync(
            TenantOrProjectNameOneof parent,
            string filter,
            st::CancellationToken cancellationToken) => BatchDeleteJobsAsync(
                parent,
                filter,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        ///
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void BatchDeleteJobs(
            TenantOrProjectNameOneof parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteJobs(
                new BatchDeleteJobsRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                },
                callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        ///
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task BatchDeleteJobsAsync(
            string parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteJobsAsync(
                new BatchDeleteJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                },
                callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        ///
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task BatchDeleteJobsAsync(
            string parent,
            string filter,
            st::CancellationToken cancellationToken) => BatchDeleteJobsAsync(
                parent,
                filter,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        ///
        /// Supported operator: =, AND
        ///
        /// The fields eligible for filtering are:
        ///
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        ///
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void BatchDeleteJobs(
            string parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteJobs(
                new BatchDeleteJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                },
                callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
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
        public virtual stt::Task BatchDeleteJobsAsync(
            BatchDeleteJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
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
        public virtual stt::Task BatchDeleteJobsAsync(
            BatchDeleteJobsRequest request,
            st::CancellationToken cancellationToken) => BatchDeleteJobsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void BatchDeleteJobs(
            BatchDeleteJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsAsync(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobs(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlertAsync(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlert(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(
            string parent,
            scg::IEnumerable<Job> jobs,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateJobsAsync(
                new BatchCreateJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Jobs = { gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)) },
                },
                callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(
            string parent,
            scg::IEnumerable<Job> jobs,
            st::CancellationToken cancellationToken) => BatchCreateJobsAsync(
                parent,
                jobs,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(
            string parent,
            scg::IEnumerable<Job> jobs,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateJobs(
                new BatchCreateJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Jobs = { gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)) },
                },
                callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
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
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(
            BatchCreateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateJobsAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> PollOnceBatchCreateJobsAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchCreateJobsOperationsClient,
                callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
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
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(
            BatchCreateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchCreateJobs</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchCreateJobsOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateJobs</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> PollOnceBatchCreateJobs(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchCreateJobsOperationsClient,
                callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(
            string parent,
            scg::IEnumerable<Job> jobs,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateJobsAsync(
                new BatchUpdateJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Jobs = { gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)) },
                },
                callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(
            string parent,
            scg::IEnumerable<Job> jobs,
            st::CancellationToken cancellationToken) => BatchUpdateJobsAsync(
                parent,
                jobs,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(
            string parent,
            scg::IEnumerable<Job> jobs,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateJobs(
                new BatchUpdateJobsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Jobs = { gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)) },
                },
                callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
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
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(
            BatchUpdateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateJobsAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> PollOnceBatchUpdateJobsAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateJobsOperationsClient,
                callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
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
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(
            BatchUpdateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateJobs</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchUpdateJobsOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateJobs</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> PollOnceBatchUpdateJobs(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateJobsOperationsClient,
                callSettings);

    }

    /// <summary>
    /// JobService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class JobServiceClientImpl : JobServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateJobRequest, Job> _callCreateJob;
        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;
        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;
        private readonly gaxgrpc::ApiCall<DeleteJobRequest, pbwkt::Empty> _callDeleteJob;
        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;
        private readonly gaxgrpc::ApiCall<BatchDeleteJobsRequest, pbwkt::Empty> _callBatchDeleteJobs;
        private readonly gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> _callSearchJobs;
        private readonly gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> _callSearchJobsForAlert;
        private readonly gaxgrpc::ApiCall<BatchCreateJobsRequest, lro::Operation> _callBatchCreateJobs;
        private readonly gaxgrpc::ApiCall<BatchUpdateJobsRequest, lro::Operation> _callBatchUpdateJobs;

        /// <summary>
        /// Constructs a client wrapper for the JobService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobServiceSettings"/> used within this client </param>
        public JobServiceClientImpl(JobService.JobServiceClient grpcClient, JobServiceSettings settings)
        {
            GrpcClient = grpcClient;
            JobServiceSettings effectiveSettings = settings ?? JobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchCreateJobsOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateJobsOperationsSettings);
            BatchUpdateJobsOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateJobsOperationsSettings);
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, Job>(
                GrpcClient.CreateJobAsync, GrpcClient.CreateJob, effectiveSettings.CreateJobSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>(
                GrpcClient.GetJobAsync, GrpcClient.GetJob, effectiveSettings.GetJobSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>(
                GrpcClient.UpdateJobAsync, GrpcClient.UpdateJob, effectiveSettings.UpdateJobSettings)
                .WithGoogleRequestParam("job.name", request => request.Job?.Name);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, pbwkt::Empty>(
                GrpcClient.DeleteJobAsync, GrpcClient.DeleteJob, effectiveSettings.DeleteJobSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>(
                GrpcClient.ListJobsAsync, GrpcClient.ListJobs, effectiveSettings.ListJobsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchDeleteJobs = clientHelper.BuildApiCall<BatchDeleteJobsRequest, pbwkt::Empty>(
                GrpcClient.BatchDeleteJobsAsync, GrpcClient.BatchDeleteJobs, effectiveSettings.BatchDeleteJobsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callSearchJobs = clientHelper.BuildApiCall<SearchJobsRequest, SearchJobsResponse>(
                GrpcClient.SearchJobsAsync, GrpcClient.SearchJobs, effectiveSettings.SearchJobsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callSearchJobsForAlert = clientHelper.BuildApiCall<SearchJobsRequest, SearchJobsResponse>(
                GrpcClient.SearchJobsForAlertAsync, GrpcClient.SearchJobsForAlert, effectiveSettings.SearchJobsForAlertSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchCreateJobs = clientHelper.BuildApiCall<BatchCreateJobsRequest, lro::Operation>(
                GrpcClient.BatchCreateJobsAsync, GrpcClient.BatchCreateJobs, effectiveSettings.BatchCreateJobsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchUpdateJobs = clientHelper.BuildApiCall<BatchUpdateJobsRequest, lro::Operation>(
                GrpcClient.BatchUpdateJobsAsync, GrpcClient.BatchUpdateJobs, effectiveSettings.BatchUpdateJobsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            Modify_ApiCall(ref _callBatchDeleteJobs);
            Modify_BatchDeleteJobsApiCall(ref _callBatchDeleteJobs);
            Modify_ApiCall(ref _callSearchJobs);
            Modify_SearchJobsApiCall(ref _callSearchJobs);
            Modify_ApiCall(ref _callSearchJobsForAlert);
            Modify_SearchJobsForAlertApiCall(ref _callSearchJobsForAlert);
            Modify_ApiCall(ref _callBatchCreateJobs);
            Modify_BatchCreateJobsApiCall(ref _callBatchCreateJobs);
            Modify_ApiCall(ref _callBatchUpdateJobs);
            Modify_BatchUpdateJobsApiCall(ref _callBatchUpdateJobs);
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
        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, Job> call);
        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);
        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);
        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, pbwkt::Empty> call);
        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);
        partial void Modify_BatchDeleteJobsApiCall(ref gaxgrpc::ApiCall<BatchDeleteJobsRequest, pbwkt::Empty> call);
        partial void Modify_SearchJobsApiCall(ref gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> call);
        partial void Modify_SearchJobsForAlertApiCall(ref gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> call);
        partial void Modify_BatchCreateJobsApiCall(ref gaxgrpc::ApiCall<BatchCreateJobsRequest, lro::Operation> call);
        partial void Modify_BatchUpdateJobsApiCall(ref gaxgrpc::ApiCall<BatchUpdateJobsRequest, lro::Operation> call);
        partial void OnConstruction(JobService.JobServiceClient grpcClient, JobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC JobService client.
        /// </summary>
        public override JobService.JobServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchDeleteJobsRequest(ref BatchDeleteJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchJobsRequest(ref SearchJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateJobsRequest(ref BatchCreateJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchUpdateJobsRequest(ref BatchUpdateJobsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        public override stt::Task<Job> CreateJobAsync(
            CreateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return _callCreateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new job.
        ///
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        public override Job CreateJob(
            CreateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return _callCreateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
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
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
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
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
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
        /// Updates specified job.
        ///
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
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
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        /// Deletes the specified job.
        ///
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
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

        /// <summary>
        /// Lists jobs by filter.
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
        /// Lists jobs by filter.
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
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
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
        public override stt::Task BatchDeleteJobsAsync(
            BatchDeleteJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteJobsRequest(ref request, ref callSettings);
            return _callBatchDeleteJobs.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void BatchDeleteJobs(
            BatchDeleteJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteJobsRequest(ref request, ref callSettings);
            _callBatchDeleteJobs.Sync(request, callSettings);
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsAsync(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchJobsRequest, SearchJobsResponse, SearchJobsResponse.Types.MatchingJob>(_callSearchJobs, request, callSettings);
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobs(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchJobsRequest, SearchJobsResponse, SearchJobsResponse.Types.MatchingJob>(_callSearchJobs, request, callSettings);
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlertAsync(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchJobsRequest, SearchJobsResponse, SearchJobsResponse.Types.MatchingJob>(_callSearchJobsForAlert, request, callSettings);
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        ///
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        ///
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlert(
            SearchJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchJobsRequest, SearchJobsResponse, SearchJobsResponse.Types.MatchingJob>(_callSearchJobsForAlert, request, callSettings);
        }

        /// <summary>
        /// Begins executing a batch create jobs operation.
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
        public override async stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(
            BatchCreateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(
                await _callBatchCreateJobs.Async(request, callSettings).ConfigureAwait(false), BatchCreateJobsOperationsClient);
        }

        /// <summary>
        /// Begins executing a batch create jobs operation.
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
        public override lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(
            BatchCreateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(
                _callBatchCreateJobs.Sync(request, callSettings), BatchCreateJobsOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchCreateJobs</c>.
        /// </summary>
        public override lro::OperationsClient BatchCreateJobsOperationsClient { get; }

        /// <summary>
        /// Begins executing a batch update jobs operation.
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
        public override async stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(
            BatchUpdateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(
                await _callBatchUpdateJobs.Async(request, callSettings).ConfigureAwait(false), BatchUpdateJobsOperationsClient);
        }

        /// <summary>
        /// Begins executing a batch update jobs operation.
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
        public override lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(
            BatchUpdateJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(
                _callBatchUpdateJobs.Sync(request, callSettings), BatchUpdateJobsOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateJobs</c>.
        /// </summary>
        public override lro::OperationsClient BatchUpdateJobsOperationsClient { get; }

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

    public partial class SearchJobsRequest : gaxgrpc::IPageRequest { }
    public partial class SearchJobsResponse : gaxgrpc::IPageResponse<SearchJobsResponse.Types.MatchingJob>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<SearchJobsResponse.Types.MatchingJob> GetEnumerator() => MatchingJobs.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class JobService
    {
        public partial class JobServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
