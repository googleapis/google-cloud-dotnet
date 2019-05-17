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
using iam = Google.Cloud.Iam.V1;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using gv = Grafeas.V1;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DevTools.ContainerAnalysis.V1
{
    /// <summary>
    /// Settings for a <see cref="ContainerAnalysisClient"/>.
    /// </summary>
    public sealed partial class ContainerAnalysisSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ContainerAnalysisSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ContainerAnalysisSettings"/>.
        /// </returns>
        public static ContainerAnalysisSettings GetDefault() => new ContainerAnalysisSettings();

        /// <summary>
        /// Constructs a new <see cref="ContainerAnalysisSettings"/> object with default settings.
        /// </summary>
        public ContainerAnalysisSettings() { }

        private ContainerAnalysisSettings(ContainerAnalysisSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            GetOccurrenceSettings = existing.GetOccurrenceSettings;
            ListOccurrencesSettings = existing.ListOccurrencesSettings;
            DeleteOccurrenceSettings = existing.DeleteOccurrenceSettings;
            CreateOccurrenceSettings = existing.CreateOccurrenceSettings;
            BatchCreateOccurrencesSettings = existing.BatchCreateOccurrencesSettings;
            UpdateOccurrenceSettings = existing.UpdateOccurrenceSettings;
            GetOccurrenceNoteSettings = existing.GetOccurrenceNoteSettings;
            GetNoteSettings = existing.GetNoteSettings;
            ListNotesSettings = existing.ListNotesSettings;
            DeleteNoteSettings = existing.DeleteNoteSettings;
            CreateNoteSettings = existing.CreateNoteSettings;
            BatchCreateNotesSettings = existing.BatchCreateNotesSettings;
            UpdateNoteSettings = existing.UpdateNoteSettings;
            ListNoteOccurrencesSettings = existing.ListNoteOccurrencesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContainerAnalysisSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ContainerAnalysisClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ContainerAnalysisClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ContainerAnalysisClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ContainerAnalysisClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ContainerAnalysisClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ContainerAnalysisClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ContainerAnalysisClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ContainerAnalysisClient"/> RPC methods is defined as:
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
        /// <c>ContainerAnalysisClient.SetIamPolicy</c> and <c>ContainerAnalysisClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.SetIamPolicy</c> and
        /// <c>ContainerAnalysisClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.GetIamPolicy</c> and <c>ContainerAnalysisClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.GetIamPolicy</c> and
        /// <c>ContainerAnalysisClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.TestIamPermissions</c> and <c>ContainerAnalysisClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.TestIamPermissions</c> and
        /// <c>ContainerAnalysisClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.GetOccurrence</c> and <c>ContainerAnalysisClient.GetOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.GetOccurrence</c> and
        /// <c>ContainerAnalysisClient.GetOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.ListOccurrences</c> and <c>ContainerAnalysisClient.ListOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.ListOccurrences</c> and
        /// <c>ContainerAnalysisClient.ListOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListOccurrencesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.DeleteOccurrence</c> and <c>ContainerAnalysisClient.DeleteOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.DeleteOccurrence</c> and
        /// <c>ContainerAnalysisClient.DeleteOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.CreateOccurrence</c> and <c>ContainerAnalysisClient.CreateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.CreateOccurrence</c> and
        /// <c>ContainerAnalysisClient.CreateOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.BatchCreateOccurrences</c> and <c>ContainerAnalysisClient.BatchCreateOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.BatchCreateOccurrences</c> and
        /// <c>ContainerAnalysisClient.BatchCreateOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchCreateOccurrencesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.UpdateOccurrence</c> and <c>ContainerAnalysisClient.UpdateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.UpdateOccurrence</c> and
        /// <c>ContainerAnalysisClient.UpdateOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.GetOccurrenceNote</c> and <c>ContainerAnalysisClient.GetOccurrenceNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.GetOccurrenceNote</c> and
        /// <c>ContainerAnalysisClient.GetOccurrenceNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetOccurrenceNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.GetNote</c> and <c>ContainerAnalysisClient.GetNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.GetNote</c> and
        /// <c>ContainerAnalysisClient.GetNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.ListNotes</c> and <c>ContainerAnalysisClient.ListNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.ListNotes</c> and
        /// <c>ContainerAnalysisClient.ListNotesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListNotesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.DeleteNote</c> and <c>ContainerAnalysisClient.DeleteNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.DeleteNote</c> and
        /// <c>ContainerAnalysisClient.DeleteNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.CreateNote</c> and <c>ContainerAnalysisClient.CreateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.CreateNote</c> and
        /// <c>ContainerAnalysisClient.CreateNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.BatchCreateNotes</c> and <c>ContainerAnalysisClient.BatchCreateNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.BatchCreateNotes</c> and
        /// <c>ContainerAnalysisClient.BatchCreateNotesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchCreateNotesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.UpdateNote</c> and <c>ContainerAnalysisClient.UpdateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.UpdateNote</c> and
        /// <c>ContainerAnalysisClient.UpdateNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.ListNoteOccurrences</c> and <c>ContainerAnalysisClient.ListNoteOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisClient.ListNoteOccurrences</c> and
        /// <c>ContainerAnalysisClient.ListNoteOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListNoteOccurrencesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ContainerAnalysisSettings"/> object.</returns>
        public ContainerAnalysisSettings Clone() => new ContainerAnalysisSettings(this);
    }

    /// <summary>
    /// ContainerAnalysis client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ContainerAnalysisClient
    {
        /// <summary>
        /// The default endpoint for the ContainerAnalysis service, which is a host of "containeranalysis.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("containeranalysis.googleapis.com", 443);

        /// <summary>
        /// The default ContainerAnalysis scopes.
        /// </summary>
        /// <remarks>
        /// The default ContainerAnalysis scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ContainerAnalysisClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.DevTools.ContainerAnalysis.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ContainerAnalysisClient client = await ContainerAnalysisClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.DevTools.ContainerAnalysis.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ContainerAnalysisClient.DefaultEndpoint.Host, ContainerAnalysisClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ContainerAnalysisClient client = ContainerAnalysisClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ContainerAnalysisClient"/>.</returns>
        public static async stt::Task<ContainerAnalysisClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ContainerAnalysisSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ContainerAnalysisClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.DevTools.ContainerAnalysis.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ContainerAnalysisClient client = ContainerAnalysisClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.DevTools.ContainerAnalysis.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ContainerAnalysisClient.DefaultEndpoint.Host, ContainerAnalysisClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ContainerAnalysisClient client = ContainerAnalysisClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisSettings"/>.</param>
        /// <returns>The created <see cref="ContainerAnalysisClient"/>.</returns>
        public static ContainerAnalysisClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ContainerAnalysisSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ContainerAnalysisClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisSettings"/>.</param>
        /// <returns>The created <see cref="ContainerAnalysisClient"/>.</returns>
        public static ContainerAnalysisClient Create(grpccore::Channel channel, ContainerAnalysisSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ContainerAnalysisClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisSettings"/>.</param>
        /// <returns>The created <see cref="ContainerAnalysisClient"/>.</returns>
        public static ContainerAnalysisClient Create(grpccore::CallInvoker callInvoker, ContainerAnalysisSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContainerAnalysis.ContainerAnalysisClient grpcClient = new ContainerAnalysis.ContainerAnalysisClient(callInvoker);
            return new ContainerAnalysisClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ContainerAnalysisSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ContainerAnalysisSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ContainerAnalysisSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ContainerAnalysisSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ContainerAnalysis client.
        /// </summary>
        public virtual ContainerAnalysis.ContainerAnalysisClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
            IamResourceNameOneof resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceAsync(
                new gv::GetOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::OccurrenceName name,
            st::CancellationToken cancellationToken) => GetOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence GetOccurrence(
            gv::OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrence(
                new gv::GetOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceAsync(
                new gv::GetOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            string name,
            st::CancellationToken cancellationToken) => GetOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence GetOccurrence(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrence(
                new gv::GetOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::GetOccurrenceRequest request,
            st::CancellationToken cancellationToken) => GetOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
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
        public virtual gv::Occurrence GetOccurrence(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            gv::ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrencesAsync(
                new gv::ListOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            gv::ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrences(
                new gv::ListOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrencesAsync(
                new gv::ListOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrences(
                new gv::ListOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            gv::OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrenceAsync(
                new gv::DeleteOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            gv::OccurrenceName name,
            st::CancellationToken cancellationToken) => DeleteOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteOccurrence(
            gv::OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrence(
                new gv::DeleteOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrenceAsync(
                new gv::DeleteOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteOccurrence(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrence(
                new gv::DeleteOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
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
        public virtual stt::Task DeleteOccurrenceAsync(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
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
        public virtual stt::Task DeleteOccurrenceAsync(
            gv::DeleteOccurrenceRequest request,
            st::CancellationToken cancellationToken) => DeleteOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteOccurrence(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::ProjectName parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrenceAsync(
                new gv::CreateOccurrenceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::ProjectName parent,
            gv::Occurrence occurrence,
            st::CancellationToken cancellationToken) => CreateOccurrenceAsync(
                parent,
                occurrence,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence CreateOccurrence(
            gv::ProjectName parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrence(
                new gv::CreateOccurrenceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            string parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrenceAsync(
                new gv::CreateOccurrenceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            string parent,
            gv::Occurrence occurrence,
            st::CancellationToken cancellationToken) => CreateOccurrenceAsync(
                parent,
                occurrence,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence CreateOccurrence(
            string parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrence(
                new gv::CreateOccurrenceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
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
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new occurrence.
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
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::CreateOccurrenceRequest request,
            st::CancellationToken cancellationToken) => CreateOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
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
        public virtual gv::Occurrence CreateOccurrence(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::ProjectName parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrencesAsync(
                new gv::BatchCreateOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::ProjectName parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            st::CancellationToken cancellationToken) => BatchCreateOccurrencesAsync(
                parent,
                occurrences,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            gv::ProjectName parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrences(
                new gv::BatchCreateOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            string parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrencesAsync(
                new gv::BatchCreateOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            string parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            st::CancellationToken cancellationToken) => BatchCreateOccurrencesAsync(
                parent,
                occurrences,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            string parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrences(
                new gv::BatchCreateOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
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
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new occurrences in batch.
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
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::BatchCreateOccurrencesRequest request,
            st::CancellationToken cancellationToken) => BatchCreateOccurrencesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
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
        public virtual gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::OccurrenceName name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrenceAsync(
                new gv::UpdateOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::OccurrenceName name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateOccurrenceAsync(
                name,
                occurrence,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence UpdateOccurrence(
            gv::OccurrenceName name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrence(
                new gv::UpdateOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            string name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrenceAsync(
                new gv::UpdateOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            string name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateOccurrenceAsync(
                name,
                occurrence,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence UpdateOccurrence(
            string name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrence(
                new gv::UpdateOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::UpdateOccurrenceRequest request,
            st::CancellationToken cancellationToken) => UpdateOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
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
        public virtual gv::Occurrence UpdateOccurrence(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNoteAsync(
                new gv::GetOccurrenceNoteRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::OccurrenceName name,
            st::CancellationToken cancellationToken) => GetOccurrenceNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetOccurrenceNote(
            gv::OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNote(
                new gv::GetOccurrenceNoteRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNoteAsync(
                new gv::GetOccurrenceNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            string name,
            st::CancellationToken cancellationToken) => GetOccurrenceNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetOccurrenceNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNote(
                new gv::GetOccurrenceNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::GetOccurrenceNoteRequest request,
            st::CancellationToken cancellationToken) => GetOccurrenceNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public virtual gv::Note GetOccurrenceNote(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            gv::NoteName name,
            gaxgrpc::CallSettings callSettings = null) => GetNoteAsync(
                new gv::GetNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            gv::NoteName name,
            st::CancellationToken cancellationToken) => GetNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetNote(
            gv::NoteName name,
            gaxgrpc::CallSettings callSettings = null) => GetNote(
                new gv::GetNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNoteAsync(
                new gv::GetNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            string name,
            st::CancellationToken cancellationToken) => GetNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNote(
                new gv::GetNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
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
        public virtual stt::Task<gv::Note> GetNoteAsync(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified note.
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
        public virtual stt::Task<gv::Note> GetNoteAsync(
            gv::GetNoteRequest request,
            st::CancellationToken cancellationToken) => GetNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
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
        public virtual gv::Note GetNote(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            gv::ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotesAsync(
                new gv::ListNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            gv::ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotes(
                new gv::ListNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotesAsync(
                new gv::ListNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotes(
                new gv::ListNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            gv::NoteName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNoteAsync(
                new gv::DeleteNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            gv::NoteName name,
            st::CancellationToken cancellationToken) => DeleteNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNote(
            gv::NoteName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNote(
                new gv::DeleteNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNoteAsync(
                new gv::DeleteNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNote(
                new gv::DeleteNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
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
        public virtual stt::Task DeleteNoteAsync(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified note.
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
        public virtual stt::Task DeleteNoteAsync(
            gv::DeleteNoteRequest request,
            st::CancellationToken cancellationToken) => DeleteNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNote(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            gv::ProjectName parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNoteAsync(
                new gv::CreateNoteRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            gv::ProjectName parent,
            string noteId,
            gv::Note note,
            st::CancellationToken cancellationToken) => CreateNoteAsync(
                parent,
                noteId,
                note,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note CreateNote(
            gv::ProjectName parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNote(
                new gv::CreateNoteRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            string parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNoteAsync(
                new gv::CreateNoteRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            string parent,
            string noteId,
            gv::Note note,
            st::CancellationToken cancellationToken) => CreateNoteAsync(
                parent,
                noteId,
                note,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note CreateNote(
            string parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNote(
                new gv::CreateNoteRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
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
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new note.
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
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            gv::CreateNoteRequest request,
            st::CancellationToken cancellationToken) => CreateNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
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
        public virtual gv::Note CreateNote(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::ProjectName parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotesAsync(
                new gv::BatchCreateNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::ProjectName parent,
            scg::IDictionary<string, gv::Note> notes,
            st::CancellationToken cancellationToken) => BatchCreateNotesAsync(
                parent,
                notes,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateNotesResponse BatchCreateNotes(
            gv::ProjectName parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotes(
                new gv::BatchCreateNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            string parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotesAsync(
                new gv::BatchCreateNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            string parent,
            scg::IDictionary<string, gv::Note> notes,
            st::CancellationToken cancellationToken) => BatchCreateNotesAsync(
                parent,
                notes,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateNotesResponse BatchCreateNotes(
            string parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotes(
                new gv::BatchCreateNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
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
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new notes in batch.
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
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::BatchCreateNotesRequest request,
            st::CancellationToken cancellationToken) => BatchCreateNotesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
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
        public virtual gv::BatchCreateNotesResponse BatchCreateNotes(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            gv::NoteName name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNoteAsync(
                new gv::UpdateNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            gv::NoteName name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateNoteAsync(
                name,
                note,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note UpdateNote(
            gv::NoteName name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNote(
                new gv::UpdateNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            string name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNoteAsync(
                new gv::UpdateNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            string name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateNoteAsync(
                name,
                note,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note UpdateNote(
            string name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNote(
                new gv::UpdateNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
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
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified note.
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
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            gv::UpdateNoteRequest request,
            st::CancellationToken cancellationToken) => UpdateNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
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
        public virtual gv::Note UpdateNote(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            gv::NoteName name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrencesAsync(
                new gv::ListNoteOccurrencesRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            gv::NoteName name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrences(
                new gv::ListNoteOccurrencesRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrencesAsync(
                new gv::ListNoteOccurrencesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrences(
                new gv::ListNoteOccurrencesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ContainerAnalysis client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ContainerAnalysisClientImpl : ContainerAnalysisClient
    {
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;
        private readonly gaxgrpc::ApiCall<gv::GetOccurrenceRequest, gv::Occurrence> _callGetOccurrence;
        private readonly gaxgrpc::ApiCall<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse> _callListOccurrences;
        private readonly gaxgrpc::ApiCall<gv::DeleteOccurrenceRequest, pbwkt::Empty> _callDeleteOccurrence;
        private readonly gaxgrpc::ApiCall<gv::CreateOccurrenceRequest, gv::Occurrence> _callCreateOccurrence;
        private readonly gaxgrpc::ApiCall<gv::BatchCreateOccurrencesRequest, gv::BatchCreateOccurrencesResponse> _callBatchCreateOccurrences;
        private readonly gaxgrpc::ApiCall<gv::UpdateOccurrenceRequest, gv::Occurrence> _callUpdateOccurrence;
        private readonly gaxgrpc::ApiCall<gv::GetOccurrenceNoteRequest, gv::Note> _callGetOccurrenceNote;
        private readonly gaxgrpc::ApiCall<gv::GetNoteRequest, gv::Note> _callGetNote;
        private readonly gaxgrpc::ApiCall<gv::ListNotesRequest, gv::ListNotesResponse> _callListNotes;
        private readonly gaxgrpc::ApiCall<gv::DeleteNoteRequest, pbwkt::Empty> _callDeleteNote;
        private readonly gaxgrpc::ApiCall<gv::CreateNoteRequest, gv::Note> _callCreateNote;
        private readonly gaxgrpc::ApiCall<gv::BatchCreateNotesRequest, gv::BatchCreateNotesResponse> _callBatchCreateNotes;
        private readonly gaxgrpc::ApiCall<gv::UpdateNoteRequest, gv::Note> _callUpdateNote;
        private readonly gaxgrpc::ApiCall<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse> _callListNoteOccurrences;

        /// <summary>
        /// Constructs a client wrapper for the ContainerAnalysis service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContainerAnalysisSettings"/> used within this client </param>
        public ContainerAnalysisClientImpl(ContainerAnalysis.ContainerAnalysisClient grpcClient, ContainerAnalysisSettings settings)
        {
            GrpcClient = grpcClient;
            ContainerAnalysisSettings effectiveSettings = settings ?? ContainerAnalysisSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            gv::Grafeas.GrafeasClient grpcGrafeasClient = grpcClient.CreateGrafeasClient();
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callGetOccurrence = clientHelper.BuildApiCall<gv::GetOccurrenceRequest, gv::Occurrence>(
                grpcGrafeasClient.GetOccurrenceAsync, grpcGrafeasClient.GetOccurrence, effectiveSettings.GetOccurrenceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListOccurrences = clientHelper.BuildApiCall<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse>(
                grpcGrafeasClient.ListOccurrencesAsync, grpcGrafeasClient.ListOccurrences, effectiveSettings.ListOccurrencesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callDeleteOccurrence = clientHelper.BuildApiCall<gv::DeleteOccurrenceRequest, pbwkt::Empty>(
                grpcGrafeasClient.DeleteOccurrenceAsync, grpcGrafeasClient.DeleteOccurrence, effectiveSettings.DeleteOccurrenceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateOccurrence = clientHelper.BuildApiCall<gv::CreateOccurrenceRequest, gv::Occurrence>(
                grpcGrafeasClient.CreateOccurrenceAsync, grpcGrafeasClient.CreateOccurrence, effectiveSettings.CreateOccurrenceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callBatchCreateOccurrences = clientHelper.BuildApiCall<gv::BatchCreateOccurrencesRequest, gv::BatchCreateOccurrencesResponse>(
                grpcGrafeasClient.BatchCreateOccurrencesAsync, grpcGrafeasClient.BatchCreateOccurrences, effectiveSettings.BatchCreateOccurrencesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callUpdateOccurrence = clientHelper.BuildApiCall<gv::UpdateOccurrenceRequest, gv::Occurrence>(
                grpcGrafeasClient.UpdateOccurrenceAsync, grpcGrafeasClient.UpdateOccurrence, effectiveSettings.UpdateOccurrenceSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetOccurrenceNote = clientHelper.BuildApiCall<gv::GetOccurrenceNoteRequest, gv::Note>(
                grpcGrafeasClient.GetOccurrenceNoteAsync, grpcGrafeasClient.GetOccurrenceNote, effectiveSettings.GetOccurrenceNoteSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetNote = clientHelper.BuildApiCall<gv::GetNoteRequest, gv::Note>(
                grpcGrafeasClient.GetNoteAsync, grpcGrafeasClient.GetNote, effectiveSettings.GetNoteSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListNotes = clientHelper.BuildApiCall<gv::ListNotesRequest, gv::ListNotesResponse>(
                grpcGrafeasClient.ListNotesAsync, grpcGrafeasClient.ListNotes, effectiveSettings.ListNotesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callDeleteNote = clientHelper.BuildApiCall<gv::DeleteNoteRequest, pbwkt::Empty>(
                grpcGrafeasClient.DeleteNoteAsync, grpcGrafeasClient.DeleteNote, effectiveSettings.DeleteNoteSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateNote = clientHelper.BuildApiCall<gv::CreateNoteRequest, gv::Note>(
                grpcGrafeasClient.CreateNoteAsync, grpcGrafeasClient.CreateNote, effectiveSettings.CreateNoteSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callBatchCreateNotes = clientHelper.BuildApiCall<gv::BatchCreateNotesRequest, gv::BatchCreateNotesResponse>(
                grpcGrafeasClient.BatchCreateNotesAsync, grpcGrafeasClient.BatchCreateNotes, effectiveSettings.BatchCreateNotesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callUpdateNote = clientHelper.BuildApiCall<gv::UpdateNoteRequest, gv::Note>(
                grpcGrafeasClient.UpdateNoteAsync, grpcGrafeasClient.UpdateNote, effectiveSettings.UpdateNoteSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListNoteOccurrences = clientHelper.BuildApiCall<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse>(
                grpcGrafeasClient.ListNoteOccurrencesAsync, grpcGrafeasClient.ListNoteOccurrences, effectiveSettings.ListNoteOccurrencesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            Modify_ApiCall(ref _callGetOccurrence);
            Modify_GetOccurrenceApiCall(ref _callGetOccurrence);
            Modify_ApiCall(ref _callListOccurrences);
            Modify_ListOccurrencesApiCall(ref _callListOccurrences);
            Modify_ApiCall(ref _callDeleteOccurrence);
            Modify_DeleteOccurrenceApiCall(ref _callDeleteOccurrence);
            Modify_ApiCall(ref _callCreateOccurrence);
            Modify_CreateOccurrenceApiCall(ref _callCreateOccurrence);
            Modify_ApiCall(ref _callBatchCreateOccurrences);
            Modify_BatchCreateOccurrencesApiCall(ref _callBatchCreateOccurrences);
            Modify_ApiCall(ref _callUpdateOccurrence);
            Modify_UpdateOccurrenceApiCall(ref _callUpdateOccurrence);
            Modify_ApiCall(ref _callGetOccurrenceNote);
            Modify_GetOccurrenceNoteApiCall(ref _callGetOccurrenceNote);
            Modify_ApiCall(ref _callGetNote);
            Modify_GetNoteApiCall(ref _callGetNote);
            Modify_ApiCall(ref _callListNotes);
            Modify_ListNotesApiCall(ref _callListNotes);
            Modify_ApiCall(ref _callDeleteNote);
            Modify_DeleteNoteApiCall(ref _callDeleteNote);
            Modify_ApiCall(ref _callCreateNote);
            Modify_CreateNoteApiCall(ref _callCreateNote);
            Modify_ApiCall(ref _callBatchCreateNotes);
            Modify_BatchCreateNotesApiCall(ref _callBatchCreateNotes);
            Modify_ApiCall(ref _callUpdateNote);
            Modify_UpdateNoteApiCall(ref _callUpdateNote);
            Modify_ApiCall(ref _callListNoteOccurrences);
            Modify_ListNoteOccurrencesApiCall(ref _callListNoteOccurrences);
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
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void Modify_GetOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::GetOccurrenceRequest, gv::Occurrence> call);
        partial void Modify_ListOccurrencesApiCall(ref gaxgrpc::ApiCall<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse> call);
        partial void Modify_DeleteOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::DeleteOccurrenceRequest, pbwkt::Empty> call);
        partial void Modify_CreateOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::CreateOccurrenceRequest, gv::Occurrence> call);
        partial void Modify_BatchCreateOccurrencesApiCall(ref gaxgrpc::ApiCall<gv::BatchCreateOccurrencesRequest, gv::BatchCreateOccurrencesResponse> call);
        partial void Modify_UpdateOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::UpdateOccurrenceRequest, gv::Occurrence> call);
        partial void Modify_GetOccurrenceNoteApiCall(ref gaxgrpc::ApiCall<gv::GetOccurrenceNoteRequest, gv::Note> call);
        partial void Modify_GetNoteApiCall(ref gaxgrpc::ApiCall<gv::GetNoteRequest, gv::Note> call);
        partial void Modify_ListNotesApiCall(ref gaxgrpc::ApiCall<gv::ListNotesRequest, gv::ListNotesResponse> call);
        partial void Modify_DeleteNoteApiCall(ref gaxgrpc::ApiCall<gv::DeleteNoteRequest, pbwkt::Empty> call);
        partial void Modify_CreateNoteApiCall(ref gaxgrpc::ApiCall<gv::CreateNoteRequest, gv::Note> call);
        partial void Modify_BatchCreateNotesApiCall(ref gaxgrpc::ApiCall<gv::BatchCreateNotesRequest, gv::BatchCreateNotesResponse> call);
        partial void Modify_UpdateNoteApiCall(ref gaxgrpc::ApiCall<gv::UpdateNoteRequest, gv::Note> call);
        partial void Modify_ListNoteOccurrencesApiCall(ref gaxgrpc::ApiCall<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse> call);
        partial void OnConstruction(ContainerAnalysis.ContainerAnalysisClient grpcClient, ContainerAnalysisSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ContainerAnalysis client.
        /// </summary>
        public override ContainerAnalysis.ContainerAnalysisClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetOccurrenceRequest(ref gv::GetOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListOccurrencesRequest(ref gv::ListOccurrencesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteOccurrenceRequest(ref gv::DeleteOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateOccurrenceRequest(ref gv::CreateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateOccurrencesRequest(ref gv::BatchCreateOccurrencesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateOccurrenceRequest(ref gv::UpdateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetOccurrenceNoteRequest(ref gv::GetOccurrenceNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetNoteRequest(ref gv::GetNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListNotesRequest(ref gv::ListNotesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteNoteRequest(ref gv::DeleteNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateNoteRequest(ref gv::CreateNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateNotesRequest(ref gv::BatchCreateNotesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateNoteRequest(ref gv::UpdateNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListNoteOccurrencesRequest(ref gv::ListNoteOccurrencesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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

        /// <summary>
        /// Gets the specified occurrence.
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
        public override stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceRequest(ref request, ref callSettings);
            return _callGetOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified occurrence.
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
        public override gv::Occurrence GetOccurrence(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceRequest(ref request, ref callSettings);
            return _callGetOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse, gv::Occurrence>(_callListOccurrences, request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse, gv::Occurrence>(_callListOccurrences, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
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
        public override stt::Task DeleteOccurrenceAsync(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOccurrenceRequest(ref request, ref callSettings);
            return _callDeleteOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteOccurrence(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOccurrenceRequest(ref request, ref callSettings);
            _callDeleteOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new occurrence.
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
        public override stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOccurrenceRequest(ref request, ref callSettings);
            return _callCreateOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new occurrence.
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
        public override gv::Occurrence CreateOccurrence(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOccurrenceRequest(ref request, ref callSettings);
            return _callCreateOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new occurrences in batch.
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
        public override stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOccurrencesRequest(ref request, ref callSettings);
            return _callBatchCreateOccurrences.Async(request, callSettings);
        }

        /// <summary>
        /// Creates new occurrences in batch.
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
        public override gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOccurrencesRequest(ref request, ref callSettings);
            return _callBatchCreateOccurrences.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified occurrence.
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
        public override stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOccurrenceRequest(ref request, ref callSettings);
            return _callUpdateOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified occurrence.
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
        public override gv::Occurrence UpdateOccurrence(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOccurrenceRequest(ref request, ref callSettings);
            return _callUpdateOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public override stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceNoteRequest(ref request, ref callSettings);
            return _callGetOccurrenceNote.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public override gv::Note GetOccurrenceNote(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceNoteRequest(ref request, ref callSettings);
            return _callGetOccurrenceNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified note.
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
        public override stt::Task<gv::Note> GetNoteAsync(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNoteRequest(ref request, ref callSettings);
            return _callGetNote.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified note.
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
        public override gv::Note GetNote(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNoteRequest(ref request, ref callSettings);
            return _callGetNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<gv::ListNotesRequest, gv::ListNotesResponse, gv::Note>(_callListNotes, request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<gv::ListNotesRequest, gv::ListNotesResponse, gv::Note>(_callListNotes, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified note.
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
        public override stt::Task DeleteNoteAsync(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNoteRequest(ref request, ref callSettings);
            return _callDeleteNote.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteNote(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNoteRequest(ref request, ref callSettings);
            _callDeleteNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new note.
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
        public override stt::Task<gv::Note> CreateNoteAsync(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNoteRequest(ref request, ref callSettings);
            return _callCreateNote.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new note.
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
        public override gv::Note CreateNote(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNoteRequest(ref request, ref callSettings);
            return _callCreateNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new notes in batch.
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
        public override stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNotesRequest(ref request, ref callSettings);
            return _callBatchCreateNotes.Async(request, callSettings);
        }

        /// <summary>
        /// Creates new notes in batch.
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
        public override gv::BatchCreateNotesResponse BatchCreateNotes(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNotesRequest(ref request, ref callSettings);
            return _callBatchCreateNotes.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified note.
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
        public override stt::Task<gv::Note> UpdateNoteAsync(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNoteRequest(ref request, ref callSettings);
            return _callUpdateNote.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified note.
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
        public override gv::Note UpdateNote(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNoteRequest(ref request, ref callSettings);
            return _callUpdateNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse, gv::Occurrence>(_callListNoteOccurrences, request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse, gv::Occurrence>(_callListNoteOccurrences, request, callSettings);
        }

    }

    // Partial Grpc class to enable gv::Grafeas.GrafeasClient client creation
    public static partial class ContainerAnalysis
    {
        public partial class ContainerAnalysisClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gv::Grafeas.GrafeasClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new gv::Grafeas.GrafeasClient for the same target as this client.</returns>
            public virtual gv::Grafeas.GrafeasClient CreateGrafeasClient() => new gv::Grafeas.GrafeasClient(CallInvoker);
        }
    }


}
