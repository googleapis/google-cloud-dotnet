// Copyright 2024 Google LLC
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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Settings for <see cref="ConfigServiceV2Client"/> instances.</summary>
    public sealed partial class ConfigServiceV2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConfigServiceV2Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConfigServiceV2Settings"/>.</returns>
        public static ConfigServiceV2Settings GetDefault() => new ConfigServiceV2Settings();

        /// <summary>Constructs a new <see cref="ConfigServiceV2Settings"/> object with default settings.</summary>
        public ConfigServiceV2Settings()
        {
        }

        private ConfigServiceV2Settings(ConfigServiceV2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListBucketsSettings = existing.ListBucketsSettings;
            GetBucketSettings = existing.GetBucketSettings;
            CreateBucketAsyncSettings = existing.CreateBucketAsyncSettings;
            CreateBucketAsyncOperationsSettings = existing.CreateBucketAsyncOperationsSettings.Clone();
            UpdateBucketAsyncSettings = existing.UpdateBucketAsyncSettings;
            UpdateBucketAsyncOperationsSettings = existing.UpdateBucketAsyncOperationsSettings.Clone();
            CreateBucketSettings = existing.CreateBucketSettings;
            UpdateBucketSettings = existing.UpdateBucketSettings;
            DeleteBucketSettings = existing.DeleteBucketSettings;
            UndeleteBucketSettings = existing.UndeleteBucketSettings;
            ListViewsSettings = existing.ListViewsSettings;
            GetViewSettings = existing.GetViewSettings;
            CreateViewSettings = existing.CreateViewSettings;
            UpdateViewSettings = existing.UpdateViewSettings;
            DeleteViewSettings = existing.DeleteViewSettings;
            ListSinksSettings = existing.ListSinksSettings;
            GetSinkSettings = existing.GetSinkSettings;
            CreateSinkSettings = existing.CreateSinkSettings;
            UpdateSinkSettings = existing.UpdateSinkSettings;
            DeleteSinkSettings = existing.DeleteSinkSettings;
            CreateLinkSettings = existing.CreateLinkSettings;
            CreateLinkOperationsSettings = existing.CreateLinkOperationsSettings.Clone();
            DeleteLinkSettings = existing.DeleteLinkSettings;
            DeleteLinkOperationsSettings = existing.DeleteLinkOperationsSettings.Clone();
            ListLinksSettings = existing.ListLinksSettings;
            GetLinkSettings = existing.GetLinkSettings;
            ListExclusionsSettings = existing.ListExclusionsSettings;
            GetExclusionSettings = existing.GetExclusionSettings;
            CreateExclusionSettings = existing.CreateExclusionSettings;
            UpdateExclusionSettings = existing.UpdateExclusionSettings;
            DeleteExclusionSettings = existing.DeleteExclusionSettings;
            GetCmekSettingsSettings = existing.GetCmekSettingsSettings;
            UpdateCmekSettingsSettings = existing.UpdateCmekSettingsSettings;
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            CopyLogEntriesSettings = existing.CopyLogEntriesSettings;
            CopyLogEntriesOperationsSettings = existing.CopyLogEntriesOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ConfigServiceV2Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListBuckets</c> and <c>ConfigServiceV2Client.ListBucketsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBucketsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetBucket</c> and <c>ConfigServiceV2Client.GetBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateBucketAsync</c> and <c>ConfigServiceV2Client.CreateBucketAsyncAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBucketAsyncSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigServiceV2Client.CreateBucketAsync</c> and
        /// <c>ConfigServiceV2Client.CreateBucketAsyncAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateBucketAsyncOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateBucketAsync</c> and <c>ConfigServiceV2Client.UpdateBucketAsyncAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBucketAsyncSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigServiceV2Client.UpdateBucketAsync</c> and
        /// <c>ConfigServiceV2Client.UpdateBucketAsyncAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateBucketAsyncOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateBucket</c> and <c>ConfigServiceV2Client.CreateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateBucket</c> and <c>ConfigServiceV2Client.UpdateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteBucket</c> and <c>ConfigServiceV2Client.DeleteBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UndeleteBucket</c> and <c>ConfigServiceV2Client.UndeleteBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListViews</c> and <c>ConfigServiceV2Client.ListViewsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListViewsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetView</c> and <c>ConfigServiceV2Client.GetViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateView</c> and <c>ConfigServiceV2Client.CreateViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateView</c> and <c>ConfigServiceV2Client.UpdateViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteView</c> and <c>ConfigServiceV2Client.DeleteViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListSinks</c> and <c>ConfigServiceV2Client.ListSinksAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetSink</c> and <c>ConfigServiceV2Client.GetSinkAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateSink</c> and <c>ConfigServiceV2Client.CreateSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateSink</c> and <c>ConfigServiceV2Client.UpdateSinkAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteSink</c> and <c>ConfigServiceV2Client.DeleteSinkAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateLink</c> and <c>ConfigServiceV2Client.CreateLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigServiceV2Client.CreateLink</c> and
        /// <c>ConfigServiceV2Client.CreateLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateLinkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteLink</c> and <c>ConfigServiceV2Client.DeleteLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigServiceV2Client.DeleteLink</c> and
        /// <c>ConfigServiceV2Client.DeleteLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteLinkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListLinks</c> and <c>ConfigServiceV2Client.ListLinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLinksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetLink</c> and <c>ConfigServiceV2Client.GetLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListExclusions</c> and <c>ConfigServiceV2Client.ListExclusionsAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExclusionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetExclusion</c> and <c>ConfigServiceV2Client.GetExclusionAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExclusionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateExclusion</c> and <c>ConfigServiceV2Client.CreateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateExclusion</c> and <c>ConfigServiceV2Client.UpdateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteExclusion</c> and <c>ConfigServiceV2Client.DeleteExclusionAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExclusionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetCmekSettings</c> and <c>ConfigServiceV2Client.GetCmekSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCmekSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateCmekSettings</c> and <c>ConfigServiceV2Client.UpdateCmekSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCmekSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetSettings</c> and <c>ConfigServiceV2Client.GetSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateSettings</c> and <c>ConfigServiceV2Client.UpdateSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CopyLogEntries</c> and <c>ConfigServiceV2Client.CopyLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CopyLogEntriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigServiceV2Client.CopyLogEntries</c> and
        /// <c>ConfigServiceV2Client.CopyLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CopyLogEntriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConfigServiceV2Settings"/> object.</returns>
        public ConfigServiceV2Settings Clone() => new ConfigServiceV2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfigServiceV2Client"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ConfigServiceV2ClientBuilder : gaxgrpc::ClientBuilderBase<ConfigServiceV2Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConfigServiceV2Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConfigServiceV2ClientBuilder() : base(ConfigServiceV2Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConfigServiceV2Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConfigServiceV2Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConfigServiceV2Client Build()
        {
            ConfigServiceV2Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConfigServiceV2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConfigServiceV2Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConfigServiceV2Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfigServiceV2Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConfigServiceV2Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfigServiceV2Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfigServiceV2Client.ChannelPool;
    }

    /// <summary>ConfigServiceV2 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for configuring sinks used to route log entries.
    /// </remarks>
    public abstract partial class ConfigServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the ConfigServiceV2 service, which is a host of "logging.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "logging.googleapis.com:443";

        /// <summary>The default ConfigServiceV2 scopes.</summary>
        /// <remarks>
        /// The default ConfigServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConfigServiceV2.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConfigServiceV2ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConfigServiceV2Client"/>.</returns>
        public static stt::Task<ConfigServiceV2Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConfigServiceV2ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConfigServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConfigServiceV2ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create() => new ConfigServiceV2ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConfigServiceV2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        internal static ConfigServiceV2Client Create(grpccore::CallInvoker callInvoker, ConfigServiceV2Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConfigServiceV2.ConfigServiceV2Client grpcClient = new ConfigServiceV2.ConfigServiceV2Client(callInvoker);
            return new ConfigServiceV2ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConfigServiceV2 client</summary>
        public virtual ConfigServiceV2.ConfigServiceV2Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(BillingAccountLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsBillingAccountLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(BillingAccountLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsBillingAccountLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogBucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> GetBucketAsync(GetBucketRequest request, st::CancellationToken cancellationToken) =>
            GetBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a log bucket asynchronously that can be used to store log entries.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LogBucket, BucketMetadata> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a log bucket asynchronously that can be used to store log entries.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LogBucket, BucketMetadata>> CreateBucketAsyncAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a log bucket asynchronously that can be used to store log entries.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LogBucket, BucketMetadata>> CreateBucketAsyncAsync(CreateBucketRequest request, st::CancellationToken cancellationToken) =>
            CreateBucketAsyncAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBucketAsync</c>.</summary>
        public virtual lro::OperationsClient CreateBucketAsyncOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBucketAsync</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LogBucket, BucketMetadata> PollOnceCreateBucketAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LogBucket, BucketMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBucketAsyncOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBucketAsync</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LogBucket, BucketMetadata>> PollOnceCreateBucketAsyncAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LogBucket, BucketMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBucketAsyncOperationsClient, callSettings);

        /// <summary>
        /// Updates a log bucket asynchronously.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LogBucket, BucketMetadata> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a log bucket asynchronously.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LogBucket, BucketMetadata>> UpdateBucketAsyncAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a log bucket asynchronously.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LogBucket, BucketMetadata>> UpdateBucketAsyncAsync(UpdateBucketRequest request, st::CancellationToken cancellationToken) =>
            UpdateBucketAsyncAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBucketAsync</c>.</summary>
        public virtual lro::OperationsClient UpdateBucketAsyncOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBucketAsync</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LogBucket, BucketMetadata> PollOnceUpdateBucketAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LogBucket, BucketMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBucketAsyncOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBucketAsync</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LogBucket, BucketMetadata>> PollOnceUpdateBucketAsyncAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LogBucket, BucketMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBucketAsyncOperationsClient, callSettings);

        /// <summary>
        /// Creates a log bucket that can be used to store log entries. After a bucket
        /// has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogBucket CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a log bucket that can be used to store log entries. After a bucket
        /// has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a log bucket that can be used to store log entries. After a bucket
        /// has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> CreateBucketAsync(CreateBucketRequest request, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a log bucket.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogBucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a log bucket.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a log bucket.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> UpdateBucketAsync(UpdateBucketRequest request, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a log bucket.
        /// 
        /// Changes the bucket's `lifecycle_state` to the `DELETE_REQUESTED` state.
        /// After 7 days, the bucket will be purged and all log entries in the bucket
        /// will be permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBucket(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a log bucket.
        /// 
        /// Changes the bucket's `lifecycle_state` to the `DELETE_REQUESTED` state.
        /// After 7 days, the bucket will be purged and all log entries in the bucket
        /// will be permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a log bucket.
        /// 
        /// Changes the bucket's `lifecycle_state` to the `DELETE_REQUESTED` state.
        /// After 7 days, the bucket will be purged and all log entries in the bucket
        /// will be permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBucketAsync(DeleteBucketRequest request, st::CancellationToken cancellationToken) =>
            DeleteBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes a log bucket. A bucket that has been deleted can be undeleted
        /// within the grace period of 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void UndeleteBucket(UndeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a log bucket. A bucket that has been deleted can be undeleted
        /// within the grace period of 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UndeleteBucketAsync(UndeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a log bucket. A bucket that has been deleted can be undeleted
        /// within the grace period of 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UndeleteBucketAsync(UndeleteBucketRequest request, st::CancellationToken cancellationToken) =>
            UndeleteBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists views on a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, LogView> ListViews(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists views on a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, LogView> ListViewsAsync(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists views on a log bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket whose views are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, LogView> ListViews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViews(request, callSettings);
        }

        /// <summary>
        /// Lists views on a log bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The bucket whose views are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, LogView> ListViewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViewsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a view on a log bucket..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogView GetView(GetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a view on a log bucket..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogView> GetViewAsync(GetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a view on a log bucket..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogView> GetViewAsync(GetViewRequest request, st::CancellationToken cancellationToken) =>
            GetViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a view over log entries in a log bucket. A bucket may contain a
        /// maximum of 30 views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogView CreateView(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a view over log entries in a log bucket. A bucket may contain a
        /// maximum of 30 views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogView> CreateViewAsync(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a view over log entries in a log bucket. A bucket may contain a
        /// maximum of 30 views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogView> CreateViewAsync(CreateViewRequest request, st::CancellationToken cancellationToken) =>
            CreateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a view on a log bucket. This method replaces the following fields
        /// in the existing view with values from the new view: `filter`.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can update the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogView UpdateView(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a view on a log bucket. This method replaces the following fields
        /// in the existing view with values from the new view: `filter`.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can update the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogView> UpdateViewAsync(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a view on a log bucket. This method replaces the following fields
        /// in the existing view with values from the new view: `filter`.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can update the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogView> UpdateViewAsync(UpdateViewRequest request, st::CancellationToken cancellationToken) =>
            UpdateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a view on a log bucket.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can delete the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteView(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a view on a log bucket.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can delete the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a view on a log bucket.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can delete the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteViewAsync(DeleteViewRequest request, st::CancellationToken cancellationToken) =>
            DeleteViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
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
            return ListSinks(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
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
            return ListSinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinks(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinks(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinks(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinks(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSinksAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(GetSinkRequest request, st::CancellationToken cancellationToken) =>
            GetSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSink(new GetSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSinkAsync(new GetSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(string sinkName, st::CancellationToken cancellationToken) =>
            GetSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSink(new GetSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSinkAsync(new GetSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(LogSinkName sinkName, st::CancellationToken cancellationToken) =>
            GetSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(CreateSinkRequest request, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(string parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(string parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(string parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::ProjectName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::ProjectName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::ProjectName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::OrganizationName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::OrganizationName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::OrganizationName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::FolderName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::FolderName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::FolderName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::BillingAccountName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::BillingAccountName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::BillingAccountName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(UpdateSinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty `updateMask` is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// 
        /// `destination,filter,includeChildren`
        /// 
        /// At some point in the future, behavior will be removed and specifying an
        /// empty `updateMask` will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// For example: `updateMask=filter`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(string sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty `updateMask` is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// 
        /// `destination,filter,includeChildren`
        /// 
        /// At some point in the future, behavior will be removed and specifying an
        /// empty `updateMask` will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// For example: `updateMask=filter`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty `updateMask` is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// 
        /// `destination,filter,includeChildren`
        /// 
        /// At some point in the future, behavior will be removed and specifying an
        /// empty `updateMask` will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// For example: `updateMask=filter`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty `updateMask` is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// 
        /// `destination,filter,includeChildren`
        /// 
        /// At some point in the future, behavior will be removed and specifying an
        /// empty `updateMask` will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// For example: `updateMask=filter`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(LogSinkName sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty `updateMask` is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// 
        /// `destination,filter,includeChildren`
        /// 
        /// At some point in the future, behavior will be removed and specifying an
        /// empty `updateMask` will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// For example: `updateMask=filter`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty `updateMask` is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// 
        /// `destination,filter,includeChildren`
        /// 
        /// At some point in the future, behavior will be removed and specifying an
        /// empty `updateMask` will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// For example: `updateMask=filter`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(string sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(LogSinkName sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(DeleteSinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSink(new DeleteSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSinkAsync(new DeleteSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(string sinkName, st::CancellationToken cancellationToken) =>
            DeleteSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSink(new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSinkAsync(new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/sinks/my-sink"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(LogSinkName sinkName, st::CancellationToken cancellationToken) =>
            DeleteSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, LinkMetadata> CreateLink(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, LinkMetadata>> CreateLinkAsync(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, LinkMetadata>> CreateLinkAsync(CreateLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateLink</c>.</summary>
        public virtual lro::OperationsClient CreateLinkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Link, LinkMetadata> PollOnceCreateLink(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Link, LinkMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Link, LinkMetadata>> PollOnceCreateLinkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Link, LinkMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the bucket to create a link for.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// </param>
        /// <param name="link">
        /// Required. The new link.
        /// </param>
        /// <param name="linkId">
        /// Required. The ID to use for the link. The link_id can have up to 100
        /// characters. A valid link_id must only have alphanumeric characters and
        /// underscores within it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, LinkMetadata> CreateLink(string parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLink(new CreateLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
            }, callSettings);

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the bucket to create a link for.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// </param>
        /// <param name="link">
        /// Required. The new link.
        /// </param>
        /// <param name="linkId">
        /// Required. The ID to use for the link. The link_id can have up to 100
        /// characters. A valid link_id must only have alphanumeric characters and
        /// underscores within it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, LinkMetadata>> CreateLinkAsync(string parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLinkAsync(new CreateLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
            }, callSettings);

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the bucket to create a link for.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// </param>
        /// <param name="link">
        /// Required. The new link.
        /// </param>
        /// <param name="linkId">
        /// Required. The ID to use for the link. The link_id can have up to 100
        /// characters. A valid link_id must only have alphanumeric characters and
        /// underscores within it.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, LinkMetadata>> CreateLinkAsync(string parent, Link link, string linkId, st::CancellationToken cancellationToken) =>
            CreateLinkAsync(parent, link, linkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the bucket to create a link for.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// </param>
        /// <param name="link">
        /// Required. The new link.
        /// </param>
        /// <param name="linkId">
        /// Required. The ID to use for the link. The link_id can have up to 100
        /// characters. A valid link_id must only have alphanumeric characters and
        /// underscores within it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, LinkMetadata> CreateLink(LogBucketName parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLink(new CreateLinkRequest
            {
                ParentAsLogBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
            }, callSettings);

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the bucket to create a link for.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// </param>
        /// <param name="link">
        /// Required. The new link.
        /// </param>
        /// <param name="linkId">
        /// Required. The ID to use for the link. The link_id can have up to 100
        /// characters. A valid link_id must only have alphanumeric characters and
        /// underscores within it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, LinkMetadata>> CreateLinkAsync(LogBucketName parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLinkAsync(new CreateLinkRequest
            {
                ParentAsLogBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
            }, callSettings);

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the bucket to create a link for.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]"
        /// </param>
        /// <param name="link">
        /// Required. The new link.
        /// </param>
        /// <param name="linkId">
        /// Required. The ID to use for the link. The link_id can have up to 100
        /// characters. A valid link_id must only have alphanumeric characters and
        /// underscores within it.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, LinkMetadata>> CreateLinkAsync(LogBucketName parent, Link link, string linkId, st::CancellationToken cancellationToken) =>
            CreateLinkAsync(parent, link, linkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, LinkMetadata> DeleteLink(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> DeleteLinkAsync(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> DeleteLinkAsync(DeleteLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteLink</c>.</summary>
        public virtual lro::OperationsClient DeleteLinkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, LinkMetadata> PollOnceDeleteLink(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, LinkMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> PollOnceDeleteLinkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, LinkMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLinkOperationsClient, callSettings);

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the link to delete.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, LinkMetadata> DeleteLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLink(new DeleteLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the link to delete.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> DeleteLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLinkAsync(new DeleteLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the link to delete.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> DeleteLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the link to delete.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, LinkMetadata> DeleteLink(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLink(new DeleteLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the link to delete.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> DeleteLinkAsync(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLinkAsync(new DeleteLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the link to delete.
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> DeleteLinkAsync(LinkName name, st::CancellationToken cancellationToken) =>
            DeleteLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose links are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/
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
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
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
            return ListLinks(request, callSettings);
        }

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose links are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/
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
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
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
            return ListLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose links are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/
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
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(LogBucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
            {
                ParentAsLogBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLinks(request, callSettings);
        }

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose links are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/
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
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(LogBucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
            {
                ParentAsLogBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Link GetLink(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(GetLinkRequest request, st::CancellationToken cancellationToken) =>
            GetLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the link:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Link GetLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLink(new GetLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the link:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLinkAsync(new GetLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the link:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(string name, st::CancellationToken cancellationToken) =>
            GetLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the link:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Link GetLink(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLink(new GetLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the link:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLinkAsync(new GetLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the link:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(LinkName name, st::CancellationToken cancellationToken) =>
            GetLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
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
            return ListExclusions(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
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
            return ListExclusionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusions(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusions(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusions(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusions(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExclusionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion GetExclusion(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(GetExclusionRequest request, st::CancellationToken cancellationToken) =>
            GetExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion GetExclusion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusion(new GetExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusionAsync(new GetExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(string name, st::CancellationToken cancellationToken) =>
            GetExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion GetExclusion(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusion(new GetExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusionAsync(new GetExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(LogExclusionName name, st::CancellationToken cancellationToken) =>
            GetExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(CreateExclusionRequest request, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(string parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(string parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(string parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::ProjectName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::ProjectName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::ProjectName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::OrganizationName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::OrganizationName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::OrganizationName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::FolderName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::FolderName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::FolderName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::BillingAccountName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::BillingAccountName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// For examples:
        /// 
        /// `"projects/my-logging-project"`
        /// `"organizations/123456789"`
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::BillingAccountName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion UpdateExclusion(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(UpdateExclusionRequest request, st::CancellationToken cancellationToken) =>
            UpdateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request.
        /// Fields not mentioned in `update_mask` are not changed and are ignored in
        /// the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion UpdateExclusion(string name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusion(new UpdateExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request.
        /// Fields not mentioned in `update_mask` are not changed and are ignored in
        /// the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(string name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusionAsync(new UpdateExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request.
        /// Fields not mentioned in `update_mask` are not changed and are ignored in
        /// the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(string name, LogExclusion exclusion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExclusionAsync(name, exclusion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request.
        /// Fields not mentioned in `update_mask` are not changed and are ignored in
        /// the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion UpdateExclusion(LogExclusionName name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusion(new UpdateExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request.
        /// Fields not mentioned in `update_mask` are not changed and are ignored in
        /// the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(LogExclusionName name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusionAsync(new UpdateExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request.
        /// Fields not mentioned in `update_mask` are not changed and are ignored in
        /// the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(LogExclusionName name, LogExclusion exclusion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExclusionAsync(name, exclusion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExclusion(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(DeleteExclusionRequest request, st::CancellationToken cancellationToken) =>
            DeleteExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExclusion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusion(new DeleteExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusionAsync(new DeleteExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExclusion(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusion(new DeleteExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusionAsync(new DeleteExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// For example:
        /// 
        /// `"projects/my-project/exclusions/my-exclusion"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(LogExclusionName name, st::CancellationToken cancellationToken) =>
            DeleteExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Logging CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can be configured for Google Cloud projects,
        /// folders, organizations and billing accounts. Once configured for an
        /// organization, it applies to all projects and folders in the Google Cloud
        /// organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmekSettings GetCmekSettings(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Logging CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can be configured for Google Cloud projects,
        /// folders, organizations and billing accounts. Once configured for an
        /// organization, it applies to all projects and folders in the Google Cloud
        /// organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> GetCmekSettingsAsync(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Logging CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can be configured for Google Cloud projects,
        /// folders, organizations and billing accounts. Once configured for an
        /// organization, it applies to all projects and folders in the Google Cloud
        /// organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> GetCmekSettingsAsync(GetCmekSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Log Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can currently only be configured for Google
        /// Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmekSettings UpdateCmekSettings(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Log Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can currently only be configured for Google
        /// Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> UpdateCmekSettingsAsync(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Log Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can currently only be configured for Google
        /// Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> UpdateCmekSettingsAsync(UpdateCmekSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve settings.
        /// 
        /// "projects/[PROJECT_ID]/settings"
        /// "organizations/[ORGANIZATION_ID]/settings"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/settings"
        /// "folders/[FOLDER_ID]/settings"
        /// 
        /// For example:
        /// 
        /// `"organizations/12345/settings"`
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve settings.
        /// 
        /// "projects/[PROJECT_ID]/settings"
        /// "organizations/[ORGANIZATION_ID]/settings"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/settings"
        /// "folders/[FOLDER_ID]/settings"
        /// 
        /// For example:
        /// 
        /// `"organizations/12345/settings"`
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve settings.
        /// 
        /// "projects/[PROJECT_ID]/settings"
        /// "organizations/[ORGANIZATION_ID]/settings"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/settings"
        /// "folders/[FOLDER_ID]/settings"
        /// 
        /// For example:
        /// 
        /// `"organizations/12345/settings"`
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve settings.
        /// 
        /// "projects/[PROJECT_ID]/settings"
        /// "organizations/[ORGANIZATION_ID]/settings"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/settings"
        /// "folders/[FOLDER_ID]/settings"
        /// 
        /// For example:
        /// 
        /// `"organizations/12345/settings"`
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve settings.
        /// 
        /// "projects/[PROJECT_ID]/settings"
        /// "organizations/[ORGANIZATION_ID]/settings"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/settings"
        /// "folders/[FOLDER_ID]/settings"
        /// 
        /// For example:
        /// 
        /// `"organizations/12345/settings"`
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="name">
        /// Required. The resource for which to retrieve settings.
        /// 
        /// "projects/[PROJECT_ID]/settings"
        /// "organizations/[ORGANIZATION_ID]/settings"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/settings"
        /// "folders/[FOLDER_ID]/settings"
        /// 
        /// For example:
        /// 
        /// `"organizations/12345/settings"`
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask identifying which fields from `settings` should
        /// be updated. A field will be overwritten if and only if it is in the update
        /// mask. Output only fields cannot be updated.
        /// 
        /// See [FieldMask][google.protobuf.FieldMask] for more information.
        /// 
        /// For example: `"updateMask=kmsKeyName"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask identifying which fields from `settings` should
        /// be updated. A field will be overwritten if and only if it is in the update
        /// mask. Output only fields cannot be updated.
        /// 
        /// See [FieldMask][google.protobuf.FieldMask] for more information.
        /// 
        /// For example: `"updateMask=kmsKeyName"`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask identifying which fields from `settings` should
        /// be updated. A field will be overwritten if and only if it is in the update
        /// mask. Output only fields cannot be updated.
        /// 
        /// See [FieldMask][google.protobuf.FieldMask] for more information.
        /// 
        /// For example: `"updateMask=kmsKeyName"`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Copies a set of log entries from a log bucket to a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata> CopyLogEntries(CopyLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies a set of log entries from a log bucket to a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>> CopyLogEntriesAsync(CopyLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies a set of log entries from a log bucket to a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>> CopyLogEntriesAsync(CopyLogEntriesRequest request, st::CancellationToken cancellationToken) =>
            CopyLogEntriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CopyLogEntries</c>.</summary>
        public virtual lro::OperationsClient CopyLogEntriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CopyLogEntries</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata> PollOnceCopyLogEntries(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CopyLogEntriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CopyLogEntries</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>> PollOnceCopyLogEntriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CopyLogEntriesOperationsClient, callSettings);
    }

    /// <summary>ConfigServiceV2 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for configuring sinks used to route log entries.
    /// </remarks>
    public sealed partial class ConfigServiceV2ClientImpl : ConfigServiceV2Client
    {
        private readonly gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> _callListBuckets;

        private readonly gaxgrpc::ApiCall<GetBucketRequest, LogBucket> _callGetBucket;

        private readonly gaxgrpc::ApiCall<CreateBucketRequest, lro::Operation> _callCreateBucketAsync;

        private readonly gaxgrpc::ApiCall<UpdateBucketRequest, lro::Operation> _callUpdateBucketAsync;

        private readonly gaxgrpc::ApiCall<CreateBucketRequest, LogBucket> _callCreateBucket;

        private readonly gaxgrpc::ApiCall<UpdateBucketRequest, LogBucket> _callUpdateBucket;

        private readonly gaxgrpc::ApiCall<DeleteBucketRequest, wkt::Empty> _callDeleteBucket;

        private readonly gaxgrpc::ApiCall<UndeleteBucketRequest, wkt::Empty> _callUndeleteBucket;

        private readonly gaxgrpc::ApiCall<ListViewsRequest, ListViewsResponse> _callListViews;

        private readonly gaxgrpc::ApiCall<GetViewRequest, LogView> _callGetView;

        private readonly gaxgrpc::ApiCall<CreateViewRequest, LogView> _callCreateView;

        private readonly gaxgrpc::ApiCall<UpdateViewRequest, LogView> _callUpdateView;

        private readonly gaxgrpc::ApiCall<DeleteViewRequest, wkt::Empty> _callDeleteView;

        private readonly gaxgrpc::ApiCall<ListSinksRequest, ListSinksResponse> _callListSinks;

        private readonly gaxgrpc::ApiCall<GetSinkRequest, LogSink> _callGetSink;

        private readonly gaxgrpc::ApiCall<CreateSinkRequest, LogSink> _callCreateSink;

        private readonly gaxgrpc::ApiCall<UpdateSinkRequest, LogSink> _callUpdateSink;

        private readonly gaxgrpc::ApiCall<DeleteSinkRequest, wkt::Empty> _callDeleteSink;

        private readonly gaxgrpc::ApiCall<CreateLinkRequest, lro::Operation> _callCreateLink;

        private readonly gaxgrpc::ApiCall<DeleteLinkRequest, lro::Operation> _callDeleteLink;

        private readonly gaxgrpc::ApiCall<ListLinksRequest, ListLinksResponse> _callListLinks;

        private readonly gaxgrpc::ApiCall<GetLinkRequest, Link> _callGetLink;

        private readonly gaxgrpc::ApiCall<ListExclusionsRequest, ListExclusionsResponse> _callListExclusions;

        private readonly gaxgrpc::ApiCall<GetExclusionRequest, LogExclusion> _callGetExclusion;

        private readonly gaxgrpc::ApiCall<CreateExclusionRequest, LogExclusion> _callCreateExclusion;

        private readonly gaxgrpc::ApiCall<UpdateExclusionRequest, LogExclusion> _callUpdateExclusion;

        private readonly gaxgrpc::ApiCall<DeleteExclusionRequest, wkt::Empty> _callDeleteExclusion;

        private readonly gaxgrpc::ApiCall<GetCmekSettingsRequest, CmekSettings> _callGetCmekSettings;

        private readonly gaxgrpc::ApiCall<UpdateCmekSettingsRequest, CmekSettings> _callUpdateCmekSettings;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> _callUpdateSettings;

        private readonly gaxgrpc::ApiCall<CopyLogEntriesRequest, lro::Operation> _callCopyLogEntries;

        /// <summary>
        /// Constructs a client wrapper for the ConfigServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfigServiceV2Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConfigServiceV2ClientImpl(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConfigServiceV2Settings effectiveSettings = settings ?? ConfigServiceV2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateBucketAsyncOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBucketAsyncOperationsSettings, logger);
            UpdateBucketAsyncOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBucketAsyncOperationsSettings, logger);
            CreateLinkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateLinkOperationsSettings, logger);
            DeleteLinkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteLinkOperationsSettings, logger);
            CopyLogEntriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CopyLogEntriesOperationsSettings, logger);
            _callListBuckets = clientHelper.BuildApiCall<ListBucketsRequest, ListBucketsResponse>("ListBuckets", grpcClient.ListBucketsAsync, grpcClient.ListBuckets, effectiveSettings.ListBucketsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBuckets);
            Modify_ListBucketsApiCall(ref _callListBuckets);
            _callGetBucket = clientHelper.BuildApiCall<GetBucketRequest, LogBucket>("GetBucket", grpcClient.GetBucketAsync, grpcClient.GetBucket, effectiveSettings.GetBucketSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBucket);
            Modify_GetBucketApiCall(ref _callGetBucket);
            _callCreateBucketAsync = clientHelper.BuildApiCall<CreateBucketRequest, lro::Operation>("CreateBucketAsync", grpcClient.CreateBucketAsyncAsync, grpcClient.CreateBucketAsync, effectiveSettings.CreateBucketAsyncSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBucketAsync);
            Modify_CreateBucketAsyncApiCall(ref _callCreateBucketAsync);
            _callUpdateBucketAsync = clientHelper.BuildApiCall<UpdateBucketRequest, lro::Operation>("UpdateBucketAsync", grpcClient.UpdateBucketAsyncAsync, grpcClient.UpdateBucketAsync, effectiveSettings.UpdateBucketAsyncSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateBucketAsync);
            Modify_UpdateBucketAsyncApiCall(ref _callUpdateBucketAsync);
            _callCreateBucket = clientHelper.BuildApiCall<CreateBucketRequest, LogBucket>("CreateBucket", grpcClient.CreateBucketAsync, grpcClient.CreateBucket, effectiveSettings.CreateBucketSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBucket);
            Modify_CreateBucketApiCall(ref _callCreateBucket);
            _callUpdateBucket = clientHelper.BuildApiCall<UpdateBucketRequest, LogBucket>("UpdateBucket", grpcClient.UpdateBucketAsync, grpcClient.UpdateBucket, effectiveSettings.UpdateBucketSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateBucket);
            Modify_UpdateBucketApiCall(ref _callUpdateBucket);
            _callDeleteBucket = clientHelper.BuildApiCall<DeleteBucketRequest, wkt::Empty>("DeleteBucket", grpcClient.DeleteBucketAsync, grpcClient.DeleteBucket, effectiveSettings.DeleteBucketSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBucket);
            Modify_DeleteBucketApiCall(ref _callDeleteBucket);
            _callUndeleteBucket = clientHelper.BuildApiCall<UndeleteBucketRequest, wkt::Empty>("UndeleteBucket", grpcClient.UndeleteBucketAsync, grpcClient.UndeleteBucket, effectiveSettings.UndeleteBucketSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteBucket);
            Modify_UndeleteBucketApiCall(ref _callUndeleteBucket);
            _callListViews = clientHelper.BuildApiCall<ListViewsRequest, ListViewsResponse>("ListViews", grpcClient.ListViewsAsync, grpcClient.ListViews, effectiveSettings.ListViewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListViews);
            Modify_ListViewsApiCall(ref _callListViews);
            _callGetView = clientHelper.BuildApiCall<GetViewRequest, LogView>("GetView", grpcClient.GetViewAsync, grpcClient.GetView, effectiveSettings.GetViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetView);
            Modify_GetViewApiCall(ref _callGetView);
            _callCreateView = clientHelper.BuildApiCall<CreateViewRequest, LogView>("CreateView", grpcClient.CreateViewAsync, grpcClient.CreateView, effectiveSettings.CreateViewSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateView);
            Modify_CreateViewApiCall(ref _callCreateView);
            _callUpdateView = clientHelper.BuildApiCall<UpdateViewRequest, LogView>("UpdateView", grpcClient.UpdateViewAsync, grpcClient.UpdateView, effectiveSettings.UpdateViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateView);
            Modify_UpdateViewApiCall(ref _callUpdateView);
            _callDeleteView = clientHelper.BuildApiCall<DeleteViewRequest, wkt::Empty>("DeleteView", grpcClient.DeleteViewAsync, grpcClient.DeleteView, effectiveSettings.DeleteViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteView);
            Modify_DeleteViewApiCall(ref _callDeleteView);
            _callListSinks = clientHelper.BuildApiCall<ListSinksRequest, ListSinksResponse>("ListSinks", grpcClient.ListSinksAsync, grpcClient.ListSinks, effectiveSettings.ListSinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSinks);
            Modify_ListSinksApiCall(ref _callListSinks);
            _callGetSink = clientHelper.BuildApiCall<GetSinkRequest, LogSink>("GetSink", grpcClient.GetSinkAsync, grpcClient.GetSink, effectiveSettings.GetSinkSettings).WithGoogleRequestParam("sink_name", request => request.SinkName);
            Modify_ApiCall(ref _callGetSink);
            Modify_GetSinkApiCall(ref _callGetSink);
            _callCreateSink = clientHelper.BuildApiCall<CreateSinkRequest, LogSink>("CreateSink", grpcClient.CreateSinkAsync, grpcClient.CreateSink, effectiveSettings.CreateSinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSink);
            Modify_CreateSinkApiCall(ref _callCreateSink);
            _callUpdateSink = clientHelper.BuildApiCall<UpdateSinkRequest, LogSink>("UpdateSink", grpcClient.UpdateSinkAsync, grpcClient.UpdateSink, effectiveSettings.UpdateSinkSettings).WithGoogleRequestParam("sink_name", request => request.SinkName);
            Modify_ApiCall(ref _callUpdateSink);
            Modify_UpdateSinkApiCall(ref _callUpdateSink);
            _callDeleteSink = clientHelper.BuildApiCall<DeleteSinkRequest, wkt::Empty>("DeleteSink", grpcClient.DeleteSinkAsync, grpcClient.DeleteSink, effectiveSettings.DeleteSinkSettings).WithGoogleRequestParam("sink_name", request => request.SinkName);
            Modify_ApiCall(ref _callDeleteSink);
            Modify_DeleteSinkApiCall(ref _callDeleteSink);
            _callCreateLink = clientHelper.BuildApiCall<CreateLinkRequest, lro::Operation>("CreateLink", grpcClient.CreateLinkAsync, grpcClient.CreateLink, effectiveSettings.CreateLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLink);
            Modify_CreateLinkApiCall(ref _callCreateLink);
            _callDeleteLink = clientHelper.BuildApiCall<DeleteLinkRequest, lro::Operation>("DeleteLink", grpcClient.DeleteLinkAsync, grpcClient.DeleteLink, effectiveSettings.DeleteLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLink);
            Modify_DeleteLinkApiCall(ref _callDeleteLink);
            _callListLinks = clientHelper.BuildApiCall<ListLinksRequest, ListLinksResponse>("ListLinks", grpcClient.ListLinksAsync, grpcClient.ListLinks, effectiveSettings.ListLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLinks);
            Modify_ListLinksApiCall(ref _callListLinks);
            _callGetLink = clientHelper.BuildApiCall<GetLinkRequest, Link>("GetLink", grpcClient.GetLinkAsync, grpcClient.GetLink, effectiveSettings.GetLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLink);
            Modify_GetLinkApiCall(ref _callGetLink);
            _callListExclusions = clientHelper.BuildApiCall<ListExclusionsRequest, ListExclusionsResponse>("ListExclusions", grpcClient.ListExclusionsAsync, grpcClient.ListExclusions, effectiveSettings.ListExclusionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExclusions);
            Modify_ListExclusionsApiCall(ref _callListExclusions);
            _callGetExclusion = clientHelper.BuildApiCall<GetExclusionRequest, LogExclusion>("GetExclusion", grpcClient.GetExclusionAsync, grpcClient.GetExclusion, effectiveSettings.GetExclusionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExclusion);
            Modify_GetExclusionApiCall(ref _callGetExclusion);
            _callCreateExclusion = clientHelper.BuildApiCall<CreateExclusionRequest, LogExclusion>("CreateExclusion", grpcClient.CreateExclusionAsync, grpcClient.CreateExclusion, effectiveSettings.CreateExclusionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExclusion);
            Modify_CreateExclusionApiCall(ref _callCreateExclusion);
            _callUpdateExclusion = clientHelper.BuildApiCall<UpdateExclusionRequest, LogExclusion>("UpdateExclusion", grpcClient.UpdateExclusionAsync, grpcClient.UpdateExclusion, effectiveSettings.UpdateExclusionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateExclusion);
            Modify_UpdateExclusionApiCall(ref _callUpdateExclusion);
            _callDeleteExclusion = clientHelper.BuildApiCall<DeleteExclusionRequest, wkt::Empty>("DeleteExclusion", grpcClient.DeleteExclusionAsync, grpcClient.DeleteExclusion, effectiveSettings.DeleteExclusionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExclusion);
            Modify_DeleteExclusionApiCall(ref _callDeleteExclusion);
            _callGetCmekSettings = clientHelper.BuildApiCall<GetCmekSettingsRequest, CmekSettings>("GetCmekSettings", grpcClient.GetCmekSettingsAsync, grpcClient.GetCmekSettings, effectiveSettings.GetCmekSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCmekSettings);
            Modify_GetCmekSettingsApiCall(ref _callGetCmekSettings);
            _callUpdateCmekSettings = clientHelper.BuildApiCall<UpdateCmekSettingsRequest, CmekSettings>("UpdateCmekSettings", grpcClient.UpdateCmekSettingsAsync, grpcClient.UpdateCmekSettings, effectiveSettings.UpdateCmekSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateCmekSettings);
            Modify_UpdateCmekSettingsApiCall(ref _callUpdateCmekSettings);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>("GetSettings", grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, Settings>("UpdateSettings", grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            _callCopyLogEntries = clientHelper.BuildApiCall<CopyLogEntriesRequest, lro::Operation>("CopyLogEntries", grpcClient.CopyLogEntriesAsync, grpcClient.CopyLogEntries, effectiveSettings.CopyLogEntriesSettings);
            Modify_ApiCall(ref _callCopyLogEntries);
            Modify_CopyLogEntriesApiCall(ref _callCopyLogEntries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListBucketsApiCall(ref gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> call);

        partial void Modify_GetBucketApiCall(ref gaxgrpc::ApiCall<GetBucketRequest, LogBucket> call);

        partial void Modify_CreateBucketAsyncApiCall(ref gaxgrpc::ApiCall<CreateBucketRequest, lro::Operation> call);

        partial void Modify_UpdateBucketAsyncApiCall(ref gaxgrpc::ApiCall<UpdateBucketRequest, lro::Operation> call);

        partial void Modify_CreateBucketApiCall(ref gaxgrpc::ApiCall<CreateBucketRequest, LogBucket> call);

        partial void Modify_UpdateBucketApiCall(ref gaxgrpc::ApiCall<UpdateBucketRequest, LogBucket> call);

        partial void Modify_DeleteBucketApiCall(ref gaxgrpc::ApiCall<DeleteBucketRequest, wkt::Empty> call);

        partial void Modify_UndeleteBucketApiCall(ref gaxgrpc::ApiCall<UndeleteBucketRequest, wkt::Empty> call);

        partial void Modify_ListViewsApiCall(ref gaxgrpc::ApiCall<ListViewsRequest, ListViewsResponse> call);

        partial void Modify_GetViewApiCall(ref gaxgrpc::ApiCall<GetViewRequest, LogView> call);

        partial void Modify_CreateViewApiCall(ref gaxgrpc::ApiCall<CreateViewRequest, LogView> call);

        partial void Modify_UpdateViewApiCall(ref gaxgrpc::ApiCall<UpdateViewRequest, LogView> call);

        partial void Modify_DeleteViewApiCall(ref gaxgrpc::ApiCall<DeleteViewRequest, wkt::Empty> call);

        partial void Modify_ListSinksApiCall(ref gaxgrpc::ApiCall<ListSinksRequest, ListSinksResponse> call);

        partial void Modify_GetSinkApiCall(ref gaxgrpc::ApiCall<GetSinkRequest, LogSink> call);

        partial void Modify_CreateSinkApiCall(ref gaxgrpc::ApiCall<CreateSinkRequest, LogSink> call);

        partial void Modify_UpdateSinkApiCall(ref gaxgrpc::ApiCall<UpdateSinkRequest, LogSink> call);

        partial void Modify_DeleteSinkApiCall(ref gaxgrpc::ApiCall<DeleteSinkRequest, wkt::Empty> call);

        partial void Modify_CreateLinkApiCall(ref gaxgrpc::ApiCall<CreateLinkRequest, lro::Operation> call);

        partial void Modify_DeleteLinkApiCall(ref gaxgrpc::ApiCall<DeleteLinkRequest, lro::Operation> call);

        partial void Modify_ListLinksApiCall(ref gaxgrpc::ApiCall<ListLinksRequest, ListLinksResponse> call);

        partial void Modify_GetLinkApiCall(ref gaxgrpc::ApiCall<GetLinkRequest, Link> call);

        partial void Modify_ListExclusionsApiCall(ref gaxgrpc::ApiCall<ListExclusionsRequest, ListExclusionsResponse> call);

        partial void Modify_GetExclusionApiCall(ref gaxgrpc::ApiCall<GetExclusionRequest, LogExclusion> call);

        partial void Modify_CreateExclusionApiCall(ref gaxgrpc::ApiCall<CreateExclusionRequest, LogExclusion> call);

        partial void Modify_UpdateExclusionApiCall(ref gaxgrpc::ApiCall<UpdateExclusionRequest, LogExclusion> call);

        partial void Modify_DeleteExclusionApiCall(ref gaxgrpc::ApiCall<DeleteExclusionRequest, wkt::Empty> call);

        partial void Modify_GetCmekSettingsApiCall(ref gaxgrpc::ApiCall<GetCmekSettingsRequest, CmekSettings> call);

        partial void Modify_UpdateCmekSettingsApiCall(ref gaxgrpc::ApiCall<UpdateCmekSettingsRequest, CmekSettings> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> call);

        partial void Modify_CopyLogEntriesApiCall(ref gaxgrpc::ApiCall<CopyLogEntriesRequest, lro::Operation> call);

        partial void OnConstruction(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConfigServiceV2 client</summary>
        public override ConfigServiceV2.ConfigServiceV2Client GrpcClient { get; }

        partial void Modify_ListBucketsRequest(ref ListBucketsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBucketRequest(ref GetBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBucketRequest(ref CreateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBucketRequest(ref UpdateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBucketRequest(ref DeleteBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteBucketRequest(ref UndeleteBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListViewsRequest(ref ListViewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetViewRequest(ref GetViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateViewRequest(ref CreateViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateViewRequest(ref UpdateViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteViewRequest(ref DeleteViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSinksRequest(ref ListSinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSinkRequest(ref GetSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSinkRequest(ref CreateSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSinkRequest(ref UpdateSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSinkRequest(ref DeleteSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLinkRequest(ref CreateLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLinkRequest(ref DeleteLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLinksRequest(ref ListLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLinkRequest(ref GetLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExclusionsRequest(ref ListExclusionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExclusionRequest(ref GetExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExclusionRequest(ref CreateExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExclusionRequest(ref UpdateExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExclusionRequest(ref DeleteExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCmekSettingsRequest(ref GetCmekSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCmekSettingsRequest(ref UpdateCmekSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CopyLogEntriesRequest(ref CopyLogEntriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public override gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBucketsRequest, ListBucketsResponse, LogBucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Lists log buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBucketsRequest, ListBucketsResponse, LogBucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Gets a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogBucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogBucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBucketAsync</c>.</summary>
        public override lro::OperationsClient CreateBucketAsyncOperationsClient { get; }

        /// <summary>
        /// Creates a log bucket asynchronously that can be used to store log entries.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LogBucket, BucketMetadata> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<LogBucket, BucketMetadata>(_callCreateBucketAsync.Sync(request, callSettings), CreateBucketAsyncOperationsClient);
        }

        /// <summary>
        /// Creates a log bucket asynchronously that can be used to store log entries.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LogBucket, BucketMetadata>> CreateBucketAsyncAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<LogBucket, BucketMetadata>(await _callCreateBucketAsync.Async(request, callSettings).ConfigureAwait(false), CreateBucketAsyncOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBucketAsync</c>.</summary>
        public override lro::OperationsClient UpdateBucketAsyncOperationsClient { get; }

        /// <summary>
        /// Updates a log bucket asynchronously.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LogBucket, BucketMetadata> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<LogBucket, BucketMetadata>(_callUpdateBucketAsync.Sync(request, callSettings), UpdateBucketAsyncOperationsClient);
        }

        /// <summary>
        /// Updates a log bucket asynchronously.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LogBucket, BucketMetadata>> UpdateBucketAsyncAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<LogBucket, BucketMetadata>(await _callUpdateBucketAsync.Async(request, callSettings).ConfigureAwait(false), UpdateBucketAsyncOperationsClient);
        }

        /// <summary>
        /// Creates a log bucket that can be used to store log entries. After a bucket
        /// has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogBucket CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return _callCreateBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a log bucket that can be used to store log entries. After a bucket
        /// has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogBucket> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return _callCreateBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a log bucket.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogBucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a log bucket.
        /// 
        /// If the bucket has a `lifecycle_state` of `DELETE_REQUESTED`, then
        /// `FAILED_PRECONDITION` will be returned.
        /// 
        /// After a bucket has been created, the bucket's location cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogBucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a log bucket.
        /// 
        /// Changes the bucket's `lifecycle_state` to the `DELETE_REQUESTED` state.
        /// After 7 days, the bucket will be purged and all log entries in the bucket
        /// will be permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBucket(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBucketRequest(ref request, ref callSettings);
            _callDeleteBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a log bucket.
        /// 
        /// Changes the bucket's `lifecycle_state` to the `DELETE_REQUESTED` state.
        /// After 7 days, the bucket will be purged and all log entries in the bucket
        /// will be permanently deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBucketAsync(DeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBucketRequest(ref request, ref callSettings);
            return _callDeleteBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Undeletes a log bucket. A bucket that has been deleted can be undeleted
        /// within the grace period of 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void UndeleteBucket(UndeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteBucketRequest(ref request, ref callSettings);
            _callUndeleteBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Undeletes a log bucket. A bucket that has been deleted can be undeleted
        /// within the grace period of 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task UndeleteBucketAsync(UndeleteBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteBucketRequest(ref request, ref callSettings);
            return _callUndeleteBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Lists views on a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogView"/> resources.</returns>
        public override gax::PagedEnumerable<ListViewsResponse, LogView> ListViews(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListViewsRequest, ListViewsResponse, LogView>(_callListViews, request, callSettings);
        }

        /// <summary>
        /// Lists views on a log bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogView"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListViewsResponse, LogView> ListViewsAsync(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListViewsRequest, ListViewsResponse, LogView>(_callListViews, request, callSettings);
        }

        /// <summary>
        /// Gets a view on a log bucket..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogView GetView(GetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewRequest(ref request, ref callSettings);
            return _callGetView.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a view on a log bucket..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogView> GetViewAsync(GetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewRequest(ref request, ref callSettings);
            return _callGetView.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a view over log entries in a log bucket. A bucket may contain a
        /// maximum of 30 views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogView CreateView(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateViewRequest(ref request, ref callSettings);
            return _callCreateView.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a view over log entries in a log bucket. A bucket may contain a
        /// maximum of 30 views.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogView> CreateViewAsync(CreateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateViewRequest(ref request, ref callSettings);
            return _callCreateView.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a view on a log bucket. This method replaces the following fields
        /// in the existing view with values from the new view: `filter`.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can update the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogView UpdateView(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateViewRequest(ref request, ref callSettings);
            return _callUpdateView.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a view on a log bucket. This method replaces the following fields
        /// in the existing view with values from the new view: `filter`.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can update the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogView> UpdateViewAsync(UpdateViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateViewRequest(ref request, ref callSettings);
            return _callUpdateView.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a view on a log bucket.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can delete the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteView(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteViewRequest(ref request, ref callSettings);
            _callDeleteView.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a view on a log bucket.
        /// If an `UNAVAILABLE` error is returned, this indicates that system is not in
        /// a state where it can delete the view. If this occurs, please try again in a
        /// few minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteViewAsync(DeleteViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteViewRequest(ref request, ref callSettings);
            return _callDeleteView.Async(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public override gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink GetSink(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogSink> GetSinkAsync(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink CreateSink(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogSink> CreateSinkAsync(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink UpdateSink(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogSink> UpdateSinkAsync(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSink(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            _callDeleteSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSinkAsync(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            return _callDeleteSink.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateLink</c>.</summary>
        public override lro::OperationsClient CreateLinkOperationsClient { get; }

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Link, LinkMetadata> CreateLink(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLinkRequest(ref request, ref callSettings);
            return new lro::Operation<Link, LinkMetadata>(_callCreateLink.Sync(request, callSettings), CreateLinkOperationsClient);
        }

        /// <summary>
        /// Asynchronously creates a linked dataset in BigQuery which makes it possible
        /// to use BigQuery to read the logs stored in the log bucket. A log bucket may
        /// currently only contain one link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Link, LinkMetadata>> CreateLinkAsync(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLinkRequest(ref request, ref callSettings);
            return new lro::Operation<Link, LinkMetadata>(await _callCreateLink.Async(request, callSettings).ConfigureAwait(false), CreateLinkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteLink</c>.</summary>
        public override lro::OperationsClient DeleteLinkOperationsClient { get; }

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, LinkMetadata> DeleteLink(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLinkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, LinkMetadata>(_callDeleteLink.Sync(request, callSettings), DeleteLinkOperationsClient);
        }

        /// <summary>
        /// Deletes a link. This will also delete the corresponding BigQuery linked
        /// dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, LinkMetadata>> DeleteLinkAsync(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLinkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, LinkMetadata>(await _callDeleteLink.Async(request, callSettings).ConfigureAwait(false), DeleteLinkOperationsClient);
        }

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public override gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLinksRequest, ListLinksResponse, Link>(_callListLinks, request, callSettings);
        }

        /// <summary>
        /// Lists links.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLinksRequest, ListLinksResponse, Link>(_callListLinks, request, callSettings);
        }

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Link GetLink(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLinkRequest(ref request, ref callSettings);
            return _callGetLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Link> GetLinkAsync(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLinkRequest(ref request, ref callSettings);
            return _callGetLink.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public override gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions on the _Default sink in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogExclusion GetExclusion(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogExclusion> GetExclusionAsync(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogExclusion CreateExclusion(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in the _Default sink in a specified parent
        /// resource. Only log entries belonging to that resource can be excluded. You
        /// can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogExclusion> CreateExclusionAsync(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogExclusion UpdateExclusion(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion in the _Default
        /// sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogExclusion> UpdateExclusionAsync(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteExclusion(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            _callDeleteExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion in the _Default sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteExclusionAsync(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            return _callDeleteExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the Logging CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can be configured for Google Cloud projects,
        /// folders, organizations and billing accounts. Once configured for an
        /// organization, it applies to all projects and folders in the Google Cloud
        /// organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmekSettings GetCmekSettings(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmekSettingsRequest(ref request, ref callSettings);
            return _callGetCmekSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Logging CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can be configured for Google Cloud projects,
        /// folders, organizations and billing accounts. Once configured for an
        /// organization, it applies to all projects and folders in the Google Cloud
        /// organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmekSettings> GetCmekSettingsAsync(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmekSettingsRequest(ref request, ref callSettings);
            return _callGetCmekSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Log Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can currently only be configured for Google
        /// Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmekSettings UpdateCmekSettings(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmekSettingsRequest(ref request, ref callSettings);
            return _callUpdateCmekSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Log Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Log Router can currently only be configured for Google
        /// Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmekSettings> UpdateCmekSettingsAsync(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmekSettingsRequest(ref request, ref callSettings);
            return _callUpdateCmekSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can be get for Google Cloud projects,
        /// folders, organizations and billing accounts. Currently it can only be
        /// configured for organizations. Once configured for an organization, it
        /// applies to all projects and folders in the Google Cloud organization.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Log Router settings for the given resource.
        /// 
        /// Note: Settings for the Log Router can currently only be configured for
        /// Google Cloud organizations. Once configured, it applies to all projects and
        /// folders in the Google Cloud organization.
        /// 
        /// [UpdateSettings][google.logging.v2.ConfigServiceV2.UpdateSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled. 4) `location_id` is not supported by
        /// Logging. 5) `location_id` violate OrgPolicy.
        /// 
        /// See [Enabling CMEK for Log
        /// Router](https://cloud.google.com/logging/docs/routing/managed-encryption)
        /// for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CopyLogEntries</c>.</summary>
        public override lro::OperationsClient CopyLogEntriesOperationsClient { get; }

        /// <summary>
        /// Copies a set of log entries from a log bucket to a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata> CopyLogEntries(CopyLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CopyLogEntriesRequest(ref request, ref callSettings);
            return new lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>(_callCopyLogEntries.Sync(request, callSettings), CopyLogEntriesOperationsClient);
        }

        /// <summary>
        /// Copies a set of log entries from a log bucket to a Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>> CopyLogEntriesAsync(CopyLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CopyLogEntriesRequest(ref request, ref callSettings);
            return new lro::Operation<CopyLogEntriesResponse, CopyLogEntriesMetadata>(await _callCopyLogEntries.Async(request, callSettings).ConfigureAwait(false), CopyLogEntriesOperationsClient);
        }
    }

    public partial class ListBucketsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListViewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExclusionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBucketsResponse : gaxgrpc::IPageResponse<LogBucket>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogBucket> GetEnumerator() => Buckets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListViewsResponse : gaxgrpc::IPageResponse<LogView>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogView> GetEnumerator() => Views.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSinksResponse : gaxgrpc::IPageResponse<LogSink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogSink> GetEnumerator() => Sinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLinksResponse : gaxgrpc::IPageResponse<Link>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Link> GetEnumerator() => Links.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExclusionsResponse : gaxgrpc::IPageResponse<LogExclusion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogExclusion> GetEnumerator() => Exclusions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ConfigServiceV2
    {
        public partial class ConfigServiceV2Client
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
