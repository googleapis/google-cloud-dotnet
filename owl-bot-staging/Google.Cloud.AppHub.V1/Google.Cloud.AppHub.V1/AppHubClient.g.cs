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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.AppHub.V1
{
    /// <summary>Settings for <see cref="AppHubClient"/> instances.</summary>
    public sealed partial class AppHubSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AppHubSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AppHubSettings"/>.</returns>
        public static AppHubSettings GetDefault() => new AppHubSettings();

        /// <summary>Constructs a new <see cref="AppHubSettings"/> object with default settings.</summary>
        public AppHubSettings()
        {
        }

        private AppHubSettings(AppHubSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            LookupServiceProjectAttachmentSettings = existing.LookupServiceProjectAttachmentSettings;
            ListServiceProjectAttachmentsSettings = existing.ListServiceProjectAttachmentsSettings;
            CreateServiceProjectAttachmentSettings = existing.CreateServiceProjectAttachmentSettings;
            CreateServiceProjectAttachmentOperationsSettings = existing.CreateServiceProjectAttachmentOperationsSettings.Clone();
            GetServiceProjectAttachmentSettings = existing.GetServiceProjectAttachmentSettings;
            DeleteServiceProjectAttachmentSettings = existing.DeleteServiceProjectAttachmentSettings;
            DeleteServiceProjectAttachmentOperationsSettings = existing.DeleteServiceProjectAttachmentOperationsSettings.Clone();
            DetachServiceProjectAttachmentSettings = existing.DetachServiceProjectAttachmentSettings;
            ListDiscoveredServicesSettings = existing.ListDiscoveredServicesSettings;
            GetDiscoveredServiceSettings = existing.GetDiscoveredServiceSettings;
            LookupDiscoveredServiceSettings = existing.LookupDiscoveredServiceSettings;
            ListServicesSettings = existing.ListServicesSettings;
            CreateServiceSettings = existing.CreateServiceSettings;
            CreateServiceOperationsSettings = existing.CreateServiceOperationsSettings.Clone();
            GetServiceSettings = existing.GetServiceSettings;
            UpdateServiceSettings = existing.UpdateServiceSettings;
            UpdateServiceOperationsSettings = existing.UpdateServiceOperationsSettings.Clone();
            DeleteServiceSettings = existing.DeleteServiceSettings;
            DeleteServiceOperationsSettings = existing.DeleteServiceOperationsSettings.Clone();
            ListDiscoveredWorkloadsSettings = existing.ListDiscoveredWorkloadsSettings;
            GetDiscoveredWorkloadSettings = existing.GetDiscoveredWorkloadSettings;
            LookupDiscoveredWorkloadSettings = existing.LookupDiscoveredWorkloadSettings;
            ListWorkloadsSettings = existing.ListWorkloadsSettings;
            CreateWorkloadSettings = existing.CreateWorkloadSettings;
            CreateWorkloadOperationsSettings = existing.CreateWorkloadOperationsSettings.Clone();
            GetWorkloadSettings = existing.GetWorkloadSettings;
            UpdateWorkloadSettings = existing.UpdateWorkloadSettings;
            UpdateWorkloadOperationsSettings = existing.UpdateWorkloadOperationsSettings.Clone();
            DeleteWorkloadSettings = existing.DeleteWorkloadSettings;
            DeleteWorkloadOperationsSettings = existing.DeleteWorkloadOperationsSettings.Clone();
            ListApplicationsSettings = existing.ListApplicationsSettings;
            CreateApplicationSettings = existing.CreateApplicationSettings;
            CreateApplicationOperationsSettings = existing.CreateApplicationOperationsSettings.Clone();
            GetApplicationSettings = existing.GetApplicationSettings;
            UpdateApplicationSettings = existing.UpdateApplicationSettings;
            UpdateApplicationOperationsSettings = existing.UpdateApplicationOperationsSettings.Clone();
            DeleteApplicationSettings = existing.DeleteApplicationSettings;
            DeleteApplicationOperationsSettings = existing.DeleteApplicationOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AppHubSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.LookupServiceProjectAttachment</c> and <c>AppHubClient.LookupServiceProjectAttachmentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupServiceProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.ListServiceProjectAttachments</c> and <c>AppHubClient.ListServiceProjectAttachmentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceProjectAttachmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.CreateServiceProjectAttachment</c> and <c>AppHubClient.CreateServiceProjectAttachmentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.CreateServiceProjectAttachment</c> and
        /// <c>AppHubClient.CreateServiceProjectAttachmentAsync</c>.
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
        public lro::OperationsSettings CreateServiceProjectAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.GetServiceProjectAttachment</c> and <c>AppHubClient.GetServiceProjectAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.DeleteServiceProjectAttachment</c> and <c>AppHubClient.DeleteServiceProjectAttachmentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.DeleteServiceProjectAttachment</c> and
        /// <c>AppHubClient.DeleteServiceProjectAttachmentAsync</c>.
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
        public lro::OperationsSettings DeleteServiceProjectAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.DetachServiceProjectAttachment</c> and <c>AppHubClient.DetachServiceProjectAttachmentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetachServiceProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.ListDiscoveredServices</c> and <c>AppHubClient.ListDiscoveredServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDiscoveredServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.GetDiscoveredService</c> and <c>AppHubClient.GetDiscoveredServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDiscoveredServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.LookupDiscoveredService</c> and <c>AppHubClient.LookupDiscoveredServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupDiscoveredServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.ListServices</c>
        ///  and <c>AppHubClient.ListServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.CreateService</c>
        ///  and <c>AppHubClient.CreateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.CreateService</c> and
        /// <c>AppHubClient.CreateServiceAsync</c>.
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
        public lro::OperationsSettings CreateServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.GetService</c>
        /// and <c>AppHubClient.GetServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.UpdateService</c>
        ///  and <c>AppHubClient.UpdateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.UpdateService</c> and
        /// <c>AppHubClient.UpdateServiceAsync</c>.
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
        public lro::OperationsSettings UpdateServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.DeleteService</c>
        ///  and <c>AppHubClient.DeleteServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.DeleteService</c> and
        /// <c>AppHubClient.DeleteServiceAsync</c>.
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
        public lro::OperationsSettings DeleteServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.ListDiscoveredWorkloads</c> and <c>AppHubClient.ListDiscoveredWorkloadsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDiscoveredWorkloadsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.GetDiscoveredWorkload</c> and <c>AppHubClient.GetDiscoveredWorkloadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDiscoveredWorkloadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.LookupDiscoveredWorkload</c> and <c>AppHubClient.LookupDiscoveredWorkloadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupDiscoveredWorkloadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.ListWorkloads</c>
        ///  and <c>AppHubClient.ListWorkloadsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkloadsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.CreateWorkload</c>
        ///  and <c>AppHubClient.CreateWorkloadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkloadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.CreateWorkload</c> and
        /// <c>AppHubClient.CreateWorkloadAsync</c>.
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
        public lro::OperationsSettings CreateWorkloadOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.GetWorkload</c>
        ///  and <c>AppHubClient.GetWorkloadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkloadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.UpdateWorkload</c>
        ///  and <c>AppHubClient.UpdateWorkloadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkloadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.UpdateWorkload</c> and
        /// <c>AppHubClient.UpdateWorkloadAsync</c>.
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
        public lro::OperationsSettings UpdateWorkloadOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.DeleteWorkload</c>
        ///  and <c>AppHubClient.DeleteWorkloadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkloadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.DeleteWorkload</c> and
        /// <c>AppHubClient.DeleteWorkloadAsync</c>.
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
        public lro::OperationsSettings DeleteWorkloadOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.ListApplications</c> and <c>AppHubClient.ListApplicationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApplicationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.CreateApplication</c> and <c>AppHubClient.CreateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.CreateApplication</c> and
        /// <c>AppHubClient.CreateApplicationAsync</c>.
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
        public lro::OperationsSettings CreateApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppHubClient.GetApplication</c>
        ///  and <c>AppHubClient.GetApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApplicationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.UpdateApplication</c> and <c>AppHubClient.UpdateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.UpdateApplication</c> and
        /// <c>AppHubClient.UpdateApplicationAsync</c>.
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
        public lro::OperationsSettings UpdateApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppHubClient.DeleteApplication</c> and <c>AppHubClient.DeleteApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppHubClient.DeleteApplication</c> and
        /// <c>AppHubClient.DeleteApplicationAsync</c>.
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
        public lro::OperationsSettings DeleteApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AppHubSettings"/> object.</returns>
        public AppHubSettings Clone() => new AppHubSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AppHubClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AppHubClientBuilder : gaxgrpc::ClientBuilderBase<AppHubClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AppHubSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AppHubClientBuilder() : base(AppHubClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AppHubClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AppHubClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AppHubClient Build()
        {
            AppHubClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AppHubClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AppHubClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AppHubClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AppHubClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AppHubClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AppHubClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AppHubClient.ChannelPool;
    }

    /// <summary>AppHub client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The App Hub API allows you to manage App Hub resources.
    /// </remarks>
    public abstract partial class AppHubClient
    {
        /// <summary>
        /// The default endpoint for the AppHub service, which is a host of "apphub.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apphub.googleapis.com:443";

        /// <summary>The default AppHub scopes.</summary>
        /// <remarks>
        /// The default AppHub scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AppHub.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AppHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AppHubClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AppHubClient"/>.</returns>
        public static stt::Task<AppHubClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AppHubClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AppHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AppHubClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AppHubClient"/>.</returns>
        public static AppHubClient Create() => new AppHubClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AppHubClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AppHubSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AppHubClient"/>.</returns>
        internal static AppHubClient Create(grpccore::CallInvoker callInvoker, AppHubSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AppHub.AppHubClient grpcClient = new AppHub.AppHubClient(callInvoker);
            return new AppHubClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AppHub client</summary>
        public virtual AppHub.AppHubClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupServiceProjectAttachmentResponse LookupServiceProjectAttachment(LookupServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupServiceProjectAttachmentResponse> LookupServiceProjectAttachmentAsync(LookupServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupServiceProjectAttachmentResponse> LookupServiceProjectAttachmentAsync(LookupServiceProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            LookupServiceProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="name">
        /// Required. Service project ID and location to lookup service project
        /// attachment for. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupServiceProjectAttachmentResponse LookupServiceProjectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            LookupServiceProjectAttachment(new LookupServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="name">
        /// Required. Service project ID and location to lookup service project
        /// attachment for. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupServiceProjectAttachmentResponse> LookupServiceProjectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            LookupServiceProjectAttachmentAsync(new LookupServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="name">
        /// Required. Service project ID and location to lookup service project
        /// attachment for. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupServiceProjectAttachmentResponse> LookupServiceProjectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            LookupServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="name">
        /// Required. Service project ID and location to lookup service project
        /// attachment for. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupServiceProjectAttachmentResponse LookupServiceProjectAttachment(gagr::LocationName name, gaxgrpc::CallSettings callSettings = null) =>
            LookupServiceProjectAttachment(new LookupServiceProjectAttachmentRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="name">
        /// Required. Service project ID and location to lookup service project
        /// attachment for. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupServiceProjectAttachmentResponse> LookupServiceProjectAttachmentAsync(gagr::LocationName name, gaxgrpc::CallSettings callSettings = null) =>
            LookupServiceProjectAttachmentAsync(new LookupServiceProjectAttachmentRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="name">
        /// Required. Service project ID and location to lookup service project
        /// attachment for. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupServiceProjectAttachmentResponse> LookupServiceProjectAttachmentAsync(gagr::LocationName name, st::CancellationToken cancellationToken) =>
            LookupServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachments(ListServiceProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachmentsAsync(ListServiceProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to list service project attachments.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceProjectAttachmentsRequest request = new ListServiceProjectAttachmentsRequest
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
            return ListServiceProjectAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to list service project attachments.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceProjectAttachmentsRequest request = new ListServiceProjectAttachmentsRequest
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
            return ListServiceProjectAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to list service project attachments.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceProjectAttachmentsRequest request = new ListServiceProjectAttachmentsRequest
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
            return ListServiceProjectAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to list service project attachments.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachmentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceProjectAttachmentsRequest request = new ListServiceProjectAttachmentsRequest
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
            return ListServiceProjectAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceProjectAttachment, OperationMetadata> CreateServiceProjectAttachment(CreateServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> CreateServiceProjectAttachmentAsync(CreateServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> CreateServiceProjectAttachmentAsync(CreateServiceProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServiceProjectAttachment</c>.</summary>
        public virtual lro::OperationsClient CreateServiceProjectAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceProjectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceProjectAttachment, OperationMetadata> PollOnceCreateServiceProjectAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceProjectAttachment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceProjectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceProjectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> PollOnceCreateServiceProjectAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceProjectAttachment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceProjectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to which service project is being
        /// attached. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceProjectAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceProjectAttachmentId">
        /// Required. The service project attachment identifier must contain the
        /// project id of the service project specified in the
        /// service_project_attachment.service_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceProjectAttachment, OperationMetadata> CreateServiceProjectAttachment(string parent, ServiceProjectAttachment serviceProjectAttachment, string serviceProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceProjectAttachment(new CreateServiceProjectAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProjectAttachmentId, nameof(serviceProjectAttachmentId)),
                ServiceProjectAttachment = gax::GaxPreconditions.CheckNotNull(serviceProjectAttachment, nameof(serviceProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to which service project is being
        /// attached. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceProjectAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceProjectAttachmentId">
        /// Required. The service project attachment identifier must contain the
        /// project id of the service project specified in the
        /// service_project_attachment.service_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> CreateServiceProjectAttachmentAsync(string parent, ServiceProjectAttachment serviceProjectAttachment, string serviceProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceProjectAttachmentAsync(new CreateServiceProjectAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProjectAttachmentId, nameof(serviceProjectAttachmentId)),
                ServiceProjectAttachment = gax::GaxPreconditions.CheckNotNull(serviceProjectAttachment, nameof(serviceProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to which service project is being
        /// attached. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceProjectAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceProjectAttachmentId">
        /// Required. The service project attachment identifier must contain the
        /// project id of the service project specified in the
        /// service_project_attachment.service_project field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> CreateServiceProjectAttachmentAsync(string parent, ServiceProjectAttachment serviceProjectAttachment, string serviceProjectAttachmentId, st::CancellationToken cancellationToken) =>
            CreateServiceProjectAttachmentAsync(parent, serviceProjectAttachment, serviceProjectAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to which service project is being
        /// attached. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceProjectAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceProjectAttachmentId">
        /// Required. The service project attachment identifier must contain the
        /// project id of the service project specified in the
        /// service_project_attachment.service_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceProjectAttachment, OperationMetadata> CreateServiceProjectAttachment(gagr::LocationName parent, ServiceProjectAttachment serviceProjectAttachment, string serviceProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceProjectAttachment(new CreateServiceProjectAttachmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProjectAttachmentId, nameof(serviceProjectAttachmentId)),
                ServiceProjectAttachment = gax::GaxPreconditions.CheckNotNull(serviceProjectAttachment, nameof(serviceProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to which service project is being
        /// attached. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceProjectAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceProjectAttachmentId">
        /// Required. The service project attachment identifier must contain the
        /// project id of the service project specified in the
        /// service_project_attachment.service_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> CreateServiceProjectAttachmentAsync(gagr::LocationName parent, ServiceProjectAttachment serviceProjectAttachment, string serviceProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceProjectAttachmentAsync(new CreateServiceProjectAttachmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProjectAttachmentId, nameof(serviceProjectAttachmentId)),
                ServiceProjectAttachment = gax::GaxPreconditions.CheckNotNull(serviceProjectAttachment, nameof(serviceProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to which service project is being
        /// attached. Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="serviceProjectAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceProjectAttachmentId">
        /// Required. The service project attachment identifier must contain the
        /// project id of the service project specified in the
        /// service_project_attachment.service_project field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> CreateServiceProjectAttachmentAsync(gagr::LocationName parent, ServiceProjectAttachment serviceProjectAttachment, string serviceProjectAttachmentId, st::CancellationToken cancellationToken) =>
            CreateServiceProjectAttachmentAsync(parent, serviceProjectAttachment, serviceProjectAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceProjectAttachment GetServiceProjectAttachment(GetServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceProjectAttachment> GetServiceProjectAttachmentAsync(GetServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceProjectAttachment> GetServiceProjectAttachmentAsync(GetServiceProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            GetServiceProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to
        /// retrieve. Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceProjectAttachment GetServiceProjectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceProjectAttachment(new GetServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to
        /// retrieve. Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceProjectAttachment> GetServiceProjectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceProjectAttachmentAsync(new GetServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to
        /// retrieve. Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceProjectAttachment> GetServiceProjectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to
        /// retrieve. Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceProjectAttachment GetServiceProjectAttachment(ServiceProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceProjectAttachment(new GetServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to
        /// retrieve. Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceProjectAttachment> GetServiceProjectAttachmentAsync(ServiceProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceProjectAttachmentAsync(new GetServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to
        /// retrieve. Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceProjectAttachment> GetServiceProjectAttachmentAsync(ServiceProjectAttachmentName name, st::CancellationToken cancellationToken) =>
            GetServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceProjectAttachment(DeleteServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceProjectAttachmentAsync(DeleteServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceProjectAttachmentAsync(DeleteServiceProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteServiceProjectAttachment</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceProjectAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceProjectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteServiceProjectAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceProjectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteServiceProjectAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceProjectAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceProjectAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceProjectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceProjectAttachment(new DeleteServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceProjectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceProjectAttachmentAsync(new DeleteServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceProjectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceProjectAttachment(ServiceProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceProjectAttachment(new DeleteServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceProjectAttachmentAsync(ServiceProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceProjectAttachmentAsync(new DeleteServiceProjectAttachmentRequest
            {
                ServiceProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the service project attachment to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/serviceProjectAttachments/{serviceProjectAttachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceProjectAttachmentAsync(ServiceProjectAttachmentName name, st::CancellationToken cancellationToken) =>
            DeleteServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetachServiceProjectAttachmentResponse DetachServiceProjectAttachment(DetachServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachServiceProjectAttachmentResponse> DetachServiceProjectAttachmentAsync(DetachServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachServiceProjectAttachmentResponse> DetachServiceProjectAttachmentAsync(DetachServiceProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            DetachServiceProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="name">
        /// Required. Service project id and location to detach from a host project.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetachServiceProjectAttachmentResponse DetachServiceProjectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DetachServiceProjectAttachment(new DetachServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="name">
        /// Required. Service project id and location to detach from a host project.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachServiceProjectAttachmentResponse> DetachServiceProjectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DetachServiceProjectAttachmentAsync(new DetachServiceProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="name">
        /// Required. Service project id and location to detach from a host project.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachServiceProjectAttachmentResponse> DetachServiceProjectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            DetachServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="name">
        /// Required. Service project id and location to detach from a host project.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetachServiceProjectAttachmentResponse DetachServiceProjectAttachment(gagr::LocationName name, gaxgrpc::CallSettings callSettings = null) =>
            DetachServiceProjectAttachment(new DetachServiceProjectAttachmentRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="name">
        /// Required. Service project id and location to detach from a host project.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachServiceProjectAttachmentResponse> DetachServiceProjectAttachmentAsync(gagr::LocationName name, gaxgrpc::CallSettings callSettings = null) =>
            DetachServiceProjectAttachmentAsync(new DetachServiceProjectAttachmentRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="name">
        /// Required. Service project id and location to detach from a host project.
        /// Only global location is supported. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachServiceProjectAttachmentResponse> DetachServiceProjectAttachmentAsync(gagr::LocationName name, st::CancellationToken cancellationToken) =>
            DetachServiceProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServices(ListDiscoveredServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServicesAsync(ListDiscoveredServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Services on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="DiscoveredService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredServicesRequest request = new ListDiscoveredServicesRequest
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
            return ListDiscoveredServices(request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Services on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredServicesRequest request = new ListDiscoveredServicesRequest
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
            return ListDiscoveredServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Services on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="DiscoveredService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServices(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredServicesRequest request = new ListDiscoveredServicesRequest
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
            return ListDiscoveredServices(request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Services on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServicesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredServicesRequest request = new ListDiscoveredServicesRequest
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
            return ListDiscoveredServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredService GetDiscoveredService(GetDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredService> GetDiscoveredServiceAsync(GetDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredService> GetDiscoveredServiceAsync(GetDiscoveredServiceRequest request, st::CancellationToken cancellationToken) =>
            GetDiscoveredServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredServices/{discoveredService}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredService GetDiscoveredService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredService(new GetDiscoveredServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredServices/{discoveredService}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredService> GetDiscoveredServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredServiceAsync(new GetDiscoveredServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredServices/{discoveredService}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredService> GetDiscoveredServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetDiscoveredServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredServices/{discoveredService}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredService GetDiscoveredService(DiscoveredServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredService(new GetDiscoveredServiceRequest
            {
                DiscoveredServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredServices/{discoveredService}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredService> GetDiscoveredServiceAsync(DiscoveredServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredServiceAsync(new GetDiscoveredServiceRequest
            {
                DiscoveredServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredServices/{discoveredService}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredService> GetDiscoveredServiceAsync(DiscoveredServiceName name, st::CancellationToken cancellationToken) =>
            GetDiscoveredServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupDiscoveredServiceResponse LookupDiscoveredService(LookupDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredServiceResponse> LookupDiscoveredServiceAsync(LookupDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredServiceResponse> LookupDiscoveredServiceAsync(LookupDiscoveredServiceRequest request, st::CancellationToken cancellationToken) =>
            LookupDiscoveredServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find DiscoveredService for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupDiscoveredServiceResponse LookupDiscoveredService(string parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredService(new LookupDiscoveredServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find DiscoveredService for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredServiceResponse> LookupDiscoveredServiceAsync(string parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredServiceAsync(new LookupDiscoveredServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find DiscoveredService for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredServiceResponse> LookupDiscoveredServiceAsync(string parent, string uri, st::CancellationToken cancellationToken) =>
            LookupDiscoveredServiceAsync(parent, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find DiscoveredService for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupDiscoveredServiceResponse LookupDiscoveredService(gagr::LocationName parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredService(new LookupDiscoveredServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find DiscoveredService for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredServiceResponse> LookupDiscoveredServiceAsync(gagr::LocationName parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredServiceAsync(new LookupDiscoveredServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Service in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find DiscoveredService for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredServiceResponse> LookupDiscoveredServiceAsync(gagr::LocationName parent, string uri, st::CancellationToken cancellationToken) =>
            LookupDiscoveredServiceAsync(parent, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Services
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Services
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Services
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Services
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public virtual lro::OperationsClient CreateServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Service, OperationMetadata> PollOnceCreateService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> PollOnceCreateServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to create the
        /// Service in. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="service">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Service identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to create the
        /// Service in. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="service">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Service identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to create the
        /// Service in. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="service">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Service identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(string parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to create the
        /// Service in. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="service">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Service identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(ApplicationName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to create the
        /// Service in. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="service">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Service identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(ApplicationName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to create the
        /// Service in. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="service">
        /// Required. The resource being created.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Service identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(ApplicationName parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateService</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Service, OperationMetadata> PollOnceUpdateService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> PollOnceUpdateServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceOperationsClient, callSettings);

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="service">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Service resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> UpdateService(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateService(new UpdateServiceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="service">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Service resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceAsync(new UpdateServiceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="service">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Service resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(service, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Service to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/services/{service}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloads(ListDiscoveredWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloadsAsync(ListDiscoveredWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Workloads on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloads(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredWorkloadsRequest request = new ListDiscoveredWorkloadsRequest
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
            return ListDiscoveredWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Workloads on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloadsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredWorkloadsRequest request = new ListDiscoveredWorkloadsRequest
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
            return ListDiscoveredWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Workloads on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloads(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredWorkloadsRequest request = new ListDiscoveredWorkloadsRequest
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
            return ListDiscoveredWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Discovered Workloads on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloadsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredWorkloadsRequest request = new ListDiscoveredWorkloadsRequest
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
            return ListDiscoveredWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredWorkload GetDiscoveredWorkload(GetDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredWorkload> GetDiscoveredWorkloadAsync(GetDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredWorkload> GetDiscoveredWorkloadAsync(GetDiscoveredWorkloadRequest request, st::CancellationToken cancellationToken) =>
            GetDiscoveredWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredWorkloads/{discoveredWorkload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredWorkload GetDiscoveredWorkload(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredWorkload(new GetDiscoveredWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredWorkloads/{discoveredWorkload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredWorkload> GetDiscoveredWorkloadAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredWorkloadAsync(new GetDiscoveredWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredWorkloads/{discoveredWorkload}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredWorkload> GetDiscoveredWorkloadAsync(string name, st::CancellationToken cancellationToken) =>
            GetDiscoveredWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredWorkloads/{discoveredWorkload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredWorkload GetDiscoveredWorkload(DiscoveredWorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredWorkload(new GetDiscoveredWorkloadRequest
            {
                DiscoveredWorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredWorkloads/{discoveredWorkload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredWorkload> GetDiscoveredWorkloadAsync(DiscoveredWorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredWorkloadAsync(new GetDiscoveredWorkloadRequest
            {
                DiscoveredWorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Discovered Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredWorkloads/{discoveredWorkload}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredWorkload> GetDiscoveredWorkloadAsync(DiscoveredWorkloadName name, st::CancellationToken cancellationToken) =>
            GetDiscoveredWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupDiscoveredWorkloadResponse LookupDiscoveredWorkload(LookupDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredWorkloadResponse> LookupDiscoveredWorkloadAsync(LookupDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredWorkloadResponse> LookupDiscoveredWorkloadAsync(LookupDiscoveredWorkloadRequest request, st::CancellationToken cancellationToken) =>
            LookupDiscoveredWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Workload in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find Discovered Workload for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupDiscoveredWorkloadResponse LookupDiscoveredWorkload(string parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredWorkload(new LookupDiscoveredWorkloadRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Workload in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find Discovered Workload for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredWorkloadResponse> LookupDiscoveredWorkloadAsync(string parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredWorkloadAsync(new LookupDiscoveredWorkloadRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Workload in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find Discovered Workload for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredWorkloadResponse> LookupDiscoveredWorkloadAsync(string parent, string uri, st::CancellationToken cancellationToken) =>
            LookupDiscoveredWorkloadAsync(parent, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Workload in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find Discovered Workload for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupDiscoveredWorkloadResponse LookupDiscoveredWorkload(gagr::LocationName parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredWorkload(new LookupDiscoveredWorkloadRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Workload in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find Discovered Workload for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredWorkloadResponse> LookupDiscoveredWorkloadAsync(gagr::LocationName parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            LookupDiscoveredWorkloadAsync(new LookupDiscoveredWorkloadRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="parent">
        /// Required. Host project ID and location to lookup Discovered Workload in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="uri">
        /// Required. Resource URI to find Discovered Workload for.
        /// Accepts both project number and project ID and does translation when
        /// needed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupDiscoveredWorkloadResponse> LookupDiscoveredWorkloadAsync(gagr::LocationName parent, string uri, st::CancellationToken cancellationToken) =>
            LookupDiscoveredWorkloadAsync(parent, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Workloads
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Workloads
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Workloads
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the parent Application to list Workloads
        /// for. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(ApplicationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, OperationMetadata> CreateWorkload(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> CreateWorkloadAsync(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> CreateWorkloadAsync(CreateWorkloadRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkload</c>.</summary>
        public virtual lro::OperationsClient CreateWorkloadOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workload, OperationMetadata> PollOnceCreateWorkload(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workload, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> PollOnceCreateWorkloadAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workload, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the Application to create Workload in.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="workload">
        /// Required. The resource being created.
        /// </param>
        /// <param name="workloadId">
        /// Required. The Workload identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, OperationMetadata> CreateWorkload(string parent, Workload workload, string workloadId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkload(new CreateWorkloadRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkloadId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the Application to create Workload in.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="workload">
        /// Required. The resource being created.
        /// </param>
        /// <param name="workloadId">
        /// Required. The Workload identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> CreateWorkloadAsync(string parent, Workload workload, string workloadId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadAsync(new CreateWorkloadRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkloadId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the Application to create Workload in.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="workload">
        /// Required. The resource being created.
        /// </param>
        /// <param name="workloadId">
        /// Required. The Workload identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> CreateWorkloadAsync(string parent, Workload workload, string workloadId, st::CancellationToken cancellationToken) =>
            CreateWorkloadAsync(parent, workload, workloadId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the Application to create Workload in.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="workload">
        /// Required. The resource being created.
        /// </param>
        /// <param name="workloadId">
        /// Required. The Workload identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, OperationMetadata> CreateWorkload(ApplicationName parent, Workload workload, string workloadId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkload(new CreateWorkloadRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkloadId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the Application to create Workload in.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="workload">
        /// Required. The resource being created.
        /// </param>
        /// <param name="workloadId">
        /// Required. The Workload identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> CreateWorkloadAsync(ApplicationName parent, Workload workload, string workloadId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadAsync(new CreateWorkloadRequest
            {
                ParentAsApplicationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkloadId = gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="parent">
        /// Required. Fully qualified name of the Application to create Workload in.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="workload">
        /// Required. The resource being created.
        /// </param>
        /// <param name="workloadId">
        /// Required. The Workload identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> CreateWorkloadAsync(ApplicationName parent, Workload workload, string workloadId, st::CancellationToken cancellationToken) =>
            CreateWorkloadAsync(parent, workload, workloadId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkload(new GetWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadAsync(new GetWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkload(new GetWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadAsync(new GetWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(WorkloadName name, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, OperationMetadata> UpdateWorkload(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> UpdateWorkloadAsync(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> UpdateWorkloadAsync(UpdateWorkloadRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkload</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkloadOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workload, OperationMetadata> PollOnceUpdateWorkload(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workload, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> PollOnceUpdateWorkloadAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workload, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="workload">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Workload resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, OperationMetadata> UpdateWorkload(Workload workload, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkload(new UpdateWorkloadRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="workload">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Workload resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> UpdateWorkloadAsync(Workload workload, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkloadAsync(new UpdateWorkloadRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="workload">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Workload resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, OperationMetadata>> UpdateWorkloadAsync(Workload workload, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkloadAsync(workload, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkload(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkloadAsync(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkloadAsync(DeleteWorkloadRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkload</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkloadOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteWorkload(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteWorkloadAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkload(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkload(new DeleteWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkloadAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadAsync(new DeleteWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkloadAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkload(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkload(new DeleteWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkloadAsync(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadAsync(new DeleteWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Workload to delete from an
        /// Application. Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}/workloads/{workload}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkloadAsync(WorkloadName name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Applications on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Applications on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Applications on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to list Applications on.
        /// Expected format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(CreateApplicationRequest request, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApplication</c>.</summary>
        public virtual lro::OperationsClient CreateApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Application, OperationMetadata> PollOnceCreateApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> PollOnceCreateApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to create Application in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created
        /// </param>
        /// <param name="applicationId">
        /// Required. The Application identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> CreateApplication(string parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to create Application in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created
        /// </param>
        /// <param name="applicationId">
        /// Required. The Application identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(string parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to create Application in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created
        /// </param>
        /// <param name="applicationId">
        /// Required. The Application identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(string parent, Application application, string applicationId, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, applicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to create Application in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created
        /// </param>
        /// <param name="applicationId">
        /// Required. The Application identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> CreateApplication(gagr::LocationName parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to create Application in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created
        /// </param>
        /// <param name="applicationId">
        /// Required. The Application identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(gagr::LocationName parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location to create Application in.
        /// Expected format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="application">
        /// Required. The resource being created
        /// </param>
        /// <param name="applicationId">
        /// Required. The Application identifier.
        /// Must contain only lowercase letters, numbers
        /// or hyphens, with the first character a letter, the last a letter or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(gagr::LocationName parent, Application application, string applicationId, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, applicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to fetch.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(UpdateApplicationRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateApplication</c>.</summary>
        public virtual lro::OperationsClient UpdateApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Application, OperationMetadata> PollOnceUpdateApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> PollOnceUpdateApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="application">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Application resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadata> UpdateApplication(Application application, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplication(new UpdateApplicationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="application">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Application resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(Application application, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationAsync(new UpdateApplicationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="application">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Application resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request.
        /// The API changes the values of the fields as specified in the update_mask.
        /// The API ignores the values of all fields not covered by the update_mask.
        /// You can also unset a field by not specifying it in the updated message, but
        /// adding the field to the mask. This clears whatever value the field
        /// previously had.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(Application application, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(application, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteApplication</c>.</summary>
        public virtual lro::OperationsClient DeleteApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationOperationsClient, callSettings);

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified name of the Application to delete.
        /// Expected format:
        /// `projects/{project}/locations/{location}/applications/{application}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AppHub client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The App Hub API allows you to manage App Hub resources.
    /// </remarks>
    public sealed partial class AppHubClientImpl : AppHubClient
    {
        private readonly gaxgrpc::ApiCall<LookupServiceProjectAttachmentRequest, LookupServiceProjectAttachmentResponse> _callLookupServiceProjectAttachment;

        private readonly gaxgrpc::ApiCall<ListServiceProjectAttachmentsRequest, ListServiceProjectAttachmentsResponse> _callListServiceProjectAttachments;

        private readonly gaxgrpc::ApiCall<CreateServiceProjectAttachmentRequest, lro::Operation> _callCreateServiceProjectAttachment;

        private readonly gaxgrpc::ApiCall<GetServiceProjectAttachmentRequest, ServiceProjectAttachment> _callGetServiceProjectAttachment;

        private readonly gaxgrpc::ApiCall<DeleteServiceProjectAttachmentRequest, lro::Operation> _callDeleteServiceProjectAttachment;

        private readonly gaxgrpc::ApiCall<DetachServiceProjectAttachmentRequest, DetachServiceProjectAttachmentResponse> _callDetachServiceProjectAttachment;

        private readonly gaxgrpc::ApiCall<ListDiscoveredServicesRequest, ListDiscoveredServicesResponse> _callListDiscoveredServices;

        private readonly gaxgrpc::ApiCall<GetDiscoveredServiceRequest, DiscoveredService> _callGetDiscoveredService;

        private readonly gaxgrpc::ApiCall<LookupDiscoveredServiceRequest, LookupDiscoveredServiceResponse> _callLookupDiscoveredService;

        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> _callCreateService;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<UpdateServiceRequest, lro::Operation> _callUpdateService;

        private readonly gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> _callDeleteService;

        private readonly gaxgrpc::ApiCall<ListDiscoveredWorkloadsRequest, ListDiscoveredWorkloadsResponse> _callListDiscoveredWorkloads;

        private readonly gaxgrpc::ApiCall<GetDiscoveredWorkloadRequest, DiscoveredWorkload> _callGetDiscoveredWorkload;

        private readonly gaxgrpc::ApiCall<LookupDiscoveredWorkloadRequest, LookupDiscoveredWorkloadResponse> _callLookupDiscoveredWorkload;

        private readonly gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> _callListWorkloads;

        private readonly gaxgrpc::ApiCall<CreateWorkloadRequest, lro::Operation> _callCreateWorkload;

        private readonly gaxgrpc::ApiCall<GetWorkloadRequest, Workload> _callGetWorkload;

        private readonly gaxgrpc::ApiCall<UpdateWorkloadRequest, lro::Operation> _callUpdateWorkload;

        private readonly gaxgrpc::ApiCall<DeleteWorkloadRequest, lro::Operation> _callDeleteWorkload;

        private readonly gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> _callListApplications;

        private readonly gaxgrpc::ApiCall<CreateApplicationRequest, lro::Operation> _callCreateApplication;

        private readonly gaxgrpc::ApiCall<GetApplicationRequest, Application> _callGetApplication;

        private readonly gaxgrpc::ApiCall<UpdateApplicationRequest, lro::Operation> _callUpdateApplication;

        private readonly gaxgrpc::ApiCall<DeleteApplicationRequest, lro::Operation> _callDeleteApplication;

        /// <summary>
        /// Constructs a client wrapper for the AppHub service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AppHubSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AppHubClientImpl(AppHub.AppHubClient grpcClient, AppHubSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AppHubSettings effectiveSettings = settings ?? AppHubSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateServiceProjectAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceProjectAttachmentOperationsSettings, logger);
            DeleteServiceProjectAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceProjectAttachmentOperationsSettings, logger);
            CreateServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceOperationsSettings, logger);
            UpdateServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceOperationsSettings, logger);
            DeleteServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceOperationsSettings, logger);
            CreateWorkloadOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkloadOperationsSettings, logger);
            UpdateWorkloadOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkloadOperationsSettings, logger);
            DeleteWorkloadOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkloadOperationsSettings, logger);
            CreateApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateApplicationOperationsSettings, logger);
            UpdateApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateApplicationOperationsSettings, logger);
            DeleteApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteApplicationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callLookupServiceProjectAttachment = clientHelper.BuildApiCall<LookupServiceProjectAttachmentRequest, LookupServiceProjectAttachmentResponse>("LookupServiceProjectAttachment", grpcClient.LookupServiceProjectAttachmentAsync, grpcClient.LookupServiceProjectAttachment, effectiveSettings.LookupServiceProjectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLookupServiceProjectAttachment);
            Modify_LookupServiceProjectAttachmentApiCall(ref _callLookupServiceProjectAttachment);
            _callListServiceProjectAttachments = clientHelper.BuildApiCall<ListServiceProjectAttachmentsRequest, ListServiceProjectAttachmentsResponse>("ListServiceProjectAttachments", grpcClient.ListServiceProjectAttachmentsAsync, grpcClient.ListServiceProjectAttachments, effectiveSettings.ListServiceProjectAttachmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceProjectAttachments);
            Modify_ListServiceProjectAttachmentsApiCall(ref _callListServiceProjectAttachments);
            _callCreateServiceProjectAttachment = clientHelper.BuildApiCall<CreateServiceProjectAttachmentRequest, lro::Operation>("CreateServiceProjectAttachment", grpcClient.CreateServiceProjectAttachmentAsync, grpcClient.CreateServiceProjectAttachment, effectiveSettings.CreateServiceProjectAttachmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServiceProjectAttachment);
            Modify_CreateServiceProjectAttachmentApiCall(ref _callCreateServiceProjectAttachment);
            _callGetServiceProjectAttachment = clientHelper.BuildApiCall<GetServiceProjectAttachmentRequest, ServiceProjectAttachment>("GetServiceProjectAttachment", grpcClient.GetServiceProjectAttachmentAsync, grpcClient.GetServiceProjectAttachment, effectiveSettings.GetServiceProjectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceProjectAttachment);
            Modify_GetServiceProjectAttachmentApiCall(ref _callGetServiceProjectAttachment);
            _callDeleteServiceProjectAttachment = clientHelper.BuildApiCall<DeleteServiceProjectAttachmentRequest, lro::Operation>("DeleteServiceProjectAttachment", grpcClient.DeleteServiceProjectAttachmentAsync, grpcClient.DeleteServiceProjectAttachment, effectiveSettings.DeleteServiceProjectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceProjectAttachment);
            Modify_DeleteServiceProjectAttachmentApiCall(ref _callDeleteServiceProjectAttachment);
            _callDetachServiceProjectAttachment = clientHelper.BuildApiCall<DetachServiceProjectAttachmentRequest, DetachServiceProjectAttachmentResponse>("DetachServiceProjectAttachment", grpcClient.DetachServiceProjectAttachmentAsync, grpcClient.DetachServiceProjectAttachment, effectiveSettings.DetachServiceProjectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDetachServiceProjectAttachment);
            Modify_DetachServiceProjectAttachmentApiCall(ref _callDetachServiceProjectAttachment);
            _callListDiscoveredServices = clientHelper.BuildApiCall<ListDiscoveredServicesRequest, ListDiscoveredServicesResponse>("ListDiscoveredServices", grpcClient.ListDiscoveredServicesAsync, grpcClient.ListDiscoveredServices, effectiveSettings.ListDiscoveredServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDiscoveredServices);
            Modify_ListDiscoveredServicesApiCall(ref _callListDiscoveredServices);
            _callGetDiscoveredService = clientHelper.BuildApiCall<GetDiscoveredServiceRequest, DiscoveredService>("GetDiscoveredService", grpcClient.GetDiscoveredServiceAsync, grpcClient.GetDiscoveredService, effectiveSettings.GetDiscoveredServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDiscoveredService);
            Modify_GetDiscoveredServiceApiCall(ref _callGetDiscoveredService);
            _callLookupDiscoveredService = clientHelper.BuildApiCall<LookupDiscoveredServiceRequest, LookupDiscoveredServiceResponse>("LookupDiscoveredService", grpcClient.LookupDiscoveredServiceAsync, grpcClient.LookupDiscoveredService, effectiveSettings.LookupDiscoveredServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLookupDiscoveredService);
            Modify_LookupDiscoveredServiceApiCall(ref _callLookupDiscoveredService);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callCreateService = clientHelper.BuildApiCall<CreateServiceRequest, lro::Operation>("CreateService", grpcClient.CreateServiceAsync, grpcClient.CreateService, effectiveSettings.CreateServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateService);
            Modify_CreateServiceApiCall(ref _callCreateService);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callUpdateService = clientHelper.BuildApiCall<UpdateServiceRequest, lro::Operation>("UpdateService", grpcClient.UpdateServiceAsync, grpcClient.UpdateService, effectiveSettings.UpdateServiceSettings).WithGoogleRequestParam("service.name", request => request.Service?.Name);
            Modify_ApiCall(ref _callUpdateService);
            Modify_UpdateServiceApiCall(ref _callUpdateService);
            _callDeleteService = clientHelper.BuildApiCall<DeleteServiceRequest, lro::Operation>("DeleteService", grpcClient.DeleteServiceAsync, grpcClient.DeleteService, effectiveSettings.DeleteServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteService);
            Modify_DeleteServiceApiCall(ref _callDeleteService);
            _callListDiscoveredWorkloads = clientHelper.BuildApiCall<ListDiscoveredWorkloadsRequest, ListDiscoveredWorkloadsResponse>("ListDiscoveredWorkloads", grpcClient.ListDiscoveredWorkloadsAsync, grpcClient.ListDiscoveredWorkloads, effectiveSettings.ListDiscoveredWorkloadsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDiscoveredWorkloads);
            Modify_ListDiscoveredWorkloadsApiCall(ref _callListDiscoveredWorkloads);
            _callGetDiscoveredWorkload = clientHelper.BuildApiCall<GetDiscoveredWorkloadRequest, DiscoveredWorkload>("GetDiscoveredWorkload", grpcClient.GetDiscoveredWorkloadAsync, grpcClient.GetDiscoveredWorkload, effectiveSettings.GetDiscoveredWorkloadSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDiscoveredWorkload);
            Modify_GetDiscoveredWorkloadApiCall(ref _callGetDiscoveredWorkload);
            _callLookupDiscoveredWorkload = clientHelper.BuildApiCall<LookupDiscoveredWorkloadRequest, LookupDiscoveredWorkloadResponse>("LookupDiscoveredWorkload", grpcClient.LookupDiscoveredWorkloadAsync, grpcClient.LookupDiscoveredWorkload, effectiveSettings.LookupDiscoveredWorkloadSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLookupDiscoveredWorkload);
            Modify_LookupDiscoveredWorkloadApiCall(ref _callLookupDiscoveredWorkload);
            _callListWorkloads = clientHelper.BuildApiCall<ListWorkloadsRequest, ListWorkloadsResponse>("ListWorkloads", grpcClient.ListWorkloadsAsync, grpcClient.ListWorkloads, effectiveSettings.ListWorkloadsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkloads);
            Modify_ListWorkloadsApiCall(ref _callListWorkloads);
            _callCreateWorkload = clientHelper.BuildApiCall<CreateWorkloadRequest, lro::Operation>("CreateWorkload", grpcClient.CreateWorkloadAsync, grpcClient.CreateWorkload, effectiveSettings.CreateWorkloadSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkload);
            Modify_CreateWorkloadApiCall(ref _callCreateWorkload);
            _callGetWorkload = clientHelper.BuildApiCall<GetWorkloadRequest, Workload>("GetWorkload", grpcClient.GetWorkloadAsync, grpcClient.GetWorkload, effectiveSettings.GetWorkloadSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkload);
            Modify_GetWorkloadApiCall(ref _callGetWorkload);
            _callUpdateWorkload = clientHelper.BuildApiCall<UpdateWorkloadRequest, lro::Operation>("UpdateWorkload", grpcClient.UpdateWorkloadAsync, grpcClient.UpdateWorkload, effectiveSettings.UpdateWorkloadSettings).WithGoogleRequestParam("workload.name", request => request.Workload?.Name);
            Modify_ApiCall(ref _callUpdateWorkload);
            Modify_UpdateWorkloadApiCall(ref _callUpdateWorkload);
            _callDeleteWorkload = clientHelper.BuildApiCall<DeleteWorkloadRequest, lro::Operation>("DeleteWorkload", grpcClient.DeleteWorkloadAsync, grpcClient.DeleteWorkload, effectiveSettings.DeleteWorkloadSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkload);
            Modify_DeleteWorkloadApiCall(ref _callDeleteWorkload);
            _callListApplications = clientHelper.BuildApiCall<ListApplicationsRequest, ListApplicationsResponse>("ListApplications", grpcClient.ListApplicationsAsync, grpcClient.ListApplications, effectiveSettings.ListApplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplications);
            Modify_ListApplicationsApiCall(ref _callListApplications);
            _callCreateApplication = clientHelper.BuildApiCall<CreateApplicationRequest, lro::Operation>("CreateApplication", grpcClient.CreateApplicationAsync, grpcClient.CreateApplication, effectiveSettings.CreateApplicationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApplication);
            Modify_CreateApplicationApiCall(ref _callCreateApplication);
            _callGetApplication = clientHelper.BuildApiCall<GetApplicationRequest, Application>("GetApplication", grpcClient.GetApplicationAsync, grpcClient.GetApplication, effectiveSettings.GetApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplication);
            Modify_GetApplicationApiCall(ref _callGetApplication);
            _callUpdateApplication = clientHelper.BuildApiCall<UpdateApplicationRequest, lro::Operation>("UpdateApplication", grpcClient.UpdateApplicationAsync, grpcClient.UpdateApplication, effectiveSettings.UpdateApplicationSettings).WithGoogleRequestParam("application.name", request => request.Application?.Name);
            Modify_ApiCall(ref _callUpdateApplication);
            Modify_UpdateApplicationApiCall(ref _callUpdateApplication);
            _callDeleteApplication = clientHelper.BuildApiCall<DeleteApplicationRequest, lro::Operation>("DeleteApplication", grpcClient.DeleteApplicationAsync, grpcClient.DeleteApplication, effectiveSettings.DeleteApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApplication);
            Modify_DeleteApplicationApiCall(ref _callDeleteApplication);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_LookupServiceProjectAttachmentApiCall(ref gaxgrpc::ApiCall<LookupServiceProjectAttachmentRequest, LookupServiceProjectAttachmentResponse> call);

        partial void Modify_ListServiceProjectAttachmentsApiCall(ref gaxgrpc::ApiCall<ListServiceProjectAttachmentsRequest, ListServiceProjectAttachmentsResponse> call);

        partial void Modify_CreateServiceProjectAttachmentApiCall(ref gaxgrpc::ApiCall<CreateServiceProjectAttachmentRequest, lro::Operation> call);

        partial void Modify_GetServiceProjectAttachmentApiCall(ref gaxgrpc::ApiCall<GetServiceProjectAttachmentRequest, ServiceProjectAttachment> call);

        partial void Modify_DeleteServiceProjectAttachmentApiCall(ref gaxgrpc::ApiCall<DeleteServiceProjectAttachmentRequest, lro::Operation> call);

        partial void Modify_DetachServiceProjectAttachmentApiCall(ref gaxgrpc::ApiCall<DetachServiceProjectAttachmentRequest, DetachServiceProjectAttachmentResponse> call);

        partial void Modify_ListDiscoveredServicesApiCall(ref gaxgrpc::ApiCall<ListDiscoveredServicesRequest, ListDiscoveredServicesResponse> call);

        partial void Modify_GetDiscoveredServiceApiCall(ref gaxgrpc::ApiCall<GetDiscoveredServiceRequest, DiscoveredService> call);

        partial void Modify_LookupDiscoveredServiceApiCall(ref gaxgrpc::ApiCall<LookupDiscoveredServiceRequest, LookupDiscoveredServiceResponse> call);

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_CreateServiceApiCall(ref gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_UpdateServiceApiCall(ref gaxgrpc::ApiCall<UpdateServiceRequest, lro::Operation> call);

        partial void Modify_DeleteServiceApiCall(ref gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> call);

        partial void Modify_ListDiscoveredWorkloadsApiCall(ref gaxgrpc::ApiCall<ListDiscoveredWorkloadsRequest, ListDiscoveredWorkloadsResponse> call);

        partial void Modify_GetDiscoveredWorkloadApiCall(ref gaxgrpc::ApiCall<GetDiscoveredWorkloadRequest, DiscoveredWorkload> call);

        partial void Modify_LookupDiscoveredWorkloadApiCall(ref gaxgrpc::ApiCall<LookupDiscoveredWorkloadRequest, LookupDiscoveredWorkloadResponse> call);

        partial void Modify_ListWorkloadsApiCall(ref gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> call);

        partial void Modify_CreateWorkloadApiCall(ref gaxgrpc::ApiCall<CreateWorkloadRequest, lro::Operation> call);

        partial void Modify_GetWorkloadApiCall(ref gaxgrpc::ApiCall<GetWorkloadRequest, Workload> call);

        partial void Modify_UpdateWorkloadApiCall(ref gaxgrpc::ApiCall<UpdateWorkloadRequest, lro::Operation> call);

        partial void Modify_DeleteWorkloadApiCall(ref gaxgrpc::ApiCall<DeleteWorkloadRequest, lro::Operation> call);

        partial void Modify_ListApplicationsApiCall(ref gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> call);

        partial void Modify_CreateApplicationApiCall(ref gaxgrpc::ApiCall<CreateApplicationRequest, lro::Operation> call);

        partial void Modify_GetApplicationApiCall(ref gaxgrpc::ApiCall<GetApplicationRequest, Application> call);

        partial void Modify_UpdateApplicationApiCall(ref gaxgrpc::ApiCall<UpdateApplicationRequest, lro::Operation> call);

        partial void Modify_DeleteApplicationApiCall(ref gaxgrpc::ApiCall<DeleteApplicationRequest, lro::Operation> call);

        partial void OnConstruction(AppHub.AppHubClient grpcClient, AppHubSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AppHub client</summary>
        public override AppHub.AppHubClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_LookupServiceProjectAttachmentRequest(ref LookupServiceProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceProjectAttachmentsRequest(ref ListServiceProjectAttachmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceProjectAttachmentRequest(ref CreateServiceProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceProjectAttachmentRequest(ref GetServiceProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceProjectAttachmentRequest(ref DeleteServiceProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DetachServiceProjectAttachmentRequest(ref DetachServiceProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDiscoveredServicesRequest(ref ListDiscoveredServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDiscoveredServiceRequest(ref GetDiscoveredServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupDiscoveredServiceRequest(ref LookupDiscoveredServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceRequest(ref CreateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceRequest(ref UpdateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceRequest(ref DeleteServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDiscoveredWorkloadsRequest(ref ListDiscoveredWorkloadsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDiscoveredWorkloadRequest(ref GetDiscoveredWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupDiscoveredWorkloadRequest(ref LookupDiscoveredWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkloadsRequest(ref ListWorkloadsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkloadRequest(ref CreateWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkloadRequest(ref GetWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkloadRequest(ref UpdateWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkloadRequest(ref DeleteWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApplicationsRequest(ref ListApplicationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApplicationRequest(ref CreateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApplicationRequest(ref GetApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationRequest(ref UpdateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApplicationRequest(ref DeleteApplicationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupServiceProjectAttachmentResponse LookupServiceProjectAttachment(LookupServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupServiceProjectAttachmentRequest(ref request, ref callSettings);
            return _callLookupServiceProjectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists a service project attachment for a given service project. You can
        /// call this API from any project to find if it is attached to a host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupServiceProjectAttachmentResponse> LookupServiceProjectAttachmentAsync(LookupServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupServiceProjectAttachmentRequest(ref request, ref callSettings);
            return _callLookupServiceProjectAttachment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachments(ListServiceProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceProjectAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceProjectAttachmentsRequest, ListServiceProjectAttachmentsResponse, ServiceProjectAttachment>(_callListServiceProjectAttachments, request, callSettings);
        }

        /// <summary>
        /// Lists service projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceProjectAttachment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceProjectAttachmentsResponse, ServiceProjectAttachment> ListServiceProjectAttachmentsAsync(ListServiceProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceProjectAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceProjectAttachmentsRequest, ListServiceProjectAttachmentsResponse, ServiceProjectAttachment>(_callListServiceProjectAttachments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServiceProjectAttachment</c>.</summary>
        public override lro::OperationsClient CreateServiceProjectAttachmentOperationsClient { get; }

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceProjectAttachment, OperationMetadata> CreateServiceProjectAttachment(CreateServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceProjectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceProjectAttachment, OperationMetadata>(_callCreateServiceProjectAttachment.Sync(request, callSettings), CreateServiceProjectAttachmentOperationsClient);
        }

        /// <summary>
        /// Attaches a service project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceProjectAttachment, OperationMetadata>> CreateServiceProjectAttachmentAsync(CreateServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceProjectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceProjectAttachment, OperationMetadata>(await _callCreateServiceProjectAttachment.Async(request, callSettings).ConfigureAwait(false), CreateServiceProjectAttachmentOperationsClient);
        }

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceProjectAttachment GetServiceProjectAttachment(GetServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceProjectAttachmentRequest(ref request, ref callSettings);
            return _callGetServiceProjectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceProjectAttachment> GetServiceProjectAttachmentAsync(GetServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceProjectAttachmentRequest(ref request, ref callSettings);
            return _callGetServiceProjectAttachment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteServiceProjectAttachment</c>.</summary>
        public override lro::OperationsClient DeleteServiceProjectAttachmentOperationsClient { get; }

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteServiceProjectAttachment(DeleteServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceProjectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteServiceProjectAttachment.Sync(request, callSettings), DeleteServiceProjectAttachmentOperationsClient);
        }

        /// <summary>
        /// Deletes a service project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceProjectAttachmentAsync(DeleteServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceProjectAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteServiceProjectAttachment.Async(request, callSettings).ConfigureAwait(false), DeleteServiceProjectAttachmentOperationsClient);
        }

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DetachServiceProjectAttachmentResponse DetachServiceProjectAttachment(DetachServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachServiceProjectAttachmentRequest(ref request, ref callSettings);
            return _callDetachServiceProjectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Detaches a service project from a host project.
        /// You can call this API from any service project without needing access to
        /// the host project that it is attached to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DetachServiceProjectAttachmentResponse> DetachServiceProjectAttachmentAsync(DetachServiceProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachServiceProjectAttachmentRequest(ref request, ref callSettings);
            return _callDetachServiceProjectAttachment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredService"/> resources.</returns>
        public override gax::PagedEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServices(ListDiscoveredServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDiscoveredServicesRequest, ListDiscoveredServicesResponse, DiscoveredService>(_callListDiscoveredServices, request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Services that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredService"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDiscoveredServicesResponse, DiscoveredService> ListDiscoveredServicesAsync(ListDiscoveredServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDiscoveredServicesRequest, ListDiscoveredServicesResponse, DiscoveredService>(_callListDiscoveredServices, request, callSettings);
        }

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoveredService GetDiscoveredService(GetDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredServiceRequest(ref request, ref callSettings);
            return _callGetDiscoveredService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Discovered Service in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoveredService> GetDiscoveredServiceAsync(GetDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredServiceRequest(ref request, ref callSettings);
            return _callGetDiscoveredService.Async(request, callSettings);
        }

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupDiscoveredServiceResponse LookupDiscoveredService(LookupDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupDiscoveredServiceRequest(ref request, ref callSettings);
            return _callLookupDiscoveredService.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists a Discovered Service in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupDiscoveredServiceResponse> LookupDiscoveredServiceAsync(LookupDiscoveredServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupDiscoveredServiceRequest(ref request, ref callSettings);
            return _callLookupDiscoveredService.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists Services in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public override lro::OperationsClient CreateServiceOperationsClient { get; }

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Service, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(_callCreateService.Sync(request, callSettings), CreateServiceOperationsClient);
        }

        /// <summary>
        /// Creates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(await _callCreateService.Async(request, callSettings).ConfigureAwait(false), CreateServiceOperationsClient);
        }

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateService</c>.</summary>
        public override lro::OperationsClient UpdateServiceOperationsClient { get; }

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Service, OperationMetadata> UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(_callUpdateService.Sync(request, callSettings), UpdateServiceOperationsClient);
        }

        /// <summary>
        /// Updates a Service in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(await _callUpdateService.Async(request, callSettings).ConfigureAwait(false), UpdateServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public override lro::OperationsClient DeleteServiceOperationsClient { get; }

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteService.Sync(request, callSettings), DeleteServiceOperationsClient);
        }

        /// <summary>
        /// Deletes a Service from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteService.Async(request, callSettings).ConfigureAwait(false), DeleteServiceOperationsClient);
        }

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public override gax::PagedEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloads(ListDiscoveredWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDiscoveredWorkloadsRequest, ListDiscoveredWorkloadsResponse, DiscoveredWorkload>(_callListDiscoveredWorkloads, request, callSettings);
        }

        /// <summary>
        /// Lists Discovered Workloads that can be added to an Application in a host
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredWorkload"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDiscoveredWorkloadsResponse, DiscoveredWorkload> ListDiscoveredWorkloadsAsync(ListDiscoveredWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDiscoveredWorkloadsRequest, ListDiscoveredWorkloadsResponse, DiscoveredWorkload>(_callListDiscoveredWorkloads, request, callSettings);
        }

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoveredWorkload GetDiscoveredWorkload(GetDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredWorkloadRequest(ref request, ref callSettings);
            return _callGetDiscoveredWorkload.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Discovered Workload in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoveredWorkload> GetDiscoveredWorkloadAsync(GetDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredWorkloadRequest(ref request, ref callSettings);
            return _callGetDiscoveredWorkload.Async(request, callSettings);
        }

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupDiscoveredWorkloadResponse LookupDiscoveredWorkload(LookupDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupDiscoveredWorkloadRequest(ref request, ref callSettings);
            return _callLookupDiscoveredWorkload.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists a Discovered Workload in a host project and location, with a
        /// given resource URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupDiscoveredWorkloadResponse> LookupDiscoveredWorkloadAsync(LookupDiscoveredWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupDiscoveredWorkloadRequest(ref request, ref callSettings);
            return _callLookupDiscoveredWorkload.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, Workload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>
        /// Lists Workloads in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, Workload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkload</c>.</summary>
        public override lro::OperationsClient CreateWorkloadOperationsClient { get; }

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workload, OperationMetadata> CreateWorkload(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<Workload, OperationMetadata>(_callCreateWorkload.Sync(request, callSettings), CreateWorkloadOperationsClient);
        }

        /// <summary>
        /// Creates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workload, OperationMetadata>> CreateWorkloadAsync(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<Workload, OperationMetadata>(await _callCreateWorkload.Async(request, callSettings).ConfigureAwait(false), CreateWorkloadOperationsClient);
        }

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workload GetWorkload(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadRequest(ref request, ref callSettings);
            return _callGetWorkload.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadRequest(ref request, ref callSettings);
            return _callGetWorkload.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkload</c>.</summary>
        public override lro::OperationsClient UpdateWorkloadOperationsClient { get; }

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workload, OperationMetadata> UpdateWorkload(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<Workload, OperationMetadata>(_callUpdateWorkload.Sync(request, callSettings), UpdateWorkloadOperationsClient);
        }

        /// <summary>
        /// Updates a Workload in an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workload, OperationMetadata>> UpdateWorkloadAsync(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<Workload, OperationMetadata>(await _callUpdateWorkload.Async(request, callSettings).ConfigureAwait(false), UpdateWorkloadOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkload</c>.</summary>
        public override lro::OperationsClient DeleteWorkloadOperationsClient { get; }

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkload(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteWorkload.Sync(request, callSettings), DeleteWorkloadOperationsClient);
        }

        /// <summary>
        /// Deletes a Workload from an Application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkloadAsync(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteWorkload.Async(request, callSettings).ConfigureAwait(false), DeleteWorkloadOperationsClient);
        }

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// Lists Applications in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateApplication</c>.</summary>
        public override lro::OperationsClient CreateApplicationOperationsClient { get; }

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Application, OperationMetadata> CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(_callCreateApplication.Sync(request, callSettings), CreateApplicationOperationsClient);
        }

        /// <summary>
        /// Creates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Application, OperationMetadata>> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(await _callCreateApplication.Async(request, callSettings).ConfigureAwait(false), CreateApplicationOperationsClient);
        }

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateApplication</c>.</summary>
        public override lro::OperationsClient UpdateApplicationOperationsClient { get; }

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Application, OperationMetadata> UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(_callUpdateApplication.Sync(request, callSettings), UpdateApplicationOperationsClient);
        }

        /// <summary>
        /// Updates an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Application, OperationMetadata>> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadata>(await _callUpdateApplication.Async(request, callSettings).ConfigureAwait(false), UpdateApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteApplication</c>.</summary>
        public override lro::OperationsClient DeleteApplicationOperationsClient { get; }

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteApplication.Sync(request, callSettings), DeleteApplicationOperationsClient);
        }

        /// <summary>
        /// Deletes an Application in a host project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteApplication.Async(request, callSettings).ConfigureAwait(false), DeleteApplicationOperationsClient);
        }
    }

    public partial class ListServiceProjectAttachmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDiscoveredServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDiscoveredWorkloadsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkloadsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceProjectAttachmentsResponse : gaxgrpc::IPageResponse<ServiceProjectAttachment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceProjectAttachment> GetEnumerator() => ServiceProjectAttachments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDiscoveredServicesResponse : gaxgrpc::IPageResponse<DiscoveredService>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DiscoveredService> GetEnumerator() => DiscoveredServices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDiscoveredWorkloadsResponse : gaxgrpc::IPageResponse<DiscoveredWorkload>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DiscoveredWorkload> GetEnumerator() => DiscoveredWorkloads.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkloadsResponse : gaxgrpc::IPageResponse<Workload>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workload> GetEnumerator() => Workloads.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApplicationsResponse : gaxgrpc::IPageResponse<Application>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Application> GetEnumerator() => Applications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AppHub
    {
        public partial class AppHubClient
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

    public static partial class AppHub
    {
        public partial class AppHubClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
