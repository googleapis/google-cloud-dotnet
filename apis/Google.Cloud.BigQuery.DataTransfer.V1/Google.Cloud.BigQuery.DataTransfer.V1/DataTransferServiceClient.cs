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
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>
    /// Settings for a <see cref="DataTransferServiceClient"/>.
    /// </summary>
    public sealed partial class DataTransferServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DataTransferServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DataTransferServiceSettings"/>.
        /// </returns>
        public static DataTransferServiceSettings GetDefault() => new DataTransferServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DataTransferServiceSettings"/> object with default settings.
        /// </summary>
        public DataTransferServiceSettings() { }

        private DataTransferServiceSettings(DataTransferServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDataSourceSettings = existing.GetDataSourceSettings;
            ListDataSourcesSettings = existing.ListDataSourcesSettings;
            CreateTransferConfigSettings = existing.CreateTransferConfigSettings;
            UpdateTransferConfigSettings = existing.UpdateTransferConfigSettings;
            DeleteTransferConfigSettings = existing.DeleteTransferConfigSettings;
            GetTransferConfigSettings = existing.GetTransferConfigSettings;
            ListTransferConfigsSettings = existing.ListTransferConfigsSettings;
            ScheduleTransferRunsSettings = existing.ScheduleTransferRunsSettings;
            GetTransferRunSettings = existing.GetTransferRunSettings;
            DeleteTransferRunSettings = existing.DeleteTransferRunSettings;
            ListTransferRunsSettings = existing.ListTransferRunsSettings;
            ListTransferLogsSettings = existing.ListTransferLogsSettings;
            CheckValidCredsSettings = existing.CheckValidCredsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataTransferServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DataTransferServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="DataTransferServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DataTransferServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DataTransferServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetDataSource</c> and <c>DataTransferServiceClient.GetDataSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.GetDataSource</c> and
        /// <c>DataTransferServiceClient.GetDataSourceAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetDataSourceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListDataSources</c> and <c>DataTransferServiceClient.ListDataSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListDataSources</c> and
        /// <c>DataTransferServiceClient.ListDataSourcesAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListDataSourcesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CreateTransferConfig</c> and <c>DataTransferServiceClient.CreateTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.CreateTransferConfig</c> and
        /// <c>DataTransferServiceClient.CreateTransferConfigAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateTransferConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.UpdateTransferConfig</c> and <c>DataTransferServiceClient.UpdateTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.UpdateTransferConfig</c> and
        /// <c>DataTransferServiceClient.UpdateTransferConfigAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateTransferConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteTransferConfig</c> and <c>DataTransferServiceClient.DeleteTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.DeleteTransferConfig</c> and
        /// <c>DataTransferServiceClient.DeleteTransferConfigAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteTransferConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetTransferConfig</c> and <c>DataTransferServiceClient.GetTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.GetTransferConfig</c> and
        /// <c>DataTransferServiceClient.GetTransferConfigAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetTransferConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferConfigs</c> and <c>DataTransferServiceClient.ListTransferConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListTransferConfigs</c> and
        /// <c>DataTransferServiceClient.ListTransferConfigsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListTransferConfigsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ScheduleTransferRuns</c> and <c>DataTransferServiceClient.ScheduleTransferRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ScheduleTransferRuns</c> and
        /// <c>DataTransferServiceClient.ScheduleTransferRunsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ScheduleTransferRunsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetTransferRun</c> and <c>DataTransferServiceClient.GetTransferRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.GetTransferRun</c> and
        /// <c>DataTransferServiceClient.GetTransferRunAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetTransferRunSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteTransferRun</c> and <c>DataTransferServiceClient.DeleteTransferRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.DeleteTransferRun</c> and
        /// <c>DataTransferServiceClient.DeleteTransferRunAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteTransferRunSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferRuns</c> and <c>DataTransferServiceClient.ListTransferRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListTransferRuns</c> and
        /// <c>DataTransferServiceClient.ListTransferRunsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListTransferRunsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferLogs</c> and <c>DataTransferServiceClient.ListTransferLogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListTransferLogs</c> and
        /// <c>DataTransferServiceClient.ListTransferLogsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListTransferLogsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CheckValidCreds</c> and <c>DataTransferServiceClient.CheckValidCredsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.CheckValidCreds</c> and
        /// <c>DataTransferServiceClient.CheckValidCredsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CheckValidCredsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DataTransferServiceSettings"/> object.</returns>
        public DataTransferServiceSettings Clone() => new DataTransferServiceSettings(this);
    }

    /// <summary>
    /// DataTransferService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DataTransferServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataTransferService service, which is a host of "bigquerydatatransfer.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("bigquerydatatransfer.googleapis.com", 443);

        /// <summary>
        /// The default DataTransferService scopes.
        /// </summary>
        /// <remarks>
        /// The default DataTransferService scopes are:
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
        /// Asynchronously creates a <see cref="DataTransferServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DataTransferServiceClient"/>.</returns>
        public static async Task<DataTransferServiceClient> CreateAsync(ServiceEndpoint endpoint = null, DataTransferServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DataTransferServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        public static DataTransferServiceClient Create(ServiceEndpoint endpoint = null, DataTransferServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DataTransferServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        public static DataTransferServiceClient Create(Channel channel, DataTransferServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            DataTransferService.DataTransferServiceClient grpcClient = new DataTransferService.DataTransferServiceClient(channel);
            return new DataTransferServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, DataTransferServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DataTransferServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, DataTransferServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DataTransferServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DataTransferService client.
        /// </summary>
        public virtual DataTransferService.DataTransferServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<DataSource> GetDataSourceAsync(
            DataSourceNameOneof name,
            CallSettings callSettings = null) => GetDataSourceAsync(
                new GetDataSourceRequest
                {
                    DataSourceNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<DataSource> GetDataSourceAsync(
            DataSourceNameOneof name,
            CancellationToken cancellationToken) => GetDataSourceAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DataSource GetDataSource(
            DataSourceNameOneof name,
            CallSettings callSettings = null) => GetDataSource(
                new GetDataSourceRequest
                {
                    DataSourceNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
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
        public virtual Task<DataSource> GetDataSourceAsync(
            GetDataSourceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
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
        public virtual DataSource GetDataSource(
            GetDataSourceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="parent">
        /// The BigQuery project id for which data sources should be returned.
        /// Must be in the form: `projects/{project_id}`
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
        /// A pageable asynchronous sequence of <see cref="DataSource"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListDataSourcesAsync(
                new ListDataSourcesRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="parent">
        /// The BigQuery project id for which data sources should be returned.
        /// Must be in the form: `projects/{project_id}`
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
        /// A pageable sequence of <see cref="DataSource"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListDataSources(
                new ListDataSourcesRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DataSource"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(
            ListDataSourcesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DataSource"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(
            ListDataSourcesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// The BigQuery project id where the transfer configuration should be created.
        /// Must be in the format /projects/{project_id}/locations/{location_id}
        /// If specified location and location of the destination bigquery dataset
        /// do not match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferConfig> CreateTransferConfigAsync(
            ParentNameOneof parent,
            TransferConfig transferConfig,
            CallSettings callSettings = null) => CreateTransferConfigAsync(
                new CreateTransferConfigRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TransferConfig = GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
                },
                callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// The BigQuery project id where the transfer configuration should be created.
        /// Must be in the format /projects/{project_id}/locations/{location_id}
        /// If specified location and location of the destination bigquery dataset
        /// do not match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Data transfer configuration to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferConfig> CreateTransferConfigAsync(
            ParentNameOneof parent,
            TransferConfig transferConfig,
            CancellationToken cancellationToken) => CreateTransferConfigAsync(
                parent,
                transferConfig,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="parent">
        /// The BigQuery project id where the transfer configuration should be created.
        /// Must be in the format /projects/{project_id}/locations/{location_id}
        /// If specified location and location of the destination bigquery dataset
        /// do not match - the request will fail.
        /// </param>
        /// <param name="transferConfig">
        /// Data transfer configuration to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferConfig CreateTransferConfig(
            ParentNameOneof parent,
            TransferConfig transferConfig,
            CallSettings callSettings = null) => CreateTransferConfig(
                new CreateTransferConfigRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TransferConfig = GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
                },
                callSettings);

        /// <summary>
        /// Creates a new data transfer configuration.
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
        public virtual Task<TransferConfig> CreateTransferConfigAsync(
            CreateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new data transfer configuration.
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
        public virtual TransferConfig CreateTransferConfig(
            CreateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="transferConfig">
        /// Data transfer configuration to create.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferConfig> UpdateTransferConfigAsync(
            TransferConfig transferConfig,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateTransferConfigAsync(
                new UpdateTransferConfigRequest
                {
                    TransferConfig = GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="transferConfig">
        /// Data transfer configuration to create.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferConfig> UpdateTransferConfigAsync(
            TransferConfig transferConfig,
            FieldMask updateMask,
            CancellationToken cancellationToken) => UpdateTransferConfigAsync(
                transferConfig,
                updateMask,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="transferConfig">
        /// Data transfer configuration to create.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferConfig UpdateTransferConfig(
            TransferConfig transferConfig,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateTransferConfig(
                new UpdateTransferConfigRequest
                {
                    TransferConfig = GaxPreconditions.CheckNotNull(transferConfig, nameof(transferConfig)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
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
        public virtual Task<TransferConfig> UpdateTransferConfigAsync(
            UpdateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
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
        public virtual TransferConfig UpdateTransferConfig(
            UpdateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteTransferConfigAsync(
            TransferConfigNameOneof name,
            CallSettings callSettings = null) => DeleteTransferConfigAsync(
                new DeleteTransferConfigRequest
                {
                    TransferConfigNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteTransferConfigAsync(
            TransferConfigNameOneof name,
            CancellationToken cancellationToken) => DeleteTransferConfigAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTransferConfig(
            TransferConfigNameOneof name,
            CallSettings callSettings = null) => DeleteTransferConfig(
                new DeleteTransferConfigRequest
                {
                    TransferConfigNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
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
        public virtual Task DeleteTransferConfigAsync(
            DeleteTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTransferConfig(
            DeleteTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferConfig> GetTransferConfigAsync(
            TransferConfigNameOneof name,
            CallSettings callSettings = null) => GetTransferConfigAsync(
                new GetTransferConfigRequest
                {
                    TransferConfigNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferConfig> GetTransferConfigAsync(
            TransferConfigNameOneof name,
            CancellationToken cancellationToken) => GetTransferConfigAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferConfig GetTransferConfig(
            TransferConfigNameOneof name,
            CallSettings callSettings = null) => GetTransferConfig(
                new GetTransferConfigRequest
                {
                    TransferConfigNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns information about a data transfer config.
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
        public virtual Task<TransferConfig> GetTransferConfigAsync(
            GetTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about a data transfer config.
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
        public virtual TransferConfig GetTransferConfig(
            GetTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="parent">
        /// The BigQuery project id for which data sources
        /// should be returned: `projects/{project_id}`.
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
        /// A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTransferConfigsAsync(
                new ListTransferConfigsRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="parent">
        /// The BigQuery project id for which data sources
        /// should be returned: `projects/{project_id}`.
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
        /// A pageable sequence of <see cref="TransferConfig"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTransferConfigs(
                new ListTransferConfigsRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(
            ListTransferConfigsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TransferConfig"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(
            ListTransferConfigsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// </summary>
        /// <param name="parent">
        /// Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(
            TransferConfigNameOneof parent,
            Timestamp startTime,
            Timestamp endTime,
            CallSettings callSettings = null) => ScheduleTransferRunsAsync(
                new ScheduleTransferRunsRequest
                {
                    ParentAsTransferConfigNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    StartTime = GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                    EndTime = GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
                },
                callSettings);

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// </summary>
        /// <param name="parent">
        /// Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(
            TransferConfigNameOneof parent,
            Timestamp startTime,
            Timestamp endTime,
            CancellationToken cancellationToken) => ScheduleTransferRunsAsync(
                parent,
                startTime,
                endTime,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// </summary>
        /// <param name="parent">
        /// Transfer configuration name in the form:
        /// `projects/{project_id}/transferConfigs/{config_id}`.
        /// </param>
        /// <param name="startTime">
        /// Start time of the range of transfer runs. For example,
        /// `"2017-05-25T00:00:00+00:00"`.
        /// </param>
        /// <param name="endTime">
        /// End time of the range of transfer runs. For example,
        /// `"2017-05-30T00:00:00+00:00"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ScheduleTransferRunsResponse ScheduleTransferRuns(
            TransferConfigNameOneof parent,
            Timestamp startTime,
            Timestamp endTime,
            CallSettings callSettings = null) => ScheduleTransferRuns(
                new ScheduleTransferRunsRequest
                {
                    ParentAsTransferConfigNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    StartTime = GaxPreconditions.CheckNotNull(startTime, nameof(startTime)),
                    EndTime = GaxPreconditions.CheckNotNull(endTime, nameof(endTime)),
                },
                callSettings);

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
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
        public virtual Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(
            ScheduleTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
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
        public virtual ScheduleTransferRunsResponse ScheduleTransferRuns(
            ScheduleTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferRun> GetTransferRunAsync(
            RunNameOneof name,
            CallSettings callSettings = null) => GetTransferRunAsync(
                new GetTransferRunRequest
                {
                    RunNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TransferRun> GetTransferRunAsync(
            RunNameOneof name,
            CancellationToken cancellationToken) => GetTransferRunAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferRun GetTransferRun(
            RunNameOneof name,
            CallSettings callSettings = null) => GetTransferRun(
                new GetTransferRunRequest
                {
                    RunNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns information about the particular transfer run.
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
        public virtual Task<TransferRun> GetTransferRunAsync(
            GetTransferRunRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about the particular transfer run.
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
        public virtual TransferRun GetTransferRun(
            GetTransferRunRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteTransferRunAsync(
            RunNameOneof name,
            CallSettings callSettings = null) => DeleteTransferRunAsync(
                new DeleteTransferRunRequest
                {
                    RunNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteTransferRunAsync(
            RunNameOneof name,
            CancellationToken cancellationToken) => DeleteTransferRunAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="name">
        /// The field will contain name of the resource requested, for example:
        /// `projects/{project_id}/transferConfigs/{config_id}/runs/{run_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTransferRun(
            RunNameOneof name,
            CallSettings callSettings = null) => DeleteTransferRun(
                new DeleteTransferRunRequest
                {
                    RunNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified transfer run.
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
        public virtual Task DeleteTransferRunAsync(
            DeleteTransferRunRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTransferRun(
            DeleteTransferRunRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="parent">
        /// Name of transfer configuration for which transfer runs should be retrieved.
        /// Format of transfer configuration resource name is:
        /// `projects/{project_id}/transferConfigs/{config_id}`.
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
        /// A pageable asynchronous sequence of <see cref="TransferRun"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRunsAsync(
            TransferConfigNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTransferRunsAsync(
                new ListTransferRunsRequest
                {
                    ParentAsTransferConfigNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="parent">
        /// Name of transfer configuration for which transfer runs should be retrieved.
        /// Format of transfer configuration resource name is:
        /// `projects/{project_id}/transferConfigs/{config_id}`.
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
        /// A pageable sequence of <see cref="TransferRun"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRuns(
            TransferConfigNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTransferRuns(
                new ListTransferRunsRequest
                {
                    ParentAsTransferConfigNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TransferRun"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRunsAsync(
            ListTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TransferRun"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRuns(
            ListTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="parent">
        /// Transfer run name in the form:
        /// `projects/{project_id}/transferConfigs/{config_Id}/runs/{run_id}`.
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
        /// A pageable asynchronous sequence of <see cref="TransferMessage"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogsAsync(
            RunNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTransferLogsAsync(
                new ListTransferLogsRequest
                {
                    ParentAsRunNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="parent">
        /// Transfer run name in the form:
        /// `projects/{project_id}/transferConfigs/{config_Id}/runs/{run_id}`.
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
        /// A pageable sequence of <see cref="TransferMessage"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogs(
            RunNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTransferLogs(
                new ListTransferLogsRequest
                {
                    ParentAsRunNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TransferMessage"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogsAsync(
            ListTransferLogsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TransferMessage"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogs(
            ListTransferLogsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="name">
        /// The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckValidCredsResponse> CheckValidCredsAsync(
            DataSourceNameOneof name,
            CallSettings callSettings = null) => CheckValidCredsAsync(
                new CheckValidCredsRequest
                {
                    DataSourceNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="name">
        /// The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckValidCredsResponse> CheckValidCredsAsync(
            DataSourceNameOneof name,
            CancellationToken cancellationToken) => CheckValidCredsAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="name">
        /// The data source in the form:
        /// `projects/{project_id}/dataSources/{data_source_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CheckValidCredsResponse CheckValidCreds(
            DataSourceNameOneof name,
            CallSettings callSettings = null) => CheckValidCreds(
                new CheckValidCredsRequest
                {
                    DataSourceNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
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
        public virtual Task<CheckValidCredsResponse> CheckValidCredsAsync(
            CheckValidCredsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
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
        public virtual CheckValidCredsResponse CheckValidCreds(
            CheckValidCredsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// DataTransferService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DataTransferServiceClientImpl : DataTransferServiceClient
    {
        private readonly ApiCall<GetDataSourceRequest, DataSource> _callGetDataSource;
        private readonly ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> _callListDataSources;
        private readonly ApiCall<CreateTransferConfigRequest, TransferConfig> _callCreateTransferConfig;
        private readonly ApiCall<UpdateTransferConfigRequest, TransferConfig> _callUpdateTransferConfig;
        private readonly ApiCall<DeleteTransferConfigRequest, Empty> _callDeleteTransferConfig;
        private readonly ApiCall<GetTransferConfigRequest, TransferConfig> _callGetTransferConfig;
        private readonly ApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse> _callListTransferConfigs;
        private readonly ApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse> _callScheduleTransferRuns;
        private readonly ApiCall<GetTransferRunRequest, TransferRun> _callGetTransferRun;
        private readonly ApiCall<DeleteTransferRunRequest, Empty> _callDeleteTransferRun;
        private readonly ApiCall<ListTransferRunsRequest, ListTransferRunsResponse> _callListTransferRuns;
        private readonly ApiCall<ListTransferLogsRequest, ListTransferLogsResponse> _callListTransferLogs;
        private readonly ApiCall<CheckValidCredsRequest, CheckValidCredsResponse> _callCheckValidCreds;

        /// <summary>
        /// Constructs a client wrapper for the DataTransferService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataTransferServiceSettings"/> used within this client </param>
        public DataTransferServiceClientImpl(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DataTransferServiceSettings effectiveSettings = settings ?? DataTransferServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callGetDataSource = clientHelper.BuildApiCall<GetDataSourceRequest, DataSource>(
                GrpcClient.GetDataSourceAsync, GrpcClient.GetDataSource, effectiveSettings.GetDataSourceSettings);
            _callListDataSources = clientHelper.BuildApiCall<ListDataSourcesRequest, ListDataSourcesResponse>(
                GrpcClient.ListDataSourcesAsync, GrpcClient.ListDataSources, effectiveSettings.ListDataSourcesSettings);
            _callCreateTransferConfig = clientHelper.BuildApiCall<CreateTransferConfigRequest, TransferConfig>(
                GrpcClient.CreateTransferConfigAsync, GrpcClient.CreateTransferConfig, effectiveSettings.CreateTransferConfigSettings);
            _callUpdateTransferConfig = clientHelper.BuildApiCall<UpdateTransferConfigRequest, TransferConfig>(
                GrpcClient.UpdateTransferConfigAsync, GrpcClient.UpdateTransferConfig, effectiveSettings.UpdateTransferConfigSettings);
            _callDeleteTransferConfig = clientHelper.BuildApiCall<DeleteTransferConfigRequest, Empty>(
                GrpcClient.DeleteTransferConfigAsync, GrpcClient.DeleteTransferConfig, effectiveSettings.DeleteTransferConfigSettings);
            _callGetTransferConfig = clientHelper.BuildApiCall<GetTransferConfigRequest, TransferConfig>(
                GrpcClient.GetTransferConfigAsync, GrpcClient.GetTransferConfig, effectiveSettings.GetTransferConfigSettings);
            _callListTransferConfigs = clientHelper.BuildApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse>(
                GrpcClient.ListTransferConfigsAsync, GrpcClient.ListTransferConfigs, effectiveSettings.ListTransferConfigsSettings);
            _callScheduleTransferRuns = clientHelper.BuildApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>(
                GrpcClient.ScheduleTransferRunsAsync, GrpcClient.ScheduleTransferRuns, effectiveSettings.ScheduleTransferRunsSettings);
            _callGetTransferRun = clientHelper.BuildApiCall<GetTransferRunRequest, TransferRun>(
                GrpcClient.GetTransferRunAsync, GrpcClient.GetTransferRun, effectiveSettings.GetTransferRunSettings);
            _callDeleteTransferRun = clientHelper.BuildApiCall<DeleteTransferRunRequest, Empty>(
                GrpcClient.DeleteTransferRunAsync, GrpcClient.DeleteTransferRun, effectiveSettings.DeleteTransferRunSettings);
            _callListTransferRuns = clientHelper.BuildApiCall<ListTransferRunsRequest, ListTransferRunsResponse>(
                GrpcClient.ListTransferRunsAsync, GrpcClient.ListTransferRuns, effectiveSettings.ListTransferRunsSettings);
            _callListTransferLogs = clientHelper.BuildApiCall<ListTransferLogsRequest, ListTransferLogsResponse>(
                GrpcClient.ListTransferLogsAsync, GrpcClient.ListTransferLogs, effectiveSettings.ListTransferLogsSettings);
            _callCheckValidCreds = clientHelper.BuildApiCall<CheckValidCredsRequest, CheckValidCredsResponse>(
                GrpcClient.CheckValidCredsAsync, GrpcClient.CheckValidCreds, effectiveSettings.CheckValidCredsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DataTransferService client.
        /// </summary>
        public override DataTransferService.DataTransferServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_GetDataSourceRequest(ref GetDataSourceRequest request, ref CallSettings settings);
        partial void Modify_ListDataSourcesRequest(ref ListDataSourcesRequest request, ref CallSettings settings);
        partial void Modify_CreateTransferConfigRequest(ref CreateTransferConfigRequest request, ref CallSettings settings);
        partial void Modify_UpdateTransferConfigRequest(ref UpdateTransferConfigRequest request, ref CallSettings settings);
        partial void Modify_DeleteTransferConfigRequest(ref DeleteTransferConfigRequest request, ref CallSettings settings);
        partial void Modify_GetTransferConfigRequest(ref GetTransferConfigRequest request, ref CallSettings settings);
        partial void Modify_ListTransferConfigsRequest(ref ListTransferConfigsRequest request, ref CallSettings settings);
        partial void Modify_ScheduleTransferRunsRequest(ref ScheduleTransferRunsRequest request, ref CallSettings settings);
        partial void Modify_GetTransferRunRequest(ref GetTransferRunRequest request, ref CallSettings settings);
        partial void Modify_DeleteTransferRunRequest(ref DeleteTransferRunRequest request, ref CallSettings settings);
        partial void Modify_ListTransferRunsRequest(ref ListTransferRunsRequest request, ref CallSettings settings);
        partial void Modify_ListTransferLogsRequest(ref ListTransferLogsRequest request, ref CallSettings settings);
        partial void Modify_CheckValidCredsRequest(ref CheckValidCredsRequest request, ref CallSettings settings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
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
        public override Task<DataSource> GetDataSourceAsync(
            GetDataSourceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
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
        public override DataSource GetDataSource(
            GetDataSourceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DataSource"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(
            ListDataSourcesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DataSource"/> resources.
        /// </returns>
        public override PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(
            ListDataSourcesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Creates a new data transfer configuration.
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
        public override Task<TransferConfig> CreateTransferConfigAsync(
            CreateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTransferConfigRequest(ref request, ref callSettings);
            return _callCreateTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new data transfer configuration.
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
        public override TransferConfig CreateTransferConfig(
            CreateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTransferConfigRequest(ref request, ref callSettings);
            return _callCreateTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
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
        public override Task<TransferConfig> UpdateTransferConfigAsync(
            UpdateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateTransferConfigRequest(ref request, ref callSettings);
            return _callUpdateTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
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
        public override TransferConfig UpdateTransferConfig(
            UpdateTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateTransferConfigRequest(ref request, ref callSettings);
            return _callUpdateTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
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
        public override Task DeleteTransferConfigAsync(
            DeleteTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTransferConfigRequest(ref request, ref callSettings);
            return _callDeleteTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteTransferConfig(
            DeleteTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTransferConfigRequest(ref request, ref callSettings);
            _callDeleteTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about a data transfer config.
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
        public override Task<TransferConfig> GetTransferConfigAsync(
            GetTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTransferConfigRequest(ref request, ref callSettings);
            return _callGetTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about a data transfer config.
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
        public override TransferConfig GetTransferConfig(
            GetTransferConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTransferConfigRequest(ref request, ref callSettings);
            return _callGetTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TransferConfig"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigsAsync(
            ListTransferConfigsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTransferConfigsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTransferConfigsRequest, ListTransferConfigsResponse, TransferConfig>(_callListTransferConfigs, request, callSettings);
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TransferConfig"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTransferConfigsResponse, TransferConfig> ListTransferConfigs(
            ListTransferConfigsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTransferConfigsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTransferConfigsRequest, ListTransferConfigsResponse, TransferConfig>(_callListTransferConfigs, request, callSettings);
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
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
        public override Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(
            ScheduleTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ScheduleTransferRunsRequest(ref request, ref callSettings);
            return _callScheduleTransferRuns.Async(request, callSettings);
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
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
        public override ScheduleTransferRunsResponse ScheduleTransferRuns(
            ScheduleTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ScheduleTransferRunsRequest(ref request, ref callSettings);
            return _callScheduleTransferRuns.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the particular transfer run.
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
        public override Task<TransferRun> GetTransferRunAsync(
            GetTransferRunRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTransferRunRequest(ref request, ref callSettings);
            return _callGetTransferRun.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about the particular transfer run.
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
        public override TransferRun GetTransferRun(
            GetTransferRunRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTransferRunRequest(ref request, ref callSettings);
            return _callGetTransferRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified transfer run.
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
        public override Task DeleteTransferRunAsync(
            DeleteTransferRunRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTransferRunRequest(ref request, ref callSettings);
            return _callDeleteTransferRun.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteTransferRun(
            DeleteTransferRunRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTransferRunRequest(ref request, ref callSettings);
            _callDeleteTransferRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TransferRun"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRunsAsync(
            ListTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTransferRunsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTransferRunsRequest, ListTransferRunsResponse, TransferRun>(_callListTransferRuns, request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TransferRun"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTransferRunsResponse, TransferRun> ListTransferRuns(
            ListTransferRunsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTransferRunsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTransferRunsRequest, ListTransferRunsResponse, TransferRun>(_callListTransferRuns, request, callSettings);
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TransferMessage"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogsAsync(
            ListTransferLogsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTransferLogsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTransferLogsRequest, ListTransferLogsResponse, TransferMessage>(_callListTransferLogs, request, callSettings);
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TransferMessage"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTransferLogsResponse, TransferMessage> ListTransferLogs(
            ListTransferLogsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTransferLogsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTransferLogsRequest, ListTransferLogsResponse, TransferMessage>(_callListTransferLogs, request, callSettings);
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
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
        public override Task<CheckValidCredsResponse> CheckValidCredsAsync(
            CheckValidCredsRequest request,
            CallSettings callSettings = null)
        {
            Modify_CheckValidCredsRequest(ref request, ref callSettings);
            return _callCheckValidCreds.Async(request, callSettings);
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
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
        public override CheckValidCredsResponse CheckValidCreds(
            CheckValidCredsRequest request,
            CallSettings callSettings = null)
        {
            Modify_CheckValidCredsRequest(ref request, ref callSettings);
            return _callCheckValidCreds.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListDataSourcesRequest : IPageRequest { }
    public partial class ListDataSourcesResponse : IPageResponse<DataSource>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<DataSource> GetEnumerator() => DataSources.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferConfigsRequest : IPageRequest { }
    public partial class ListTransferConfigsResponse : IPageResponse<TransferConfig>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<TransferConfig> GetEnumerator() => TransferConfigs.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferRunsRequest : IPageRequest { }
    public partial class ListTransferRunsResponse : IPageResponse<TransferRun>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<TransferRun> GetEnumerator() => TransferRuns.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferLogsRequest : IPageRequest { }
    public partial class ListTransferLogsResponse : IPageResponse<TransferMessage>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<TransferMessage> GetEnumerator() => TransferMessages.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
