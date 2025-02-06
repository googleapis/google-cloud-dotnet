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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Tasks.V2
{
    /// <summary>Settings for <see cref="CloudTasksClient"/> instances.</summary>
    public sealed partial class CloudTasksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudTasksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudTasksSettings"/>.</returns>
        public static CloudTasksSettings GetDefault() => new CloudTasksSettings();

        /// <summary>Constructs a new <see cref="CloudTasksSettings"/> object with default settings.</summary>
        public CloudTasksSettings()
        {
        }

        private CloudTasksSettings(CloudTasksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListQueuesSettings = existing.ListQueuesSettings;
            GetQueueSettings = existing.GetQueueSettings;
            CreateQueueSettings = existing.CreateQueueSettings;
            UpdateQueueSettings = existing.UpdateQueueSettings;
            DeleteQueueSettings = existing.DeleteQueueSettings;
            PurgeQueueSettings = existing.PurgeQueueSettings;
            PauseQueueSettings = existing.PauseQueueSettings;
            ResumeQueueSettings = existing.ResumeQueueSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            ListTasksSettings = existing.ListTasksSettings;
            GetTaskSettings = existing.GetTaskSettings;
            CreateTaskSettings = existing.CreateTaskSettings;
            DeleteTaskSettings = existing.DeleteTaskSettings;
            RunTaskSettings = existing.RunTaskSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudTasksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.ListQueues</c>
        ///  and <c>CloudTasksClient.ListQueuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListQueuesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.GetQueue</c>
        ///  and <c>CloudTasksClient.GetQueueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetQueueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudTasksClient.CreateQueue</c> and <c>CloudTasksClient.CreateQueueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateQueueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudTasksClient.UpdateQueue</c> and <c>CloudTasksClient.UpdateQueueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateQueueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudTasksClient.DeleteQueue</c> and <c>CloudTasksClient.DeleteQueueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteQueueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.PurgeQueue</c>
        ///  and <c>CloudTasksClient.PurgeQueueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeQueueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.PauseQueue</c>
        ///  and <c>CloudTasksClient.PauseQueueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseQueueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudTasksClient.ResumeQueue</c> and <c>CloudTasksClient.ResumeQueueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeQueueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudTasksClient.GetIamPolicy</c> and <c>CloudTasksClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudTasksClient.SetIamPolicy</c> and <c>CloudTasksClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudTasksClient.TestIamPermissions</c> and <c>CloudTasksClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.ListTasks</c>
        ///  and <c>CloudTasksClient.ListTasksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTasksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.GetTask</c>
        ///  and <c>CloudTasksClient.GetTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.CreateTask</c>
        ///  and <c>CloudTasksClient.CreateTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.DeleteTask</c>
        ///  and <c>CloudTasksClient.DeleteTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudTasksClient.RunTask</c>
        ///  and <c>CloudTasksClient.RunTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunTaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudTasksSettings"/> object.</returns>
        public CloudTasksSettings Clone() => new CloudTasksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudTasksClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudTasksClientBuilder : gaxgrpc::ClientBuilderBase<CloudTasksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudTasksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudTasksClientBuilder() : base(CloudTasksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudTasksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudTasksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudTasksClient Build()
        {
            CloudTasksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudTasksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudTasksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudTasksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudTasksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudTasksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudTasksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudTasksClient.ChannelPool;
    }

    /// <summary>CloudTasks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Tasks allows developers to manage the execution of background
    /// work in their applications.
    /// </remarks>
    public abstract partial class CloudTasksClient
    {
        /// <summary>
        /// The default endpoint for the CloudTasks service, which is a host of "cloudtasks.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudtasks.googleapis.com:443";

        /// <summary>The default CloudTasks scopes.</summary>
        /// <remarks>
        /// The default CloudTasks scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudTasks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudTasksClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudTasksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudTasksClient"/>.</returns>
        public static stt::Task<CloudTasksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudTasksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudTasksClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="CloudTasksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudTasksClient"/>.</returns>
        public static CloudTasksClient Create() => new CloudTasksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudTasksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudTasksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudTasksClient"/>.</returns>
        internal static CloudTasksClient Create(grpccore::CallInvoker callInvoker, CloudTasksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudTasks.CloudTasksClient grpcClient = new CloudTasks.CloudTasksClient(callInvoker);
            return new CloudTasksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudTasks client</summary>
        public virtual CloudTasks.CloudTasksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Queue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQueuesResponse, Queue> ListQueues(ListQueuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Queue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQueuesResponse, Queue> ListQueuesAsync(ListQueuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
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
        /// <returns>A pageable sequence of <see cref="Queue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQueuesResponse, Queue> ListQueues(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQueuesRequest request = new ListQueuesRequest
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
            return ListQueues(request, callSettings);
        }

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Queue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQueuesResponse, Queue> ListQueuesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQueuesRequest request = new ListQueuesRequest
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
            return ListQueuesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
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
        /// <returns>A pageable sequence of <see cref="Queue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQueuesResponse, Queue> ListQueues(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQueuesRequest request = new ListQueuesRequest
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
            return ListQueues(request, callSettings);
        }

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Queue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQueuesResponse, Queue> ListQueuesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQueuesRequest request = new ListQueuesRequest
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
            return ListQueuesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue GetQueue(GetQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> GetQueueAsync(GetQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> GetQueueAsync(GetQueueRequest request, st::CancellationToken cancellationToken) =>
            GetQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the queue. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue GetQueue(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQueue(new GetQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the queue. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> GetQueueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQueueAsync(new GetQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the queue. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> GetQueueAsync(string name, st::CancellationToken cancellationToken) =>
            GetQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the queue. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue GetQueue(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQueue(new GetQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the queue. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> GetQueueAsync(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQueueAsync(new GetQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the queue. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> GetQueueAsync(QueueName name, st::CancellationToken cancellationToken) =>
            GetQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue CreateQueue(CreateQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> CreateQueueAsync(CreateQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> CreateQueueAsync(CreateQueueRequest request, st::CancellationToken cancellationToken) =>
            CreateQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name in which the queue will be created.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
        /// 
        /// The list of allowed locations can be obtained by calling Cloud
        /// Tasks' implementation of
        /// [ListLocations][google.cloud.location.Locations.ListLocations].
        /// </param>
        /// <param name="queue">
        /// Required. The queue to create.
        /// 
        /// [Queue's name][google.cloud.tasks.v2.Queue.name] cannot be the same as an
        /// existing queue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue CreateQueue(string parent, Queue queue, gaxgrpc::CallSettings callSettings = null) =>
            CreateQueue(new CreateQueueRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Queue = gax::GaxPreconditions.CheckNotNull(queue, nameof(queue)),
            }, callSettings);

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name in which the queue will be created.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
        /// 
        /// The list of allowed locations can be obtained by calling Cloud
        /// Tasks' implementation of
        /// [ListLocations][google.cloud.location.Locations.ListLocations].
        /// </param>
        /// <param name="queue">
        /// Required. The queue to create.
        /// 
        /// [Queue's name][google.cloud.tasks.v2.Queue.name] cannot be the same as an
        /// existing queue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> CreateQueueAsync(string parent, Queue queue, gaxgrpc::CallSettings callSettings = null) =>
            CreateQueueAsync(new CreateQueueRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Queue = gax::GaxPreconditions.CheckNotNull(queue, nameof(queue)),
            }, callSettings);

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name in which the queue will be created.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
        /// 
        /// The list of allowed locations can be obtained by calling Cloud
        /// Tasks' implementation of
        /// [ListLocations][google.cloud.location.Locations.ListLocations].
        /// </param>
        /// <param name="queue">
        /// Required. The queue to create.
        /// 
        /// [Queue's name][google.cloud.tasks.v2.Queue.name] cannot be the same as an
        /// existing queue.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> CreateQueueAsync(string parent, Queue queue, st::CancellationToken cancellationToken) =>
            CreateQueueAsync(parent, queue, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name in which the queue will be created.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
        /// 
        /// The list of allowed locations can be obtained by calling Cloud
        /// Tasks' implementation of
        /// [ListLocations][google.cloud.location.Locations.ListLocations].
        /// </param>
        /// <param name="queue">
        /// Required. The queue to create.
        /// 
        /// [Queue's name][google.cloud.tasks.v2.Queue.name] cannot be the same as an
        /// existing queue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue CreateQueue(gagr::LocationName parent, Queue queue, gaxgrpc::CallSettings callSettings = null) =>
            CreateQueue(new CreateQueueRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Queue = gax::GaxPreconditions.CheckNotNull(queue, nameof(queue)),
            }, callSettings);

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name in which the queue will be created.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
        /// 
        /// The list of allowed locations can be obtained by calling Cloud
        /// Tasks' implementation of
        /// [ListLocations][google.cloud.location.Locations.ListLocations].
        /// </param>
        /// <param name="queue">
        /// Required. The queue to create.
        /// 
        /// [Queue's name][google.cloud.tasks.v2.Queue.name] cannot be the same as an
        /// existing queue.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> CreateQueueAsync(gagr::LocationName parent, Queue queue, gaxgrpc::CallSettings callSettings = null) =>
            CreateQueueAsync(new CreateQueueRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Queue = gax::GaxPreconditions.CheckNotNull(queue, nameof(queue)),
            }, callSettings);

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name in which the queue will be created.
        /// For example: `projects/PROJECT_ID/locations/LOCATION_ID`
        /// 
        /// The list of allowed locations can be obtained by calling Cloud
        /// Tasks' implementation of
        /// [ListLocations][google.cloud.location.Locations.ListLocations].
        /// </param>
        /// <param name="queue">
        /// Required. The queue to create.
        /// 
        /// [Queue's name][google.cloud.tasks.v2.Queue.name] cannot be the same as an
        /// existing queue.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> CreateQueueAsync(gagr::LocationName parent, Queue queue, st::CancellationToken cancellationToken) =>
            CreateQueueAsync(parent, queue, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue UpdateQueue(UpdateQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> UpdateQueueAsync(UpdateQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> UpdateQueueAsync(UpdateQueueRequest request, st::CancellationToken cancellationToken) =>
            UpdateQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="queue">
        /// Required. The queue to create or update.
        /// 
        /// The queue's [name][google.cloud.tasks.v2.Queue.name] must be specified.
        /// 
        /// Output only fields cannot be modified using UpdateQueue.
        /// Any value specified for an output only field will be ignored.
        /// The queue's [name][google.cloud.tasks.v2.Queue.name] cannot be changed.
        /// </param>
        /// <param name="updateMask">
        /// A mask used to specify which fields of the queue are being updated.
        /// 
        /// If empty, then all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue UpdateQueue(Queue queue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQueue(new UpdateQueueRequest
            {
                Queue = gax::GaxPreconditions.CheckNotNull(queue, nameof(queue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="queue">
        /// Required. The queue to create or update.
        /// 
        /// The queue's [name][google.cloud.tasks.v2.Queue.name] must be specified.
        /// 
        /// Output only fields cannot be modified using UpdateQueue.
        /// Any value specified for an output only field will be ignored.
        /// The queue's [name][google.cloud.tasks.v2.Queue.name] cannot be changed.
        /// </param>
        /// <param name="updateMask">
        /// A mask used to specify which fields of the queue are being updated.
        /// 
        /// If empty, then all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> UpdateQueueAsync(Queue queue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQueueAsync(new UpdateQueueRequest
            {
                Queue = gax::GaxPreconditions.CheckNotNull(queue, nameof(queue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="queue">
        /// Required. The queue to create or update.
        /// 
        /// The queue's [name][google.cloud.tasks.v2.Queue.name] must be specified.
        /// 
        /// Output only fields cannot be modified using UpdateQueue.
        /// Any value specified for an output only field will be ignored.
        /// The queue's [name][google.cloud.tasks.v2.Queue.name] cannot be changed.
        /// </param>
        /// <param name="updateMask">
        /// A mask used to specify which fields of the queue are being updated.
        /// 
        /// If empty, then all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> UpdateQueueAsync(Queue queue, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateQueueAsync(queue, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQueue(DeleteQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQueueAsync(DeleteQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQueueAsync(DeleteQueueRequest request, st::CancellationToken cancellationToken) =>
            DeleteQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQueue(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQueue(new DeleteQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQueueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQueueAsync(new DeleteQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQueueAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteQueue(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQueue(new DeleteQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQueueAsync(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteQueueAsync(new DeleteQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteQueueAsync(QueueName name, st::CancellationToken cancellationToken) =>
            DeleteQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue PurgeQueue(PurgeQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PurgeQueueAsync(PurgeQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PurgeQueueAsync(PurgeQueueRequest request, st::CancellationToken cancellationToken) =>
            PurgeQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue PurgeQueue(string name, gaxgrpc::CallSettings callSettings = null) =>
            PurgeQueue(new PurgeQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PurgeQueueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PurgeQueueAsync(new PurgeQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PurgeQueueAsync(string name, st::CancellationToken cancellationToken) =>
            PurgeQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue PurgeQueue(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            PurgeQueue(new PurgeQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PurgeQueueAsync(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            PurgeQueueAsync(new PurgeQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PurgeQueueAsync(QueueName name, st::CancellationToken cancellationToken) =>
            PurgeQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue PauseQueue(PauseQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PauseQueueAsync(PauseQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PauseQueueAsync(PauseQueueRequest request, st::CancellationToken cancellationToken) =>
            PauseQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue PauseQueue(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseQueue(new PauseQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PauseQueueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseQueueAsync(new PauseQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PauseQueueAsync(string name, st::CancellationToken cancellationToken) =>
            PauseQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue PauseQueue(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseQueue(new PauseQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PauseQueueAsync(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseQueueAsync(new PauseQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> PauseQueueAsync(QueueName name, st::CancellationToken cancellationToken) =>
            PauseQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue ResumeQueue(ResumeQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> ResumeQueueAsync(ResumeQueueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> ResumeQueueAsync(ResumeQueueRequest request, st::CancellationToken cancellationToken) =>
            ResumeQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue ResumeQueue(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeQueue(new ResumeQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> ResumeQueueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeQueueAsync(new ResumeQueueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> ResumeQueueAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Queue ResumeQueue(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeQueue(new ResumeQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> ResumeQueueAsync(QueueName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeQueueAsync(new ResumeQueueRequest
            {
                QueueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="name">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Queue> ResumeQueueAsync(QueueName name, st::CancellationToken cancellationToken) =>
            ResumeQueueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
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
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
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
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
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
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(QueueName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
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
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(QueueName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets a task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, st::CancellationToken cancellationToken) =>
            GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task CreateTask(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(CreateTaskRequest request, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// 
        /// The queue must already exist.
        /// </param>
        /// <param name="task">
        /// Required. The task to add.
        /// 
        /// Task names have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`.
        /// The user can optionally specify a task
        /// [name][google.cloud.tasks.v2.Task.name]. If a name is not specified then
        /// the system will generate a random unique task id, which will be set in the
        /// task returned in the [response][google.cloud.tasks.v2.Task.name].
        /// 
        /// If [schedule_time][google.cloud.tasks.v2.Task.schedule_time] is not set or
        /// is in the past then Cloud Tasks will set it to the current time.
        /// 
        /// Task De-duplication:
        /// 
        /// Explicitly specifying a task ID enables task de-duplication.  If
        /// a task's ID is identical to that of an existing task or a task
        /// that was deleted or executed recently then the call will fail
        /// with [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS].
        /// If the task's queue was created using Cloud Tasks, then another task with
        /// the same name can't be created for ~1hour after the original task was
        /// deleted or executed. If the task's queue was created using queue.yaml or
        /// queue.xml, then another task with the same name can't be created
        /// for ~9days after the original task was deleted or executed.
        /// 
        /// Because there is an extra lookup cost to identify duplicate task
        /// names, these [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask]
        /// calls have significantly increased latency. Using hashed strings for the
        /// task id or for the prefix of the task id is recommended. Choosing task ids
        /// that are sequential or have sequential prefixes, for example using a
        /// timestamp, causes an increase in latency and error rates in all
        /// task commands. The infrastructure relies on an approximately
        /// uniform distribution of task ids to store and serve tasks
        /// efficiently.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task CreateTask(string parent, Task task, gaxgrpc::CallSettings callSettings = null) =>
            CreateTask(new CreateTaskRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// 
        /// The queue must already exist.
        /// </param>
        /// <param name="task">
        /// Required. The task to add.
        /// 
        /// Task names have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`.
        /// The user can optionally specify a task
        /// [name][google.cloud.tasks.v2.Task.name]. If a name is not specified then
        /// the system will generate a random unique task id, which will be set in the
        /// task returned in the [response][google.cloud.tasks.v2.Task.name].
        /// 
        /// If [schedule_time][google.cloud.tasks.v2.Task.schedule_time] is not set or
        /// is in the past then Cloud Tasks will set it to the current time.
        /// 
        /// Task De-duplication:
        /// 
        /// Explicitly specifying a task ID enables task de-duplication.  If
        /// a task's ID is identical to that of an existing task or a task
        /// that was deleted or executed recently then the call will fail
        /// with [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS].
        /// If the task's queue was created using Cloud Tasks, then another task with
        /// the same name can't be created for ~1hour after the original task was
        /// deleted or executed. If the task's queue was created using queue.yaml or
        /// queue.xml, then another task with the same name can't be created
        /// for ~9days after the original task was deleted or executed.
        /// 
        /// Because there is an extra lookup cost to identify duplicate task
        /// names, these [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask]
        /// calls have significantly increased latency. Using hashed strings for the
        /// task id or for the prefix of the task id is recommended. Choosing task ids
        /// that are sequential or have sequential prefixes, for example using a
        /// timestamp, causes an increase in latency and error rates in all
        /// task commands. The infrastructure relies on an approximately
        /// uniform distribution of task ids to store and serve tasks
        /// efficiently.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(string parent, Task task, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaskAsync(new CreateTaskRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// 
        /// The queue must already exist.
        /// </param>
        /// <param name="task">
        /// Required. The task to add.
        /// 
        /// Task names have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`.
        /// The user can optionally specify a task
        /// [name][google.cloud.tasks.v2.Task.name]. If a name is not specified then
        /// the system will generate a random unique task id, which will be set in the
        /// task returned in the [response][google.cloud.tasks.v2.Task.name].
        /// 
        /// If [schedule_time][google.cloud.tasks.v2.Task.schedule_time] is not set or
        /// is in the past then Cloud Tasks will set it to the current time.
        /// 
        /// Task De-duplication:
        /// 
        /// Explicitly specifying a task ID enables task de-duplication.  If
        /// a task's ID is identical to that of an existing task or a task
        /// that was deleted or executed recently then the call will fail
        /// with [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS].
        /// If the task's queue was created using Cloud Tasks, then another task with
        /// the same name can't be created for ~1hour after the original task was
        /// deleted or executed. If the task's queue was created using queue.yaml or
        /// queue.xml, then another task with the same name can't be created
        /// for ~9days after the original task was deleted or executed.
        /// 
        /// Because there is an extra lookup cost to identify duplicate task
        /// names, these [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask]
        /// calls have significantly increased latency. Using hashed strings for the
        /// task id or for the prefix of the task id is recommended. Choosing task ids
        /// that are sequential or have sequential prefixes, for example using a
        /// timestamp, causes an increase in latency and error rates in all
        /// task commands. The infrastructure relies on an approximately
        /// uniform distribution of task ids to store and serve tasks
        /// efficiently.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(string parent, Task task, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(parent, task, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// 
        /// The queue must already exist.
        /// </param>
        /// <param name="task">
        /// Required. The task to add.
        /// 
        /// Task names have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`.
        /// The user can optionally specify a task
        /// [name][google.cloud.tasks.v2.Task.name]. If a name is not specified then
        /// the system will generate a random unique task id, which will be set in the
        /// task returned in the [response][google.cloud.tasks.v2.Task.name].
        /// 
        /// If [schedule_time][google.cloud.tasks.v2.Task.schedule_time] is not set or
        /// is in the past then Cloud Tasks will set it to the current time.
        /// 
        /// Task De-duplication:
        /// 
        /// Explicitly specifying a task ID enables task de-duplication.  If
        /// a task's ID is identical to that of an existing task or a task
        /// that was deleted or executed recently then the call will fail
        /// with [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS].
        /// If the task's queue was created using Cloud Tasks, then another task with
        /// the same name can't be created for ~1hour after the original task was
        /// deleted or executed. If the task's queue was created using queue.yaml or
        /// queue.xml, then another task with the same name can't be created
        /// for ~9days after the original task was deleted or executed.
        /// 
        /// Because there is an extra lookup cost to identify duplicate task
        /// names, these [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask]
        /// calls have significantly increased latency. Using hashed strings for the
        /// task id or for the prefix of the task id is recommended. Choosing task ids
        /// that are sequential or have sequential prefixes, for example using a
        /// timestamp, causes an increase in latency and error rates in all
        /// task commands. The infrastructure relies on an approximately
        /// uniform distribution of task ids to store and serve tasks
        /// efficiently.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task CreateTask(QueueName parent, Task task, gaxgrpc::CallSettings callSettings = null) =>
            CreateTask(new CreateTaskRequest
            {
                ParentAsQueueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// 
        /// The queue must already exist.
        /// </param>
        /// <param name="task">
        /// Required. The task to add.
        /// 
        /// Task names have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`.
        /// The user can optionally specify a task
        /// [name][google.cloud.tasks.v2.Task.name]. If a name is not specified then
        /// the system will generate a random unique task id, which will be set in the
        /// task returned in the [response][google.cloud.tasks.v2.Task.name].
        /// 
        /// If [schedule_time][google.cloud.tasks.v2.Task.schedule_time] is not set or
        /// is in the past then Cloud Tasks will set it to the current time.
        /// 
        /// Task De-duplication:
        /// 
        /// Explicitly specifying a task ID enables task de-duplication.  If
        /// a task's ID is identical to that of an existing task or a task
        /// that was deleted or executed recently then the call will fail
        /// with [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS].
        /// If the task's queue was created using Cloud Tasks, then another task with
        /// the same name can't be created for ~1hour after the original task was
        /// deleted or executed. If the task's queue was created using queue.yaml or
        /// queue.xml, then another task with the same name can't be created
        /// for ~9days after the original task was deleted or executed.
        /// 
        /// Because there is an extra lookup cost to identify duplicate task
        /// names, these [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask]
        /// calls have significantly increased latency. Using hashed strings for the
        /// task id or for the prefix of the task id is recommended. Choosing task ids
        /// that are sequential or have sequential prefixes, for example using a
        /// timestamp, causes an increase in latency and error rates in all
        /// task commands. The infrastructure relies on an approximately
        /// uniform distribution of task ids to store and serve tasks
        /// efficiently.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(QueueName parent, Task task, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaskAsync(new CreateTaskRequest
            {
                ParentAsQueueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="parent">
        /// Required. The queue name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
        /// 
        /// The queue must already exist.
        /// </param>
        /// <param name="task">
        /// Required. The task to add.
        /// 
        /// Task names have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`.
        /// The user can optionally specify a task
        /// [name][google.cloud.tasks.v2.Task.name]. If a name is not specified then
        /// the system will generate a random unique task id, which will be set in the
        /// task returned in the [response][google.cloud.tasks.v2.Task.name].
        /// 
        /// If [schedule_time][google.cloud.tasks.v2.Task.schedule_time] is not set or
        /// is in the past then Cloud Tasks will set it to the current time.
        /// 
        /// Task De-duplication:
        /// 
        /// Explicitly specifying a task ID enables task de-duplication.  If
        /// a task's ID is identical to that of an existing task or a task
        /// that was deleted or executed recently then the call will fail
        /// with [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS].
        /// If the task's queue was created using Cloud Tasks, then another task with
        /// the same name can't be created for ~1hour after the original task was
        /// deleted or executed. If the task's queue was created using queue.yaml or
        /// queue.xml, then another task with the same name can't be created
        /// for ~9days after the original task was deleted or executed.
        /// 
        /// Because there is an extra lookup cost to identify duplicate task
        /// names, these [CreateTask][google.cloud.tasks.v2.CloudTasks.CreateTask]
        /// calls have significantly increased latency. Using hashed strings for the
        /// task id or for the prefix of the task id is recommended. Choosing task ids
        /// that are sequential or have sequential prefixes, for example using a
        /// timestamp, causes an increase in latency and error rates in all
        /// task commands. The infrastructure relies on an approximately
        /// uniform distribution of task ids to store and serve tasks
        /// efficiently.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(QueueName parent, Task task, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(parent, task, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTask(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaskAsync(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaskAsync(DeleteTaskRequest request, st::CancellationToken cancellationToken) =>
            DeleteTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTask(new DeleteTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaskAsync(new DeleteTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaskAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTask(new DeleteTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaskAsync(new DeleteTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            DeleteTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task RunTask(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> RunTaskAsync(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> RunTaskAsync(RunTaskRequest request, st::CancellationToken cancellationToken) =>
            RunTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task RunTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunTask(new RunTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> RunTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunTaskAsync(new RunTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> RunTaskAsync(string name, st::CancellationToken cancellationToken) =>
            RunTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task RunTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            RunTask(new RunTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> RunTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            RunTaskAsync(new RunTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="name">
        /// Required. The task name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> RunTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            RunTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudTasks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Tasks allows developers to manage the execution of background
    /// work in their applications.
    /// </remarks>
    public sealed partial class CloudTasksClientImpl : CloudTasksClient
    {
        private readonly gaxgrpc::ApiCall<ListQueuesRequest, ListQueuesResponse> _callListQueues;

        private readonly gaxgrpc::ApiCall<GetQueueRequest, Queue> _callGetQueue;

        private readonly gaxgrpc::ApiCall<CreateQueueRequest, Queue> _callCreateQueue;

        private readonly gaxgrpc::ApiCall<UpdateQueueRequest, Queue> _callUpdateQueue;

        private readonly gaxgrpc::ApiCall<DeleteQueueRequest, wkt::Empty> _callDeleteQueue;

        private readonly gaxgrpc::ApiCall<PurgeQueueRequest, Queue> _callPurgeQueue;

        private readonly gaxgrpc::ApiCall<PauseQueueRequest, Queue> _callPauseQueue;

        private readonly gaxgrpc::ApiCall<ResumeQueueRequest, Queue> _callResumeQueue;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> _callListTasks;

        private readonly gaxgrpc::ApiCall<GetTaskRequest, Task> _callGetTask;

        private readonly gaxgrpc::ApiCall<CreateTaskRequest, Task> _callCreateTask;

        private readonly gaxgrpc::ApiCall<DeleteTaskRequest, wkt::Empty> _callDeleteTask;

        private readonly gaxgrpc::ApiCall<RunTaskRequest, Task> _callRunTask;

        /// <summary>
        /// Constructs a client wrapper for the CloudTasks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudTasksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudTasksClientImpl(CloudTasks.CloudTasksClient grpcClient, CloudTasksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudTasksSettings effectiveSettings = settings ?? CloudTasksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListQueues = clientHelper.BuildApiCall<ListQueuesRequest, ListQueuesResponse>("ListQueues", grpcClient.ListQueuesAsync, grpcClient.ListQueues, effectiveSettings.ListQueuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListQueues);
            Modify_ListQueuesApiCall(ref _callListQueues);
            _callGetQueue = clientHelper.BuildApiCall<GetQueueRequest, Queue>("GetQueue", grpcClient.GetQueueAsync, grpcClient.GetQueue, effectiveSettings.GetQueueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQueue);
            Modify_GetQueueApiCall(ref _callGetQueue);
            _callCreateQueue = clientHelper.BuildApiCall<CreateQueueRequest, Queue>("CreateQueue", grpcClient.CreateQueueAsync, grpcClient.CreateQueue, effectiveSettings.CreateQueueSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateQueue);
            Modify_CreateQueueApiCall(ref _callCreateQueue);
            _callUpdateQueue = clientHelper.BuildApiCall<UpdateQueueRequest, Queue>("UpdateQueue", grpcClient.UpdateQueueAsync, grpcClient.UpdateQueue, effectiveSettings.UpdateQueueSettings).WithGoogleRequestParam("queue.name", request => request.Queue?.Name);
            Modify_ApiCall(ref _callUpdateQueue);
            Modify_UpdateQueueApiCall(ref _callUpdateQueue);
            _callDeleteQueue = clientHelper.BuildApiCall<DeleteQueueRequest, wkt::Empty>("DeleteQueue", grpcClient.DeleteQueueAsync, grpcClient.DeleteQueue, effectiveSettings.DeleteQueueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteQueue);
            Modify_DeleteQueueApiCall(ref _callDeleteQueue);
            _callPurgeQueue = clientHelper.BuildApiCall<PurgeQueueRequest, Queue>("PurgeQueue", grpcClient.PurgeQueueAsync, grpcClient.PurgeQueue, effectiveSettings.PurgeQueueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPurgeQueue);
            Modify_PurgeQueueApiCall(ref _callPurgeQueue);
            _callPauseQueue = clientHelper.BuildApiCall<PauseQueueRequest, Queue>("PauseQueue", grpcClient.PauseQueueAsync, grpcClient.PauseQueue, effectiveSettings.PauseQueueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseQueue);
            Modify_PauseQueueApiCall(ref _callPauseQueue);
            _callResumeQueue = clientHelper.BuildApiCall<ResumeQueueRequest, Queue>("ResumeQueue", grpcClient.ResumeQueueAsync, grpcClient.ResumeQueue, effectiveSettings.ResumeQueueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeQueue);
            Modify_ResumeQueueApiCall(ref _callResumeQueue);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callListTasks = clientHelper.BuildApiCall<ListTasksRequest, ListTasksResponse>("ListTasks", grpcClient.ListTasksAsync, grpcClient.ListTasks, effectiveSettings.ListTasksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTasks);
            Modify_ListTasksApiCall(ref _callListTasks);
            _callGetTask = clientHelper.BuildApiCall<GetTaskRequest, Task>("GetTask", grpcClient.GetTaskAsync, grpcClient.GetTask, effectiveSettings.GetTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTask);
            Modify_GetTaskApiCall(ref _callGetTask);
            _callCreateTask = clientHelper.BuildApiCall<CreateTaskRequest, Task>("CreateTask", grpcClient.CreateTaskAsync, grpcClient.CreateTask, effectiveSettings.CreateTaskSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTask);
            Modify_CreateTaskApiCall(ref _callCreateTask);
            _callDeleteTask = clientHelper.BuildApiCall<DeleteTaskRequest, wkt::Empty>("DeleteTask", grpcClient.DeleteTaskAsync, grpcClient.DeleteTask, effectiveSettings.DeleteTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTask);
            Modify_DeleteTaskApiCall(ref _callDeleteTask);
            _callRunTask = clientHelper.BuildApiCall<RunTaskRequest, Task>("RunTask", grpcClient.RunTaskAsync, grpcClient.RunTask, effectiveSettings.RunTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunTask);
            Modify_RunTaskApiCall(ref _callRunTask);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListQueuesApiCall(ref gaxgrpc::ApiCall<ListQueuesRequest, ListQueuesResponse> call);

        partial void Modify_GetQueueApiCall(ref gaxgrpc::ApiCall<GetQueueRequest, Queue> call);

        partial void Modify_CreateQueueApiCall(ref gaxgrpc::ApiCall<CreateQueueRequest, Queue> call);

        partial void Modify_UpdateQueueApiCall(ref gaxgrpc::ApiCall<UpdateQueueRequest, Queue> call);

        partial void Modify_DeleteQueueApiCall(ref gaxgrpc::ApiCall<DeleteQueueRequest, wkt::Empty> call);

        partial void Modify_PurgeQueueApiCall(ref gaxgrpc::ApiCall<PurgeQueueRequest, Queue> call);

        partial void Modify_PauseQueueApiCall(ref gaxgrpc::ApiCall<PauseQueueRequest, Queue> call);

        partial void Modify_ResumeQueueApiCall(ref gaxgrpc::ApiCall<ResumeQueueRequest, Queue> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_ListTasksApiCall(ref gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> call);

        partial void Modify_GetTaskApiCall(ref gaxgrpc::ApiCall<GetTaskRequest, Task> call);

        partial void Modify_CreateTaskApiCall(ref gaxgrpc::ApiCall<CreateTaskRequest, Task> call);

        partial void Modify_DeleteTaskApiCall(ref gaxgrpc::ApiCall<DeleteTaskRequest, wkt::Empty> call);

        partial void Modify_RunTaskApiCall(ref gaxgrpc::ApiCall<RunTaskRequest, Task> call);

        partial void OnConstruction(CloudTasks.CloudTasksClient grpcClient, CloudTasksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudTasks client</summary>
        public override CloudTasks.CloudTasksClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListQueuesRequest(ref ListQueuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetQueueRequest(ref GetQueueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateQueueRequest(ref CreateQueueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateQueueRequest(ref UpdateQueueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteQueueRequest(ref DeleteQueueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeQueueRequest(ref PurgeQueueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseQueueRequest(ref PauseQueueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeQueueRequest(ref ResumeQueueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTasksRequest(ref ListTasksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTaskRequest(ref GetTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTaskRequest(ref CreateTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTaskRequest(ref DeleteTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunTaskRequest(ref RunTaskRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Queue"/> resources.</returns>
        public override gax::PagedEnumerable<ListQueuesResponse, Queue> ListQueues(ListQueuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQueuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListQueuesRequest, ListQueuesResponse, Queue>(_callListQueues, request, callSettings);
        }

        /// <summary>
        /// Lists queues.
        /// 
        /// Queues are returned in lexicographical order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Queue"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListQueuesResponse, Queue> ListQueuesAsync(ListQueuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQueuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListQueuesRequest, ListQueuesResponse, Queue>(_callListQueues, request, callSettings);
        }

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Queue GetQueue(GetQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQueueRequest(ref request, ref callSettings);
            return _callGetQueue.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Queue> GetQueueAsync(GetQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQueueRequest(ref request, ref callSettings);
            return _callGetQueue.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Queue CreateQueue(CreateQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQueueRequest(ref request, ref callSettings);
            return _callCreateQueue.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a queue.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Queue> CreateQueueAsync(CreateQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQueueRequest(ref request, ref callSettings);
            return _callCreateQueue.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Queue UpdateQueue(UpdateQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQueueRequest(ref request, ref callSettings);
            return _callUpdateQueue.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a queue.
        /// 
        /// This method creates the queue if it does not exist and updates
        /// the queue if it does exist.
        /// 
        /// Queues created with this method allow tasks to live for a maximum of 31
        /// days. After a task is 31 days old, the task will be deleted regardless of
        /// whether it was dispatched or not.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Queue> UpdateQueueAsync(UpdateQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQueueRequest(ref request, ref callSettings);
            return _callUpdateQueue.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteQueue(DeleteQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQueueRequest(ref request, ref callSettings);
            _callDeleteQueue.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a queue.
        /// 
        /// This command will delete the queue even if it has tasks in it.
        /// 
        /// Note: If you delete a queue, a queue with the same name can't be created
        /// for 7 days.
        /// 
        /// WARNING: Using this method may have unintended side effects if you are
        /// using an App Engine `queue.yaml` or `queue.xml` file to manage your queues.
        /// Read
        /// [Overview of Queue Management and
        /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using
        /// this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteQueueAsync(DeleteQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteQueueRequest(ref request, ref callSettings);
            return _callDeleteQueue.Async(request, callSettings);
        }

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Queue PurgeQueue(PurgeQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeQueueRequest(ref request, ref callSettings);
            return _callPurgeQueue.Sync(request, callSettings);
        }

        /// <summary>
        /// Purges a queue by deleting all of its tasks.
        /// 
        /// All tasks created before this method is called are permanently deleted.
        /// 
        /// Purge operations can take up to one minute to take effect. Tasks
        /// might be dispatched before the purge takes effect. A purge is irreversible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Queue> PurgeQueueAsync(PurgeQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeQueueRequest(ref request, ref callSettings);
            return _callPurgeQueue.Async(request, callSettings);
        }

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Queue PauseQueue(PauseQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseQueueRequest(ref request, ref callSettings);
            return _callPauseQueue.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses the queue.
        /// 
        /// If a queue is paused then the system will stop dispatching tasks
        /// until the queue is resumed via
        /// [ResumeQueue][google.cloud.tasks.v2.CloudTasks.ResumeQueue]. Tasks can
        /// still be added when the queue is paused. A queue is paused if its
        /// [state][google.cloud.tasks.v2.Queue.state] is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Queue> PauseQueueAsync(PauseQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseQueueRequest(ref request, ref callSettings);
            return _callPauseQueue.Async(request, callSettings);
        }

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Queue ResumeQueue(ResumeQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeQueueRequest(ref request, ref callSettings);
            return _callResumeQueue.Sync(request, callSettings);
        }

        /// <summary>
        /// Resume a queue.
        /// 
        /// This method resumes a queue after it has been
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED] or
        /// [DISABLED][google.cloud.tasks.v2.Queue.State.DISABLED]. The state of a
        /// queue is stored in the queue's [state][google.cloud.tasks.v2.Queue.state];
        /// after calling this method it will be set to
        /// [RUNNING][google.cloud.tasks.v2.Queue.State.RUNNING].
        /// 
        /// WARNING: Resuming many high-QPS queues at the same time can
        /// lead to target overloading. If you are resuming high-QPS
        /// queues, follow the 500/50/5 pattern described in
        /// [Managing Cloud Tasks Scaling
        /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Queue> ResumeQueueAsync(ResumeQueueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeQueueRequest(ref request, ref callSettings);
            return _callResumeQueue.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Replaces any existing policy.
        /// 
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        /// 
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        /// 
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on a
        /// [Queue][google.cloud.tasks.v2.Queue]. If the resource does not exist, this
        /// will return an empty set of permissions, not a
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
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
        /// Lists the tasks in a queue.
        /// 
        /// By default, only the [BASIC][google.cloud.tasks.v2.Task.View.BASIC] view is
        /// retrieved due to performance considerations;
        /// [response_view][google.cloud.tasks.v2.ListTasksRequest.response_view]
        /// controls the subset of information which is returned.
        /// 
        /// The tasks may be returned in any order. The ordering may change at any
        /// time.
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
        /// Gets a task.
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
        /// Gets a task.
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
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task CreateTask(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaskRequest(ref request, ref callSettings);
            return _callCreateTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a task and adds it to a queue.
        /// 
        /// Tasks cannot be updated after creation; there is no UpdateTask command.
        /// 
        /// * The maximum task size is 100KB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> CreateTaskAsync(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaskRequest(ref request, ref callSettings);
            return _callCreateTask.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTask(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTaskRequest(ref request, ref callSettings);
            _callDeleteTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a task.
        /// 
        /// A task can be deleted if it is scheduled or dispatched. A task
        /// cannot be deleted if it has executed successfully or permanently
        /// failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTaskAsync(DeleteTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTaskRequest(ref request, ref callSettings);
            return _callDeleteTask.Async(request, callSettings);
        }

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task RunTask(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTaskRequest(ref request, ref callSettings);
            return _callRunTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Forces a task to run now.
        /// 
        /// When this method is called, Cloud Tasks will dispatch the task, even if
        /// the task is already running, the queue has reached its
        /// [RateLimits][google.cloud.tasks.v2.RateLimits] or is
        /// [PAUSED][google.cloud.tasks.v2.Queue.State.PAUSED].
        /// 
        /// This command is meant to be used for manual debugging. For
        /// example, [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] can be used to
        /// retry a failed task after a fix has been made or to manually force a task
        /// to be dispatched now.
        /// 
        /// The dispatched task is returned. That is, the task that is returned
        /// contains the [status][Task.status] after the task is dispatched but
        /// before the task is received by its target.
        /// 
        /// If Cloud Tasks receives a successful response from the task's
        /// target, then the task will be deleted; otherwise the task's
        /// [schedule_time][google.cloud.tasks.v2.Task.schedule_time] will be reset to
        /// the time that [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] was
        /// called plus the retry delay specified in the queue's
        /// [RetryConfig][google.cloud.tasks.v2.RetryConfig].
        /// 
        /// [RunTask][google.cloud.tasks.v2.CloudTasks.RunTask] returns
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] when it is called on a
        /// task that has already succeeded or permanently failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> RunTaskAsync(RunTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTaskRequest(ref request, ref callSettings);
            return _callRunTask.Async(request, callSettings);
        }
    }

    public partial class ListQueuesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTasksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListQueuesResponse : gaxgrpc::IPageResponse<Queue>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Queue> GetEnumerator() => Queues.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTasksResponse : gaxgrpc::IPageResponse<Task>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Task> GetEnumerator() => Tasks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudTasks
    {
        public partial class CloudTasksClient
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
