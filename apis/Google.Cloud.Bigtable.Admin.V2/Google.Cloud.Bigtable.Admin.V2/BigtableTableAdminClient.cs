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
using gcbcv = Google.Cloud.Bigtable.Common.V2;
using iam = Google.Cloud.Iam.V1;
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
            ListTablesSettings = existing.ListTablesSettings;
            GetTableSettings = existing.GetTableSettings;
            DeleteTableSettings = existing.DeleteTableSettings;
            ModifyColumnFamiliesSettings = existing.ModifyColumnFamiliesSettings;
            DropRowRangeSettings = existing.DropRowRangeSettings;
            GenerateConsistencyTokenSettings = existing.GenerateConsistencyTokenSettings;
            CheckConsistencySettings = existing.CheckConsistencySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
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
        /// "IdempotentParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "IdempotentParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "IdempotentParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetIdempotentParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(1000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "IdempotentParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "IdempotentParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "IdempotentParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetIdempotentParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "NonIdempotentParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "NonIdempotentParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "NonIdempotentParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 0 milliseconds</description></item>
        /// <item><description>Maximum delay: 0 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetNonIdempotentParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(0),
            maxDelay: sys::TimeSpan.FromMilliseconds(0),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "NonIdempotentParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "NonIdempotentParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "NonIdempotentParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetNonIdempotentParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "NonIdempotentHeavyParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "NonIdempotentHeavyParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "NonIdempotentHeavyParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 0 milliseconds</description></item>
        /// <item><description>Maximum delay: 0 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetNonIdempotentHeavyParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(0),
            maxDelay: sys::TimeSpan.FromMilliseconds(0),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "NonIdempotentHeavyParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "NonIdempotentHeavyParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "NonIdempotentHeavyParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 300000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetNonIdempotentHeavyParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(300000),
            maxDelay: sys::TimeSpan.FromMilliseconds(300000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "DropRowRangeParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "DropRowRangeParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "DropRowRangeParams" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 0 milliseconds</description></item>
        /// <item><description>Maximum delay: 0 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDropRowRangeParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(0),
            maxDelay: sys::TimeSpan.FromMilliseconds(0),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "DropRowRangeParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "DropRowRangeParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "DropRowRangeParams" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDropRowRangeParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(3600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(3600000),
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
        /// <item><description>Initial retry delay: 0 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.0</description></item>
        /// <item><description>Retry maximum delay: 0 milliseconds</description></item>
        /// <item><description>Initial timeout: 300000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 300000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateTableSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetNonIdempotentHeavyParamsRetryBackoff(),
                timeoutBackoff: GetNonIdempotentHeavyParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListTables</c> and <c>BigtableTableAdminClient.ListTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ListTables</c> and
        /// <c>BigtableTableAdminClient.ListTablesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
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
                retryBackoff: GetIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetIdempotentParamsTimeoutBackoff(),
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
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
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
                retryBackoff: GetIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetIdempotentParamsTimeoutBackoff(),
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
        /// <item><description>Initial retry delay: 0 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.0</description></item>
        /// <item><description>Retry maximum delay: 0 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTableSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetNonIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetNonIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and
        /// <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 0 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.0</description></item>
        /// <item><description>Retry maximum delay: 0 milliseconds</description></item>
        /// <item><description>Initial timeout: 300000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 300000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 300000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ModifyColumnFamiliesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetNonIdempotentHeavyParamsRetryBackoff(),
                timeoutBackoff: GetNonIdempotentHeavyParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)),
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
        /// <item><description>Initial retry delay: 0 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.0</description></item>
        /// <item><description>Retry maximum delay: 0 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DropRowRangeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDropRowRangeParamsRetryBackoff(),
                timeoutBackoff: GetDropRowRangeParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
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
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
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
                retryBackoff: GetIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetIdempotentParamsTimeoutBackoff(),
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
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
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
                retryBackoff: GetIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetIamPolicy</c> and <c>BigtableTableAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.GetIamPolicy</c> and
        /// <c>BigtableTableAdminClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.SetIamPolicy</c> and <c>BigtableTableAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.SetIamPolicy</c> and
        /// <c>BigtableTableAdminClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 0 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.0</description></item>
        /// <item><description>Retry maximum delay: 0 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetNonIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetNonIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.TestIamPermissions</c> and <c>BigtableTableAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableTableAdminClient.TestIamPermissions</c> and
        /// <c>BigtableTableAdminClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableTableAdminSettings"/> object.</returns>
        public BigtableTableAdminSettings Clone() => new BigtableTableAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigtableTableAdminClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BigtableTableAdminClientBuilder : gaxgrpc::ClientBuilderBase<BigtableTableAdminClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public BigtableTableAdminSettings Settings { get; set; }

        /// <inheritdoc/>
        public override BigtableTableAdminClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigtableTableAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<BigtableTableAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigtableTableAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => BigtableTableAdminClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BigtableTableAdminClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigtableTableAdminClient.ChannelPool;
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

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableTableAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BigtableTableAdminClient client = await BigtableTableAdminClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BigtableTableAdminClient.DefaultEndpoint.Host, BigtableTableAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BigtableTableAdminClient client = BigtableTableAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
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
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BigtableTableAdminClient client = BigtableTableAdminClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Bigtable.Admin.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BigtableTableAdminClient.DefaultEndpoint.Host, BigtableTableAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BigtableTableAdminClient client = BigtableTableAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
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
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableTableAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create(grpccore::CallInvoker callInvoker, BigtableTableAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigtableTableAdmin.BigtableTableAdminClient grpcClient = new BigtableTableAdmin.BigtableTableAdminClient(callInvoker);
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
            string parent,
            string tableId,
            Table table,
            gaxgrpc::CallSettings callSettings = null) => CreateTableAsync(
                new CreateTableRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            string parent,
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
            string parent,
            string tableId,
            Table table,
            gaxgrpc::CallSettings callSettings = null) => CreateTable(
                new CreateTableRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTablesAsync(
                new ListTablesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTables(
                new ListTablesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            gcbcv::TableName name,
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
            gcbcv::TableName name,
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
            gcbcv::TableName name,
            gaxgrpc::CallSettings callSettings = null) => GetTable(
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Table> GetTableAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetTableAsync(
                new GetTableRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            string name,
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
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetTable(
                new GetTableRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            gcbcv::TableName name,
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
            gcbcv::TableName name,
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
            gcbcv::TableName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTable(
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTableAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTableAsync(
                new DeleteTableRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            string name,
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
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTable(
                new DeleteTableRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            gcbcv::TableName name,
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
            gcbcv::TableName name,
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
            gcbcv::TableName name,
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
            string name,
            scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            gaxgrpc::CallSettings callSettings = null) => ModifyColumnFamiliesAsync(
                new ModifyColumnFamiliesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            string name,
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
            string name,
            scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications,
            gaxgrpc::CallSettings callSettings = null) => ModifyColumnFamilies(
                new ModifyColumnFamiliesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            gcbcv::TableName name,
            gaxgrpc::CallSettings callSettings = null) => GenerateConsistencyTokenAsync(
                new GenerateConsistencyTokenRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
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
            gcbcv::TableName name,
            st::CancellationToken cancellationToken) => GenerateConsistencyTokenAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
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
            gcbcv::TableName name,
            gaxgrpc::CallSettings callSettings = null) => GenerateConsistencyToken(
                new GenerateConsistencyTokenRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
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
            string name,
            gaxgrpc::CallSettings callSettings = null) => GenerateConsistencyTokenAsync(
                new GenerateConsistencyTokenRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
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
            string name,
            st::CancellationToken cancellationToken) => GenerateConsistencyTokenAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
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
            string name,
            gaxgrpc::CallSettings callSettings = null) => GenerateConsistencyToken(
                new GenerateConsistencyTokenRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
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
            gcbcv::TableName name,
            string consistencyToken,
            gaxgrpc::CallSettings callSettings = null) => CheckConsistencyAsync(
                new CheckConsistencyRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
                },
                callSettings);

        /// <summary>
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
            gcbcv::TableName name,
            string consistencyToken,
            st::CancellationToken cancellationToken) => CheckConsistencyAsync(
                name,
                consistencyToken,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
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
            gcbcv::TableName name,
            string consistencyToken,
            gaxgrpc::CallSettings callSettings = null) => CheckConsistency(
                new CheckConsistencyRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
                },
                callSettings);

        /// <summary>
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
            string name,
            string consistencyToken,
            gaxgrpc::CallSettings callSettings = null) => CheckConsistencyAsync(
                new CheckConsistencyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
                },
                callSettings);

        /// <summary>
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
            string name,
            string consistencyToken,
            st::CancellationToken cancellationToken) => CheckConsistencyAsync(
                name,
                consistencyToken,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
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
            string name,
            string consistencyToken,
            gaxgrpc::CallSettings callSettings = null) => CheckConsistency(
                new CheckConsistencyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
                },
                callSettings);

        /// <summary>
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
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
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
        public virtual iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy SetIamPolicy(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        public virtual iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
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
        private readonly gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> _callListTables;
        private readonly gaxgrpc::ApiCall<GetTableRequest, Table> _callGetTable;
        private readonly gaxgrpc::ApiCall<DeleteTableRequest, pbwkt::Empty> _callDeleteTable;
        private readonly gaxgrpc::ApiCall<ModifyColumnFamiliesRequest, Table> _callModifyColumnFamilies;
        private readonly gaxgrpc::ApiCall<DropRowRangeRequest, pbwkt::Empty> _callDropRowRange;
        private readonly gaxgrpc::ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> _callGenerateConsistencyToken;
        private readonly gaxgrpc::ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> _callCheckConsistency;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;

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
            _callCreateTable = clientHelper.BuildApiCall<CreateTableRequest, Table>(
                GrpcClient.CreateTableAsync, GrpcClient.CreateTable, effectiveSettings.CreateTableSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callListTables = clientHelper.BuildApiCall<ListTablesRequest, ListTablesResponse>(
                GrpcClient.ListTablesAsync, GrpcClient.ListTables, effectiveSettings.ListTablesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetTable = clientHelper.BuildApiCall<GetTableRequest, Table>(
                GrpcClient.GetTableAsync, GrpcClient.GetTable, effectiveSettings.GetTableSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteTable = clientHelper.BuildApiCall<DeleteTableRequest, pbwkt::Empty>(
                GrpcClient.DeleteTableAsync, GrpcClient.DeleteTable, effectiveSettings.DeleteTableSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callModifyColumnFamilies = clientHelper.BuildApiCall<ModifyColumnFamiliesRequest, Table>(
                GrpcClient.ModifyColumnFamiliesAsync, GrpcClient.ModifyColumnFamilies, effectiveSettings.ModifyColumnFamiliesSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDropRowRange = clientHelper.BuildApiCall<DropRowRangeRequest, pbwkt::Empty>(
                GrpcClient.DropRowRangeAsync, GrpcClient.DropRowRange, effectiveSettings.DropRowRangeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGenerateConsistencyToken = clientHelper.BuildApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse>(
                GrpcClient.GenerateConsistencyTokenAsync, GrpcClient.GenerateConsistencyToken, effectiveSettings.GenerateConsistencyTokenSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCheckConsistency = clientHelper.BuildApiCall<CheckConsistencyRequest, CheckConsistencyResponse>(
                GrpcClient.CheckConsistencyAsync, GrpcClient.CheckConsistency, effectiveSettings.CheckConsistencySettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callCreateTable);
            Modify_CreateTableApiCall(ref _callCreateTable);
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
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
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
        partial void Modify_ListTablesApiCall(ref gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> call);
        partial void Modify_GetTableApiCall(ref gaxgrpc::ApiCall<GetTableRequest, Table> call);
        partial void Modify_DeleteTableApiCall(ref gaxgrpc::ApiCall<DeleteTableRequest, pbwkt::Empty> call);
        partial void Modify_ModifyColumnFamiliesApiCall(ref gaxgrpc::ApiCall<ModifyColumnFamiliesRequest, Table> call);
        partial void Modify_DropRowRangeApiCall(ref gaxgrpc::ApiCall<DropRowRangeRequest, pbwkt::Empty> call);
        partial void Modify_GenerateConsistencyTokenApiCall(ref gaxgrpc::ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> call);
        partial void Modify_CheckConsistencyApiCall(ref gaxgrpc::ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void OnConstruction(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BigtableTableAdmin client.
        /// </summary>
        public override BigtableTableAdmin.BigtableTableAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateTableRequest(ref CreateTableRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTablesRequest(ref ListTablesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetTableRequest(ref GetTableRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteTableRequest(ref DeleteTableRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ModifyColumnFamiliesRequest(ref ModifyColumnFamiliesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DropRowRangeRequest(ref DropRowRangeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GenerateConsistencyTokenRequest(ref GenerateConsistencyTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CheckConsistencyRequest(ref CheckConsistencyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

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
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
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
        public override stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a table resource. Returns an empty
        /// policy if an table exists but does not have a policy set.
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
        public override iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        public override stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a table resource. Replaces any existing
        /// policy.
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
        public override iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        public override stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified table resource.
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
        public override iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
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


}
