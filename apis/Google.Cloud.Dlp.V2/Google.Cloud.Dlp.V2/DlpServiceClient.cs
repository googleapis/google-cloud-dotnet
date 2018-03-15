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

namespace Google.Cloud.Dlp.V2
{
    /// <summary>
    /// Settings for a <see cref="DlpServiceClient"/>.
    /// </summary>
    public sealed partial class DlpServiceSettings : ServiceSettingsBase
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
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
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
            OnCopy(existing);
        }

        partial void OnCopy(DlpServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DlpServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

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
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
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
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.InspectContent</c> and <c>DlpServiceClient.InspectContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.InspectContent</c> and
        /// <c>DlpServiceClient.InspectContentAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings InspectContentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.RedactImage</c> and <c>DlpServiceClient.RedactImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.RedactImage</c> and
        /// <c>DlpServiceClient.RedactImageAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings RedactImageSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeidentifyContent</c> and <c>DlpServiceClient.DeidentifyContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeidentifyContent</c> and
        /// <c>DlpServiceClient.DeidentifyContentAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeidentifyContentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ReidentifyContent</c> and <c>DlpServiceClient.ReidentifyContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ReidentifyContent</c> and
        /// <c>DlpServiceClient.ReidentifyContentAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ReidentifyContentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInfoTypes</c> and <c>DlpServiceClient.ListInfoTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListInfoTypes</c> and
        /// <c>DlpServiceClient.ListInfoTypesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListInfoTypesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateInspectTemplate</c> and <c>DlpServiceClient.CreateInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateInspectTemplate</c> and
        /// <c>DlpServiceClient.CreateInspectTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateInspectTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateInspectTemplate</c> and <c>DlpServiceClient.UpdateInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.UpdateInspectTemplate</c> and
        /// <c>DlpServiceClient.UpdateInspectTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateInspectTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetInspectTemplate</c> and <c>DlpServiceClient.GetInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetInspectTemplate</c> and
        /// <c>DlpServiceClient.GetInspectTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetInspectTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInspectTemplates</c> and <c>DlpServiceClient.ListInspectTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListInspectTemplates</c> and
        /// <c>DlpServiceClient.ListInspectTemplatesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListInspectTemplatesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteInspectTemplate</c> and <c>DlpServiceClient.DeleteInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteInspectTemplate</c> and
        /// <c>DlpServiceClient.DeleteInspectTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteInspectTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateDeidentifyTemplate</c> and <c>DlpServiceClient.CreateDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.CreateDeidentifyTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateDeidentifyTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateDeidentifyTemplate</c> and <c>DlpServiceClient.UpdateDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.UpdateDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.UpdateDeidentifyTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateDeidentifyTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetDeidentifyTemplate</c> and <c>DlpServiceClient.GetDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.GetDeidentifyTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetDeidentifyTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListDeidentifyTemplates</c> and <c>DlpServiceClient.ListDeidentifyTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListDeidentifyTemplates</c> and
        /// <c>DlpServiceClient.ListDeidentifyTemplatesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListDeidentifyTemplatesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteDeidentifyTemplate</c> and <c>DlpServiceClient.DeleteDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteDeidentifyTemplate</c> and
        /// <c>DlpServiceClient.DeleteDeidentifyTemplateAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteDeidentifyTemplateSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateDlpJob</c> and <c>DlpServiceClient.CreateDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateDlpJob</c> and
        /// <c>DlpServiceClient.CreateDlpJobAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateDlpJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListDlpJobs</c> and <c>DlpServiceClient.ListDlpJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListDlpJobs</c> and
        /// <c>DlpServiceClient.ListDlpJobsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListDlpJobsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetDlpJob</c> and <c>DlpServiceClient.GetDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetDlpJob</c> and
        /// <c>DlpServiceClient.GetDlpJobAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetDlpJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteDlpJob</c> and <c>DlpServiceClient.DeleteDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteDlpJob</c> and
        /// <c>DlpServiceClient.DeleteDlpJobAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteDlpJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CancelDlpJob</c> and <c>DlpServiceClient.CancelDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CancelDlpJob</c> and
        /// <c>DlpServiceClient.CancelDlpJobAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CancelDlpJobSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListJobTriggers</c> and <c>DlpServiceClient.ListJobTriggersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListJobTriggers</c> and
        /// <c>DlpServiceClient.ListJobTriggersAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListJobTriggersSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetJobTrigger</c> and <c>DlpServiceClient.GetJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.GetJobTrigger</c> and
        /// <c>DlpServiceClient.GetJobTriggerAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetJobTriggerSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteJobTrigger</c> and <c>DlpServiceClient.DeleteJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeleteJobTrigger</c> and
        /// <c>DlpServiceClient.DeleteJobTriggerAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteJobTriggerSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateJobTrigger</c> and <c>DlpServiceClient.UpdateJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.UpdateJobTrigger</c> and
        /// <c>DlpServiceClient.UpdateJobTriggerAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateJobTriggerSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateJobTrigger</c> and <c>DlpServiceClient.CreateJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateJobTrigger</c> and
        /// <c>DlpServiceClient.CreateJobTriggerAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateJobTriggerSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DlpServiceSettings"/> object.</returns>
        public DlpServiceSettings Clone() => new DlpServiceSettings(this);
    }

    /// <summary>
    /// DlpService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DlpServiceClient
    {
        /// <summary>
        /// The default endpoint for the DlpService service, which is a host of "dlp.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("dlp.googleapis.com", 443);

        /// <summary>
        /// The default DlpService scopes.
        /// </summary>
        /// <remarks>
        /// The default DlpService scopes are:
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
        /// Asynchronously creates a <see cref="DlpServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DlpServiceClient"/>.</returns>
        public static async Task<DlpServiceClient> CreateAsync(ServiceEndpoint endpoint = null, DlpServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DlpServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create(ServiceEndpoint endpoint = null, DlpServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DlpServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create(Channel channel, DlpServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            DlpService.DlpServiceClient grpcClient = new DlpService.DlpServiceClient(channel);
            return new DlpServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, DlpServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DlpServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, DlpServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DlpServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DlpService client.
        /// </summary>
        public virtual DlpService.DlpServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide for text](/dlp/docs/inspecting-text), [How-to guide for
        /// images](/dlp/docs/inspecting-images)
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
        public virtual Task<InspectContentResponse> InspectContentAsync(
            InspectContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide for text](/dlp/docs/inspecting-text), [How-to guide for
        /// images](/dlp/docs/inspecting-images)
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide](/dlp/docs/redacting-sensitive-data-images)
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
        public virtual Task<RedactImageResponse> RedactImageAsync(
            RedactImageRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide](/dlp/docs/redacting-sensitive-data-images)
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// [How-to guide](/dlp/docs/deidentify-sensitive-data)
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
        public virtual Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// [How-to guide](/dlp/docs/deidentify-sensitive-data)
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Re-identify content that has been de-identified.
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
        public virtual Task<ReidentifyContentResponse> ReidentifyContentAsync(
            ReidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Re-identify content that has been de-identified.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns sensitive information types DLP supports.
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
        public virtual Task<ListInfoTypesResponse> ListInfoTypesAsync(
            ListInfoTypesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns sensitive information types DLP supports.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an inspect template for re-using frequently used configuration
        /// for inspecting content, images, and storage.
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
        public virtual Task<InspectTemplate> CreateInspectTemplateAsync(
            CreateInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an inspect template for re-using frequently used configuration
        /// for inspecting content, images, and storage.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the inspect template.
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
        public virtual Task<InspectTemplate> UpdateInspectTemplateAsync(
            UpdateInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the inspect template.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an inspect template.
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
        public virtual Task<InspectTemplate> GetInspectTemplateAsync(
            GetInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an inspect template.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists inspect templates.
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
        public virtual PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(
            ListInspectTemplatesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists inspect templates.
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
        public virtual PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(
            ListInspectTemplatesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes inspect templates.
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
        public virtual Task DeleteInspectTemplateAsync(
            DeleteInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes inspect templates.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteInspectTemplate(
            DeleteInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an Deidentify template for re-using frequently used configuration
        /// for Deidentifying content, images, and storage.
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
        public virtual Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(
            CreateDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an Deidentify template for re-using frequently used configuration
        /// for Deidentifying content, images, and storage.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the inspect template.
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
        public virtual Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(
            UpdateDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the inspect template.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an inspect template.
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
        public virtual Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(
            GetDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an inspect template.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists inspect templates.
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
        public virtual PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(
            ListDeidentifyTemplatesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists inspect templates.
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
        public virtual PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(
            ListDeidentifyTemplatesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes inspect templates.
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
        public virtual Task DeleteDeidentifyTemplateAsync(
            DeleteDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes inspect templates.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDeidentifyTemplate(
            DeleteDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new job to inspect storage or calculate risk metrics [How-to
        /// guide](/dlp/docs/compute-risk-analysis).
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
        public virtual Task<DlpJob> CreateDlpJobAsync(
            CreateDlpJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new job to inspect storage or calculate risk metrics [How-to
        /// guide](/dlp/docs/compute-risk-analysis).
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
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
        public virtual PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(
            ListDlpJobsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
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
        public virtual PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(
            ListDlpJobsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
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
        public virtual Task<DlpJob> GetDlpJobAsync(
            GetDlpJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
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
        public virtual Task DeleteDlpJobAsync(
            DeleteDlpJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDlpJob(
            DeleteDlpJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob.  The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
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
        public virtual Task CancelDlpJobAsync(
            CancelDlpJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob.  The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void CancelDlpJob(
            CancelDlpJobRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists job triggers.
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
        public virtual PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(
            ListJobTriggersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists job triggers.
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
        public virtual PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(
            ListJobTriggersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a job trigger.
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
        public virtual Task<JobTrigger> GetJobTriggerAsync(
            GetJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a job trigger.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a job trigger.
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
        public virtual Task DeleteJobTriggerAsync(
            DeleteJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a job trigger.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteJobTrigger(
            DeleteJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a job trigger.
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
        public virtual Task<JobTrigger> UpdateJobTriggerAsync(
            UpdateJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a job trigger.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a job to run DLP actions such as scanning storage for sensitive
        /// information on a set schedule.
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
        public virtual Task<JobTrigger> CreateJobTriggerAsync(
            CreateJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a job to run DLP actions such as scanning storage for sensitive
        /// information on a set schedule.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// DlpService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DlpServiceClientImpl : DlpServiceClient
    {
        private readonly ApiCall<InspectContentRequest, InspectContentResponse> _callInspectContent;
        private readonly ApiCall<RedactImageRequest, RedactImageResponse> _callRedactImage;
        private readonly ApiCall<DeidentifyContentRequest, DeidentifyContentResponse> _callDeidentifyContent;
        private readonly ApiCall<ReidentifyContentRequest, ReidentifyContentResponse> _callReidentifyContent;
        private readonly ApiCall<ListInfoTypesRequest, ListInfoTypesResponse> _callListInfoTypes;
        private readonly ApiCall<CreateInspectTemplateRequest, InspectTemplate> _callCreateInspectTemplate;
        private readonly ApiCall<UpdateInspectTemplateRequest, InspectTemplate> _callUpdateInspectTemplate;
        private readonly ApiCall<GetInspectTemplateRequest, InspectTemplate> _callGetInspectTemplate;
        private readonly ApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse> _callListInspectTemplates;
        private readonly ApiCall<DeleteInspectTemplateRequest, Empty> _callDeleteInspectTemplate;
        private readonly ApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate> _callCreateDeidentifyTemplate;
        private readonly ApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate> _callUpdateDeidentifyTemplate;
        private readonly ApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate> _callGetDeidentifyTemplate;
        private readonly ApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse> _callListDeidentifyTemplates;
        private readonly ApiCall<DeleteDeidentifyTemplateRequest, Empty> _callDeleteDeidentifyTemplate;
        private readonly ApiCall<CreateDlpJobRequest, DlpJob> _callCreateDlpJob;
        private readonly ApiCall<ListDlpJobsRequest, ListDlpJobsResponse> _callListDlpJobs;
        private readonly ApiCall<GetDlpJobRequest, DlpJob> _callGetDlpJob;
        private readonly ApiCall<DeleteDlpJobRequest, Empty> _callDeleteDlpJob;
        private readonly ApiCall<CancelDlpJobRequest, Empty> _callCancelDlpJob;
        private readonly ApiCall<ListJobTriggersRequest, ListJobTriggersResponse> _callListJobTriggers;
        private readonly ApiCall<GetJobTriggerRequest, JobTrigger> _callGetJobTrigger;
        private readonly ApiCall<DeleteJobTriggerRequest, Empty> _callDeleteJobTrigger;
        private readonly ApiCall<UpdateJobTriggerRequest, JobTrigger> _callUpdateJobTrigger;
        private readonly ApiCall<CreateJobTriggerRequest, JobTrigger> _callCreateJobTrigger;

        /// <summary>
        /// Constructs a client wrapper for the DlpService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DlpServiceSettings"/> used within this client </param>
        public DlpServiceClientImpl(DlpService.DlpServiceClient grpcClient, DlpServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DlpServiceSettings effectiveSettings = settings ?? DlpServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callInspectContent = clientHelper.BuildApiCall<InspectContentRequest, InspectContentResponse>(
                GrpcClient.InspectContentAsync, GrpcClient.InspectContent, effectiveSettings.InspectContentSettings);
            _callRedactImage = clientHelper.BuildApiCall<RedactImageRequest, RedactImageResponse>(
                GrpcClient.RedactImageAsync, GrpcClient.RedactImage, effectiveSettings.RedactImageSettings);
            _callDeidentifyContent = clientHelper.BuildApiCall<DeidentifyContentRequest, DeidentifyContentResponse>(
                GrpcClient.DeidentifyContentAsync, GrpcClient.DeidentifyContent, effectiveSettings.DeidentifyContentSettings);
            _callReidentifyContent = clientHelper.BuildApiCall<ReidentifyContentRequest, ReidentifyContentResponse>(
                GrpcClient.ReidentifyContentAsync, GrpcClient.ReidentifyContent, effectiveSettings.ReidentifyContentSettings);
            _callListInfoTypes = clientHelper.BuildApiCall<ListInfoTypesRequest, ListInfoTypesResponse>(
                GrpcClient.ListInfoTypesAsync, GrpcClient.ListInfoTypes, effectiveSettings.ListInfoTypesSettings);
            _callCreateInspectTemplate = clientHelper.BuildApiCall<CreateInspectTemplateRequest, InspectTemplate>(
                GrpcClient.CreateInspectTemplateAsync, GrpcClient.CreateInspectTemplate, effectiveSettings.CreateInspectTemplateSettings);
            _callUpdateInspectTemplate = clientHelper.BuildApiCall<UpdateInspectTemplateRequest, InspectTemplate>(
                GrpcClient.UpdateInspectTemplateAsync, GrpcClient.UpdateInspectTemplate, effectiveSettings.UpdateInspectTemplateSettings);
            _callGetInspectTemplate = clientHelper.BuildApiCall<GetInspectTemplateRequest, InspectTemplate>(
                GrpcClient.GetInspectTemplateAsync, GrpcClient.GetInspectTemplate, effectiveSettings.GetInspectTemplateSettings);
            _callListInspectTemplates = clientHelper.BuildApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse>(
                GrpcClient.ListInspectTemplatesAsync, GrpcClient.ListInspectTemplates, effectiveSettings.ListInspectTemplatesSettings);
            _callDeleteInspectTemplate = clientHelper.BuildApiCall<DeleteInspectTemplateRequest, Empty>(
                GrpcClient.DeleteInspectTemplateAsync, GrpcClient.DeleteInspectTemplate, effectiveSettings.DeleteInspectTemplateSettings);
            _callCreateDeidentifyTemplate = clientHelper.BuildApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate>(
                GrpcClient.CreateDeidentifyTemplateAsync, GrpcClient.CreateDeidentifyTemplate, effectiveSettings.CreateDeidentifyTemplateSettings);
            _callUpdateDeidentifyTemplate = clientHelper.BuildApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate>(
                GrpcClient.UpdateDeidentifyTemplateAsync, GrpcClient.UpdateDeidentifyTemplate, effectiveSettings.UpdateDeidentifyTemplateSettings);
            _callGetDeidentifyTemplate = clientHelper.BuildApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate>(
                GrpcClient.GetDeidentifyTemplateAsync, GrpcClient.GetDeidentifyTemplate, effectiveSettings.GetDeidentifyTemplateSettings);
            _callListDeidentifyTemplates = clientHelper.BuildApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse>(
                GrpcClient.ListDeidentifyTemplatesAsync, GrpcClient.ListDeidentifyTemplates, effectiveSettings.ListDeidentifyTemplatesSettings);
            _callDeleteDeidentifyTemplate = clientHelper.BuildApiCall<DeleteDeidentifyTemplateRequest, Empty>(
                GrpcClient.DeleteDeidentifyTemplateAsync, GrpcClient.DeleteDeidentifyTemplate, effectiveSettings.DeleteDeidentifyTemplateSettings);
            _callCreateDlpJob = clientHelper.BuildApiCall<CreateDlpJobRequest, DlpJob>(
                GrpcClient.CreateDlpJobAsync, GrpcClient.CreateDlpJob, effectiveSettings.CreateDlpJobSettings);
            _callListDlpJobs = clientHelper.BuildApiCall<ListDlpJobsRequest, ListDlpJobsResponse>(
                GrpcClient.ListDlpJobsAsync, GrpcClient.ListDlpJobs, effectiveSettings.ListDlpJobsSettings);
            _callGetDlpJob = clientHelper.BuildApiCall<GetDlpJobRequest, DlpJob>(
                GrpcClient.GetDlpJobAsync, GrpcClient.GetDlpJob, effectiveSettings.GetDlpJobSettings);
            _callDeleteDlpJob = clientHelper.BuildApiCall<DeleteDlpJobRequest, Empty>(
                GrpcClient.DeleteDlpJobAsync, GrpcClient.DeleteDlpJob, effectiveSettings.DeleteDlpJobSettings);
            _callCancelDlpJob = clientHelper.BuildApiCall<CancelDlpJobRequest, Empty>(
                GrpcClient.CancelDlpJobAsync, GrpcClient.CancelDlpJob, effectiveSettings.CancelDlpJobSettings);
            _callListJobTriggers = clientHelper.BuildApiCall<ListJobTriggersRequest, ListJobTriggersResponse>(
                GrpcClient.ListJobTriggersAsync, GrpcClient.ListJobTriggers, effectiveSettings.ListJobTriggersSettings);
            _callGetJobTrigger = clientHelper.BuildApiCall<GetJobTriggerRequest, JobTrigger>(
                GrpcClient.GetJobTriggerAsync, GrpcClient.GetJobTrigger, effectiveSettings.GetJobTriggerSettings);
            _callDeleteJobTrigger = clientHelper.BuildApiCall<DeleteJobTriggerRequest, Empty>(
                GrpcClient.DeleteJobTriggerAsync, GrpcClient.DeleteJobTrigger, effectiveSettings.DeleteJobTriggerSettings);
            _callUpdateJobTrigger = clientHelper.BuildApiCall<UpdateJobTriggerRequest, JobTrigger>(
                GrpcClient.UpdateJobTriggerAsync, GrpcClient.UpdateJobTrigger, effectiveSettings.UpdateJobTriggerSettings);
            _callCreateJobTrigger = clientHelper.BuildApiCall<CreateJobTriggerRequest, JobTrigger>(
                GrpcClient.CreateJobTriggerAsync, GrpcClient.CreateJobTrigger, effectiveSettings.CreateJobTriggerSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(DlpService.DlpServiceClient grpcClient, DlpServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DlpService client.
        /// </summary>
        public override DlpService.DlpServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_InspectContentRequest(ref InspectContentRequest request, ref CallSettings settings);
        partial void Modify_RedactImageRequest(ref RedactImageRequest request, ref CallSettings settings);
        partial void Modify_DeidentifyContentRequest(ref DeidentifyContentRequest request, ref CallSettings settings);
        partial void Modify_ReidentifyContentRequest(ref ReidentifyContentRequest request, ref CallSettings settings);
        partial void Modify_ListInfoTypesRequest(ref ListInfoTypesRequest request, ref CallSettings settings);
        partial void Modify_CreateInspectTemplateRequest(ref CreateInspectTemplateRequest request, ref CallSettings settings);
        partial void Modify_UpdateInspectTemplateRequest(ref UpdateInspectTemplateRequest request, ref CallSettings settings);
        partial void Modify_GetInspectTemplateRequest(ref GetInspectTemplateRequest request, ref CallSettings settings);
        partial void Modify_ListInspectTemplatesRequest(ref ListInspectTemplatesRequest request, ref CallSettings settings);
        partial void Modify_DeleteInspectTemplateRequest(ref DeleteInspectTemplateRequest request, ref CallSettings settings);
        partial void Modify_CreateDeidentifyTemplateRequest(ref CreateDeidentifyTemplateRequest request, ref CallSettings settings);
        partial void Modify_UpdateDeidentifyTemplateRequest(ref UpdateDeidentifyTemplateRequest request, ref CallSettings settings);
        partial void Modify_GetDeidentifyTemplateRequest(ref GetDeidentifyTemplateRequest request, ref CallSettings settings);
        partial void Modify_ListDeidentifyTemplatesRequest(ref ListDeidentifyTemplatesRequest request, ref CallSettings settings);
        partial void Modify_DeleteDeidentifyTemplateRequest(ref DeleteDeidentifyTemplateRequest request, ref CallSettings settings);
        partial void Modify_CreateDlpJobRequest(ref CreateDlpJobRequest request, ref CallSettings settings);
        partial void Modify_ListDlpJobsRequest(ref ListDlpJobsRequest request, ref CallSettings settings);
        partial void Modify_GetDlpJobRequest(ref GetDlpJobRequest request, ref CallSettings settings);
        partial void Modify_DeleteDlpJobRequest(ref DeleteDlpJobRequest request, ref CallSettings settings);
        partial void Modify_CancelDlpJobRequest(ref CancelDlpJobRequest request, ref CallSettings settings);
        partial void Modify_ListJobTriggersRequest(ref ListJobTriggersRequest request, ref CallSettings settings);
        partial void Modify_GetJobTriggerRequest(ref GetJobTriggerRequest request, ref CallSettings settings);
        partial void Modify_DeleteJobTriggerRequest(ref DeleteJobTriggerRequest request, ref CallSettings settings);
        partial void Modify_UpdateJobTriggerRequest(ref UpdateJobTriggerRequest request, ref CallSettings settings);
        partial void Modify_CreateJobTriggerRequest(ref CreateJobTriggerRequest request, ref CallSettings settings);

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide for text](/dlp/docs/inspecting-text), [How-to guide for
        /// images](/dlp/docs/inspecting-images)
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
        public override Task<InspectContentResponse> InspectContentAsync(
            InspectContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Async(request, callSettings);
        }

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide for text](/dlp/docs/inspecting-text), [How-to guide for
        /// images](/dlp/docs/inspecting-images)
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
            CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide](/dlp/docs/redacting-sensitive-data-images)
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
        public override Task<RedactImageResponse> RedactImageAsync(
            RedactImageRequest request,
            CallSettings callSettings = null)
        {
            Modify_RedactImageRequest(ref request, ref callSettings);
            return _callRedactImage.Async(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// [How-to guide](/dlp/docs/redacting-sensitive-data-images)
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
            CallSettings callSettings = null)
        {
            Modify_RedactImageRequest(ref request, ref callSettings);
            return _callRedactImage.Sync(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// [How-to guide](/dlp/docs/deidentify-sensitive-data)
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
        public override Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Async(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// [How-to guide](/dlp/docs/deidentify-sensitive-data)
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
            CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Re-identify content that has been de-identified.
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
        public override Task<ReidentifyContentResponse> ReidentifyContentAsync(
            ReidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_ReidentifyContentRequest(ref request, ref callSettings);
            return _callReidentifyContent.Async(request, callSettings);
        }

        /// <summary>
        /// Re-identify content that has been de-identified.
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
            CallSettings callSettings = null)
        {
            Modify_ReidentifyContentRequest(ref request, ref callSettings);
            return _callReidentifyContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns sensitive information types DLP supports.
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
        public override Task<ListInfoTypesResponse> ListInfoTypesAsync(
            ListInfoTypesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Async(request, callSettings);
        }

        /// <summary>
        /// Returns sensitive information types DLP supports.
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
            CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an inspect template for re-using frequently used configuration
        /// for inspecting content, images, and storage.
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
        public override Task<InspectTemplate> CreateInspectTemplateAsync(
            CreateInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInspectTemplateRequest(ref request, ref callSettings);
            return _callCreateInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an inspect template for re-using frequently used configuration
        /// for inspecting content, images, and storage.
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
            CallSettings callSettings = null)
        {
            Modify_CreateInspectTemplateRequest(ref request, ref callSettings);
            return _callCreateInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the inspect template.
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
        public override Task<InspectTemplate> UpdateInspectTemplateAsync(
            UpdateInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateInspectTemplateRequest(ref request, ref callSettings);
            return _callUpdateInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the inspect template.
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
            CallSettings callSettings = null)
        {
            Modify_UpdateInspectTemplateRequest(ref request, ref callSettings);
            return _callUpdateInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an inspect template.
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
        public override Task<InspectTemplate> GetInspectTemplateAsync(
            GetInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInspectTemplateRequest(ref request, ref callSettings);
            return _callGetInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an inspect template.
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
            CallSettings callSettings = null)
        {
            Modify_GetInspectTemplateRequest(ref request, ref callSettings);
            return _callGetInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists inspect templates.
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
        public override PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(
            ListInspectTemplatesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInspectTemplatesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListInspectTemplatesRequest, ListInspectTemplatesResponse, InspectTemplate>(_callListInspectTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists inspect templates.
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
        public override PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(
            ListInspectTemplatesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInspectTemplatesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListInspectTemplatesRequest, ListInspectTemplatesResponse, InspectTemplate>(_callListInspectTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes inspect templates.
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
        public override Task DeleteInspectTemplateAsync(
            DeleteInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInspectTemplateRequest(ref request, ref callSettings);
            return _callDeleteInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes inspect templates.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteInspectTemplate(
            DeleteInspectTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInspectTemplateRequest(ref request, ref callSettings);
            _callDeleteInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an Deidentify template for re-using frequently used configuration
        /// for Deidentifying content, images, and storage.
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
        public override Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(
            CreateDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callCreateDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an Deidentify template for re-using frequently used configuration
        /// for Deidentifying content, images, and storage.
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
            CallSettings callSettings = null)
        {
            Modify_CreateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callCreateDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the inspect template.
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
        public override Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(
            UpdateDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callUpdateDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the inspect template.
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
            CallSettings callSettings = null)
        {
            Modify_UpdateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callUpdateDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an inspect template.
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
        public override Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(
            GetDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callGetDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an inspect template.
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
            CallSettings callSettings = null)
        {
            Modify_GetDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callGetDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists inspect templates.
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
        public override PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(
            ListDeidentifyTemplatesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDeidentifyTemplatesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse, DeidentifyTemplate>(_callListDeidentifyTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists inspect templates.
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
        public override PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(
            ListDeidentifyTemplatesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDeidentifyTemplatesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse, DeidentifyTemplate>(_callListDeidentifyTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes inspect templates.
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
        public override Task DeleteDeidentifyTemplateAsync(
            DeleteDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callDeleteDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes inspect templates.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteDeidentifyTemplate(
            DeleteDeidentifyTemplateRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteDeidentifyTemplateRequest(ref request, ref callSettings);
            _callDeleteDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new job to inspect storage or calculate risk metrics [How-to
        /// guide](/dlp/docs/compute-risk-analysis).
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
        public override Task<DlpJob> CreateDlpJobAsync(
            CreateDlpJobRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateDlpJobRequest(ref request, ref callSettings);
            return _callCreateDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new job to inspect storage or calculate risk metrics [How-to
        /// guide](/dlp/docs/compute-risk-analysis).
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
            CallSettings callSettings = null)
        {
            Modify_CreateDlpJobRequest(ref request, ref callSettings);
            return _callCreateDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
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
        public override PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(
            ListDlpJobsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDlpJobsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListDlpJobsRequest, ListDlpJobsResponse, DlpJob>(_callListDlpJobs, request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
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
        public override PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(
            ListDlpJobsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDlpJobsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListDlpJobsRequest, ListDlpJobsResponse, DlpJob>(_callListDlpJobs, request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
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
        public override Task<DlpJob> GetDlpJobAsync(
            GetDlpJobRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDlpJobRequest(ref request, ref callSettings);
            return _callGetDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
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
            CallSettings callSettings = null)
        {
            Modify_GetDlpJobRequest(ref request, ref callSettings);
            return _callGetDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
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
        public override Task DeleteDlpJobAsync(
            DeleteDlpJobRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteDlpJobRequest(ref request, ref callSettings);
            return _callDeleteDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be cancelled if
        /// possible.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteDlpJob(
            DeleteDlpJobRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteDlpJobRequest(ref request, ref callSettings);
            _callDeleteDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob.  The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
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
        public override Task CancelDlpJobAsync(
            CancelDlpJobRequest request,
            CallSettings callSettings = null)
        {
            Modify_CancelDlpJobRequest(ref request, ref callSettings);
            return _callCancelDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob.  The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void CancelDlpJob(
            CancelDlpJobRequest request,
            CallSettings callSettings = null)
        {
            Modify_CancelDlpJobRequest(ref request, ref callSettings);
            _callCancelDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
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
        public override PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(
            ListJobTriggersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListJobTriggersRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListJobTriggersRequest, ListJobTriggersResponse, JobTrigger>(_callListJobTriggers, request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
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
        public override PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(
            ListJobTriggersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListJobTriggersRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListJobTriggersRequest, ListJobTriggersResponse, JobTrigger>(_callListJobTriggers, request, callSettings);
        }

        /// <summary>
        /// Gets a job trigger.
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
        public override Task<JobTrigger> GetJobTriggerAsync(
            GetJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetJobTriggerRequest(ref request, ref callSettings);
            return _callGetJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a job trigger.
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
            CallSettings callSettings = null)
        {
            Modify_GetJobTriggerRequest(ref request, ref callSettings);
            return _callGetJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a job trigger.
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
        public override Task DeleteJobTriggerAsync(
            DeleteJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteJobTriggerRequest(ref request, ref callSettings);
            return _callDeleteJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a job trigger.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteJobTrigger(
            DeleteJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteJobTriggerRequest(ref request, ref callSettings);
            _callDeleteJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a job trigger.
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
        public override Task<JobTrigger> UpdateJobTriggerAsync(
            UpdateJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateJobTriggerRequest(ref request, ref callSettings);
            return _callUpdateJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a job trigger.
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
            CallSettings callSettings = null)
        {
            Modify_UpdateJobTriggerRequest(ref request, ref callSettings);
            return _callUpdateJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a job to run DLP actions such as scanning storage for sensitive
        /// information on a set schedule.
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
        public override Task<JobTrigger> CreateJobTriggerAsync(
            CreateJobTriggerRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateJobTriggerRequest(ref request, ref callSettings);
            return _callCreateJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a job to run DLP actions such as scanning storage for sensitive
        /// information on a set schedule.
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
            CallSettings callSettings = null)
        {
            Modify_CreateJobTriggerRequest(ref request, ref callSettings);
            return _callCreateJobTrigger.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListInspectTemplatesRequest : IPageRequest { }
    public partial class ListInspectTemplatesResponse : IPageResponse<InspectTemplate>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<InspectTemplate> GetEnumerator() => InspectTemplates.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeidentifyTemplatesRequest : IPageRequest { }
    public partial class ListDeidentifyTemplatesResponse : IPageResponse<DeidentifyTemplate>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<DeidentifyTemplate> GetEnumerator() => DeidentifyTemplates.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDlpJobsRequest : IPageRequest { }
    public partial class ListDlpJobsResponse : IPageResponse<DlpJob>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<DlpJob> GetEnumerator() => Jobs.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListJobTriggersRequest : IPageRequest { }
    public partial class ListJobTriggersResponse : IPageResponse<JobTrigger>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<JobTrigger> GetEnumerator() => JobTriggers.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
