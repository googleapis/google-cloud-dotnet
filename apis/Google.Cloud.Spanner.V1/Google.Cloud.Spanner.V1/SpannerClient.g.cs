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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcscv = Google.Cloud.Spanner.Common.V1;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>Settings for <see cref="SpannerClient"/> instances.</summary>
    public sealed partial class SpannerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SpannerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SpannerSettings"/>.</returns>
        public static SpannerSettings GetDefault() => new SpannerSettings();

        /// <summary>Constructs a new <see cref="SpannerSettings"/> object with default settings.</summary>
        public SpannerSettings()
        {
        }

        private SpannerSettings(SpannerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSessionSettings = existing.CreateSessionSettings;
            BatchCreateSessionsSettings = existing.BatchCreateSessionsSettings;
            GetSessionSettings = existing.GetSessionSettings;
            ListSessionsSettings = existing.ListSessionsSettings;
            DeleteSessionSettings = existing.DeleteSessionSettings;
            ExecuteSqlSettings = existing.ExecuteSqlSettings;
            ExecuteStreamingSqlSettings = existing.ExecuteStreamingSqlSettings;
            ExecuteBatchDmlSettings = existing.ExecuteBatchDmlSettings;
            ReadSettings = existing.ReadSettings;
            StreamingReadSettings = existing.StreamingReadSettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            PartitionQuerySettings = existing.PartitionQuerySettings;
            PartitionReadSettings = existing.PartitionReadSettings;
            BatchWriteSettings = existing.BatchWriteSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpannerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.CreateSession</c>
        ///  and <c>SpannerClient.CreateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.BatchCreateSessions</c> and <c>SpannerClient.BatchCreateSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateSessionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.GetSession</c>
        ///  and <c>SpannerClient.GetSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.ListSessions</c>
        ///  and <c>SpannerClient.ListSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.DeleteSession</c>
        ///  and <c>SpannerClient.DeleteSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.ExecuteSql</c>
        ///  and <c>SpannerClient.ExecuteSqlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteSqlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.ExecuteStreamingSql</c> and <c>SpannerClient.ExecuteStreamingSqlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteStreamingSqlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.ExecuteBatchDml</c> and <c>SpannerClient.ExecuteBatchDmlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteBatchDmlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.Read</c> and
        /// <c>SpannerClient.ReadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.StreamingRead</c>
        ///  and <c>SpannerClient.StreamingReadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingReadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.BeginTransaction</c> and <c>SpannerClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BeginTransactionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.Commit</c>
        /// and <c>SpannerClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.Rollback</c>
        /// and <c>SpannerClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpannerClient.PartitionQuery</c> and <c>SpannerClient.PartitionQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PartitionQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.PartitionRead</c>
        ///  and <c>SpannerClient.PartitionReadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PartitionReadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpannerClient.BatchWrite</c>
        ///  and <c>SpannerClient.BatchWriteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchWriteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SpannerSettings"/> object.</returns>
        public SpannerSettings Clone() => new SpannerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SpannerClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SpannerClientBuilder : gaxgrpc::ClientBuilderBase<SpannerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SpannerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SpannerClientBuilder() : base(SpannerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SpannerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SpannerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SpannerClient Build()
        {
            SpannerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SpannerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SpannerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SpannerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SpannerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SpannerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SpannerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SpannerClient.ChannelPool;
    }

    /// <summary>Spanner client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Spanner API
    /// 
    /// The Cloud Spanner API can be used to manage sessions and execute
    /// transactions on data stored in Cloud Spanner databases.
    /// </remarks>
    public abstract partial class SpannerClient
    {
        /// <summary>
        /// The default endpoint for the Spanner service, which is a host of "spanner.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "spanner.googleapis.com:443";

        /// <summary>The default Spanner scopes.</summary>
        /// <remarks>
        /// The default Spanner scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/spanner.data</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.data",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Spanner.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SpannerClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="SpannerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SpannerClient"/>.</returns>
        public static stt::Task<SpannerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SpannerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SpannerClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="SpannerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SpannerClient"/>.</returns>
        public static SpannerClient Create() => new SpannerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SpannerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SpannerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SpannerClient"/>.</returns>
        internal static SpannerClient Create(grpccore::CallInvoker callInvoker, SpannerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Spanner.SpannerClient grpcClient = new Spanner.SpannerClient(callInvoker);
            return new SpannerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Spanner client</summary>
        public virtual Spanner.SpannerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(string database, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
            }, callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(string database, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
            }, callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(string database, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(database, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(gcscv::DatabaseName database, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
            }, callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(gcscv::DatabaseName database, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
            }, callSettings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new session is created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(gcscv::DatabaseName database, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(database, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSessionsResponse BatchCreateSessions(BatchCreateSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(BatchCreateSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(BatchCreateSessionsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateSessionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new sessions are created.
        /// </param>
        /// <param name="sessionCount">
        /// Required. The number of sessions to be created in this batch call.
        /// The API can return fewer than the requested number of sessions. If a
        /// specific number of sessions are desired, the client can make additional
        /// calls to `BatchCreateSessions` (adjusting
        /// [session_count][google.spanner.v1.BatchCreateSessionsRequest.session_count]
        /// as necessary).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSessionsResponse BatchCreateSessions(string database, int sessionCount, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSessions(new BatchCreateSessionsRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                SessionCount = sessionCount,
            }, callSettings);

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new sessions are created.
        /// </param>
        /// <param name="sessionCount">
        /// Required. The number of sessions to be created in this batch call.
        /// The API can return fewer than the requested number of sessions. If a
        /// specific number of sessions are desired, the client can make additional
        /// calls to `BatchCreateSessions` (adjusting
        /// [session_count][google.spanner.v1.BatchCreateSessionsRequest.session_count]
        /// as necessary).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(string database, int sessionCount, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSessionsAsync(new BatchCreateSessionsRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                SessionCount = sessionCount,
            }, callSettings);

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new sessions are created.
        /// </param>
        /// <param name="sessionCount">
        /// Required. The number of sessions to be created in this batch call.
        /// The API can return fewer than the requested number of sessions. If a
        /// specific number of sessions are desired, the client can make additional
        /// calls to `BatchCreateSessions` (adjusting
        /// [session_count][google.spanner.v1.BatchCreateSessionsRequest.session_count]
        /// as necessary).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(string database, int sessionCount, st::CancellationToken cancellationToken) =>
            BatchCreateSessionsAsync(database, sessionCount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new sessions are created.
        /// </param>
        /// <param name="sessionCount">
        /// Required. The number of sessions to be created in this batch call.
        /// The API can return fewer than the requested number of sessions. If a
        /// specific number of sessions are desired, the client can make additional
        /// calls to `BatchCreateSessions` (adjusting
        /// [session_count][google.spanner.v1.BatchCreateSessionsRequest.session_count]
        /// as necessary).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSessionsResponse BatchCreateSessions(gcscv::DatabaseName database, int sessionCount, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSessions(new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                SessionCount = sessionCount,
            }, callSettings);

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new sessions are created.
        /// </param>
        /// <param name="sessionCount">
        /// Required. The number of sessions to be created in this batch call.
        /// The API can return fewer than the requested number of sessions. If a
        /// specific number of sessions are desired, the client can make additional
        /// calls to `BatchCreateSessions` (adjusting
        /// [session_count][google.spanner.v1.BatchCreateSessionsRequest.session_count]
        /// as necessary).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(gcscv::DatabaseName database, int sessionCount, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSessionsAsync(new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                SessionCount = sessionCount,
            }, callSettings);

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which the new sessions are created.
        /// </param>
        /// <param name="sessionCount">
        /// Required. The number of sessions to be created in this batch call.
        /// The API can return fewer than the requested number of sessions. If a
        /// specific number of sessions are desired, the client can make additional
        /// calls to `BatchCreateSessions` (adjusting
        /// [session_count][google.spanner.v1.BatchCreateSessionsRequest.session_count]
        /// as necessary).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(gcscv::DatabaseName database, int sessionCount, st::CancellationToken cancellationToken) =>
            BatchCreateSessionsAsync(database, sessionCount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, st::CancellationToken cancellationToken) =>
            GetSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which to list sessions.
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(string database, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which to list sessions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(string database, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which to list sessions.
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(gcscv::DatabaseName database, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="database">
        /// Required. The database in which to list sessions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(gcscv::DatabaseName database, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                DatabaseAsDatabaseName = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(DeleteSessionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes an SQL statement, returning all results in a single reply. This
        /// method can't be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        /// 
        /// Operations inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql]
        /// instead.
        /// 
        /// The query string can be SQL or [Graph Query Language
        /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResultSet ExecuteSql(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes an SQL statement, returning all results in a single reply. This
        /// method can't be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        /// 
        /// Operations inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql]
        /// instead.
        /// 
        /// The query string can be SQL or [Graph Query Language
        /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes an SQL statement, returning all results in a single reply. This
        /// method can't be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        /// 
        /// Operations inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql]
        /// instead.
        /// 
        /// The query string can be SQL or [Graph Query Language
        /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, st::CancellationToken cancellationToken) =>
            ExecuteSqlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="ExecuteStreamingSql(ExecuteSqlRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ExecuteStreamingSqlStream : gaxgrpc::ServerStreamingBase<PartialResultSet>
        {
        }

        /// <summary>
        /// Like [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], except returns the
        /// result set as a stream. Unlike
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], there is no limit on
        /// the size of the returned result set. However, no individual row in the
        /// result set can exceed 100 MiB, and no column value can exceed 10 MiB.
        /// 
        /// The query string can be SQL or [Graph Query Language
        /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ExecuteStreamingSqlStream ExecuteStreamingSql(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a batch of SQL DML statements. This method allows many statements
        /// to be run with lower latency than submitting them sequentially with
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].
        /// 
        /// Statements are executed in sequential order. A request can succeed even if
        /// a statement fails. The
        /// [ExecuteBatchDmlResponse.status][google.spanner.v1.ExecuteBatchDmlResponse.status]
        /// field in the response provides information about the statement that failed.
        /// Clients must inspect this field to determine whether an error occurred.
        /// 
        /// Execution stops after the first failed statement; the remaining statements
        /// are not executed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteBatchDmlResponse ExecuteBatchDml(ExecuteBatchDmlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a batch of SQL DML statements. This method allows many statements
        /// to be run with lower latency than submitting them sequentially with
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].
        /// 
        /// Statements are executed in sequential order. A request can succeed even if
        /// a statement fails. The
        /// [ExecuteBatchDmlResponse.status][google.spanner.v1.ExecuteBatchDmlResponse.status]
        /// field in the response provides information about the statement that failed.
        /// Clients must inspect this field to determine whether an error occurred.
        /// 
        /// Execution stops after the first failed statement; the remaining statements
        /// are not executed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a batch of SQL DML statements. This method allows many statements
        /// to be run with lower latency than submitting them sequentially with
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].
        /// 
        /// Statements are executed in sequential order. A request can succeed even if
        /// a statement fails. The
        /// [ExecuteBatchDmlResponse.status][google.spanner.v1.ExecuteBatchDmlResponse.status]
        /// field in the response provides information about the statement that failed.
        /// Clients must inspect this field to determine whether an error occurred.
        /// 
        /// Execution stops after the first failed statement; the remaining statements
        /// are not executed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, st::CancellationToken cancellationToken) =>
            ExecuteBatchDmlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql]. This method can't be
        /// used to return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        /// 
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResultSet Read(ReadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql]. This method can't be
        /// used to return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        /// 
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResultSet> ReadAsync(ReadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql]. This method can't be
        /// used to return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        /// 
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResultSet> ReadAsync(ReadRequest request, st::CancellationToken cancellationToken) =>
            ReadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="StreamingRead(ReadRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class StreamingReadStream : gaxgrpc::ServerStreamingBase<PartialResultSet>
        {
        }

        /// <summary>
        /// Like [Read][google.spanner.v1.Spanner.Read], except returns the result set
        /// as a stream. Unlike [Read][google.spanner.v1.Spanner.Read], there is no
        /// limit on the size of the returned result set. However, no individual row in
        /// the result set can exceed 100 MiB, and no column value can exceed
        /// 10 MiB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamingReadStream StreamingRead(ReadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transaction BeginTransaction(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(BeginTransactionRequest request, st::CancellationToken cancellationToken) =>
            BeginTransactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transaction BeginTransaction(string session, TransactionOptions options, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransaction(new BeginTransactionRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                Options = gax::GaxPreconditions.CheckNotNull(options, nameof(options)),
            }, callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(string session, TransactionOptions options, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransactionAsync(new BeginTransactionRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                Options = gax::GaxPreconditions.CheckNotNull(options, nameof(options)),
            }, callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(string session, TransactionOptions options, st::CancellationToken cancellationToken) =>
            BeginTransactionAsync(session, options, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transaction BeginTransaction(SessionName session, TransactionOptions options, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransaction(new BeginTransactionRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                Options = gax::GaxPreconditions.CheckNotNull(options, nameof(options)),
            }, callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(SessionName session, TransactionOptions options, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransactionAsync(new BeginTransactionRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                Options = gax::GaxPreconditions.CheckNotNull(options, nameof(options)),
            }, callSettings);

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction runs.
        /// </param>
        /// <param name="options">
        /// Required. Options for the new transaction.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transaction> BeginTransactionAsync(SessionName session, TransactionOptions options, st::CancellationToken cancellationToken) =>
            BeginTransactionAsync(session, options, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(CommitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(CommitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(CommitRequest request, st::CancellationToken cancellationToken) =>
            CommitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(string session, proto::ByteString transactionId, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            Commit(new CommitRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                TransactionId = transactionId ?? proto::ByteString.Empty,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string session, proto::ByteString transactionId, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            CommitAsync(new CommitRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                TransactionId = transactionId ?? proto::ByteString.Empty,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string session, proto::ByteString transactionId, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            CommitAsync(session, transactionId, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(SessionName session, proto::ByteString transactionId, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            Commit(new CommitRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                TransactionId = transactionId ?? proto::ByteString.Empty,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(SessionName session, proto::ByteString transactionId, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            CommitAsync(new CommitRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                TransactionId = transactionId ?? proto::ByteString.Empty,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="transactionId">
        /// Commit a previously-started transaction.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(SessionName session, proto::ByteString transactionId, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            CommitAsync(session, transactionId, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it's possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(string session, TransactionOptions singleUseTransaction, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            Commit(new CommitRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                SingleUseTransaction = singleUseTransaction,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it's possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string session, TransactionOptions singleUseTransaction, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            CommitAsync(new CommitRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                SingleUseTransaction = singleUseTransaction,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it's possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string session, TransactionOptions singleUseTransaction, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            CommitAsync(session, singleUseTransaction, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it's possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(SessionName session, TransactionOptions singleUseTransaction, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            Commit(new CommitRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                SingleUseTransaction = singleUseTransaction,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it's possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(SessionName session, TransactionOptions singleUseTransaction, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            CommitAsync(new CommitRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                SingleUseTransaction = singleUseTransaction,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to be committed is running.
        /// </param>
        /// <param name="singleUseTransaction">
        /// Execute mutations in a temporary transaction. Note that unlike
        /// commit of a previously-started transaction, commit with a
        /// temporary transaction is non-idempotent. That is, if the
        /// `CommitRequest` is sent to Cloud Spanner more than once (for
        /// instance, due to retries in the application, or in the
        /// transport library), it's possible that the mutations are
        /// executed more than once. If this is undesirable, use
        /// [BeginTransaction][google.spanner.v1.Spanner.BeginTransaction] and
        /// [Commit][google.spanner.v1.Spanner.Commit] instead.
        /// </param>
        /// <param name="mutations">
        /// The mutations to be executed when this transaction commits. All
        /// mutations are applied atomically, in the order they appear in
        /// this list.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(SessionName session, TransactionOptions singleUseTransaction, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            CommitAsync(session, singleUseTransaction, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Rollback(RollbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(RollbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(RollbackRequest request, st::CancellationToken cancellationToken) =>
            RollbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Rollback(string session, proto::ByteString transactionId, gaxgrpc::CallSettings callSettings = null) =>
            Rollback(new RollbackRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                TransactionId = gax::GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(string session, proto::ByteString transactionId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAsync(new RollbackRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                TransactionId = gax::GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(string session, proto::ByteString transactionId, st::CancellationToken cancellationToken) =>
            RollbackAsync(session, transactionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Rollback(SessionName session, proto::ByteString transactionId, gaxgrpc::CallSettings callSettings = null) =>
            Rollback(new RollbackRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                TransactionId = gax::GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(SessionName session, proto::ByteString transactionId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAsync(new RollbackRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                TransactionId = gax::GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the transaction to roll back is running.
        /// </param>
        /// <param name="transactionId">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(SessionName session, proto::ByteString transactionId, st::CancellationToken cancellationToken) =>
            RollbackAsync(session, transactionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to
        /// specify a subset of the query result to read. The same session and
        /// read-only transaction must be used by the `PartitionQueryRequest` used to
        /// create the partition tokens and the `ExecuteSqlRequests` that use the
        /// partition tokens.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the query, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartitionResponse PartitionQuery(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to
        /// specify a subset of the query result to read. The same session and
        /// read-only transaction must be used by the `PartitionQueryRequest` used to
        /// create the partition tokens and the `ExecuteSqlRequests` that use the
        /// partition tokens.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the query, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to
        /// specify a subset of the query result to read. The same session and
        /// read-only transaction must be used by the `PartitionQueryRequest` used to
        /// create the partition tokens and the `ExecuteSqlRequests` that use the
        /// partition tokens.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the query, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, st::CancellationToken cancellationToken) =>
            PartitionQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a
        /// subset of the read result to read. The same session and read-only
        /// transaction must be used by the `PartitionReadRequest` used to create the
        /// partition tokens and the `ReadRequests` that use the partition tokens.
        /// There are no ordering guarantees on rows returned among the returned
        /// partition tokens, or even within each individual `StreamingRead` call
        /// issued with a `partition_token`.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the read, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartitionResponse PartitionRead(PartitionReadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a
        /// subset of the read result to read. The same session and read-only
        /// transaction must be used by the `PartitionReadRequest` used to create the
        /// partition tokens and the `ReadRequests` that use the partition tokens.
        /// There are no ordering guarantees on rows returned among the returned
        /// partition tokens, or even within each individual `StreamingRead` call
        /// issued with a `partition_token`.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the read, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a
        /// subset of the read result to read. The same session and read-only
        /// transaction must be used by the `PartitionReadRequest` used to create the
        /// partition tokens and the `ReadRequests` that use the partition tokens.
        /// There are no ordering guarantees on rows returned among the returned
        /// partition tokens, or even within each individual `StreamingRead` call
        /// issued with a `partition_token`.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the read, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, st::CancellationToken cancellationToken) =>
            PartitionReadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="BatchWrite(BatchWriteRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class BatchWriteStream : gaxgrpc::ServerStreamingBase<BatchWriteResponse>
        {
        }

        /// <summary>
        /// Batches the supplied mutation groups in a collection of efficient
        /// transactions. All mutations in a group are committed atomically. However,
        /// mutations across groups can be committed non-atomically in an unspecified
        /// order and thus, they must be independent of each other. Partial failure is
        /// possible, that is, some groups might have been committed successfully,
        /// while some might have failed. The results of individual batches are
        /// streamed into the response as the batches are applied.
        /// 
        /// `BatchWrite` requests are not replay protected, meaning that each mutation
        /// group can be applied more than once. Replays of non-idempotent mutations
        /// can have undesirable effects. For example, replays of an insert mutation
        /// can produce an already exists error or if you use generated or commit
        /// timestamp-based keys, it can result in additional rows being added to the
        /// mutation's table. We recommend structuring your mutation groups to be
        /// idempotent to avoid this issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BatchWriteStream BatchWrite(BatchWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batches the supplied mutation groups in a collection of efficient
        /// transactions. All mutations in a group are committed atomically. However,
        /// mutations across groups can be committed non-atomically in an unspecified
        /// order and thus, they must be independent of each other. Partial failure is
        /// possible, that is, some groups might have been committed successfully,
        /// while some might have failed. The results of individual batches are
        /// streamed into the response as the batches are applied.
        /// 
        /// `BatchWrite` requests are not replay protected, meaning that each mutation
        /// group can be applied more than once. Replays of non-idempotent mutations
        /// can have undesirable effects. For example, replays of an insert mutation
        /// can produce an already exists error or if you use generated or commit
        /// timestamp-based keys, it can result in additional rows being added to the
        /// mutation's table. We recommend structuring your mutation groups to be
        /// idempotent to avoid this issue.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the batch request is to be run.
        /// </param>
        /// <param name="mutationGroups">
        /// Required. The groups of mutations to be applied.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BatchWriteStream BatchWrite(string session, scg::IEnumerable<BatchWriteRequest.Types.MutationGroup> mutationGroups, gaxgrpc::CallSettings callSettings = null) =>
            BatchWrite(new BatchWriteRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                MutationGroups =
                {
                    gax::GaxPreconditions.CheckNotNull(mutationGroups, nameof(mutationGroups)),
                },
            }, callSettings);

        /// <summary>
        /// Batches the supplied mutation groups in a collection of efficient
        /// transactions. All mutations in a group are committed atomically. However,
        /// mutations across groups can be committed non-atomically in an unspecified
        /// order and thus, they must be independent of each other. Partial failure is
        /// possible, that is, some groups might have been committed successfully,
        /// while some might have failed. The results of individual batches are
        /// streamed into the response as the batches are applied.
        /// 
        /// `BatchWrite` requests are not replay protected, meaning that each mutation
        /// group can be applied more than once. Replays of non-idempotent mutations
        /// can have undesirable effects. For example, replays of an insert mutation
        /// can produce an already exists error or if you use generated or commit
        /// timestamp-based keys, it can result in additional rows being added to the
        /// mutation's table. We recommend structuring your mutation groups to be
        /// idempotent to avoid this issue.
        /// </summary>
        /// <param name="session">
        /// Required. The session in which the batch request is to be run.
        /// </param>
        /// <param name="mutationGroups">
        /// Required. The groups of mutations to be applied.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BatchWriteStream BatchWrite(SessionName session, scg::IEnumerable<BatchWriteRequest.Types.MutationGroup> mutationGroups, gaxgrpc::CallSettings callSettings = null) =>
            BatchWrite(new BatchWriteRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                MutationGroups =
                {
                    gax::GaxPreconditions.CheckNotNull(mutationGroups, nameof(mutationGroups)),
                },
            }, callSettings);
    }

    /// <summary>Spanner client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Spanner API
    /// 
    /// The Cloud Spanner API can be used to manage sessions and execute
    /// transactions on data stored in Cloud Spanner databases.
    /// </remarks>
    public sealed partial class SpannerClientImpl : SpannerClient
    {
        private readonly gaxgrpc::ApiCall<CreateSessionRequest, Session> _callCreateSession;

        private readonly gaxgrpc::ApiCall<BatchCreateSessionsRequest, BatchCreateSessionsResponse> _callBatchCreateSessions;

        private readonly gaxgrpc::ApiCall<GetSessionRequest, Session> _callGetSession;

        private readonly gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> _callListSessions;

        private readonly gaxgrpc::ApiCall<DeleteSessionRequest, wkt::Empty> _callDeleteSession;

        private readonly gaxgrpc::ApiCall<ExecuteSqlRequest, ResultSet> _callExecuteSql;

        private readonly gaxgrpc::ApiServerStreamingCall<ExecuteSqlRequest, PartialResultSet> _callExecuteStreamingSql;

        private readonly gaxgrpc::ApiCall<ExecuteBatchDmlRequest, ExecuteBatchDmlResponse> _callExecuteBatchDml;

        private readonly gaxgrpc::ApiCall<ReadRequest, ResultSet> _callRead;

        private readonly gaxgrpc::ApiServerStreamingCall<ReadRequest, PartialResultSet> _callStreamingRead;

        private readonly gaxgrpc::ApiCall<BeginTransactionRequest, Transaction> _callBeginTransaction;

        private readonly gaxgrpc::ApiCall<CommitRequest, CommitResponse> _callCommit;

        private readonly gaxgrpc::ApiCall<RollbackRequest, wkt::Empty> _callRollback;

        private readonly gaxgrpc::ApiCall<PartitionQueryRequest, PartitionResponse> _callPartitionQuery;

        private readonly gaxgrpc::ApiCall<PartitionReadRequest, PartitionResponse> _callPartitionRead;

        private readonly gaxgrpc::ApiServerStreamingCall<BatchWriteRequest, BatchWriteResponse> _callBatchWrite;

        /// <summary>
        /// Constructs a client wrapper for the Spanner service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpannerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SpannerClientImpl(Spanner.SpannerClient grpcClient, SpannerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SpannerSettings effectiveSettings = settings ?? SpannerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateSession = clientHelper.BuildApiCall<CreateSessionRequest, Session>("CreateSession", grpcClient.CreateSessionAsync, grpcClient.CreateSession, effectiveSettings.CreateSessionSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callCreateSession);
            Modify_CreateSessionApiCall(ref _callCreateSession);
            _callBatchCreateSessions = clientHelper.BuildApiCall<BatchCreateSessionsRequest, BatchCreateSessionsResponse>("BatchCreateSessions", grpcClient.BatchCreateSessionsAsync, grpcClient.BatchCreateSessions, effectiveSettings.BatchCreateSessionsSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callBatchCreateSessions);
            Modify_BatchCreateSessionsApiCall(ref _callBatchCreateSessions);
            _callGetSession = clientHelper.BuildApiCall<GetSessionRequest, Session>("GetSession", grpcClient.GetSessionAsync, grpcClient.GetSession, effectiveSettings.GetSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSession);
            Modify_GetSessionApiCall(ref _callGetSession);
            _callListSessions = clientHelper.BuildApiCall<ListSessionsRequest, ListSessionsResponse>("ListSessions", grpcClient.ListSessionsAsync, grpcClient.ListSessions, effectiveSettings.ListSessionsSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callListSessions);
            Modify_ListSessionsApiCall(ref _callListSessions);
            _callDeleteSession = clientHelper.BuildApiCall<DeleteSessionRequest, wkt::Empty>("DeleteSession", grpcClient.DeleteSessionAsync, grpcClient.DeleteSession, effectiveSettings.DeleteSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSession);
            Modify_DeleteSessionApiCall(ref _callDeleteSession);
            _callExecuteSql = clientHelper.BuildApiCall<ExecuteSqlRequest, ResultSet>("ExecuteSql", grpcClient.ExecuteSqlAsync, grpcClient.ExecuteSql, effectiveSettings.ExecuteSqlSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callExecuteSql);
            Modify_ExecuteSqlApiCall(ref _callExecuteSql);
            _callExecuteStreamingSql = clientHelper.BuildApiCall<ExecuteSqlRequest, PartialResultSet>("ExecuteStreamingSql", grpcClient.ExecuteStreamingSql, effectiveSettings.ExecuteStreamingSqlSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callExecuteStreamingSql);
            Modify_ExecuteStreamingSqlApiCall(ref _callExecuteStreamingSql);
            _callExecuteBatchDml = clientHelper.BuildApiCall<ExecuteBatchDmlRequest, ExecuteBatchDmlResponse>("ExecuteBatchDml", grpcClient.ExecuteBatchDmlAsync, grpcClient.ExecuteBatchDml, effectiveSettings.ExecuteBatchDmlSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callExecuteBatchDml);
            Modify_ExecuteBatchDmlApiCall(ref _callExecuteBatchDml);
            _callRead = clientHelper.BuildApiCall<ReadRequest, ResultSet>("Read", grpcClient.ReadAsync, grpcClient.Read, effectiveSettings.ReadSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callRead);
            Modify_ReadApiCall(ref _callRead);
            _callStreamingRead = clientHelper.BuildApiCall<ReadRequest, PartialResultSet>("StreamingRead", grpcClient.StreamingRead, effectiveSettings.StreamingReadSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callStreamingRead);
            Modify_StreamingReadApiCall(ref _callStreamingRead);
            _callBeginTransaction = clientHelper.BuildApiCall<BeginTransactionRequest, Transaction>("BeginTransaction", grpcClient.BeginTransactionAsync, grpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callBeginTransaction);
            Modify_BeginTransactionApiCall(ref _callBeginTransaction);
            _callCommit = clientHelper.BuildApiCall<CommitRequest, CommitResponse>("Commit", grpcClient.CommitAsync, grpcClient.Commit, effectiveSettings.CommitSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callCommit);
            Modify_CommitApiCall(ref _callCommit);
            _callRollback = clientHelper.BuildApiCall<RollbackRequest, wkt::Empty>("Rollback", grpcClient.RollbackAsync, grpcClient.Rollback, effectiveSettings.RollbackSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callRollback);
            Modify_RollbackApiCall(ref _callRollback);
            _callPartitionQuery = clientHelper.BuildApiCall<PartitionQueryRequest, PartitionResponse>("PartitionQuery", grpcClient.PartitionQueryAsync, grpcClient.PartitionQuery, effectiveSettings.PartitionQuerySettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callPartitionQuery);
            Modify_PartitionQueryApiCall(ref _callPartitionQuery);
            _callPartitionRead = clientHelper.BuildApiCall<PartitionReadRequest, PartitionResponse>("PartitionRead", grpcClient.PartitionReadAsync, grpcClient.PartitionRead, effectiveSettings.PartitionReadSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callPartitionRead);
            Modify_PartitionReadApiCall(ref _callPartitionRead);
            _callBatchWrite = clientHelper.BuildApiCall<BatchWriteRequest, BatchWriteResponse>("BatchWrite", grpcClient.BatchWrite, effectiveSettings.BatchWriteSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callBatchWrite);
            Modify_BatchWriteApiCall(ref _callBatchWrite);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSessionApiCall(ref gaxgrpc::ApiCall<CreateSessionRequest, Session> call);

        partial void Modify_BatchCreateSessionsApiCall(ref gaxgrpc::ApiCall<BatchCreateSessionsRequest, BatchCreateSessionsResponse> call);

        partial void Modify_GetSessionApiCall(ref gaxgrpc::ApiCall<GetSessionRequest, Session> call);

        partial void Modify_ListSessionsApiCall(ref gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> call);

        partial void Modify_DeleteSessionApiCall(ref gaxgrpc::ApiCall<DeleteSessionRequest, wkt::Empty> call);

        partial void Modify_ExecuteSqlApiCall(ref gaxgrpc::ApiCall<ExecuteSqlRequest, ResultSet> call);

        partial void Modify_ExecuteStreamingSqlApiCall(ref gaxgrpc::ApiServerStreamingCall<ExecuteSqlRequest, PartialResultSet> call);

        partial void Modify_ExecuteBatchDmlApiCall(ref gaxgrpc::ApiCall<ExecuteBatchDmlRequest, ExecuteBatchDmlResponse> call);

        partial void Modify_ReadApiCall(ref gaxgrpc::ApiCall<ReadRequest, ResultSet> call);

        partial void Modify_StreamingReadApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadRequest, PartialResultSet> call);

        partial void Modify_BeginTransactionApiCall(ref gaxgrpc::ApiCall<BeginTransactionRequest, Transaction> call);

        partial void Modify_CommitApiCall(ref gaxgrpc::ApiCall<CommitRequest, CommitResponse> call);

        partial void Modify_RollbackApiCall(ref gaxgrpc::ApiCall<RollbackRequest, wkt::Empty> call);

        partial void Modify_PartitionQueryApiCall(ref gaxgrpc::ApiCall<PartitionQueryRequest, PartitionResponse> call);

        partial void Modify_PartitionReadApiCall(ref gaxgrpc::ApiCall<PartitionReadRequest, PartitionResponse> call);

        partial void Modify_BatchWriteApiCall(ref gaxgrpc::ApiServerStreamingCall<BatchWriteRequest, BatchWriteResponse> call);

        partial void OnConstruction(Spanner.SpannerClient grpcClient, SpannerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Spanner client</summary>
        public override Spanner.SpannerClient GrpcClient { get; }

        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateSessionsRequest(ref BatchCreateSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteSqlRequest(ref ExecuteSqlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteBatchDmlRequest(ref ExecuteBatchDmlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadRequest(ref ReadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitRequest(ref CommitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackRequest(ref RollbackRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PartitionQueryRequest(ref PartitionQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PartitionReadRequest(ref PartitionReadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchWriteRequest(ref BatchWriteRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new session. A session can be used to perform
        /// transactions that read and/or modify data in a Cloud Spanner database.
        /// Sessions are meant to be reused for many consecutive
        /// transactions.
        /// 
        /// Sessions can only execute one transaction at a time. To execute
        /// multiple concurrent read-write/write-only transactions, create
        /// multiple sessions. Note that standalone reads and queries use a
        /// transaction internally, and count toward the one transaction
        /// limit.
        /// 
        /// Active sessions use additional server resources, so it's a good idea to
        /// delete idle and unneeded sessions.
        /// Aside from explicit deletes, Cloud Spanner can delete sessions when no
        /// operations are sent for more than an hour. If a session is deleted,
        /// requests to it return `NOT_FOUND`.
        /// 
        /// Idle sessions can be kept alive by sending a trivial SQL query
        /// periodically, for example, `"SELECT 1"`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Async(request, callSettings);
        }

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateSessionsResponse BatchCreateSessions(BatchCreateSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateSessionsRequest(ref request, ref callSettings);
            return _callBatchCreateSessions.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates multiple new sessions.
        /// 
        /// This API can be used to initialize a session cache on the clients.
        /// See https://goo.gl/TgSFN2 for best practices on session cache management.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(BatchCreateSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateSessionsRequest(ref request, ref callSettings);
            return _callBatchCreateSessions.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a session. Returns `NOT_FOUND` if the session doesn't exist.
        /// This is mainly useful for determining whether a session is still
        /// alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Lists all sessions in a given database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            _callDeleteSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Ends a session, releasing server resources associated with it. This
        /// asynchronously triggers the cancellation of any operations that are running
        /// with this session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return _callDeleteSession.Async(request, callSettings);
        }

        /// <summary>
        /// Executes an SQL statement, returning all results in a single reply. This
        /// method can't be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        /// 
        /// Operations inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql]
        /// instead.
        /// 
        /// The query string can be SQL or [Graph Query Language
        /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResultSet ExecuteSql(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes an SQL statement, returning all results in a single reply. This
        /// method can't be used to return a result set larger than 10 MiB;
        /// if the query yields more data than that, the query fails with
        /// a `FAILED_PRECONDITION` error.
        /// 
        /// Operations inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be fetched in streaming fashion by calling
        /// [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql]
        /// instead.
        /// 
        /// The query string can be SQL or [Graph Query Language
        /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Async(request, callSettings);
        }

        internal sealed partial class ExecuteStreamingSqlStreamImpl : ExecuteStreamingSqlStream
        {
            /// <summary>Construct the server streaming method for <c>ExecuteStreamingSql</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ExecuteStreamingSqlStreamImpl(grpccore::AsyncServerStreamingCall<PartialResultSet> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<PartialResultSet> GrpcCall { get; }
        }

        /// <summary>
        /// Like [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], except returns the
        /// result set as a stream. Unlike
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql], there is no limit on
        /// the size of the returned result set. However, no individual row in the
        /// result set can exceed 100 MiB, and no column value can exceed 10 MiB.
        /// 
        /// The query string can be SQL or [Graph Query Language
        /// (GQL)](https://cloud.google.com/spanner/docs/reference/standard-sql/graph-intro).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override SpannerClient.ExecuteStreamingSqlStream ExecuteStreamingSql(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return new ExecuteStreamingSqlStreamImpl(_callExecuteStreamingSql.Call(request, callSettings));
        }

        /// <summary>
        /// Executes a batch of SQL DML statements. This method allows many statements
        /// to be run with lower latency than submitting them sequentially with
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].
        /// 
        /// Statements are executed in sequential order. A request can succeed even if
        /// a statement fails. The
        /// [ExecuteBatchDmlResponse.status][google.spanner.v1.ExecuteBatchDmlResponse.status]
        /// field in the response provides information about the statement that failed.
        /// Clients must inspect this field to determine whether an error occurred.
        /// 
        /// Execution stops after the first failed statement; the remaining statements
        /// are not executed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExecuteBatchDmlResponse ExecuteBatchDml(ExecuteBatchDmlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteBatchDmlRequest(ref request, ref callSettings);
            return _callExecuteBatchDml.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes a batch of SQL DML statements. This method allows many statements
        /// to be run with lower latency than submitting them sequentially with
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql].
        /// 
        /// Statements are executed in sequential order. A request can succeed even if
        /// a statement fails. The
        /// [ExecuteBatchDmlResponse.status][google.spanner.v1.ExecuteBatchDmlResponse.status]
        /// field in the response provides information about the statement that failed.
        /// Clients must inspect this field to determine whether an error occurred.
        /// 
        /// Execution stops after the first failed statement; the remaining statements
        /// are not executed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteBatchDmlRequest(ref request, ref callSettings);
            return _callExecuteBatchDml.Async(request, callSettings);
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql]. This method can't be
        /// used to return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        /// 
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResultSet Read(ReadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return _callRead.Sync(request, callSettings);
        }

        /// <summary>
        /// Reads rows from the database using key lookups and scans, as a
        /// simple key/value style alternative to
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql]. This method can't be
        /// used to return a result set larger than 10 MiB; if the read matches more
        /// data than that, the read fails with a `FAILED_PRECONDITION`
        /// error.
        /// 
        /// Reads inside read-write transactions might return `ABORTED`. If
        /// this occurs, the application should restart the transaction from
        /// the beginning. See [Transaction][google.spanner.v1.Transaction] for more
        /// details.
        /// 
        /// Larger result sets can be yielded in streaming fashion by calling
        /// [StreamingRead][google.spanner.v1.Spanner.StreamingRead] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResultSet> ReadAsync(ReadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return _callRead.Async(request, callSettings);
        }

        internal sealed partial class StreamingReadStreamImpl : StreamingReadStream
        {
            /// <summary>Construct the server streaming method for <c>StreamingRead</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public StreamingReadStreamImpl(grpccore::AsyncServerStreamingCall<PartialResultSet> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<PartialResultSet> GrpcCall { get; }
        }

        /// <summary>
        /// Like [Read][google.spanner.v1.Spanner.Read], except returns the result set
        /// as a stream. Unlike [Read][google.spanner.v1.Spanner.Read], there is no
        /// limit on the size of the returned result set. However, no individual row in
        /// the result set can exceed 100 MiB, and no column value can exceed
        /// 10 MiB.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override SpannerClient.StreamingReadStream StreamingRead(ReadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRequest(ref request, ref callSettings);
            return new StreamingReadStreamImpl(_callStreamingRead.Call(request, callSettings));
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Transaction BeginTransaction(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Begins a new transaction. This step can often be skipped:
        /// [Read][google.spanner.v1.Spanner.Read],
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] and
        /// [Commit][google.spanner.v1.Spanner.Commit] can begin a new transaction as a
        /// side-effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Transaction> BeginTransactionAsync(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Async(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitResponse Commit(CommitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction. The request includes the mutations to be
        /// applied to rows in the database.
        /// 
        /// `Commit` might return an `ABORTED` error. This can occur at any time;
        /// commonly, the cause is conflicts with concurrent
        /// transactions. However, it can also happen for a variety of other
        /// reasons. If `Commit` returns `ABORTED`, the caller should retry
        /// the transaction from the beginning, reusing the same session.
        /// 
        /// On very rare occasions, `Commit` might return `UNKNOWN`. This can happen,
        /// for example, if the client job experiences a 1+ hour networking failure.
        /// At that point, Cloud Spanner has lost track of the transaction outcome and
        /// we recommend that you perform another read from the database to see the
        /// state of things as they are now.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CommitResponse> CommitAsync(CommitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void Rollback(RollbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            _callRollback.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction, releasing any locks it holds. It's a good
        /// idea to call this for any transaction that includes one or more
        /// [Read][google.spanner.v1.Spanner.Read] or
        /// [ExecuteSql][google.spanner.v1.Spanner.ExecuteSql] requests and ultimately
        /// decides not to commit.
        /// 
        /// `Rollback` returns `OK` if it successfully aborts the transaction, the
        /// transaction was already aborted, or the transaction isn't
        /// found. `Rollback` never returns `ABORTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task RollbackAsync(RollbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to
        /// specify a subset of the query result to read. The same session and
        /// read-only transaction must be used by the `PartitionQueryRequest` used to
        /// create the partition tokens and the `ExecuteSqlRequests` that use the
        /// partition tokens.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the query, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PartitionResponse PartitionQuery(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionQueryRequest(ref request, ref callSettings);
            return _callPartitionQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a query
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [ExecuteStreamingSql][google.spanner.v1.Spanner.ExecuteStreamingSql] to
        /// specify a subset of the query result to read. The same session and
        /// read-only transaction must be used by the `PartitionQueryRequest` used to
        /// create the partition tokens and the `ExecuteSqlRequests` that use the
        /// partition tokens.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the query, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionQueryRequest(ref request, ref callSettings);
            return _callPartitionQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a
        /// subset of the read result to read. The same session and read-only
        /// transaction must be used by the `PartitionReadRequest` used to create the
        /// partition tokens and the `ReadRequests` that use the partition tokens.
        /// There are no ordering guarantees on rows returned among the returned
        /// partition tokens, or even within each individual `StreamingRead` call
        /// issued with a `partition_token`.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the read, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PartitionResponse PartitionRead(PartitionReadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionReadRequest(ref request, ref callSettings);
            return _callPartitionRead.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a set of partition tokens that can be used to execute a read
        /// operation in parallel. Each of the returned partition tokens can be used
        /// by [StreamingRead][google.spanner.v1.Spanner.StreamingRead] to specify a
        /// subset of the read result to read. The same session and read-only
        /// transaction must be used by the `PartitionReadRequest` used to create the
        /// partition tokens and the `ReadRequests` that use the partition tokens.
        /// There are no ordering guarantees on rows returned among the returned
        /// partition tokens, or even within each individual `StreamingRead` call
        /// issued with a `partition_token`.
        /// 
        /// Partition tokens become invalid when the session used to create them
        /// is deleted, is idle for too long, begins a new transaction, or becomes too
        /// old. When any of these happen, it isn't possible to resume the read, and
        /// the whole operation must be restarted from the beginning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionReadRequest(ref request, ref callSettings);
            return _callPartitionRead.Async(request, callSettings);
        }

        internal sealed partial class BatchWriteStreamImpl : BatchWriteStream
        {
            /// <summary>Construct the server streaming method for <c>BatchWrite</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public BatchWriteStreamImpl(grpccore::AsyncServerStreamingCall<BatchWriteResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<BatchWriteResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Batches the supplied mutation groups in a collection of efficient
        /// transactions. All mutations in a group are committed atomically. However,
        /// mutations across groups can be committed non-atomically in an unspecified
        /// order and thus, they must be independent of each other. Partial failure is
        /// possible, that is, some groups might have been committed successfully,
        /// while some might have failed. The results of individual batches are
        /// streamed into the response as the batches are applied.
        /// 
        /// `BatchWrite` requests are not replay protected, meaning that each mutation
        /// group can be applied more than once. Replays of non-idempotent mutations
        /// can have undesirable effects. For example, replays of an insert mutation
        /// can produce an already exists error or if you use generated or commit
        /// timestamp-based keys, it can result in additional rows being added to the
        /// mutation's table. We recommend structuring your mutation groups to be
        /// idempotent to avoid this issue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override SpannerClient.BatchWriteStream BatchWrite(BatchWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchWriteRequest(ref request, ref callSettings);
            return new BatchWriteStreamImpl(_callBatchWrite.Call(request, callSettings));
        }
    }

    public partial class ListSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSessionsResponse : gaxgrpc::IPageResponse<Session>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Session> GetEnumerator() => Sessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
