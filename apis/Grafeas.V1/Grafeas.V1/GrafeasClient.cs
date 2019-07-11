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

namespace Grafeas.V1
{
    /// <summary>
    /// Settings for a <see cref="GrafeasClient"/>.
    /// </summary>
    public sealed partial class GrafeasSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GrafeasSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GrafeasSettings"/>.
        /// </returns>
        public static GrafeasSettings GetDefault() => new GrafeasSettings();

        /// <summary>
        /// Constructs a new <see cref="GrafeasSettings"/> object with default settings.
        /// </summary>
        public GrafeasSettings() { }

        private GrafeasSettings(GrafeasSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
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

        partial void OnCopy(GrafeasSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GrafeasClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="GrafeasClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GrafeasClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GrafeasClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GrafeasClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="GrafeasClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GrafeasClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GrafeasClient"/> RPC methods is defined as:
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
        /// <c>GrafeasClient.GetOccurrence</c> and <c>GrafeasClient.GetOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.GetOccurrence</c> and
        /// <c>GrafeasClient.GetOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.ListOccurrences</c> and <c>GrafeasClient.ListOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.ListOccurrences</c> and
        /// <c>GrafeasClient.ListOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.DeleteOccurrence</c> and <c>GrafeasClient.DeleteOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.DeleteOccurrence</c> and
        /// <c>GrafeasClient.DeleteOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.CreateOccurrence</c> and <c>GrafeasClient.CreateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.CreateOccurrence</c> and
        /// <c>GrafeasClient.CreateOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.BatchCreateOccurrences</c> and <c>GrafeasClient.BatchCreateOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.BatchCreateOccurrences</c> and
        /// <c>GrafeasClient.BatchCreateOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.UpdateOccurrence</c> and <c>GrafeasClient.UpdateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.UpdateOccurrence</c> and
        /// <c>GrafeasClient.UpdateOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.GetOccurrenceNote</c> and <c>GrafeasClient.GetOccurrenceNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.GetOccurrenceNote</c> and
        /// <c>GrafeasClient.GetOccurrenceNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.GetNote</c> and <c>GrafeasClient.GetNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.GetNote</c> and
        /// <c>GrafeasClient.GetNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.ListNotes</c> and <c>GrafeasClient.ListNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.ListNotes</c> and
        /// <c>GrafeasClient.ListNotesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.DeleteNote</c> and <c>GrafeasClient.DeleteNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.DeleteNote</c> and
        /// <c>GrafeasClient.DeleteNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.CreateNote</c> and <c>GrafeasClient.CreateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.CreateNote</c> and
        /// <c>GrafeasClient.CreateNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.BatchCreateNotes</c> and <c>GrafeasClient.BatchCreateNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.BatchCreateNotes</c> and
        /// <c>GrafeasClient.BatchCreateNotesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.UpdateNote</c> and <c>GrafeasClient.UpdateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.UpdateNote</c> and
        /// <c>GrafeasClient.UpdateNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>GrafeasClient.ListNoteOccurrences</c> and <c>GrafeasClient.ListNoteOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasClient.ListNoteOccurrences</c> and
        /// <c>GrafeasClient.ListNoteOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <returns>A deep clone of this <see cref="GrafeasSettings"/> object.</returns>
        public GrafeasSettings Clone() => new GrafeasSettings(this);
    }

    /// <summary>
    /// Grafeas client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GrafeasClient
    {

        /// <summary>
        /// Creates a <see cref="GrafeasClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GrafeasSettings"/>.</param>
        /// <returns>The created <see cref="GrafeasClient"/>.</returns>
        public static GrafeasClient Create(grpccore::Channel channel, GrafeasSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="GrafeasClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GrafeasSettings"/>.</param>
        /// <returns>The created <see cref="GrafeasClient"/>.</returns>
        public static GrafeasClient Create(grpccore::CallInvoker callInvoker, GrafeasSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Grafeas.GrafeasClient grpcClient = new Grafeas.GrafeasClient(callInvoker);
            return new GrafeasClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying gRPC Grafeas client.
        /// </summary>
        public virtual Grafeas.GrafeasClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceAsync(
                new GetOccurrenceRequest
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
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(
            OccurrenceName name,
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
        public virtual Occurrence GetOccurrence(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrence(
                new GetOccurrenceRequest
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
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceAsync(
                new GetOccurrenceRequest
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
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(
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
        public virtual Occurrence GetOccurrence(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrence(
                new GetOccurrenceRequest
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
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(
            GetOccurrenceRequest request,
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
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(
            GetOccurrenceRequest request,
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
        public virtual Occurrence GetOccurrence(
            GetOccurrenceRequest request,
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrencesAsync(
                new ListOccurrencesRequest
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrences(
                new ListOccurrencesRequest
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrencesAsync(
                new ListOccurrencesRequest
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrences(
                new ListOccurrencesRequest
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(
            ListOccurrencesRequest request,
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(
            ListOccurrencesRequest request,
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
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrenceAsync(
                new DeleteOccurrenceRequest
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
            OccurrenceName name,
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
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrence(
                new DeleteOccurrenceRequest
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
                new DeleteOccurrenceRequest
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
                new DeleteOccurrenceRequest
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
            DeleteOccurrenceRequest request,
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
            DeleteOccurrenceRequest request,
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
            DeleteOccurrenceRequest request,
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
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(
            ProjectName parent,
            Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrenceAsync(
                new CreateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(
            ProjectName parent,
            Occurrence occurrence,
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
        public virtual Occurrence CreateOccurrence(
            ProjectName parent,
            Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrence(
                new CreateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(
            string parent,
            Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrenceAsync(
                new CreateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(
            string parent,
            Occurrence occurrence,
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
        public virtual Occurrence CreateOccurrence(
            string parent,
            Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrence(
                new CreateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(
            CreateOccurrenceRequest request,
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
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(
            CreateOccurrenceRequest request,
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
        public virtual Occurrence CreateOccurrence(
            CreateOccurrenceRequest request,
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
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            ProjectName parent,
            scg::IEnumerable<Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrencesAsync(
                new BatchCreateOccurrencesRequest
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
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            ProjectName parent,
            scg::IEnumerable<Occurrence> occurrences,
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
        public virtual BatchCreateOccurrencesResponse BatchCreateOccurrences(
            ProjectName parent,
            scg::IEnumerable<Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrences(
                new BatchCreateOccurrencesRequest
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
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            string parent,
            scg::IEnumerable<Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrencesAsync(
                new BatchCreateOccurrencesRequest
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
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            string parent,
            scg::IEnumerable<Occurrence> occurrences,
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
        public virtual BatchCreateOccurrencesResponse BatchCreateOccurrences(
            string parent,
            scg::IEnumerable<Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrences(
                new BatchCreateOccurrencesRequest
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
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            BatchCreateOccurrencesRequest request,
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
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            BatchCreateOccurrencesRequest request,
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
        public virtual BatchCreateOccurrencesResponse BatchCreateOccurrences(
            BatchCreateOccurrencesRequest request,
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
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(
            OccurrenceName name,
            Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrenceAsync(
                new UpdateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(
            OccurrenceName name,
            Occurrence occurrence,
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
        public virtual Occurrence UpdateOccurrence(
            OccurrenceName name,
            Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrence(
                new UpdateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(
            string name,
            Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrenceAsync(
                new UpdateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(
            string name,
            Occurrence occurrence,
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
        public virtual Occurrence UpdateOccurrence(
            string name,
            Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrence(
                new UpdateOccurrenceRequest
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
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(
            UpdateOccurrenceRequest request,
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
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(
            UpdateOccurrenceRequest request,
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
        public virtual Occurrence UpdateOccurrence(
            UpdateOccurrenceRequest request,
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
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNoteAsync(
                new GetOccurrenceNoteRequest
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
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(
            OccurrenceName name,
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
        public virtual Note GetOccurrenceNote(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNote(
                new GetOccurrenceNoteRequest
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
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNoteAsync(
                new GetOccurrenceNoteRequest
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
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(
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
        public virtual Note GetOccurrenceNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNote(
                new GetOccurrenceNoteRequest
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
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(
            GetOccurrenceNoteRequest request,
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
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(
            GetOccurrenceNoteRequest request,
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
        public virtual Note GetOccurrenceNote(
            GetOccurrenceNoteRequest request,
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
        public virtual stt::Task<Note> GetNoteAsync(
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => GetNoteAsync(
                new GetNoteRequest
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
        public virtual stt::Task<Note> GetNoteAsync(
            NoteName name,
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
        public virtual Note GetNote(
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => GetNote(
                new GetNoteRequest
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
        public virtual stt::Task<Note> GetNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNoteAsync(
                new GetNoteRequest
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
        public virtual stt::Task<Note> GetNoteAsync(
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
        public virtual Note GetNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNote(
                new GetNoteRequest
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
        public virtual stt::Task<Note> GetNoteAsync(
            GetNoteRequest request,
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
        public virtual stt::Task<Note> GetNoteAsync(
            GetNoteRequest request,
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
        public virtual Note GetNote(
            GetNoteRequest request,
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
        /// A pageable asynchronous sequence of <see cref="Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotesAsync(
                new ListNotesRequest
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
        /// A pageable sequence of <see cref="Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotes(
                new ListNotesRequest
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
        /// A pageable asynchronous sequence of <see cref="Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotesAsync(
                new ListNotesRequest
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
        /// A pageable sequence of <see cref="Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotes(
                new ListNotesRequest
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
        /// A pageable asynchronous sequence of <see cref="Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(
            ListNotesRequest request,
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
        /// A pageable sequence of <see cref="Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(
            ListNotesRequest request,
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
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNoteAsync(
                new DeleteNoteRequest
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
            NoteName name,
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
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNote(
                new DeleteNoteRequest
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
                new DeleteNoteRequest
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
                new DeleteNoteRequest
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
            DeleteNoteRequest request,
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
            DeleteNoteRequest request,
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
            DeleteNoteRequest request,
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
        public virtual stt::Task<Note> CreateNoteAsync(
            ProjectName parent,
            string noteId,
            Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNoteAsync(
                new CreateNoteRequest
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
        public virtual stt::Task<Note> CreateNoteAsync(
            ProjectName parent,
            string noteId,
            Note note,
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
        public virtual Note CreateNote(
            ProjectName parent,
            string noteId,
            Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNote(
                new CreateNoteRequest
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
        public virtual stt::Task<Note> CreateNoteAsync(
            string parent,
            string noteId,
            Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNoteAsync(
                new CreateNoteRequest
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
        public virtual stt::Task<Note> CreateNoteAsync(
            string parent,
            string noteId,
            Note note,
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
        public virtual Note CreateNote(
            string parent,
            string noteId,
            Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNote(
                new CreateNoteRequest
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
        public virtual stt::Task<Note> CreateNoteAsync(
            CreateNoteRequest request,
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
        public virtual stt::Task<Note> CreateNoteAsync(
            CreateNoteRequest request,
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
        public virtual Note CreateNote(
            CreateNoteRequest request,
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
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(
            ProjectName parent,
            scg::IDictionary<string, Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotesAsync(
                new BatchCreateNotesRequest
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
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(
            ProjectName parent,
            scg::IDictionary<string, Note> notes,
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
        public virtual BatchCreateNotesResponse BatchCreateNotes(
            ProjectName parent,
            scg::IDictionary<string, Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotes(
                new BatchCreateNotesRequest
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
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(
            string parent,
            scg::IDictionary<string, Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotesAsync(
                new BatchCreateNotesRequest
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
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(
            string parent,
            scg::IDictionary<string, Note> notes,
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
        public virtual BatchCreateNotesResponse BatchCreateNotes(
            string parent,
            scg::IDictionary<string, Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotes(
                new BatchCreateNotesRequest
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
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(
            BatchCreateNotesRequest request,
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
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(
            BatchCreateNotesRequest request,
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
        public virtual BatchCreateNotesResponse BatchCreateNotes(
            BatchCreateNotesRequest request,
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
        public virtual stt::Task<Note> UpdateNoteAsync(
            NoteName name,
            Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNoteAsync(
                new UpdateNoteRequest
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
        public virtual stt::Task<Note> UpdateNoteAsync(
            NoteName name,
            Note note,
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
        public virtual Note UpdateNote(
            NoteName name,
            Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNote(
                new UpdateNoteRequest
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
        public virtual stt::Task<Note> UpdateNoteAsync(
            string name,
            Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNoteAsync(
                new UpdateNoteRequest
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
        public virtual stt::Task<Note> UpdateNoteAsync(
            string name,
            Note note,
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
        public virtual Note UpdateNote(
            string name,
            Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNote(
                new UpdateNoteRequest
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
        public virtual stt::Task<Note> UpdateNoteAsync(
            UpdateNoteRequest request,
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
        public virtual stt::Task<Note> UpdateNoteAsync(
            UpdateNoteRequest request,
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
        public virtual Note UpdateNote(
            UpdateNoteRequest request,
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(
            NoteName name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrencesAsync(
                new ListNoteOccurrencesRequest
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(
            NoteName name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrences(
                new ListNoteOccurrencesRequest
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrencesAsync(
                new ListNoteOccurrencesRequest
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrences(
                new ListNoteOccurrencesRequest
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(
            ListNoteOccurrencesRequest request,
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(
            ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Grafeas client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GrafeasClientImpl : GrafeasClient
    {
        private readonly gaxgrpc::ApiCall<GetOccurrenceRequest, Occurrence> _callGetOccurrence;
        private readonly gaxgrpc::ApiCall<ListOccurrencesRequest, ListOccurrencesResponse> _callListOccurrences;
        private readonly gaxgrpc::ApiCall<DeleteOccurrenceRequest, pbwkt::Empty> _callDeleteOccurrence;
        private readonly gaxgrpc::ApiCall<CreateOccurrenceRequest, Occurrence> _callCreateOccurrence;
        private readonly gaxgrpc::ApiCall<BatchCreateOccurrencesRequest, BatchCreateOccurrencesResponse> _callBatchCreateOccurrences;
        private readonly gaxgrpc::ApiCall<UpdateOccurrenceRequest, Occurrence> _callUpdateOccurrence;
        private readonly gaxgrpc::ApiCall<GetOccurrenceNoteRequest, Note> _callGetOccurrenceNote;
        private readonly gaxgrpc::ApiCall<GetNoteRequest, Note> _callGetNote;
        private readonly gaxgrpc::ApiCall<ListNotesRequest, ListNotesResponse> _callListNotes;
        private readonly gaxgrpc::ApiCall<DeleteNoteRequest, pbwkt::Empty> _callDeleteNote;
        private readonly gaxgrpc::ApiCall<CreateNoteRequest, Note> _callCreateNote;
        private readonly gaxgrpc::ApiCall<BatchCreateNotesRequest, BatchCreateNotesResponse> _callBatchCreateNotes;
        private readonly gaxgrpc::ApiCall<UpdateNoteRequest, Note> _callUpdateNote;
        private readonly gaxgrpc::ApiCall<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse> _callListNoteOccurrences;

        /// <summary>
        /// Constructs a client wrapper for the Grafeas service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GrafeasSettings"/> used within this client </param>
        public GrafeasClientImpl(Grafeas.GrafeasClient grpcClient, GrafeasSettings settings)
        {
            GrpcClient = grpcClient;
            GrafeasSettings effectiveSettings = settings ?? GrafeasSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetOccurrence = clientHelper.BuildApiCall<GetOccurrenceRequest, Occurrence>(
                GrpcClient.GetOccurrenceAsync, GrpcClient.GetOccurrence, effectiveSettings.GetOccurrenceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListOccurrences = clientHelper.BuildApiCall<ListOccurrencesRequest, ListOccurrencesResponse>(
                GrpcClient.ListOccurrencesAsync, GrpcClient.ListOccurrences, effectiveSettings.ListOccurrencesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteOccurrence = clientHelper.BuildApiCall<DeleteOccurrenceRequest, pbwkt::Empty>(
                GrpcClient.DeleteOccurrenceAsync, GrpcClient.DeleteOccurrence, effectiveSettings.DeleteOccurrenceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateOccurrence = clientHelper.BuildApiCall<CreateOccurrenceRequest, Occurrence>(
                GrpcClient.CreateOccurrenceAsync, GrpcClient.CreateOccurrence, effectiveSettings.CreateOccurrenceSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchCreateOccurrences = clientHelper.BuildApiCall<BatchCreateOccurrencesRequest, BatchCreateOccurrencesResponse>(
                GrpcClient.BatchCreateOccurrencesAsync, GrpcClient.BatchCreateOccurrences, effectiveSettings.BatchCreateOccurrencesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateOccurrence = clientHelper.BuildApiCall<UpdateOccurrenceRequest, Occurrence>(
                GrpcClient.UpdateOccurrenceAsync, GrpcClient.UpdateOccurrence, effectiveSettings.UpdateOccurrenceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetOccurrenceNote = clientHelper.BuildApiCall<GetOccurrenceNoteRequest, Note>(
                GrpcClient.GetOccurrenceNoteAsync, GrpcClient.GetOccurrenceNote, effectiveSettings.GetOccurrenceNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetNote = clientHelper.BuildApiCall<GetNoteRequest, Note>(
                GrpcClient.GetNoteAsync, GrpcClient.GetNote, effectiveSettings.GetNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListNotes = clientHelper.BuildApiCall<ListNotesRequest, ListNotesResponse>(
                GrpcClient.ListNotesAsync, GrpcClient.ListNotes, effectiveSettings.ListNotesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteNote = clientHelper.BuildApiCall<DeleteNoteRequest, pbwkt::Empty>(
                GrpcClient.DeleteNoteAsync, GrpcClient.DeleteNote, effectiveSettings.DeleteNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateNote = clientHelper.BuildApiCall<CreateNoteRequest, Note>(
                GrpcClient.CreateNoteAsync, GrpcClient.CreateNote, effectiveSettings.CreateNoteSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchCreateNotes = clientHelper.BuildApiCall<BatchCreateNotesRequest, BatchCreateNotesResponse>(
                GrpcClient.BatchCreateNotesAsync, GrpcClient.BatchCreateNotes, effectiveSettings.BatchCreateNotesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateNote = clientHelper.BuildApiCall<UpdateNoteRequest, Note>(
                GrpcClient.UpdateNoteAsync, GrpcClient.UpdateNote, effectiveSettings.UpdateNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListNoteOccurrences = clientHelper.BuildApiCall<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>(
                GrpcClient.ListNoteOccurrencesAsync, GrpcClient.ListNoteOccurrences, effectiveSettings.ListNoteOccurrencesSettings)
                .WithGoogleRequestParam("name", request => request.Name);
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
        partial void Modify_GetOccurrenceApiCall(ref gaxgrpc::ApiCall<GetOccurrenceRequest, Occurrence> call);
        partial void Modify_ListOccurrencesApiCall(ref gaxgrpc::ApiCall<ListOccurrencesRequest, ListOccurrencesResponse> call);
        partial void Modify_DeleteOccurrenceApiCall(ref gaxgrpc::ApiCall<DeleteOccurrenceRequest, pbwkt::Empty> call);
        partial void Modify_CreateOccurrenceApiCall(ref gaxgrpc::ApiCall<CreateOccurrenceRequest, Occurrence> call);
        partial void Modify_BatchCreateOccurrencesApiCall(ref gaxgrpc::ApiCall<BatchCreateOccurrencesRequest, BatchCreateOccurrencesResponse> call);
        partial void Modify_UpdateOccurrenceApiCall(ref gaxgrpc::ApiCall<UpdateOccurrenceRequest, Occurrence> call);
        partial void Modify_GetOccurrenceNoteApiCall(ref gaxgrpc::ApiCall<GetOccurrenceNoteRequest, Note> call);
        partial void Modify_GetNoteApiCall(ref gaxgrpc::ApiCall<GetNoteRequest, Note> call);
        partial void Modify_ListNotesApiCall(ref gaxgrpc::ApiCall<ListNotesRequest, ListNotesResponse> call);
        partial void Modify_DeleteNoteApiCall(ref gaxgrpc::ApiCall<DeleteNoteRequest, pbwkt::Empty> call);
        partial void Modify_CreateNoteApiCall(ref gaxgrpc::ApiCall<CreateNoteRequest, Note> call);
        partial void Modify_BatchCreateNotesApiCall(ref gaxgrpc::ApiCall<BatchCreateNotesRequest, BatchCreateNotesResponse> call);
        partial void Modify_UpdateNoteApiCall(ref gaxgrpc::ApiCall<UpdateNoteRequest, Note> call);
        partial void Modify_ListNoteOccurrencesApiCall(ref gaxgrpc::ApiCall<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse> call);
        partial void OnConstruction(Grafeas.GrafeasClient grpcClient, GrafeasSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Grafeas client.
        /// </summary>
        public override Grafeas.GrafeasClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetOccurrenceRequest(ref GetOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListOccurrencesRequest(ref ListOccurrencesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteOccurrenceRequest(ref DeleteOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateOccurrenceRequest(ref CreateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateOccurrencesRequest(ref BatchCreateOccurrencesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateOccurrenceRequest(ref UpdateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetOccurrenceNoteRequest(ref GetOccurrenceNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetNoteRequest(ref GetNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListNotesRequest(ref ListNotesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteNoteRequest(ref DeleteNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateNoteRequest(ref CreateNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateNotesRequest(ref BatchCreateNotesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateNoteRequest(ref UpdateNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListNoteOccurrencesRequest(ref ListNoteOccurrencesRequest request, ref gaxgrpc::CallSettings settings);

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
        public override stt::Task<Occurrence> GetOccurrenceAsync(
            GetOccurrenceRequest request,
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
        public override Occurrence GetOccurrence(
            GetOccurrenceRequest request,
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(
            ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOccurrencesRequest, ListOccurrencesResponse, Occurrence>(_callListOccurrences, request, callSettings);
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(
            ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOccurrencesRequest, ListOccurrencesResponse, Occurrence>(_callListOccurrences, request, callSettings);
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
            DeleteOccurrenceRequest request,
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
            DeleteOccurrenceRequest request,
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
        public override stt::Task<Occurrence> CreateOccurrenceAsync(
            CreateOccurrenceRequest request,
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
        public override Occurrence CreateOccurrence(
            CreateOccurrenceRequest request,
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
        public override stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            BatchCreateOccurrencesRequest request,
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
        public override BatchCreateOccurrencesResponse BatchCreateOccurrences(
            BatchCreateOccurrencesRequest request,
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
        public override stt::Task<Occurrence> UpdateOccurrenceAsync(
            UpdateOccurrenceRequest request,
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
        public override Occurrence UpdateOccurrence(
            UpdateOccurrenceRequest request,
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
        public override stt::Task<Note> GetOccurrenceNoteAsync(
            GetOccurrenceNoteRequest request,
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
        public override Note GetOccurrenceNote(
            GetOccurrenceNoteRequest request,
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
        public override stt::Task<Note> GetNoteAsync(
            GetNoteRequest request,
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
        public override Note GetNote(
            GetNoteRequest request,
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
        /// A pageable asynchronous sequence of <see cref="Note"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(
            ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotesRequest, ListNotesResponse, Note>(_callListNotes, request, callSettings);
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
        /// A pageable sequence of <see cref="Note"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(
            ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotesRequest, ListNotesResponse, Note>(_callListNotes, request, callSettings);
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
            DeleteNoteRequest request,
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
            DeleteNoteRequest request,
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
        public override stt::Task<Note> CreateNoteAsync(
            CreateNoteRequest request,
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
        public override Note CreateNote(
            CreateNoteRequest request,
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
        public override stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(
            BatchCreateNotesRequest request,
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
        public override BatchCreateNotesResponse BatchCreateNotes(
            BatchCreateNotesRequest request,
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
        public override stt::Task<Note> UpdateNoteAsync(
            UpdateNoteRequest request,
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
        public override Note UpdateNote(
            UpdateNoteRequest request,
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
        /// A pageable asynchronous sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(
            ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse, Occurrence>(_callListNoteOccurrences, request, callSettings);
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
        /// A pageable sequence of <see cref="Occurrence"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(
            ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse, Occurrence>(_callListNoteOccurrences, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListOccurrencesRequest : gaxgrpc::IPageRequest { }
    public partial class ListOccurrencesResponse : gaxgrpc::IPageResponse<Occurrence>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Occurrence> GetEnumerator() => Occurrences.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotesRequest : gaxgrpc::IPageRequest { }
    public partial class ListNotesResponse : gaxgrpc::IPageResponse<Note>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Note> GetEnumerator() => Notes.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNoteOccurrencesRequest : gaxgrpc::IPageRequest { }
    public partial class ListNoteOccurrencesResponse : gaxgrpc::IPageResponse<Occurrence>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Occurrence> GetEnumerator() => Occurrences.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
