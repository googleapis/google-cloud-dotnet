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
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableTableAdminClient"/>.
    /// </summary>
    public sealed partial class BigtableTableAdminSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableTableAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableTableAdminSettings"/>.
        /// </returns>
        public static BigtableTableAdminSettings GetDefault() => new BigtableTableAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableTableAdminSettings"/> object with default settings.
        /// </summary>
        public BigtableTableAdminSettings() { }

        private BigtableTableAdminSettings(BigtableTableAdminSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTableSettings = existing.CreateTableSettings;
            CreateTableFromSnapshotSettings = existing.CreateTableFromSnapshotSettings;
            CreateTableFromSnapshotOperationsSettings = existing.CreateTableFromSnapshotOperationsSettings?.Clone();
            ListTablesSettings = existing.ListTablesSettings;
            GetTableSettings = existing.GetTableSettings;
            DeleteTableSettings = existing.DeleteTableSettings;
            ModifyColumnFamiliesSettings = existing.ModifyColumnFamiliesSettings;
            DropRowRangeSettings = existing.DropRowRangeSettings;
            GenerateConsistencyTokenSettings = existing.GenerateConsistencyTokenSettings;
            CheckConsistencySettings = existing.CheckConsistencySettings;
            SnapshotTableSettings = existing.SnapshotTableSettings;
            SnapshotTableOperationsSettings = existing.SnapshotTableOperationsSettings?.Clone();
            GetSnapshotSettings = existing.GetSnapshotSettings;
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            DeleteSnapshotSettings = existing.DeleteSnapshotSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableTableAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableTableAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
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
        /// <c>BigtableTableAdminClient.CreateTable</c> and <c>BigtableTableAdminClient.CreateTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.CreateTable</c> and
        /// <c>BigtableTableAdminClient.CreateTableAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateTableSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CreateTableFromSnapshot</c> and <c>BigtableTableAdminClient.CreateTableFromSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.CreateTableFromSnapshot</c> and
        /// <c>BigtableTableAdminClient.CreateTableFromSnapshotAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateTableFromSnapshotSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.CreateTableFromSnapshot</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateTableFromSnapshotOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListTables</c> and <c>BigtableTableAdminClient.ListTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ListTables</c> and
        /// <c>BigtableTableAdminClient.ListTablesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListTablesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetTable</c> and <c>BigtableTableAdminClient.GetTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GetTable</c> and
        /// <c>BigtableTableAdminClient.GetTableAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetTableSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteTable</c> and <c>BigtableTableAdminClient.DeleteTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DeleteTable</c> and
        /// <c>BigtableTableAdminClient.DeleteTableAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteTableSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and
        /// <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ModifyColumnFamiliesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DropRowRange</c> and <c>BigtableTableAdminClient.DropRowRangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DropRowRange</c> and
        /// <c>BigtableTableAdminClient.DropRowRangeAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DropRowRangeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GenerateConsistencyToken</c> and <c>BigtableTableAdminClient.GenerateConsistencyTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GenerateConsistencyToken</c> and
        /// <c>BigtableTableAdminClient.GenerateConsistencyTokenAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GenerateConsistencyTokenSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CheckConsistency</c> and <c>BigtableTableAdminClient.CheckConsistencyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.CheckConsistency</c> and
        /// <c>BigtableTableAdminClient.CheckConsistencyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CheckConsistencySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.SnapshotTable</c> and <c>BigtableTableAdminClient.SnapshotTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.SnapshotTable</c> and
        /// <c>BigtableTableAdminClient.SnapshotTableAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings SnapshotTableSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.SnapshotTable</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings SnapshotTableOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetSnapshot</c> and <c>BigtableTableAdminClient.GetSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GetSnapshot</c> and
        /// <c>BigtableTableAdminClient.GetSnapshotAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetSnapshotSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListSnapshots</c> and <c>BigtableTableAdminClient.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ListSnapshots</c> and
        /// <c>BigtableTableAdminClient.ListSnapshotsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListSnapshotsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteSnapshot</c> and <c>BigtableTableAdminClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DeleteSnapshot</c> and
        /// <c>BigtableTableAdminClient.DeleteSnapshotAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteSnapshotSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableTableAdminSettings"/> object.</returns>
        public BigtableTableAdminSettings Clone() => new BigtableTableAdminSettings(this);
    }

    /// <summary>
    /// BigtableTableAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableTableAdminClient
    {
        /// <summary>
        /// The default endpoint for the BigtableTableAdmin service, which is a host of "bigtableadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("bigtableadmin.googleapis.com", 443);

        /// <summary>
        /// The default BigtableTableAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default BigtableTableAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.instance"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/bigtable.admin",
            "https://www.googleapis.com/auth/bigtable.admin.cluster",
            "https://www.googleapis.com/auth/bigtable.admin.instance",
            "https://www.googleapis.com/auth/bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-bigtable.admin",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableTableAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableTableAdminClient"/>.</returns>
        public static async Task<BigtableTableAdminClient> CreateAsync(ServiceEndpoint endpoint = null, BigtableTableAdminSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableTableAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create(ServiceEndpoint endpoint = null, BigtableTableAdminSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableTableAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create(Channel channel, BigtableTableAdminSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            BigtableTableAdmin.BigtableTableAdminClient grpcClient = new BigtableTableAdmin.BigtableTableAdminClient(channel);
            return new BigtableTableAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, BigtableTableAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableTableAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, BigtableTableAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableTableAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BigtableTableAdmin client.
        /// </summary>
        public virtual BigtableTableAdmin.BigtableTableAdminClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="table">
        /// The Table to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> CreateTableAsync(
            InstanceName parent,
            string tableId,
            Table table,
            CallSettings callSettings = null) => CreateTableAsync(
                new CreateTableRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    Table = GaxPreconditions.CheckNotNull(table, nameof(table)),
                },
                callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="table">
        /// The Table to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> CreateTableAsync(
            InstanceName parent,
            string tableId,
            Table table,
            CancellationToken cancellationToken) => CreateTableAsync(
                parent,
                tableId,
                table,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="table">
        /// The Table to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Table CreateTable(
            InstanceName parent,
            string tableId,
            Table table,
            CallSettings callSettings = null) => CreateTable(
                new CreateTableRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    Table = GaxPreconditions.CheckNotNull(table, nameof(table)),
                },
                callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public virtual Task<Table> CreateTableAsync(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public virtual Task<Table> CreateTableAsync(
            CreateTableRequest request,
            CancellationToken cancellationToken) => CreateTableAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public virtual Table CreateTable(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            InstanceName parent,
            string tableId,
            SnapshotName sourceSnapshot,
            CallSettings callSettings = null) => CreateTableFromSnapshotAsync(
                new CreateTableFromSnapshotRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    SourceSnapshotAsSnapshotName = GaxPreconditions.CheckNotNull(sourceSnapshot, nameof(sourceSnapshot)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            InstanceName parent,
            string tableId,
            SnapshotName sourceSnapshot,
            CancellationToken cancellationToken) => CreateTableFromSnapshotAsync(
                parent,
                tableId,
                sourceSnapshot,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the table.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="tableId">
        /// The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `&lt;parent&gt;/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(
            InstanceName parent,
            string tableId,
            SnapshotName sourceSnapshot,
            CallSettings callSettings = null) => CreateTableFromSnapshot(
                new CreateTableFromSnapshotRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    SourceSnapshotAsSnapshotName = GaxPreconditions.CheckNotNull(sourceSnapshot, nameof(sourceSnapshot)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
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
        public virtual Task<Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            CreateTableFromSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTableFromSnapshotAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Table, CreateTableFromSnapshotMetadata>> PollOnceCreateTableFromSnapshotAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Table, CreateTableFromSnapshotMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateTableFromSnapshotOperationsClient,
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
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
        public virtual Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(
            CreateTableFromSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateTableFromSnapshot</c>.
        /// </summary>
        public virtual OperationsClient CreateTableFromSnapshotOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTableFromSnapshot</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Table, CreateTableFromSnapshotMetadata> PollOnceCreateTableFromSnapshot(
            string operationName,
            CallSettings callSettings = null) => Operation<Table, CreateTableFromSnapshotMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateTableFromSnapshotOperationsClient,
                callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which tables should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTablesAsync(
                new ListTablesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which tables should be listed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTablesResponse, Table> ListTables(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTables(
                new ListTablesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Table"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTablesResponse, Table> ListTables(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested table.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> GetTableAsync(
            TableName name,
            CallSettings callSettings = null) => GetTableAsync(
                new GetTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested table.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> GetTableAsync(
            TableName name,
            CancellationToken cancellationToken) => GetTableAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested table.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Table GetTable(
            TableName name,
            CallSettings callSettings = null) => GetTable(
                new GetTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public virtual Task<Table> GetTableAsync(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public virtual Task<Table> GetTableAsync(
            GetTableRequest request,
            CancellationToken cancellationToken) => GetTableAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public virtual Table GetTable(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteTableAsync(
            TableName name,
            CallSettings callSettings = null) => DeleteTableAsync(
                new DeleteTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteTableAsync(
            TableName name,
            CancellationToken cancellationToken) => DeleteTableAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTable(
            TableName name,
            CallSettings callSettings = null) => DeleteTable(
                new DeleteTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public virtual Task DeleteTableAsync(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public virtual Task DeleteTableAsync(
            DeleteTableRequest request,
            CancellationToken cancellationToken) => DeleteTableAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTable(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="modifications">
        /// Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> ModifyColumnFamiliesAsync(
            TableName name,
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            CallSettings callSettings = null) => ModifyColumnFamiliesAsync(
                new ModifyColumnFamiliesRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Modifications = { GaxPreconditions.CheckNotNull(modifications, nameof(modifications)) },
                },
                callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="modifications">
        /// Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Table> ModifyColumnFamiliesAsync(
            TableName name,
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            CancellationToken cancellationToken) => ModifyColumnFamiliesAsync(
                name,
                modifications,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="modifications">
        /// Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Table ModifyColumnFamilies(
            TableName name,
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            CallSettings callSettings = null) => ModifyColumnFamilies(
                new ModifyColumnFamiliesRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Modifications = { GaxPreconditions.CheckNotNull(modifications, nameof(modifications)) },
                },
                callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public virtual Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public virtual Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            CancellationToken cancellationToken) => ModifyColumnFamiliesAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public virtual Table ModifyColumnFamilies(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
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
        public virtual Task DropRowRangeAsync(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
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
        public virtual Task DropRowRangeAsync(
            DropRowRangeRequest request,
            CancellationToken cancellationToken) => DropRowRangeAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DropRowRange(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            TableName name,
            CallSettings callSettings = null) => GenerateConsistencyTokenAsync(
                new GenerateConsistencyTokenRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            TableName name,
            CancellationToken cancellationToken) => GenerateConsistencyTokenAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GenerateConsistencyTokenResponse GenerateConsistencyToken(
            TableName name,
            CallSettings callSettings = null) => GenerateConsistencyToken(
                new GenerateConsistencyTokenRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
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
        public virtual Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            GenerateConsistencyTokenRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
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
        public virtual Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            GenerateConsistencyTokenRequest request,
            CancellationToken cancellationToken) => GenerateConsistencyTokenAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
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
        public virtual GenerateConsistencyTokenResponse GenerateConsistencyToken(
            GenerateConsistencyTokenRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="consistencyToken">
        /// The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckConsistencyResponse> CheckConsistencyAsync(
            TableName name,
            string consistencyToken,
            CallSettings callSettings = null) => CheckConsistencyAsync(
                new CheckConsistencyRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ConsistencyToken = GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="consistencyToken">
        /// The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckConsistencyResponse> CheckConsistencyAsync(
            TableName name,
            string consistencyToken,
            CancellationToken cancellationToken) => CheckConsistencyAsync(
                name,
                consistencyToken,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="consistencyToken">
        /// The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CheckConsistencyResponse CheckConsistency(
            TableName name,
            string consistencyToken,
            CallSettings callSettings = null) => CheckConsistency(
                new CheckConsistencyRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ConsistencyToken = GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
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
        public virtual Task<CheckConsistencyResponse> CheckConsistencyAsync(
            CheckConsistencyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
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
        public virtual Task<CheckConsistencyResponse> CheckConsistencyAsync(
            CheckConsistencyRequest request,
            CancellationToken cancellationToken) => CheckConsistencyAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
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
        public virtual CheckConsistencyResponse CheckConsistency(
            CheckConsistencyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cluster">
        /// The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="snapshotId">
        /// The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            TableName name,
            ClusterName cluster,
            SnapshotName snapshotId,
            string description,
            CallSettings callSettings = null) => SnapshotTableAsync(
                new SnapshotTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ClusterAsClusterName = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                    SnapshotIdAsSnapshotName = GaxPreconditions.CheckNotNull(snapshotId, nameof(snapshotId)),
                    Description = GaxPreconditions.CheckNotNullOrEmpty(description, nameof(description)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cluster">
        /// The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="snapshotId">
        /// The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            TableName name,
            ClusterName cluster,
            SnapshotName snapshotId,
            string description,
            CancellationToken cancellationToken) => SnapshotTableAsync(
                name,
                cluster,
                snapshotId,
                description,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="cluster">
        /// The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="snapshotId">
        /// The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(
            TableName name,
            ClusterName cluster,
            SnapshotName snapshotId,
            string description,
            CallSettings callSettings = null) => SnapshotTable(
                new SnapshotTableRequest
                {
                    TableName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ClusterAsClusterName = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                    SnapshotIdAsSnapshotName = GaxPreconditions.CheckNotNull(snapshotId, nameof(snapshotId)),
                    Description = GaxPreconditions.CheckNotNullOrEmpty(description, nameof(description)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
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
        public virtual Task<Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            SnapshotTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SnapshotTableAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Snapshot, SnapshotTableMetadata>> PollOnceSnapshotTableAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Snapshot, SnapshotTableMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                SnapshotTableOperationsClient,
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
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
        public virtual Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(
            SnapshotTableRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>SnapshotTable</c>.
        /// </summary>
        public virtual OperationsClient SnapshotTableOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SnapshotTable</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Snapshot, SnapshotTableMetadata> PollOnceSnapshotTable(
            string operationName,
            CallSettings callSettings = null) => Operation<Snapshot, SnapshotTableMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                SnapshotTableOperationsClient,
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Snapshot> GetSnapshotAsync(
            SnapshotName name,
            CallSettings callSettings = null) => GetSnapshotAsync(
                new GetSnapshotRequest
                {
                    SnapshotName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Snapshot> GetSnapshotAsync(
            SnapshotName name,
            CancellationToken cancellationToken) => GetSnapshotAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Snapshot GetSnapshot(
            SnapshotName name,
            CallSettings callSettings = null) => GetSnapshot(
                new GetSnapshotRequest
                {
                    SnapshotName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
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
        public virtual Task<Snapshot> GetSnapshotAsync(
            GetSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
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
        public virtual Task<Snapshot> GetSnapshotAsync(
            GetSnapshotRequest request,
            CancellationToken cancellationToken) => GetSnapshotAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
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
        public virtual Snapshot GetSnapshot(
            GetSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists all snapshots associated with the specified cluster.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the cluster for which snapshots should be listed.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// Use `&lt;cluster&gt; = '-'` to list snapshots for all clusters in an instance,
        /// e.g., `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/-`.
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
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ClusterName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSnapshotsAsync(
                new ListSnapshotsRequest
                {
                    ParentAsClusterName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists all snapshots associated with the specified cluster.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the cluster for which snapshots should be listed.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// Use `&lt;cluster&gt; = '-'` to list snapshots for all clusters in an instance,
        /// e.g., `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/-`.
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
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ClusterName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSnapshots(
                new ListSnapshotsRequest
                {
                    ParentAsClusterName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists all snapshots associated with the specified cluster.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists all snapshots associated with the specified cluster.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
        /// </summary>
        /// <param name="name">
        /// The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteSnapshotAsync(
            SnapshotName name,
            CallSettings callSettings = null) => DeleteSnapshotAsync(
                new DeleteSnapshotRequest
                {
                    SnapshotName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
        /// </summary>
        /// <param name="name">
        /// The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteSnapshotAsync(
            SnapshotName name,
            CancellationToken cancellationToken) => DeleteSnapshotAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
        /// </summary>
        /// <param name="name">
        /// The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;/snapshots/&lt;snapshot&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSnapshot(
            SnapshotName name,
            CallSettings callSettings = null) => DeleteSnapshot(
                new DeleteSnapshotRequest
                {
                    SnapshotName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
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
        public virtual Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
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
        public virtual Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            CancellationToken cancellationToken) => DeleteSnapshotAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSnapshot(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// BigtableTableAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableTableAdminClientImpl : BigtableTableAdminClient
    {
        private readonly ApiCall<CreateTableRequest, Table> _callCreateTable;
        private readonly ApiCall<CreateTableFromSnapshotRequest, Operation> _callCreateTableFromSnapshot;
        private readonly ApiCall<ListTablesRequest, ListTablesResponse> _callListTables;
        private readonly ApiCall<GetTableRequest, Table> _callGetTable;
        private readonly ApiCall<DeleteTableRequest, Empty> _callDeleteTable;
        private readonly ApiCall<ModifyColumnFamiliesRequest, Table> _callModifyColumnFamilies;
        private readonly ApiCall<DropRowRangeRequest, Empty> _callDropRowRange;
        private readonly ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> _callGenerateConsistencyToken;
        private readonly ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> _callCheckConsistency;
        private readonly ApiCall<SnapshotTableRequest, Operation> _callSnapshotTable;
        private readonly ApiCall<GetSnapshotRequest, Snapshot> _callGetSnapshot;
        private readonly ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;
        private readonly ApiCall<DeleteSnapshotRequest, Empty> _callDeleteSnapshot;

        /// <summary>
        /// Constructs a client wrapper for the BigtableTableAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableTableAdminSettings"/> used within this client </param>
        public BigtableTableAdminClientImpl(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableTableAdminSettings effectiveSettings = settings ?? BigtableTableAdminSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            CreateTableFromSnapshotOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateTableFromSnapshotOperationsSettings);
            SnapshotTableOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.SnapshotTableOperationsSettings);
            _callCreateTable = clientHelper.BuildApiCall<CreateTableRequest, Table>(
                GrpcClient.CreateTableAsync, GrpcClient.CreateTable, effectiveSettings.CreateTableSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callCreateTableFromSnapshot = clientHelper.BuildApiCall<CreateTableFromSnapshotRequest, Operation>(
                GrpcClient.CreateTableFromSnapshotAsync, GrpcClient.CreateTableFromSnapshot, effectiveSettings.CreateTableFromSnapshotSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callListTables = clientHelper.BuildApiCall<ListTablesRequest, ListTablesResponse>(
                GrpcClient.ListTablesAsync, GrpcClient.ListTables, effectiveSettings.ListTablesSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetTable = clientHelper.BuildApiCall<GetTableRequest, Table>(
                GrpcClient.GetTableAsync, GrpcClient.GetTable, effectiveSettings.GetTableSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDeleteTable = clientHelper.BuildApiCall<DeleteTableRequest, Empty>(
                GrpcClient.DeleteTableAsync, GrpcClient.DeleteTable, effectiveSettings.DeleteTableSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callModifyColumnFamilies = clientHelper.BuildApiCall<ModifyColumnFamiliesRequest, Table>(
                GrpcClient.ModifyColumnFamiliesAsync, GrpcClient.ModifyColumnFamilies, effectiveSettings.ModifyColumnFamiliesSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDropRowRange = clientHelper.BuildApiCall<DropRowRangeRequest, Empty>(
                GrpcClient.DropRowRangeAsync, GrpcClient.DropRowRange, effectiveSettings.DropRowRangeSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGenerateConsistencyToken = clientHelper.BuildApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse>(
                GrpcClient.GenerateConsistencyTokenAsync, GrpcClient.GenerateConsistencyToken, effectiveSettings.GenerateConsistencyTokenSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCheckConsistency = clientHelper.BuildApiCall<CheckConsistencyRequest, CheckConsistencyResponse>(
                GrpcClient.CheckConsistencyAsync, GrpcClient.CheckConsistency, effectiveSettings.CheckConsistencySettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callSnapshotTable = clientHelper.BuildApiCall<SnapshotTableRequest, Operation>(
                GrpcClient.SnapshotTableAsync, GrpcClient.SnapshotTable, effectiveSettings.SnapshotTableSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetSnapshot = clientHelper.BuildApiCall<GetSnapshotRequest, Snapshot>(
                GrpcClient.GetSnapshotAsync, GrpcClient.GetSnapshot, effectiveSettings.GetSnapshotSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>(
                GrpcClient.ListSnapshotsAsync, GrpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, Empty>(
                GrpcClient.DeleteSnapshotAsync, GrpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            Modify_ApiCall(ref _callCreateTable);
            Modify_CreateTableApiCall(ref _callCreateTable);
            Modify_ApiCall(ref _callCreateTableFromSnapshot);
            Modify_CreateTableFromSnapshotApiCall(ref _callCreateTableFromSnapshot);
            Modify_ApiCall(ref _callListTables);
            Modify_ListTablesApiCall(ref _callListTables);
            Modify_ApiCall(ref _callGetTable);
            Modify_GetTableApiCall(ref _callGetTable);
            Modify_ApiCall(ref _callDeleteTable);
            Modify_DeleteTableApiCall(ref _callDeleteTable);
            Modify_ApiCall(ref _callModifyColumnFamilies);
            Modify_ModifyColumnFamiliesApiCall(ref _callModifyColumnFamilies);
            Modify_ApiCall(ref _callDropRowRange);
            Modify_DropRowRangeApiCall(ref _callDropRowRange);
            Modify_ApiCall(ref _callGenerateConsistencyToken);
            Modify_GenerateConsistencyTokenApiCall(ref _callGenerateConsistencyToken);
            Modify_ApiCall(ref _callCheckConsistency);
            Modify_CheckConsistencyApiCall(ref _callCheckConsistency);
            Modify_ApiCall(ref _callSnapshotTable);
            Modify_SnapshotTableApiCall(ref _callSnapshotTable);
            Modify_ApiCall(ref _callGetSnapshot);
            Modify_GetSnapshotApiCall(ref _callGetSnapshot);
            Modify_ApiCall(ref _callListSnapshots);
            Modify_ListSnapshotsApiCall(ref _callListSnapshots);
            Modify_ApiCall(ref _callDeleteSnapshot);
            Modify_DeleteSnapshotApiCall(ref _callDeleteSnapshot);
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
        partial void Modify_CreateTableApiCall(ref ApiCall<CreateTableRequest, Table> call);
        partial void Modify_CreateTableFromSnapshotApiCall(ref ApiCall<CreateTableFromSnapshotRequest, Operation> call);
        partial void Modify_ListTablesApiCall(ref ApiCall<ListTablesRequest, ListTablesResponse> call);
        partial void Modify_GetTableApiCall(ref ApiCall<GetTableRequest, Table> call);
        partial void Modify_DeleteTableApiCall(ref ApiCall<DeleteTableRequest, Empty> call);
        partial void Modify_ModifyColumnFamiliesApiCall(ref ApiCall<ModifyColumnFamiliesRequest, Table> call);
        partial void Modify_DropRowRangeApiCall(ref ApiCall<DropRowRangeRequest, Empty> call);
        partial void Modify_GenerateConsistencyTokenApiCall(ref ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> call);
        partial void Modify_CheckConsistencyApiCall(ref ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> call);
        partial void Modify_SnapshotTableApiCall(ref ApiCall<SnapshotTableRequest, Operation> call);
        partial void Modify_GetSnapshotApiCall(ref ApiCall<GetSnapshotRequest, Snapshot> call);
        partial void Modify_ListSnapshotsApiCall(ref ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);
        partial void Modify_DeleteSnapshotApiCall(ref ApiCall<DeleteSnapshotRequest, Empty> call);
        partial void OnConstruction(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BigtableTableAdmin client.
        /// </summary>
        public override BigtableTableAdmin.BigtableTableAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateTableRequest(ref CreateTableRequest request, ref CallSettings settings);
        partial void Modify_CreateTableFromSnapshotRequest(ref CreateTableFromSnapshotRequest request, ref CallSettings settings);
        partial void Modify_ListTablesRequest(ref ListTablesRequest request, ref CallSettings settings);
        partial void Modify_GetTableRequest(ref GetTableRequest request, ref CallSettings settings);
        partial void Modify_DeleteTableRequest(ref DeleteTableRequest request, ref CallSettings settings);
        partial void Modify_ModifyColumnFamiliesRequest(ref ModifyColumnFamiliesRequest request, ref CallSettings settings);
        partial void Modify_DropRowRangeRequest(ref DropRowRangeRequest request, ref CallSettings settings);
        partial void Modify_GenerateConsistencyTokenRequest(ref GenerateConsistencyTokenRequest request, ref CallSettings settings);
        partial void Modify_CheckConsistencyRequest(ref CheckConsistencyRequest request, ref CallSettings settings);
        partial void Modify_SnapshotTableRequest(ref SnapshotTableRequest request, ref CallSettings settings);
        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref CallSettings settings);
        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref CallSettings settings);
        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref CallSettings settings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public override Task<Table> CreateTableAsync(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTableRequest(ref request, ref callSettings);
            return _callCreateTable.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
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
        public override Table CreateTable(
            CreateTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTableRequest(ref request, ref callSettings);
            return _callCreateTable.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
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
        public override async Task<Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            CreateTableFromSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTableFromSnapshotRequest(ref request, ref callSettings);
            return new Operation<Table, CreateTableFromSnapshotMetadata>(
                await _callCreateTableFromSnapshot.Async(request, callSettings).ConfigureAwait(false), CreateTableFromSnapshotOperationsClient);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
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
        public override Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(
            CreateTableFromSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTableFromSnapshotRequest(ref request, ref callSettings);
            return new Operation<Table, CreateTableFromSnapshotMetadata>(
                _callCreateTableFromSnapshot.Sync(request, callSettings), CreateTableFromSnapshotOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateTableFromSnapshot</c>.
        /// </summary>
        public override OperationsClient CreateTableFromSnapshotOperationsClient { get; }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Table"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Table"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTablesResponse, Table> ListTables(
            ListTablesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public override Task<Table> GetTableAsync(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Async(request, callSettings);
        }

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public override Table GetTable(
            GetTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public override Task DeleteTableAsync(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTableRequest(ref request, ref callSettings);
            return _callDeleteTable.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteTable(
            DeleteTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTableRequest(ref request, ref callSettings);
            _callDeleteTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public override Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyColumnFamiliesRequest(ref request, ref callSettings);
            return _callModifyColumnFamilies.Async(request, callSettings);
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
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
        public override Table ModifyColumnFamilies(
            ModifyColumnFamiliesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyColumnFamiliesRequest(ref request, ref callSettings);
            return _callModifyColumnFamilies.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
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
        public override Task DropRowRangeAsync(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            Modify_DropRowRangeRequest(ref request, ref callSettings);
            return _callDropRowRange.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DropRowRange(
            DropRowRangeRequest request,
            CallSettings callSettings = null)
        {
            Modify_DropRowRangeRequest(ref request, ref callSettings);
            _callDropRowRange.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
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
        public override Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            GenerateConsistencyTokenRequest request,
            CallSettings callSettings = null)
        {
            Modify_GenerateConsistencyTokenRequest(ref request, ref callSettings);
            return _callGenerateConsistencyToken.Async(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
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
        public override GenerateConsistencyTokenResponse GenerateConsistencyToken(
            GenerateConsistencyTokenRequest request,
            CallSettings callSettings = null)
        {
            Modify_GenerateConsistencyTokenRequest(ref request, ref callSettings);
            return _callGenerateConsistencyToken.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
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
        public override Task<CheckConsistencyResponse> CheckConsistencyAsync(
            CheckConsistencyRequest request,
            CallSettings callSettings = null)
        {
            Modify_CheckConsistencyRequest(ref request, ref callSettings);
            return _callCheckConsistency.Async(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
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
        public override CheckConsistencyResponse CheckConsistency(
            CheckConsistencyRequest request,
            CallSettings callSettings = null)
        {
            Modify_CheckConsistencyRequest(ref request, ref callSettings);
            return _callCheckConsistency.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
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
        public override async Task<Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            SnapshotTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_SnapshotTableRequest(ref request, ref callSettings);
            return new Operation<Snapshot, SnapshotTableMetadata>(
                await _callSnapshotTable.Async(request, callSettings).ConfigureAwait(false), SnapshotTableOperationsClient);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
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
        public override Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(
            SnapshotTableRequest request,
            CallSettings callSettings = null)
        {
            Modify_SnapshotTableRequest(ref request, ref callSettings);
            return new Operation<Snapshot, SnapshotTableMetadata>(
                _callSnapshotTable.Sync(request, callSettings), SnapshotTableOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>SnapshotTable</c>.
        /// </summary>
        public override OperationsClient SnapshotTableOperationsClient { get; }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
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
        public override Task<Snapshot> GetSnapshotAsync(
            GetSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets metadata information about the specified snapshot.
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
        public override Snapshot GetSnapshot(
            GetSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists all snapshots associated with the specified cluster.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists all snapshots associated with the specified cluster.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public override PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
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
        public override Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return _callDeleteSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable snapshots. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Permanently deletes the specified snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteSnapshot(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            _callDeleteSnapshot.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListTablesRequest : IPageRequest { }
    public partial class ListTablesResponse : IPageResponse<Table>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Table> GetEnumerator() => Tables.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSnapshotsRequest : IPageRequest { }
    public partial class ListSnapshotsResponse : IPageResponse<Snapshot>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Snapshot> GetEnumerator() => Snapshots.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class BigtableTableAdmin
    {
        public partial class BigtableTableAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual Operations.OperationsClient CreateOperationsClient() => new Operations.OperationsClient(CallInvoker);
        }
    }


}
