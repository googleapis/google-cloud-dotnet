// Copyright 2020 Google LLC
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

namespace Google.Cloud.Dlp.V2
{
    /// <summary>
    /// Settings for a <see cref="DlpServiceClient"/>.
    /// </summary>
    public sealed partial class DlpServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DlpServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DlpServiceSettings"/>.
        /// </returns>
        public static DlpServiceSettings GetDefault() => new DlpServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DlpServiceSettings"/> object with default settings.
        /// </summary>
        public DlpServiceSettings() { }

        private DlpServiceSettings(DlpServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InspectContentSettings = existing.InspectContentSettings;
            RedactImageSettings = existing.RedactImageSettings;
            DeidentifyContentSettings = existing.DeidentifyContentSettings;
            ReidentifyContentSettings = existing.ReidentifyContentSettings;
            ListInfoTypesSettings = existing.ListInfoTypesSettings;
            CreateInspectTemplateSettings = existing.CreateInspectTemplateSettings;
            UpdateInspectTemplateSettings = existing.UpdateInspectTemplateSettings;
            GetInspectTemplateSettings = existing.GetInspectTemplateSettings;
            ListInspectTemplatesSettings = existing.ListInspectTemplatesSettings;
            DeleteInspectTemplateSettings = existing.DeleteInspectTemplateSettings;
            CreateDeidentifyTemplateSettings = existing.CreateDeidentifyTemplateSettings;
            UpdateDeidentifyTemplateSettings = existing.UpdateDeidentifyTemplateSettings;
            GetDeidentifyTemplateSettings = existing.GetDeidentifyTemplateSettings;
            ListDeidentifyTemplatesSettings = existing.ListDeidentifyTemplatesSettings;
            DeleteDeidentifyTemplateSettings = existing.DeleteDeidentifyTemplateSettings;
            CreateDlpJobSettings = existing.CreateDlpJobSettings;
            ListDlpJobsSettings = existing.ListDlpJobsSettings;
            GetDlpJobSettings = existing.GetDlpJobSettings;
            DeleteDlpJobSettings = existing.DeleteDlpJobSettings;
            CancelDlpJobSettings = existing.CancelDlpJobSettings;
            ListJobTriggersSettings = existing.ListJobTriggersSettings;
            GetJobTriggerSettings = existing.GetJobTriggerSettings;
            DeleteJobTriggerSettings = existing.DeleteJobTriggerSettings;
            UpdateJobTriggerSettings = existing.UpdateJobTriggerSettings;
            CreateJobTriggerSettings = existing.CreateJobTriggerSettings;
            CreateStoredInfoTypeSettings = existing.CreateStoredInfoTypeSettings;
            UpdateStoredInfoTypeSettings = existing.UpdateStoredInfoTypeSettings;
            GetStoredInfoTypeSettings = existing.GetStoredInfoTypeSettings;
            ListStoredInfoTypesSettings = existing.ListStoredInfoTypesSettings;
            DeleteStoredInfoTypeSettings = existing.DeleteStoredInfoTypeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DlpServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DlpServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DlpServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DlpServiceClient"/> RPC methods is defined as:
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
        /// <c>DlpServiceClient.InspectContent</c> and <c>DlpServiceClient.InspectContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.InspectContent</c> and
        /// <c>DlpServiceClient.InspectContentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings InspectContentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.RedactImage</c> and <c>DlpServiceClient.RedactImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.RedactImage</c> and
        /// <c>DlpServiceClient.RedactImageAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RedactImageSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeidentifyContent</c> and <c>DlpServiceClient.DeidentifyContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeidentifyContent</c> and
        /// <c>DlpServiceClient.DeidentifyContentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeidentifyContentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ReidentifyContent</c> and <c>DlpServiceClient.ReidentifyContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ReidentifyContent</c> and
        /// <c>DlpServiceClient.ReidentifyContentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ReidentifyContentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInfoTypes</c> and <c>DlpServiceClient.ListInfoTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListInfoTypes</c> and
        /// <c>DlpServiceClient.ListInfoTypesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListInfoTypesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateInspectTemplate</c> and <c>DlpServiceClient.CreateInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateInspectTemplate</c> and
        /// <c>DlpServiceClient.CreateInspectTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateInspectTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateInspectTemplate</c> and <c>DlpServiceClient.UpdateInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.UpdateInspectTemplate</c> and
        /// <c>DlpServiceClient.UpdateInspectTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateInspectTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetInspectTemplate</c> and <c>DlpServiceClient.GetInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetInspectTemplate</c> and
        /// <c>DlpServiceClient.GetInspectTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetInspectTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInspectTemplates</c> and <c>DlpServiceClient.ListInspectTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListInspectTemplates</c> and
        /// <c>DlpServiceClient.ListInspectTemplatesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListInspectTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteInspectTemplate</c> and <c>DlpServiceClient.DeleteInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteInspectTemplate</c> and
        /// <c>DlpServiceClient.DeleteInspectTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteInspectTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateDeidentifyTemplate</c> and <c>DlpServiceClient.CreateDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.CreateDeidentifyTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateDeidentifyTemplate</c> and <c>DlpServiceClient.UpdateDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.UpdateDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.UpdateDeidentifyTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetDeidentifyTemplate</c> and <c>DlpServiceClient.GetDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.GetDeidentifyTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListDeidentifyTemplates</c> and <c>DlpServiceClient.ListDeidentifyTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListDeidentifyTemplates</c> and
        /// <c>DlpServiceClient.ListDeidentifyTemplatesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListDeidentifyTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteDeidentifyTemplate</c> and <c>DlpServiceClient.DeleteDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.DeleteDeidentifyTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateDlpJob</c> and <c>DlpServiceClient.CreateDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateDlpJob</c> and
        /// <c>DlpServiceClient.CreateDlpJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListDlpJobs</c> and <c>DlpServiceClient.ListDlpJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListDlpJobs</c> and
        /// <c>DlpServiceClient.ListDlpJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListDlpJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetDlpJob</c> and <c>DlpServiceClient.GetDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetDlpJob</c> and
        /// <c>DlpServiceClient.GetDlpJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteDlpJob</c> and <c>DlpServiceClient.DeleteDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteDlpJob</c> and
        /// <c>DlpServiceClient.DeleteDlpJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CancelDlpJob</c> and <c>DlpServiceClient.CancelDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CancelDlpJob</c> and
        /// <c>DlpServiceClient.CancelDlpJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CancelDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListJobTriggers</c> and <c>DlpServiceClient.ListJobTriggersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListJobTriggers</c> and
        /// <c>DlpServiceClient.ListJobTriggersAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListJobTriggersSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetJobTrigger</c> and <c>DlpServiceClient.GetJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetJobTrigger</c> and
        /// <c>DlpServiceClient.GetJobTriggerAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteJobTrigger</c> and <c>DlpServiceClient.DeleteJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteJobTrigger</c> and
        /// <c>DlpServiceClient.DeleteJobTriggerAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateJobTrigger</c> and <c>DlpServiceClient.UpdateJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.UpdateJobTrigger</c> and
        /// <c>DlpServiceClient.UpdateJobTriggerAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateJobTrigger</c> and <c>DlpServiceClient.CreateJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateJobTrigger</c> and
        /// <c>DlpServiceClient.CreateJobTriggerAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateStoredInfoType</c> and <c>DlpServiceClient.CreateStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateStoredInfoType</c> and
        /// <c>DlpServiceClient.CreateStoredInfoTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateStoredInfoType</c> and <c>DlpServiceClient.UpdateStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.UpdateStoredInfoType</c> and
        /// <c>DlpServiceClient.UpdateStoredInfoTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetStoredInfoType</c> and <c>DlpServiceClient.GetStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetStoredInfoType</c> and
        /// <c>DlpServiceClient.GetStoredInfoTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListStoredInfoTypes</c> and <c>DlpServiceClient.ListStoredInfoTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListStoredInfoTypes</c> and
        /// <c>DlpServiceClient.ListStoredInfoTypesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListStoredInfoTypesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteStoredInfoType</c> and <c>DlpServiceClient.DeleteStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteStoredInfoType</c> and
        /// <c>DlpServiceClient.DeleteStoredInfoTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DlpServiceSettings"/> object.</returns>
        public DlpServiceSettings Clone() => new DlpServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DlpServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DlpServiceClientBuilder : gaxgrpc::ClientBuilderBase<DlpServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DlpServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override DlpServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DlpServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<DlpServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DlpServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => DlpServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DlpServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => DlpServiceClient.ChannelPool;
    }

