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
using st = SearchSimilarIncidentsResponse.Types;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Irm.V1Alpha2
{
    /// <summary>
    /// Settings for a <see cref="IncidentServiceClient"/>.
    /// </summary>
    public sealed partial class IncidentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="IncidentServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="IncidentServiceSettings"/>.
        /// </returns>
        public static IncidentServiceSettings GetDefault() => new IncidentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="IncidentServiceSettings"/> object with default settings.
        /// </summary>
        public IncidentServiceSettings() { }

        private IncidentServiceSettings(IncidentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateIncidentSettings = existing.CreateIncidentSettings;
            GetIncidentSettings = existing.GetIncidentSettings;
            SearchIncidentsSettings = existing.SearchIncidentsSettings;
            UpdateIncidentSettings = existing.UpdateIncidentSettings;
            SearchSimilarIncidentsSettings = existing.SearchSimilarIncidentsSettings;
            CreateAnnotationSettings = existing.CreateAnnotationSettings;
            ListAnnotationsSettings = existing.ListAnnotationsSettings;
            UpdateAnnotationSettings = existing.UpdateAnnotationSettings;
            CreateTagSettings = existing.CreateTagSettings;
            DeleteTagSettings = existing.DeleteTagSettings;
            ListTagsSettings = existing.ListTagsSettings;
            CreateSignalSettings = existing.CreateSignalSettings;
            ListSignalsSettings = existing.ListSignalsSettings;
            GetSignalSettings = existing.GetSignalSettings;
            UpdateSignalSettings = existing.UpdateSignalSettings;
            AcknowledgeSignalSettings = existing.AcknowledgeSignalSettings;
            EscalateIncidentSettings = existing.EscalateIncidentSettings;
            CreateArtifactSettings = existing.CreateArtifactSettings;
            ListArtifactsSettings = existing.ListArtifactsSettings;
            UpdateArtifactSettings = existing.UpdateArtifactSettings;
            DeleteArtifactSettings = existing.DeleteArtifactSettings;
            GetShiftHandoffPresetsSettings = existing.GetShiftHandoffPresetsSettings;
            SendShiftHandoffSettings = existing.SendShiftHandoffSettings;
            CreateSubscriptionSettings = existing.CreateSubscriptionSettings;
            ListSubscriptionsSettings = existing.ListSubscriptionsSettings;
            DeleteSubscriptionSettings = existing.DeleteSubscriptionSettings;
            CreateIncidentRoleAssignmentSettings = existing.CreateIncidentRoleAssignmentSettings;
            DeleteIncidentRoleAssignmentSettings = existing.DeleteIncidentRoleAssignmentSettings;
            ListIncidentRoleAssignmentsSettings = existing.ListIncidentRoleAssignmentsSettings;
            RequestIncidentRoleHandoverSettings = existing.RequestIncidentRoleHandoverSettings;
            ConfirmIncidentRoleHandoverSettings = existing.ConfirmIncidentRoleHandoverSettings;
            ForceIncidentRoleHandoverSettings = existing.ForceIncidentRoleHandoverSettings;
            CancelIncidentRoleHandoverSettings = existing.CancelIncidentRoleHandoverSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IncidentServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="IncidentServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="IncidentServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="IncidentServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="IncidentServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="IncidentServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="IncidentServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="IncidentServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="IncidentServiceClient"/> RPC methods is defined as:
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
        /// <c>IncidentServiceClient.CreateIncident</c> and <c>IncidentServiceClient.CreateIncidentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CreateIncident</c> and
        /// <c>IncidentServiceClient.CreateIncidentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateIncidentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.GetIncident</c> and <c>IncidentServiceClient.GetIncidentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.GetIncident</c> and
        /// <c>IncidentServiceClient.GetIncidentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetIncidentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.SearchIncidents</c> and <c>IncidentServiceClient.SearchIncidentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.SearchIncidents</c> and
        /// <c>IncidentServiceClient.SearchIncidentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SearchIncidentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.UpdateIncident</c> and <c>IncidentServiceClient.UpdateIncidentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.UpdateIncident</c> and
        /// <c>IncidentServiceClient.UpdateIncidentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateIncidentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.SearchSimilarIncidents</c> and <c>IncidentServiceClient.SearchSimilarIncidentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.SearchSimilarIncidents</c> and
        /// <c>IncidentServiceClient.SearchSimilarIncidentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SearchSimilarIncidentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.CreateAnnotation</c> and <c>IncidentServiceClient.CreateAnnotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CreateAnnotation</c> and
        /// <c>IncidentServiceClient.CreateAnnotationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateAnnotationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ListAnnotations</c> and <c>IncidentServiceClient.ListAnnotationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ListAnnotations</c> and
        /// <c>IncidentServiceClient.ListAnnotationsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListAnnotationsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.UpdateAnnotation</c> and <c>IncidentServiceClient.UpdateAnnotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.UpdateAnnotation</c> and
        /// <c>IncidentServiceClient.UpdateAnnotationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateAnnotationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.CreateTag</c> and <c>IncidentServiceClient.CreateTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CreateTag</c> and
        /// <c>IncidentServiceClient.CreateTagAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateTagSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.DeleteTag</c> and <c>IncidentServiceClient.DeleteTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.DeleteTag</c> and
        /// <c>IncidentServiceClient.DeleteTagAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteTagSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ListTags</c> and <c>IncidentServiceClient.ListTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ListTags</c> and
        /// <c>IncidentServiceClient.ListTagsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListTagsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.CreateSignal</c> and <c>IncidentServiceClient.CreateSignalAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CreateSignal</c> and
        /// <c>IncidentServiceClient.CreateSignalAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateSignalSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ListSignals</c> and <c>IncidentServiceClient.ListSignalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ListSignals</c> and
        /// <c>IncidentServiceClient.ListSignalsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListSignalsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.GetSignal</c> and <c>IncidentServiceClient.GetSignalAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.GetSignal</c> and
        /// <c>IncidentServiceClient.GetSignalAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetSignalSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.UpdateSignal</c> and <c>IncidentServiceClient.UpdateSignalAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.UpdateSignal</c> and
        /// <c>IncidentServiceClient.UpdateSignalAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateSignalSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.AcknowledgeSignal</c> and <c>IncidentServiceClient.AcknowledgeSignalAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.AcknowledgeSignal</c> and
        /// <c>IncidentServiceClient.AcknowledgeSignalAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings AcknowledgeSignalSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.EscalateIncident</c> and <c>IncidentServiceClient.EscalateIncidentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.EscalateIncident</c> and
        /// <c>IncidentServiceClient.EscalateIncidentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings EscalateIncidentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.CreateArtifact</c> and <c>IncidentServiceClient.CreateArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CreateArtifact</c> and
        /// <c>IncidentServiceClient.CreateArtifactAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ListArtifacts</c> and <c>IncidentServiceClient.ListArtifactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ListArtifacts</c> and
        /// <c>IncidentServiceClient.ListArtifactsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListArtifactsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.UpdateArtifact</c> and <c>IncidentServiceClient.UpdateArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.UpdateArtifact</c> and
        /// <c>IncidentServiceClient.UpdateArtifactAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.DeleteArtifact</c> and <c>IncidentServiceClient.DeleteArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.DeleteArtifact</c> and
        /// <c>IncidentServiceClient.DeleteArtifactAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.GetShiftHandoffPresets</c> and <c>IncidentServiceClient.GetShiftHandoffPresetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.GetShiftHandoffPresets</c> and
        /// <c>IncidentServiceClient.GetShiftHandoffPresetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetShiftHandoffPresetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.SendShiftHandoff</c> and <c>IncidentServiceClient.SendShiftHandoffAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.SendShiftHandoff</c> and
        /// <c>IncidentServiceClient.SendShiftHandoffAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SendShiftHandoffSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.CreateSubscription</c> and <c>IncidentServiceClient.CreateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CreateSubscription</c> and
        /// <c>IncidentServiceClient.CreateSubscriptionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ListSubscriptions</c> and <c>IncidentServiceClient.ListSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ListSubscriptions</c> and
        /// <c>IncidentServiceClient.ListSubscriptionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListSubscriptionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.DeleteSubscription</c> and <c>IncidentServiceClient.DeleteSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.DeleteSubscription</c> and
        /// <c>IncidentServiceClient.DeleteSubscriptionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.CreateIncidentRoleAssignment</c> and <c>IncidentServiceClient.CreateIncidentRoleAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CreateIncidentRoleAssignment</c> and
        /// <c>IncidentServiceClient.CreateIncidentRoleAssignmentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateIncidentRoleAssignmentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.DeleteIncidentRoleAssignment</c> and <c>IncidentServiceClient.DeleteIncidentRoleAssignmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.DeleteIncidentRoleAssignment</c> and
        /// <c>IncidentServiceClient.DeleteIncidentRoleAssignmentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteIncidentRoleAssignmentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ListIncidentRoleAssignments</c> and <c>IncidentServiceClient.ListIncidentRoleAssignmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ListIncidentRoleAssignments</c> and
        /// <c>IncidentServiceClient.ListIncidentRoleAssignmentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListIncidentRoleAssignmentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.RequestIncidentRoleHandover</c> and <c>IncidentServiceClient.RequestIncidentRoleHandoverAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.RequestIncidentRoleHandover</c> and
        /// <c>IncidentServiceClient.RequestIncidentRoleHandoverAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RequestIncidentRoleHandoverSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ConfirmIncidentRoleHandover</c> and <c>IncidentServiceClient.ConfirmIncidentRoleHandoverAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ConfirmIncidentRoleHandover</c> and
        /// <c>IncidentServiceClient.ConfirmIncidentRoleHandoverAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ConfirmIncidentRoleHandoverSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.ForceIncidentRoleHandover</c> and <c>IncidentServiceClient.ForceIncidentRoleHandoverAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.ForceIncidentRoleHandover</c> and
        /// <c>IncidentServiceClient.ForceIncidentRoleHandoverAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ForceIncidentRoleHandoverSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncidentServiceClient.CancelIncidentRoleHandover</c> and <c>IncidentServiceClient.CancelIncidentRoleHandoverAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IncidentServiceClient.CancelIncidentRoleHandover</c> and
        /// <c>IncidentServiceClient.CancelIncidentRoleHandoverAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CancelIncidentRoleHandoverSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="IncidentServiceSettings"/> object.</returns>
        public IncidentServiceSettings Clone() => new IncidentServiceSettings(this);
    }

    /// <summary>
    /// IncidentService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class IncidentServiceClient
    {
        /// <summary>
        /// The default endpoint for the IncidentService service, which is a host of "irm.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("irm.googleapis.com", 443);

        /// <summary>
        /// The default IncidentService scopes.
        /// </summary>
        /// <remarks>
        /// The default IncidentService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="IncidentServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Irm.V1Alpha2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// IncidentServiceClient client = await IncidentServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Irm.V1Alpha2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     IncidentServiceClient.DefaultEndpoint.Host, IncidentServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// IncidentServiceClient client = IncidentServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IncidentServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="IncidentServiceClient"/>.</returns>
        public static async stt::Task<IncidentServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, IncidentServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="IncidentServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Irm.V1Alpha2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// IncidentServiceClient client = IncidentServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Irm.V1Alpha2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     IncidentServiceClient.DefaultEndpoint.Host, IncidentServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// IncidentServiceClient client = IncidentServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IncidentServiceSettings"/>.</param>
        /// <returns>The created <see cref="IncidentServiceClient"/>.</returns>
        public static IncidentServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, IncidentServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="IncidentServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="IncidentServiceSettings"/>.</param>
        /// <returns>The created <see cref="IncidentServiceClient"/>.</returns>
        public static IncidentServiceClient Create(grpccore::Channel channel, IncidentServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="IncidentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="IncidentServiceSettings"/>.</param>
        /// <returns>The created <see cref="IncidentServiceClient"/>.</returns>
        public static IncidentServiceClient Create(grpccore::CallInvoker callInvoker, IncidentServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IncidentService.IncidentServiceClient grpcClient = new IncidentService.IncidentServiceClient(callInvoker);
            return new IncidentServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, IncidentServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, IncidentServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, IncidentServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, IncidentServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC IncidentService client.
        /// </summary>
        public virtual IncidentService.IncidentServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new incident.
        /// </summary>
        /// <param name="incident">
        /// The incident to create.
        /// </param>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which the incident
        /// belongs to.
        /// The name is of the form `projects/{project_id_or_number}`
        /// .
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Incident> CreateIncidentAsync(
            Incident incident,
            string parent,
            gaxgrpc::CallSettings callSettings = null) => CreateIncidentAsync(
                new CreateIncidentRequest
                {
                    Incident = gax::GaxPreconditions.CheckNotNull(incident, nameof(incident)),
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Creates a new incident.
        /// </summary>
        /// <param name="incident">
        /// The incident to create.
        /// </param>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which the incident
        /// belongs to.
        /// The name is of the form `projects/{project_id_or_number}`
        /// .
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Incident> CreateIncidentAsync(
            Incident incident,
            string parent,
            st::CancellationToken cancellationToken) => CreateIncidentAsync(
                incident,
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new incident.
        /// </summary>
        /// <param name="incident">
        /// The incident to create.
        /// </param>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which the incident
        /// belongs to.
        /// The name is of the form `projects/{project_id_or_number}`
        /// .
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Incident CreateIncident(
            Incident incident,
            string parent,
            gaxgrpc::CallSettings callSettings = null) => CreateIncident(
                new CreateIncidentRequest
                {
                    Incident = gax::GaxPreconditions.CheckNotNull(incident, nameof(incident)),
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Creates a new incident.
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
        public virtual stt::Task<Incident> CreateIncidentAsync(
            CreateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new incident.
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
        public virtual stt::Task<Incident> CreateIncidentAsync(
            CreateIncidentRequest request,
            st::CancellationToken cancellationToken) => CreateIncidentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new incident.
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
        public virtual Incident CreateIncident(
            CreateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns an incident by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Incident> GetIncidentAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetIncidentAsync(
                new GetIncidentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns an incident by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Incident> GetIncidentAsync(
            string name,
            st::CancellationToken cancellationToken) => GetIncidentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an incident by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Incident GetIncident(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetIncident(
                new GetIncidentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns an incident by name.
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
        public virtual stt::Task<Incident> GetIncidentAsync(
            GetIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns an incident by name.
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
        public virtual stt::Task<Incident> GetIncidentAsync(
            GetIncidentRequest request,
            st::CancellationToken cancellationToken) => GetIncidentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an incident by name.
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
        public virtual Incident GetIncident(
            GetIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of incidents.
        /// Incidents are ordered by start time, with the most recent incidents first.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which requested
        /// incidents belong to.
        /// </param>
        /// <param name="query">
        /// An expression that defines which incidents to return.
        ///
        /// Search atoms can be used to match certain specific fields.  Otherwise,
        /// plain text will match text fields in the incident.
        ///
        /// Search atoms:
        /// * `start` - (timestamp) The time the incident started.
        /// * `stage` - The stage of the incident, one of detected, triaged, mitigated,
        ///   resolved, documented, or duplicate (which correspond to values in the
        ///   Incident.Stage enum). These are ordered, so `stage&lt;resolved` is
        ///   equivalent to `stage:detected OR stage:triaged OR stage:mitigated`.
        /// * `severity` - (Incident.Severity) The severity of the incident.
        ///    + Supports matching on a specific severity (e.g., `severity:major`) or
        ///      on a range (e.g., `severity&gt;medium`, `severity&lt;=minor`, etc.).
        ///
        /// Timestamp formats:
        /// * yyyy-MM-dd - an absolute date, treated as a calendar-day-wide window.
        ///   In other words, the "&lt;" operator will match dates before that date, the
        ///   "&gt;" operator will match dates after that date, and the ":" or "="
        ///   operators will match the entire day.
        /// * Nd (e.g. 7d) - a relative number of days ago, treated as a moment in time
        ///   (as opposed to a day-wide span) a multiple of 24 hours ago (as opposed to
        ///   calendar days).  In the case of daylight savings time, it will apply the
        ///   current timezone to both ends of the range.  Note that exact matching
        ///   (e.g. `start:7d`) is unlikely to be useful because that would only match
        ///   incidents created precisely at a particular instant in time.
        ///
        /// Examples:
        ///
        /// * `foo` - matches incidents containing the word "foo"
        /// * `"foo bar"` - matches incidents containing the phrase "foo bar"
        /// * `foo bar` or `foo AND bar` - matches incidents containing the words "foo"
        ///   and "bar"
        /// * `foo -bar` or `foo AND NOT bar` - matches incidents containing the word
        ///   "foo" but not the word "bar"
        /// * `foo OR bar` - matches incidents containing the word "foo" or the word
        ///   "bar"
        /// * `start&gt;2018-11-28` - matches incidents which started after November 11,
        ///   2018.
        /// * `start&lt;=2018-11-28` - matches incidents which started on or before
        ///   November 11, 2018.
        /// * `start:2018-11-28` - matches incidents which started on November 11,
        ///   2018.
        /// * `start&gt;7d` - matches incidents which started after the point in time 7*24
        ///   hours ago
        /// * `start&gt;180d` - similar to 7d, but likely to cross the daylight savings
        ///   time boundary, so the end time will be 1 hour different from "now."
        /// * `foo AND start&gt;90d AND stage&lt;resolved` - unresolved incidents from the
        ///   past 90 days containing the word "foo"
        /// </param>
        /// <param name="timeZone">
        /// The time zone name. It should be an IANA TZ name, such as
        /// "America/Los_Angeles". For more information,
        /// see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones.
        /// If no time zone is specified, the default is UTC.
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
        /// A pageable asynchronous sequence of <see cref="Incident"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchIncidentsResponse, Incident> SearchIncidentsAsync(
            string parent,
            string query,
            string timeZone,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchIncidentsAsync(
                new SearchIncidentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Query = query ?? "", // Optional
                    TimeZone = timeZone ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of incidents.
        /// Incidents are ordered by start time, with the most recent incidents first.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which requested
        /// incidents belong to.
        /// </param>
        /// <param name="query">
        /// An expression that defines which incidents to return.
        ///
        /// Search atoms can be used to match certain specific fields.  Otherwise,
        /// plain text will match text fields in the incident.
        ///
        /// Search atoms:
        /// * `start` - (timestamp) The time the incident started.
        /// * `stage` - The stage of the incident, one of detected, triaged, mitigated,
        ///   resolved, documented, or duplicate (which correspond to values in the
        ///   Incident.Stage enum). These are ordered, so `stage&lt;resolved` is
        ///   equivalent to `stage:detected OR stage:triaged OR stage:mitigated`.
        /// * `severity` - (Incident.Severity) The severity of the incident.
        ///    + Supports matching on a specific severity (e.g., `severity:major`) or
        ///      on a range (e.g., `severity&gt;medium`, `severity&lt;=minor`, etc.).
        ///
        /// Timestamp formats:
        /// * yyyy-MM-dd - an absolute date, treated as a calendar-day-wide window.
        ///   In other words, the "&lt;" operator will match dates before that date, the
        ///   "&gt;" operator will match dates after that date, and the ":" or "="
        ///   operators will match the entire day.
        /// * Nd (e.g. 7d) - a relative number of days ago, treated as a moment in time
        ///   (as opposed to a day-wide span) a multiple of 24 hours ago (as opposed to
        ///   calendar days).  In the case of daylight savings time, it will apply the
        ///   current timezone to both ends of the range.  Note that exact matching
        ///   (e.g. `start:7d`) is unlikely to be useful because that would only match
        ///   incidents created precisely at a particular instant in time.
        ///
        /// Examples:
        ///
        /// * `foo` - matches incidents containing the word "foo"
        /// * `"foo bar"` - matches incidents containing the phrase "foo bar"
        /// * `foo bar` or `foo AND bar` - matches incidents containing the words "foo"
        ///   and "bar"
        /// * `foo -bar` or `foo AND NOT bar` - matches incidents containing the word
        ///   "foo" but not the word "bar"
        /// * `foo OR bar` - matches incidents containing the word "foo" or the word
        ///   "bar"
        /// * `start&gt;2018-11-28` - matches incidents which started after November 11,
        ///   2018.
        /// * `start&lt;=2018-11-28` - matches incidents which started on or before
        ///   November 11, 2018.
        /// * `start:2018-11-28` - matches incidents which started on November 11,
        ///   2018.
        /// * `start&gt;7d` - matches incidents which started after the point in time 7*24
        ///   hours ago
        /// * `start&gt;180d` - similar to 7d, but likely to cross the daylight savings
        ///   time boundary, so the end time will be 1 hour different from "now."
        /// * `foo AND start&gt;90d AND stage&lt;resolved` - unresolved incidents from the
        ///   past 90 days containing the word "foo"
        /// </param>
        /// <param name="timeZone">
        /// The time zone name. It should be an IANA TZ name, such as
        /// "America/Los_Angeles". For more information,
        /// see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones.
        /// If no time zone is specified, the default is UTC.
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
        /// A pageable sequence of <see cref="Incident"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchIncidentsResponse, Incident> SearchIncidents(
            string parent,
            string query,
            string timeZone,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchIncidents(
                new SearchIncidentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Query = query ?? "", // Optional
                    TimeZone = timeZone ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of incidents.
        /// Incidents are ordered by start time, with the most recent incidents first.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Incident"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchIncidentsResponse, Incident> SearchIncidentsAsync(
            SearchIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of incidents.
        /// Incidents are ordered by start time, with the most recent incidents first.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Incident"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchIncidentsResponse, Incident> SearchIncidents(
            SearchIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing incident.
        /// </summary>
        /// <param name="incident">
        /// The incident to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Incident> UpdateIncidentAsync(
            Incident incident,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateIncidentAsync(
                new UpdateIncidentRequest
                {
                    Incident = gax::GaxPreconditions.CheckNotNull(incident, nameof(incident)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an existing incident.
        /// </summary>
        /// <param name="incident">
        /// The incident to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Incident> UpdateIncidentAsync(
            Incident incident,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateIncidentAsync(
                incident,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing incident.
        /// </summary>
        /// <param name="incident">
        /// The incident to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Incident UpdateIncident(
            Incident incident,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateIncident(
                new UpdateIncidentRequest
                {
                    Incident = gax::GaxPreconditions.CheckNotNull(incident, nameof(incident)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an existing incident.
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
        public virtual stt::Task<Incident> UpdateIncidentAsync(
            UpdateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing incident.
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
        public virtual stt::Task<Incident> UpdateIncidentAsync(
            UpdateIncidentRequest request,
            st::CancellationToken cancellationToken) => UpdateIncidentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing incident.
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
        public virtual Incident UpdateIncident(
            UpdateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of incidents that are "similar" to the specified incident
        /// or signal. This functionality is provided on a best-effort basis and the
        /// definition of "similar" is subject to change.
        /// </summary>
        /// <param name="name">
        /// Resource name of the incident or signal, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable asynchronous sequence of <see cref="SearchSimilarIncidentsResponse.Types.Result"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result> SearchSimilarIncidentsAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchSimilarIncidentsAsync(
                new SearchSimilarIncidentsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of incidents that are "similar" to the specified incident
        /// or signal. This functionality is provided on a best-effort basis and the
        /// definition of "similar" is subject to change.
        /// </summary>
        /// <param name="name">
        /// Resource name of the incident or signal, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable sequence of <see cref="SearchSimilarIncidentsResponse.Types.Result"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result> SearchSimilarIncidents(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchSimilarIncidents(
                new SearchSimilarIncidentsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of incidents that are "similar" to the specified incident
        /// or signal. This functionality is provided on a best-effort basis and the
        /// definition of "similar" is subject to change.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchSimilarIncidentsResponse.Types.Result"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result> SearchSimilarIncidentsAsync(
            SearchSimilarIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of incidents that are "similar" to the specified incident
        /// or signal. This functionality is provided on a best-effort basis and the
        /// definition of "similar" is subject to change.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchSimilarIncidentsResponse.Types.Result"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result> SearchSimilarIncidents(
            SearchSimilarIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="annotation">
        /// Only annotation.content is an input argument.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(
            string parent,
            Annotation annotation,
            gaxgrpc::CallSettings callSettings = null) => CreateAnnotationAsync(
                new CreateAnnotationRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                },
                callSettings);

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="annotation">
        /// Only annotation.content is an input argument.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Annotation> CreateAnnotationAsync(
            string parent,
            Annotation annotation,
            st::CancellationToken cancellationToken) => CreateAnnotationAsync(
                parent,
                annotation,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="annotation">
        /// Only annotation.content is an input argument.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Annotation CreateAnnotation(
            string parent,
            Annotation annotation,
            gaxgrpc::CallSettings callSettings = null) => CreateAnnotation(
                new CreateAnnotationRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                },
                callSettings);

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
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
        public virtual stt::Task<Annotation> CreateAnnotationAsync(
            CreateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
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
        public virtual stt::Task<Annotation> CreateAnnotationAsync(
            CreateAnnotationRequest request,
            st::CancellationToken cancellationToken) => CreateAnnotationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
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
        public virtual Annotation CreateAnnotation(
            CreateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists annotations that are part of an incident. No assumptions should be
        /// made on the content-type of the annotation returned.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable asynchronous sequence of <see cref="Annotation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAnnotationsAsync(
                new ListAnnotationsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists annotations that are part of an incident. No assumptions should be
        /// made on the content-type of the annotation returned.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable sequence of <see cref="Annotation"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAnnotations(
                new ListAnnotationsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists annotations that are part of an incident. No assumptions should be
        /// made on the content-type of the annotation returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Annotation"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(
            ListAnnotationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists annotations that are part of an incident. No assumptions should be
        /// made on the content-type of the annotation returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Annotation"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(
            ListAnnotationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an annotation on an existing incident.
        /// </summary>
        /// <param name="annotation">
        /// The annotation to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(
            Annotation annotation,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateAnnotationAsync(
                new UpdateAnnotationRequest
                {
                    Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an annotation on an existing incident.
        /// </summary>
        /// <param name="annotation">
        /// The annotation to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(
            Annotation annotation,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateAnnotationAsync(
                annotation,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an annotation on an existing incident.
        /// </summary>
        /// <param name="annotation">
        /// The annotation to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Annotation UpdateAnnotation(
            Annotation annotation,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateAnnotation(
                new UpdateAnnotationRequest
                {
                    Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an annotation on an existing incident.
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
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(
            UpdateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an annotation on an existing incident.
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
        public virtual stt::Task<Annotation> UpdateAnnotationAsync(
            UpdateAnnotationRequest request,
            st::CancellationToken cancellationToken) => UpdateAnnotationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an annotation on an existing incident.
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
        public virtual Annotation UpdateAnnotation(
            UpdateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a tag on an existing incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="tag">
        /// Tag to create. Only tag.display_name is an input argument.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tag> CreateTagAsync(
            string parent,
            Tag tag,
            gaxgrpc::CallSettings callSettings = null) => CreateTagAsync(
                new CreateTagRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
                },
                callSettings);

        /// <summary>
        /// Creates a tag on an existing incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="tag">
        /// Tag to create. Only tag.display_name is an input argument.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Tag> CreateTagAsync(
            string parent,
            Tag tag,
            st::CancellationToken cancellationToken) => CreateTagAsync(
                parent,
                tag,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag on an existing incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="tag">
        /// Tag to create. Only tag.display_name is an input argument.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Tag CreateTag(
            string parent,
            Tag tag,
            gaxgrpc::CallSettings callSettings = null) => CreateTag(
                new CreateTagRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
                },
                callSettings);

        /// <summary>
        /// Creates a tag on an existing incident.
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
        public virtual stt::Task<Tag> CreateTagAsync(
            CreateTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a tag on an existing incident.
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
        public virtual stt::Task<Tag> CreateTagAsync(
            CreateTagRequest request,
            st::CancellationToken cancellationToken) => CreateTagAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag on an existing incident.
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
        public virtual Tag CreateTag(
            CreateTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing tag.
        /// </summary>
        /// <param name="name">
        /// Resource name of the tag.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTagAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTagAsync(
                new DeleteTagRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing tag.
        /// </summary>
        /// <param name="name">
        /// Resource name of the tag.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTagAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteTagAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing tag.
        /// </summary>
        /// <param name="name">
        /// Resource name of the tag.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTag(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteTag(
                new DeleteTagRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing tag.
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
        public virtual stt::Task DeleteTagAsync(
            DeleteTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing tag.
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
        public virtual stt::Task DeleteTagAsync(
            DeleteTagRequest request,
            st::CancellationToken cancellationToken) => DeleteTagAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing tag.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTag(
            DeleteTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists tags that are part of an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable asynchronous sequence of <see cref="Tag"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTagsAsync(
                new ListTagsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists tags that are part of an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable sequence of <see cref="Tag"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTags(
                new ListTagsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists tags that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Tag"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(
            ListTagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists tags that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Tag"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(
            ListTagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new signal.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which requested
        /// signal belongs to.
        /// </param>
        /// <param name="signal">
        /// The signal to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Signal> CreateSignalAsync(
            string parent,
            Signal signal,
            gaxgrpc::CallSettings callSettings = null) => CreateSignalAsync(
                new CreateSignalRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Signal = gax::GaxPreconditions.CheckNotNull(signal, nameof(signal)),
                },
                callSettings);

        /// <summary>
        /// Creates a new signal.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which requested
        /// signal belongs to.
        /// </param>
        /// <param name="signal">
        /// The signal to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Signal> CreateSignalAsync(
            string parent,
            Signal signal,
            st::CancellationToken cancellationToken) => CreateSignalAsync(
                parent,
                signal,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new signal.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which requested
        /// signal belongs to.
        /// </param>
        /// <param name="signal">
        /// The signal to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Signal CreateSignal(
            string parent,
            Signal signal,
            gaxgrpc::CallSettings callSettings = null) => CreateSignal(
                new CreateSignalRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Signal = gax::GaxPreconditions.CheckNotNull(signal, nameof(signal)),
                },
                callSettings);

        /// <summary>
        /// Creates a new signal.
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
        public virtual stt::Task<Signal> CreateSignalAsync(
            CreateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new signal.
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
        public virtual stt::Task<Signal> CreateSignalAsync(
            CreateSignalRequest request,
            st::CancellationToken cancellationToken) => CreateSignalAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new signal.
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
        public virtual Signal CreateSignal(
            CreateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists signals that are part of an incident.
        /// Signals are returned in reverse chronological order.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which requested
        /// incidents belong to.
        /// </param>
        /// <param name="filter">
        /// Filter to specify which signals should be returned.
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
        /// A pageable asynchronous sequence of <see cref="Signal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSignalsResponse, Signal> ListSignalsAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSignalsAsync(
                new ListSignalsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists signals that are part of an incident.
        /// Signals are returned in reverse chronological order.
        /// </summary>
        /// <param name="parent">
        /// The resource name of the hosting Stackdriver project which requested
        /// incidents belong to.
        /// </param>
        /// <param name="filter">
        /// Filter to specify which signals should be returned.
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
        /// A pageable sequence of <see cref="Signal"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSignalsResponse, Signal> ListSignals(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSignals(
                new ListSignalsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists signals that are part of an incident.
        /// Signals are returned in reverse chronological order.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Signal"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSignalsResponse, Signal> ListSignalsAsync(
            ListSignalsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists signals that are part of an incident.
        /// Signals are returned in reverse chronological order.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Signal"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSignalsResponse, Signal> ListSignals(
            ListSignalsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a signal by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Signal resource, e.g.
        /// "projects/{project_id}/signals/{signal_id}".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Signal> GetSignalAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetSignalAsync(
                new GetSignalRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns a signal by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Signal resource, e.g.
        /// "projects/{project_id}/signals/{signal_id}".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Signal> GetSignalAsync(
            string name,
            st::CancellationToken cancellationToken) => GetSignalAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a signal by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Signal resource, e.g.
        /// "projects/{project_id}/signals/{signal_id}".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Signal GetSignal(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetSignal(
                new GetSignalRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns a signal by name.
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
        public virtual stt::Task<Signal> GetSignalAsync(
            GetSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a signal by name.
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
        public virtual stt::Task<Signal> GetSignalAsync(
            GetSignalRequest request,
            st::CancellationToken cancellationToken) => GetSignalAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a signal by name.
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
        public virtual Signal GetSignal(
            GetSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
        /// </summary>
        /// <param name="signal">
        /// The signal to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Signal> UpdateSignalAsync(
            Signal signal,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateSignalAsync(
                new UpdateSignalRequest
                {
                    Signal = gax::GaxPreconditions.CheckNotNull(signal, nameof(signal)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
        /// </summary>
        /// <param name="signal">
        /// The signal to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Signal> UpdateSignalAsync(
            Signal signal,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateSignalAsync(
                signal,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
        /// </summary>
        /// <param name="signal">
        /// The signal to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Signal UpdateSignal(
            Signal signal,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateSignal(
                new UpdateSignalRequest
                {
                    Signal = gax::GaxPreconditions.CheckNotNull(signal, nameof(signal)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
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
        public virtual stt::Task<Signal> UpdateSignalAsync(
            UpdateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
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
        public virtual stt::Task<Signal> UpdateSignalAsync(
            UpdateSignalRequest request,
            st::CancellationToken cancellationToken) => UpdateSignalAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
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
        public virtual Signal UpdateSignal(
            UpdateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Signal resource, e.g.
        /// "projects/{project_id}/signals/{signal_id}".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AcknowledgeSignalResponse> AcknowledgeSignalAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => AcknowledgeSignalAsync(
                new AcknowledgeSignalRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Signal resource, e.g.
        /// "projects/{project_id}/signals/{signal_id}".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AcknowledgeSignalResponse> AcknowledgeSignalAsync(
            string name,
            st::CancellationToken cancellationToken) => AcknowledgeSignalAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Signal resource, e.g.
        /// "projects/{project_id}/signals/{signal_id}".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AcknowledgeSignalResponse AcknowledgeSignal(
            string name,
            gaxgrpc::CallSettings callSettings = null) => AcknowledgeSignal(
                new AcknowledgeSignalRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
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
        public virtual stt::Task<AcknowledgeSignalResponse> AcknowledgeSignalAsync(
            AcknowledgeSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
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
        public virtual stt::Task<AcknowledgeSignalResponse> AcknowledgeSignalAsync(
            AcknowledgeSignalRequest request,
            st::CancellationToken cancellationToken) => AcknowledgeSignalAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
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
        public virtual AcknowledgeSignalResponse AcknowledgeSignal(
            AcknowledgeSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Escalates an incident.
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
        public virtual stt::Task<EscalateIncidentResponse> EscalateIncidentAsync(
            EscalateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Escalates an incident.
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
        public virtual stt::Task<EscalateIncidentResponse> EscalateIncidentAsync(
            EscalateIncidentRequest request,
            st::CancellationToken cancellationToken) => EscalateIncidentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Escalates an incident.
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
        public virtual EscalateIncidentResponse EscalateIncident(
            EscalateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new artifact.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="artifact">
        /// The artifact to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(
            string parent,
            Artifact artifact,
            gaxgrpc::CallSettings callSettings = null) => CreateArtifactAsync(
                new CreateArtifactRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                },
                callSettings);

        /// <summary>
        /// Creates a new artifact.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="artifact">
        /// The artifact to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(
            string parent,
            Artifact artifact,
            st::CancellationToken cancellationToken) => CreateArtifactAsync(
                parent,
                artifact,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new artifact.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="artifact">
        /// The artifact to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Artifact CreateArtifact(
            string parent,
            Artifact artifact,
            gaxgrpc::CallSettings callSettings = null) => CreateArtifact(
                new CreateArtifactRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                },
                callSettings);

        /// <summary>
        /// Creates a new artifact.
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
        public virtual stt::Task<Artifact> CreateArtifactAsync(
            CreateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new artifact.
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
        public virtual stt::Task<Artifact> CreateArtifactAsync(
            CreateArtifactRequest request,
            st::CancellationToken cancellationToken) => CreateArtifactAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new artifact.
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
        public virtual Artifact CreateArtifact(
            CreateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of artifacts for an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable asynchronous sequence of <see cref="Artifact"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListArtifactsAsync(
                new ListArtifactsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of artifacts for an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable sequence of <see cref="Artifact"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListArtifacts(
                new ListArtifactsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of artifacts for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Artifact"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(
            ListArtifactsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of artifacts for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Artifact"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(
            ListArtifactsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing artifact.
        /// </summary>
        /// <param name="artifact">
        /// The artifact to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Artifact> UpdateArtifactAsync(
            Artifact artifact,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateArtifactAsync(
                new UpdateArtifactRequest
                {
                    Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an existing artifact.
        /// </summary>
        /// <param name="artifact">
        /// The artifact to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Artifact> UpdateArtifactAsync(
            Artifact artifact,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateArtifactAsync(
                artifact,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing artifact.
        /// </summary>
        /// <param name="artifact">
        /// The artifact to update with the new values.
        /// </param>
        /// <param name="updateMask">
        /// List of fields that should be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Artifact UpdateArtifact(
            Artifact artifact,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateArtifact(
                new UpdateArtifactRequest
                {
                    Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates an existing artifact.
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
        public virtual stt::Task<Artifact> UpdateArtifactAsync(
            UpdateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing artifact.
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
        public virtual stt::Task<Artifact> UpdateArtifactAsync(
            UpdateArtifactRequest request,
            st::CancellationToken cancellationToken) => UpdateArtifactAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing artifact.
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
        public virtual Artifact UpdateArtifact(
            UpdateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing artifact.
        /// </summary>
        /// <param name="name">
        /// Resource name of the artifact.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteArtifactAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteArtifactAsync(
                new DeleteArtifactRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing artifact.
        /// </summary>
        /// <param name="name">
        /// Resource name of the artifact.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteArtifactAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteArtifactAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing artifact.
        /// </summary>
        /// <param name="name">
        /// Resource name of the artifact.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteArtifact(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteArtifact(
                new DeleteArtifactRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing artifact.
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
        public virtual stt::Task DeleteArtifactAsync(
            DeleteArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing artifact.
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
        public virtual stt::Task DeleteArtifactAsync(
            DeleteArtifactRequest request,
            st::CancellationToken cancellationToken) => DeleteArtifactAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing artifact.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteArtifact(
            DeleteArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the Stackdriver project that the presets belong to. e.g.
        /// `projects/{project_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ShiftHandoffPresets> GetShiftHandoffPresetsAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => GetShiftHandoffPresetsAsync(
                new GetShiftHandoffPresetsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the Stackdriver project that the presets belong to. e.g.
        /// `projects/{project_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ShiftHandoffPresets> GetShiftHandoffPresetsAsync(
            string parent,
            st::CancellationToken cancellationToken) => GetShiftHandoffPresetsAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the Stackdriver project that the presets belong to. e.g.
        /// `projects/{project_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ShiftHandoffPresets GetShiftHandoffPresets(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => GetShiftHandoffPresets(
                new GetShiftHandoffPresetsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
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
        public virtual stt::Task<ShiftHandoffPresets> GetShiftHandoffPresetsAsync(
            GetShiftHandoffPresetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
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
        public virtual stt::Task<ShiftHandoffPresets> GetShiftHandoffPresetsAsync(
            GetShiftHandoffPresetsRequest request,
            st::CancellationToken cancellationToken) => GetShiftHandoffPresetsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
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
        public virtual ShiftHandoffPresets GetShiftHandoffPresets(
            GetShiftHandoffPresetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sends a summary of the shift for oncall handoff.
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
        public virtual stt::Task<SendShiftHandoffResponse> SendShiftHandoffAsync(
            SendShiftHandoffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sends a summary of the shift for oncall handoff.
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
        public virtual stt::Task<SendShiftHandoffResponse> SendShiftHandoffAsync(
            SendShiftHandoffRequest request,
            st::CancellationToken cancellationToken) => SendShiftHandoffAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends a summary of the shift for oncall handoff.
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
        public virtual SendShiftHandoffResponse SendShiftHandoff(
            SendShiftHandoffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="subscription">
        /// The subscription to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            string parent,
            Subscription subscription,
            gaxgrpc::CallSettings callSettings = null) => CreateSubscriptionAsync(
                new CreateSubscriptionRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="subscription">
        /// The subscription to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            string parent,
            Subscription subscription,
            st::CancellationToken cancellationToken) => CreateSubscriptionAsync(
                parent,
                subscription,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="subscription">
        /// The subscription to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Subscription CreateSubscription(
            string parent,
            Subscription subscription,
            gaxgrpc::CallSettings callSettings = null) => CreateSubscription(
                new CreateSubscriptionRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
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
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            CreateSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
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
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            CreateSubscriptionRequest request,
            st::CancellationToken cancellationToken) => CreateSubscriptionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
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
        public virtual Subscription CreateSubscription(
            CreateSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of subscriptions for an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSubscriptionsAsync(
                new ListSubscriptionsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of subscriptions for an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSubscriptions(
                new ListSubscriptionsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns a list of subscriptions for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of subscriptions for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription.
        /// </summary>
        /// <param name="name">
        /// Resource name of the subscription.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSubscriptionAsync(
                new DeleteSubscriptionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing subscription.
        /// </summary>
        /// <param name="name">
        /// Resource name of the subscription.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing subscription.
        /// </summary>
        /// <param name="name">
        /// Resource name of the subscription.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSubscription(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSubscription(
                new DeleteSubscriptionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing subscription.
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
        public virtual stt::Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription.
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
        public virtual stt::Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            st::CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing subscription.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSubscription(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="incidentRoleAssignment">
        /// Role assignment to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> CreateIncidentRoleAssignmentAsync(
            string parent,
            IncidentRoleAssignment incidentRoleAssignment,
            gaxgrpc::CallSettings callSettings = null) => CreateIncidentRoleAssignmentAsync(
                new CreateIncidentRoleAssignmentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    IncidentRoleAssignment = gax::GaxPreconditions.CheckNotNull(incidentRoleAssignment, nameof(incidentRoleAssignment)),
                },
                callSettings);

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="incidentRoleAssignment">
        /// Role assignment to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> CreateIncidentRoleAssignmentAsync(
            string parent,
            IncidentRoleAssignment incidentRoleAssignment,
            st::CancellationToken cancellationToken) => CreateIncidentRoleAssignmentAsync(
                parent,
                incidentRoleAssignment,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
        /// </param>
        /// <param name="incidentRoleAssignment">
        /// Role assignment to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual IncidentRoleAssignment CreateIncidentRoleAssignment(
            string parent,
            IncidentRoleAssignment incidentRoleAssignment,
            gaxgrpc::CallSettings callSettings = null) => CreateIncidentRoleAssignment(
                new CreateIncidentRoleAssignmentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    IncidentRoleAssignment = gax::GaxPreconditions.CheckNotNull(incidentRoleAssignment, nameof(incidentRoleAssignment)),
                },
                callSettings);

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
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
        public virtual stt::Task<IncidentRoleAssignment> CreateIncidentRoleAssignmentAsync(
            CreateIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
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
        public virtual stt::Task<IncidentRoleAssignment> CreateIncidentRoleAssignmentAsync(
            CreateIncidentRoleAssignmentRequest request,
            st::CancellationToken cancellationToken) => CreateIncidentRoleAssignmentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
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
        public virtual IncidentRoleAssignment CreateIncidentRoleAssignment(
            CreateIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing role assignment.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIncidentRoleAssignmentAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIncidentRoleAssignmentAsync(
                new DeleteIncidentRoleAssignmentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing role assignment.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIncidentRoleAssignmentAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteIncidentRoleAssignmentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing role assignment.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIncidentRoleAssignment(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIncidentRoleAssignment(
                new DeleteIncidentRoleAssignmentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing role assignment.
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
        public virtual stt::Task DeleteIncidentRoleAssignmentAsync(
            DeleteIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing role assignment.
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
        public virtual stt::Task DeleteIncidentRoleAssignmentAsync(
            DeleteIncidentRoleAssignmentRequest request,
            st::CancellationToken cancellationToken) => DeleteIncidentRoleAssignmentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing role assignment.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIncidentRoleAssignment(
            DeleteIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists role assignments that are part of an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable asynchronous sequence of <see cref="IncidentRoleAssignment"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> ListIncidentRoleAssignmentsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIncidentRoleAssignmentsAsync(
                new ListIncidentRoleAssignmentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists role assignments that are part of an incident.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the incident, e.g.
        /// "projects/{project_id}/incidents/{incident_id}".
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
        /// A pageable sequence of <see cref="IncidentRoleAssignment"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> ListIncidentRoleAssignments(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIncidentRoleAssignments(
                new ListIncidentRoleAssignmentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists role assignments that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="IncidentRoleAssignment"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> ListIncidentRoleAssignmentsAsync(
            ListIncidentRoleAssignmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists role assignments that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="IncidentRoleAssignment"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> ListIncidentRoleAssignments(
            ListIncidentRoleAssignmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> RequestIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => RequestIncidentRoleHandoverAsync(
                new RequestIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> RequestIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            st::CancellationToken cancellationToken) => RequestIncidentRoleHandoverAsync(
                name,
                newAssignee,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual IncidentRoleAssignment RequestIncidentRoleHandover(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => RequestIncidentRoleHandover(
                new RequestIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
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
        public virtual stt::Task<IncidentRoleAssignment> RequestIncidentRoleHandoverAsync(
            RequestIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
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
        public virtual stt::Task<IncidentRoleAssignment> RequestIncidentRoleHandoverAsync(
            RequestIncidentRoleHandoverRequest request,
            st::CancellationToken cancellationToken) => RequestIncidentRoleHandoverAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
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
        public virtual IncidentRoleAssignment RequestIncidentRoleHandover(
            RequestIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee, who will now be the assignee. This should be the
        /// current user; otherwise ForceRoleHandover should be called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> ConfirmIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => ConfirmIncidentRoleHandoverAsync(
                new ConfirmIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee, who will now be the assignee. This should be the
        /// current user; otherwise ForceRoleHandover should be called.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> ConfirmIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            st::CancellationToken cancellationToken) => ConfirmIncidentRoleHandoverAsync(
                name,
                newAssignee,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee, who will now be the assignee. This should be the
        /// current user; otherwise ForceRoleHandover should be called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual IncidentRoleAssignment ConfirmIncidentRoleHandover(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => ConfirmIncidentRoleHandover(
                new ConfirmIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
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
        public virtual stt::Task<IncidentRoleAssignment> ConfirmIncidentRoleHandoverAsync(
            ConfirmIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
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
        public virtual stt::Task<IncidentRoleAssignment> ConfirmIncidentRoleHandoverAsync(
            ConfirmIncidentRoleHandoverRequest request,
            st::CancellationToken cancellationToken) => ConfirmIncidentRoleHandoverAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
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
        public virtual IncidentRoleAssignment ConfirmIncidentRoleHandover(
            ConfirmIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee, who will now be the assignee. This should not be
        /// the current user; otherwise ConfirmRoleHandover should be called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> ForceIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => ForceIncidentRoleHandoverAsync(
                new ForceIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee, who will now be the assignee. This should not be
        /// the current user; otherwise ConfirmRoleHandover should be called.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> ForceIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            st::CancellationToken cancellationToken) => ForceIncidentRoleHandoverAsync(
                name,
                newAssignee,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// The proposed assignee, who will now be the assignee. This should not be
        /// the current user; otherwise ConfirmRoleHandover should be called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual IncidentRoleAssignment ForceIncidentRoleHandover(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => ForceIncidentRoleHandover(
                new ForceIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
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
        public virtual stt::Task<IncidentRoleAssignment> ForceIncidentRoleHandoverAsync(
            ForceIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
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
        public virtual stt::Task<IncidentRoleAssignment> ForceIncidentRoleHandoverAsync(
            ForceIncidentRoleHandoverRequest request,
            st::CancellationToken cancellationToken) => ForceIncidentRoleHandoverAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
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
        public virtual IncidentRoleAssignment ForceIncidentRoleHandover(
            ForceIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// Person who was proposed as the next assignee (i.e.
        /// IncidentRoleAssignment.proposed_assignee) and whose proposal is being
        /// cancelled.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> CancelIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => CancelIncidentRoleHandoverAsync(
                new CancelIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// Person who was proposed as the next assignee (i.e.
        /// IncidentRoleAssignment.proposed_assignee) and whose proposal is being
        /// cancelled.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<IncidentRoleAssignment> CancelIncidentRoleHandoverAsync(
            string name,
            User newAssignee,
            st::CancellationToken cancellationToken) => CancelIncidentRoleHandoverAsync(
                name,
                newAssignee,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Resource name of the role assignment.
        /// </param>
        /// <param name="newAssignee">
        /// Person who was proposed as the next assignee (i.e.
        /// IncidentRoleAssignment.proposed_assignee) and whose proposal is being
        /// cancelled.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual IncidentRoleAssignment CancelIncidentRoleHandover(
            string name,
            User newAssignee,
            gaxgrpc::CallSettings callSettings = null) => CancelIncidentRoleHandover(
                new CancelIncidentRoleHandoverRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    NewAssignee = gax::GaxPreconditions.CheckNotNull(newAssignee, nameof(newAssignee)),
                },
                callSettings);

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
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
        public virtual stt::Task<IncidentRoleAssignment> CancelIncidentRoleHandoverAsync(
            CancelIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
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
        public virtual stt::Task<IncidentRoleAssignment> CancelIncidentRoleHandoverAsync(
            CancelIncidentRoleHandoverRequest request,
            st::CancellationToken cancellationToken) => CancelIncidentRoleHandoverAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
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
        public virtual IncidentRoleAssignment CancelIncidentRoleHandover(
            CancelIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// IncidentService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class IncidentServiceClientImpl : IncidentServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateIncidentRequest, Incident> _callCreateIncident;
        private readonly gaxgrpc::ApiCall<GetIncidentRequest, Incident> _callGetIncident;
        private readonly gaxgrpc::ApiCall<SearchIncidentsRequest, SearchIncidentsResponse> _callSearchIncidents;
        private readonly gaxgrpc::ApiCall<UpdateIncidentRequest, Incident> _callUpdateIncident;
        private readonly gaxgrpc::ApiCall<SearchSimilarIncidentsRequest, SearchSimilarIncidentsResponse> _callSearchSimilarIncidents;
        private readonly gaxgrpc::ApiCall<CreateAnnotationRequest, Annotation> _callCreateAnnotation;
        private readonly gaxgrpc::ApiCall<ListAnnotationsRequest, ListAnnotationsResponse> _callListAnnotations;
        private readonly gaxgrpc::ApiCall<UpdateAnnotationRequest, Annotation> _callUpdateAnnotation;
        private readonly gaxgrpc::ApiCall<CreateTagRequest, Tag> _callCreateTag;
        private readonly gaxgrpc::ApiCall<DeleteTagRequest, pbwkt::Empty> _callDeleteTag;
        private readonly gaxgrpc::ApiCall<ListTagsRequest, ListTagsResponse> _callListTags;
        private readonly gaxgrpc::ApiCall<CreateSignalRequest, Signal> _callCreateSignal;
        private readonly gaxgrpc::ApiCall<ListSignalsRequest, ListSignalsResponse> _callListSignals;
        private readonly gaxgrpc::ApiCall<GetSignalRequest, Signal> _callGetSignal;
        private readonly gaxgrpc::ApiCall<UpdateSignalRequest, Signal> _callUpdateSignal;
        private readonly gaxgrpc::ApiCall<AcknowledgeSignalRequest, AcknowledgeSignalResponse> _callAcknowledgeSignal;
        private readonly gaxgrpc::ApiCall<EscalateIncidentRequest, EscalateIncidentResponse> _callEscalateIncident;
        private readonly gaxgrpc::ApiCall<CreateArtifactRequest, Artifact> _callCreateArtifact;
        private readonly gaxgrpc::ApiCall<ListArtifactsRequest, ListArtifactsResponse> _callListArtifacts;
        private readonly gaxgrpc::ApiCall<UpdateArtifactRequest, Artifact> _callUpdateArtifact;
        private readonly gaxgrpc::ApiCall<DeleteArtifactRequest, pbwkt::Empty> _callDeleteArtifact;
        private readonly gaxgrpc::ApiCall<GetShiftHandoffPresetsRequest, ShiftHandoffPresets> _callGetShiftHandoffPresets;
        private readonly gaxgrpc::ApiCall<SendShiftHandoffRequest, SendShiftHandoffResponse> _callSendShiftHandoff;
        private readonly gaxgrpc::ApiCall<CreateSubscriptionRequest, Subscription> _callCreateSubscription;
        private readonly gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> _callListSubscriptions;
        private readonly gaxgrpc::ApiCall<DeleteSubscriptionRequest, pbwkt::Empty> _callDeleteSubscription;
        private readonly gaxgrpc::ApiCall<CreateIncidentRoleAssignmentRequest, IncidentRoleAssignment> _callCreateIncidentRoleAssignment;
        private readonly gaxgrpc::ApiCall<DeleteIncidentRoleAssignmentRequest, pbwkt::Empty> _callDeleteIncidentRoleAssignment;
        private readonly gaxgrpc::ApiCall<ListIncidentRoleAssignmentsRequest, ListIncidentRoleAssignmentsResponse> _callListIncidentRoleAssignments;
        private readonly gaxgrpc::ApiCall<RequestIncidentRoleHandoverRequest, IncidentRoleAssignment> _callRequestIncidentRoleHandover;
        private readonly gaxgrpc::ApiCall<ConfirmIncidentRoleHandoverRequest, IncidentRoleAssignment> _callConfirmIncidentRoleHandover;
        private readonly gaxgrpc::ApiCall<ForceIncidentRoleHandoverRequest, IncidentRoleAssignment> _callForceIncidentRoleHandover;
        private readonly gaxgrpc::ApiCall<CancelIncidentRoleHandoverRequest, IncidentRoleAssignment> _callCancelIncidentRoleHandover;

        /// <summary>
        /// Constructs a client wrapper for the IncidentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IncidentServiceSettings"/> used within this client </param>
        public IncidentServiceClientImpl(IncidentService.IncidentServiceClient grpcClient, IncidentServiceSettings settings)
        {
            GrpcClient = grpcClient;
            IncidentServiceSettings effectiveSettings = settings ?? IncidentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateIncident = clientHelper.BuildApiCall<CreateIncidentRequest, Incident>(
                GrpcClient.CreateIncidentAsync, GrpcClient.CreateIncident, effectiveSettings.CreateIncidentSettings);
            _callGetIncident = clientHelper.BuildApiCall<GetIncidentRequest, Incident>(
                GrpcClient.GetIncidentAsync, GrpcClient.GetIncident, effectiveSettings.GetIncidentSettings);
            _callSearchIncidents = clientHelper.BuildApiCall<SearchIncidentsRequest, SearchIncidentsResponse>(
                GrpcClient.SearchIncidentsAsync, GrpcClient.SearchIncidents, effectiveSettings.SearchIncidentsSettings);
            _callUpdateIncident = clientHelper.BuildApiCall<UpdateIncidentRequest, Incident>(
                GrpcClient.UpdateIncidentAsync, GrpcClient.UpdateIncident, effectiveSettings.UpdateIncidentSettings);
            _callSearchSimilarIncidents = clientHelper.BuildApiCall<SearchSimilarIncidentsRequest, SearchSimilarIncidentsResponse>(
                GrpcClient.SearchSimilarIncidentsAsync, GrpcClient.SearchSimilarIncidents, effectiveSettings.SearchSimilarIncidentsSettings);
            _callCreateAnnotation = clientHelper.BuildApiCall<CreateAnnotationRequest, Annotation>(
                GrpcClient.CreateAnnotationAsync, GrpcClient.CreateAnnotation, effectiveSettings.CreateAnnotationSettings);
            _callListAnnotations = clientHelper.BuildApiCall<ListAnnotationsRequest, ListAnnotationsResponse>(
                GrpcClient.ListAnnotationsAsync, GrpcClient.ListAnnotations, effectiveSettings.ListAnnotationsSettings);
            _callUpdateAnnotation = clientHelper.BuildApiCall<UpdateAnnotationRequest, Annotation>(
                GrpcClient.UpdateAnnotationAsync, GrpcClient.UpdateAnnotation, effectiveSettings.UpdateAnnotationSettings);
            _callCreateTag = clientHelper.BuildApiCall<CreateTagRequest, Tag>(
                GrpcClient.CreateTagAsync, GrpcClient.CreateTag, effectiveSettings.CreateTagSettings);
            _callDeleteTag = clientHelper.BuildApiCall<DeleteTagRequest, pbwkt::Empty>(
                GrpcClient.DeleteTagAsync, GrpcClient.DeleteTag, effectiveSettings.DeleteTagSettings);
            _callListTags = clientHelper.BuildApiCall<ListTagsRequest, ListTagsResponse>(
                GrpcClient.ListTagsAsync, GrpcClient.ListTags, effectiveSettings.ListTagsSettings);
            _callCreateSignal = clientHelper.BuildApiCall<CreateSignalRequest, Signal>(
                GrpcClient.CreateSignalAsync, GrpcClient.CreateSignal, effectiveSettings.CreateSignalSettings);
            _callListSignals = clientHelper.BuildApiCall<ListSignalsRequest, ListSignalsResponse>(
                GrpcClient.ListSignalsAsync, GrpcClient.ListSignals, effectiveSettings.ListSignalsSettings);
            _callGetSignal = clientHelper.BuildApiCall<GetSignalRequest, Signal>(
                GrpcClient.GetSignalAsync, GrpcClient.GetSignal, effectiveSettings.GetSignalSettings);
            _callUpdateSignal = clientHelper.BuildApiCall<UpdateSignalRequest, Signal>(
                GrpcClient.UpdateSignalAsync, GrpcClient.UpdateSignal, effectiveSettings.UpdateSignalSettings);
            _callAcknowledgeSignal = clientHelper.BuildApiCall<AcknowledgeSignalRequest, AcknowledgeSignalResponse>(
                GrpcClient.AcknowledgeSignalAsync, GrpcClient.AcknowledgeSignal, effectiveSettings.AcknowledgeSignalSettings);
            _callEscalateIncident = clientHelper.BuildApiCall<EscalateIncidentRequest, EscalateIncidentResponse>(
                GrpcClient.EscalateIncidentAsync, GrpcClient.EscalateIncident, effectiveSettings.EscalateIncidentSettings);
            _callCreateArtifact = clientHelper.BuildApiCall<CreateArtifactRequest, Artifact>(
                GrpcClient.CreateArtifactAsync, GrpcClient.CreateArtifact, effectiveSettings.CreateArtifactSettings);
            _callListArtifacts = clientHelper.BuildApiCall<ListArtifactsRequest, ListArtifactsResponse>(
                GrpcClient.ListArtifactsAsync, GrpcClient.ListArtifacts, effectiveSettings.ListArtifactsSettings);
            _callUpdateArtifact = clientHelper.BuildApiCall<UpdateArtifactRequest, Artifact>(
                GrpcClient.UpdateArtifactAsync, GrpcClient.UpdateArtifact, effectiveSettings.UpdateArtifactSettings);
            _callDeleteArtifact = clientHelper.BuildApiCall<DeleteArtifactRequest, pbwkt::Empty>(
                GrpcClient.DeleteArtifactAsync, GrpcClient.DeleteArtifact, effectiveSettings.DeleteArtifactSettings);
            _callGetShiftHandoffPresets = clientHelper.BuildApiCall<GetShiftHandoffPresetsRequest, ShiftHandoffPresets>(
                GrpcClient.GetShiftHandoffPresetsAsync, GrpcClient.GetShiftHandoffPresets, effectiveSettings.GetShiftHandoffPresetsSettings);
            _callSendShiftHandoff = clientHelper.BuildApiCall<SendShiftHandoffRequest, SendShiftHandoffResponse>(
                GrpcClient.SendShiftHandoffAsync, GrpcClient.SendShiftHandoff, effectiveSettings.SendShiftHandoffSettings);
            _callCreateSubscription = clientHelper.BuildApiCall<CreateSubscriptionRequest, Subscription>(
                GrpcClient.CreateSubscriptionAsync, GrpcClient.CreateSubscription, effectiveSettings.CreateSubscriptionSettings);
            _callListSubscriptions = clientHelper.BuildApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse>(
                GrpcClient.ListSubscriptionsAsync, GrpcClient.ListSubscriptions, effectiveSettings.ListSubscriptionsSettings);
            _callDeleteSubscription = clientHelper.BuildApiCall<DeleteSubscriptionRequest, pbwkt::Empty>(
                GrpcClient.DeleteSubscriptionAsync, GrpcClient.DeleteSubscription, effectiveSettings.DeleteSubscriptionSettings);
            _callCreateIncidentRoleAssignment = clientHelper.BuildApiCall<CreateIncidentRoleAssignmentRequest, IncidentRoleAssignment>(
                GrpcClient.CreateIncidentRoleAssignmentAsync, GrpcClient.CreateIncidentRoleAssignment, effectiveSettings.CreateIncidentRoleAssignmentSettings);
            _callDeleteIncidentRoleAssignment = clientHelper.BuildApiCall<DeleteIncidentRoleAssignmentRequest, pbwkt::Empty>(
                GrpcClient.DeleteIncidentRoleAssignmentAsync, GrpcClient.DeleteIncidentRoleAssignment, effectiveSettings.DeleteIncidentRoleAssignmentSettings);
            _callListIncidentRoleAssignments = clientHelper.BuildApiCall<ListIncidentRoleAssignmentsRequest, ListIncidentRoleAssignmentsResponse>(
                GrpcClient.ListIncidentRoleAssignmentsAsync, GrpcClient.ListIncidentRoleAssignments, effectiveSettings.ListIncidentRoleAssignmentsSettings);
            _callRequestIncidentRoleHandover = clientHelper.BuildApiCall<RequestIncidentRoleHandoverRequest, IncidentRoleAssignment>(
                GrpcClient.RequestIncidentRoleHandoverAsync, GrpcClient.RequestIncidentRoleHandover, effectiveSettings.RequestIncidentRoleHandoverSettings);
            _callConfirmIncidentRoleHandover = clientHelper.BuildApiCall<ConfirmIncidentRoleHandoverRequest, IncidentRoleAssignment>(
                GrpcClient.ConfirmIncidentRoleHandoverAsync, GrpcClient.ConfirmIncidentRoleHandover, effectiveSettings.ConfirmIncidentRoleHandoverSettings);
            _callForceIncidentRoleHandover = clientHelper.BuildApiCall<ForceIncidentRoleHandoverRequest, IncidentRoleAssignment>(
                GrpcClient.ForceIncidentRoleHandoverAsync, GrpcClient.ForceIncidentRoleHandover, effectiveSettings.ForceIncidentRoleHandoverSettings);
            _callCancelIncidentRoleHandover = clientHelper.BuildApiCall<CancelIncidentRoleHandoverRequest, IncidentRoleAssignment>(
                GrpcClient.CancelIncidentRoleHandoverAsync, GrpcClient.CancelIncidentRoleHandover, effectiveSettings.CancelIncidentRoleHandoverSettings);
            Modify_ApiCall(ref _callCreateIncident);
            Modify_CreateIncidentApiCall(ref _callCreateIncident);
            Modify_ApiCall(ref _callGetIncident);
            Modify_GetIncidentApiCall(ref _callGetIncident);
            Modify_ApiCall(ref _callSearchIncidents);
            Modify_SearchIncidentsApiCall(ref _callSearchIncidents);
            Modify_ApiCall(ref _callUpdateIncident);
            Modify_UpdateIncidentApiCall(ref _callUpdateIncident);
            Modify_ApiCall(ref _callSearchSimilarIncidents);
            Modify_SearchSimilarIncidentsApiCall(ref _callSearchSimilarIncidents);
            Modify_ApiCall(ref _callCreateAnnotation);
            Modify_CreateAnnotationApiCall(ref _callCreateAnnotation);
            Modify_ApiCall(ref _callListAnnotations);
            Modify_ListAnnotationsApiCall(ref _callListAnnotations);
            Modify_ApiCall(ref _callUpdateAnnotation);
            Modify_UpdateAnnotationApiCall(ref _callUpdateAnnotation);
            Modify_ApiCall(ref _callCreateTag);
            Modify_CreateTagApiCall(ref _callCreateTag);
            Modify_ApiCall(ref _callDeleteTag);
            Modify_DeleteTagApiCall(ref _callDeleteTag);
            Modify_ApiCall(ref _callListTags);
            Modify_ListTagsApiCall(ref _callListTags);
            Modify_ApiCall(ref _callCreateSignal);
            Modify_CreateSignalApiCall(ref _callCreateSignal);
            Modify_ApiCall(ref _callListSignals);
            Modify_ListSignalsApiCall(ref _callListSignals);
            Modify_ApiCall(ref _callGetSignal);
            Modify_GetSignalApiCall(ref _callGetSignal);
            Modify_ApiCall(ref _callUpdateSignal);
            Modify_UpdateSignalApiCall(ref _callUpdateSignal);
            Modify_ApiCall(ref _callAcknowledgeSignal);
            Modify_AcknowledgeSignalApiCall(ref _callAcknowledgeSignal);
            Modify_ApiCall(ref _callEscalateIncident);
            Modify_EscalateIncidentApiCall(ref _callEscalateIncident);
            Modify_ApiCall(ref _callCreateArtifact);
            Modify_CreateArtifactApiCall(ref _callCreateArtifact);
            Modify_ApiCall(ref _callListArtifacts);
            Modify_ListArtifactsApiCall(ref _callListArtifacts);
            Modify_ApiCall(ref _callUpdateArtifact);
            Modify_UpdateArtifactApiCall(ref _callUpdateArtifact);
            Modify_ApiCall(ref _callDeleteArtifact);
            Modify_DeleteArtifactApiCall(ref _callDeleteArtifact);
            Modify_ApiCall(ref _callGetShiftHandoffPresets);
            Modify_GetShiftHandoffPresetsApiCall(ref _callGetShiftHandoffPresets);
            Modify_ApiCall(ref _callSendShiftHandoff);
            Modify_SendShiftHandoffApiCall(ref _callSendShiftHandoff);
            Modify_ApiCall(ref _callCreateSubscription);
            Modify_CreateSubscriptionApiCall(ref _callCreateSubscription);
            Modify_ApiCall(ref _callListSubscriptions);
            Modify_ListSubscriptionsApiCall(ref _callListSubscriptions);
            Modify_ApiCall(ref _callDeleteSubscription);
            Modify_DeleteSubscriptionApiCall(ref _callDeleteSubscription);
            Modify_ApiCall(ref _callCreateIncidentRoleAssignment);
            Modify_CreateIncidentRoleAssignmentApiCall(ref _callCreateIncidentRoleAssignment);
            Modify_ApiCall(ref _callDeleteIncidentRoleAssignment);
            Modify_DeleteIncidentRoleAssignmentApiCall(ref _callDeleteIncidentRoleAssignment);
            Modify_ApiCall(ref _callListIncidentRoleAssignments);
            Modify_ListIncidentRoleAssignmentsApiCall(ref _callListIncidentRoleAssignments);
            Modify_ApiCall(ref _callRequestIncidentRoleHandover);
            Modify_RequestIncidentRoleHandoverApiCall(ref _callRequestIncidentRoleHandover);
            Modify_ApiCall(ref _callConfirmIncidentRoleHandover);
            Modify_ConfirmIncidentRoleHandoverApiCall(ref _callConfirmIncidentRoleHandover);
            Modify_ApiCall(ref _callForceIncidentRoleHandover);
            Modify_ForceIncidentRoleHandoverApiCall(ref _callForceIncidentRoleHandover);
            Modify_ApiCall(ref _callCancelIncidentRoleHandover);
            Modify_CancelIncidentRoleHandoverApiCall(ref _callCancelIncidentRoleHandover);
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
        partial void Modify_CreateIncidentApiCall(ref gaxgrpc::ApiCall<CreateIncidentRequest, Incident> call);
        partial void Modify_GetIncidentApiCall(ref gaxgrpc::ApiCall<GetIncidentRequest, Incident> call);
        partial void Modify_SearchIncidentsApiCall(ref gaxgrpc::ApiCall<SearchIncidentsRequest, SearchIncidentsResponse> call);
        partial void Modify_UpdateIncidentApiCall(ref gaxgrpc::ApiCall<UpdateIncidentRequest, Incident> call);
        partial void Modify_SearchSimilarIncidentsApiCall(ref gaxgrpc::ApiCall<SearchSimilarIncidentsRequest, SearchSimilarIncidentsResponse> call);
        partial void Modify_CreateAnnotationApiCall(ref gaxgrpc::ApiCall<CreateAnnotationRequest, Annotation> call);
        partial void Modify_ListAnnotationsApiCall(ref gaxgrpc::ApiCall<ListAnnotationsRequest, ListAnnotationsResponse> call);
        partial void Modify_UpdateAnnotationApiCall(ref gaxgrpc::ApiCall<UpdateAnnotationRequest, Annotation> call);
        partial void Modify_CreateTagApiCall(ref gaxgrpc::ApiCall<CreateTagRequest, Tag> call);
        partial void Modify_DeleteTagApiCall(ref gaxgrpc::ApiCall<DeleteTagRequest, pbwkt::Empty> call);
        partial void Modify_ListTagsApiCall(ref gaxgrpc::ApiCall<ListTagsRequest, ListTagsResponse> call);
        partial void Modify_CreateSignalApiCall(ref gaxgrpc::ApiCall<CreateSignalRequest, Signal> call);
        partial void Modify_ListSignalsApiCall(ref gaxgrpc::ApiCall<ListSignalsRequest, ListSignalsResponse> call);
        partial void Modify_GetSignalApiCall(ref gaxgrpc::ApiCall<GetSignalRequest, Signal> call);
        partial void Modify_UpdateSignalApiCall(ref gaxgrpc::ApiCall<UpdateSignalRequest, Signal> call);
        partial void Modify_AcknowledgeSignalApiCall(ref gaxgrpc::ApiCall<AcknowledgeSignalRequest, AcknowledgeSignalResponse> call);
        partial void Modify_EscalateIncidentApiCall(ref gaxgrpc::ApiCall<EscalateIncidentRequest, EscalateIncidentResponse> call);
        partial void Modify_CreateArtifactApiCall(ref gaxgrpc::ApiCall<CreateArtifactRequest, Artifact> call);
        partial void Modify_ListArtifactsApiCall(ref gaxgrpc::ApiCall<ListArtifactsRequest, ListArtifactsResponse> call);
        partial void Modify_UpdateArtifactApiCall(ref gaxgrpc::ApiCall<UpdateArtifactRequest, Artifact> call);
        partial void Modify_DeleteArtifactApiCall(ref gaxgrpc::ApiCall<DeleteArtifactRequest, pbwkt::Empty> call);
        partial void Modify_GetShiftHandoffPresetsApiCall(ref gaxgrpc::ApiCall<GetShiftHandoffPresetsRequest, ShiftHandoffPresets> call);
        partial void Modify_SendShiftHandoffApiCall(ref gaxgrpc::ApiCall<SendShiftHandoffRequest, SendShiftHandoffResponse> call);
        partial void Modify_CreateSubscriptionApiCall(ref gaxgrpc::ApiCall<CreateSubscriptionRequest, Subscription> call);
        partial void Modify_ListSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> call);
        partial void Modify_DeleteSubscriptionApiCall(ref gaxgrpc::ApiCall<DeleteSubscriptionRequest, pbwkt::Empty> call);
        partial void Modify_CreateIncidentRoleAssignmentApiCall(ref gaxgrpc::ApiCall<CreateIncidentRoleAssignmentRequest, IncidentRoleAssignment> call);
        partial void Modify_DeleteIncidentRoleAssignmentApiCall(ref gaxgrpc::ApiCall<DeleteIncidentRoleAssignmentRequest, pbwkt::Empty> call);
        partial void Modify_ListIncidentRoleAssignmentsApiCall(ref gaxgrpc::ApiCall<ListIncidentRoleAssignmentsRequest, ListIncidentRoleAssignmentsResponse> call);
        partial void Modify_RequestIncidentRoleHandoverApiCall(ref gaxgrpc::ApiCall<RequestIncidentRoleHandoverRequest, IncidentRoleAssignment> call);
        partial void Modify_ConfirmIncidentRoleHandoverApiCall(ref gaxgrpc::ApiCall<ConfirmIncidentRoleHandoverRequest, IncidentRoleAssignment> call);
        partial void Modify_ForceIncidentRoleHandoverApiCall(ref gaxgrpc::ApiCall<ForceIncidentRoleHandoverRequest, IncidentRoleAssignment> call);
        partial void Modify_CancelIncidentRoleHandoverApiCall(ref gaxgrpc::ApiCall<CancelIncidentRoleHandoverRequest, IncidentRoleAssignment> call);
        partial void OnConstruction(IncidentService.IncidentServiceClient grpcClient, IncidentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC IncidentService client.
        /// </summary>
        public override IncidentService.IncidentServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateIncidentRequest(ref CreateIncidentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIncidentRequest(ref GetIncidentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchIncidentsRequest(ref SearchIncidentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateIncidentRequest(ref UpdateIncidentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchSimilarIncidentsRequest(ref SearchSimilarIncidentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateAnnotationRequest(ref CreateAnnotationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListAnnotationsRequest(ref ListAnnotationsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateAnnotationRequest(ref UpdateAnnotationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateTagRequest(ref CreateTagRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteTagRequest(ref DeleteTagRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTagsRequest(ref ListTagsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateSignalRequest(ref CreateSignalRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListSignalsRequest(ref ListSignalsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSignalRequest(ref GetSignalRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateSignalRequest(ref UpdateSignalRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_AcknowledgeSignalRequest(ref AcknowledgeSignalRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_EscalateIncidentRequest(ref EscalateIncidentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateArtifactRequest(ref CreateArtifactRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListArtifactsRequest(ref ListArtifactsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateArtifactRequest(ref UpdateArtifactRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteArtifactRequest(ref DeleteArtifactRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetShiftHandoffPresetsRequest(ref GetShiftHandoffPresetsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SendShiftHandoffRequest(ref SendShiftHandoffRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateSubscriptionRequest(ref CreateSubscriptionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListSubscriptionsRequest(ref ListSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteSubscriptionRequest(ref DeleteSubscriptionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateIncidentRoleAssignmentRequest(ref CreateIncidentRoleAssignmentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteIncidentRoleAssignmentRequest(ref DeleteIncidentRoleAssignmentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListIncidentRoleAssignmentsRequest(ref ListIncidentRoleAssignmentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RequestIncidentRoleHandoverRequest(ref RequestIncidentRoleHandoverRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ConfirmIncidentRoleHandoverRequest(ref ConfirmIncidentRoleHandoverRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ForceIncidentRoleHandoverRequest(ref ForceIncidentRoleHandoverRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CancelIncidentRoleHandoverRequest(ref CancelIncidentRoleHandoverRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new incident.
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
        public override stt::Task<Incident> CreateIncidentAsync(
            CreateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIncidentRequest(ref request, ref callSettings);
            return _callCreateIncident.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new incident.
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
        public override Incident CreateIncident(
            CreateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIncidentRequest(ref request, ref callSettings);
            return _callCreateIncident.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns an incident by name.
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
        public override stt::Task<Incident> GetIncidentAsync(
            GetIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIncidentRequest(ref request, ref callSettings);
            return _callGetIncident.Async(request, callSettings);
        }

        /// <summary>
        /// Returns an incident by name.
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
        public override Incident GetIncident(
            GetIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIncidentRequest(ref request, ref callSettings);
            return _callGetIncident.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of incidents.
        /// Incidents are ordered by start time, with the most recent incidents first.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Incident"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchIncidentsResponse, Incident> SearchIncidentsAsync(
            SearchIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchIncidentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchIncidentsRequest, SearchIncidentsResponse, Incident>(_callSearchIncidents, request, callSettings);
        }

        /// <summary>
        /// Returns a list of incidents.
        /// Incidents are ordered by start time, with the most recent incidents first.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Incident"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchIncidentsResponse, Incident> SearchIncidents(
            SearchIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchIncidentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchIncidentsRequest, SearchIncidentsResponse, Incident>(_callSearchIncidents, request, callSettings);
        }

        /// <summary>
        /// Updates an existing incident.
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
        public override stt::Task<Incident> UpdateIncidentAsync(
            UpdateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIncidentRequest(ref request, ref callSettings);
            return _callUpdateIncident.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing incident.
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
        public override Incident UpdateIncident(
            UpdateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIncidentRequest(ref request, ref callSettings);
            return _callUpdateIncident.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of incidents that are "similar" to the specified incident
        /// or signal. This functionality is provided on a best-effort basis and the
        /// definition of "similar" is subject to change.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchSimilarIncidentsResponse.Types.Result"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result> SearchSimilarIncidentsAsync(
            SearchSimilarIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchSimilarIncidentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchSimilarIncidentsRequest, SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result>(_callSearchSimilarIncidents, request, callSettings);
        }

        /// <summary>
        /// Returns a list of incidents that are "similar" to the specified incident
        /// or signal. This functionality is provided on a best-effort basis and the
        /// definition of "similar" is subject to change.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchSimilarIncidentsResponse.Types.Result"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result> SearchSimilarIncidents(
            SearchSimilarIncidentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchSimilarIncidentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchSimilarIncidentsRequest, SearchSimilarIncidentsResponse, SearchSimilarIncidentsResponse.Types.Result>(_callSearchSimilarIncidents, request, callSettings);
        }

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
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
        public override stt::Task<Annotation> CreateAnnotationAsync(
            CreateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationRequest(ref request, ref callSettings);
            return _callCreateAnnotation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an annotation on an existing incident. Only 'text/plain' and
        /// 'text/markdown' annotations can be created via this method.
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
        public override Annotation CreateAnnotation(
            CreateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationRequest(ref request, ref callSettings);
            return _callCreateAnnotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists annotations that are part of an incident. No assumptions should be
        /// made on the content-type of the annotation returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Annotation"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(
            ListAnnotationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnnotationsRequest, ListAnnotationsResponse, Annotation>(_callListAnnotations, request, callSettings);
        }

        /// <summary>
        /// Lists annotations that are part of an incident. No assumptions should be
        /// made on the content-type of the annotation returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Annotation"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(
            ListAnnotationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnnotationsRequest, ListAnnotationsResponse, Annotation>(_callListAnnotations, request, callSettings);
        }

        /// <summary>
        /// Updates an annotation on an existing incident.
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
        public override stt::Task<Annotation> UpdateAnnotationAsync(
            UpdateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnnotationRequest(ref request, ref callSettings);
            return _callUpdateAnnotation.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an annotation on an existing incident.
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
        public override Annotation UpdateAnnotation(
            UpdateAnnotationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnnotationRequest(ref request, ref callSettings);
            return _callUpdateAnnotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a tag on an existing incident.
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
        public override stt::Task<Tag> CreateTagAsync(
            CreateTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagRequest(ref request, ref callSettings);
            return _callCreateTag.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a tag on an existing incident.
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
        public override Tag CreateTag(
            CreateTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagRequest(ref request, ref callSettings);
            return _callCreateTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing tag.
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
        public override stt::Task DeleteTagAsync(
            DeleteTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagRequest(ref request, ref callSettings);
            return _callDeleteTag.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing tag.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteTag(
            DeleteTagRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagRequest(ref request, ref callSettings);
            _callDeleteTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists tags that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Tag"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(
            ListTagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTagsRequest, ListTagsResponse, Tag>(_callListTags, request, callSettings);
        }

        /// <summary>
        /// Lists tags that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Tag"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(
            ListTagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTagsRequest, ListTagsResponse, Tag>(_callListTags, request, callSettings);
        }

        /// <summary>
        /// Creates a new signal.
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
        public override stt::Task<Signal> CreateSignalAsync(
            CreateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSignalRequest(ref request, ref callSettings);
            return _callCreateSignal.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new signal.
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
        public override Signal CreateSignal(
            CreateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSignalRequest(ref request, ref callSettings);
            return _callCreateSignal.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists signals that are part of an incident.
        /// Signals are returned in reverse chronological order.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Signal"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSignalsResponse, Signal> ListSignalsAsync(
            ListSignalsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSignalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSignalsRequest, ListSignalsResponse, Signal>(_callListSignals, request, callSettings);
        }

        /// <summary>
        /// Lists signals that are part of an incident.
        /// Signals are returned in reverse chronological order.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Signal"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListSignalsResponse, Signal> ListSignals(
            ListSignalsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSignalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSignalsRequest, ListSignalsResponse, Signal>(_callListSignals, request, callSettings);
        }

        /// <summary>
        /// Returns a signal by name.
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
        public override stt::Task<Signal> GetSignalAsync(
            GetSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSignalRequest(ref request, ref callSettings);
            return _callGetSignal.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a signal by name.
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
        public override Signal GetSignal(
            GetSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSignalRequest(ref request, ref callSettings);
            return _callGetSignal.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
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
        public override stt::Task<Signal> UpdateSignalAsync(
            UpdateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSignalRequest(ref request, ref callSettings);
            return _callUpdateSignal.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing signal (e.g. to assign/unassign it to an
        /// incident).
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
        public override Signal UpdateSignal(
            UpdateSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSignalRequest(ref request, ref callSettings);
            return _callUpdateSignal.Sync(request, callSettings);
        }

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
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
        public override stt::Task<AcknowledgeSignalResponse> AcknowledgeSignalAsync(
            AcknowledgeSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcknowledgeSignalRequest(ref request, ref callSettings);
            return _callAcknowledgeSignal.Async(request, callSettings);
        }

        /// <summary>
        /// Acks a signal. This acknowledges the signal in the underlying system,
        /// indicating that the caller takes responsibility for looking into this.
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
        public override AcknowledgeSignalResponse AcknowledgeSignal(
            AcknowledgeSignalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcknowledgeSignalRequest(ref request, ref callSettings);
            return _callAcknowledgeSignal.Sync(request, callSettings);
        }

        /// <summary>
        /// Escalates an incident.
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
        public override stt::Task<EscalateIncidentResponse> EscalateIncidentAsync(
            EscalateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EscalateIncidentRequest(ref request, ref callSettings);
            return _callEscalateIncident.Async(request, callSettings);
        }

        /// <summary>
        /// Escalates an incident.
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
        public override EscalateIncidentResponse EscalateIncident(
            EscalateIncidentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EscalateIncidentRequest(ref request, ref callSettings);
            return _callEscalateIncident.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new artifact.
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
        public override stt::Task<Artifact> CreateArtifactAsync(
            CreateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateArtifactRequest(ref request, ref callSettings);
            return _callCreateArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new artifact.
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
        public override Artifact CreateArtifact(
            CreateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateArtifactRequest(ref request, ref callSettings);
            return _callCreateArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of artifacts for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Artifact"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(
            ListArtifactsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListArtifactsRequest, ListArtifactsResponse, Artifact>(_callListArtifacts, request, callSettings);
        }

        /// <summary>
        /// Returns a list of artifacts for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Artifact"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(
            ListArtifactsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListArtifactsRequest, ListArtifactsResponse, Artifact>(_callListArtifacts, request, callSettings);
        }

        /// <summary>
        /// Updates an existing artifact.
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
        public override stt::Task<Artifact> UpdateArtifactAsync(
            UpdateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateArtifactRequest(ref request, ref callSettings);
            return _callUpdateArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing artifact.
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
        public override Artifact UpdateArtifact(
            UpdateArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateArtifactRequest(ref request, ref callSettings);
            return _callUpdateArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing artifact.
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
        public override stt::Task DeleteArtifactAsync(
            DeleteArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteArtifactRequest(ref request, ref callSettings);
            return _callDeleteArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing artifact.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteArtifact(
            DeleteArtifactRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteArtifactRequest(ref request, ref callSettings);
            _callDeleteArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
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
        public override stt::Task<ShiftHandoffPresets> GetShiftHandoffPresetsAsync(
            GetShiftHandoffPresetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShiftHandoffPresetsRequest(ref request, ref callSettings);
            return _callGetShiftHandoffPresets.Async(request, callSettings);
        }

        /// <summary>
        /// Returns "presets" specific to shift handoff (see SendShiftHandoff), e.g.
        /// default values for handoff message fields.
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
        public override ShiftHandoffPresets GetShiftHandoffPresets(
            GetShiftHandoffPresetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShiftHandoffPresetsRequest(ref request, ref callSettings);
            return _callGetShiftHandoffPresets.Sync(request, callSettings);
        }

        /// <summary>
        /// Sends a summary of the shift for oncall handoff.
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
        public override stt::Task<SendShiftHandoffResponse> SendShiftHandoffAsync(
            SendShiftHandoffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendShiftHandoffRequest(ref request, ref callSettings);
            return _callSendShiftHandoff.Async(request, callSettings);
        }

        /// <summary>
        /// Sends a summary of the shift for oncall handoff.
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
        public override SendShiftHandoffResponse SendShiftHandoff(
            SendShiftHandoffRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendShiftHandoffRequest(ref request, ref callSettings);
            return _callSendShiftHandoff.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
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
        public override stt::Task<Subscription> CreateSubscriptionAsync(
            CreateSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriptionRequest(ref request, ref callSettings);
            return _callCreateSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new subscription.
        /// This will fail if:
        ///    a. there are too many (50) subscriptions in the incident already
        ///    b. a subscription using the given channel already exists
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
        public override Subscription CreateSubscription(
            CreateSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriptionRequest(ref request, ref callSettings);
            return _callCreateSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of subscriptions for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Returns a list of subscriptions for an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Deletes an existing subscription.
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
        public override stt::Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            return _callDeleteSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing subscription.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteSubscription(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            _callDeleteSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
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
        public override stt::Task<IncidentRoleAssignment> CreateIncidentRoleAssignmentAsync(
            CreateIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIncidentRoleAssignmentRequest(ref request, ref callSettings);
            return _callCreateIncidentRoleAssignment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a role assignment on an existing incident. Normally, the user field
        /// will be set when assigning a role to oneself, and the next field will be
        /// set when proposing another user as the assignee. Setting the next field
        /// directly to a user other than oneself is equivalent to proposing and
        /// force-assigning the role to the user.
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
        public override IncidentRoleAssignment CreateIncidentRoleAssignment(
            CreateIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIncidentRoleAssignmentRequest(ref request, ref callSettings);
            return _callCreateIncidentRoleAssignment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing role assignment.
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
        public override stt::Task DeleteIncidentRoleAssignmentAsync(
            DeleteIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIncidentRoleAssignmentRequest(ref request, ref callSettings);
            return _callDeleteIncidentRoleAssignment.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing role assignment.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteIncidentRoleAssignment(
            DeleteIncidentRoleAssignmentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIncidentRoleAssignmentRequest(ref request, ref callSettings);
            _callDeleteIncidentRoleAssignment.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists role assignments that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="IncidentRoleAssignment"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> ListIncidentRoleAssignmentsAsync(
            ListIncidentRoleAssignmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIncidentRoleAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIncidentRoleAssignmentsRequest, ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment>(_callListIncidentRoleAssignments, request, callSettings);
        }

        /// <summary>
        /// Lists role assignments that are part of an incident.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="IncidentRoleAssignment"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> ListIncidentRoleAssignments(
            ListIncidentRoleAssignmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIncidentRoleAssignmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIncidentRoleAssignmentsRequest, ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment>(_callListIncidentRoleAssignments, request, callSettings);
        }

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
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
        public override stt::Task<IncidentRoleAssignment> RequestIncidentRoleHandoverAsync(
            RequestIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callRequestIncidentRoleHandover.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a role handover. The proposed assignee will receive an email
        /// notifying them of the assignment. This will fail if a role handover is
        /// already pending.
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
        public override IncidentRoleAssignment RequestIncidentRoleHandover(
            RequestIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callRequestIncidentRoleHandover.Sync(request, callSettings);
        }

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
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
        public override stt::Task<IncidentRoleAssignment> ConfirmIncidentRoleHandoverAsync(
            ConfirmIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfirmIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callConfirmIncidentRoleHandover.Async(request, callSettings);
        }

        /// <summary>
        /// Confirms a role handover. This will fail if the 'proposed_assignee' field
        /// of the IncidentRoleAssignment is not equal to the 'new_assignee' field of
        /// the request. If the caller is not the new_assignee,
        /// ForceIncidentRoleHandover should be used instead.
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
        public override IncidentRoleAssignment ConfirmIncidentRoleHandover(
            ConfirmIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfirmIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callConfirmIncidentRoleHandover.Sync(request, callSettings);
        }

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
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
        public override stt::Task<IncidentRoleAssignment> ForceIncidentRoleHandoverAsync(
            ForceIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ForceIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callForceIncidentRoleHandover.Async(request, callSettings);
        }

        /// <summary>
        /// Forces a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request. If the caller is the new_assignee, ConfirmIncidentRoleHandover
        /// should be used instead.
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
        public override IncidentRoleAssignment ForceIncidentRoleHandover(
            ForceIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ForceIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callForceIncidentRoleHandover.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
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
        public override stt::Task<IncidentRoleAssignment> CancelIncidentRoleHandoverAsync(
            CancelIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callCancelIncidentRoleHandover.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels a role handover. This will fail if the 'proposed_assignee' field of
        /// the IncidentRoleAssignment is not equal to the 'new_assignee' field of the
        /// request.
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
        public override IncidentRoleAssignment CancelIncidentRoleHandover(
            CancelIncidentRoleHandoverRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelIncidentRoleHandoverRequest(ref request, ref callSettings);
            return _callCancelIncidentRoleHandover.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class SearchIncidentsRequest : gaxgrpc::IPageRequest { }
    public partial class SearchIncidentsResponse : gaxgrpc::IPageResponse<Incident>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Incident> GetEnumerator() => Incidents.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchSimilarIncidentsRequest : gaxgrpc::IPageRequest { }
    public partial class SearchSimilarIncidentsResponse : gaxgrpc::IPageResponse<SearchSimilarIncidentsResponse.Types.Result>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<SearchSimilarIncidentsResponse.Types.Result> GetEnumerator() => Results.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnnotationsRequest : gaxgrpc::IPageRequest { }
    public partial class ListAnnotationsResponse : gaxgrpc::IPageResponse<Annotation>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Annotation> GetEnumerator() => Annotations.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTagsRequest : gaxgrpc::IPageRequest { }
    public partial class ListTagsResponse : gaxgrpc::IPageResponse<Tag>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Tag> GetEnumerator() => Tags.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSignalsRequest : gaxgrpc::IPageRequest { }
    public partial class ListSignalsResponse : gaxgrpc::IPageResponse<Signal>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Signal> GetEnumerator() => Signals.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListArtifactsRequest : gaxgrpc::IPageRequest { }
    public partial class ListArtifactsResponse : gaxgrpc::IPageResponse<Artifact>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Artifact> GetEnumerator() => Artifacts.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSubscriptionsRequest : gaxgrpc::IPageRequest { }
    public partial class ListSubscriptionsResponse : gaxgrpc::IPageResponse<Subscription>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Subscription> GetEnumerator() => Subscriptions.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListIncidentRoleAssignmentsRequest : gaxgrpc::IPageRequest { }
    public partial class ListIncidentRoleAssignmentsResponse : gaxgrpc::IPageResponse<IncidentRoleAssignment>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<IncidentRoleAssignment> GetEnumerator() => IncidentRoleAssignments.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
