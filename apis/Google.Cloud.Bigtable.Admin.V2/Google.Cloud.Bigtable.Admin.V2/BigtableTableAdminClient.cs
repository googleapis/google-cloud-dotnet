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

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableTableAdminClient"/>.
    /// </summary>
    public sealed partial class BigtableTableAdminSettings : gaxgrpc::ServiceSettingsBase
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
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
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
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableTableAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

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
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
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
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CreateTable</c> and <c>BigtableTableAdminClient.CreateTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.CreateTable</c> and
        /// <c>BigtableTableAdminClient.CreateTableAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateTableSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CreateTableFromSnapshot</c> and <c>BigtableTableAdminClient.CreateTableFromSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.CreateTableFromSnapshot</c> and
        /// <c>BigtableTableAdminClient.CreateTableFromSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateTableFromSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.CreateTableFromSnapshot</c>.
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
        public lro::OperationsSettings CreateTableFromSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListTables</c> and <c>BigtableTableAdminClient.ListTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ListTables</c> and
        /// <c>BigtableTableAdminClient.ListTablesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListTablesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetTable</c> and <c>BigtableTableAdminClient.GetTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GetTable</c> and
        /// <c>BigtableTableAdminClient.GetTableAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetTableSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteTable</c> and <c>BigtableTableAdminClient.DeleteTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DeleteTable</c> and
        /// <c>BigtableTableAdminClient.DeleteTableAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteTableSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and
        /// <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ModifyColumnFamiliesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DropRowRange</c> and <c>BigtableTableAdminClient.DropRowRangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DropRowRange</c> and
        /// <c>BigtableTableAdminClient.DropRowRangeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DropRowRangeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GenerateConsistencyToken</c> and <c>BigtableTableAdminClient.GenerateConsistencyTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GenerateConsistencyToken</c> and
        /// <c>BigtableTableAdminClient.GenerateConsistencyTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GenerateConsistencyTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CheckConsistency</c> and <c>BigtableTableAdminClient.CheckConsistencyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.CheckConsistency</c> and
        /// <c>BigtableTableAdminClient.CheckConsistencyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CheckConsistencySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.SnapshotTable</c> and <c>BigtableTableAdminClient.SnapshotTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.SnapshotTable</c> and
        /// <c>BigtableTableAdminClient.SnapshotTableAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SnapshotTableSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.SnapshotTable</c>.
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
        public lro::OperationsSettings SnapshotTableOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetSnapshot</c> and <c>BigtableTableAdminClient.GetSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GetSnapshot</c> and
        /// <c>BigtableTableAdminClient.GetSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListSnapshots</c> and <c>BigtableTableAdminClient.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ListSnapshots</c> and
        /// <c>BigtableTableAdminClient.ListSnapshotsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteSnapshot</c> and <c>BigtableTableAdminClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.DeleteSnapshot</c> and
        /// <c>BigtableTableAdminClient.DeleteSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
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
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("bigtableadmin.googleapis.com", 443);

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
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
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

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

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
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableTableAdminClient"/>.</returns>
        public static async stt::Task<BigtableTableAdminClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, BigtableTableAdminSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableTableAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create(gaxgrpc::ServiceEndpoint endpoint = null, BigtableTableAdminSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableTableAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create(grpccore::Channel channel, BigtableTableAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            BigtableTableAdmin.BigtableTableAdminClient grpcClient = new BigtableTableAdmin.BigtableTableAdminClient(channel);
            return new BigtableTableAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, BigtableTableAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BigtableTableAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, BigtableTableAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BigtableTableAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BigtableTableAdmin client.
        /// </summary>
        public virtual BigtableTableAdmin.BigtableTableAdminClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        public virtual stt::Task<Table> CreateTableAsync(
            InstanceName parent,
            string tableId,
            Table table,
            gaxgrpc::CallSettings callSettings = null) => CreateTableAsync(
                new CreateTableRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    Table = gax::GaxPreconditions.CheckNotNull(table, nameof(table)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Table> CreateTableAsync(
            InstanceName parent,
            string tableId,
            Table table,
            st::CancellationToken cancellationToken) => CreateTableAsync(
                parent,
                tableId,
                table,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => CreateTable(
                new CreateTableRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    Table = gax::GaxPreconditions.CheckNotNull(table, nameof(table)),
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
        public virtual stt::Task<Table> CreateTableAsync(
            CreateTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Table> CreateTableAsync(
            CreateTableRequest request,
            st::CancellationToken cancellationToken) => CreateTableAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            InstanceName parent,
            string tableId,
            SnapshotName sourceSnapshot,
            gaxgrpc::CallSettings callSettings = null) => CreateTableFromSnapshotAsync(
                new CreateTableFromSnapshotRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    SourceSnapshotAsSnapshotName = gax::GaxPreconditions.CheckNotNull(sourceSnapshot, nameof(sourceSnapshot)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            InstanceName parent,
            string tableId,
            SnapshotName sourceSnapshot,
            st::CancellationToken cancellationToken) => CreateTableFromSnapshotAsync(
                parent,
                tableId,
                sourceSnapshot,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual lro::Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(
            InstanceName parent,
            string tableId,
            SnapshotName sourceSnapshot,
            gaxgrpc::CallSettings callSettings = null) => CreateTableFromSnapshot(
                new CreateTableFromSnapshotRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                    SourceSnapshotAsSnapshotName = gax::GaxPreconditions.CheckNotNull(sourceSnapshot, nameof(sourceSnapshot)),
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
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            CreateTableFromSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTableFromSnapshotAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> PollOnceCreateTableFromSnapshotAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Table, CreateTableFromSnapshotMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        public virtual lro::Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(
            CreateTableFromSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateTableFromSnapshot</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateTableFromSnapshotOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTableFromSnapshot</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Table, CreateTableFromSnapshotMetadata> PollOnceCreateTableFromSnapshot(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Table, CreateTableFromSnapshotMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        public virtual gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTablesAsync(
                new ListTablesRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual gax::PagedEnumerable<ListTablesResponse, Table> ListTables(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTables(
                new ListTablesRequest
                {
                    ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            ListTablesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListTablesResponse, Table> ListTables(
            ListTablesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<Table> GetTableAsync(
            TableName name,
            gaxgrpc::CallSettings callSettings = null) => GetTableAsync(
                new GetTableRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Table> GetTableAsync(
            TableName name,
            st::CancellationToken cancellationToken) => GetTableAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetTable(
                new GetTableRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<Table> GetTableAsync(
            GetTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets metadata information about the specified table.
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
        public virtual stt::Task<Table> GetTableAsync(
            GetTableRequest request,
            st::CancellationToken cancellationToken) => GetTableAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task DeleteTableAsync(
            TableName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTableAsync(
                new DeleteTableRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTableAsync(
            TableName name,
            st::CancellationToken cancellationToken) => DeleteTableAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => DeleteTable(
                new DeleteTableRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task DeleteTableAsync(
            DeleteTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
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
        public virtual stt::Task DeleteTableAsync(
            DeleteTableRequest request,
            st::CancellationToken cancellationToken) => DeleteTableAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(
            TableName name,
            scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            gaxgrpc::CallSettings callSettings = null) => ModifyColumnFamiliesAsync(
                new ModifyColumnFamiliesRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Modifications = { gax::GaxPreconditions.CheckNotNull(modifications, nameof(modifications)) },
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(
            TableName name,
            scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            st::CancellationToken cancellationToken) => ModifyColumnFamiliesAsync(
                name,
                modifications,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            gaxgrpc::CallSettings callSettings = null) => ModifyColumnFamilies(
                new ModifyColumnFamiliesRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Modifications = { gax::GaxPreconditions.CheckNotNull(modifications, nameof(modifications)) },
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
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            st::CancellationToken cancellationToken) => ModifyColumnFamiliesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task DropRowRangeAsync(
            DropRowRangeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DropRowRangeAsync(
            DropRowRangeRequest request,
            st::CancellationToken cancellationToken) => DropRowRangeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            TableName name,
            gaxgrpc::CallSettings callSettings = null) => GenerateConsistencyTokenAsync(
                new GenerateConsistencyTokenRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            TableName name,
            st::CancellationToken cancellationToken) => GenerateConsistencyTokenAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GenerateConsistencyToken(
                new GenerateConsistencyTokenRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            GenerateConsistencyTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            GenerateConsistencyTokenRequest request,
            st::CancellationToken cancellationToken) => GenerateConsistencyTokenAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(
            TableName name,
            string consistencyToken,
            gaxgrpc::CallSettings callSettings = null) => CheckConsistencyAsync(
                new CheckConsistencyRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(
            TableName name,
            string consistencyToken,
            st::CancellationToken cancellationToken) => CheckConsistencyAsync(
                name,
                consistencyToken,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => CheckConsistency(
                new CheckConsistencyRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
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
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(
            CheckConsistencyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(
            CheckConsistencyRequest request,
            st::CancellationToken cancellationToken) => CheckConsistencyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            TableName name,
            ClusterName cluster,
            SnapshotName snapshotId,
            string description,
            gaxgrpc::CallSettings callSettings = null) => SnapshotTableAsync(
                new SnapshotTableRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ClusterAsClusterName = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                    SnapshotIdAsSnapshotName = gax::GaxPreconditions.CheckNotNull(snapshotId, nameof(snapshotId)),
                    Description = gax::GaxPreconditions.CheckNotNullOrEmpty(description, nameof(description)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            TableName name,
            ClusterName cluster,
            SnapshotName snapshotId,
            string description,
            st::CancellationToken cancellationToken) => SnapshotTableAsync(
                name,
                cluster,
                snapshotId,
                description,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual lro::Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(
            TableName name,
            ClusterName cluster,
            SnapshotName snapshotId,
            string description,
            gaxgrpc::CallSettings callSettings = null) => SnapshotTable(
                new SnapshotTableRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ClusterAsClusterName = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                    SnapshotIdAsSnapshotName = gax::GaxPreconditions.CheckNotNull(snapshotId, nameof(snapshotId)),
                    Description = gax::GaxPreconditions.CheckNotNullOrEmpty(description, nameof(description)),
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
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            SnapshotTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SnapshotTableAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> PollOnceSnapshotTableAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Snapshot, SnapshotTableMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        public virtual lro::Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(
            SnapshotTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>SnapshotTable</c>.
        /// </summary>
        public virtual lro::OperationsClient SnapshotTableOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SnapshotTable</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Snapshot, SnapshotTableMetadata> PollOnceSnapshotTable(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Snapshot, SnapshotTableMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        public virtual stt::Task<Snapshot> GetSnapshotAsync(
            SnapshotName name,
            gaxgrpc::CallSettings callSettings = null) => GetSnapshotAsync(
                new GetSnapshotRequest
                {
                    SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(
            SnapshotName name,
            st::CancellationToken cancellationToken) => GetSnapshotAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetSnapshot(
                new GetSnapshotRequest
                {
                    SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task<Snapshot> GetSnapshotAsync(
            GetSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(
            GetSnapshotRequest request,
            st::CancellationToken cancellationToken) => GetSnapshotAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ClusterName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshotsAsync(
                new ListSnapshotsRequest
                {
                    ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ClusterName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshots(
                new ListSnapshotsRequest
                {
                    ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task DeleteSnapshotAsync(
            SnapshotName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSnapshotAsync(
                new DeleteSnapshotRequest
                {
                    SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            SnapshotName name,
            st::CancellationToken cancellationToken) => DeleteSnapshotAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => DeleteSnapshot(
                new DeleteSnapshotRequest
                {
                    SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual stt::Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            st::CancellationToken cancellationToken) => DeleteSnapshotAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// BigtableTableAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableTableAdminClientImpl : BigtableTableAdminClient
    {
        private readonly gaxgrpc::ApiCall<CreateTableRequest, Table> _callCreateTable;
        private readonly gaxgrpc::ApiCall<CreateTableFromSnapshotRequest, lro::Operation> _callCreateTableFromSnapshot;
        private readonly gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> _callListTables;
        private readonly gaxgrpc::ApiCall<GetTableRequest, Table> _callGetTable;
        private readonly gaxgrpc::ApiCall<DeleteTableRequest, pbwkt::Empty> _callDeleteTable;
        private readonly gaxgrpc::ApiCall<ModifyColumnFamiliesRequest, Table> _callModifyColumnFamilies;
        private readonly gaxgrpc::ApiCall<DropRowRangeRequest, pbwkt::Empty> _callDropRowRange;
        private readonly gaxgrpc::ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> _callGenerateConsistencyToken;
        private readonly gaxgrpc::ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> _callCheckConsistency;
        private readonly gaxgrpc::ApiCall<SnapshotTableRequest, lro::Operation> _callSnapshotTable;
        private readonly gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> _callGetSnapshot;
        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;
        private readonly gaxgrpc::ApiCall<DeleteSnapshotRequest, pbwkt::Empty> _callDeleteSnapshot;

        /// <summary>
        /// Constructs a client wrapper for the BigtableTableAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableTableAdminSettings"/> used within this client </param>
        public BigtableTableAdminClientImpl(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableTableAdminSettings effectiveSettings = settings ?? BigtableTableAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateTableFromSnapshotOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateTableFromSnapshotOperationsSettings);
            SnapshotTableOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.SnapshotTableOperationsSettings);
            _callCreateTable = clientHelper.BuildApiCall<CreateTableRequest, Table>(
                GrpcClient.CreateTableAsync, GrpcClient.CreateTable, effectiveSettings.CreateTableSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callCreateTableFromSnapshot = clientHelper.BuildApiCall<CreateTableFromSnapshotRequest, lro::Operation>(
                GrpcClient.CreateTableFromSnapshotAsync, GrpcClient.CreateTableFromSnapshot, effectiveSettings.CreateTableFromSnapshotSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callListTables = clientHelper.BuildApiCall<ListTablesRequest, ListTablesResponse>(
                GrpcClient.ListTablesAsync, GrpcClient.ListTables, effectiveSettings.ListTablesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetTable = clientHelper.BuildApiCall<GetTableRequest, Table>(
                GrpcClient.GetTableAsync, GrpcClient.GetTable, effectiveSettings.GetTableSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDeleteTable = clientHelper.BuildApiCall<DeleteTableRequest, pbwkt::Empty>(
                GrpcClient.DeleteTableAsync, GrpcClient.DeleteTable, effectiveSettings.DeleteTableSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callModifyColumnFamilies = clientHelper.BuildApiCall<ModifyColumnFamiliesRequest, Table>(
                GrpcClient.ModifyColumnFamiliesAsync, GrpcClient.ModifyColumnFamilies, effectiveSettings.ModifyColumnFamiliesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDropRowRange = clientHelper.BuildApiCall<DropRowRangeRequest, pbwkt::Empty>(
                GrpcClient.DropRowRangeAsync, GrpcClient.DropRowRange, effectiveSettings.DropRowRangeSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGenerateConsistencyToken = clientHelper.BuildApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse>(
                GrpcClient.GenerateConsistencyTokenAsync, GrpcClient.GenerateConsistencyToken, effectiveSettings.GenerateConsistencyTokenSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCheckConsistency = clientHelper.BuildApiCall<CheckConsistencyRequest, CheckConsistencyResponse>(
                GrpcClient.CheckConsistencyAsync, GrpcClient.CheckConsistency, effectiveSettings.CheckConsistencySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callSnapshotTable = clientHelper.BuildApiCall<SnapshotTableRequest, lro::Operation>(
                GrpcClient.SnapshotTableAsync, GrpcClient.SnapshotTable, effectiveSettings.SnapshotTableSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetSnapshot = clientHelper.BuildApiCall<GetSnapshotRequest, Snapshot>(
                GrpcClient.GetSnapshotAsync, GrpcClient.GetSnapshot, effectiveSettings.GetSnapshotSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>(
                GrpcClient.ListSnapshotsAsync, GrpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, pbwkt::Empty>(
                GrpcClient.DeleteSnapshotAsync, GrpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
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
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateTableApiCall(ref gaxgrpc::ApiCall<CreateTableRequest, Table> call);
        partial void Modify_CreateTableFromSnapshotApiCall(ref gaxgrpc::ApiCall<CreateTableFromSnapshotRequest, lro::Operation> call);
        partial void Modify_ListTablesApiCall(ref gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> call);
        partial void Modify_GetTableApiCall(ref gaxgrpc::ApiCall<GetTableRequest, Table> call);
        partial void Modify_DeleteTableApiCall(ref gaxgrpc::ApiCall<DeleteTableRequest, pbwkt::Empty> call);
        partial void Modify_ModifyColumnFamiliesApiCall(ref gaxgrpc::ApiCall<ModifyColumnFamiliesRequest, Table> call);
        partial void Modify_DropRowRangeApiCall(ref gaxgrpc::ApiCall<DropRowRangeRequest, pbwkt::Empty> call);
        partial void Modify_GenerateConsistencyTokenApiCall(ref gaxgrpc::ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> call);
        partial void Modify_CheckConsistencyApiCall(ref gaxgrpc::ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> call);
        partial void Modify_SnapshotTableApiCall(ref gaxgrpc::ApiCall<SnapshotTableRequest, lro::Operation> call);
        partial void Modify_GetSnapshotApiCall(ref gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> call);
        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);
        partial void Modify_DeleteSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotRequest, pbwkt::Empty> call);
        partial void OnConstruction(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BigtableTableAdmin client.
        /// </summary>
        public override BigtableTableAdmin.BigtableTableAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateTableRequest(ref CreateTableRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateTableFromSnapshotRequest(ref CreateTableFromSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTablesRequest(ref ListTablesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetTableRequest(ref GetTableRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteTableRequest(ref DeleteTableRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ModifyColumnFamiliesRequest(ref ModifyColumnFamiliesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DropRowRangeRequest(ref DropRowRangeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GenerateConsistencyTokenRequest(ref GenerateConsistencyTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CheckConsistencyRequest(ref CheckConsistencyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SnapshotTableRequest(ref SnapshotTableRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref gaxgrpc::CallSettings settings);

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
        public override stt::Task<Table> CreateTableAsync(
            CreateTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override async stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(
            CreateTableFromSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTableFromSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Table, CreateTableFromSnapshotMetadata>(
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
        public override lro::Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(
            CreateTableFromSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTableFromSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Table, CreateTableFromSnapshotMetadata>(
                _callCreateTableFromSnapshot.Sync(request, callSettings), CreateTableFromSnapshotOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateTableFromSnapshot</c>.
        /// </summary>
        public override lro::OperationsClient CreateTableFromSnapshotOperationsClient { get; }

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
        public override gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(
            ListTablesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
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
        public override gax::PagedEnumerable<ListTablesResponse, Table> ListTables(
            ListTablesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
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
        public override stt::Task<Table> GetTableAsync(
            GetTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task DeleteTableAsync(
            DeleteTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<Table> ModifyColumnFamiliesAsync(
            ModifyColumnFamiliesRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task DropRowRangeAsync(
            DropRowRangeRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(
            GenerateConsistencyTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(
            CheckConsistencyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override async stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(
            SnapshotTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotTableRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, SnapshotTableMetadata>(
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
        public override lro::Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(
            SnapshotTableRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotTableRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, SnapshotTableMetadata>(
                _callSnapshotTable.Sync(request, callSettings), SnapshotTableOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>SnapshotTable</c>.
        /// </summary>
        public override lro::OperationsClient SnapshotTableOperationsClient { get; }

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
        public override stt::Task<Snapshot> GetSnapshotAsync(
            GetSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
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
        public override gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
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
        public override stt::Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            _callDeleteSnapshot.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListTablesRequest : gaxgrpc::IPageRequest { }
    public partial class ListTablesResponse : gaxgrpc::IPageResponse<Table>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Table> GetEnumerator() => Tables.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSnapshotsRequest : gaxgrpc::IPageRequest { }
    public partial class ListSnapshotsResponse : gaxgrpc::IPageResponse<Snapshot>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Snapshot> GetEnumerator() => Snapshots.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class BigtableTableAdmin
    {
        public partial class BigtableTableAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
