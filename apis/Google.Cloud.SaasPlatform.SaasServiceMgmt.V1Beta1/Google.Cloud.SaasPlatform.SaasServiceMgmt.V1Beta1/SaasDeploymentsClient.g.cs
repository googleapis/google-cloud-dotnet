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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1
{
    /// <summary>Settings for <see cref="SaasDeploymentsClient"/> instances.</summary>
    public sealed partial class SaasDeploymentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SaasDeploymentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SaasDeploymentsSettings"/>.</returns>
        public static SaasDeploymentsSettings GetDefault() => new SaasDeploymentsSettings();

        /// <summary>Constructs a new <see cref="SaasDeploymentsSettings"/> object with default settings.</summary>
        public SaasDeploymentsSettings()
        {
        }

        private SaasDeploymentsSettings(SaasDeploymentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSaasSettings = existing.ListSaasSettings;
            GetSaasSettings = existing.GetSaasSettings;
            CreateSaasSettings = existing.CreateSaasSettings;
            UpdateSaasSettings = existing.UpdateSaasSettings;
            DeleteSaasSettings = existing.DeleteSaasSettings;
            ListTenantsSettings = existing.ListTenantsSettings;
            GetTenantSettings = existing.GetTenantSettings;
            CreateTenantSettings = existing.CreateTenantSettings;
            UpdateTenantSettings = existing.UpdateTenantSettings;
            DeleteTenantSettings = existing.DeleteTenantSettings;
            ListUnitKindsSettings = existing.ListUnitKindsSettings;
            GetUnitKindSettings = existing.GetUnitKindSettings;
            CreateUnitKindSettings = existing.CreateUnitKindSettings;
            UpdateUnitKindSettings = existing.UpdateUnitKindSettings;
            DeleteUnitKindSettings = existing.DeleteUnitKindSettings;
            ListUnitsSettings = existing.ListUnitsSettings;
            GetUnitSettings = existing.GetUnitSettings;
            CreateUnitSettings = existing.CreateUnitSettings;
            UpdateUnitSettings = existing.UpdateUnitSettings;
            DeleteUnitSettings = existing.DeleteUnitSettings;
            ListUnitOperationsSettings = existing.ListUnitOperationsSettings;
            GetUnitOperationSettings = existing.GetUnitOperationSettings;
            CreateUnitOperationSettings = existing.CreateUnitOperationSettings;
            UpdateUnitOperationSettings = existing.UpdateUnitOperationSettings;
            DeleteUnitOperationSettings = existing.DeleteUnitOperationSettings;
            ListReleasesSettings = existing.ListReleasesSettings;
            GetReleaseSettings = existing.GetReleaseSettings;
            CreateReleaseSettings = existing.CreateReleaseSettings;
            UpdateReleaseSettings = existing.UpdateReleaseSettings;
            DeleteReleaseSettings = existing.DeleteReleaseSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SaasDeploymentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.ListSaas</c> and <c>SaasDeploymentsClient.ListSaasAsync</c>.
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
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSaasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.GetSaas</c> and <c>SaasDeploymentsClient.GetSaasAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSaasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.CreateSaas</c> and <c>SaasDeploymentsClient.CreateSaasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSaasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.UpdateSaas</c> and <c>SaasDeploymentsClient.UpdateSaasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSaasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.DeleteSaas</c> and <c>SaasDeploymentsClient.DeleteSaasAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSaasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.ListTenants</c> and <c>SaasDeploymentsClient.ListTenantsAsync</c>.
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
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTenantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.GetTenant</c> and <c>SaasDeploymentsClient.GetTenantAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTenantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.CreateTenant</c> and <c>SaasDeploymentsClient.CreateTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTenantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.UpdateTenant</c> and <c>SaasDeploymentsClient.UpdateTenantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTenantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.DeleteTenant</c> and <c>SaasDeploymentsClient.DeleteTenantAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTenantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.ListUnitKinds</c> and <c>SaasDeploymentsClient.ListUnitKindsAsync</c>.
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
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUnitKindsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.GetUnitKind</c> and <c>SaasDeploymentsClient.GetUnitKindAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUnitKindSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.CreateUnitKind</c> and <c>SaasDeploymentsClient.CreateUnitKindAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUnitKindSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.UpdateUnitKind</c> and <c>SaasDeploymentsClient.UpdateUnitKindAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUnitKindSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.DeleteUnitKind</c> and <c>SaasDeploymentsClient.DeleteUnitKindAsync</c>.
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
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUnitKindSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.ListUnits</c> and <c>SaasDeploymentsClient.ListUnitsAsync</c>.
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
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUnitsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.GetUnit</c> and <c>SaasDeploymentsClient.GetUnitAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUnitSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.CreateUnit</c> and <c>SaasDeploymentsClient.CreateUnitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUnitSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.UpdateUnit</c> and <c>SaasDeploymentsClient.UpdateUnitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUnitSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.DeleteUnit</c> and <c>SaasDeploymentsClient.DeleteUnitAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUnitSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.ListUnitOperations</c> and <c>SaasDeploymentsClient.ListUnitOperationsAsync</c>.
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
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUnitOperationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.GetUnitOperation</c> and <c>SaasDeploymentsClient.GetUnitOperationAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUnitOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.CreateUnitOperation</c> and <c>SaasDeploymentsClient.CreateUnitOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUnitOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.UpdateUnitOperation</c> and <c>SaasDeploymentsClient.UpdateUnitOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUnitOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.DeleteUnitOperation</c> and <c>SaasDeploymentsClient.DeleteUnitOperationAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUnitOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.ListReleases</c> and <c>SaasDeploymentsClient.ListReleasesAsync</c>.
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
        /// <item><description>Timeout: 80 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReleasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(80000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.GetRelease</c> and <c>SaasDeploymentsClient.GetReleaseAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReleaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.CreateRelease</c> and <c>SaasDeploymentsClient.CreateReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReleaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.UpdateRelease</c> and <c>SaasDeploymentsClient.UpdateReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReleaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SaasDeploymentsClient.DeleteRelease</c> and <c>SaasDeploymentsClient.DeleteReleaseAsync</c>.
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
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReleaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SaasDeploymentsSettings"/> object.</returns>
        public SaasDeploymentsSettings Clone() => new SaasDeploymentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SaasDeploymentsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SaasDeploymentsClientBuilder : gaxgrpc::ClientBuilderBase<SaasDeploymentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SaasDeploymentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SaasDeploymentsClientBuilder() : base(SaasDeploymentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SaasDeploymentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SaasDeploymentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SaasDeploymentsClient Build()
        {
            SaasDeploymentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SaasDeploymentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SaasDeploymentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SaasDeploymentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SaasDeploymentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SaasDeploymentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SaasDeploymentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SaasDeploymentsClient.ChannelPool;
    }

    /// <summary>SaasDeployments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages the deployment of SaaS services.
    /// </remarks>
    public abstract partial class SaasDeploymentsClient
    {
        /// <summary>
        /// The default endpoint for the SaasDeployments service, which is a host of "saasservicemgmt.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "saasservicemgmt.googleapis.com:443";

        /// <summary>The default SaasDeployments scopes.</summary>
        /// <remarks>
        /// The default SaasDeployments scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SaasDeployments.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SaasDeploymentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SaasDeploymentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SaasDeploymentsClient"/>.</returns>
        public static stt::Task<SaasDeploymentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SaasDeploymentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SaasDeploymentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SaasDeploymentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SaasDeploymentsClient"/>.</returns>
        public static SaasDeploymentsClient Create() => new SaasDeploymentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SaasDeploymentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SaasDeploymentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SaasDeploymentsClient"/>.</returns>
        internal static SaasDeploymentsClient Create(grpccore::CallInvoker callInvoker, SaasDeploymentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SaasDeployments.SaasDeploymentsClient grpcClient = new SaasDeployments.SaasDeploymentsClient(callInvoker);
            return new SaasDeploymentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SaasDeployments client</summary>
        public virtual SaasDeployments.SaasDeploymentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Saas"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSaasResponse, Saas> ListSaas(ListSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Saas"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSaasResponse, Saas> ListSaasAsync(ListSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
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
        /// <returns>A pageable sequence of <see cref="Saas"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSaasResponse, Saas> ListSaas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSaasRequest request = new ListSaasRequest
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
            return ListSaas(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Saas"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSaasResponse, Saas> ListSaasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSaasRequest request = new ListSaasRequest
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
            return ListSaasAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
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
        /// <returns>A pageable sequence of <see cref="Saas"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSaasResponse, Saas> ListSaas(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSaasRequest request = new ListSaasRequest
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
            return ListSaas(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Saas"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSaasResponse, Saas> ListSaasAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSaasRequest request = new ListSaasRequest
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
            return ListSaasAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas GetSaas(GetSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> GetSaasAsync(GetSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> GetSaasAsync(GetSaasRequest request, st::CancellationToken cancellationToken) =>
            GetSaasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas GetSaas(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSaas(new GetSaasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> GetSaasAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSaasAsync(new GetSaasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> GetSaasAsync(string name, st::CancellationToken cancellationToken) =>
            GetSaasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas GetSaas(SaasName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSaas(new GetSaasRequest
            {
                SaasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> GetSaasAsync(SaasName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSaasAsync(new GetSaasRequest
            {
                SaasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> GetSaasAsync(SaasName name, st::CancellationToken cancellationToken) =>
            GetSaasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas CreateSaas(CreateSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> CreateSaasAsync(CreateSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> CreateSaasAsync(CreateSaasRequest request, st::CancellationToken cancellationToken) =>
            CreateSaasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
        /// </param>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="saasId">
        /// Required. The ID value for the new saas.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas CreateSaas(string parent, Saas saas, string saasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSaas(new CreateSaasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SaasId = gax::GaxPreconditions.CheckNotNullOrEmpty(saasId, nameof(saasId)),
                Saas = gax::GaxPreconditions.CheckNotNull(saas, nameof(saas)),
            }, callSettings);

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
        /// </param>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="saasId">
        /// Required. The ID value for the new saas.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> CreateSaasAsync(string parent, Saas saas, string saasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSaasAsync(new CreateSaasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SaasId = gax::GaxPreconditions.CheckNotNullOrEmpty(saasId, nameof(saasId)),
                Saas = gax::GaxPreconditions.CheckNotNull(saas, nameof(saas)),
            }, callSettings);

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
        /// </param>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="saasId">
        /// Required. The ID value for the new saas.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> CreateSaasAsync(string parent, Saas saas, string saasId, st::CancellationToken cancellationToken) =>
            CreateSaasAsync(parent, saas, saasId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
        /// </param>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="saasId">
        /// Required. The ID value for the new saas.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas CreateSaas(gagr::LocationName parent, Saas saas, string saasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSaas(new CreateSaasRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SaasId = gax::GaxPreconditions.CheckNotNullOrEmpty(saasId, nameof(saasId)),
                Saas = gax::GaxPreconditions.CheckNotNull(saas, nameof(saas)),
            }, callSettings);

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
        /// </param>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="saasId">
        /// Required. The ID value for the new saas.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> CreateSaasAsync(gagr::LocationName parent, Saas saas, string saasId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSaasAsync(new CreateSaasRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SaasId = gax::GaxPreconditions.CheckNotNullOrEmpty(saasId, nameof(saasId)),
                Saas = gax::GaxPreconditions.CheckNotNull(saas, nameof(saas)),
            }, callSettings);

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the saas.
        /// </param>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="saasId">
        /// Required. The ID value for the new saas.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> CreateSaasAsync(gagr::LocationName parent, Saas saas, string saasId, st::CancellationToken cancellationToken) =>
            CreateSaasAsync(parent, saas, saasId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas UpdateSaas(UpdateSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> UpdateSaasAsync(UpdateSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> UpdateSaasAsync(UpdateSaasRequest request, st::CancellationToken cancellationToken) =>
            UpdateSaasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Saas resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Saas will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Saas UpdateSaas(Saas saas, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSaas(new UpdateSaasRequest
            {
                Saas = gax::GaxPreconditions.CheckNotNull(saas, nameof(saas)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Saas resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Saas will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> UpdateSaasAsync(Saas saas, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSaasAsync(new UpdateSaasRequest
            {
                Saas = gax::GaxPreconditions.CheckNotNull(saas, nameof(saas)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="saas">
        /// Required. The desired state for the saas.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Saas resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Saas will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Saas> UpdateSaasAsync(Saas saas, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSaasAsync(saas, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSaas(DeleteSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSaasAsync(DeleteSaasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSaasAsync(DeleteSaasRequest request, st::CancellationToken cancellationToken) =>
            DeleteSaasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSaas(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSaas(new DeleteSaasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSaasAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSaasAsync(new DeleteSaasRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSaasAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSaasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSaas(SaasName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSaas(new DeleteSaasRequest
            {
                SaasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSaasAsync(SaasName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSaasAsync(new DeleteSaasRequest
            {
                SaasName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSaasAsync(SaasName name, st::CancellationToken cancellationToken) =>
            DeleteSaasAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
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
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
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
            return ListTenants(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
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
            return ListTenantsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
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
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
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
            return ListTenants(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTenantsRequest request = new ListTenantsRequest
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
            return ListTenantsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant GetTenant(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(GetTenantRequest request, st::CancellationToken cancellationToken) =>
            GetTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant GetTenant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenant(new GetTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenantAsync(new GetTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(string name, st::CancellationToken cancellationToken) =>
            GetTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant GetTenant(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenant(new GetTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTenantAsync(new GetTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> GetTenantAsync(TenantName name, st::CancellationToken cancellationToken) =>
            GetTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant CreateTenant(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(CreateTenantRequest request, st::CancellationToken cancellationToken) =>
            CreateTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
        /// </param>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="tenantId">
        /// Required. The ID value for the new tenant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant CreateTenant(string parent, Tenant tenant, string tenantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenant(new CreateTenantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TenantId = gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
        /// </param>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="tenantId">
        /// Required. The ID value for the new tenant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(string parent, Tenant tenant, string tenantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenantAsync(new CreateTenantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TenantId = gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
        /// </param>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="tenantId">
        /// Required. The ID value for the new tenant.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(string parent, Tenant tenant, string tenantId, st::CancellationToken cancellationToken) =>
            CreateTenantAsync(parent, tenant, tenantId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
        /// </param>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="tenantId">
        /// Required. The ID value for the new tenant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant CreateTenant(gagr::LocationName parent, Tenant tenant, string tenantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenant(new CreateTenantRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TenantId = gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
        /// </param>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="tenantId">
        /// Required. The ID value for the new tenant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(gagr::LocationName parent, Tenant tenant, string tenantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTenantAsync(new CreateTenantRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TenantId = gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)),
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
            }, callSettings);

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the tenant.
        /// </param>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="tenantId">
        /// Required. The ID value for the new tenant.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> CreateTenantAsync(gagr::LocationName parent, Tenant tenant, string tenantId, st::CancellationToken cancellationToken) =>
            CreateTenantAsync(parent, tenant, tenantId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant UpdateTenant(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(UpdateTenantRequest request, st::CancellationToken cancellationToken) =>
            UpdateTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Tenant resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Tenant will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tenant UpdateTenant(Tenant tenant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTenant(new UpdateTenantRequest
            {
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Tenant resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Tenant will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(Tenant tenant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTenantAsync(new UpdateTenantRequest
            {
                Tenant = gax::GaxPreconditions.CheckNotNull(tenant, nameof(tenant)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="tenant">
        /// Required. The desired state for the tenant.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Tenant resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Tenant will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tenant> UpdateTenantAsync(Tenant tenant, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTenantAsync(tenant, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTenant(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(DeleteTenantRequest request, st::CancellationToken cancellationToken) =>
            DeleteTenantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTenant(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenant(new DeleteTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenantAsync(new DeleteTenantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTenant(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenant(new DeleteTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(TenantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTenantAsync(new DeleteTenantRequest
            {
                TenantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTenantAsync(TenantName name, st::CancellationToken cancellationToken) =>
            DeleteTenantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UnitKind"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKinds(ListUnitKindsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UnitKind"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKindsAsync(ListUnitKindsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
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
        /// <returns>A pageable sequence of <see cref="UnitKind"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKinds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitKindsRequest request = new ListUnitKindsRequest
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
            return ListUnitKinds(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UnitKind"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKindsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitKindsRequest request = new ListUnitKindsRequest
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
            return ListUnitKindsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
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
        /// <returns>A pageable sequence of <see cref="UnitKind"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKinds(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitKindsRequest request = new ListUnitKindsRequest
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
            return ListUnitKinds(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UnitKind"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKindsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitKindsRequest request = new ListUnitKindsRequest
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
            return ListUnitKindsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind GetUnitKind(GetUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> GetUnitKindAsync(GetUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> GetUnitKindAsync(GetUnitKindRequest request, st::CancellationToken cancellationToken) =>
            GetUnitKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind GetUnitKind(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitKind(new GetUnitKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> GetUnitKindAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitKindAsync(new GetUnitKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> GetUnitKindAsync(string name, st::CancellationToken cancellationToken) =>
            GetUnitKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind GetUnitKind(UnitKindName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitKind(new GetUnitKindRequest
            {
                UnitKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> GetUnitKindAsync(UnitKindName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitKindAsync(new GetUnitKindRequest
            {
                UnitKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> GetUnitKindAsync(UnitKindName name, st::CancellationToken cancellationToken) =>
            GetUnitKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind CreateUnitKind(CreateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> CreateUnitKindAsync(CreateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> CreateUnitKindAsync(CreateUnitKindRequest request, st::CancellationToken cancellationToken) =>
            CreateUnitKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
        /// </param>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="unitKindId">
        /// Required. The ID value for the new unit kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind CreateUnitKind(string parent, UnitKind unitKind, string unitKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitKind(new CreateUnitKindRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UnitKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitKindId, nameof(unitKindId)),
                UnitKind = gax::GaxPreconditions.CheckNotNull(unitKind, nameof(unitKind)),
            }, callSettings);

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
        /// </param>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="unitKindId">
        /// Required. The ID value for the new unit kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> CreateUnitKindAsync(string parent, UnitKind unitKind, string unitKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitKindAsync(new CreateUnitKindRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UnitKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitKindId, nameof(unitKindId)),
                UnitKind = gax::GaxPreconditions.CheckNotNull(unitKind, nameof(unitKind)),
            }, callSettings);

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
        /// </param>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="unitKindId">
        /// Required. The ID value for the new unit kind.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> CreateUnitKindAsync(string parent, UnitKind unitKind, string unitKindId, st::CancellationToken cancellationToken) =>
            CreateUnitKindAsync(parent, unitKind, unitKindId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
        /// </param>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="unitKindId">
        /// Required. The ID value for the new unit kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind CreateUnitKind(gagr::LocationName parent, UnitKind unitKind, string unitKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitKind(new CreateUnitKindRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UnitKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitKindId, nameof(unitKindId)),
                UnitKind = gax::GaxPreconditions.CheckNotNull(unitKind, nameof(unitKind)),
            }, callSettings);

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
        /// </param>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="unitKindId">
        /// Required. The ID value for the new unit kind.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> CreateUnitKindAsync(gagr::LocationName parent, UnitKind unitKind, string unitKindId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitKindAsync(new CreateUnitKindRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UnitKindId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitKindId, nameof(unitKindId)),
                UnitKind = gax::GaxPreconditions.CheckNotNull(unitKind, nameof(unitKind)),
            }, callSettings);

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit kind.
        /// </param>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="unitKindId">
        /// Required. The ID value for the new unit kind.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> CreateUnitKindAsync(gagr::LocationName parent, UnitKind unitKind, string unitKindId, st::CancellationToken cancellationToken) =>
            CreateUnitKindAsync(parent, unitKind, unitKindId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind UpdateUnitKind(UpdateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> UpdateUnitKindAsync(UpdateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> UpdateUnitKindAsync(UpdateUnitKindRequest request, st::CancellationToken cancellationToken) =>
            UpdateUnitKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// UnitKind resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// UnitKind will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitKind UpdateUnitKind(UnitKind unitKind, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUnitKind(new UpdateUnitKindRequest
            {
                UnitKind = gax::GaxPreconditions.CheckNotNull(unitKind, nameof(unitKind)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// UnitKind resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// UnitKind will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> UpdateUnitKindAsync(UnitKind unitKind, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUnitKindAsync(new UpdateUnitKindRequest
            {
                UnitKind = gax::GaxPreconditions.CheckNotNull(unitKind, nameof(unitKind)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="unitKind">
        /// Required. The desired state for the unit kind.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// UnitKind resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// UnitKind will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitKind> UpdateUnitKindAsync(UnitKind unitKind, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUnitKindAsync(unitKind, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnitKind(DeleteUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitKindAsync(DeleteUnitKindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitKindAsync(DeleteUnitKindRequest request, st::CancellationToken cancellationToken) =>
            DeleteUnitKindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnitKind(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitKind(new DeleteUnitKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitKindAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitKindAsync(new DeleteUnitKindRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitKindAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUnitKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnitKind(UnitKindName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitKind(new DeleteUnitKindRequest
            {
                UnitKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitKindAsync(UnitKindName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitKindAsync(new DeleteUnitKindRequest
            {
                UnitKindName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitKindAsync(UnitKindName name, st::CancellationToken cancellationToken) =>
            DeleteUnitKindAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Unit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitsResponse, Unit> ListUnits(ListUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Unit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitsResponse, Unit> ListUnitsAsync(ListUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
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
        /// <returns>A pageable sequence of <see cref="Unit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitsResponse, Unit> ListUnits(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitsRequest request = new ListUnitsRequest
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
            return ListUnits(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Unit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitsResponse, Unit> ListUnitsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitsRequest request = new ListUnitsRequest
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
            return ListUnitsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
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
        /// <returns>A pageable sequence of <see cref="Unit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitsResponse, Unit> ListUnits(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitsRequest request = new ListUnitsRequest
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
            return ListUnits(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Unit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitsResponse, Unit> ListUnitsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitsRequest request = new ListUnitsRequest
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
            return ListUnitsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit GetUnit(GetUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> GetUnitAsync(GetUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> GetUnitAsync(GetUnitRequest request, st::CancellationToken cancellationToken) =>
            GetUnitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit GetUnit(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnit(new GetUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> GetUnitAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitAsync(new GetUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> GetUnitAsync(string name, st::CancellationToken cancellationToken) =>
            GetUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit GetUnit(UnitName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnit(new GetUnitRequest
            {
                UnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> GetUnitAsync(UnitName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitAsync(new GetUnitRequest
            {
                UnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> GetUnitAsync(UnitName name, st::CancellationToken cancellationToken) =>
            GetUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit CreateUnit(CreateUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> CreateUnitAsync(CreateUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> CreateUnitAsync(CreateUnitRequest request, st::CancellationToken cancellationToken) =>
            CreateUnitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
        /// </param>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="unitId">
        /// Required. The ID value for the new unit.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit CreateUnit(string parent, Unit unit, string unitId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnit(new CreateUnitRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UnitId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitId, nameof(unitId)),
                Unit = gax::GaxPreconditions.CheckNotNull(unit, nameof(unit)),
            }, callSettings);

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
        /// </param>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="unitId">
        /// Required. The ID value for the new unit.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> CreateUnitAsync(string parent, Unit unit, string unitId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitAsync(new CreateUnitRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UnitId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitId, nameof(unitId)),
                Unit = gax::GaxPreconditions.CheckNotNull(unit, nameof(unit)),
            }, callSettings);

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
        /// </param>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="unitId">
        /// Required. The ID value for the new unit.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> CreateUnitAsync(string parent, Unit unit, string unitId, st::CancellationToken cancellationToken) =>
            CreateUnitAsync(parent, unit, unitId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
        /// </param>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="unitId">
        /// Required. The ID value for the new unit.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit CreateUnit(gagr::LocationName parent, Unit unit, string unitId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnit(new CreateUnitRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UnitId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitId, nameof(unitId)),
                Unit = gax::GaxPreconditions.CheckNotNull(unit, nameof(unit)),
            }, callSettings);

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
        /// </param>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="unitId">
        /// Required. The ID value for the new unit.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> CreateUnitAsync(gagr::LocationName parent, Unit unit, string unitId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitAsync(new CreateUnitRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UnitId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitId, nameof(unitId)),
                Unit = gax::GaxPreconditions.CheckNotNull(unit, nameof(unit)),
            }, callSettings);

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit.
        /// </param>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="unitId">
        /// Required. The ID value for the new unit.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> CreateUnitAsync(gagr::LocationName parent, Unit unit, string unitId, st::CancellationToken cancellationToken) =>
            CreateUnitAsync(parent, unit, unitId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit UpdateUnit(UpdateUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> UpdateUnitAsync(UpdateUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> UpdateUnitAsync(UpdateUnitRequest request, st::CancellationToken cancellationToken) =>
            UpdateUnitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Unit resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Unit will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Unit UpdateUnit(Unit unit, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUnit(new UpdateUnitRequest
            {
                Unit = gax::GaxPreconditions.CheckNotNull(unit, nameof(unit)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Unit resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Unit will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> UpdateUnitAsync(Unit unit, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUnitAsync(new UpdateUnitRequest
            {
                Unit = gax::GaxPreconditions.CheckNotNull(unit, nameof(unit)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="unit">
        /// Required. The desired state for the unit.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Unit resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Unit will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Unit> UpdateUnitAsync(Unit unit, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUnitAsync(unit, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnit(DeleteUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitAsync(DeleteUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitAsync(DeleteUnitRequest request, st::CancellationToken cancellationToken) =>
            DeleteUnitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnit(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnit(new DeleteUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitAsync(new DeleteUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnit(UnitName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnit(new DeleteUnitRequest
            {
                UnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitAsync(UnitName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitAsync(new DeleteUnitRequest
            {
                UnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitAsync(UnitName name, st::CancellationToken cancellationToken) =>
            DeleteUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UnitOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperations(ListUnitOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UnitOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperationsAsync(ListUnitOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
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
        /// <returns>A pageable sequence of <see cref="UnitOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitOperationsRequest request = new ListUnitOperationsRequest
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
            return ListUnitOperations(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UnitOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitOperationsRequest request = new ListUnitOperationsRequest
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
            return ListUnitOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
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
        /// <returns>A pageable sequence of <see cref="UnitOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitOperationsRequest request = new ListUnitOperationsRequest
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
            return ListUnitOperations(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UnitOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUnitOperationsRequest request = new ListUnitOperationsRequest
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
            return ListUnitOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation GetUnitOperation(GetUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> GetUnitOperationAsync(GetUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> GetUnitOperationAsync(GetUnitOperationRequest request, st::CancellationToken cancellationToken) =>
            GetUnitOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation GetUnitOperation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitOperation(new GetUnitOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> GetUnitOperationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitOperationAsync(new GetUnitOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> GetUnitOperationAsync(string name, st::CancellationToken cancellationToken) =>
            GetUnitOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation GetUnitOperation(UnitOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitOperation(new GetUnitOperationRequest
            {
                UnitOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> GetUnitOperationAsync(UnitOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUnitOperationAsync(new GetUnitOperationRequest
            {
                UnitOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> GetUnitOperationAsync(UnitOperationName name, st::CancellationToken cancellationToken) =>
            GetUnitOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation CreateUnitOperation(CreateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> CreateUnitOperationAsync(CreateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> CreateUnitOperationAsync(CreateUnitOperationRequest request, st::CancellationToken cancellationToken) =>
            CreateUnitOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
        /// </param>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="unitOperationId">
        /// Required. The ID value for the new unit operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation CreateUnitOperation(string parent, UnitOperation unitOperation, string unitOperationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitOperation(new CreateUnitOperationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UnitOperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitOperationId, nameof(unitOperationId)),
                UnitOperation = gax::GaxPreconditions.CheckNotNull(unitOperation, nameof(unitOperation)),
            }, callSettings);

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
        /// </param>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="unitOperationId">
        /// Required. The ID value for the new unit operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> CreateUnitOperationAsync(string parent, UnitOperation unitOperation, string unitOperationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitOperationAsync(new CreateUnitOperationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UnitOperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitOperationId, nameof(unitOperationId)),
                UnitOperation = gax::GaxPreconditions.CheckNotNull(unitOperation, nameof(unitOperation)),
            }, callSettings);

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
        /// </param>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="unitOperationId">
        /// Required. The ID value for the new unit operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> CreateUnitOperationAsync(string parent, UnitOperation unitOperation, string unitOperationId, st::CancellationToken cancellationToken) =>
            CreateUnitOperationAsync(parent, unitOperation, unitOperationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
        /// </param>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="unitOperationId">
        /// Required. The ID value for the new unit operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation CreateUnitOperation(gagr::LocationName parent, UnitOperation unitOperation, string unitOperationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitOperation(new CreateUnitOperationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UnitOperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitOperationId, nameof(unitOperationId)),
                UnitOperation = gax::GaxPreconditions.CheckNotNull(unitOperation, nameof(unitOperation)),
            }, callSettings);

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
        /// </param>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="unitOperationId">
        /// Required. The ID value for the new unit operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> CreateUnitOperationAsync(gagr::LocationName parent, UnitOperation unitOperation, string unitOperationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUnitOperationAsync(new CreateUnitOperationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UnitOperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(unitOperationId, nameof(unitOperationId)),
                UnitOperation = gax::GaxPreconditions.CheckNotNull(unitOperation, nameof(unitOperation)),
            }, callSettings);

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the unit operation.
        /// </param>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="unitOperationId">
        /// Required. The ID value for the new unit operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> CreateUnitOperationAsync(gagr::LocationName parent, UnitOperation unitOperation, string unitOperationId, st::CancellationToken cancellationToken) =>
            CreateUnitOperationAsync(parent, unitOperation, unitOperationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation UpdateUnitOperation(UpdateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> UpdateUnitOperationAsync(UpdateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> UpdateUnitOperationAsync(UpdateUnitOperationRequest request, st::CancellationToken cancellationToken) =>
            UpdateUnitOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// UnitOperation resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// UnitOperation will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnitOperation UpdateUnitOperation(UnitOperation unitOperation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUnitOperation(new UpdateUnitOperationRequest
            {
                UnitOperation = gax::GaxPreconditions.CheckNotNull(unitOperation, nameof(unitOperation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// UnitOperation resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// UnitOperation will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> UpdateUnitOperationAsync(UnitOperation unitOperation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUnitOperationAsync(new UpdateUnitOperationRequest
            {
                UnitOperation = gax::GaxPreconditions.CheckNotNull(unitOperation, nameof(unitOperation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="unitOperation">
        /// Required. The desired state for the unit operation.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// UnitOperation resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// UnitOperation will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnitOperation> UpdateUnitOperationAsync(UnitOperation unitOperation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUnitOperationAsync(unitOperation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnitOperation(DeleteUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitOperationAsync(DeleteUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitOperationAsync(DeleteUnitOperationRequest request, st::CancellationToken cancellationToken) =>
            DeleteUnitOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnitOperation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitOperation(new DeleteUnitOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitOperationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitOperationAsync(new DeleteUnitOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitOperationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUnitOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUnitOperation(UnitOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitOperation(new DeleteUnitOperationRequest
            {
                UnitOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitOperationAsync(UnitOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUnitOperationAsync(new DeleteUnitOperationRequest
            {
                UnitOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUnitOperationAsync(UnitOperationName name, st::CancellationToken cancellationToken) =>
            DeleteUnitOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
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
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
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
            return ListReleases(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
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
            return ListReleasesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
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
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
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
            return ListReleases(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
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
            return ListReleasesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRelease(new GetReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseAsync(new GetReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRelease(new GetReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseAsync(new GetReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(ReleaseName name, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release CreateRelease(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> CreateReleaseAsync(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> CreateReleaseAsync(CreateReleaseRequest request, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
        /// </param>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="releaseId">
        /// Required. The ID value for the new release.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release CreateRelease(string parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRelease(new CreateReleaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
        /// </param>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="releaseId">
        /// Required. The ID value for the new release.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> CreateReleaseAsync(string parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseAsync(new CreateReleaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
        /// </param>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="releaseId">
        /// Required. The ID value for the new release.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> CreateReleaseAsync(string parent, Release release, string releaseId, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(parent, release, releaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
        /// </param>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="releaseId">
        /// Required. The ID value for the new release.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release CreateRelease(gagr::LocationName parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRelease(new CreateReleaseRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
        /// </param>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="releaseId">
        /// Required. The ID value for the new release.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> CreateReleaseAsync(gagr::LocationName parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseAsync(new CreateReleaseRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the release.
        /// </param>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="releaseId">
        /// Required. The ID value for the new release.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> CreateReleaseAsync(gagr::LocationName parent, Release release, string releaseId, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(parent, release, releaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release UpdateRelease(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> UpdateReleaseAsync(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> UpdateReleaseAsync(UpdateReleaseRequest request, st::CancellationToken cancellationToken) =>
            UpdateReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Release resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Release will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release UpdateRelease(Release release, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRelease(new UpdateReleaseRequest
            {
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Release resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Release will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> UpdateReleaseAsync(Release release, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReleaseAsync(new UpdateReleaseRequest
            {
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="release">
        /// Required. The desired state for the release.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Release resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// 
        /// If the user does not provide a mask then all fields in the
        /// Release will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> UpdateReleaseAsync(Release release, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReleaseAsync(release, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRelease(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseAsync(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseAsync(DeleteReleaseRequest request, st::CancellationToken cancellationToken) =>
            DeleteReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRelease(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRelease(new DeleteReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseAsync(new DeleteReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRelease(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRelease(new DeleteReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseAsync(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseAsync(new DeleteReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseAsync(ReleaseName name, st::CancellationToken cancellationToken) =>
            DeleteReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SaasDeployments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages the deployment of SaaS services.
    /// </remarks>
    public sealed partial class SaasDeploymentsClientImpl : SaasDeploymentsClient
    {
        private readonly gaxgrpc::ApiCall<ListSaasRequest, ListSaasResponse> _callListSaas;

        private readonly gaxgrpc::ApiCall<GetSaasRequest, Saas> _callGetSaas;

        private readonly gaxgrpc::ApiCall<CreateSaasRequest, Saas> _callCreateSaas;

        private readonly gaxgrpc::ApiCall<UpdateSaasRequest, Saas> _callUpdateSaas;

        private readonly gaxgrpc::ApiCall<DeleteSaasRequest, wkt::Empty> _callDeleteSaas;

        private readonly gaxgrpc::ApiCall<ListTenantsRequest, ListTenantsResponse> _callListTenants;

        private readonly gaxgrpc::ApiCall<GetTenantRequest, Tenant> _callGetTenant;

        private readonly gaxgrpc::ApiCall<CreateTenantRequest, Tenant> _callCreateTenant;

        private readonly gaxgrpc::ApiCall<UpdateTenantRequest, Tenant> _callUpdateTenant;

        private readonly gaxgrpc::ApiCall<DeleteTenantRequest, wkt::Empty> _callDeleteTenant;

        private readonly gaxgrpc::ApiCall<ListUnitKindsRequest, ListUnitKindsResponse> _callListUnitKinds;

        private readonly gaxgrpc::ApiCall<GetUnitKindRequest, UnitKind> _callGetUnitKind;

        private readonly gaxgrpc::ApiCall<CreateUnitKindRequest, UnitKind> _callCreateUnitKind;

        private readonly gaxgrpc::ApiCall<UpdateUnitKindRequest, UnitKind> _callUpdateUnitKind;

        private readonly gaxgrpc::ApiCall<DeleteUnitKindRequest, wkt::Empty> _callDeleteUnitKind;

        private readonly gaxgrpc::ApiCall<ListUnitsRequest, ListUnitsResponse> _callListUnits;

        private readonly gaxgrpc::ApiCall<GetUnitRequest, Unit> _callGetUnit;

        private readonly gaxgrpc::ApiCall<CreateUnitRequest, Unit> _callCreateUnit;

        private readonly gaxgrpc::ApiCall<UpdateUnitRequest, Unit> _callUpdateUnit;

        private readonly gaxgrpc::ApiCall<DeleteUnitRequest, wkt::Empty> _callDeleteUnit;

        private readonly gaxgrpc::ApiCall<ListUnitOperationsRequest, ListUnitOperationsResponse> _callListUnitOperations;

        private readonly gaxgrpc::ApiCall<GetUnitOperationRequest, UnitOperation> _callGetUnitOperation;

        private readonly gaxgrpc::ApiCall<CreateUnitOperationRequest, UnitOperation> _callCreateUnitOperation;

        private readonly gaxgrpc::ApiCall<UpdateUnitOperationRequest, UnitOperation> _callUpdateUnitOperation;

        private readonly gaxgrpc::ApiCall<DeleteUnitOperationRequest, wkt::Empty> _callDeleteUnitOperation;

        private readonly gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> _callListReleases;

        private readonly gaxgrpc::ApiCall<GetReleaseRequest, Release> _callGetRelease;

        private readonly gaxgrpc::ApiCall<CreateReleaseRequest, Release> _callCreateRelease;

        private readonly gaxgrpc::ApiCall<UpdateReleaseRequest, Release> _callUpdateRelease;

        private readonly gaxgrpc::ApiCall<DeleteReleaseRequest, wkt::Empty> _callDeleteRelease;

        /// <summary>
        /// Constructs a client wrapper for the SaasDeployments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SaasDeploymentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SaasDeploymentsClientImpl(SaasDeployments.SaasDeploymentsClient grpcClient, SaasDeploymentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SaasDeploymentsSettings effectiveSettings = settings ?? SaasDeploymentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListSaas = clientHelper.BuildApiCall<ListSaasRequest, ListSaasResponse>("ListSaas", grpcClient.ListSaasAsync, grpcClient.ListSaas, effectiveSettings.ListSaasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSaas);
            Modify_ListSaasApiCall(ref _callListSaas);
            _callGetSaas = clientHelper.BuildApiCall<GetSaasRequest, Saas>("GetSaas", grpcClient.GetSaasAsync, grpcClient.GetSaas, effectiveSettings.GetSaasSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSaas);
            Modify_GetSaasApiCall(ref _callGetSaas);
            _callCreateSaas = clientHelper.BuildApiCall<CreateSaasRequest, Saas>("CreateSaas", grpcClient.CreateSaasAsync, grpcClient.CreateSaas, effectiveSettings.CreateSaasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSaas);
            Modify_CreateSaasApiCall(ref _callCreateSaas);
            _callUpdateSaas = clientHelper.BuildApiCall<UpdateSaasRequest, Saas>("UpdateSaas", grpcClient.UpdateSaasAsync, grpcClient.UpdateSaas, effectiveSettings.UpdateSaasSettings).WithGoogleRequestParam("saas.name", request => request.Saas?.Name);
            Modify_ApiCall(ref _callUpdateSaas);
            Modify_UpdateSaasApiCall(ref _callUpdateSaas);
            _callDeleteSaas = clientHelper.BuildApiCall<DeleteSaasRequest, wkt::Empty>("DeleteSaas", grpcClient.DeleteSaasAsync, grpcClient.DeleteSaas, effectiveSettings.DeleteSaasSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSaas);
            Modify_DeleteSaasApiCall(ref _callDeleteSaas);
            _callListTenants = clientHelper.BuildApiCall<ListTenantsRequest, ListTenantsResponse>("ListTenants", grpcClient.ListTenantsAsync, grpcClient.ListTenants, effectiveSettings.ListTenantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTenants);
            Modify_ListTenantsApiCall(ref _callListTenants);
            _callGetTenant = clientHelper.BuildApiCall<GetTenantRequest, Tenant>("GetTenant", grpcClient.GetTenantAsync, grpcClient.GetTenant, effectiveSettings.GetTenantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTenant);
            Modify_GetTenantApiCall(ref _callGetTenant);
            _callCreateTenant = clientHelper.BuildApiCall<CreateTenantRequest, Tenant>("CreateTenant", grpcClient.CreateTenantAsync, grpcClient.CreateTenant, effectiveSettings.CreateTenantSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTenant);
            Modify_CreateTenantApiCall(ref _callCreateTenant);
            _callUpdateTenant = clientHelper.BuildApiCall<UpdateTenantRequest, Tenant>("UpdateTenant", grpcClient.UpdateTenantAsync, grpcClient.UpdateTenant, effectiveSettings.UpdateTenantSettings).WithGoogleRequestParam("tenant.name", request => request.Tenant?.Name);
            Modify_ApiCall(ref _callUpdateTenant);
            Modify_UpdateTenantApiCall(ref _callUpdateTenant);
            _callDeleteTenant = clientHelper.BuildApiCall<DeleteTenantRequest, wkt::Empty>("DeleteTenant", grpcClient.DeleteTenantAsync, grpcClient.DeleteTenant, effectiveSettings.DeleteTenantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTenant);
            Modify_DeleteTenantApiCall(ref _callDeleteTenant);
            _callListUnitKinds = clientHelper.BuildApiCall<ListUnitKindsRequest, ListUnitKindsResponse>("ListUnitKinds", grpcClient.ListUnitKindsAsync, grpcClient.ListUnitKinds, effectiveSettings.ListUnitKindsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUnitKinds);
            Modify_ListUnitKindsApiCall(ref _callListUnitKinds);
            _callGetUnitKind = clientHelper.BuildApiCall<GetUnitKindRequest, UnitKind>("GetUnitKind", grpcClient.GetUnitKindAsync, grpcClient.GetUnitKind, effectiveSettings.GetUnitKindSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUnitKind);
            Modify_GetUnitKindApiCall(ref _callGetUnitKind);
            _callCreateUnitKind = clientHelper.BuildApiCall<CreateUnitKindRequest, UnitKind>("CreateUnitKind", grpcClient.CreateUnitKindAsync, grpcClient.CreateUnitKind, effectiveSettings.CreateUnitKindSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUnitKind);
            Modify_CreateUnitKindApiCall(ref _callCreateUnitKind);
            _callUpdateUnitKind = clientHelper.BuildApiCall<UpdateUnitKindRequest, UnitKind>("UpdateUnitKind", grpcClient.UpdateUnitKindAsync, grpcClient.UpdateUnitKind, effectiveSettings.UpdateUnitKindSettings).WithGoogleRequestParam("unit_kind.name", request => request.UnitKind?.Name);
            Modify_ApiCall(ref _callUpdateUnitKind);
            Modify_UpdateUnitKindApiCall(ref _callUpdateUnitKind);
            _callDeleteUnitKind = clientHelper.BuildApiCall<DeleteUnitKindRequest, wkt::Empty>("DeleteUnitKind", grpcClient.DeleteUnitKindAsync, grpcClient.DeleteUnitKind, effectiveSettings.DeleteUnitKindSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUnitKind);
            Modify_DeleteUnitKindApiCall(ref _callDeleteUnitKind);
            _callListUnits = clientHelper.BuildApiCall<ListUnitsRequest, ListUnitsResponse>("ListUnits", grpcClient.ListUnitsAsync, grpcClient.ListUnits, effectiveSettings.ListUnitsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUnits);
            Modify_ListUnitsApiCall(ref _callListUnits);
            _callGetUnit = clientHelper.BuildApiCall<GetUnitRequest, Unit>("GetUnit", grpcClient.GetUnitAsync, grpcClient.GetUnit, effectiveSettings.GetUnitSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUnit);
            Modify_GetUnitApiCall(ref _callGetUnit);
            _callCreateUnit = clientHelper.BuildApiCall<CreateUnitRequest, Unit>("CreateUnit", grpcClient.CreateUnitAsync, grpcClient.CreateUnit, effectiveSettings.CreateUnitSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUnit);
            Modify_CreateUnitApiCall(ref _callCreateUnit);
            _callUpdateUnit = clientHelper.BuildApiCall<UpdateUnitRequest, Unit>("UpdateUnit", grpcClient.UpdateUnitAsync, grpcClient.UpdateUnit, effectiveSettings.UpdateUnitSettings).WithGoogleRequestParam("unit.name", request => request.Unit?.Name);
            Modify_ApiCall(ref _callUpdateUnit);
            Modify_UpdateUnitApiCall(ref _callUpdateUnit);
            _callDeleteUnit = clientHelper.BuildApiCall<DeleteUnitRequest, wkt::Empty>("DeleteUnit", grpcClient.DeleteUnitAsync, grpcClient.DeleteUnit, effectiveSettings.DeleteUnitSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUnit);
            Modify_DeleteUnitApiCall(ref _callDeleteUnit);
            _callListUnitOperations = clientHelper.BuildApiCall<ListUnitOperationsRequest, ListUnitOperationsResponse>("ListUnitOperations", grpcClient.ListUnitOperationsAsync, grpcClient.ListUnitOperations, effectiveSettings.ListUnitOperationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUnitOperations);
            Modify_ListUnitOperationsApiCall(ref _callListUnitOperations);
            _callGetUnitOperation = clientHelper.BuildApiCall<GetUnitOperationRequest, UnitOperation>("GetUnitOperation", grpcClient.GetUnitOperationAsync, grpcClient.GetUnitOperation, effectiveSettings.GetUnitOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUnitOperation);
            Modify_GetUnitOperationApiCall(ref _callGetUnitOperation);
            _callCreateUnitOperation = clientHelper.BuildApiCall<CreateUnitOperationRequest, UnitOperation>("CreateUnitOperation", grpcClient.CreateUnitOperationAsync, grpcClient.CreateUnitOperation, effectiveSettings.CreateUnitOperationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUnitOperation);
            Modify_CreateUnitOperationApiCall(ref _callCreateUnitOperation);
            _callUpdateUnitOperation = clientHelper.BuildApiCall<UpdateUnitOperationRequest, UnitOperation>("UpdateUnitOperation", grpcClient.UpdateUnitOperationAsync, grpcClient.UpdateUnitOperation, effectiveSettings.UpdateUnitOperationSettings).WithGoogleRequestParam("unit_operation.name", request => request.UnitOperation?.Name);
            Modify_ApiCall(ref _callUpdateUnitOperation);
            Modify_UpdateUnitOperationApiCall(ref _callUpdateUnitOperation);
            _callDeleteUnitOperation = clientHelper.BuildApiCall<DeleteUnitOperationRequest, wkt::Empty>("DeleteUnitOperation", grpcClient.DeleteUnitOperationAsync, grpcClient.DeleteUnitOperation, effectiveSettings.DeleteUnitOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUnitOperation);
            Modify_DeleteUnitOperationApiCall(ref _callDeleteUnitOperation);
            _callListReleases = clientHelper.BuildApiCall<ListReleasesRequest, ListReleasesResponse>("ListReleases", grpcClient.ListReleasesAsync, grpcClient.ListReleases, effectiveSettings.ListReleasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReleases);
            Modify_ListReleasesApiCall(ref _callListReleases);
            _callGetRelease = clientHelper.BuildApiCall<GetReleaseRequest, Release>("GetRelease", grpcClient.GetReleaseAsync, grpcClient.GetRelease, effectiveSettings.GetReleaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRelease);
            Modify_GetReleaseApiCall(ref _callGetRelease);
            _callCreateRelease = clientHelper.BuildApiCall<CreateReleaseRequest, Release>("CreateRelease", grpcClient.CreateReleaseAsync, grpcClient.CreateRelease, effectiveSettings.CreateReleaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRelease);
            Modify_CreateReleaseApiCall(ref _callCreateRelease);
            _callUpdateRelease = clientHelper.BuildApiCall<UpdateReleaseRequest, Release>("UpdateRelease", grpcClient.UpdateReleaseAsync, grpcClient.UpdateRelease, effectiveSettings.UpdateReleaseSettings).WithGoogleRequestParam("release.name", request => request.Release?.Name);
            Modify_ApiCall(ref _callUpdateRelease);
            Modify_UpdateReleaseApiCall(ref _callUpdateRelease);
            _callDeleteRelease = clientHelper.BuildApiCall<DeleteReleaseRequest, wkt::Empty>("DeleteRelease", grpcClient.DeleteReleaseAsync, grpcClient.DeleteRelease, effectiveSettings.DeleteReleaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRelease);
            Modify_DeleteReleaseApiCall(ref _callDeleteRelease);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListSaasApiCall(ref gaxgrpc::ApiCall<ListSaasRequest, ListSaasResponse> call);

        partial void Modify_GetSaasApiCall(ref gaxgrpc::ApiCall<GetSaasRequest, Saas> call);

        partial void Modify_CreateSaasApiCall(ref gaxgrpc::ApiCall<CreateSaasRequest, Saas> call);

        partial void Modify_UpdateSaasApiCall(ref gaxgrpc::ApiCall<UpdateSaasRequest, Saas> call);

        partial void Modify_DeleteSaasApiCall(ref gaxgrpc::ApiCall<DeleteSaasRequest, wkt::Empty> call);

        partial void Modify_ListTenantsApiCall(ref gaxgrpc::ApiCall<ListTenantsRequest, ListTenantsResponse> call);

        partial void Modify_GetTenantApiCall(ref gaxgrpc::ApiCall<GetTenantRequest, Tenant> call);

        partial void Modify_CreateTenantApiCall(ref gaxgrpc::ApiCall<CreateTenantRequest, Tenant> call);

        partial void Modify_UpdateTenantApiCall(ref gaxgrpc::ApiCall<UpdateTenantRequest, Tenant> call);

        partial void Modify_DeleteTenantApiCall(ref gaxgrpc::ApiCall<DeleteTenantRequest, wkt::Empty> call);

        partial void Modify_ListUnitKindsApiCall(ref gaxgrpc::ApiCall<ListUnitKindsRequest, ListUnitKindsResponse> call);

        partial void Modify_GetUnitKindApiCall(ref gaxgrpc::ApiCall<GetUnitKindRequest, UnitKind> call);

        partial void Modify_CreateUnitKindApiCall(ref gaxgrpc::ApiCall<CreateUnitKindRequest, UnitKind> call);

        partial void Modify_UpdateUnitKindApiCall(ref gaxgrpc::ApiCall<UpdateUnitKindRequest, UnitKind> call);

        partial void Modify_DeleteUnitKindApiCall(ref gaxgrpc::ApiCall<DeleteUnitKindRequest, wkt::Empty> call);

        partial void Modify_ListUnitsApiCall(ref gaxgrpc::ApiCall<ListUnitsRequest, ListUnitsResponse> call);

        partial void Modify_GetUnitApiCall(ref gaxgrpc::ApiCall<GetUnitRequest, Unit> call);

        partial void Modify_CreateUnitApiCall(ref gaxgrpc::ApiCall<CreateUnitRequest, Unit> call);

        partial void Modify_UpdateUnitApiCall(ref gaxgrpc::ApiCall<UpdateUnitRequest, Unit> call);

        partial void Modify_DeleteUnitApiCall(ref gaxgrpc::ApiCall<DeleteUnitRequest, wkt::Empty> call);

        partial void Modify_ListUnitOperationsApiCall(ref gaxgrpc::ApiCall<ListUnitOperationsRequest, ListUnitOperationsResponse> call);

        partial void Modify_GetUnitOperationApiCall(ref gaxgrpc::ApiCall<GetUnitOperationRequest, UnitOperation> call);

        partial void Modify_CreateUnitOperationApiCall(ref gaxgrpc::ApiCall<CreateUnitOperationRequest, UnitOperation> call);

        partial void Modify_UpdateUnitOperationApiCall(ref gaxgrpc::ApiCall<UpdateUnitOperationRequest, UnitOperation> call);

        partial void Modify_DeleteUnitOperationApiCall(ref gaxgrpc::ApiCall<DeleteUnitOperationRequest, wkt::Empty> call);

        partial void Modify_ListReleasesApiCall(ref gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> call);

        partial void Modify_GetReleaseApiCall(ref gaxgrpc::ApiCall<GetReleaseRequest, Release> call);

        partial void Modify_CreateReleaseApiCall(ref gaxgrpc::ApiCall<CreateReleaseRequest, Release> call);

        partial void Modify_UpdateReleaseApiCall(ref gaxgrpc::ApiCall<UpdateReleaseRequest, Release> call);

        partial void Modify_DeleteReleaseApiCall(ref gaxgrpc::ApiCall<DeleteReleaseRequest, wkt::Empty> call);

        partial void OnConstruction(SaasDeployments.SaasDeploymentsClient grpcClient, SaasDeploymentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SaasDeployments client</summary>
        public override SaasDeployments.SaasDeploymentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListSaasRequest(ref ListSaasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSaasRequest(ref GetSaasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSaasRequest(ref CreateSaasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSaasRequest(ref UpdateSaasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSaasRequest(ref DeleteSaasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTenantsRequest(ref ListTenantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTenantRequest(ref GetTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTenantRequest(ref CreateTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTenantRequest(ref UpdateTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTenantRequest(ref DeleteTenantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUnitKindsRequest(ref ListUnitKindsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUnitKindRequest(ref GetUnitKindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUnitKindRequest(ref CreateUnitKindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUnitKindRequest(ref UpdateUnitKindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUnitKindRequest(ref DeleteUnitKindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUnitsRequest(ref ListUnitsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUnitRequest(ref GetUnitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUnitRequest(ref CreateUnitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUnitRequest(ref UpdateUnitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUnitRequest(ref DeleteUnitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUnitOperationsRequest(ref ListUnitOperationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUnitOperationRequest(ref GetUnitOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUnitOperationRequest(ref CreateUnitOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUnitOperationRequest(ref UpdateUnitOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUnitOperationRequest(ref DeleteUnitOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReleasesRequest(ref ListReleasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReleaseRequest(ref GetReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReleaseRequest(ref CreateReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReleaseRequest(ref UpdateReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReleaseRequest(ref DeleteReleaseRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Saas"/> resources.</returns>
        public override gax::PagedEnumerable<ListSaasResponse, Saas> ListSaas(ListSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSaasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSaasRequest, ListSaasResponse, Saas>(_callListSaas, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Saas"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSaasResponse, Saas> ListSaasAsync(ListSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSaasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSaasRequest, ListSaasResponse, Saas>(_callListSaas, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Saas GetSaas(GetSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSaasRequest(ref request, ref callSettings);
            return _callGetSaas.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Saas> GetSaasAsync(GetSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSaasRequest(ref request, ref callSettings);
            return _callGetSaas.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Saas CreateSaas(CreateSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSaasRequest(ref request, ref callSettings);
            return _callCreateSaas.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Saas> CreateSaasAsync(CreateSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSaasRequest(ref request, ref callSettings);
            return _callCreateSaas.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Saas UpdateSaas(UpdateSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSaasRequest(ref request, ref callSettings);
            return _callUpdateSaas.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Saas> UpdateSaasAsync(UpdateSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSaasRequest(ref request, ref callSettings);
            return _callUpdateSaas.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSaas(DeleteSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSaasRequest(ref request, ref callSettings);
            _callDeleteSaas.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single saas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSaasAsync(DeleteSaasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSaasRequest(ref request, ref callSettings);
            return _callDeleteSaas.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tenant"/> resources.</returns>
        public override gax::PagedEnumerable<ListTenantsResponse, Tenant> ListTenants(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTenantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTenantsRequest, ListTenantsResponse, Tenant>(_callListTenants, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of tenants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tenant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTenantsResponse, Tenant> ListTenantsAsync(ListTenantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTenantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTenantsRequest, ListTenantsResponse, Tenant>(_callListTenants, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tenant GetTenant(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTenantRequest(ref request, ref callSettings);
            return _callGetTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tenant> GetTenantAsync(GetTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTenantRequest(ref request, ref callSettings);
            return _callGetTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tenant CreateTenant(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTenantRequest(ref request, ref callSettings);
            return _callCreateTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tenant> CreateTenantAsync(CreateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTenantRequest(ref request, ref callSettings);
            return _callCreateTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tenant UpdateTenant(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTenantRequest(ref request, ref callSettings);
            return _callUpdateTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tenant> UpdateTenantAsync(UpdateTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTenantRequest(ref request, ref callSettings);
            return _callUpdateTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTenant(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTenantRequest(ref request, ref callSettings);
            _callDeleteTenant.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single tenant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTenantAsync(DeleteTenantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTenantRequest(ref request, ref callSettings);
            return _callDeleteTenant.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UnitKind"/> resources.</returns>
        public override gax::PagedEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKinds(ListUnitKindsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnitKindsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUnitKindsRequest, ListUnitKindsResponse, UnitKind>(_callListUnitKinds, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit kinds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UnitKind"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUnitKindsResponse, UnitKind> ListUnitKindsAsync(ListUnitKindsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnitKindsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUnitKindsRequest, ListUnitKindsResponse, UnitKind>(_callListUnitKinds, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnitKind GetUnitKind(GetUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnitKindRequest(ref request, ref callSettings);
            return _callGetUnitKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnitKind> GetUnitKindAsync(GetUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnitKindRequest(ref request, ref callSettings);
            return _callGetUnitKind.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnitKind CreateUnitKind(CreateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnitKindRequest(ref request, ref callSettings);
            return _callCreateUnitKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnitKind> CreateUnitKindAsync(CreateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnitKindRequest(ref request, ref callSettings);
            return _callCreateUnitKind.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnitKind UpdateUnitKind(UpdateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnitKindRequest(ref request, ref callSettings);
            return _callUpdateUnitKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnitKind> UpdateUnitKindAsync(UpdateUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnitKindRequest(ref request, ref callSettings);
            return _callUpdateUnitKind.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUnitKind(DeleteUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnitKindRequest(ref request, ref callSettings);
            _callDeleteUnitKind.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single unit kind.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUnitKindAsync(DeleteUnitKindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnitKindRequest(ref request, ref callSettings);
            return _callDeleteUnitKind.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Unit"/> resources.</returns>
        public override gax::PagedEnumerable<ListUnitsResponse, Unit> ListUnits(ListUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnitsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUnitsRequest, ListUnitsResponse, Unit>(_callListUnits, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of units.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Unit"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUnitsResponse, Unit> ListUnitsAsync(ListUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnitsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUnitsRequest, ListUnitsResponse, Unit>(_callListUnits, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Unit GetUnit(GetUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnitRequest(ref request, ref callSettings);
            return _callGetUnit.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Unit> GetUnitAsync(GetUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnitRequest(ref request, ref callSettings);
            return _callGetUnit.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Unit CreateUnit(CreateUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnitRequest(ref request, ref callSettings);
            return _callCreateUnit.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Unit> CreateUnitAsync(CreateUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnitRequest(ref request, ref callSettings);
            return _callCreateUnit.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Unit UpdateUnit(UpdateUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnitRequest(ref request, ref callSettings);
            return _callUpdateUnit.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Unit> UpdateUnitAsync(UpdateUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnitRequest(ref request, ref callSettings);
            return _callUpdateUnit.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUnit(DeleteUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnitRequest(ref request, ref callSettings);
            _callDeleteUnit.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single unit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUnitAsync(DeleteUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnitRequest(ref request, ref callSettings);
            return _callDeleteUnit.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UnitOperation"/> resources.</returns>
        public override gax::PagedEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperations(ListUnitOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnitOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUnitOperationsRequest, ListUnitOperationsResponse, UnitOperation>(_callListUnitOperations, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of unit operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UnitOperation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUnitOperationsResponse, UnitOperation> ListUnitOperationsAsync(ListUnitOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUnitOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUnitOperationsRequest, ListUnitOperationsResponse, UnitOperation>(_callListUnitOperations, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnitOperation GetUnitOperation(GetUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnitOperationRequest(ref request, ref callSettings);
            return _callGetUnitOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnitOperation> GetUnitOperationAsync(GetUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUnitOperationRequest(ref request, ref callSettings);
            return _callGetUnitOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnitOperation CreateUnitOperation(CreateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnitOperationRequest(ref request, ref callSettings);
            return _callCreateUnitOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnitOperation> CreateUnitOperationAsync(CreateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUnitOperationRequest(ref request, ref callSettings);
            return _callCreateUnitOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnitOperation UpdateUnitOperation(UpdateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnitOperationRequest(ref request, ref callSettings);
            return _callUpdateUnitOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnitOperation> UpdateUnitOperationAsync(UpdateUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUnitOperationRequest(ref request, ref callSettings);
            return _callUpdateUnitOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUnitOperation(DeleteUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnitOperationRequest(ref request, ref callSettings);
            _callDeleteUnitOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single unit operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUnitOperationAsync(DeleteUnitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUnitOperationRequest(ref request, ref callSettings);
            return _callDeleteUnitOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public override gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReleasesRequest, ListReleasesResponse, Release>(_callListReleases, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of releases.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReleasesRequest, ListReleasesResponse, Release>(_callListReleases, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Release GetRelease(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseRequest(ref request, ref callSettings);
            return _callGetRelease.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseRequest(ref request, ref callSettings);
            return _callGetRelease.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Release CreateRelease(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseRequest(ref request, ref callSettings);
            return _callCreateRelease.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Release> CreateReleaseAsync(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseRequest(ref request, ref callSettings);
            return _callCreateRelease.Async(request, callSettings);
        }

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Release UpdateRelease(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReleaseRequest(ref request, ref callSettings);
            return _callUpdateRelease.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Release> UpdateReleaseAsync(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReleaseRequest(ref request, ref callSettings);
            return _callUpdateRelease.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRelease(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReleaseRequest(ref request, ref callSettings);
            _callDeleteRelease.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a single release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReleaseAsync(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReleaseRequest(ref request, ref callSettings);
            return _callDeleteRelease.Async(request, callSettings);
        }
    }

    public partial class ListSaasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTenantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUnitKindsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUnitsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUnitOperationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReleasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSaasResponse : gaxgrpc::IPageResponse<Saas>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Saas> GetEnumerator() => Saas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTenantsResponse : gaxgrpc::IPageResponse<Tenant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Tenant> GetEnumerator() => Tenants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUnitKindsResponse : gaxgrpc::IPageResponse<UnitKind>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UnitKind> GetEnumerator() => UnitKinds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUnitsResponse : gaxgrpc::IPageResponse<Unit>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Unit> GetEnumerator() => Units.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUnitOperationsResponse : gaxgrpc::IPageResponse<UnitOperation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UnitOperation> GetEnumerator() => UnitOperations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReleasesResponse : gaxgrpc::IPageResponse<Release>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Release> GetEnumerator() => Releases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SaasDeployments
    {
        public partial class SaasDeploymentsClient
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
        }
    }
}
