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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.StorageTransfer.V1
{
    /// <summary>Settings for <see cref="StorageTransferServiceClient"/> instances.</summary>
    public sealed partial class StorageTransferServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StorageTransferServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StorageTransferServiceSettings"/>.</returns>
        public static StorageTransferServiceSettings GetDefault() => new StorageTransferServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="StorageTransferServiceSettings"/> object with default settings.
        /// </summary>
        public StorageTransferServiceSettings()
        {
        }

        private StorageTransferServiceSettings(StorageTransferServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGoogleServiceAccountSettings = existing.GetGoogleServiceAccountSettings;
            CreateTransferJobSettings = existing.CreateTransferJobSettings;
            UpdateTransferJobSettings = existing.UpdateTransferJobSettings;
            GetTransferJobSettings = existing.GetTransferJobSettings;
            ListTransferJobsSettings = existing.ListTransferJobsSettings;
            PauseTransferOperationSettings = existing.PauseTransferOperationSettings;
            ResumeTransferOperationSettings = existing.ResumeTransferOperationSettings;
            RunTransferJobSettings = existing.RunTransferJobSettings;
            RunTransferJobOperationsSettings = existing.RunTransferJobOperationsSettings.Clone();
            DeleteTransferJobSettings = existing.DeleteTransferJobSettings;
            CreateAgentPoolSettings = existing.CreateAgentPoolSettings;
            UpdateAgentPoolSettings = existing.UpdateAgentPoolSettings;
            GetAgentPoolSettings = existing.GetAgentPoolSettings;
            ListAgentPoolsSettings = existing.ListAgentPoolsSettings;
            DeleteAgentPoolSettings = existing.DeleteAgentPoolSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StorageTransferServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.GetGoogleServiceAccount</c> and
        /// <c>StorageTransferServiceClient.GetGoogleServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGoogleServiceAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.CreateTransferJob</c> and
        /// <c>StorageTransferServiceClient.CreateTransferJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTransferJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.UpdateTransferJob</c> and
        /// <c>StorageTransferServiceClient.UpdateTransferJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTransferJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.GetTransferJob</c> and <c>StorageTransferServiceClient.GetTransferJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTransferJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.ListTransferJobs</c> and
        /// <c>StorageTransferServiceClient.ListTransferJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTransferJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.PauseTransferOperation</c> and
        /// <c>StorageTransferServiceClient.PauseTransferOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseTransferOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.ResumeTransferOperation</c> and
        /// <c>StorageTransferServiceClient.ResumeTransferOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeTransferOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.RunTransferJob</c> and <c>StorageTransferServiceClient.RunTransferJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunTransferJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageTransferServiceClient.RunTransferJob</c> and
        /// <c>StorageTransferServiceClient.RunTransferJobAsync</c>.
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
        public lro::OperationsSettings RunTransferJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.DeleteTransferJob</c> and
        /// <c>StorageTransferServiceClient.DeleteTransferJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTransferJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.CreateAgentPool</c> and <c>StorageTransferServiceClient.CreateAgentPoolAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAgentPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.UpdateAgentPool</c> and <c>StorageTransferServiceClient.UpdateAgentPoolAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAgentPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.GetAgentPool</c> and <c>StorageTransferServiceClient.GetAgentPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.ListAgentPools</c> and <c>StorageTransferServiceClient.ListAgentPoolsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAgentPoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageTransferServiceClient.DeleteAgentPool</c> and <c>StorageTransferServiceClient.DeleteAgentPoolAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAgentPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StorageTransferServiceSettings"/> object.</returns>
        public StorageTransferServiceSettings Clone() => new StorageTransferServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StorageTransferServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class StorageTransferServiceClientBuilder : gaxgrpc::ClientBuilderBase<StorageTransferServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StorageTransferServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StorageTransferServiceClientBuilder() : base(StorageTransferServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StorageTransferServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StorageTransferServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StorageTransferServiceClient Build()
        {
            StorageTransferServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StorageTransferServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StorageTransferServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StorageTransferServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StorageTransferServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StorageTransferServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StorageTransferServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StorageTransferServiceClient.ChannelPool;
    }

    /// <summary>StorageTransferService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Storage Transfer Service and its protos.
    /// Transfers data between between Google Cloud Storage buckets or from a data
    /// source external to Google to a Cloud Storage bucket.
    /// </remarks>
    public abstract partial class StorageTransferServiceClient
    {
        /// <summary>
        /// The default endpoint for the StorageTransferService service, which is a host of
        /// "storagetransfer.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "storagetransfer.googleapis.com:443";

        /// <summary>The default StorageTransferService scopes.</summary>
        /// <remarks>
        /// The default StorageTransferService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(StorageTransferService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StorageTransferServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="StorageTransferServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StorageTransferServiceClient"/>.</returns>
        public static stt::Task<StorageTransferServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StorageTransferServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StorageTransferServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="StorageTransferServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StorageTransferServiceClient"/>.</returns>
        public static StorageTransferServiceClient Create() => new StorageTransferServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StorageTransferServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StorageTransferServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StorageTransferServiceClient"/>.</returns>
        internal static StorageTransferServiceClient Create(grpccore::CallInvoker callInvoker, StorageTransferServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StorageTransferService.StorageTransferServiceClient grpcClient = new StorageTransferService.StorageTransferServiceClient(callInvoker);
            return new StorageTransferServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC StorageTransferService client</summary>
        public virtual StorageTransferService.StorageTransferServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Google service account that is used by Storage Transfer
        /// Service to access buckets in the project where transfers
        /// run or in other projects. Each Google service account is associated
        /// with one Google Cloud project. Users
        /// should add this service account to the Google Cloud Storage bucket
        /// ACLs to grant access to Storage Transfer Service. This service
        /// account is created and owned by Storage Transfer Service and can
        /// only be used by Storage Transfer Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GoogleServiceAccount GetGoogleServiceAccount(GetGoogleServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Google service account that is used by Storage Transfer
        /// Service to access buckets in the project where transfers
        /// run or in other projects. Each Google service account is associated
        /// with one Google Cloud project. Users
        /// should add this service account to the Google Cloud Storage bucket
        /// ACLs to grant access to Storage Transfer Service. This service
        /// account is created and owned by Storage Transfer Service and can
        /// only be used by Storage Transfer Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleServiceAccount> GetGoogleServiceAccountAsync(GetGoogleServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Google service account that is used by Storage Transfer
        /// Service to access buckets in the project where transfers
        /// run or in other projects. Each Google service account is associated
        /// with one Google Cloud project. Users
        /// should add this service account to the Google Cloud Storage bucket
        /// ACLs to grant access to Storage Transfer Service. This service
        /// account is created and owned by Storage Transfer Service and can
        /// only be used by Storage Transfer Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GoogleServiceAccount> GetGoogleServiceAccountAsync(GetGoogleServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            GetGoogleServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a transfer job that runs periodically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferJob CreateTransferJob(CreateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a transfer job that runs periodically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferJob> CreateTransferJobAsync(CreateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a transfer job that runs periodically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferJob> CreateTransferJobAsync(CreateTransferJobRequest request, st::CancellationToken cancellationToken) =>
            CreateTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a transfer job. Updating a job's transfer spec does not affect
        /// transfer operations that are running already.
        /// 
        /// **Note:** The job's [status][google.storagetransfer.v1.TransferJob.status]
        /// field can be modified using this RPC (for example, to set a job's status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED],
        /// [DISABLED][google.storagetransfer.v1.TransferJob.Status.DISABLED], or
        /// [ENABLED][google.storagetransfer.v1.TransferJob.Status.ENABLED]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferJob UpdateTransferJob(UpdateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a transfer job. Updating a job's transfer spec does not affect
        /// transfer operations that are running already.
        /// 
        /// **Note:** The job's [status][google.storagetransfer.v1.TransferJob.status]
        /// field can be modified using this RPC (for example, to set a job's status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED],
        /// [DISABLED][google.storagetransfer.v1.TransferJob.Status.DISABLED], or
        /// [ENABLED][google.storagetransfer.v1.TransferJob.Status.ENABLED]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferJob> UpdateTransferJobAsync(UpdateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a transfer job. Updating a job's transfer spec does not affect
        /// transfer operations that are running already.
        /// 
        /// **Note:** The job's [status][google.storagetransfer.v1.TransferJob.status]
        /// field can be modified using this RPC (for example, to set a job's status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED],
        /// [DISABLED][google.storagetransfer.v1.TransferJob.Status.DISABLED], or
        /// [ENABLED][google.storagetransfer.v1.TransferJob.Status.ENABLED]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferJob> UpdateTransferJobAsync(UpdateTransferJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a transfer job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransferJob GetTransferJob(GetTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a transfer job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferJob> GetTransferJobAsync(GetTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a transfer job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransferJob> GetTransferJobAsync(GetTransferJobRequest request, st::CancellationToken cancellationToken) =>
            GetTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists transfer jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferJobsResponse, TransferJob> ListTransferJobs(ListTransferJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists transfer jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferJobsResponse, TransferJob> ListTransferJobsAsync(ListTransferJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a transfer operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseTransferOperation(PauseTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a transfer operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseTransferOperationAsync(PauseTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a transfer operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseTransferOperationAsync(PauseTransferOperationRequest request, st::CancellationToken cancellationToken) =>
            PauseTransferOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a transfer operation that is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeTransferOperation(ResumeTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a transfer operation that is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeTransferOperationAsync(ResumeTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a transfer operation that is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeTransferOperationAsync(ResumeTransferOperationRequest request, st::CancellationToken cancellationToken) =>
            ResumeTransferOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a new operation for the specified transfer job.
        /// A `TransferJob` has a maximum of one active `TransferOperation`. If this
        /// method is called while a `TransferOperation` is active, an error is
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, TransferOperation> RunTransferJob(RunTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a new operation for the specified transfer job.
        /// A `TransferJob` has a maximum of one active `TransferOperation`. If this
        /// method is called while a `TransferOperation` is active, an error is
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, TransferOperation>> RunTransferJobAsync(RunTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a new operation for the specified transfer job.
        /// A `TransferJob` has a maximum of one active `TransferOperation`. If this
        /// method is called while a `TransferOperation` is active, an error is
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, TransferOperation>> RunTransferJobAsync(RunTransferJobRequest request, st::CancellationToken cancellationToken) =>
            RunTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunTransferJob</c>.</summary>
        public virtual lro::OperationsClient RunTransferJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunTransferJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, TransferOperation> PollOnceRunTransferJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, TransferOperation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunTransferJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunTransferJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, TransferOperation>> PollOnceRunTransferJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, TransferOperation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunTransferJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a transfer job. Deleting a transfer job sets its status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransferJob(DeleteTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a transfer job. Deleting a transfer job sets its status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferJobAsync(DeleteTransferJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a transfer job. Deleting a transfer job sets its status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransferJobAsync(DeleteTransferJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteTransferJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentPool CreateAgentPool(CreateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> CreateAgentPoolAsync(CreateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> CreateAgentPoolAsync(CreateAgentPoolRequest request, st::CancellationToken cancellationToken) =>
            CreateAgentPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud project that owns the
        /// agent pool.
        /// </param>
        /// <param name="agentPool">
        /// Required. The agent pool to create.
        /// </param>
        /// <param name="agentPoolId">
        /// Required. The ID of the agent pool to create.
        /// 
        /// The `agent_pool_id` must meet the following requirements:
        /// 
        /// *   Length of 128 characters or less.
        /// *   Not start with the string `goog`.
        /// *   Start with a lowercase ASCII character, followed by:
        /// *   Zero or more: lowercase Latin alphabet characters, numerals,
        /// hyphens (`-`), periods (`.`), underscores (`_`), or tildes (`~`).
        /// *   One or more numerals or lowercase ASCII characters.
        /// 
        /// As expressed by the regular expression:
        /// `^(?!goog)[a-z]([a-z0-9-._~]*[a-z0-9])?$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentPool CreateAgentPool(string projectId, AgentPool agentPool, string agentPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentPool(new CreateAgentPoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                AgentPool = gax::GaxPreconditions.CheckNotNull(agentPool, nameof(agentPool)),
                AgentPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentPoolId, nameof(agentPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud project that owns the
        /// agent pool.
        /// </param>
        /// <param name="agentPool">
        /// Required. The agent pool to create.
        /// </param>
        /// <param name="agentPoolId">
        /// Required. The ID of the agent pool to create.
        /// 
        /// The `agent_pool_id` must meet the following requirements:
        /// 
        /// *   Length of 128 characters or less.
        /// *   Not start with the string `goog`.
        /// *   Start with a lowercase ASCII character, followed by:
        /// *   Zero or more: lowercase Latin alphabet characters, numerals,
        /// hyphens (`-`), periods (`.`), underscores (`_`), or tildes (`~`).
        /// *   One or more numerals or lowercase ASCII characters.
        /// 
        /// As expressed by the regular expression:
        /// `^(?!goog)[a-z]([a-z0-9-._~]*[a-z0-9])?$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> CreateAgentPoolAsync(string projectId, AgentPool agentPool, string agentPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentPoolAsync(new CreateAgentPoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                AgentPool = gax::GaxPreconditions.CheckNotNull(agentPool, nameof(agentPool)),
                AgentPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentPoolId, nameof(agentPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud project that owns the
        /// agent pool.
        /// </param>
        /// <param name="agentPool">
        /// Required. The agent pool to create.
        /// </param>
        /// <param name="agentPoolId">
        /// Required. The ID of the agent pool to create.
        /// 
        /// The `agent_pool_id` must meet the following requirements:
        /// 
        /// *   Length of 128 characters or less.
        /// *   Not start with the string `goog`.
        /// *   Start with a lowercase ASCII character, followed by:
        /// *   Zero or more: lowercase Latin alphabet characters, numerals,
        /// hyphens (`-`), periods (`.`), underscores (`_`), or tildes (`~`).
        /// *   One or more numerals or lowercase ASCII characters.
        /// 
        /// As expressed by the regular expression:
        /// `^(?!goog)[a-z]([a-z0-9-._~]*[a-z0-9])?$`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> CreateAgentPoolAsync(string projectId, AgentPool agentPool, string agentPoolId, st::CancellationToken cancellationToken) =>
            CreateAgentPoolAsync(projectId, agentPool, agentPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentPool UpdateAgentPool(UpdateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> UpdateAgentPoolAsync(UpdateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> UpdateAgentPoolAsync(UpdateAgentPoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateAgentPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="agentPool">
        /// Required. The agent pool to update. `agent_pool` is expected to specify
        /// following fields:
        /// 
        /// *  [name][google.storagetransfer.v1.AgentPool.name]
        /// 
        /// *  [display_name][google.storagetransfer.v1.AgentPool.display_name]
        /// 
        /// *  [bandwidth_limit][google.storagetransfer.v1.AgentPool.bandwidth_limit]
        /// An `UpdateAgentPoolRequest` with any other fields is rejected
        /// with the error [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT].
        /// </param>
        /// <param name="updateMask">
        /// The [field mask]
        /// (https://developers.google.com/protocol-buffers/docs/reference/google.protobuf)
        /// of the fields in `agentPool` to update in this request.
        /// The following `agentPool` fields can be updated:
        /// 
        /// *  [display_name][google.storagetransfer.v1.AgentPool.display_name]
        /// 
        /// *  [bandwidth_limit][google.storagetransfer.v1.AgentPool.bandwidth_limit]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentPool UpdateAgentPool(AgentPool agentPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAgentPool(new UpdateAgentPoolRequest
            {
                AgentPool = gax::GaxPreconditions.CheckNotNull(agentPool, nameof(agentPool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="agentPool">
        /// Required. The agent pool to update. `agent_pool` is expected to specify
        /// following fields:
        /// 
        /// *  [name][google.storagetransfer.v1.AgentPool.name]
        /// 
        /// *  [display_name][google.storagetransfer.v1.AgentPool.display_name]
        /// 
        /// *  [bandwidth_limit][google.storagetransfer.v1.AgentPool.bandwidth_limit]
        /// An `UpdateAgentPoolRequest` with any other fields is rejected
        /// with the error [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT].
        /// </param>
        /// <param name="updateMask">
        /// The [field mask]
        /// (https://developers.google.com/protocol-buffers/docs/reference/google.protobuf)
        /// of the fields in `agentPool` to update in this request.
        /// The following `agentPool` fields can be updated:
        /// 
        /// *  [display_name][google.storagetransfer.v1.AgentPool.display_name]
        /// 
        /// *  [bandwidth_limit][google.storagetransfer.v1.AgentPool.bandwidth_limit]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> UpdateAgentPoolAsync(AgentPool agentPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAgentPoolAsync(new UpdateAgentPoolRequest
            {
                AgentPool = gax::GaxPreconditions.CheckNotNull(agentPool, nameof(agentPool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="agentPool">
        /// Required. The agent pool to update. `agent_pool` is expected to specify
        /// following fields:
        /// 
        /// *  [name][google.storagetransfer.v1.AgentPool.name]
        /// 
        /// *  [display_name][google.storagetransfer.v1.AgentPool.display_name]
        /// 
        /// *  [bandwidth_limit][google.storagetransfer.v1.AgentPool.bandwidth_limit]
        /// An `UpdateAgentPoolRequest` with any other fields is rejected
        /// with the error [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT].
        /// </param>
        /// <param name="updateMask">
        /// The [field mask]
        /// (https://developers.google.com/protocol-buffers/docs/reference/google.protobuf)
        /// of the fields in `agentPool` to update in this request.
        /// The following `agentPool` fields can be updated:
        /// 
        /// *  [display_name][google.storagetransfer.v1.AgentPool.display_name]
        /// 
        /// *  [bandwidth_limit][google.storagetransfer.v1.AgentPool.bandwidth_limit]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> UpdateAgentPoolAsync(AgentPool agentPool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAgentPoolAsync(agentPool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentPool GetAgentPool(GetAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> GetAgentPoolAsync(GetAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> GetAgentPoolAsync(GetAgentPoolRequest request, st::CancellationToken cancellationToken) =>
            GetAgentPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent pool to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentPool GetAgentPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentPool(new GetAgentPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent pool to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> GetAgentPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentPoolAsync(new GetAgentPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent pool to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentPool> GetAgentPoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetAgentPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists agent pools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AgentPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentPoolsResponse, AgentPool> ListAgentPools(ListAgentPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists agent pools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AgentPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentPoolsResponse, AgentPool> ListAgentPoolsAsync(ListAgentPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists agent pools.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud project that owns the job.
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
        /// <returns>A pageable sequence of <see cref="AgentPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentPoolsResponse, AgentPool> ListAgentPools(string projectId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentPoolsRequest request = new ListAgentPoolsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAgentPools(request, callSettings);
        }

        /// <summary>
        /// Lists agent pools.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud project that owns the job.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AgentPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentPoolsResponse, AgentPool> ListAgentPoolsAsync(string projectId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentPoolsRequest request = new ListAgentPoolsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAgentPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgentPool(DeleteAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentPoolAsync(DeleteAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentPoolAsync(DeleteAgentPoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteAgentPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent pool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgentPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentPool(new DeleteAgentPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent pool to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentPoolAsync(new DeleteAgentPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent pool to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentPoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAgentPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>StorageTransferService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Storage Transfer Service and its protos.
    /// Transfers data between between Google Cloud Storage buckets or from a data
    /// source external to Google to a Cloud Storage bucket.
    /// </remarks>
    public sealed partial class StorageTransferServiceClientImpl : StorageTransferServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGoogleServiceAccountRequest, GoogleServiceAccount> _callGetGoogleServiceAccount;

        private readonly gaxgrpc::ApiCall<CreateTransferJobRequest, TransferJob> _callCreateTransferJob;

        private readonly gaxgrpc::ApiCall<UpdateTransferJobRequest, TransferJob> _callUpdateTransferJob;

        private readonly gaxgrpc::ApiCall<GetTransferJobRequest, TransferJob> _callGetTransferJob;

        private readonly gaxgrpc::ApiCall<ListTransferJobsRequest, ListTransferJobsResponse> _callListTransferJobs;

        private readonly gaxgrpc::ApiCall<PauseTransferOperationRequest, wkt::Empty> _callPauseTransferOperation;

        private readonly gaxgrpc::ApiCall<ResumeTransferOperationRequest, wkt::Empty> _callResumeTransferOperation;

        private readonly gaxgrpc::ApiCall<RunTransferJobRequest, lro::Operation> _callRunTransferJob;

        private readonly gaxgrpc::ApiCall<DeleteTransferJobRequest, wkt::Empty> _callDeleteTransferJob;

        private readonly gaxgrpc::ApiCall<CreateAgentPoolRequest, AgentPool> _callCreateAgentPool;

        private readonly gaxgrpc::ApiCall<UpdateAgentPoolRequest, AgentPool> _callUpdateAgentPool;

        private readonly gaxgrpc::ApiCall<GetAgentPoolRequest, AgentPool> _callGetAgentPool;

        private readonly gaxgrpc::ApiCall<ListAgentPoolsRequest, ListAgentPoolsResponse> _callListAgentPools;

        private readonly gaxgrpc::ApiCall<DeleteAgentPoolRequest, wkt::Empty> _callDeleteAgentPool;

        /// <summary>
        /// Constructs a client wrapper for the StorageTransferService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="StorageTransferServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StorageTransferServiceClientImpl(StorageTransferService.StorageTransferServiceClient grpcClient, StorageTransferServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StorageTransferServiceSettings effectiveSettings = settings ?? StorageTransferServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RunTransferJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunTransferJobOperationsSettings, logger);
            _callGetGoogleServiceAccount = clientHelper.BuildApiCall<GetGoogleServiceAccountRequest, GoogleServiceAccount>("GetGoogleServiceAccount", grpcClient.GetGoogleServiceAccountAsync, grpcClient.GetGoogleServiceAccount, effectiveSettings.GetGoogleServiceAccountSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callGetGoogleServiceAccount);
            Modify_GetGoogleServiceAccountApiCall(ref _callGetGoogleServiceAccount);
            _callCreateTransferJob = clientHelper.BuildApiCall<CreateTransferJobRequest, TransferJob>("CreateTransferJob", grpcClient.CreateTransferJobAsync, grpcClient.CreateTransferJob, effectiveSettings.CreateTransferJobSettings);
            Modify_ApiCall(ref _callCreateTransferJob);
            Modify_CreateTransferJobApiCall(ref _callCreateTransferJob);
            _callUpdateTransferJob = clientHelper.BuildApiCall<UpdateTransferJobRequest, TransferJob>("UpdateTransferJob", grpcClient.UpdateTransferJobAsync, grpcClient.UpdateTransferJob, effectiveSettings.UpdateTransferJobSettings).WithGoogleRequestParam("job_name", request => request.JobName);
            Modify_ApiCall(ref _callUpdateTransferJob);
            Modify_UpdateTransferJobApiCall(ref _callUpdateTransferJob);
            _callGetTransferJob = clientHelper.BuildApiCall<GetTransferJobRequest, TransferJob>("GetTransferJob", grpcClient.GetTransferJobAsync, grpcClient.GetTransferJob, effectiveSettings.GetTransferJobSettings).WithGoogleRequestParam("job_name", request => request.JobName);
            Modify_ApiCall(ref _callGetTransferJob);
            Modify_GetTransferJobApiCall(ref _callGetTransferJob);
            _callListTransferJobs = clientHelper.BuildApiCall<ListTransferJobsRequest, ListTransferJobsResponse>("ListTransferJobs", grpcClient.ListTransferJobsAsync, grpcClient.ListTransferJobs, effectiveSettings.ListTransferJobsSettings);
            Modify_ApiCall(ref _callListTransferJobs);
            Modify_ListTransferJobsApiCall(ref _callListTransferJobs);
            _callPauseTransferOperation = clientHelper.BuildApiCall<PauseTransferOperationRequest, wkt::Empty>("PauseTransferOperation", grpcClient.PauseTransferOperationAsync, grpcClient.PauseTransferOperation, effectiveSettings.PauseTransferOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseTransferOperation);
            Modify_PauseTransferOperationApiCall(ref _callPauseTransferOperation);
            _callResumeTransferOperation = clientHelper.BuildApiCall<ResumeTransferOperationRequest, wkt::Empty>("ResumeTransferOperation", grpcClient.ResumeTransferOperationAsync, grpcClient.ResumeTransferOperation, effectiveSettings.ResumeTransferOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeTransferOperation);
            Modify_ResumeTransferOperationApiCall(ref _callResumeTransferOperation);
            _callRunTransferJob = clientHelper.BuildApiCall<RunTransferJobRequest, lro::Operation>("RunTransferJob", grpcClient.RunTransferJobAsync, grpcClient.RunTransferJob, effectiveSettings.RunTransferJobSettings).WithGoogleRequestParam("job_name", request => request.JobName);
            Modify_ApiCall(ref _callRunTransferJob);
            Modify_RunTransferJobApiCall(ref _callRunTransferJob);
            _callDeleteTransferJob = clientHelper.BuildApiCall<DeleteTransferJobRequest, wkt::Empty>("DeleteTransferJob", grpcClient.DeleteTransferJobAsync, grpcClient.DeleteTransferJob, effectiveSettings.DeleteTransferJobSettings).WithGoogleRequestParam("job_name", request => request.JobName);
            Modify_ApiCall(ref _callDeleteTransferJob);
            Modify_DeleteTransferJobApiCall(ref _callDeleteTransferJob);
            _callCreateAgentPool = clientHelper.BuildApiCall<CreateAgentPoolRequest, AgentPool>("CreateAgentPool", grpcClient.CreateAgentPoolAsync, grpcClient.CreateAgentPool, effectiveSettings.CreateAgentPoolSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callCreateAgentPool);
            Modify_CreateAgentPoolApiCall(ref _callCreateAgentPool);
            _callUpdateAgentPool = clientHelper.BuildApiCall<UpdateAgentPoolRequest, AgentPool>("UpdateAgentPool", grpcClient.UpdateAgentPoolAsync, grpcClient.UpdateAgentPool, effectiveSettings.UpdateAgentPoolSettings).WithGoogleRequestParam("agent_pool.name", request => request.AgentPool?.Name);
            Modify_ApiCall(ref _callUpdateAgentPool);
            Modify_UpdateAgentPoolApiCall(ref _callUpdateAgentPool);
            _callGetAgentPool = clientHelper.BuildApiCall<GetAgentPoolRequest, AgentPool>("GetAgentPool", grpcClient.GetAgentPoolAsync, grpcClient.GetAgentPool, effectiveSettings.GetAgentPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAgentPool);
            Modify_GetAgentPoolApiCall(ref _callGetAgentPool);
            _callListAgentPools = clientHelper.BuildApiCall<ListAgentPoolsRequest, ListAgentPoolsResponse>("ListAgentPools", grpcClient.ListAgentPoolsAsync, grpcClient.ListAgentPools, effectiveSettings.ListAgentPoolsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callListAgentPools);
            Modify_ListAgentPoolsApiCall(ref _callListAgentPools);
            _callDeleteAgentPool = clientHelper.BuildApiCall<DeleteAgentPoolRequest, wkt::Empty>("DeleteAgentPool", grpcClient.DeleteAgentPoolAsync, grpcClient.DeleteAgentPool, effectiveSettings.DeleteAgentPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAgentPool);
            Modify_DeleteAgentPoolApiCall(ref _callDeleteAgentPool);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetGoogleServiceAccountApiCall(ref gaxgrpc::ApiCall<GetGoogleServiceAccountRequest, GoogleServiceAccount> call);

        partial void Modify_CreateTransferJobApiCall(ref gaxgrpc::ApiCall<CreateTransferJobRequest, TransferJob> call);

        partial void Modify_UpdateTransferJobApiCall(ref gaxgrpc::ApiCall<UpdateTransferJobRequest, TransferJob> call);

        partial void Modify_GetTransferJobApiCall(ref gaxgrpc::ApiCall<GetTransferJobRequest, TransferJob> call);

        partial void Modify_ListTransferJobsApiCall(ref gaxgrpc::ApiCall<ListTransferJobsRequest, ListTransferJobsResponse> call);

        partial void Modify_PauseTransferOperationApiCall(ref gaxgrpc::ApiCall<PauseTransferOperationRequest, wkt::Empty> call);

        partial void Modify_ResumeTransferOperationApiCall(ref gaxgrpc::ApiCall<ResumeTransferOperationRequest, wkt::Empty> call);

        partial void Modify_RunTransferJobApiCall(ref gaxgrpc::ApiCall<RunTransferJobRequest, lro::Operation> call);

        partial void Modify_DeleteTransferJobApiCall(ref gaxgrpc::ApiCall<DeleteTransferJobRequest, wkt::Empty> call);

        partial void Modify_CreateAgentPoolApiCall(ref gaxgrpc::ApiCall<CreateAgentPoolRequest, AgentPool> call);

        partial void Modify_UpdateAgentPoolApiCall(ref gaxgrpc::ApiCall<UpdateAgentPoolRequest, AgentPool> call);

        partial void Modify_GetAgentPoolApiCall(ref gaxgrpc::ApiCall<GetAgentPoolRequest, AgentPool> call);

        partial void Modify_ListAgentPoolsApiCall(ref gaxgrpc::ApiCall<ListAgentPoolsRequest, ListAgentPoolsResponse> call);

        partial void Modify_DeleteAgentPoolApiCall(ref gaxgrpc::ApiCall<DeleteAgentPoolRequest, wkt::Empty> call);

        partial void OnConstruction(StorageTransferService.StorageTransferServiceClient grpcClient, StorageTransferServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StorageTransferService client</summary>
        public override StorageTransferService.StorageTransferServiceClient GrpcClient { get; }

        partial void Modify_GetGoogleServiceAccountRequest(ref GetGoogleServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTransferJobRequest(ref CreateTransferJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTransferJobRequest(ref UpdateTransferJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTransferJobRequest(ref GetTransferJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTransferJobsRequest(ref ListTransferJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseTransferOperationRequest(ref PauseTransferOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeTransferOperationRequest(ref ResumeTransferOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunTransferJobRequest(ref RunTransferJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTransferJobRequest(ref DeleteTransferJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAgentPoolRequest(ref CreateAgentPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAgentPoolRequest(ref UpdateAgentPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAgentPoolRequest(ref GetAgentPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAgentPoolsRequest(ref ListAgentPoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAgentPoolRequest(ref DeleteAgentPoolRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the Google service account that is used by Storage Transfer
        /// Service to access buckets in the project where transfers
        /// run or in other projects. Each Google service account is associated
        /// with one Google Cloud project. Users
        /// should add this service account to the Google Cloud Storage bucket
        /// ACLs to grant access to Storage Transfer Service. This service
        /// account is created and owned by Storage Transfer Service and can
        /// only be used by Storage Transfer Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GoogleServiceAccount GetGoogleServiceAccount(GetGoogleServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleServiceAccountRequest(ref request, ref callSettings);
            return _callGetGoogleServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Google service account that is used by Storage Transfer
        /// Service to access buckets in the project where transfers
        /// run or in other projects. Each Google service account is associated
        /// with one Google Cloud project. Users
        /// should add this service account to the Google Cloud Storage bucket
        /// ACLs to grant access to Storage Transfer Service. This service
        /// account is created and owned by Storage Transfer Service and can
        /// only be used by Storage Transfer Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GoogleServiceAccount> GetGoogleServiceAccountAsync(GetGoogleServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleServiceAccountRequest(ref request, ref callSettings);
            return _callGetGoogleServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a transfer job that runs periodically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferJob CreateTransferJob(CreateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransferJobRequest(ref request, ref callSettings);
            return _callCreateTransferJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a transfer job that runs periodically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferJob> CreateTransferJobAsync(CreateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransferJobRequest(ref request, ref callSettings);
            return _callCreateTransferJob.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a transfer job. Updating a job's transfer spec does not affect
        /// transfer operations that are running already.
        /// 
        /// **Note:** The job's [status][google.storagetransfer.v1.TransferJob.status]
        /// field can be modified using this RPC (for example, to set a job's status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED],
        /// [DISABLED][google.storagetransfer.v1.TransferJob.Status.DISABLED], or
        /// [ENABLED][google.storagetransfer.v1.TransferJob.Status.ENABLED]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferJob UpdateTransferJob(UpdateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferJobRequest(ref request, ref callSettings);
            return _callUpdateTransferJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a transfer job. Updating a job's transfer spec does not affect
        /// transfer operations that are running already.
        /// 
        /// **Note:** The job's [status][google.storagetransfer.v1.TransferJob.status]
        /// field can be modified using this RPC (for example, to set a job's status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED],
        /// [DISABLED][google.storagetransfer.v1.TransferJob.Status.DISABLED], or
        /// [ENABLED][google.storagetransfer.v1.TransferJob.Status.ENABLED]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferJob> UpdateTransferJobAsync(UpdateTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferJobRequest(ref request, ref callSettings);
            return _callUpdateTransferJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a transfer job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransferJob GetTransferJob(GetTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferJobRequest(ref request, ref callSettings);
            return _callGetTransferJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a transfer job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransferJob> GetTransferJobAsync(GetTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferJobRequest(ref request, ref callSettings);
            return _callGetTransferJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists transfer jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransferJobsResponse, TransferJob> ListTransferJobs(ListTransferJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransferJobsRequest, ListTransferJobsResponse, TransferJob>(_callListTransferJobs, request, callSettings);
        }

        /// <summary>
        /// Lists transfer jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransferJobsResponse, TransferJob> ListTransferJobsAsync(ListTransferJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransferJobsRequest, ListTransferJobsResponse, TransferJob>(_callListTransferJobs, request, callSettings);
        }

        /// <summary>
        /// Pauses a transfer operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void PauseTransferOperation(PauseTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseTransferOperationRequest(ref request, ref callSettings);
            _callPauseTransferOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses a transfer operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task PauseTransferOperationAsync(PauseTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseTransferOperationRequest(ref request, ref callSettings);
            return _callPauseTransferOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes a transfer operation that is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ResumeTransferOperation(ResumeTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeTransferOperationRequest(ref request, ref callSettings);
            _callResumeTransferOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes a transfer operation that is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ResumeTransferOperationAsync(ResumeTransferOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeTransferOperationRequest(ref request, ref callSettings);
            return _callResumeTransferOperation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunTransferJob</c>.</summary>
        public override lro::OperationsClient RunTransferJobOperationsClient { get; }

        /// <summary>
        /// Starts a new operation for the specified transfer job.
        /// A `TransferJob` has a maximum of one active `TransferOperation`. If this
        /// method is called while a `TransferOperation` is active, an error is
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, TransferOperation> RunTransferJob(RunTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTransferJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, TransferOperation>(_callRunTransferJob.Sync(request, callSettings), RunTransferJobOperationsClient);
        }

        /// <summary>
        /// Starts a new operation for the specified transfer job.
        /// A `TransferJob` has a maximum of one active `TransferOperation`. If this
        /// method is called while a `TransferOperation` is active, an error is
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, TransferOperation>> RunTransferJobAsync(RunTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTransferJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, TransferOperation>(await _callRunTransferJob.Async(request, callSettings).ConfigureAwait(false), RunTransferJobOperationsClient);
        }

        /// <summary>
        /// Deletes a transfer job. Deleting a transfer job sets its status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTransferJob(DeleteTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferJobRequest(ref request, ref callSettings);
            _callDeleteTransferJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a transfer job. Deleting a transfer job sets its status to
        /// [DELETED][google.storagetransfer.v1.TransferJob.Status.DELETED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTransferJobAsync(DeleteTransferJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferJobRequest(ref request, ref callSettings);
            return _callDeleteTransferJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AgentPool CreateAgentPool(CreateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentPoolRequest(ref request, ref callSettings);
            return _callCreateAgentPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AgentPool> CreateAgentPoolAsync(CreateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentPoolRequest(ref request, ref callSettings);
            return _callCreateAgentPool.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AgentPool UpdateAgentPool(UpdateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAgentPoolRequest(ref request, ref callSettings);
            return _callUpdateAgentPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing agent pool resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AgentPool> UpdateAgentPoolAsync(UpdateAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAgentPoolRequest(ref request, ref callSettings);
            return _callUpdateAgentPool.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AgentPool GetAgentPool(GetAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentPoolRequest(ref request, ref callSettings);
            return _callGetAgentPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AgentPool> GetAgentPoolAsync(GetAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentPoolRequest(ref request, ref callSettings);
            return _callGetAgentPool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists agent pools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AgentPool"/> resources.</returns>
        public override gax::PagedEnumerable<ListAgentPoolsResponse, AgentPool> ListAgentPools(ListAgentPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAgentPoolsRequest, ListAgentPoolsResponse, AgentPool>(_callListAgentPools, request, callSettings);
        }

        /// <summary>
        /// Lists agent pools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AgentPool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAgentPoolsResponse, AgentPool> ListAgentPoolsAsync(ListAgentPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAgentPoolsRequest, ListAgentPoolsResponse, AgentPool>(_callListAgentPools, request, callSettings);
        }

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAgentPool(DeleteAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentPoolRequest(ref request, ref callSettings);
            _callDeleteAgentPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an agent pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAgentPoolAsync(DeleteAgentPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentPoolRequest(ref request, ref callSettings);
            return _callDeleteAgentPool.Async(request, callSettings);
        }
    }

    public partial class ListTransferJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAgentPoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransferJobsResponse : gaxgrpc::IPageResponse<TransferJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TransferJob> GetEnumerator() => TransferJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAgentPoolsResponse : gaxgrpc::IPageResponse<AgentPool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AgentPool> GetEnumerator() => AgentPools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class StorageTransferService
    {
        public partial class StorageTransferServiceClient
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
}
