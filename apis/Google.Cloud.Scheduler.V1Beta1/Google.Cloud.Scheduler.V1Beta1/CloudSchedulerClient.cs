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

namespace Google.Cloud.Scheduler.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="CloudSchedulerClient"/>.
    /// </summary>
    public sealed partial class CloudSchedulerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CloudSchedulerSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CloudSchedulerSettings"/>.
        /// </returns>
        public static CloudSchedulerSettings GetDefault() => new CloudSchedulerSettings();

        /// <summary>
        /// Constructs a new <see cref="CloudSchedulerSettings"/> object with default settings.
        /// </summary>
        public CloudSchedulerSettings() { }

        private CloudSchedulerSettings(CloudSchedulerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListJobsSettings = existing.ListJobsSettings;
            GetJobSettings = existing.GetJobSettings;
            CreateJobSettings = existing.CreateJobSettings;
            UpdateJobSettings = existing.UpdateJobSettings;
            DeleteJobSettings = existing.DeleteJobSettings;
            PauseJobSettings = existing.PauseJobSettings;
            ResumeJobSettings = existing.ResumeJobSettings;
            RunJobSettings = existing.RunJobSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudSchedulerSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CloudSchedulerClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="CloudSchedulerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CloudSchedulerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CloudSchedulerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CloudSchedulerClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="CloudSchedulerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CloudSchedulerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CloudSchedulerClient"/> RPC methods is defined as:
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
        /// <c>CloudSchedulerClient.ListJobs</c> and <c>CloudSchedulerClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.ListJobs</c> and
        /// <c>CloudSchedulerClient.ListJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>CloudSchedulerClient.GetJob</c> and <c>CloudSchedulerClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.GetJob</c> and
        /// <c>CloudSchedulerClient.GetJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>CloudSchedulerClient.CreateJob</c> and <c>CloudSchedulerClient.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.CreateJob</c> and
        /// <c>CloudSchedulerClient.CreateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>CloudSchedulerClient.UpdateJob</c> and <c>CloudSchedulerClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.UpdateJob</c> and
        /// <c>CloudSchedulerClient.UpdateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>CloudSchedulerClient.DeleteJob</c> and <c>CloudSchedulerClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.DeleteJob</c> and
        /// <c>CloudSchedulerClient.DeleteJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>CloudSchedulerClient.PauseJob</c> and <c>CloudSchedulerClient.PauseJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.PauseJob</c> and
        /// <c>CloudSchedulerClient.PauseJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings PauseJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.ResumeJob</c> and <c>CloudSchedulerClient.ResumeJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.ResumeJob</c> and
        /// <c>CloudSchedulerClient.ResumeJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ResumeJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.RunJob</c> and <c>CloudSchedulerClient.RunJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CloudSchedulerClient.RunJob</c> and
        /// <c>CloudSchedulerClient.RunJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RunJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CloudSchedulerSettings"/> object.</returns>
        public CloudSchedulerSettings Clone() => new CloudSchedulerSettings(this);
    }

    /// <summary>
    /// CloudScheduler client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CloudSchedulerClient
    {
        /// <summary>
        /// The default endpoint for the CloudScheduler service, which is a host of "cloudscheduler.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("cloudscheduler.googleapis.com", 443);

        /// <summary>
        /// The default CloudScheduler scopes.
        /// </summary>
        /// <remarks>
        /// The default CloudScheduler scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudSchedulerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Scheduler.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CloudSchedulerClient client = await CloudSchedulerClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Scheduler.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CloudSchedulerClient.DefaultEndpoint.Host, CloudSchedulerClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CloudSchedulerClient client = CloudSchedulerClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CloudSchedulerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CloudSchedulerClient"/>.</returns>
        public static async stt::Task<CloudSchedulerClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CloudSchedulerSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CloudSchedulerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Scheduler.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CloudSchedulerClient client = CloudSchedulerClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Scheduler.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CloudSchedulerClient.DefaultEndpoint.Host, CloudSchedulerClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CloudSchedulerClient client = CloudSchedulerClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CloudSchedulerSettings"/>.</param>
        /// <returns>The created <see cref="CloudSchedulerClient"/>.</returns>
        public static CloudSchedulerClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CloudSchedulerSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CloudSchedulerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CloudSchedulerSettings"/>.</param>
        /// <returns>The created <see cref="CloudSchedulerClient"/>.</returns>
        public static CloudSchedulerClient Create(grpccore::Channel channel, CloudSchedulerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CloudSchedulerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CloudSchedulerSettings"/>.</param>
        /// <returns>The created <see cref="CloudSchedulerClient"/>.</returns>
        public static CloudSchedulerClient Create(grpccore::CallInvoker callInvoker, CloudSchedulerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudScheduler.CloudSchedulerClient grpcClient = new CloudScheduler.CloudSchedulerClient(callInvoker);
            return new CloudSchedulerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CloudSchedulerSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CloudSchedulerSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CloudSchedulerSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CloudSchedulerSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CloudScheduler client.
        /// </summary>
        public virtual CloudScheduler.CloudSchedulerClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
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
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobsAsync(
                new ListJobsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
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
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListJobs(
                new ListJobsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists jobs.
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
        /// Lists jobs.
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
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => GetJobAsync(
                new GetJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> GetJobAsync(
            JobName name,
            st::CancellationToken cancellationToken) => GetJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job GetJob(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => GetJob(
                new GetJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a job.
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
        /// Gets a job.
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
        /// Gets a job.
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
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required.
        ///
        /// The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1beta1.Job.name]. [name][google.cloud.scheduler.v1beta1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1beta1.Job.name]) in the response.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CreateJobAsync(
            LocationName parent,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => CreateJobAsync(
                new CreateJobRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required.
        ///
        /// The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1beta1.Job.name]. [name][google.cloud.scheduler.v1beta1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1beta1.Job.name]) in the response.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> CreateJobAsync(
            LocationName parent,
            Job job,
            st::CancellationToken cancellationToken) => CreateJobAsync(
                parent,
                job,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required.
        ///
        /// The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1beta1.Job.name]. [name][google.cloud.scheduler.v1beta1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1beta1.Job.name]) in the response.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job CreateJob(
            LocationName parent,
            Job job,
            gaxgrpc::CallSettings callSettings = null) => CreateJob(
                new CreateJobRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates a job.
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
        /// Creates a job.
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
        /// Creates a job.
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
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
        /// </summary>
        /// <param name="job">
        /// Required.
        ///
        /// The new job properties. [name][google.cloud.scheduler.v1beta1.Job.name] must be specified.
        ///
        /// Output only fields cannot be modified using UpdateJob.
        /// Any value specified for an output only field will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// A  mask used to specify which fields of the job are being updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> UpdateJobAsync(
            Job job,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateJobAsync(
                new UpdateJobRequest
                {
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
        /// </summary>
        /// <param name="job">
        /// Required.
        ///
        /// The new job properties. [name][google.cloud.scheduler.v1beta1.Job.name] must be specified.
        ///
        /// Output only fields cannot be modified using UpdateJob.
        /// Any value specified for an output only field will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// A  mask used to specify which fields of the job are being updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> UpdateJobAsync(
            Job job,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateJobAsync(
                job,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
        /// </summary>
        /// <param name="job">
        /// Required.
        ///
        /// The new job properties. [name][google.cloud.scheduler.v1beta1.Job.name] must be specified.
        ///
        /// Output only fields cannot be modified using UpdateJob.
        /// Any value specified for an output only field will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// A  mask used to specify which fields of the job are being updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job UpdateJob(
            Job job,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateJob(
                new UpdateJobRequest
                {
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
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
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
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
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
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
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteJobAsync(
                new DeleteJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteJobAsync(
            JobName name,
            st::CancellationToken cancellationToken) => DeleteJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteJob(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteJob(
                new DeleteJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a job.
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
        /// Deletes a job.
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
        /// Deletes a job.
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
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> PauseJobAsync(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => PauseJobAsync(
                new PauseJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> PauseJobAsync(
            JobName name,
            st::CancellationToken cancellationToken) => PauseJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job PauseJob(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => PauseJob(
                new PauseJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
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
        public virtual stt::Task<Job> PauseJobAsync(
            PauseJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
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
        public virtual stt::Task<Job> PauseJobAsync(
            PauseJobRequest request,
            st::CancellationToken cancellationToken) => PauseJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
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
        public virtual Job PauseJob(
            PauseJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> ResumeJobAsync(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => ResumeJobAsync(
                new ResumeJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> ResumeJobAsync(
            JobName name,
            st::CancellationToken cancellationToken) => ResumeJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job ResumeJob(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => ResumeJob(
                new ResumeJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
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
        public virtual stt::Task<Job> ResumeJobAsync(
            ResumeJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
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
        public virtual stt::Task<Job> ResumeJobAsync(
            ResumeJobRequest request,
            st::CancellationToken cancellationToken) => ResumeJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
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
        public virtual Job ResumeJob(
            ResumeJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> RunJobAsync(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => RunJobAsync(
                new RunJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Job> RunJobAsync(
            JobName name,
            st::CancellationToken cancellationToken) => RunJobAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Job RunJob(
            JobName name,
            gaxgrpc::CallSettings callSettings = null) => RunJob(
                new RunJobRequest
                {
                    JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
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
        public virtual stt::Task<Job> RunJobAsync(
            RunJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
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
        public virtual stt::Task<Job> RunJobAsync(
            RunJobRequest request,
            st::CancellationToken cancellationToken) => RunJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
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
        public virtual Job RunJob(
            RunJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CloudScheduler client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CloudSchedulerClientImpl : CloudSchedulerClient
    {
        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;
        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;
        private readonly gaxgrpc::ApiCall<CreateJobRequest, Job> _callCreateJob;
        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;
        private readonly gaxgrpc::ApiCall<DeleteJobRequest, pbwkt::Empty> _callDeleteJob;
        private readonly gaxgrpc::ApiCall<PauseJobRequest, Job> _callPauseJob;
        private readonly gaxgrpc::ApiCall<ResumeJobRequest, Job> _callResumeJob;
        private readonly gaxgrpc::ApiCall<RunJobRequest, Job> _callRunJob;

        /// <summary>
        /// Constructs a client wrapper for the CloudScheduler service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudSchedulerSettings"/> used within this client </param>
        public CloudSchedulerClientImpl(CloudScheduler.CloudSchedulerClient grpcClient, CloudSchedulerSettings settings)
        {
            GrpcClient = grpcClient;
            CloudSchedulerSettings effectiveSettings = settings ?? CloudSchedulerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>(
                GrpcClient.ListJobsAsync, GrpcClient.ListJobs, effectiveSettings.ListJobsSettings);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>(
                GrpcClient.GetJobAsync, GrpcClient.GetJob, effectiveSettings.GetJobSettings);
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, Job>(
                GrpcClient.CreateJobAsync, GrpcClient.CreateJob, effectiveSettings.CreateJobSettings);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>(
                GrpcClient.UpdateJobAsync, GrpcClient.UpdateJob, effectiveSettings.UpdateJobSettings);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, pbwkt::Empty>(
                GrpcClient.DeleteJobAsync, GrpcClient.DeleteJob, effectiveSettings.DeleteJobSettings);
            _callPauseJob = clientHelper.BuildApiCall<PauseJobRequest, Job>(
                GrpcClient.PauseJobAsync, GrpcClient.PauseJob, effectiveSettings.PauseJobSettings);
            _callResumeJob = clientHelper.BuildApiCall<ResumeJobRequest, Job>(
                GrpcClient.ResumeJobAsync, GrpcClient.ResumeJob, effectiveSettings.ResumeJobSettings);
            _callRunJob = clientHelper.BuildApiCall<RunJobRequest, Job>(
                GrpcClient.RunJobAsync, GrpcClient.RunJob, effectiveSettings.RunJobSettings);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            Modify_ApiCall(ref _callPauseJob);
            Modify_PauseJobApiCall(ref _callPauseJob);
            Modify_ApiCall(ref _callResumeJob);
            Modify_ResumeJobApiCall(ref _callResumeJob);
            Modify_ApiCall(ref _callRunJob);
            Modify_RunJobApiCall(ref _callRunJob);
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
        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);
        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);
        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, Job> call);
        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);
        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, pbwkt::Empty> call);
        partial void Modify_PauseJobApiCall(ref gaxgrpc::ApiCall<PauseJobRequest, Job> call);
        partial void Modify_ResumeJobApiCall(ref gaxgrpc::ApiCall<ResumeJobRequest, Job> call);
        partial void Modify_RunJobApiCall(ref gaxgrpc::ApiCall<RunJobRequest, Job> call);
        partial void OnConstruction(CloudScheduler.CloudSchedulerClient grpcClient, CloudSchedulerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CloudScheduler client.
        /// </summary>
        public override CloudScheduler.CloudSchedulerClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PauseJobRequest(ref PauseJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ResumeJobRequest(ref ResumeJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RunJobRequest(ref RunJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists jobs.
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
        /// Lists jobs.
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
        /// Gets a job.
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
        /// Gets a job.
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
        /// Creates a job.
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
        /// Creates a job.
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
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
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
        /// Updates a job.
        ///
        /// If successful, the updated [Job][google.cloud.scheduler.v1beta1.Job] is returned. If the job does
        /// not exist, `NOT_FOUND` is returned.
        ///
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1beta1.Job.State.UPDATE_FAILED] state. A job in this state may
        /// not be executed. If this happens, retry the UpdateJob request
        /// until a successful response is received.
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
        /// Deletes a job.
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
        /// Deletes a job.
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
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
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
        public override stt::Task<Job> PauseJobAsync(
            PauseJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseJobRequest(ref request, ref callSettings);
            return _callPauseJob.Async(request, callSettings);
        }

        /// <summary>
        /// Pauses a job.
        ///
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via [ResumeJob][google.cloud.scheduler.v1beta1.CloudScheduler.ResumeJob]. The
        /// state of the job is stored in [state][google.cloud.scheduler.v1beta1.Job.state]; if paused it
        /// will be set to [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. A job must be in [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]
        /// to be paused.
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
        public override Job PauseJob(
            PauseJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseJobRequest(ref request, ref callSettings);
            return _callPauseJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
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
        public override stt::Task<Job> ResumeJobAsync(
            ResumeJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeJobRequest(ref request, ref callSettings);
            return _callResumeJob.Async(request, callSettings);
        }

        /// <summary>
        /// Resume a job.
        ///
        /// This method reenables a job after it has been [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED]. The
        /// state of a job is stored in [Job.state][google.cloud.scheduler.v1beta1.Job.state]; after calling this method it
        /// will be set to [Job.State.ENABLED][google.cloud.scheduler.v1beta1.Job.State.ENABLED]. A job must be in
        /// [Job.State.PAUSED][google.cloud.scheduler.v1beta1.Job.State.PAUSED] to be resumed.
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
        public override Job ResumeJob(
            ResumeJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeJobRequest(ref request, ref callSettings);
            return _callResumeJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
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
        public override stt::Task<Job> RunJobAsync(
            RunJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunJobRequest(ref request, ref callSettings);
            return _callRunJob.Async(request, callSettings);
        }

        /// <summary>
        /// Forces a job to run now.
        ///
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
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
        public override Job RunJob(
            RunJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunJobRequest(ref request, ref callSettings);
            return _callRunJob.Sync(request, callSettings);
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
