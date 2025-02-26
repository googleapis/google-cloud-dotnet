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

namespace Google.Cloud.BigQuery.Reservation.V1
{
    /// <summary>Settings for <see cref="ReservationServiceClient"/> instances.</summary>
    public sealed partial class ReservationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReservationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReservationServiceSettings"/>.</returns>
        public static ReservationServiceSettings GetDefault() => new ReservationServiceSettings();

        /// <summary>Constructs a new <see cref="ReservationServiceSettings"/> object with default settings.</summary>
        public ReservationServiceSettings()
        {
        }

        private ReservationServiceSettings(ReservationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateReservationSettings = existing.CreateReservationSettings;
            ListReservationsSettings = existing.ListReservationsSettings;
            GetReservationSettings = existing.GetReservationSettings;
            DeleteReservationSettings = existing.DeleteReservationSettings;
            UpdateReservationSettings = existing.UpdateReservationSettings;
            FailoverReservationSettings = existing.FailoverReservationSettings;
            CreateCapacityCommitmentSettings = existing.CreateCapacityCommitmentSettings;
            ListCapacityCommitmentsSettings = existing.ListCapacityCommitmentsSettings;
            GetCapacityCommitmentSettings = existing.GetCapacityCommitmentSettings;
            DeleteCapacityCommitmentSettings = existing.DeleteCapacityCommitmentSettings;
            UpdateCapacityCommitmentSettings = existing.UpdateCapacityCommitmentSettings;
            SplitCapacityCommitmentSettings = existing.SplitCapacityCommitmentSettings;
            MergeCapacityCommitmentsSettings = existing.MergeCapacityCommitmentsSettings;
            CreateAssignmentSettings = existing.CreateAssignmentSettings;
            ListAssignmentsSettings = existing.ListAssignmentsSettings;
            DeleteAssignmentSettings = existing.DeleteAssignmentSettings;
            SearchAssignmentsSettings = existing.SearchAssignmentsSettings;
            SearchAllAssignmentsSettings = existing.SearchAllAssignmentsSettings;
            MoveAssignmentSettings = existing.MoveAssignmentSettings;
            UpdateAssignmentSettings = existing.UpdateAssignmentSettings;
            GetBiReservationSettings = existing.GetBiReservationSettings;
            UpdateBiReservationSettings = existing.UpdateBiReservationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReservationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.CreateReservation</c> and <c>ReservationServiceClient.CreateReservationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReservationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.ListReservations</c> and <c>ReservationServiceClient.ListReservationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReservationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.GetReservation</c> and <c>ReservationServiceClient.GetReservationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.DeleteReservation</c> and <c>ReservationServiceClient.DeleteReservationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.UpdateReservation</c> and <c>ReservationServiceClient.UpdateReservationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReservationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.FailoverReservation</c> and <c>ReservationServiceClient.FailoverReservationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FailoverReservationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.CreateCapacityCommitment</c> and
        /// <c>ReservationServiceClient.CreateCapacityCommitmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCapacityCommitmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.ListCapacityCommitments</c> and
        /// <c>ReservationServiceClient.ListCapacityCommitmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCapacityCommitmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.GetCapacityCommitment</c> and
        /// <c>ReservationServiceClient.GetCapacityCommitmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCapacityCommitmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.DeleteCapacityCommitment</c> and
        /// <c>ReservationServiceClient.DeleteCapacityCommitmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCapacityCommitmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.UpdateCapacityCommitment</c> and
        /// <c>ReservationServiceClient.UpdateCapacityCommitmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCapacityCommitmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.SplitCapacityCommitment</c> and
        /// <c>ReservationServiceClient.SplitCapacityCommitmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SplitCapacityCommitmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.MergeCapacityCommitments</c> and
        /// <c>ReservationServiceClient.MergeCapacityCommitmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MergeCapacityCommitmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.CreateAssignment</c> and <c>ReservationServiceClient.CreateAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAssignmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.ListAssignments</c> and <c>ReservationServiceClient.ListAssignmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAssignmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.DeleteAssignment</c> and <c>ReservationServiceClient.DeleteAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAssignmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.SearchAssignments</c> and <c>ReservationServiceClient.SearchAssignmentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAssignmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.SearchAllAssignments</c> and
        /// <c>ReservationServiceClient.SearchAllAssignmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAllAssignmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.MoveAssignment</c> and <c>ReservationServiceClient.MoveAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveAssignmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.UpdateAssignment</c> and <c>ReservationServiceClient.UpdateAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAssignmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.GetBiReservation</c> and <c>ReservationServiceClient.GetBiReservationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBiReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.UpdateBiReservation</c> and <c>ReservationServiceClient.UpdateBiReservationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBiReservationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReservationServiceSettings"/> object.</returns>
        public ReservationServiceSettings Clone() => new ReservationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReservationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ReservationServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReservationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReservationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReservationServiceClientBuilder() : base(ReservationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReservationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReservationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReservationServiceClient Build()
        {
            ReservationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReservationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReservationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReservationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReservationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReservationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReservationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReservationServiceClient.ChannelPool;
    }

    /// <summary>ReservationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This API allows users to manage their BigQuery reservations.
    /// 
    /// A reservation provides computational resource guarantees, in the form of
    /// [slots](https://cloud.google.com/bigquery/docs/slots), to users. A slot is a
    /// unit of computational power in BigQuery, and serves as the basic unit of
    /// parallelism. In a scan of a multi-partitioned table, a single slot operates
    /// on a single partition of the table. A reservation resource exists as a child
    /// resource of the admin project and location, e.g.:
    /// `projects/myproject/locations/US/reservations/reservationName`.
    /// 
    /// A capacity commitment is a way to purchase compute capacity for BigQuery jobs
    /// (in the form of slots) with some committed period of usage. A capacity
    /// commitment resource exists as a child resource of the admin project and
    /// location, e.g.:
    /// `projects/myproject/locations/US/capacityCommitments/id`.
    /// </remarks>
    public abstract partial class ReservationServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReservationService service, which is a host of
        /// "bigqueryreservation.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigqueryreservation.googleapis.com:443";

        /// <summary>The default ReservationService scopes.</summary>
        /// <remarks>
        /// The default ReservationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReservationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReservationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReservationServiceClient"/>.</returns>
        public static stt::Task<ReservationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReservationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReservationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ReservationServiceClient"/>.</returns>
        public static ReservationServiceClient Create() => new ReservationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReservationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReservationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReservationServiceClient"/>.</returns>
        internal static ReservationServiceClient Create(grpccore::CallInvoker callInvoker, ReservationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReservationService.ReservationServiceClient grpcClient = new ReservationService.ReservationServiceClient(callInvoker);
            return new ReservationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReservationService client</summary>
        public virtual ReservationService.ReservationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation CreateReservation(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(CreateReservationRequest request, st::CancellationToken cancellationToken) =>
            CreateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Project, location. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="reservation">
        /// Definition of the new reservation to create.
        /// </param>
        /// <param name="reservationId">
        /// The reservation ID. It must only contain lower case alphanumeric
        /// characters or dashes. It must start with a letter and must not end
        /// with a dash. Its maximum length is 64 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation CreateReservation(string parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservation(new CreateReservationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReservationId = reservationId ?? "",
                Reservation = reservation,
            }, callSettings);

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Project, location. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="reservation">
        /// Definition of the new reservation to create.
        /// </param>
        /// <param name="reservationId">
        /// The reservation ID. It must only contain lower case alphanumeric
        /// characters or dashes. It must start with a letter and must not end
        /// with a dash. Its maximum length is 64 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(string parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservationAsync(new CreateReservationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReservationId = reservationId ?? "",
                Reservation = reservation,
            }, callSettings);

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Project, location. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="reservation">
        /// Definition of the new reservation to create.
        /// </param>
        /// <param name="reservationId">
        /// The reservation ID. It must only contain lower case alphanumeric
        /// characters or dashes. It must start with a letter and must not end
        /// with a dash. Its maximum length is 64 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(string parent, Reservation reservation, string reservationId, st::CancellationToken cancellationToken) =>
            CreateReservationAsync(parent, reservation, reservationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Project, location. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="reservation">
        /// Definition of the new reservation to create.
        /// </param>
        /// <param name="reservationId">
        /// The reservation ID. It must only contain lower case alphanumeric
        /// characters or dashes. It must start with a letter and must not end
        /// with a dash. Its maximum length is 64 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation CreateReservation(gagr::LocationName parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservation(new CreateReservationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReservationId = reservationId ?? "",
                Reservation = reservation,
            }, callSettings);

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Project, location. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="reservation">
        /// Definition of the new reservation to create.
        /// </param>
        /// <param name="reservationId">
        /// The reservation ID. It must only contain lower case alphanumeric
        /// characters or dashes. It must start with a letter and must not end
        /// with a dash. Its maximum length is 64 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(gagr::LocationName parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservationAsync(new CreateReservationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReservationId = reservationId ?? "",
                Reservation = reservation,
            }, callSettings);

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Project, location. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="reservation">
        /// Definition of the new reservation to create.
        /// </param>
        /// <param name="reservationId">
        /// The reservation ID. It must only contain lower case alphanumeric
        /// characters or dashes. It must start with a letter and must not end
        /// with a dash. Its maximum length is 64 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(gagr::LocationName parent, Reservation reservation, string reservationId, st::CancellationToken cancellationToken) =>
            CreateReservationAsync(parent, reservation, reservationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name containing project and location, e.g.:
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationsRequest request = new ListReservationsRequest
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
            return ListReservations(request, callSettings);
        }

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name containing project and location, e.g.:
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationsRequest request = new ListReservationsRequest
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
            return ListReservationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name containing project and location, e.g.:
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationsRequest request = new ListReservationsRequest
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
            return ListReservations(request, callSettings);
        }

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name containing project and location, e.g.:
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationsRequest request = new ListReservationsRequest
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
            return ListReservationsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation GetReservation(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(GetReservationRequest request, st::CancellationToken cancellationToken) =>
            GetReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation GetReservation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservation(new GetReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservationAsync(new GetReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(string name, st::CancellationToken cancellationToken) =>
            GetReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation GetReservation(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservation(new GetReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservationAsync(new GetReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(ReservationName name, st::CancellationToken cancellationToken) =>
            GetReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReservation(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(DeleteReservationRequest request, st::CancellationToken cancellationToken) =>
            DeleteReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReservation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservation(new DeleteReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservationAsync(new DeleteReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReservation(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservation(new DeleteReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservationAsync(new DeleteReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the reservation to retrieve. E.g.,
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(ReservationName name, st::CancellationToken cancellationToken) =>
            DeleteReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation UpdateReservation(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(UpdateReservationRequest request, st::CancellationToken cancellationToken) =>
            UpdateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="reservation">
        /// Content of the reservation to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation UpdateReservation(Reservation reservation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReservation(new UpdateReservationRequest
            {
                Reservation = reservation,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="reservation">
        /// Content of the reservation to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(Reservation reservation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReservationAsync(new UpdateReservationRequest
            {
                Reservation = reservation,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="reservation">
        /// Content of the reservation to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(Reservation reservation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReservationAsync(reservation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fail over a reservation to the secondary location. The operation should be
        /// done in the current secondary location, which will be promoted to the
        /// new primary location for the reservation.
        /// Attempting to failover a reservation in the current primary location will
        /// fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation FailoverReservation(FailoverReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fail over a reservation to the secondary location. The operation should be
        /// done in the current secondary location, which will be promoted to the
        /// new primary location for the reservation.
        /// Attempting to failover a reservation in the current primary location will
        /// fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> FailoverReservationAsync(FailoverReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fail over a reservation to the secondary location. The operation should be
        /// done in the current secondary location, which will be promoted to the
        /// new primary location for the reservation.
        /// Attempting to failover a reservation in the current primary location will
        /// fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> FailoverReservationAsync(FailoverReservationRequest request, st::CancellationToken cancellationToken) =>
            FailoverReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment CreateCapacityCommitment(CreateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> CreateCapacityCommitmentAsync(CreateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> CreateCapacityCommitmentAsync(CreateCapacityCommitmentRequest request, st::CancellationToken cancellationToken) =>
            CreateCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment CreateCapacityCommitment(string parent, CapacityCommitment capacityCommitment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCapacityCommitment(new CreateCapacityCommitmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CapacityCommitment = capacityCommitment,
            }, callSettings);

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> CreateCapacityCommitmentAsync(string parent, CapacityCommitment capacityCommitment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCapacityCommitmentAsync(new CreateCapacityCommitmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CapacityCommitment = capacityCommitment,
            }, callSettings);

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> CreateCapacityCommitmentAsync(string parent, CapacityCommitment capacityCommitment, st::CancellationToken cancellationToken) =>
            CreateCapacityCommitmentAsync(parent, capacityCommitment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment CreateCapacityCommitment(gagr::LocationName parent, CapacityCommitment capacityCommitment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCapacityCommitment(new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CapacityCommitment = capacityCommitment,
            }, callSettings);

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> CreateCapacityCommitmentAsync(gagr::LocationName parent, CapacityCommitment capacityCommitment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCapacityCommitmentAsync(new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CapacityCommitment = capacityCommitment,
            }, callSettings);

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
        /// </param>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> CreateCapacityCommitmentAsync(gagr::LocationName parent, CapacityCommitment capacityCommitment, st::CancellationToken cancellationToken) =>
            CreateCapacityCommitmentAsync(parent, capacityCommitment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitments(ListCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitmentsAsync(ListCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCapacityCommitmentsRequest request = new ListCapacityCommitmentsRequest
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
            return ListCapacityCommitments(request, callSettings);
        }

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCapacityCommitmentsRequest request = new ListCapacityCommitmentsRequest
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
            return ListCapacityCommitmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCapacityCommitmentsRequest request = new ListCapacityCommitmentsRequest
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
            return ListCapacityCommitments(request, callSettings);
        }

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent reservation. E.g.,
        /// `projects/myproject/locations/US`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitmentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCapacityCommitmentsRequest request = new ListCapacityCommitmentsRequest
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
            return ListCapacityCommitmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment GetCapacityCommitment(GetCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> GetCapacityCommitmentAsync(GetCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> GetCapacityCommitmentAsync(GetCapacityCommitmentRequest request, st::CancellationToken cancellationToken) =>
            GetCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to retrieve. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment GetCapacityCommitment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityCommitment(new GetCapacityCommitmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to retrieve. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> GetCapacityCommitmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityCommitmentAsync(new GetCapacityCommitmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to retrieve. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> GetCapacityCommitmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetCapacityCommitmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to retrieve. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment GetCapacityCommitment(CapacityCommitmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityCommitment(new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to retrieve. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> GetCapacityCommitmentAsync(CapacityCommitmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityCommitmentAsync(new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to retrieve. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> GetCapacityCommitmentAsync(CapacityCommitmentName name, st::CancellationToken cancellationToken) =>
            GetCapacityCommitmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCapacityCommitment(DeleteCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCapacityCommitmentAsync(DeleteCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCapacityCommitmentAsync(DeleteCapacityCommitmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to delete. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCapacityCommitment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCapacityCommitment(new DeleteCapacityCommitmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to delete. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCapacityCommitmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCapacityCommitmentAsync(new DeleteCapacityCommitmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to delete. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCapacityCommitmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCapacityCommitmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to delete. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCapacityCommitment(CapacityCommitmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCapacityCommitment(new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to delete. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCapacityCommitmentAsync(CapacityCommitmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCapacityCommitmentAsync(new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the capacity commitment to delete. E.g.,
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCapacityCommitmentAsync(CapacityCommitmentName name, st::CancellationToken cancellationToken) =>
            DeleteCapacityCommitmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment UpdateCapacityCommitment(UpdateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> UpdateCapacityCommitmentAsync(UpdateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> UpdateCapacityCommitmentAsync(UpdateCapacityCommitmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment UpdateCapacityCommitment(CapacityCommitment capacityCommitment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCapacityCommitment(new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = capacityCommitment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> UpdateCapacityCommitmentAsync(CapacityCommitment capacityCommitment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCapacityCommitmentAsync(new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = capacityCommitment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="capacityCommitment">
        /// Content of the capacity commitment to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> UpdateCapacityCommitmentAsync(CapacityCommitment capacityCommitment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCapacityCommitmentAsync(capacityCommitment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SplitCapacityCommitmentResponse SplitCapacityCommitment(SplitCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitCapacityCommitmentResponse> SplitCapacityCommitmentAsync(SplitCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitCapacityCommitmentResponse> SplitCapacityCommitmentAsync(SplitCapacityCommitmentRequest request, st::CancellationToken cancellationToken) =>
            SplitCapacityCommitmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name e.g.,:
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="slotCount">
        /// Number of slots in the capacity commitment after the split.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SplitCapacityCommitmentResponse SplitCapacityCommitment(string name, long slotCount, gaxgrpc::CallSettings callSettings = null) =>
            SplitCapacityCommitment(new SplitCapacityCommitmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SlotCount = slotCount,
            }, callSettings);

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name e.g.,:
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="slotCount">
        /// Number of slots in the capacity commitment after the split.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitCapacityCommitmentResponse> SplitCapacityCommitmentAsync(string name, long slotCount, gaxgrpc::CallSettings callSettings = null) =>
            SplitCapacityCommitmentAsync(new SplitCapacityCommitmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SlotCount = slotCount,
            }, callSettings);

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name e.g.,:
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="slotCount">
        /// Number of slots in the capacity commitment after the split.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitCapacityCommitmentResponse> SplitCapacityCommitmentAsync(string name, long slotCount, st::CancellationToken cancellationToken) =>
            SplitCapacityCommitmentAsync(name, slotCount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name e.g.,:
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="slotCount">
        /// Number of slots in the capacity commitment after the split.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SplitCapacityCommitmentResponse SplitCapacityCommitment(CapacityCommitmentName name, long slotCount, gaxgrpc::CallSettings callSettings = null) =>
            SplitCapacityCommitment(new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SlotCount = slotCount,
            }, callSettings);

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name e.g.,:
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="slotCount">
        /// Number of slots in the capacity commitment after the split.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitCapacityCommitmentResponse> SplitCapacityCommitmentAsync(CapacityCommitmentName name, long slotCount, gaxgrpc::CallSettings callSettings = null) =>
            SplitCapacityCommitmentAsync(new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SlotCount = slotCount,
            }, callSettings);

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name e.g.,:
        /// `projects/myproject/locations/US/capacityCommitments/123`
        /// </param>
        /// <param name="slotCount">
        /// Number of slots in the capacity commitment after the split.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitCapacityCommitmentResponse> SplitCapacityCommitmentAsync(CapacityCommitmentName name, long slotCount, st::CancellationToken cancellationToken) =>
            SplitCapacityCommitmentAsync(name, slotCount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment MergeCapacityCommitments(MergeCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> MergeCapacityCommitmentsAsync(MergeCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> MergeCapacityCommitmentsAsync(MergeCapacityCommitmentsRequest request, st::CancellationToken cancellationToken) =>
            MergeCapacityCommitmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="parent">
        /// Parent resource that identifies admin project and location e.g.,
        /// `projects/myproject/locations/us`
        /// </param>
        /// <param name="capacityCommitmentIds">
        /// Ids of capacity commitments to merge.
        /// These capacity commitments must exist under admin project and location
        /// specified in the parent.
        /// ID is the last portion of capacity commitment name e.g., 'abc' for
        /// projects/myproject/locations/US/capacityCommitments/abc
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment MergeCapacityCommitments(string parent, scg::IEnumerable<string> capacityCommitmentIds, gaxgrpc::CallSettings callSettings = null) =>
            MergeCapacityCommitments(new MergeCapacityCommitmentsRequest
            {
                Parent = parent ?? "",
                CapacityCommitmentIds =
                {
                    capacityCommitmentIds ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="parent">
        /// Parent resource that identifies admin project and location e.g.,
        /// `projects/myproject/locations/us`
        /// </param>
        /// <param name="capacityCommitmentIds">
        /// Ids of capacity commitments to merge.
        /// These capacity commitments must exist under admin project and location
        /// specified in the parent.
        /// ID is the last portion of capacity commitment name e.g., 'abc' for
        /// projects/myproject/locations/US/capacityCommitments/abc
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> MergeCapacityCommitmentsAsync(string parent, scg::IEnumerable<string> capacityCommitmentIds, gaxgrpc::CallSettings callSettings = null) =>
            MergeCapacityCommitmentsAsync(new MergeCapacityCommitmentsRequest
            {
                Parent = parent ?? "",
                CapacityCommitmentIds =
                {
                    capacityCommitmentIds ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="parent">
        /// Parent resource that identifies admin project and location e.g.,
        /// `projects/myproject/locations/us`
        /// </param>
        /// <param name="capacityCommitmentIds">
        /// Ids of capacity commitments to merge.
        /// These capacity commitments must exist under admin project and location
        /// specified in the parent.
        /// ID is the last portion of capacity commitment name e.g., 'abc' for
        /// projects/myproject/locations/US/capacityCommitments/abc
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> MergeCapacityCommitmentsAsync(string parent, scg::IEnumerable<string> capacityCommitmentIds, st::CancellationToken cancellationToken) =>
            MergeCapacityCommitmentsAsync(parent, capacityCommitmentIds, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="parent">
        /// Parent resource that identifies admin project and location e.g.,
        /// `projects/myproject/locations/us`
        /// </param>
        /// <param name="capacityCommitmentIds">
        /// Ids of capacity commitments to merge.
        /// These capacity commitments must exist under admin project and location
        /// specified in the parent.
        /// ID is the last portion of capacity commitment name e.g., 'abc' for
        /// projects/myproject/locations/US/capacityCommitments/abc
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityCommitment MergeCapacityCommitments(gagr::LocationName parent, scg::IEnumerable<string> capacityCommitmentIds, gaxgrpc::CallSettings callSettings = null) =>
            MergeCapacityCommitments(new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = parent,
                CapacityCommitmentIds =
                {
                    capacityCommitmentIds ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="parent">
        /// Parent resource that identifies admin project and location e.g.,
        /// `projects/myproject/locations/us`
        /// </param>
        /// <param name="capacityCommitmentIds">
        /// Ids of capacity commitments to merge.
        /// These capacity commitments must exist under admin project and location
        /// specified in the parent.
        /// ID is the last portion of capacity commitment name e.g., 'abc' for
        /// projects/myproject/locations/US/capacityCommitments/abc
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> MergeCapacityCommitmentsAsync(gagr::LocationName parent, scg::IEnumerable<string> capacityCommitmentIds, gaxgrpc::CallSettings callSettings = null) =>
            MergeCapacityCommitmentsAsync(new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = parent,
                CapacityCommitmentIds =
                {
                    capacityCommitmentIds ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="parent">
        /// Parent resource that identifies admin project and location e.g.,
        /// `projects/myproject/locations/us`
        /// </param>
        /// <param name="capacityCommitmentIds">
        /// Ids of capacity commitments to merge.
        /// These capacity commitments must exist under admin project and location
        /// specified in the parent.
        /// ID is the last portion of capacity commitment name e.g., 'abc' for
        /// projects/myproject/locations/US/capacityCommitments/abc
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityCommitment> MergeCapacityCommitmentsAsync(gagr::LocationName parent, scg::IEnumerable<string> capacityCommitmentIds, st::CancellationToken cancellationToken) =>
            MergeCapacityCommitmentsAsync(parent, capacityCommitmentIds, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment CreateAssignment(CreateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> CreateAssignmentAsync(CreateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> CreateAssignmentAsync(CreateAssignmentRequest request, st::CancellationToken cancellationToken) =>
            CreateAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name of the assignment
        /// E.g. `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="assignment">
        /// Assignment resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment CreateAssignment(string parent, Assignment assignment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssignment(new CreateAssignmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Assignment = assignment,
            }, callSettings);

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name of the assignment
        /// E.g. `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="assignment">
        /// Assignment resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> CreateAssignmentAsync(string parent, Assignment assignment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssignmentAsync(new CreateAssignmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Assignment = assignment,
            }, callSettings);

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name of the assignment
        /// E.g. `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="assignment">
        /// Assignment resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> CreateAssignmentAsync(string parent, Assignment assignment, st::CancellationToken cancellationToken) =>
            CreateAssignmentAsync(parent, assignment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name of the assignment
        /// E.g. `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="assignment">
        /// Assignment resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment CreateAssignment(ReservationName parent, Assignment assignment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssignment(new CreateAssignmentRequest
            {
                ParentAsReservationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Assignment = assignment,
            }, callSettings);

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name of the assignment
        /// E.g. `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="assignment">
        /// Assignment resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> CreateAssignmentAsync(ReservationName parent, Assignment assignment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssignmentAsync(new CreateAssignmentRequest
            {
                ParentAsReservationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Assignment = assignment,
            }, callSettings);

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name of the assignment
        /// E.g. `projects/myproject/locations/US/reservations/team1-prod`
        /// </param>
        /// <param name="assignment">
        /// Assignment resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> CreateAssignmentAsync(ReservationName parent, Assignment assignment, st::CancellationToken cancellationToken) =>
            CreateAssignmentAsync(parent, assignment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssignmentsResponse, Assignment> ListAssignments(ListAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssignmentsResponse, Assignment> ListAssignmentsAsync(ListAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name e.g.:
        /// 
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// 
        /// Or:
        /// 
        /// `projects/myproject/locations/US/reservations/-`
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
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssignmentsResponse, Assignment> ListAssignments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssignmentsRequest request = new ListAssignmentsRequest
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
            return ListAssignments(request, callSettings);
        }

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name e.g.:
        /// 
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// 
        /// Or:
        /// 
        /// `projects/myproject/locations/US/reservations/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssignmentsResponse, Assignment> ListAssignmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssignmentsRequest request = new ListAssignmentsRequest
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
            return ListAssignmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name e.g.:
        /// 
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// 
        /// Or:
        /// 
        /// `projects/myproject/locations/US/reservations/-`
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
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssignmentsResponse, Assignment> ListAssignments(ReservationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssignmentsRequest request = new ListAssignmentsRequest
            {
                ParentAsReservationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssignments(request, callSettings);
        }

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name e.g.:
        /// 
        /// `projects/myproject/locations/US/reservations/team1-prod`
        /// 
        /// Or:
        /// 
        /// `projects/myproject/locations/US/reservations/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssignmentsResponse, Assignment> ListAssignmentsAsync(ReservationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssignmentsRequest request = new ListAssignmentsRequest
            {
                ParentAsReservationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssignmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssignment(DeleteAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssignmentAsync(DeleteAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssignmentAsync(DeleteAssignmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssignment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssignment(new DeleteAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssignmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssignmentAsync(new DeleteAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssignmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAssignmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssignment(AssignmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssignment(new DeleteAssignmentRequest
            {
                AssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssignmentAsync(AssignmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssignmentAsync(new DeleteAssignmentRequest
            {
                AssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssignmentAsync(AssignmentName name, st::CancellationToken cancellationToken) =>
            DeleteAssignmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignments(SearchAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignmentsAsync(SearchAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the admin project(containing project and
        /// location), e.g.:
        /// `projects/myproject/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignments(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAssignmentsRequest request = new SearchAssignmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAssignments(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the admin project(containing project and
        /// location), e.g.:
        /// `projects/myproject/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignmentsAsync(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAssignmentsRequest request = new SearchAssignmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAssignmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the admin project(containing project and
        /// location), e.g.:
        /// `projects/myproject/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignments(gagr::LocationName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAssignmentsRequest request = new SearchAssignmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAssignments(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the admin project(containing project and
        /// location), e.g.:
        /// `projects/myproject/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignmentsAsync(gagr::LocationName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAssignmentsRequest request = new SearchAssignmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAssignmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignments(SearchAllAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignmentsAsync(SearchAllAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name with location (project name could be the
        /// wildcard '-'), e.g.:
        /// `projects/-/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignments(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAllAssignmentsRequest request = new SearchAllAssignmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAllAssignments(request, callSettings);
        }

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name with location (project name could be the
        /// wildcard '-'), e.g.:
        /// `projects/-/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignmentsAsync(string parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAllAssignmentsRequest request = new SearchAllAssignmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAllAssignmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name with location (project name could be the
        /// wildcard '-'), e.g.:
        /// `projects/-/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignments(gagr::LocationName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAllAssignmentsRequest request = new SearchAllAssignmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAllAssignments(request, callSettings);
        }

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name with location (project name could be the
        /// wildcard '-'), e.g.:
        /// `projects/-/locations/US`.
        /// </param>
        /// <param name="query">
        /// Please specify resource name as assignee in the query.
        /// 
        /// Examples:
        /// 
        /// * `assignee=projects/myproject`
        /// * `assignee=folders/123`
        /// * `assignee=organizations/456`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignmentsAsync(gagr::LocationName parent, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAllAssignmentsRequest request = new SearchAllAssignmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAllAssignmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment MoveAssignment(MoveAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> MoveAssignmentAsync(MoveAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> MoveAssignmentAsync(MoveAssignmentRequest request, st::CancellationToken cancellationToken) =>
            MoveAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the assignment,
        /// e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="destinationId">
        /// The new reservation ID, e.g.:
        /// `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment MoveAssignment(string name, string destinationId, gaxgrpc::CallSettings callSettings = null) =>
            MoveAssignment(new MoveAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationId = destinationId ?? "",
            }, callSettings);

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the assignment,
        /// e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="destinationId">
        /// The new reservation ID, e.g.:
        /// `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> MoveAssignmentAsync(string name, string destinationId, gaxgrpc::CallSettings callSettings = null) =>
            MoveAssignmentAsync(new MoveAssignmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationId = destinationId ?? "",
            }, callSettings);

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the assignment,
        /// e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="destinationId">
        /// The new reservation ID, e.g.:
        /// `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> MoveAssignmentAsync(string name, string destinationId, st::CancellationToken cancellationToken) =>
            MoveAssignmentAsync(name, destinationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the assignment,
        /// e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="destinationId">
        /// The new reservation ID, e.g.:
        /// `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment MoveAssignment(AssignmentName name, ReservationName destinationId, gaxgrpc::CallSettings callSettings = null) =>
            MoveAssignment(new MoveAssignmentRequest
            {
                AssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationIdAsReservationName = destinationId,
            }, callSettings);

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the assignment,
        /// e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="destinationId">
        /// The new reservation ID, e.g.:
        /// `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> MoveAssignmentAsync(AssignmentName name, ReservationName destinationId, gaxgrpc::CallSettings callSettings = null) =>
            MoveAssignmentAsync(new MoveAssignmentRequest
            {
                AssignmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationIdAsReservationName = destinationId,
            }, callSettings);

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the assignment,
        /// e.g.
        /// `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
        /// </param>
        /// <param name="destinationId">
        /// The new reservation ID, e.g.:
        /// `projects/myotherproject/locations/US/reservations/team2-prod`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> MoveAssignmentAsync(AssignmentName name, ReservationName destinationId, st::CancellationToken cancellationToken) =>
            MoveAssignmentAsync(name, destinationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment UpdateAssignment(UpdateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> UpdateAssignmentAsync(UpdateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> UpdateAssignmentAsync(UpdateAssignmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="assignment">
        /// Content of the assignment to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assignment UpdateAssignment(Assignment assignment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAssignment(new UpdateAssignmentRequest
            {
                Assignment = assignment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="assignment">
        /// Content of the assignment to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> UpdateAssignmentAsync(Assignment assignment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAssignmentAsync(new UpdateAssignmentRequest
            {
                Assignment = assignment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="assignment">
        /// Content of the assignment to update.
        /// </param>
        /// <param name="updateMask">
        /// Standard field mask for the set of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assignment> UpdateAssignmentAsync(Assignment assignment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAssignmentAsync(assignment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BiReservation GetBiReservation(GetBiReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> GetBiReservationAsync(GetBiReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> GetBiReservationAsync(GetBiReservationRequest request, st::CancellationToken cancellationToken) =>
            GetBiReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested reservation, for example:
        /// `projects/{project_id}/locations/{location_id}/biReservation`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BiReservation GetBiReservation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBiReservation(new GetBiReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested reservation, for example:
        /// `projects/{project_id}/locations/{location_id}/biReservation`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> GetBiReservationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBiReservationAsync(new GetBiReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested reservation, for example:
        /// `projects/{project_id}/locations/{location_id}/biReservation`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> GetBiReservationAsync(string name, st::CancellationToken cancellationToken) =>
            GetBiReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested reservation, for example:
        /// `projects/{project_id}/locations/{location_id}/biReservation`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BiReservation GetBiReservation(BiReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBiReservation(new GetBiReservationRequest
            {
                BiReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested reservation, for example:
        /// `projects/{project_id}/locations/{location_id}/biReservation`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> GetBiReservationAsync(BiReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBiReservationAsync(new GetBiReservationRequest
            {
                BiReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the requested reservation, for example:
        /// `projects/{project_id}/locations/{location_id}/biReservation`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> GetBiReservationAsync(BiReservationName name, st::CancellationToken cancellationToken) =>
            GetBiReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BiReservation UpdateBiReservation(UpdateBiReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> UpdateBiReservationAsync(UpdateBiReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> UpdateBiReservationAsync(UpdateBiReservationRequest request, st::CancellationToken cancellationToken) =>
            UpdateBiReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="biReservation">
        /// A reservation to update.
        /// </param>
        /// <param name="updateMask">
        /// A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BiReservation UpdateBiReservation(BiReservation biReservation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBiReservation(new UpdateBiReservationRequest
            {
                BiReservation = biReservation,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="biReservation">
        /// A reservation to update.
        /// </param>
        /// <param name="updateMask">
        /// A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> UpdateBiReservationAsync(BiReservation biReservation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBiReservationAsync(new UpdateBiReservationRequest
            {
                BiReservation = biReservation,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="biReservation">
        /// A reservation to update.
        /// </param>
        /// <param name="updateMask">
        /// A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BiReservation> UpdateBiReservationAsync(BiReservation biReservation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBiReservationAsync(biReservation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReservationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This API allows users to manage their BigQuery reservations.
    /// 
    /// A reservation provides computational resource guarantees, in the form of
    /// [slots](https://cloud.google.com/bigquery/docs/slots), to users. A slot is a
    /// unit of computational power in BigQuery, and serves as the basic unit of
    /// parallelism. In a scan of a multi-partitioned table, a single slot operates
    /// on a single partition of the table. A reservation resource exists as a child
    /// resource of the admin project and location, e.g.:
    /// `projects/myproject/locations/US/reservations/reservationName`.
    /// 
    /// A capacity commitment is a way to purchase compute capacity for BigQuery jobs
    /// (in the form of slots) with some committed period of usage. A capacity
    /// commitment resource exists as a child resource of the admin project and
    /// location, e.g.:
    /// `projects/myproject/locations/US/capacityCommitments/id`.
    /// </remarks>
    public sealed partial class ReservationServiceClientImpl : ReservationServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateReservationRequest, Reservation> _callCreateReservation;

        private readonly gaxgrpc::ApiCall<ListReservationsRequest, ListReservationsResponse> _callListReservations;

        private readonly gaxgrpc::ApiCall<GetReservationRequest, Reservation> _callGetReservation;

        private readonly gaxgrpc::ApiCall<DeleteReservationRequest, wkt::Empty> _callDeleteReservation;

        private readonly gaxgrpc::ApiCall<UpdateReservationRequest, Reservation> _callUpdateReservation;

        private readonly gaxgrpc::ApiCall<FailoverReservationRequest, Reservation> _callFailoverReservation;

        private readonly gaxgrpc::ApiCall<CreateCapacityCommitmentRequest, CapacityCommitment> _callCreateCapacityCommitment;

        private readonly gaxgrpc::ApiCall<ListCapacityCommitmentsRequest, ListCapacityCommitmentsResponse> _callListCapacityCommitments;

        private readonly gaxgrpc::ApiCall<GetCapacityCommitmentRequest, CapacityCommitment> _callGetCapacityCommitment;

        private readonly gaxgrpc::ApiCall<DeleteCapacityCommitmentRequest, wkt::Empty> _callDeleteCapacityCommitment;

        private readonly gaxgrpc::ApiCall<UpdateCapacityCommitmentRequest, CapacityCommitment> _callUpdateCapacityCommitment;

        private readonly gaxgrpc::ApiCall<SplitCapacityCommitmentRequest, SplitCapacityCommitmentResponse> _callSplitCapacityCommitment;

        private readonly gaxgrpc::ApiCall<MergeCapacityCommitmentsRequest, CapacityCommitment> _callMergeCapacityCommitments;

        private readonly gaxgrpc::ApiCall<CreateAssignmentRequest, Assignment> _callCreateAssignment;

        private readonly gaxgrpc::ApiCall<ListAssignmentsRequest, ListAssignmentsResponse> _callListAssignments;

        private readonly gaxgrpc::ApiCall<DeleteAssignmentRequest, wkt::Empty> _callDeleteAssignment;

        private readonly gaxgrpc::ApiCall<SearchAssignmentsRequest, SearchAssignmentsResponse> _callSearchAssignments;

        private readonly gaxgrpc::ApiCall<SearchAllAssignmentsRequest, SearchAllAssignmentsResponse> _callSearchAllAssignments;

        private readonly gaxgrpc::ApiCall<MoveAssignmentRequest, Assignment> _callMoveAssignment;

        private readonly gaxgrpc::ApiCall<UpdateAssignmentRequest, Assignment> _callUpdateAssignment;

        private readonly gaxgrpc::ApiCall<GetBiReservationRequest, BiReservation> _callGetBiReservation;

        private readonly gaxgrpc::ApiCall<UpdateBiReservationRequest, BiReservation> _callUpdateBiReservation;

        /// <summary>
        /// Constructs a client wrapper for the ReservationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReservationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReservationServiceClientImpl(ReservationService.ReservationServiceClient grpcClient, ReservationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReservationServiceSettings effectiveSettings = settings ?? ReservationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateReservation = clientHelper.BuildApiCall<CreateReservationRequest, Reservation>("CreateReservation", grpcClient.CreateReservationAsync, grpcClient.CreateReservation, effectiveSettings.CreateReservationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReservation);
            Modify_CreateReservationApiCall(ref _callCreateReservation);
            _callListReservations = clientHelper.BuildApiCall<ListReservationsRequest, ListReservationsResponse>("ListReservations", grpcClient.ListReservationsAsync, grpcClient.ListReservations, effectiveSettings.ListReservationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReservations);
            Modify_ListReservationsApiCall(ref _callListReservations);
            _callGetReservation = clientHelper.BuildApiCall<GetReservationRequest, Reservation>("GetReservation", grpcClient.GetReservationAsync, grpcClient.GetReservation, effectiveSettings.GetReservationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReservation);
            Modify_GetReservationApiCall(ref _callGetReservation);
            _callDeleteReservation = clientHelper.BuildApiCall<DeleteReservationRequest, wkt::Empty>("DeleteReservation", grpcClient.DeleteReservationAsync, grpcClient.DeleteReservation, effectiveSettings.DeleteReservationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReservation);
            Modify_DeleteReservationApiCall(ref _callDeleteReservation);
            _callUpdateReservation = clientHelper.BuildApiCall<UpdateReservationRequest, Reservation>("UpdateReservation", grpcClient.UpdateReservationAsync, grpcClient.UpdateReservation, effectiveSettings.UpdateReservationSettings).WithGoogleRequestParam("reservation.name", request => request.Reservation?.Name);
            Modify_ApiCall(ref _callUpdateReservation);
            Modify_UpdateReservationApiCall(ref _callUpdateReservation);
            _callFailoverReservation = clientHelper.BuildApiCall<FailoverReservationRequest, Reservation>("FailoverReservation", grpcClient.FailoverReservationAsync, grpcClient.FailoverReservation, effectiveSettings.FailoverReservationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFailoverReservation);
            Modify_FailoverReservationApiCall(ref _callFailoverReservation);
            _callCreateCapacityCommitment = clientHelper.BuildApiCall<CreateCapacityCommitmentRequest, CapacityCommitment>("CreateCapacityCommitment", grpcClient.CreateCapacityCommitmentAsync, grpcClient.CreateCapacityCommitment, effectiveSettings.CreateCapacityCommitmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCapacityCommitment);
            Modify_CreateCapacityCommitmentApiCall(ref _callCreateCapacityCommitment);
            _callListCapacityCommitments = clientHelper.BuildApiCall<ListCapacityCommitmentsRequest, ListCapacityCommitmentsResponse>("ListCapacityCommitments", grpcClient.ListCapacityCommitmentsAsync, grpcClient.ListCapacityCommitments, effectiveSettings.ListCapacityCommitmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCapacityCommitments);
            Modify_ListCapacityCommitmentsApiCall(ref _callListCapacityCommitments);
            _callGetCapacityCommitment = clientHelper.BuildApiCall<GetCapacityCommitmentRequest, CapacityCommitment>("GetCapacityCommitment", grpcClient.GetCapacityCommitmentAsync, grpcClient.GetCapacityCommitment, effectiveSettings.GetCapacityCommitmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCapacityCommitment);
            Modify_GetCapacityCommitmentApiCall(ref _callGetCapacityCommitment);
            _callDeleteCapacityCommitment = clientHelper.BuildApiCall<DeleteCapacityCommitmentRequest, wkt::Empty>("DeleteCapacityCommitment", grpcClient.DeleteCapacityCommitmentAsync, grpcClient.DeleteCapacityCommitment, effectiveSettings.DeleteCapacityCommitmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCapacityCommitment);
            Modify_DeleteCapacityCommitmentApiCall(ref _callDeleteCapacityCommitment);
            _callUpdateCapacityCommitment = clientHelper.BuildApiCall<UpdateCapacityCommitmentRequest, CapacityCommitment>("UpdateCapacityCommitment", grpcClient.UpdateCapacityCommitmentAsync, grpcClient.UpdateCapacityCommitment, effectiveSettings.UpdateCapacityCommitmentSettings).WithGoogleRequestParam("capacity_commitment.name", request => request.CapacityCommitment?.Name);
            Modify_ApiCall(ref _callUpdateCapacityCommitment);
            Modify_UpdateCapacityCommitmentApiCall(ref _callUpdateCapacityCommitment);
            _callSplitCapacityCommitment = clientHelper.BuildApiCall<SplitCapacityCommitmentRequest, SplitCapacityCommitmentResponse>("SplitCapacityCommitment", grpcClient.SplitCapacityCommitmentAsync, grpcClient.SplitCapacityCommitment, effectiveSettings.SplitCapacityCommitmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSplitCapacityCommitment);
            Modify_SplitCapacityCommitmentApiCall(ref _callSplitCapacityCommitment);
            _callMergeCapacityCommitments = clientHelper.BuildApiCall<MergeCapacityCommitmentsRequest, CapacityCommitment>("MergeCapacityCommitments", grpcClient.MergeCapacityCommitmentsAsync, grpcClient.MergeCapacityCommitments, effectiveSettings.MergeCapacityCommitmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callMergeCapacityCommitments);
            Modify_MergeCapacityCommitmentsApiCall(ref _callMergeCapacityCommitments);
            _callCreateAssignment = clientHelper.BuildApiCall<CreateAssignmentRequest, Assignment>("CreateAssignment", grpcClient.CreateAssignmentAsync, grpcClient.CreateAssignment, effectiveSettings.CreateAssignmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAssignment);
            Modify_CreateAssignmentApiCall(ref _callCreateAssignment);
            _callListAssignments = clientHelper.BuildApiCall<ListAssignmentsRequest, ListAssignmentsResponse>("ListAssignments", grpcClient.ListAssignmentsAsync, grpcClient.ListAssignments, effectiveSettings.ListAssignmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAssignments);
            Modify_ListAssignmentsApiCall(ref _callListAssignments);
            _callDeleteAssignment = clientHelper.BuildApiCall<DeleteAssignmentRequest, wkt::Empty>("DeleteAssignment", grpcClient.DeleteAssignmentAsync, grpcClient.DeleteAssignment, effectiveSettings.DeleteAssignmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAssignment);
            Modify_DeleteAssignmentApiCall(ref _callDeleteAssignment);
#pragma warning disable CS0612
            _callSearchAssignments = clientHelper.BuildApiCall<SearchAssignmentsRequest, SearchAssignmentsResponse>("SearchAssignments", grpcClient.SearchAssignmentsAsync, grpcClient.SearchAssignments, effectiveSettings.SearchAssignmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callSearchAssignments);
            Modify_SearchAssignmentsApiCall(ref _callSearchAssignments);
            _callSearchAllAssignments = clientHelper.BuildApiCall<SearchAllAssignmentsRequest, SearchAllAssignmentsResponse>("SearchAllAssignments", grpcClient.SearchAllAssignmentsAsync, grpcClient.SearchAllAssignments, effectiveSettings.SearchAllAssignmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchAllAssignments);
            Modify_SearchAllAssignmentsApiCall(ref _callSearchAllAssignments);
            _callMoveAssignment = clientHelper.BuildApiCall<MoveAssignmentRequest, Assignment>("MoveAssignment", grpcClient.MoveAssignmentAsync, grpcClient.MoveAssignment, effectiveSettings.MoveAssignmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMoveAssignment);
            Modify_MoveAssignmentApiCall(ref _callMoveAssignment);
            _callUpdateAssignment = clientHelper.BuildApiCall<UpdateAssignmentRequest, Assignment>("UpdateAssignment", grpcClient.UpdateAssignmentAsync, grpcClient.UpdateAssignment, effectiveSettings.UpdateAssignmentSettings).WithGoogleRequestParam("assignment.name", request => request.Assignment?.Name);
            Modify_ApiCall(ref _callUpdateAssignment);
            Modify_UpdateAssignmentApiCall(ref _callUpdateAssignment);
            _callGetBiReservation = clientHelper.BuildApiCall<GetBiReservationRequest, BiReservation>("GetBiReservation", grpcClient.GetBiReservationAsync, grpcClient.GetBiReservation, effectiveSettings.GetBiReservationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBiReservation);
            Modify_GetBiReservationApiCall(ref _callGetBiReservation);
            _callUpdateBiReservation = clientHelper.BuildApiCall<UpdateBiReservationRequest, BiReservation>("UpdateBiReservation", grpcClient.UpdateBiReservationAsync, grpcClient.UpdateBiReservation, effectiveSettings.UpdateBiReservationSettings).WithGoogleRequestParam("bi_reservation.name", request => request.BiReservation?.Name);
            Modify_ApiCall(ref _callUpdateBiReservation);
            Modify_UpdateBiReservationApiCall(ref _callUpdateBiReservation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateReservationApiCall(ref gaxgrpc::ApiCall<CreateReservationRequest, Reservation> call);

        partial void Modify_ListReservationsApiCall(ref gaxgrpc::ApiCall<ListReservationsRequest, ListReservationsResponse> call);

        partial void Modify_GetReservationApiCall(ref gaxgrpc::ApiCall<GetReservationRequest, Reservation> call);

        partial void Modify_DeleteReservationApiCall(ref gaxgrpc::ApiCall<DeleteReservationRequest, wkt::Empty> call);

        partial void Modify_UpdateReservationApiCall(ref gaxgrpc::ApiCall<UpdateReservationRequest, Reservation> call);

        partial void Modify_FailoverReservationApiCall(ref gaxgrpc::ApiCall<FailoverReservationRequest, Reservation> call);

        partial void Modify_CreateCapacityCommitmentApiCall(ref gaxgrpc::ApiCall<CreateCapacityCommitmentRequest, CapacityCommitment> call);

        partial void Modify_ListCapacityCommitmentsApiCall(ref gaxgrpc::ApiCall<ListCapacityCommitmentsRequest, ListCapacityCommitmentsResponse> call);

        partial void Modify_GetCapacityCommitmentApiCall(ref gaxgrpc::ApiCall<GetCapacityCommitmentRequest, CapacityCommitment> call);

        partial void Modify_DeleteCapacityCommitmentApiCall(ref gaxgrpc::ApiCall<DeleteCapacityCommitmentRequest, wkt::Empty> call);

        partial void Modify_UpdateCapacityCommitmentApiCall(ref gaxgrpc::ApiCall<UpdateCapacityCommitmentRequest, CapacityCommitment> call);

        partial void Modify_SplitCapacityCommitmentApiCall(ref gaxgrpc::ApiCall<SplitCapacityCommitmentRequest, SplitCapacityCommitmentResponse> call);

        partial void Modify_MergeCapacityCommitmentsApiCall(ref gaxgrpc::ApiCall<MergeCapacityCommitmentsRequest, CapacityCommitment> call);

        partial void Modify_CreateAssignmentApiCall(ref gaxgrpc::ApiCall<CreateAssignmentRequest, Assignment> call);

        partial void Modify_ListAssignmentsApiCall(ref gaxgrpc::ApiCall<ListAssignmentsRequest, ListAssignmentsResponse> call);

        partial void Modify_DeleteAssignmentApiCall(ref gaxgrpc::ApiCall<DeleteAssignmentRequest, wkt::Empty> call);

        partial void Modify_SearchAssignmentsApiCall(ref gaxgrpc::ApiCall<SearchAssignmentsRequest, SearchAssignmentsResponse> call);

        partial void Modify_SearchAllAssignmentsApiCall(ref gaxgrpc::ApiCall<SearchAllAssignmentsRequest, SearchAllAssignmentsResponse> call);

        partial void Modify_MoveAssignmentApiCall(ref gaxgrpc::ApiCall<MoveAssignmentRequest, Assignment> call);

        partial void Modify_UpdateAssignmentApiCall(ref gaxgrpc::ApiCall<UpdateAssignmentRequest, Assignment> call);

        partial void Modify_GetBiReservationApiCall(ref gaxgrpc::ApiCall<GetBiReservationRequest, BiReservation> call);

        partial void Modify_UpdateBiReservationApiCall(ref gaxgrpc::ApiCall<UpdateBiReservationRequest, BiReservation> call);

        partial void OnConstruction(ReservationService.ReservationServiceClient grpcClient, ReservationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReservationService client</summary>
        public override ReservationService.ReservationServiceClient GrpcClient { get; }

        partial void Modify_CreateReservationRequest(ref CreateReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReservationsRequest(ref ListReservationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReservationRequest(ref GetReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReservationRequest(ref DeleteReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReservationRequest(ref UpdateReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FailoverReservationRequest(ref FailoverReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCapacityCommitmentRequest(ref CreateCapacityCommitmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCapacityCommitmentsRequest(ref ListCapacityCommitmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCapacityCommitmentRequest(ref GetCapacityCommitmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCapacityCommitmentRequest(ref DeleteCapacityCommitmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCapacityCommitmentRequest(ref UpdateCapacityCommitmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SplitCapacityCommitmentRequest(ref SplitCapacityCommitmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MergeCapacityCommitmentsRequest(ref MergeCapacityCommitmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAssignmentRequest(ref CreateAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAssignmentsRequest(ref ListAssignmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAssignmentRequest(ref DeleteAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAssignmentsRequest(ref SearchAssignmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAllAssignmentsRequest(ref SearchAllAssignmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveAssignmentRequest(ref MoveAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAssignmentRequest(ref UpdateAssignmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBiReservationRequest(ref GetBiReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBiReservationRequest(ref UpdateBiReservationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reservation CreateReservation(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReservationRequest(ref request, ref callSettings);
            return _callCreateReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reservation> CreateReservationAsync(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReservationRequest(ref request, ref callSettings);
            return _callCreateReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public override gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReservationsRequest, ListReservationsResponse, Reservation>(_callListReservations, request, callSettings);
        }

        /// <summary>
        /// Lists all the reservations for the project in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReservationsRequest, ListReservationsResponse, Reservation>(_callListReservations, request, callSettings);
        }

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reservation GetReservation(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationRequest(ref request, ref callSettings);
            return _callGetReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reservation> GetReservationAsync(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationRequest(ref request, ref callSettings);
            return _callGetReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReservation(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReservationRequest(ref request, ref callSettings);
            _callDeleteReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a reservation.
        /// Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
        /// assignments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReservationAsync(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReservationRequest(ref request, ref callSettings);
            return _callDeleteReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reservation UpdateReservation(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReservationRequest(ref request, ref callSettings);
            return _callUpdateReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing reservation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reservation> UpdateReservationAsync(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReservationRequest(ref request, ref callSettings);
            return _callUpdateReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Fail over a reservation to the secondary location. The operation should be
        /// done in the current secondary location, which will be promoted to the
        /// new primary location for the reservation.
        /// Attempting to failover a reservation in the current primary location will
        /// fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reservation FailoverReservation(FailoverReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverReservationRequest(ref request, ref callSettings);
            return _callFailoverReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Fail over a reservation to the secondary location. The operation should be
        /// done in the current secondary location, which will be promoted to the
        /// new primary location for the reservation.
        /// Attempting to failover a reservation in the current primary location will
        /// fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reservation> FailoverReservationAsync(FailoverReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverReservationRequest(ref request, ref callSettings);
            return _callFailoverReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CapacityCommitment CreateCapacityCommitment(CreateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCapacityCommitmentRequest(ref request, ref callSettings);
            return _callCreateCapacityCommitment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new capacity commitment resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CapacityCommitment> CreateCapacityCommitmentAsync(CreateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCapacityCommitmentRequest(ref request, ref callSettings);
            return _callCreateCapacityCommitment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public override gax::PagedEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitments(ListCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCapacityCommitmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCapacityCommitmentsRequest, ListCapacityCommitmentsResponse, CapacityCommitment>(_callListCapacityCommitments, request, callSettings);
        }

        /// <summary>
        /// Lists all the capacity commitments for the admin project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityCommitment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> ListCapacityCommitmentsAsync(ListCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCapacityCommitmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCapacityCommitmentsRequest, ListCapacityCommitmentsResponse, CapacityCommitment>(_callListCapacityCommitments, request, callSettings);
        }

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CapacityCommitment GetCapacityCommitment(GetCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCapacityCommitmentRequest(ref request, ref callSettings);
            return _callGetCapacityCommitment.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the capacity commitment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CapacityCommitment> GetCapacityCommitmentAsync(GetCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCapacityCommitmentRequest(ref request, ref callSettings);
            return _callGetCapacityCommitment.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCapacityCommitment(DeleteCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCapacityCommitmentRequest(ref request, ref callSettings);
            _callDeleteCapacityCommitment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a capacity commitment. Attempting to delete capacity commitment
        /// before its commitment_end_time will fail with the error code
        /// `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCapacityCommitmentAsync(DeleteCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCapacityCommitmentRequest(ref request, ref callSettings);
            return _callDeleteCapacityCommitment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CapacityCommitment UpdateCapacityCommitment(UpdateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCapacityCommitmentRequest(ref request, ref callSettings);
            return _callUpdateCapacityCommitment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing capacity commitment.
        /// 
        /// Only `plan` and `renewal_plan` fields can be updated.
        /// 
        /// Plan can only be changed to a plan of a longer commitment period.
        /// Attempting to change to a plan with shorter commitment period will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CapacityCommitment> UpdateCapacityCommitmentAsync(UpdateCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCapacityCommitmentRequest(ref request, ref callSettings);
            return _callUpdateCapacityCommitment.Async(request, callSettings);
        }

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SplitCapacityCommitmentResponse SplitCapacityCommitment(SplitCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SplitCapacityCommitmentRequest(ref request, ref callSettings);
            return _callSplitCapacityCommitment.Sync(request, callSettings);
        }

        /// <summary>
        /// Splits capacity commitment to two commitments of the same plan and
        /// `commitment_end_time`.
        /// 
        /// A common use case is to enable downgrading commitments.
        /// 
        /// For example, in order to downgrade from 10000 slots to 8000, you might
        /// split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
        /// you delete the first one after the commitment end time passes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SplitCapacityCommitmentResponse> SplitCapacityCommitmentAsync(SplitCapacityCommitmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SplitCapacityCommitmentRequest(ref request, ref callSettings);
            return _callSplitCapacityCommitment.Async(request, callSettings);
        }

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CapacityCommitment MergeCapacityCommitments(MergeCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergeCapacityCommitmentsRequest(ref request, ref callSettings);
            return _callMergeCapacityCommitments.Sync(request, callSettings);
        }

        /// <summary>
        /// Merges capacity commitments of the same plan into a single commitment.
        /// 
        /// The resulting capacity commitment has the greater commitment_end_time
        /// out of the to-be-merged capacity commitments.
        /// 
        /// Attempting to merge capacity commitments of different plan will fail
        /// with the error code `google.rpc.Code.FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CapacityCommitment> MergeCapacityCommitmentsAsync(MergeCapacityCommitmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergeCapacityCommitmentsRequest(ref request, ref callSettings);
            return _callMergeCapacityCommitments.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assignment CreateAssignment(CreateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssignmentRequest(ref request, ref callSettings);
            return _callCreateAssignment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an assignment object which allows the given project to submit jobs
        /// of a certain type using slots from the specified reservation.
        /// 
        /// Currently a
        /// resource (project, folder, organization) can only have one assignment per
        /// each (job_type, location) combination, and that reservation will be used
        /// for all jobs of the matching type.
        /// 
        /// Different assignments can be created on different levels of the
        /// projects, folders or organization hierarchy.  During query execution,
        /// the assignment is looked up at the project, folder and organization levels
        /// in that order. The first assignment found is applied to the query.
        /// 
        /// When creating assignments, it does not matter if other assignments exist at
        /// higher levels.
        /// 
        /// Example:
        /// 
        /// * The organization `organizationA` contains two projects, `project1`
        /// and `project2`.
        /// * Assignments for all three entities (`organizationA`, `project1`, and
        /// `project2`) could all be created and mapped to the same or different
        /// reservations.
        /// 
        /// "None" assignments represent an absence of the assignment. Projects
        /// assigned to None use on-demand pricing. To create a "None" assignment, use
        /// "none" as a reservation_id in the parent. Example parent:
        /// `projects/myproject/locations/US/reservations/none`.
        /// 
        /// Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
        /// 'bigquery.admin' permissions on the project using the reservation
        /// and the project that owns this reservation.
        /// 
        /// Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
        /// does not match location of the reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assignment> CreateAssignmentAsync(CreateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssignmentRequest(ref request, ref callSettings);
            return _callCreateAssignment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public override gax::PagedEnumerable<ListAssignmentsResponse, Assignment> ListAssignments(ListAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAssignmentsRequest, ListAssignmentsResponse, Assignment>(_callListAssignments, request, callSettings);
        }

        /// <summary>
        /// Lists assignments.
        /// 
        /// Only explicitly created assignments will be returned.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, ListAssignments will just return the above two assignments
        /// for reservation `res1`, and no expansion/merge will happen.
        /// 
        /// The wildcard "-" can be used for
        /// reservations in the request. In that case all assignments belongs to the
        /// specified project and location will be listed.
        /// 
        /// **Note** "-" cannot be used for projects nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAssignmentsResponse, Assignment> ListAssignmentsAsync(ListAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssignmentsRequest, ListAssignmentsResponse, Assignment>(_callListAssignments, request, callSettings);
        }

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAssignment(DeleteAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssignmentRequest(ref request, ref callSettings);
            _callDeleteAssignment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a assignment. No expansion will happen.
        /// 
        /// Example:
        /// 
        /// * Organization `organizationA` contains two projects, `project1` and
        /// `project2`.
        /// * Reservation `res1` exists and was created previously.
        /// * CreateAssignment was used previously to define the following
        /// associations between entities and reservations: `&lt;organizationA, res1&gt;`
        /// and `&lt;project1, res1&gt;`
        /// 
        /// In this example, deletion of the `&lt;organizationA, res1&gt;` assignment won't
        /// affect the other assignment `&lt;project1, res1&gt;`. After said deletion,
        /// queries from `project1` will still use `res1` while queries from
        /// `project2` will switch to use on-demand mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAssignmentAsync(DeleteAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssignmentRequest(ref request, ref callSettings);
            return _callDeleteAssignment.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public override gax::PagedEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignments(SearchAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAssignmentsRequest, SearchAssignmentsResponse, Assignment>(_callSearchAssignments, request, callSettings);
        }

        /// <summary>
        /// Deprecated: Looks up assignments for a specified resource for a particular
        /// region. If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// 
        /// **Note** "-" cannot be used for projects
        /// nor locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public override gax::PagedAsyncEnumerable<SearchAssignmentsResponse, Assignment> SearchAssignmentsAsync(SearchAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAssignmentsRequest, SearchAssignmentsResponse, Assignment>(_callSearchAssignments, request, callSettings);
        }

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assignment"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignments(SearchAllAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAllAssignmentsRequest, SearchAllAssignmentsResponse, Assignment>(_callSearchAllAssignments, request, callSettings);
        }

        /// <summary>
        /// Looks up assignments for a specified resource for a particular region.
        /// If the request is about a project:
        /// 
        /// 1. Assignments created on the project will be returned if they exist.
        /// 2. Otherwise assignments created on the closest ancestor will be
        /// returned.
        /// 3. Assignments for different JobTypes will all be returned.
        /// 
        /// The same logic applies if the request is about a folder.
        /// 
        /// If the request is about an organization, then assignments created on the
        /// organization will be returned (organization doesn't have ancestors).
        /// 
        /// Comparing to ListAssignments, there are some behavior
        /// differences:
        /// 
        /// 1. permission on the assignee will be verified in this API.
        /// 2. Hierarchy lookup (project-&gt;folder-&gt;organization) happens in this API.
        /// 3. Parent here is `projects/*/locations/*`, instead of
        /// `projects/*/locations/*reservations/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assignment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAllAssignmentsResponse, Assignment> SearchAllAssignmentsAsync(SearchAllAssignmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAllAssignmentsRequest, SearchAllAssignmentsResponse, Assignment>(_callSearchAllAssignments, request, callSettings);
        }

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assignment MoveAssignment(MoveAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveAssignmentRequest(ref request, ref callSettings);
            return _callMoveAssignment.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves an assignment under a new reservation.
        /// 
        /// This differs from removing an existing assignment and recreating a new one
        /// by providing a transactional change that ensures an assignee always has an
        /// associated reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assignment> MoveAssignmentAsync(MoveAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveAssignmentRequest(ref request, ref callSettings);
            return _callMoveAssignment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assignment UpdateAssignment(UpdateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssignmentRequest(ref request, ref callSettings);
            return _callUpdateAssignment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing assignment.
        /// 
        /// Only the `priority` field can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assignment> UpdateAssignmentAsync(UpdateAssignmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssignmentRequest(ref request, ref callSettings);
            return _callUpdateAssignment.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BiReservation GetBiReservation(GetBiReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiReservationRequest(ref request, ref callSettings);
            return _callGetBiReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a BI reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BiReservation> GetBiReservationAsync(GetBiReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiReservationRequest(ref request, ref callSettings);
            return _callGetBiReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BiReservation UpdateBiReservation(UpdateBiReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBiReservationRequest(ref request, ref callSettings);
            return _callUpdateBiReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a BI reservation.
        /// 
        /// Only fields specified in the `field_mask` are updated.
        /// 
        /// A singleton BI reservation always exists with default size 0.
        /// In order to reserve BI capacity it needs to be updated to an amount
        /// greater than 0. In order to release BI capacity reservation size
        /// must be set to 0.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BiReservation> UpdateBiReservationAsync(UpdateBiReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBiReservationRequest(ref request, ref callSettings);
            return _callUpdateBiReservation.Async(request, callSettings);
        }
    }

    public partial class ListReservationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCapacityCommitmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAssignmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAssignmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAllAssignmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReservationsResponse : gaxgrpc::IPageResponse<Reservation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Reservation> GetEnumerator() => Reservations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCapacityCommitmentsResponse : gaxgrpc::IPageResponse<CapacityCommitment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CapacityCommitment> GetEnumerator() => CapacityCommitments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAssignmentsResponse : gaxgrpc::IPageResponse<Assignment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Assignment> GetEnumerator() => Assignments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchAssignmentsResponse : gaxgrpc::IPageResponse<Assignment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Assignment> GetEnumerator() => Assignments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchAllAssignmentsResponse : gaxgrpc::IPageResponse<Assignment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Assignment> GetEnumerator() => Assignments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
