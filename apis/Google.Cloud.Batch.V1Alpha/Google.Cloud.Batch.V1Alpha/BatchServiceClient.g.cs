// Copyright 2024 Google LLC
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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Batch.V1Alpha
{
    /// <summary>Settings for <see cref="BatchServiceClient"/> instances.</summary>
    public sealed partial class BatchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BatchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BatchServiceSettings"/>.</returns>
        public static BatchServiceSettings GetDefault() => new BatchServiceSettings();

        /// <summary>Constructs a new <see cref="BatchServiceSettings"/> object with default settings.</summary>
        public BatchServiceSettings()
        {
        }

        private BatchServiceSettings(BatchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateJobSettings = existing.CreateJobSettings;
            GetJobSettings = existing.GetJobSettings;
            DeleteJobSettings = existing.DeleteJobSettings;
            DeleteJobOperationsSettings = existing.DeleteJobOperationsSettings.Clone();
            CancelJobSettings = existing.CancelJobSettings;
            CancelJobOperationsSettings = existing.CancelJobOperationsSettings.Clone();
            UpdateJobSettings = existing.UpdateJobSettings;
            ListJobsSettings = existing.ListJobsSettings;
            GetTaskSettings = existing.GetTaskSettings;
            ListTasksSettings = existing.ListTasksSettings;
            CreateResourceAllowanceSettings = existing.CreateResourceAllowanceSettings;
            GetResourceAllowanceSettings = existing.GetResourceAllowanceSettings;
            DeleteResourceAllowanceSettings = existing.DeleteResourceAllowanceSettings;
            DeleteResourceAllowanceOperationsSettings = existing.DeleteResourceAllowanceOperationsSettings.Clone();
            ListResourceAllowancesSettings = existing.ListResourceAllowancesSettings;
            UpdateResourceAllowanceSettings = existing.UpdateResourceAllowanceSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BatchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.CreateJob</c> and <c>BatchServiceClient.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BatchServiceClient.GetJob</c>
        ///  and <c>BatchServiceClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.DeleteJob</c> and <c>BatchServiceClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BatchServiceClient.DeleteJob</c> and
        /// <c>BatchServiceClient.DeleteJobAsync</c>.
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
        public lro::OperationsSettings DeleteJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.CancelJob</c> and <c>BatchServiceClient.CancelJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BatchServiceClient.CancelJob</c> and
        /// <c>BatchServiceClient.CancelJobAsync</c>.
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
        public lro::OperationsSettings CancelJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.UpdateJob</c> and <c>BatchServiceClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BatchServiceClient.ListJobs</c>
        ///  and <c>BatchServiceClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BatchServiceClient.GetTask</c>
        ///  and <c>BatchServiceClient.GetTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.ListTasks</c> and <c>BatchServiceClient.ListTasksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTasksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.CreateResourceAllowance</c> and <c>BatchServiceClient.CreateResourceAllowanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateResourceAllowanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.GetResourceAllowance</c> and <c>BatchServiceClient.GetResourceAllowanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetResourceAllowanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.DeleteResourceAllowance</c> and <c>BatchServiceClient.DeleteResourceAllowanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteResourceAllowanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BatchServiceClient.DeleteResourceAllowance</c> and
        /// <c>BatchServiceClient.DeleteResourceAllowanceAsync</c>.
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
        public lro::OperationsSettings DeleteResourceAllowanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.ListResourceAllowances</c> and <c>BatchServiceClient.ListResourceAllowancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListResourceAllowancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchServiceClient.UpdateResourceAllowance</c> and <c>BatchServiceClient.UpdateResourceAllowanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateResourceAllowanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BatchServiceSettings"/> object.</returns>
        public BatchServiceSettings Clone() => new BatchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BatchServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BatchServiceClientBuilder : gaxgrpc::ClientBuilderBase<BatchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BatchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BatchServiceClientBuilder() : base(BatchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BatchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BatchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BatchServiceClient Build()
        {
            BatchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BatchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BatchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BatchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BatchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BatchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BatchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BatchServiceClient.ChannelPool;
    }

    /// <summary>BatchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Batch Service.
    /// The service manages user submitted batch jobs and allocates Google Compute
    /// Engine VM instances to run the jobs.
    /// </remarks>
    public abstract partial class BatchServiceClient
    {
        /// <summary>
        /// The default endpoint for the BatchService service, which is a host of "batch.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "batch.googleapis.com:443";

        /// <summary>The default BatchService scopes.</summary>
        /// <remarks>
        /// The default BatchService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BatchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BatchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BatchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BatchServiceClient"/>.</returns>
        public static stt::Task<BatchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BatchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BatchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BatchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BatchServiceClient"/>.</returns>
        public static BatchServiceClient Create() => new BatchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BatchServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BatchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BatchServiceClient"/>.</returns>
        internal static BatchServiceClient Create(grpccore::CallInvoker callInvoker, BatchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BatchService.BatchServiceClient grpcClient = new BatchService.BatchServiceClient(callInvoker);
            return new BatchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BatchService client</summary>
        public virtual BatchService.BatchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, st::CancellationToken cancellationToken) =>
            CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the Job will be created.
        /// Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="job">
        /// Required. The Job to create.
        /// </param>
        /// <param name="jobId">
        /// ID used to uniquely identify the Job within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The job.name field in the request will be ignored and the created resource
        /// name of the Job will be "{parent}/jobs/{job_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(string parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                JobId = jobId ?? "",
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the Job will be created.
        /// Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="job">
        /// Required. The Job to create.
        /// </param>
        /// <param name="jobId">
        /// ID used to uniquely identify the Job within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The job.name field in the request will be ignored and the created resource
        /// name of the Job will be "{parent}/jobs/{job_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(string parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                JobId = jobId ?? "",
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the Job will be created.
        /// Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="job">
        /// Required. The Job to create.
        /// </param>
        /// <param name="jobId">
        /// ID used to uniquely identify the Job within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The job.name field in the request will be ignored and the created resource
        /// name of the Job will be "{parent}/jobs/{job_id}".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(string parent, Job job, string jobId, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the Job will be created.
        /// Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="job">
        /// Required. The Job to create.
        /// </param>
        /// <param name="jobId">
        /// ID used to uniquely identify the Job within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The job.name field in the request will be ignored and the created resource
        /// name of the Job will be "{parent}/jobs/{job_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(gagr::LocationName parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobId = jobId ?? "",
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the Job will be created.
        /// Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="job">
        /// Required. The Job to create.
        /// </param>
        /// <param name="jobId">
        /// ID used to uniquely identify the Job within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The job.name field in the request will be ignored and the created resource
        /// name of the Job will be "{parent}/jobs/{job_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(gagr::LocationName parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobId = jobId ?? "",
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the Job will be created.
        /// Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="job">
        /// Required. The Job to create.
        /// </param>
        /// <param name="jobId">
        /// ID used to uniquely identify the Job within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The job.name field in the request will be ignored and the created resource
        /// name of the Job will be "{parent}/jobs/{job_id}".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(gagr::LocationName parent, Job job, string jobId, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteJobAsync(DeleteJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteJob</c>.</summary>
        public virtual lro::OperationsClient DeleteJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteJobOperationsClient, callSettings);

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="name">
        /// Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="name">
        /// Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="name">
        /// Job name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelJobResponse, OperationMetadata> CancelJob(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> CancelJobAsync(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> CancelJobAsync(CancelJobRequest request, st::CancellationToken cancellationToken) =>
            CancelJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CancelJob</c>.</summary>
        public virtual lro::OperationsClient CancelJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CancelJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CancelJobResponse, OperationMetadata> PollOnceCancelJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CancelJobResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CancelJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> PollOnceCancelJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CancelJobResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelJobOperationsClient, callSettings);

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelJobResponse, OperationMetadata> CancelJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJob(new CancelJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> CancelJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJobAsync(new CancelJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> CancelJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelJobResponse, OperationMetadata> CancelJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJob(new CancelJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> CancelJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelJobAsync(new CancelJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="name">
        /// Required. Job name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> CancelJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            CancelJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Job.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to update.
        /// Only fields specified in `updateMask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// The `jobs.patch` method can only be used while a job is in the `QUEUED`,
        /// `SCHEDULED`, or `RUNNING` state and currently only supports increasing the
        /// value of the first `taskCount` field in the job's `taskGroups` field.
        /// Therefore, you must set the value of `updateMask` to `taskGroups`. Any
        /// other job fields in the update request will be ignored.
        /// 
        /// For example, to update a job's `taskCount` to `2`, set `updateMask` to
        /// `taskGroups` and use the following request body:
        /// ```
        /// {
        /// "taskGroups":[{
        /// "taskCount": 2
        /// }]
        /// }
        /// ```
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(Job job, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJob(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a Job.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to update.
        /// Only fields specified in `updateMask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// The `jobs.patch` method can only be used while a job is in the `QUEUED`,
        /// `SCHEDULED`, or `RUNNING` state and currently only supports increasing the
        /// value of the first `taskCount` field in the job's `taskGroups` field.
        /// Therefore, you must set the value of `updateMask` to `taskGroups`. Any
        /// other job fields in the update request will be ignored.
        /// 
        /// For example, to update a job's `taskCount` to `2`, set `updateMask` to
        /// `taskGroups` and use the following request body:
        /// ```
        /// {
        /// "taskGroups":[{
        /// "taskCount": 2
        /// }]
        /// }
        /// ```
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(Job job, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobAsync(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a Job.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to update.
        /// Only fields specified in `updateMask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// The `jobs.patch` method can only be used while a job is in the `QUEUED`,
        /// `SCHEDULED`, or `RUNNING` state and currently only supports increasing the
        /// value of the first `taskCount` field in the job's `taskGroups` field.
        /// Therefore, you must set the value of `updateMask` to `taskGroups`. Any
        /// other job fields in the update request will be ignored.
        /// 
        /// For example, to update a job's `taskCount` to `2`, set `updateMask` to
        /// `taskGroups` and use the following request body:
        /// ```
        /// {
        /// "taskGroups":[{
        /// "taskCount": 2
        /// }]
        /// }
        /// ```
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(Job job, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(job, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all Jobs for a project within a region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all Jobs for a project within a region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all Jobs for a project within a region.
        /// </summary>
        /// <param name="parent">
        /// Parent path.
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
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobs(request, callSettings);
        }

        /// <summary>
        /// List all Jobs for a project within a region.
        /// </summary>
        /// <param name="parent">
        /// Parent path.
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
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, st::CancellationToken cancellationToken) =>
            GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="name">
        /// Required. Task name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="name">
        /// Required. Task name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="name">
        /// Required. Task name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="name">
        /// Required. Task name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="name">
        /// Required. Task name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="name">
        /// Required. Task name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a TaskGroup from which Tasks are being requested.
        /// Pattern:
        /// "projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}"
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasks(request, callSettings);
        }

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a TaskGroup from which Tasks are being requested.
        /// Pattern:
        /// "projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasksAsync(request, callSettings);
        }

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a TaskGroup from which Tasks are being requested.
        /// Pattern:
        /// "projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}"
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(TaskGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsTaskGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasks(request, callSettings);
        }

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of a TaskGroup from which Tasks are being requested.
        /// Pattern:
        /// "projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(TaskGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsTaskGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasksAsync(request, callSettings);
        }

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance CreateResourceAllowance(CreateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> CreateResourceAllowanceAsync(CreateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> CreateResourceAllowanceAsync(CreateResourceAllowanceRequest request, st::CancellationToken cancellationToken) =>
            CreateResourceAllowanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the ResourceAllowance will be
        /// created. Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to create.
        /// </param>
        /// <param name="resourceAllowanceId">
        /// ID used to uniquely identify the ResourceAllowance within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The resource_allowance.name field in the request will be ignored and the
        /// created resource name of the ResourceAllowance will be
        /// "{parent}/resourceAllowances/{resource_allowance_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance CreateResourceAllowance(string parent, ResourceAllowance resourceAllowance, string resourceAllowanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceAllowance(new CreateResourceAllowanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ResourceAllowanceId = resourceAllowanceId ?? "",
                ResourceAllowance = gax::GaxPreconditions.CheckNotNull(resourceAllowance, nameof(resourceAllowance)),
            }, callSettings);

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the ResourceAllowance will be
        /// created. Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to create.
        /// </param>
        /// <param name="resourceAllowanceId">
        /// ID used to uniquely identify the ResourceAllowance within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The resource_allowance.name field in the request will be ignored and the
        /// created resource name of the ResourceAllowance will be
        /// "{parent}/resourceAllowances/{resource_allowance_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> CreateResourceAllowanceAsync(string parent, ResourceAllowance resourceAllowance, string resourceAllowanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceAllowanceAsync(new CreateResourceAllowanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ResourceAllowanceId = resourceAllowanceId ?? "",
                ResourceAllowance = gax::GaxPreconditions.CheckNotNull(resourceAllowance, nameof(resourceAllowance)),
            }, callSettings);

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the ResourceAllowance will be
        /// created. Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to create.
        /// </param>
        /// <param name="resourceAllowanceId">
        /// ID used to uniquely identify the ResourceAllowance within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The resource_allowance.name field in the request will be ignored and the
        /// created resource name of the ResourceAllowance will be
        /// "{parent}/resourceAllowances/{resource_allowance_id}".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> CreateResourceAllowanceAsync(string parent, ResourceAllowance resourceAllowance, string resourceAllowanceId, st::CancellationToken cancellationToken) =>
            CreateResourceAllowanceAsync(parent, resourceAllowance, resourceAllowanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the ResourceAllowance will be
        /// created. Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to create.
        /// </param>
        /// <param name="resourceAllowanceId">
        /// ID used to uniquely identify the ResourceAllowance within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The resource_allowance.name field in the request will be ignored and the
        /// created resource name of the ResourceAllowance will be
        /// "{parent}/resourceAllowances/{resource_allowance_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance CreateResourceAllowance(gagr::LocationName parent, ResourceAllowance resourceAllowance, string resourceAllowanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceAllowance(new CreateResourceAllowanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ResourceAllowanceId = resourceAllowanceId ?? "",
                ResourceAllowance = gax::GaxPreconditions.CheckNotNull(resourceAllowance, nameof(resourceAllowance)),
            }, callSettings);

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the ResourceAllowance will be
        /// created. Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to create.
        /// </param>
        /// <param name="resourceAllowanceId">
        /// ID used to uniquely identify the ResourceAllowance within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The resource_allowance.name field in the request will be ignored and the
        /// created resource name of the ResourceAllowance will be
        /// "{parent}/resourceAllowances/{resource_allowance_id}".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> CreateResourceAllowanceAsync(gagr::LocationName parent, ResourceAllowance resourceAllowance, string resourceAllowanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceAllowanceAsync(new CreateResourceAllowanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ResourceAllowanceId = resourceAllowanceId ?? "",
                ResourceAllowance = gax::GaxPreconditions.CheckNotNull(resourceAllowance, nameof(resourceAllowance)),
            }, callSettings);

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the ResourceAllowance will be
        /// created. Pattern: "projects/{project}/locations/{location}"
        /// </param>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to create.
        /// </param>
        /// <param name="resourceAllowanceId">
        /// ID used to uniquely identify the ResourceAllowance within its parent scope.
        /// This field should contain at most 63 characters and must start with
        /// lowercase characters.
        /// Only lowercase characters, numbers and '-' are accepted.
        /// The '-' character cannot be the first or the last one.
        /// A system generated ID will be used if the field is not set.
        /// 
        /// The resource_allowance.name field in the request will be ignored and the
        /// created resource name of the ResourceAllowance will be
        /// "{parent}/resourceAllowances/{resource_allowance_id}".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> CreateResourceAllowanceAsync(gagr::LocationName parent, ResourceAllowance resourceAllowance, string resourceAllowanceId, st::CancellationToken cancellationToken) =>
            CreateResourceAllowanceAsync(parent, resourceAllowance, resourceAllowanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance GetResourceAllowance(GetResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> GetResourceAllowanceAsync(GetResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> GetResourceAllowanceAsync(GetResourceAllowanceRequest request, st::CancellationToken cancellationToken) =>
            GetResourceAllowanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance GetResourceAllowance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceAllowance(new GetResourceAllowanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> GetResourceAllowanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceAllowanceAsync(new GetResourceAllowanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> GetResourceAllowanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetResourceAllowanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance GetResourceAllowance(ResourceAllowanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceAllowance(new GetResourceAllowanceRequest
            {
                ResourceAllowanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> GetResourceAllowanceAsync(ResourceAllowanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceAllowanceAsync(new GetResourceAllowanceRequest
            {
                ResourceAllowanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> GetResourceAllowanceAsync(ResourceAllowanceName name, st::CancellationToken cancellationToken) =>
            GetResourceAllowanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceAllowance(DeleteResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceAllowanceAsync(DeleteResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceAllowanceAsync(DeleteResourceAllowanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteResourceAllowanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteResourceAllowance</c>.</summary>
        public virtual lro::OperationsClient DeleteResourceAllowanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteResourceAllowance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteResourceAllowance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteResourceAllowanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteResourceAllowance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteResourceAllowanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteResourceAllowanceOperationsClient, callSettings);

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceAllowance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceAllowance(new DeleteResourceAllowanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceAllowanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceAllowanceAsync(new DeleteResourceAllowanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceAllowanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteResourceAllowanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceAllowance(ResourceAllowanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceAllowance(new DeleteResourceAllowanceRequest
            {
                ResourceAllowanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceAllowanceAsync(ResourceAllowanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceAllowanceAsync(new DeleteResourceAllowanceRequest
            {
                ResourceAllowanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="name">
        /// Required. ResourceAllowance name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceAllowanceAsync(ResourceAllowanceName name, st::CancellationToken cancellationToken) =>
            DeleteResourceAllowanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowances(ListResourceAllowancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowancesAsync(ListResourceAllowancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
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
        /// <returns>A pageable sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceAllowancesRequest request = new ListResourceAllowancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceAllowances(request, callSettings);
        }

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceAllowancesRequest request = new ListResourceAllowancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceAllowancesAsync(request, callSettings);
        }

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
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
        /// <returns>A pageable sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceAllowancesRequest request = new ListResourceAllowancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceAllowances(request, callSettings);
        }

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent path.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceAllowancesRequest request = new ListResourceAllowancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceAllowancesAsync(request, callSettings);
        }

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance UpdateResourceAllowance(UpdateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> UpdateResourceAllowanceAsync(UpdateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> UpdateResourceAllowanceAsync(UpdateResourceAllowanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateResourceAllowanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to update.
        /// Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// Field mask is used to specify the fields to be overwritten in the
        /// ResourceAllowance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// 
        /// UpdateResourceAllowance request now only supports update on `limit` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceAllowance UpdateResourceAllowance(ResourceAllowance resourceAllowance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateResourceAllowance(new UpdateResourceAllowanceRequest
            {
                ResourceAllowance = gax::GaxPreconditions.CheckNotNull(resourceAllowance, nameof(resourceAllowance)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to update.
        /// Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// Field mask is used to specify the fields to be overwritten in the
        /// ResourceAllowance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// 
        /// UpdateResourceAllowance request now only supports update on `limit` field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> UpdateResourceAllowanceAsync(ResourceAllowance resourceAllowance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateResourceAllowanceAsync(new UpdateResourceAllowanceRequest
            {
                ResourceAllowance = gax::GaxPreconditions.CheckNotNull(resourceAllowance, nameof(resourceAllowance)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="resourceAllowance">
        /// Required. The ResourceAllowance to update.
        /// Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// Field mask is used to specify the fields to be overwritten in the
        /// ResourceAllowance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// 
        /// UpdateResourceAllowance request now only supports update on `limit` field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceAllowance> UpdateResourceAllowanceAsync(ResourceAllowance resourceAllowance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateResourceAllowanceAsync(resourceAllowance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BatchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Batch Service.
    /// The service manages user submitted batch jobs and allocates Google Compute
    /// Engine VM instances to run the jobs.
    /// </remarks>
    public sealed partial class BatchServiceClientImpl : BatchServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateJobRequest, Job> _callCreateJob;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<DeleteJobRequest, lro::Operation> _callDeleteJob;

        private readonly gaxgrpc::ApiCall<CancelJobRequest, lro::Operation> _callCancelJob;

        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<GetTaskRequest, Task> _callGetTask;

        private readonly gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> _callListTasks;

        private readonly gaxgrpc::ApiCall<CreateResourceAllowanceRequest, ResourceAllowance> _callCreateResourceAllowance;

        private readonly gaxgrpc::ApiCall<GetResourceAllowanceRequest, ResourceAllowance> _callGetResourceAllowance;

        private readonly gaxgrpc::ApiCall<DeleteResourceAllowanceRequest, lro::Operation> _callDeleteResourceAllowance;

        private readonly gaxgrpc::ApiCall<ListResourceAllowancesRequest, ListResourceAllowancesResponse> _callListResourceAllowances;

        private readonly gaxgrpc::ApiCall<UpdateResourceAllowanceRequest, ResourceAllowance> _callUpdateResourceAllowance;

        /// <summary>
        /// Constructs a client wrapper for the BatchService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BatchServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BatchServiceClientImpl(BatchService.BatchServiceClient grpcClient, BatchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BatchServiceSettings effectiveSettings = settings ?? BatchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteJobOperationsSettings, logger);
            CancelJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CancelJobOperationsSettings, logger);
            DeleteResourceAllowanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteResourceAllowanceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, Job>("CreateJob", grpcClient.CreateJobAsync, grpcClient.CreateJob, effectiveSettings.CreateJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>("GetJob", grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, lro::Operation>("DeleteJob", grpcClient.DeleteJobAsync, grpcClient.DeleteJob, effectiveSettings.DeleteJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            _callCancelJob = clientHelper.BuildApiCall<CancelJobRequest, lro::Operation>("CancelJob", grpcClient.CancelJobAsync, grpcClient.CancelJob, effectiveSettings.CancelJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelJob);
            Modify_CancelJobApiCall(ref _callCancelJob);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>("UpdateJob", grpcClient.UpdateJobAsync, grpcClient.UpdateJob, effectiveSettings.UpdateJobSettings).WithGoogleRequestParam("job.name", request => request.Job?.Name);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("ListJobs", grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callGetTask = clientHelper.BuildApiCall<GetTaskRequest, Task>("GetTask", grpcClient.GetTaskAsync, grpcClient.GetTask, effectiveSettings.GetTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTask);
            Modify_GetTaskApiCall(ref _callGetTask);
            _callListTasks = clientHelper.BuildApiCall<ListTasksRequest, ListTasksResponse>("ListTasks", grpcClient.ListTasksAsync, grpcClient.ListTasks, effectiveSettings.ListTasksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTasks);
            Modify_ListTasksApiCall(ref _callListTasks);
            _callCreateResourceAllowance = clientHelper.BuildApiCall<CreateResourceAllowanceRequest, ResourceAllowance>("CreateResourceAllowance", grpcClient.CreateResourceAllowanceAsync, grpcClient.CreateResourceAllowance, effectiveSettings.CreateResourceAllowanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateResourceAllowance);
            Modify_CreateResourceAllowanceApiCall(ref _callCreateResourceAllowance);
            _callGetResourceAllowance = clientHelper.BuildApiCall<GetResourceAllowanceRequest, ResourceAllowance>("GetResourceAllowance", grpcClient.GetResourceAllowanceAsync, grpcClient.GetResourceAllowance, effectiveSettings.GetResourceAllowanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetResourceAllowance);
            Modify_GetResourceAllowanceApiCall(ref _callGetResourceAllowance);
            _callDeleteResourceAllowance = clientHelper.BuildApiCall<DeleteResourceAllowanceRequest, lro::Operation>("DeleteResourceAllowance", grpcClient.DeleteResourceAllowanceAsync, grpcClient.DeleteResourceAllowance, effectiveSettings.DeleteResourceAllowanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteResourceAllowance);
            Modify_DeleteResourceAllowanceApiCall(ref _callDeleteResourceAllowance);
            _callListResourceAllowances = clientHelper.BuildApiCall<ListResourceAllowancesRequest, ListResourceAllowancesResponse>("ListResourceAllowances", grpcClient.ListResourceAllowancesAsync, grpcClient.ListResourceAllowances, effectiveSettings.ListResourceAllowancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListResourceAllowances);
            Modify_ListResourceAllowancesApiCall(ref _callListResourceAllowances);
            _callUpdateResourceAllowance = clientHelper.BuildApiCall<UpdateResourceAllowanceRequest, ResourceAllowance>("UpdateResourceAllowance", grpcClient.UpdateResourceAllowanceAsync, grpcClient.UpdateResourceAllowance, effectiveSettings.UpdateResourceAllowanceSettings).WithGoogleRequestParam("resource_allowance.name", request => request.ResourceAllowance?.Name);
            Modify_ApiCall(ref _callUpdateResourceAllowance);
            Modify_UpdateResourceAllowanceApiCall(ref _callUpdateResourceAllowance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, Job> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, lro::Operation> call);

        partial void Modify_CancelJobApiCall(ref gaxgrpc::ApiCall<CancelJobRequest, lro::Operation> call);

        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_GetTaskApiCall(ref gaxgrpc::ApiCall<GetTaskRequest, Task> call);

        partial void Modify_ListTasksApiCall(ref gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> call);

        partial void Modify_CreateResourceAllowanceApiCall(ref gaxgrpc::ApiCall<CreateResourceAllowanceRequest, ResourceAllowance> call);

        partial void Modify_GetResourceAllowanceApiCall(ref gaxgrpc::ApiCall<GetResourceAllowanceRequest, ResourceAllowance> call);

        partial void Modify_DeleteResourceAllowanceApiCall(ref gaxgrpc::ApiCall<DeleteResourceAllowanceRequest, lro::Operation> call);

        partial void Modify_ListResourceAllowancesApiCall(ref gaxgrpc::ApiCall<ListResourceAllowancesRequest, ListResourceAllowancesResponse> call);

        partial void Modify_UpdateResourceAllowanceApiCall(ref gaxgrpc::ApiCall<UpdateResourceAllowanceRequest, ResourceAllowance> call);

        partial void OnConstruction(BatchService.BatchServiceClient grpcClient, BatchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BatchService client</summary>
        public override BatchService.BatchServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelJobRequest(ref CancelJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTaskRequest(ref GetTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTasksRequest(ref ListTasksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateResourceAllowanceRequest(ref CreateResourceAllowanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetResourceAllowanceRequest(ref GetResourceAllowanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteResourceAllowanceRequest(ref DeleteResourceAllowanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListResourceAllowancesRequest(ref ListResourceAllowancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateResourceAllowanceRequest(ref UpdateResourceAllowanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return _callCreateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return _callCreateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Get a Job specified by its resource name.
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
        /// Get a Job specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteJob</c>.</summary>
        public override lro::OperationsClient DeleteJobOperationsClient { get; }

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteJob.Sync(request, callSettings), DeleteJobOperationsClient);
        }

        /// <summary>
        /// Delete a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteJob.Async(request, callSettings).ConfigureAwait(false), DeleteJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CancelJob</c>.</summary>
        public override lro::OperationsClient CancelJobOperationsClient { get; }

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CancelJobResponse, OperationMetadata> CancelJob(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return new lro::Operation<CancelJobResponse, OperationMetadata>(_callCancelJob.Sync(request, callSettings), CancelJobOperationsClient);
        }

        /// <summary>
        /// Cancel a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CancelJobResponse, OperationMetadata>> CancelJobAsync(CancelJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelJobRequest(ref request, ref callSettings);
            return new lro::Operation<CancelJobResponse, OperationMetadata>(await _callCancelJob.Async(request, callSettings).ConfigureAwait(false), CancelJobOperationsClient);
        }

        /// <summary>
        /// Update a Job.
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
        /// Update a Job.
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
        /// List all Jobs for a project within a region.
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
        /// List all Jobs for a project within a region.
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
        /// Return a single Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Return a single Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Async(request, callSettings);
        }

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }

        /// <summary>
        /// List Tasks associated with a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceAllowance CreateResourceAllowance(CreateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateResourceAllowanceRequest(ref request, ref callSettings);
            return _callCreateResourceAllowance.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceAllowance> CreateResourceAllowanceAsync(CreateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateResourceAllowanceRequest(ref request, ref callSettings);
            return _callCreateResourceAllowance.Async(request, callSettings);
        }

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceAllowance GetResourceAllowance(GetResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceAllowanceRequest(ref request, ref callSettings);
            return _callGetResourceAllowance.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a ResourceAllowance specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceAllowance> GetResourceAllowanceAsync(GetResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceAllowanceRequest(ref request, ref callSettings);
            return _callGetResourceAllowance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteResourceAllowance</c>.</summary>
        public override lro::OperationsClient DeleteResourceAllowanceOperationsClient { get; }

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceAllowance(DeleteResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteResourceAllowanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteResourceAllowance.Sync(request, callSettings), DeleteResourceAllowanceOperationsClient);
        }

        /// <summary>
        /// Delete a ResourceAllowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceAllowanceAsync(DeleteResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteResourceAllowanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteResourceAllowance.Async(request, callSettings).ConfigureAwait(false), DeleteResourceAllowanceOperationsClient);
        }

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public override gax::PagedEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowances(ListResourceAllowancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceAllowancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListResourceAllowancesRequest, ListResourceAllowancesResponse, ResourceAllowance>(_callListResourceAllowances, request, callSettings);
        }

        /// <summary>
        /// List all ResourceAllowances for a project within a region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceAllowance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListResourceAllowancesResponse, ResourceAllowance> ListResourceAllowancesAsync(ListResourceAllowancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceAllowancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListResourceAllowancesRequest, ListResourceAllowancesResponse, ResourceAllowance>(_callListResourceAllowances, request, callSettings);
        }

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceAllowance UpdateResourceAllowance(UpdateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateResourceAllowanceRequest(ref request, ref callSettings);
            return _callUpdateResourceAllowance.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a Resource Allowance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceAllowance> UpdateResourceAllowanceAsync(UpdateResourceAllowanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateResourceAllowanceRequest(ref request, ref callSettings);
            return _callUpdateResourceAllowance.Async(request, callSettings);
        }
    }

    public partial class ListJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTasksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListResourceAllowancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobsResponse : gaxgrpc::IPageResponse<Job>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTasksResponse : gaxgrpc::IPageResponse<Task>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Task> GetEnumerator() => Tasks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListResourceAllowancesResponse : gaxgrpc::IPageResponse<ResourceAllowance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ResourceAllowance> GetEnumerator() => ResourceAllowances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BatchService
    {
        public partial class BatchServiceClient
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

    public static partial class BatchService
    {
        public partial class BatchServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