    /// <summary>
    /// DlpService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DlpServiceClient
    {
        /// <summary>
        /// The default endpoint for the DlpService service, which is a host of "dlp.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dlp.googleapis.com", 443);

        /// <summary>
        /// The default DlpService scopes.
        /// </summary>
        /// <remarks>
        /// The default DlpService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="DlpServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dlp.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DlpServiceClient client = await DlpServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dlp.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DlpServiceClient.DefaultEndpoint.Host, DlpServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DlpServiceClient client = DlpServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DlpServiceClient"/>.</returns>
        public static async stt::Task<DlpServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, DlpServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DlpServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dlp.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DlpServiceClient client = DlpServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dlp.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DlpServiceClient.DefaultEndpoint.Host, DlpServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DlpServiceClient client = DlpServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, DlpServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DlpServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create(grpccore::Channel channel, DlpServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="DlpServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create(grpccore::CallInvoker callInvoker, DlpServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DlpService.DlpServiceClient grpcClient = new DlpService.DlpServiceClient(callInvoker);
            return new DlpServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, DlpServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DlpServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, DlpServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DlpServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DlpService client.
        /// </summary>
        public virtual DlpService.DlpServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        ///
        /// For how to guides, see https://cloud.google.com/dlp/docs/inspecting-images
        /// and https://cloud.google.com/dlp/docs/inspecting-text,
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
        public virtual stt::Task<InspectContentResponse> InspectContentAsync(
            InspectContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        ///
        /// For how to guides, see https://cloud.google.com/dlp/docs/inspecting-images
        /// and https://cloud.google.com/dlp/docs/inspecting-text,
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
        public virtual stt::Task<InspectContentResponse> InspectContentAsync(
            InspectContentRequest request,
            st::CancellationToken cancellationToken) => InspectContentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        ///
        /// For how to guides, see https://cloud.google.com/dlp/docs/inspecting-images
        /// and https://cloud.google.com/dlp/docs/inspecting-text,
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
        public virtual InspectContentResponse InspectContent(
            InspectContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual stt::Task<RedactImageResponse> RedactImageAsync(
            RedactImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual stt::Task<RedactImageResponse> RedactImageAsync(
            RedactImageRequest request,
            st::CancellationToken cancellationToken) => RedactImageAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual RedactImageResponse RedactImage(
            RedactImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual stt::Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual stt::Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyContentRequest request,
            st::CancellationToken cancellationToken) => DeidentifyContentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual DeidentifyContentResponse DeidentifyContent(
            DeidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
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
        public virtual stt::Task<ReidentifyContentResponse> ReidentifyContentAsync(
            ReidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
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
        public virtual stt::Task<ReidentifyContentResponse> ReidentifyContentAsync(
            ReidentifyContentRequest request,
            st::CancellationToken cancellationToken) => ReidentifyContentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
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
        public virtual ReidentifyContentResponse ReidentifyContent(
            ReidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of the sensitive information types that the DLP API
        /// supports. See https://cloud.google.com/dlp/docs/infotypes-reference to
        /// learn more.
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
        public virtual stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(
            ListInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of the sensitive information types that the DLP API
        /// supports. See https://cloud.google.com/dlp/docs/infotypes-reference to
        /// learn more.
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
        public virtual stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(
            ListInfoTypesRequest request,
            st::CancellationToken cancellationToken) => ListInfoTypesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the sensitive information types that the DLP API
        /// supports. See https://cloud.google.com/dlp/docs/infotypes-reference to
        /// learn more.
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
        public virtual ListInfoTypesResponse ListInfoTypes(
            ListInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an InspectTemplate for re-using frequently used configuration
        /// for inspecting content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(
            CreateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an InspectTemplate for re-using frequently used configuration
        /// for inspecting content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(
            CreateInspectTemplateRequest request,
            st::CancellationToken cancellationToken) => CreateInspectTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an InspectTemplate for re-using frequently used configuration
        /// for inspecting content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual InspectTemplate CreateInspectTemplate(
            CreateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(
            UpdateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(
            UpdateInspectTemplateRequest request,
            st::CancellationToken cancellationToken) => UpdateInspectTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual InspectTemplate UpdateInspectTemplate(
            UpdateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(
            GetInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(
            GetInspectTemplateRequest request,
            st::CancellationToken cancellationToken) => GetInspectTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual InspectTemplate GetInspectTemplate(
            GetInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(
            ListInspectTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="InspectTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(
            ListInspectTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task DeleteInspectTemplateAsync(
            DeleteInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public virtual stt::Task DeleteInspectTemplateAsync(
            DeleteInspectTemplateRequest request,
            st::CancellationToken cancellationToken) => DeleteInspectTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteInspectTemplate(
            DeleteInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a DeidentifyTemplate for re-using frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(
            CreateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a DeidentifyTemplate for re-using frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(
            CreateDeidentifyTemplateRequest request,
            st::CancellationToken cancellationToken) => CreateDeidentifyTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeidentifyTemplate for re-using frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual DeidentifyTemplate CreateDeidentifyTemplate(
            CreateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(
            UpdateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(
            UpdateDeidentifyTemplateRequest request,
            st::CancellationToken cancellationToken) => UpdateDeidentifyTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual DeidentifyTemplate UpdateDeidentifyTemplate(
            UpdateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(
            GetDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(
            GetDeidentifyTemplateRequest request,
            st::CancellationToken cancellationToken) => GetDeidentifyTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual DeidentifyTemplate GetDeidentifyTemplate(
            GetDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(
            ListDeidentifyTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DeidentifyTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(
            ListDeidentifyTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task DeleteDeidentifyTemplateAsync(
            DeleteDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public virtual stt::Task DeleteDeidentifyTemplateAsync(
            DeleteDeidentifyTemplateRequest request,
            st::CancellationToken cancellationToken) => DeleteDeidentifyTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDeidentifyTemplate(
            DeleteDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(
            CreateDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(
            CreateDlpJobRequest request,
            st::CancellationToken cancellationToken) => CreateDlpJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public virtual DlpJob CreateDlpJob(
            CreateDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DlpJob"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(
            ListDlpJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DlpJob"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(
            ListDlpJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public virtual stt::Task<DlpJob> GetDlpJobAsync(
            GetDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public virtual stt::Task<DlpJob> GetDlpJobAsync(
            GetDlpJobRequest request,
            st::CancellationToken cancellationToken) => GetDlpJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public virtual DlpJob GetDlpJob(
            GetDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public virtual stt::Task DeleteDlpJobAsync(
            DeleteDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public virtual stt::Task DeleteDlpJobAsync(
            DeleteDlpJobRequest request,
            st::CancellationToken cancellationToken) => DeleteDlpJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDlpJob(
            DeleteDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public virtual stt::Task CancelDlpJobAsync(
            CancelDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public virtual stt::Task CancelDlpJobAsync(
            CancelDlpJobRequest request,
            st::CancellationToken cancellationToken) => CancelDlpJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void CancelDlpJob(
            CancelDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists job triggers.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="JobTrigger"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(
            ListJobTriggersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists job triggers.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="JobTrigger"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(
            ListJobTriggersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(
            GetJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(
            GetJobTriggerRequest request,
            st::CancellationToken cancellationToken) => GetJobTriggerAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual JobTrigger GetJobTrigger(
            GetJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task DeleteJobTriggerAsync(
            DeleteJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task DeleteJobTriggerAsync(
            DeleteJobTriggerRequest request,
            st::CancellationToken cancellationToken) => DeleteJobTriggerAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteJobTrigger(
            DeleteJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(
            UpdateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(
            UpdateJobTriggerRequest request,
            st::CancellationToken cancellationToken) => UpdateJobTriggerAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual JobTrigger UpdateJobTrigger(
            UpdateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(
            CreateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(
            CreateJobTriggerRequest request,
            st::CancellationToken cancellationToken) => CreateJobTriggerAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public virtual JobTrigger CreateJobTrigger(
            CreateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(
            CreateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(
            CreateStoredInfoTypeRequest request,
            st::CancellationToken cancellationToken) => CreateStoredInfoTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual StoredInfoType CreateStoredInfoType(
            CreateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(
            UpdateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(
            UpdateStoredInfoTypeRequest request,
            st::CancellationToken cancellationToken) => UpdateStoredInfoTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual StoredInfoType UpdateStoredInfoType(
            UpdateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(
            GetStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(
            GetStoredInfoTypeRequest request,
            st::CancellationToken cancellationToken) => GetStoredInfoTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual StoredInfoType GetStoredInfoType(
            GetStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(
            ListStoredInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="StoredInfoType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(
            ListStoredInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task DeleteStoredInfoTypeAsync(
            DeleteStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public virtual stt::Task DeleteStoredInfoTypeAsync(
            DeleteStoredInfoTypeRequest request,
            st::CancellationToken cancellationToken) => DeleteStoredInfoTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteStoredInfoType(
            DeleteStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// DlpService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DlpServiceClientImpl : DlpServiceClient
    {
        private readonly gaxgrpc::ApiCall<InspectContentRequest, InspectContentResponse> _callInspectContent;
        private readonly gaxgrpc::ApiCall<RedactImageRequest, RedactImageResponse> _callRedactImage;
        private readonly gaxgrpc::ApiCall<DeidentifyContentRequest, DeidentifyContentResponse> _callDeidentifyContent;
        private readonly gaxgrpc::ApiCall<ReidentifyContentRequest, ReidentifyContentResponse> _callReidentifyContent;
        private readonly gaxgrpc::ApiCall<ListInfoTypesRequest, ListInfoTypesResponse> _callListInfoTypes;
        private readonly gaxgrpc::ApiCall<CreateInspectTemplateRequest, InspectTemplate> _callCreateInspectTemplate;
        private readonly gaxgrpc::ApiCall<UpdateInspectTemplateRequest, InspectTemplate> _callUpdateInspectTemplate;
        private readonly gaxgrpc::ApiCall<GetInspectTemplateRequest, InspectTemplate> _callGetInspectTemplate;
        private readonly gaxgrpc::ApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse> _callListInspectTemplates;
        private readonly gaxgrpc::ApiCall<DeleteInspectTemplateRequest, pbwkt::Empty> _callDeleteInspectTemplate;
        private readonly gaxgrpc::ApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate> _callCreateDeidentifyTemplate;
        private readonly gaxgrpc::ApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate> _callUpdateDeidentifyTemplate;
        private readonly gaxgrpc::ApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate> _callGetDeidentifyTemplate;
        private readonly gaxgrpc::ApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse> _callListDeidentifyTemplates;
        private readonly gaxgrpc::ApiCall<DeleteDeidentifyTemplateRequest, pbwkt::Empty> _callDeleteDeidentifyTemplate;
        private readonly gaxgrpc::ApiCall<CreateDlpJobRequest, DlpJob> _callCreateDlpJob;
        private readonly gaxgrpc::ApiCall<ListDlpJobsRequest, ListDlpJobsResponse> _callListDlpJobs;
        private readonly gaxgrpc::ApiCall<GetDlpJobRequest, DlpJob> _callGetDlpJob;
        private readonly gaxgrpc::ApiCall<DeleteDlpJobRequest, pbwkt::Empty> _callDeleteDlpJob;
        private readonly gaxgrpc::ApiCall<CancelDlpJobRequest, pbwkt::Empty> _callCancelDlpJob;
        private readonly gaxgrpc::ApiCall<ListJobTriggersRequest, ListJobTriggersResponse> _callListJobTriggers;
        private readonly gaxgrpc::ApiCall<GetJobTriggerRequest, JobTrigger> _callGetJobTrigger;
        private readonly gaxgrpc::ApiCall<DeleteJobTriggerRequest, pbwkt::Empty> _callDeleteJobTrigger;
        private readonly gaxgrpc::ApiCall<UpdateJobTriggerRequest, JobTrigger> _callUpdateJobTrigger;
        private readonly gaxgrpc::ApiCall<CreateJobTriggerRequest, JobTrigger> _callCreateJobTrigger;
        private readonly gaxgrpc::ApiCall<CreateStoredInfoTypeRequest, StoredInfoType> _callCreateStoredInfoType;
        private readonly gaxgrpc::ApiCall<UpdateStoredInfoTypeRequest, StoredInfoType> _callUpdateStoredInfoType;
        private readonly gaxgrpc::ApiCall<GetStoredInfoTypeRequest, StoredInfoType> _callGetStoredInfoType;
        private readonly gaxgrpc::ApiCall<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse> _callListStoredInfoTypes;
        private readonly gaxgrpc::ApiCall<DeleteStoredInfoTypeRequest, pbwkt::Empty> _callDeleteStoredInfoType;

        /// <summary>
        /// Constructs a client wrapper for the DlpService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DlpServiceSettings"/> used within this client </param>
        public DlpServiceClientImpl(DlpService.DlpServiceClient grpcClient, DlpServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DlpServiceSettings effectiveSettings = settings ?? DlpServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callInspectContent = clientHelper.BuildApiCall<InspectContentRequest, InspectContentResponse>(
                GrpcClient.InspectContentAsync, GrpcClient.InspectContent, effectiveSettings.InspectContentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callRedactImage = clientHelper.BuildApiCall<RedactImageRequest, RedactImageResponse>(
                GrpcClient.RedactImageAsync, GrpcClient.RedactImage, effectiveSettings.RedactImageSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeidentifyContent = clientHelper.BuildApiCall<DeidentifyContentRequest, DeidentifyContentResponse>(
                GrpcClient.DeidentifyContentAsync, GrpcClient.DeidentifyContent, effectiveSettings.DeidentifyContentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callReidentifyContent = clientHelper.BuildApiCall<ReidentifyContentRequest, ReidentifyContentResponse>(
                GrpcClient.ReidentifyContentAsync, GrpcClient.ReidentifyContent, effectiveSettings.ReidentifyContentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callListInfoTypes = clientHelper.BuildApiCall<ListInfoTypesRequest, ListInfoTypesResponse>(
                GrpcClient.ListInfoTypesAsync, GrpcClient.ListInfoTypes, effectiveSettings.ListInfoTypesSettings)
                .WithGoogleRequestParam("location_id", request => request.LocationId);
            _callCreateInspectTemplate = clientHelper.BuildApiCall<CreateInspectTemplateRequest, InspectTemplate>(
                GrpcClient.CreateInspectTemplateAsync, GrpcClient.CreateInspectTemplate, effectiveSettings.CreateInspectTemplateSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateInspectTemplate = clientHelper.BuildApiCall<UpdateInspectTemplateRequest, InspectTemplate>(
                GrpcClient.UpdateInspectTemplateAsync, GrpcClient.UpdateInspectTemplate, effectiveSettings.UpdateInspectTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetInspectTemplate = clientHelper.BuildApiCall<GetInspectTemplateRequest, InspectTemplate>(
                GrpcClient.GetInspectTemplateAsync, GrpcClient.GetInspectTemplate, effectiveSettings.GetInspectTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListInspectTemplates = clientHelper.BuildApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse>(
                GrpcClient.ListInspectTemplatesAsync, GrpcClient.ListInspectTemplates, effectiveSettings.ListInspectTemplatesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteInspectTemplate = clientHelper.BuildApiCall<DeleteInspectTemplateRequest, pbwkt::Empty>(
                GrpcClient.DeleteInspectTemplateAsync, GrpcClient.DeleteInspectTemplate, effectiveSettings.DeleteInspectTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateDeidentifyTemplate = clientHelper.BuildApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate>(
                GrpcClient.CreateDeidentifyTemplateAsync, GrpcClient.CreateDeidentifyTemplate, effectiveSettings.CreateDeidentifyTemplateSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateDeidentifyTemplate = clientHelper.BuildApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate>(
                GrpcClient.UpdateDeidentifyTemplateAsync, GrpcClient.UpdateDeidentifyTemplate, effectiveSettings.UpdateDeidentifyTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetDeidentifyTemplate = clientHelper.BuildApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate>(
                GrpcClient.GetDeidentifyTemplateAsync, GrpcClient.GetDeidentifyTemplate, effectiveSettings.GetDeidentifyTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListDeidentifyTemplates = clientHelper.BuildApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse>(
                GrpcClient.ListDeidentifyTemplatesAsync, GrpcClient.ListDeidentifyTemplates, effectiveSettings.ListDeidentifyTemplatesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteDeidentifyTemplate = clientHelper.BuildApiCall<DeleteDeidentifyTemplateRequest, pbwkt::Empty>(
                GrpcClient.DeleteDeidentifyTemplateAsync, GrpcClient.DeleteDeidentifyTemplate, effectiveSettings.DeleteDeidentifyTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateDlpJob = clientHelper.BuildApiCall<CreateDlpJobRequest, DlpJob>(
                GrpcClient.CreateDlpJobAsync, GrpcClient.CreateDlpJob, effectiveSettings.CreateDlpJobSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callListDlpJobs = clientHelper.BuildApiCall<ListDlpJobsRequest, ListDlpJobsResponse>(
                GrpcClient.ListDlpJobsAsync, GrpcClient.ListDlpJobs, effectiveSettings.ListDlpJobsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetDlpJob = clientHelper.BuildApiCall<GetDlpJobRequest, DlpJob>(
                GrpcClient.GetDlpJobAsync, GrpcClient.GetDlpJob, effectiveSettings.GetDlpJobSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteDlpJob = clientHelper.BuildApiCall<DeleteDlpJobRequest, pbwkt::Empty>(
                GrpcClient.DeleteDlpJobAsync, GrpcClient.DeleteDlpJob, effectiveSettings.DeleteDlpJobSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCancelDlpJob = clientHelper.BuildApiCall<CancelDlpJobRequest, pbwkt::Empty>(
                GrpcClient.CancelDlpJobAsync, GrpcClient.CancelDlpJob, effectiveSettings.CancelDlpJobSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListJobTriggers = clientHelper.BuildApiCall<ListJobTriggersRequest, ListJobTriggersResponse>(
                GrpcClient.ListJobTriggersAsync, GrpcClient.ListJobTriggers, effectiveSettings.ListJobTriggersSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetJobTrigger = clientHelper.BuildApiCall<GetJobTriggerRequest, JobTrigger>(
                GrpcClient.GetJobTriggerAsync, GrpcClient.GetJobTrigger, effectiveSettings.GetJobTriggerSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteJobTrigger = clientHelper.BuildApiCall<DeleteJobTriggerRequest, pbwkt::Empty>(
                GrpcClient.DeleteJobTriggerAsync, GrpcClient.DeleteJobTrigger, effectiveSettings.DeleteJobTriggerSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callUpdateJobTrigger = clientHelper.BuildApiCall<UpdateJobTriggerRequest, JobTrigger>(
                GrpcClient.UpdateJobTriggerAsync, GrpcClient.UpdateJobTrigger, effectiveSettings.UpdateJobTriggerSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateJobTrigger = clientHelper.BuildApiCall<CreateJobTriggerRequest, JobTrigger>(
                GrpcClient.CreateJobTriggerAsync, GrpcClient.CreateJobTrigger, effectiveSettings.CreateJobTriggerSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callCreateStoredInfoType = clientHelper.BuildApiCall<CreateStoredInfoTypeRequest, StoredInfoType>(
                GrpcClient.CreateStoredInfoTypeAsync, GrpcClient.CreateStoredInfoType, effectiveSettings.CreateStoredInfoTypeSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateStoredInfoType = clientHelper.BuildApiCall<UpdateStoredInfoTypeRequest, StoredInfoType>(
                GrpcClient.UpdateStoredInfoTypeAsync, GrpcClient.UpdateStoredInfoType, effectiveSettings.UpdateStoredInfoTypeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetStoredInfoType = clientHelper.BuildApiCall<GetStoredInfoTypeRequest, StoredInfoType>(
                GrpcClient.GetStoredInfoTypeAsync, GrpcClient.GetStoredInfoType, effectiveSettings.GetStoredInfoTypeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListStoredInfoTypes = clientHelper.BuildApiCall<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse>(
                GrpcClient.ListStoredInfoTypesAsync, GrpcClient.ListStoredInfoTypes, effectiveSettings.ListStoredInfoTypesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteStoredInfoType = clientHelper.BuildApiCall<DeleteStoredInfoTypeRequest, pbwkt::Empty>(
                GrpcClient.DeleteStoredInfoTypeAsync, GrpcClient.DeleteStoredInfoType, effectiveSettings.DeleteStoredInfoTypeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callInspectContent);
            Modify_InspectContentApiCall(ref _callInspectContent);
            Modify_ApiCall(ref _callRedactImage);
            Modify_RedactImageApiCall(ref _callRedactImage);
            Modify_ApiCall(ref _callDeidentifyContent);
            Modify_DeidentifyContentApiCall(ref _callDeidentifyContent);
            Modify_ApiCall(ref _callReidentifyContent);
            Modify_ReidentifyContentApiCall(ref _callReidentifyContent);
            Modify_ApiCall(ref _callListInfoTypes);
            Modify_ListInfoTypesApiCall(ref _callListInfoTypes);
            Modify_ApiCall(ref _callCreateInspectTemplate);
            Modify_CreateInspectTemplateApiCall(ref _callCreateInspectTemplate);
            Modify_ApiCall(ref _callUpdateInspectTemplate);
            Modify_UpdateInspectTemplateApiCall(ref _callUpdateInspectTemplate);
            Modify_ApiCall(ref _callGetInspectTemplate);
            Modify_GetInspectTemplateApiCall(ref _callGetInspectTemplate);
            Modify_ApiCall(ref _callListInspectTemplates);
            Modify_ListInspectTemplatesApiCall(ref _callListInspectTemplates);
            Modify_ApiCall(ref _callDeleteInspectTemplate);
            Modify_DeleteInspectTemplateApiCall(ref _callDeleteInspectTemplate);
            Modify_ApiCall(ref _callCreateDeidentifyTemplate);
            Modify_CreateDeidentifyTemplateApiCall(ref _callCreateDeidentifyTemplate);
            Modify_ApiCall(ref _callUpdateDeidentifyTemplate);
            Modify_UpdateDeidentifyTemplateApiCall(ref _callUpdateDeidentifyTemplate);
            Modify_ApiCall(ref _callGetDeidentifyTemplate);
            Modify_GetDeidentifyTemplateApiCall(ref _callGetDeidentifyTemplate);
            Modify_ApiCall(ref _callListDeidentifyTemplates);
            Modify_ListDeidentifyTemplatesApiCall(ref _callListDeidentifyTemplates);
            Modify_ApiCall(ref _callDeleteDeidentifyTemplate);
            Modify_DeleteDeidentifyTemplateApiCall(ref _callDeleteDeidentifyTemplate);
            Modify_ApiCall(ref _callCreateDlpJob);
            Modify_CreateDlpJobApiCall(ref _callCreateDlpJob);
            Modify_ApiCall(ref _callListDlpJobs);
            Modify_ListDlpJobsApiCall(ref _callListDlpJobs);
            Modify_ApiCall(ref _callGetDlpJob);
            Modify_GetDlpJobApiCall(ref _callGetDlpJob);
            Modify_ApiCall(ref _callDeleteDlpJob);
            Modify_DeleteDlpJobApiCall(ref _callDeleteDlpJob);
            Modify_ApiCall(ref _callCancelDlpJob);
            Modify_CancelDlpJobApiCall(ref _callCancelDlpJob);
            Modify_ApiCall(ref _callListJobTriggers);
            Modify_ListJobTriggersApiCall(ref _callListJobTriggers);
            Modify_ApiCall(ref _callGetJobTrigger);
            Modify_GetJobTriggerApiCall(ref _callGetJobTrigger);
            Modify_ApiCall(ref _callDeleteJobTrigger);
            Modify_DeleteJobTriggerApiCall(ref _callDeleteJobTrigger);
            Modify_ApiCall(ref _callUpdateJobTrigger);
            Modify_UpdateJobTriggerApiCall(ref _callUpdateJobTrigger);
            Modify_ApiCall(ref _callCreateJobTrigger);
            Modify_CreateJobTriggerApiCall(ref _callCreateJobTrigger);
            Modify_ApiCall(ref _callCreateStoredInfoType);
            Modify_CreateStoredInfoTypeApiCall(ref _callCreateStoredInfoType);
            Modify_ApiCall(ref _callUpdateStoredInfoType);
            Modify_UpdateStoredInfoTypeApiCall(ref _callUpdateStoredInfoType);
            Modify_ApiCall(ref _callGetStoredInfoType);
            Modify_GetStoredInfoTypeApiCall(ref _callGetStoredInfoType);
            Modify_ApiCall(ref _callListStoredInfoTypes);
            Modify_ListStoredInfoTypesApiCall(ref _callListStoredInfoTypes);
            Modify_ApiCall(ref _callDeleteStoredInfoType);
            Modify_DeleteStoredInfoTypeApiCall(ref _callDeleteStoredInfoType);
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
        partial void Modify_InspectContentApiCall(ref gaxgrpc::ApiCall<InspectContentRequest, InspectContentResponse> call);
        partial void Modify_RedactImageApiCall(ref gaxgrpc::ApiCall<RedactImageRequest, RedactImageResponse> call);
        partial void Modify_DeidentifyContentApiCall(ref gaxgrpc::ApiCall<DeidentifyContentRequest, DeidentifyContentResponse> call);
        partial void Modify_ReidentifyContentApiCall(ref gaxgrpc::ApiCall<ReidentifyContentRequest, ReidentifyContentResponse> call);
        partial void Modify_ListInfoTypesApiCall(ref gaxgrpc::ApiCall<ListInfoTypesRequest, ListInfoTypesResponse> call);
        partial void Modify_CreateInspectTemplateApiCall(ref gaxgrpc::ApiCall<CreateInspectTemplateRequest, InspectTemplate> call);
        partial void Modify_UpdateInspectTemplateApiCall(ref gaxgrpc::ApiCall<UpdateInspectTemplateRequest, InspectTemplate> call);
        partial void Modify_GetInspectTemplateApiCall(ref gaxgrpc::ApiCall<GetInspectTemplateRequest, InspectTemplate> call);
        partial void Modify_ListInspectTemplatesApiCall(ref gaxgrpc::ApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse> call);
        partial void Modify_DeleteInspectTemplateApiCall(ref gaxgrpc::ApiCall<DeleteInspectTemplateRequest, pbwkt::Empty> call);
        partial void Modify_CreateDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate> call);
        partial void Modify_UpdateDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate> call);
        partial void Modify_GetDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate> call);
        partial void Modify_ListDeidentifyTemplatesApiCall(ref gaxgrpc::ApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse> call);
        partial void Modify_DeleteDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<DeleteDeidentifyTemplateRequest, pbwkt::Empty> call);
        partial void Modify_CreateDlpJobApiCall(ref gaxgrpc::ApiCall<CreateDlpJobRequest, DlpJob> call);
        partial void Modify_ListDlpJobsApiCall(ref gaxgrpc::ApiCall<ListDlpJobsRequest, ListDlpJobsResponse> call);
        partial void Modify_GetDlpJobApiCall(ref gaxgrpc::ApiCall<GetDlpJobRequest, DlpJob> call);
        partial void Modify_DeleteDlpJobApiCall(ref gaxgrpc::ApiCall<DeleteDlpJobRequest, pbwkt::Empty> call);
        partial void Modify_CancelDlpJobApiCall(ref gaxgrpc::ApiCall<CancelDlpJobRequest, pbwkt::Empty> call);
        partial void Modify_ListJobTriggersApiCall(ref gaxgrpc::ApiCall<ListJobTriggersRequest, ListJobTriggersResponse> call);
        partial void Modify_GetJobTriggerApiCall(ref gaxgrpc::ApiCall<GetJobTriggerRequest, JobTrigger> call);
        partial void Modify_DeleteJobTriggerApiCall(ref gaxgrpc::ApiCall<DeleteJobTriggerRequest, pbwkt::Empty> call);
        partial void Modify_UpdateJobTriggerApiCall(ref gaxgrpc::ApiCall<UpdateJobTriggerRequest, JobTrigger> call);
        partial void Modify_CreateJobTriggerApiCall(ref gaxgrpc::ApiCall<CreateJobTriggerRequest, JobTrigger> call);
        partial void Modify_CreateStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<CreateStoredInfoTypeRequest, StoredInfoType> call);
        partial void Modify_UpdateStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<UpdateStoredInfoTypeRequest, StoredInfoType> call);
        partial void Modify_GetStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<GetStoredInfoTypeRequest, StoredInfoType> call);
        partial void Modify_ListStoredInfoTypesApiCall(ref gaxgrpc::ApiCall<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse> call);
        partial void Modify_DeleteStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<DeleteStoredInfoTypeRequest, pbwkt::Empty> call);
        partial void OnConstruction(DlpService.DlpServiceClient grpcClient, DlpServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DlpService client.
        /// </summary>
        public override DlpService.DlpServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_InspectContentRequest(ref InspectContentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RedactImageRequest(ref RedactImageRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeidentifyContentRequest(ref DeidentifyContentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ReidentifyContentRequest(ref ReidentifyContentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListInfoTypesRequest(ref ListInfoTypesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateInspectTemplateRequest(ref CreateInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateInspectTemplateRequest(ref UpdateInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetInspectTemplateRequest(ref GetInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListInspectTemplatesRequest(ref ListInspectTemplatesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteInspectTemplateRequest(ref DeleteInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateDeidentifyTemplateRequest(ref CreateDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateDeidentifyTemplateRequest(ref UpdateDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetDeidentifyTemplateRequest(ref GetDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListDeidentifyTemplatesRequest(ref ListDeidentifyTemplatesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteDeidentifyTemplateRequest(ref DeleteDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateDlpJobRequest(ref CreateDlpJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListDlpJobsRequest(ref ListDlpJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetDlpJobRequest(ref GetDlpJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteDlpJobRequest(ref DeleteDlpJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CancelDlpJobRequest(ref CancelDlpJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListJobTriggersRequest(ref ListJobTriggersRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetJobTriggerRequest(ref GetJobTriggerRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteJobTriggerRequest(ref DeleteJobTriggerRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateJobTriggerRequest(ref UpdateJobTriggerRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateJobTriggerRequest(ref CreateJobTriggerRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateStoredInfoTypeRequest(ref CreateStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateStoredInfoTypeRequest(ref UpdateStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetStoredInfoTypeRequest(ref GetStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListStoredInfoTypesRequest(ref ListStoredInfoTypesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteStoredInfoTypeRequest(ref DeleteStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        ///
        /// For how to guides, see https://cloud.google.com/dlp/docs/inspecting-images
        /// and https://cloud.google.com/dlp/docs/inspecting-text,
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
        public override stt::Task<InspectContentResponse> InspectContentAsync(
            InspectContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Async(request, callSettings);
        }

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        ///
        /// For how to guides, see https://cloud.google.com/dlp/docs/inspecting-images
        /// and https://cloud.google.com/dlp/docs/inspecting-text,
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
        public override InspectContentResponse InspectContent(
            InspectContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public override stt::Task<RedactImageResponse> RedactImageAsync(
            RedactImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RedactImageRequest(ref request, ref callSettings);
            return _callRedactImage.Async(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public override RedactImageResponse RedactImage(
            RedactImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RedactImageRequest(ref request, ref callSettings);
            return _callRedactImage.Sync(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public override stt::Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Async(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to
        /// learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public override DeidentifyContentResponse DeidentifyContent(
            DeidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
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
        public override stt::Task<ReidentifyContentResponse> ReidentifyContentAsync(
            ReidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReidentifyContentRequest(ref request, ref callSettings);
            return _callReidentifyContent.Async(request, callSettings);
        }

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
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
        public override ReidentifyContentResponse ReidentifyContent(
            ReidentifyContentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReidentifyContentRequest(ref request, ref callSettings);
            return _callReidentifyContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the sensitive information types that the DLP API
        /// supports. See https://cloud.google.com/dlp/docs/infotypes-reference to
        /// learn more.
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
        public override stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(
            ListInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the sensitive information types that the DLP API
        /// supports. See https://cloud.google.com/dlp/docs/infotypes-reference to
        /// learn more.
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
        public override ListInfoTypesResponse ListInfoTypes(
            ListInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an InspectTemplate for re-using frequently used configuration
        /// for inspecting content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public override stt::Task<InspectTemplate> CreateInspectTemplateAsync(
            CreateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInspectTemplateRequest(ref request, ref callSettings);
            return _callCreateInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an InspectTemplate for re-using frequently used configuration
        /// for inspecting content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public override InspectTemplate CreateInspectTemplate(
            CreateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInspectTemplateRequest(ref request, ref callSettings);
            return _callCreateInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public override stt::Task<InspectTemplate> UpdateInspectTemplateAsync(
            UpdateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInspectTemplateRequest(ref request, ref callSettings);
            return _callUpdateInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public override InspectTemplate UpdateInspectTemplate(
            UpdateInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInspectTemplateRequest(ref request, ref callSettings);
            return _callUpdateInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public override stt::Task<InspectTemplate> GetInspectTemplateAsync(
            GetInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInspectTemplateRequest(ref request, ref callSettings);
            return _callGetInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public override InspectTemplate GetInspectTemplate(
            GetInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInspectTemplateRequest(ref request, ref callSettings);
            return _callGetInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(
            ListInspectTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInspectTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInspectTemplatesRequest, ListInspectTemplatesResponse, InspectTemplate>(_callListInspectTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="InspectTemplate"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(
            ListInspectTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInspectTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInspectTemplatesRequest, ListInspectTemplatesResponse, InspectTemplate>(_callListInspectTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
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
        public override stt::Task DeleteInspectTemplateAsync(
            DeleteInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInspectTemplateRequest(ref request, ref callSettings);
            return _callDeleteInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteInspectTemplate(
            DeleteInspectTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInspectTemplateRequest(ref request, ref callSettings);
            _callDeleteInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a DeidentifyTemplate for re-using frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public override stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(
            CreateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callCreateDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a DeidentifyTemplate for re-using frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public override DeidentifyTemplate CreateDeidentifyTemplate(
            CreateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callCreateDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public override stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(
            UpdateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callUpdateDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public override DeidentifyTemplate UpdateDeidentifyTemplate(
            UpdateDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callUpdateDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public override stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(
            GetDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callGetDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public override DeidentifyTemplate GetDeidentifyTemplate(
            GetDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callGetDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(
            ListDeidentifyTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeidentifyTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse, DeidentifyTemplate>(_callListDeidentifyTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DeidentifyTemplate"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(
            ListDeidentifyTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeidentifyTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse, DeidentifyTemplate>(_callListDeidentifyTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
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
        public override stt::Task DeleteDeidentifyTemplateAsync(
            DeleteDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callDeleteDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
        /// more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteDeidentifyTemplate(
            DeleteDeidentifyTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeidentifyTemplateRequest(ref request, ref callSettings);
            _callDeleteDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public override stt::Task<DlpJob> CreateDlpJobAsync(
            CreateDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDlpJobRequest(ref request, ref callSettings);
            return _callCreateDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        ///
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
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
        public override DlpJob CreateDlpJob(
            CreateDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDlpJobRequest(ref request, ref callSettings);
            return _callCreateDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DlpJob"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(
            ListDlpJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDlpJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDlpJobsRequest, ListDlpJobsResponse, DlpJob>(_callListDlpJobs, request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DlpJob"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(
            ListDlpJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDlpJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDlpJobsRequest, ListDlpJobsResponse, DlpJob>(_callListDlpJobs, request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public override stt::Task<DlpJob> GetDlpJobAsync(
            GetDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDlpJobRequest(ref request, ref callSettings);
            return _callGetDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public override DlpJob GetDlpJob(
            GetDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDlpJobRequest(ref request, ref callSettings);
            return _callGetDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public override stt::Task DeleteDlpJobAsync(
            DeleteDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDlpJobRequest(ref request, ref callSettings);
            return _callDeleteDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteDlpJob(
            DeleteDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDlpJobRequest(ref request, ref callSettings);
            _callDeleteDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
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
        public override stt::Task CancelDlpJobAsync(
            CancelDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDlpJobRequest(ref request, ref callSettings);
            return _callCancelDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See https://cloud.google.com/dlp/docs/inspecting-storage and
        /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void CancelDlpJob(
            CancelDlpJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDlpJobRequest(ref request, ref callSettings);
            _callCancelDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="JobTrigger"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(
            ListJobTriggersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobTriggersRequest, ListJobTriggersResponse, JobTrigger>(_callListJobTriggers, request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="JobTrigger"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(
            ListJobTriggersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobTriggersRequest, ListJobTriggersResponse, JobTrigger>(_callListJobTriggers, request, callSettings);
        }

        /// <summary>
        /// Gets a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public override stt::Task<JobTrigger> GetJobTriggerAsync(
            GetJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobTriggerRequest(ref request, ref callSettings);
            return _callGetJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public override JobTrigger GetJobTrigger(
            GetJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobTriggerRequest(ref request, ref callSettings);
            return _callGetJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public override stt::Task DeleteJobTriggerAsync(
            DeleteJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobTriggerRequest(ref request, ref callSettings);
            return _callDeleteJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteJobTrigger(
            DeleteJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobTriggerRequest(ref request, ref callSettings);
            _callDeleteJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public override stt::Task<JobTrigger> UpdateJobTriggerAsync(
            UpdateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobTriggerRequest(ref request, ref callSettings);
            return _callUpdateJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a job trigger.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public override JobTrigger UpdateJobTrigger(
            UpdateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobTriggerRequest(ref request, ref callSettings);
            return _callUpdateJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public override stt::Task<JobTrigger> CreateJobTriggerAsync(
            CreateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobTriggerRequest(ref request, ref callSettings);
            return _callCreateJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
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
        public override JobTrigger CreateJobTrigger(
            CreateJobTriggerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobTriggerRequest(ref request, ref callSettings);
            return _callCreateJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public override stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(
            CreateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callCreateStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public override StoredInfoType CreateStoredInfoType(
            CreateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callCreateStoredInfoType.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public override stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(
            UpdateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callUpdateStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public override StoredInfoType UpdateStoredInfoType(
            UpdateStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callUpdateStoredInfoType.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public override stt::Task<StoredInfoType> GetStoredInfoTypeAsync(
            GetStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoredInfoTypeRequest(ref request, ref callSettings);
            return _callGetStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public override StoredInfoType GetStoredInfoType(
            GetStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoredInfoTypeRequest(ref request, ref callSettings);
            return _callGetStoredInfoType.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(
            ListStoredInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoredInfoTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse, StoredInfoType>(_callListStoredInfoTypes, request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="StoredInfoType"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(
            ListStoredInfoTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoredInfoTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse, StoredInfoType>(_callListStoredInfoTypes, request, callSettings);
        }

        /// <summary>
        /// Deletes a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
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
        public override stt::Task DeleteStoredInfoTypeAsync(
            DeleteStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoredInfoTypeRequest(ref request, ref callSettings);
            return _callDeleteStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a stored infoType.
        /// See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
        /// learn more.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteStoredInfoType(
            DeleteStoredInfoTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoredInfoTypeRequest(ref request, ref callSettings);
            _callDeleteStoredInfoType.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListInspectTemplatesRequest : gaxgrpc::IPageRequest { }
    public partial class ListInspectTemplatesResponse : gaxgrpc::IPageResponse<InspectTemplate>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<InspectTemplate> GetEnumerator() => InspectTemplates.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeidentifyTemplatesRequest : gaxgrpc::IPageRequest { }
    public partial class ListDeidentifyTemplatesResponse : gaxgrpc::IPageResponse<DeidentifyTemplate>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<DeidentifyTemplate> GetEnumerator() => DeidentifyTemplates.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDlpJobsRequest : gaxgrpc::IPageRequest { }
    public partial class ListDlpJobsResponse : gaxgrpc::IPageResponse<DlpJob>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<DlpJob> GetEnumerator() => Jobs.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListJobTriggersRequest : gaxgrpc::IPageRequest { }
    public partial class ListJobTriggersResponse : gaxgrpc::IPageResponse<JobTrigger>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<JobTrigger> GetEnumerator() => JobTriggers.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListStoredInfoTypesRequest : gaxgrpc::IPageRequest { }
    public partial class ListStoredInfoTypesResponse : gaxgrpc::IPageResponse<StoredInfoType>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<StoredInfoType> GetEnumerator() => StoredInfoTypes.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
