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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="ApiHubClient"/> instances.</summary>
    public sealed partial class ApiHubSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiHubSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiHubSettings"/>.</returns>
        public static ApiHubSettings GetDefault() => new ApiHubSettings();

        /// <summary>Constructs a new <see cref="ApiHubSettings"/> object with default settings.</summary>
        public ApiHubSettings()
        {
        }

        private ApiHubSettings(ApiHubSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateApiSettings = existing.CreateApiSettings;
            GetApiSettings = existing.GetApiSettings;
            ListApisSettings = existing.ListApisSettings;
            UpdateApiSettings = existing.UpdateApiSettings;
            DeleteApiSettings = existing.DeleteApiSettings;
            CreateVersionSettings = existing.CreateVersionSettings;
            GetVersionSettings = existing.GetVersionSettings;
            ListVersionsSettings = existing.ListVersionsSettings;
            UpdateVersionSettings = existing.UpdateVersionSettings;
            DeleteVersionSettings = existing.DeleteVersionSettings;
            CreateSpecSettings = existing.CreateSpecSettings;
            GetSpecSettings = existing.GetSpecSettings;
            GetSpecContentsSettings = existing.GetSpecContentsSettings;
            ListSpecsSettings = existing.ListSpecsSettings;
            UpdateSpecSettings = existing.UpdateSpecSettings;
            DeleteSpecSettings = existing.DeleteSpecSettings;
            GetApiOperationSettings = existing.GetApiOperationSettings;
            ListApiOperationsSettings = existing.ListApiOperationsSettings;
            GetDefinitionSettings = existing.GetDefinitionSettings;
            CreateDeploymentSettings = existing.CreateDeploymentSettings;
            GetDeploymentSettings = existing.GetDeploymentSettings;
            ListDeploymentsSettings = existing.ListDeploymentsSettings;
            UpdateDeploymentSettings = existing.UpdateDeploymentSettings;
            DeleteDeploymentSettings = existing.DeleteDeploymentSettings;
            CreateAttributeSettings = existing.CreateAttributeSettings;
            GetAttributeSettings = existing.GetAttributeSettings;
            UpdateAttributeSettings = existing.UpdateAttributeSettings;
            DeleteAttributeSettings = existing.DeleteAttributeSettings;
            ListAttributesSettings = existing.ListAttributesSettings;
            SearchResourcesSettings = existing.SearchResourcesSettings;
            CreateExternalApiSettings = existing.CreateExternalApiSettings;
            GetExternalApiSettings = existing.GetExternalApiSettings;
            UpdateExternalApiSettings = existing.UpdateExternalApiSettings;
            DeleteExternalApiSettings = existing.DeleteExternalApiSettings;
            ListExternalApisSettings = existing.ListExternalApisSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApiHubSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.CreateApi</c>
        /// and <c>ApiHubClient.CreateApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.GetApi</c> and
        /// <c>ApiHubClient.GetApiAsync</c>.
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
        public gaxgrpc::CallSettings GetApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.ListApis</c>
        /// and <c>ApiHubClient.ListApisAsync</c>.
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
        public gaxgrpc::CallSettings ListApisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.UpdateApi</c>
        /// and <c>ApiHubClient.UpdateApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApiSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.DeleteApi</c>
        /// and <c>ApiHubClient.DeleteApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.CreateVersion</c>
        ///  and <c>ApiHubClient.CreateVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.GetVersion</c>
        /// and <c>ApiHubClient.GetVersionAsync</c>.
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
        public gaxgrpc::CallSettings GetVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.ListVersions</c>
        ///  and <c>ApiHubClient.ListVersionsAsync</c>.
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
        public gaxgrpc::CallSettings ListVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.UpdateVersion</c>
        ///  and <c>ApiHubClient.UpdateVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.DeleteVersion</c>
        ///  and <c>ApiHubClient.DeleteVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.CreateSpec</c>
        /// and <c>ApiHubClient.CreateSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpecSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.GetSpec</c>
        /// and <c>ApiHubClient.GetSpecAsync</c>.
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
        public gaxgrpc::CallSettings GetSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.GetSpecContents</c> and <c>ApiHubClient.GetSpecContentsAsync</c>.
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
        public gaxgrpc::CallSettings GetSpecContentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.ListSpecs</c>
        /// and <c>ApiHubClient.ListSpecsAsync</c>.
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
        public gaxgrpc::CallSettings ListSpecsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.UpdateSpec</c>
        /// and <c>ApiHubClient.UpdateSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpecSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.DeleteSpec</c>
        /// and <c>ApiHubClient.DeleteSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSpecSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.GetApiOperation</c> and <c>ApiHubClient.GetApiOperationAsync</c>.
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
        public gaxgrpc::CallSettings GetApiOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.ListApiOperations</c> and <c>ApiHubClient.ListApiOperationsAsync</c>.
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
        public gaxgrpc::CallSettings ListApiOperationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.GetDefinition</c>
        ///  and <c>ApiHubClient.GetDefinitionAsync</c>.
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
        public gaxgrpc::CallSettings GetDefinitionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.CreateDeployment</c> and <c>ApiHubClient.CreateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.GetDeployment</c>
        ///  and <c>ApiHubClient.GetDeploymentAsync</c>.
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
        public gaxgrpc::CallSettings GetDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.ListDeployments</c> and <c>ApiHubClient.ListDeploymentsAsync</c>.
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
        public gaxgrpc::CallSettings ListDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.UpdateDeployment</c> and <c>ApiHubClient.UpdateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.DeleteDeployment</c> and <c>ApiHubClient.DeleteDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.CreateAttribute</c> and <c>ApiHubClient.CreateAttributeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAttributeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.GetAttribute</c>
        ///  and <c>ApiHubClient.GetAttributeAsync</c>.
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
        public gaxgrpc::CallSettings GetAttributeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.UpdateAttribute</c> and <c>ApiHubClient.UpdateAttributeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAttributeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.DeleteAttribute</c> and <c>ApiHubClient.DeleteAttributeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAttributeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.ListAttributes</c>
        ///  and <c>ApiHubClient.ListAttributesAsync</c>.
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
        public gaxgrpc::CallSettings ListAttributesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.SearchResources</c> and <c>ApiHubClient.SearchResourcesAsync</c>.
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
        public gaxgrpc::CallSettings SearchResourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.CreateExternalApi</c> and <c>ApiHubClient.CreateExternalApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExternalApiSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiHubClient.GetExternalApi</c>
        ///  and <c>ApiHubClient.GetExternalApiAsync</c>.
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
        public gaxgrpc::CallSettings GetExternalApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.UpdateExternalApi</c> and <c>ApiHubClient.UpdateExternalApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExternalApiSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.DeleteExternalApi</c> and <c>ApiHubClient.DeleteExternalApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExternalApiSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubClient.ListExternalApis</c> and <c>ApiHubClient.ListExternalApisAsync</c>.
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
        public gaxgrpc::CallSettings ListExternalApisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiHubSettings"/> object.</returns>
        public ApiHubSettings Clone() => new ApiHubSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiHubClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ApiHubClientBuilder : gaxgrpc::ClientBuilderBase<ApiHubClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiHubSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiHubClientBuilder() : base(ApiHubClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiHubClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiHubClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiHubClient Build()
        {
            ApiHubClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiHubClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiHubClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiHubClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiHubClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiHubClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiHubClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiHubClient.ChannelPool;
    }

    /// <summary>ApiHub client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service provides all methods related to the API hub.
    /// </remarks>
    public abstract partial class ApiHubClient
    {
        /// <summary>
        /// The default endpoint for the ApiHub service, which is a host of "apihub.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default ApiHub scopes.</summary>
        /// <remarks>
        /// The default ApiHub scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiHub.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ApiHubClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiHubClient"/>.</returns>
        public static stt::Task<ApiHubClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiHubClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ApiHubClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApiHubClient"/>.</returns>
        public static ApiHubClient Create() => new ApiHubClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiHubClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiHubSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiHubClient"/>.</returns>
        internal static ApiHubClient Create(grpccore::CallInvoker callInvoker, ApiHubSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiHub.ApiHubClient grpcClient = new ApiHub.ApiHubClient(callInvoker);
            return new ApiHubClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiHub client</summary>
        public virtual ApiHub.ApiHubClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api CreateApi(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(CreateApiRequest request, st::CancellationToken cancellationToken) =>
            CreateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="api">
        /// Required. The API resource to create.
        /// </param>
        /// <param name="apiId">
        /// Optional. The ID to use for the API resource, which will become the final
        /// component of the API's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another API resource in the API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api CreateApi(string parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApi(new CreateApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiId = apiId ?? "",
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="api">
        /// Required. The API resource to create.
        /// </param>
        /// <param name="apiId">
        /// Optional. The ID to use for the API resource, which will become the final
        /// component of the API's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another API resource in the API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(string parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiAsync(new CreateApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiId = apiId ?? "",
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="api">
        /// Required. The API resource to create.
        /// </param>
        /// <param name="apiId">
        /// Optional. The ID to use for the API resource, which will become the final
        /// component of the API's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another API resource in the API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(string parent, Api api, string apiId, st::CancellationToken cancellationToken) =>
            CreateApiAsync(parent, api, apiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="api">
        /// Required. The API resource to create.
        /// </param>
        /// <param name="apiId">
        /// Optional. The ID to use for the API resource, which will become the final
        /// component of the API's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another API resource in the API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api CreateApi(gagr::LocationName parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApi(new CreateApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiId = apiId ?? "",
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="api">
        /// Required. The API resource to create.
        /// </param>
        /// <param name="apiId">
        /// Optional. The ID to use for the API resource, which will become the final
        /// component of the API's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another API resource in the API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(gagr::LocationName parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiAsync(new CreateApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiId = apiId ?? "",
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
            }, callSettings);

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="api">
        /// Required. The API resource to create.
        /// </param>
        /// <param name="apiId">
        /// Optional. The ID to use for the API resource, which will become the final
        /// component of the API's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another API resource in the API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(gagr::LocationName parent, Api api, string apiId, st::CancellationToken cancellationToken) =>
            CreateApiAsync(parent, api, apiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(GetApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(GetApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(GetApiRequest request, st::CancellationToken cancellationToken) =>
            GetApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApi(new GetApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiAsync(new GetApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApi(new GetApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiAsync(new GetApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(ApiName name, st::CancellationToken cancellationToken) =>
            GetApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApisResponse, Api> ListApis(ListApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(ListApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApisResponse, Api> ListApis(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApis(request, callSettings);
        }

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApisAsync(request, callSettings);
        }

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApisResponse, Api> ListApis(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApis(request, callSettings);
        }

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApisRequest request = new ListApisRequest
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
            return ListApisAsync(request, callSettings);
        }

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api UpdateApi(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(UpdateApiRequest request, st::CancellationToken cancellationToken) =>
            UpdateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="api">
        /// Required. The API resource to update.
        /// 
        /// The API resource's `name` field is used to identify the API resource to
        /// update.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api UpdateApi(Api api, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApi(new UpdateApiRequest
            {
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="api">
        /// Required. The API resource to update.
        /// 
        /// The API resource's `name` field is used to identify the API resource to
        /// update.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(Api api, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiAsync(new UpdateApiRequest
            {
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="api">
        /// Required. The API resource to update.
        /// 
        /// The API resource's `name` field is used to identify the API resource to
        /// update.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(Api api, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApiAsync(api, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApi(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(DeleteApiRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to delete.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApi(new DeleteApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to delete.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiAsync(new DeleteApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to delete.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to delete.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApi(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApi(new DeleteApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to delete.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiAsync(new DeleteApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to delete.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(ApiName name, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version CreateVersion(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(CreateVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for API version.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="versionId">
        /// Optional. The ID to use for the API version, which will become the final
        /// component of the version's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another version in the API resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version CreateVersion(string parent, Version version, string versionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersion(new CreateVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VersionId = versionId ?? "",
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for API version.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="versionId">
        /// Optional. The ID to use for the API version, which will become the final
        /// component of the version's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another version in the API resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(string parent, Version version, string versionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersionAsync(new CreateVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VersionId = versionId ?? "",
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for API version.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="versionId">
        /// Optional. The ID to use for the API version, which will become the final
        /// component of the version's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another version in the API resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(string parent, Version version, string versionId, st::CancellationToken cancellationToken) =>
            CreateVersionAsync(parent, version, versionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for API version.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="versionId">
        /// Optional. The ID to use for the API version, which will become the final
        /// component of the version's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another version in the API resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version CreateVersion(ApiName parent, Version version, string versionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersion(new CreateVersionRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VersionId = versionId ?? "",
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for API version.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="versionId">
        /// Optional. The ID to use for the API version, which will become the final
        /// component of the version's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another version in the API resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(ApiName parent, Version version, string versionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVersionAsync(new CreateVersionRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VersionId = versionId ?? "",
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
            }, callSettings);

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for API version.
        /// Format: `projects/{project}/locations/{location}/apis/{api}`
        /// </param>
        /// <param name="version">
        /// Required. The version to create.
        /// </param>
        /// <param name="versionId">
        /// Optional. The ID to use for the API version, which will become the final
        /// component of the version's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another version in the API resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> CreateVersionAsync(ApiName parent, Version version, string versionId, st::CancellationToken cancellationToken) =>
            CreateVersionAsync(parent, version, versionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, st::CancellationToken cancellationToken) =>
            GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API version to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersion(new GetVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API version to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersionAsync(new GetVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API version to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API version to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersion(new GetVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API version to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersionAsync(new GetVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API version to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(VersionName name, st::CancellationToken cancellationToken) =>
            GetVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of API versions i.e., the
        /// API resource Format: `projects/{project}/locations/{location}/apis/{api}`
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
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
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
            return ListVersions(request, callSettings);
        }

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of API versions i.e., the
        /// API resource Format: `projects/{project}/locations/{location}/apis/{api}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
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
            return ListVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of API versions i.e., the
        /// API resource Format: `projects/{project}/locations/{location}/apis/{api}`
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
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVersions(request, callSettings);
        }

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of API versions i.e., the
        /// API resource Format: `projects/{project}/locations/{location}/apis/{api}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, st::CancellationToken cancellationToken) =>
            UpdateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="version">
        /// Required. The API version to update.
        /// 
        /// The version's `name` field is used to identify the API version to update.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version UpdateVersion(Version version, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVersion(new UpdateVersionRequest
            {
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="version">
        /// Required. The API version to update.
        /// 
        /// The version's `name` field is used to identify the API version to update.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(Version version, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVersionAsync(new UpdateVersionRequest
            {
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="version">
        /// Required. The API version to update.
        /// 
        /// The version's `name` field is used to identify the API version to update.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(Version version, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVersionAsync(version, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(DeleteVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersion(new DeleteVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersionAsync(new DeleteVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVersion(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersion(new DeleteVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(VersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersionAsync(new DeleteVersionRequest
            {
                VersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVersionAsync(VersionName name, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec CreateSpec(CreateSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> CreateSpecAsync(CreateSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> CreateSpecAsync(CreateSpecRequest request, st::CancellationToken cancellationToken) =>
            CreateSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Spec.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="spec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="specId">
        /// Optional. The ID to use for the spec, which will become the final component
        /// of the spec's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another spec in the API
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec CreateSpec(string parent, Spec spec, string specId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpec(new CreateSpecRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpecId = specId ?? "",
                Spec = gax::GaxPreconditions.CheckNotNull(spec, nameof(spec)),
            }, callSettings);

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Spec.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="spec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="specId">
        /// Optional. The ID to use for the spec, which will become the final component
        /// of the spec's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another spec in the API
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> CreateSpecAsync(string parent, Spec spec, string specId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpecAsync(new CreateSpecRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpecId = specId ?? "",
                Spec = gax::GaxPreconditions.CheckNotNull(spec, nameof(spec)),
            }, callSettings);

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Spec.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="spec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="specId">
        /// Optional. The ID to use for the spec, which will become the final component
        /// of the spec's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another spec in the API
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> CreateSpecAsync(string parent, Spec spec, string specId, st::CancellationToken cancellationToken) =>
            CreateSpecAsync(parent, spec, specId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Spec.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="spec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="specId">
        /// Optional. The ID to use for the spec, which will become the final component
        /// of the spec's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another spec in the API
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec CreateSpec(VersionName parent, Spec spec, string specId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpec(new CreateSpecRequest
            {
                ParentAsVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpecId = specId ?? "",
                Spec = gax::GaxPreconditions.CheckNotNull(spec, nameof(spec)),
            }, callSettings);

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Spec.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="spec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="specId">
        /// Optional. The ID to use for the spec, which will become the final component
        /// of the spec's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another spec in the API
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> CreateSpecAsync(VersionName parent, Spec spec, string specId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpecAsync(new CreateSpecRequest
            {
                ParentAsVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpecId = specId ?? "",
                Spec = gax::GaxPreconditions.CheckNotNull(spec, nameof(spec)),
            }, callSettings);

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Spec.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
        /// </param>
        /// <param name="spec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="specId">
        /// Optional. The ID to use for the spec, which will become the final component
        /// of the spec's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another spec in the API
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> CreateSpecAsync(VersionName parent, Spec spec, string specId, st::CancellationToken cancellationToken) =>
            CreateSpecAsync(parent, spec, specId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec GetSpec(GetSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> GetSpecAsync(GetSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> GetSpecAsync(GetSpecRequest request, st::CancellationToken cancellationToken) =>
            GetSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec GetSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpec(new GetSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> GetSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecAsync(new GetSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> GetSpecAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec GetSpec(SpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpec(new GetSpecRequest
            {
                SpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> GetSpecAsync(SpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecAsync(new GetSpecRequest
            {
                SpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> GetSpecAsync(SpecName name, st::CancellationToken cancellationToken) =>
            GetSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpecContents GetSpecContents(GetSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecContents> GetSpecContentsAsync(GetSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecContents> GetSpecContentsAsync(GetSpecContentsRequest request, st::CancellationToken cancellationToken) =>
            GetSpecContentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents need to be retrieved.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpecContents GetSpecContents(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecContents(new GetSpecContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents need to be retrieved.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecContents> GetSpecContentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecContentsAsync(new GetSpecContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents need to be retrieved.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecContents> GetSpecContentsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpecContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents need to be retrieved.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpecContents GetSpecContents(SpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecContents(new GetSpecContentsRequest
            {
                SpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents need to be retrieved.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecContents> GetSpecContentsAsync(SpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpecContentsAsync(new GetSpecContentsRequest
            {
                SpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents need to be retrieved.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpecContents> GetSpecContentsAsync(SpecName name, st::CancellationToken cancellationToken) =>
            GetSpecContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spec"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpecsResponse, Spec> ListSpecs(ListSpecsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spec"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpecsResponse, Spec> ListSpecsAsync(ListSpecsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable sequence of <see cref="Spec"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpecsResponse, Spec> ListSpecs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecsRequest request = new ListSpecsRequest
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
            return ListSpecs(request, callSettings);
        }

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spec"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpecsResponse, Spec> ListSpecsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecsRequest request = new ListSpecsRequest
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
            return ListSpecsAsync(request, callSettings);
        }

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable sequence of <see cref="Spec"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpecsResponse, Spec> ListSpecs(VersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecsRequest request = new ListSpecsRequest
            {
                ParentAsVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpecs(request, callSettings);
        }

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Spec"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpecsResponse, Spec> ListSpecsAsync(VersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpecsRequest request = new ListSpecsRequest
            {
                ParentAsVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpecsAsync(request, callSettings);
        }

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec UpdateSpec(UpdateSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> UpdateSpecAsync(UpdateSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> UpdateSpecAsync(UpdateSpecRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="spec">
        /// Required. The spec to update.
        /// 
        /// The spec's `name` field is used to identify the spec to
        /// update. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Spec UpdateSpec(Spec spec, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpec(new UpdateSpecRequest
            {
                Spec = gax::GaxPreconditions.CheckNotNull(spec, nameof(spec)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="spec">
        /// Required. The spec to update.
        /// 
        /// The spec's `name` field is used to identify the spec to
        /// update. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> UpdateSpecAsync(Spec spec, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpecAsync(new UpdateSpecRequest
            {
                Spec = gax::GaxPreconditions.CheckNotNull(spec, nameof(spec)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="spec">
        /// Required. The spec to update.
        /// 
        /// The spec's `name` field is used to identify the spec to
        /// update. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Spec> UpdateSpecAsync(Spec spec, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpecAsync(spec, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpec(DeleteSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpecAsync(DeleteSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpecAsync(DeleteSpecRequest request, st::CancellationToken cancellationToken) =>
            DeleteSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec  to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpec(new DeleteSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec  to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpecAsync(new DeleteSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec  to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpecAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec  to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpec(SpecName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpec(new DeleteSpecRequest
            {
                SpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec  to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpecAsync(SpecName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpecAsync(new DeleteSpecRequest
            {
                SpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec  to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/specs/{spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpecAsync(SpecName name, st::CancellationToken cancellationToken) =>
            DeleteSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiOperation GetApiOperation(GetApiOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiOperation> GetApiOperationAsync(GetApiOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiOperation> GetApiOperationAsync(GetApiOperationRequest request, st::CancellationToken cancellationToken) =>
            GetApiOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the operation to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiOperation GetApiOperation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiOperation(new GetApiOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the operation to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiOperation> GetApiOperationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiOperationAsync(new GetApiOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the operation to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiOperation> GetApiOperationAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the operation to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiOperation GetApiOperation(ApiOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiOperation(new GetApiOperationRequest
            {
                ApiOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the operation to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiOperation> GetApiOperationAsync(ApiOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiOperationAsync(new GetApiOperationRequest
            {
                ApiOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the operation to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/operations/{operation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiOperation> GetApiOperationAsync(ApiOperationName name, st::CancellationToken cancellationToken) =>
            GetApiOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperations(ListApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperationsAsync(ListApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of operations i.e., the API
        /// version. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable sequence of <see cref="ApiOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiOperationsRequest request = new ListApiOperationsRequest
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
            return ListApiOperations(request, callSettings);
        }

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of operations i.e., the API
        /// version. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiOperationsRequest request = new ListApiOperationsRequest
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
            return ListApiOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of operations i.e., the API
        /// version. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable sequence of <see cref="ApiOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperations(VersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiOperationsRequest request = new ListApiOperationsRequest
            {
                ParentAsVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApiOperations(request, callSettings);
        }

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of operations i.e., the API
        /// version. Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperationsAsync(VersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiOperationsRequest request = new ListApiOperationsRequest
            {
                ParentAsVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApiOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Definition GetDefinition(GetDefinitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Definition> GetDefinitionAsync(GetDefinitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Definition> GetDefinitionAsync(GetDefinitionRequest request, st::CancellationToken cancellationToken) =>
            GetDefinitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the definition to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Definition GetDefinition(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefinition(new GetDefinitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the definition to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Definition> GetDefinitionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefinitionAsync(new GetDefinitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the definition to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Definition> GetDefinitionAsync(string name, st::CancellationToken cancellationToken) =>
            GetDefinitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the definition to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Definition GetDefinition(DefinitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefinition(new GetDefinitionRequest
            {
                DefinitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the definition to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Definition> GetDefinitionAsync(DefinitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefinitionAsync(new GetDefinitionRequest
            {
                DefinitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the definition to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apis/{api}/versions/{version}/definitions/{definition}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Definition> GetDefinitionAsync(DefinitionName name, st::CancellationToken cancellationToken) =>
            GetDefinitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the deployment resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment resource to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment resource, which will become the
        /// final component of the deployment's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another deployment resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the deployment resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment resource to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment resource, which will become the
        /// final component of the deployment's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another deployment resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the deployment resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment resource to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment resource, which will become the
        /// final component of the deployment's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another deployment resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the deployment resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment resource to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment resource, which will become the
        /// final component of the deployment's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another deployment resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(gagr::LocationName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the deployment resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment resource to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment resource, which will become the
        /// final component of the deployment's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another deployment resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(gagr::LocationName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = deploymentId ?? "",
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the deployment resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment resource to create.
        /// </param>
        /// <param name="deploymentId">
        /// Optional. The ID to use for the deployment resource, which will become the
        /// final component of the deployment's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another deployment resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(gagr::LocationName parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployment resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment resource to update.
        /// 
        /// The deployment resource's `name` field is used to identify the deployment
        /// resource to update.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment UpdateDeployment(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeployment(new UpdateDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment resource to update.
        /// 
        /// The deployment resource's `name` field is used to identify the deployment
        /// resource to update.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeploymentAsync(new UpdateDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment resource to update.
        /// 
        /// The deployment resource's `name` field is used to identify the deployment
        /// resource to update.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(deployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to delete.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to delete.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to delete.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to delete.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to delete.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment resource to delete.
        /// Format: `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute CreateAttribute(CreateAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> CreateAttributeAsync(CreateAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> CreateAttributeAsync(CreateAttributeRequest request, st::CancellationToken cancellationToken) =>
            CreateAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="attribute">
        /// Required. The attribute to create.
        /// </param>
        /// <param name="attributeId">
        /// Optional. The ID to use for the attribute, which will become the final
        /// component of the attribute's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another attribute resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute CreateAttribute(string parent, Attribute attribute, string attributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttribute(new CreateAttributeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttributeId = attributeId ?? "",
                Attribute = gax::GaxPreconditions.CheckNotNull(attribute, nameof(attribute)),
            }, callSettings);

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="attribute">
        /// Required. The attribute to create.
        /// </param>
        /// <param name="attributeId">
        /// Optional. The ID to use for the attribute, which will become the final
        /// component of the attribute's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another attribute resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> CreateAttributeAsync(string parent, Attribute attribute, string attributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttributeAsync(new CreateAttributeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttributeId = attributeId ?? "",
                Attribute = gax::GaxPreconditions.CheckNotNull(attribute, nameof(attribute)),
            }, callSettings);

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="attribute">
        /// Required. The attribute to create.
        /// </param>
        /// <param name="attributeId">
        /// Optional. The ID to use for the attribute, which will become the final
        /// component of the attribute's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another attribute resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> CreateAttributeAsync(string parent, Attribute attribute, string attributeId, st::CancellationToken cancellationToken) =>
            CreateAttributeAsync(parent, attribute, attributeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="attribute">
        /// Required. The attribute to create.
        /// </param>
        /// <param name="attributeId">
        /// Optional. The ID to use for the attribute, which will become the final
        /// component of the attribute's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another attribute resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute CreateAttribute(gagr::LocationName parent, Attribute attribute, string attributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttribute(new CreateAttributeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttributeId = attributeId ?? "",
                Attribute = gax::GaxPreconditions.CheckNotNull(attribute, nameof(attribute)),
            }, callSettings);

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="attribute">
        /// Required. The attribute to create.
        /// </param>
        /// <param name="attributeId">
        /// Optional. The ID to use for the attribute, which will become the final
        /// component of the attribute's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another attribute resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> CreateAttributeAsync(gagr::LocationName parent, Attribute attribute, string attributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttributeAsync(new CreateAttributeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttributeId = attributeId ?? "",
                Attribute = gax::GaxPreconditions.CheckNotNull(attribute, nameof(attribute)),
            }, callSettings);

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="attribute">
        /// Required. The attribute to create.
        /// </param>
        /// <param name="attributeId">
        /// Optional. The ID to use for the attribute, which will become the final
        /// component of the attribute's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another attribute resource in the API
        /// hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> CreateAttributeAsync(gagr::LocationName parent, Attribute attribute, string attributeId, st::CancellationToken cancellationToken) =>
            CreateAttributeAsync(parent, attribute, attributeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute GetAttribute(GetAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> GetAttributeAsync(GetAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> GetAttributeAsync(GetAttributeRequest request, st::CancellationToken cancellationToken) =>
            GetAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute GetAttribute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttribute(new GetAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> GetAttributeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttributeAsync(new GetAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> GetAttributeAsync(string name, st::CancellationToken cancellationToken) =>
            GetAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute GetAttribute(AttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttribute(new GetAttributeRequest
            {
                AttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> GetAttributeAsync(AttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttributeAsync(new GetAttributeRequest
            {
                AttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> GetAttributeAsync(AttributeName name, st::CancellationToken cancellationToken) =>
            GetAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute UpdateAttribute(UpdateAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> UpdateAttributeAsync(UpdateAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> UpdateAttributeAsync(UpdateAttributeRequest request, st::CancellationToken cancellationToken) =>
            UpdateAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="attribute">
        /// Required. The attribute to update.
        /// 
        /// The attribute's `name` field is used to identify the attribute to update.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attribute UpdateAttribute(Attribute attribute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttribute(new UpdateAttributeRequest
            {
                Attribute = gax::GaxPreconditions.CheckNotNull(attribute, nameof(attribute)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="attribute">
        /// Required. The attribute to update.
        /// 
        /// The attribute's `name` field is used to identify the attribute to update.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> UpdateAttributeAsync(Attribute attribute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttributeAsync(new UpdateAttributeRequest
            {
                Attribute = gax::GaxPreconditions.CheckNotNull(attribute, nameof(attribute)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="attribute">
        /// Required. The attribute to update.
        /// 
        /// The attribute's `name` field is used to identify the attribute to update.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attribute> UpdateAttributeAsync(Attribute attribute, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAttributeAsync(attribute, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAttribute(DeleteAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttributeAsync(DeleteAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttributeAsync(DeleteAttributeRequest request, st::CancellationToken cancellationToken) =>
            DeleteAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAttribute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttribute(new DeleteAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttributeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttributeAsync(new DeleteAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttributeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAttribute(AttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttribute(new DeleteAttributeRequest
            {
                AttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttributeAsync(AttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttributeAsync(new DeleteAttributeRequest
            {
                AttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attribute to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/attributes/{attribute}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAttributeAsync(AttributeName name, st::CancellationToken cancellationToken) =>
            DeleteAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attribute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttributesResponse, Attribute> ListAttributes(ListAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attribute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttributesResponse, Attribute> ListAttributesAsync(ListAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Attribute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttributesResponse, Attribute> ListAttributes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttributesRequest request = new ListAttributesRequest
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
            return ListAttributes(request, callSettings);
        }

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attribute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttributesResponse, Attribute> ListAttributesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttributesRequest request = new ListAttributesRequest
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
            return ListAttributesAsync(request, callSettings);
        }

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Attribute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttributesResponse, Attribute> ListAttributes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttributesRequest request = new ListAttributesRequest
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
            return ListAttributes(request, callSettings);
        }

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for Attribute.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attribute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttributesResponse, Attribute> ListAttributesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttributesRequest request = new ListAttributesRequest
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
            return ListAttributesAsync(request, callSettings);
        }

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchResourcesResponse, SearchResult> SearchResources(SearchResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchResourcesResponse, SearchResult> SearchResourcesAsync(SearchResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the location which will be of the type
        /// `projects/{project_id}/locations/{location_id}`. This field is used to
        /// identify the instance of API-Hub in which resources should be searched.
        /// </param>
        /// <param name="query">
        /// Required. The free text search query. This query can contain keywords which
        /// could be related to any detail of the API-Hub resources such display names,
        /// descriptions, attributes etc.
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
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchResourcesResponse, SearchResult> SearchResources(string location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchResourcesRequest request = new SearchResourcesRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchResources(request, callSettings);
        }

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the location which will be of the type
        /// `projects/{project_id}/locations/{location_id}`. This field is used to
        /// identify the instance of API-Hub in which resources should be searched.
        /// </param>
        /// <param name="query">
        /// Required. The free text search query. This query can contain keywords which
        /// could be related to any detail of the API-Hub resources such display names,
        /// descriptions, attributes etc.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchResourcesResponse, SearchResult> SearchResourcesAsync(string location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchResourcesRequest request = new SearchResourcesRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the location which will be of the type
        /// `projects/{project_id}/locations/{location_id}`. This field is used to
        /// identify the instance of API-Hub in which resources should be searched.
        /// </param>
        /// <param name="query">
        /// Required. The free text search query. This query can contain keywords which
        /// could be related to any detail of the API-Hub resources such display names,
        /// descriptions, attributes etc.
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
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchResourcesResponse, SearchResult> SearchResources(gagr::LocationName location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchResourcesRequest request = new SearchResourcesRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchResources(request, callSettings);
        }

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="location">
        /// Required. The resource name of the location which will be of the type
        /// `projects/{project_id}/locations/{location_id}`. This field is used to
        /// identify the instance of API-Hub in which resources should be searched.
        /// </param>
        /// <param name="query">
        /// Required. The free text search query. This query can contain keywords which
        /// could be related to any detail of the API-Hub resources such display names,
        /// descriptions, attributes etc.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchResourcesResponse, SearchResult> SearchResourcesAsync(gagr::LocationName location, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchResourcesRequest request = new SearchResourcesRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi CreateExternalApi(CreateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> CreateExternalApiAsync(CreateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> CreateExternalApiAsync(CreateExternalApiRequest request, st::CancellationToken cancellationToken) =>
            CreateExternalApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the External API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="externalApi">
        /// Required. The External API resource to create.
        /// </param>
        /// <param name="externalApiId">
        /// Optional. The ID to use for the External API resource, which will become
        /// the final component of the External API's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another External API resource in the
        /// API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi CreateExternalApi(string parent, ExternalApi externalApi, string externalApiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalApi(new CreateExternalApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExternalApiId = externalApiId ?? "",
                ExternalApi = gax::GaxPreconditions.CheckNotNull(externalApi, nameof(externalApi)),
            }, callSettings);

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the External API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="externalApi">
        /// Required. The External API resource to create.
        /// </param>
        /// <param name="externalApiId">
        /// Optional. The ID to use for the External API resource, which will become
        /// the final component of the External API's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another External API resource in the
        /// API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> CreateExternalApiAsync(string parent, ExternalApi externalApi, string externalApiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalApiAsync(new CreateExternalApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExternalApiId = externalApiId ?? "",
                ExternalApi = gax::GaxPreconditions.CheckNotNull(externalApi, nameof(externalApi)),
            }, callSettings);

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the External API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="externalApi">
        /// Required. The External API resource to create.
        /// </param>
        /// <param name="externalApiId">
        /// Optional. The ID to use for the External API resource, which will become
        /// the final component of the External API's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another External API resource in the
        /// API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> CreateExternalApiAsync(string parent, ExternalApi externalApi, string externalApiId, st::CancellationToken cancellationToken) =>
            CreateExternalApiAsync(parent, externalApi, externalApiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the External API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="externalApi">
        /// Required. The External API resource to create.
        /// </param>
        /// <param name="externalApiId">
        /// Optional. The ID to use for the External API resource, which will become
        /// the final component of the External API's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another External API resource in the
        /// API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi CreateExternalApi(gagr::LocationName parent, ExternalApi externalApi, string externalApiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalApi(new CreateExternalApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExternalApiId = externalApiId ?? "",
                ExternalApi = gax::GaxPreconditions.CheckNotNull(externalApi, nameof(externalApi)),
            }, callSettings);

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the External API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="externalApi">
        /// Required. The External API resource to create.
        /// </param>
        /// <param name="externalApiId">
        /// Optional. The ID to use for the External API resource, which will become
        /// the final component of the External API's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another External API resource in the
        /// API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> CreateExternalApiAsync(gagr::LocationName parent, ExternalApi externalApi, string externalApiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalApiAsync(new CreateExternalApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExternalApiId = externalApiId ?? "",
                ExternalApi = gax::GaxPreconditions.CheckNotNull(externalApi, nameof(externalApi)),
            }, callSettings);

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the External API resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="externalApi">
        /// Required. The External API resource to create.
        /// </param>
        /// <param name="externalApiId">
        /// Optional. The ID to use for the External API resource, which will become
        /// the final component of the External API's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another External API resource in the
        /// API hub.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> CreateExternalApiAsync(gagr::LocationName parent, ExternalApi externalApi, string externalApiId, st::CancellationToken cancellationToken) =>
            CreateExternalApiAsync(parent, externalApi, externalApiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi GetExternalApi(GetExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> GetExternalApiAsync(GetExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> GetExternalApiAsync(GetExternalApiRequest request, st::CancellationToken cancellationToken) =>
            GetExternalApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi GetExternalApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExternalApi(new GetExternalApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> GetExternalApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExternalApiAsync(new GetExternalApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> GetExternalApiAsync(string name, st::CancellationToken cancellationToken) =>
            GetExternalApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi GetExternalApi(ExternalApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExternalApi(new GetExternalApiRequest
            {
                ExternalApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> GetExternalApiAsync(ExternalApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExternalApiAsync(new GetExternalApiRequest
            {
                ExternalApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> GetExternalApiAsync(ExternalApiName name, st::CancellationToken cancellationToken) =>
            GetExternalApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi UpdateExternalApi(UpdateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> UpdateExternalApiAsync(UpdateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> UpdateExternalApiAsync(UpdateExternalApiRequest request, st::CancellationToken cancellationToken) =>
            UpdateExternalApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="externalApi">
        /// Required. The External API resource to update.
        /// 
        /// The External API resource's `name` field is used to identify the External
        /// API resource to update. Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalApi UpdateExternalApi(ExternalApi externalApi, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExternalApi(new UpdateExternalApiRequest
            {
                ExternalApi = gax::GaxPreconditions.CheckNotNull(externalApi, nameof(externalApi)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="externalApi">
        /// Required. The External API resource to update.
        /// 
        /// The External API resource's `name` field is used to identify the External
        /// API resource to update. Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> UpdateExternalApiAsync(ExternalApi externalApi, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExternalApiAsync(new UpdateExternalApiRequest
            {
                ExternalApi = gax::GaxPreconditions.CheckNotNull(externalApi, nameof(externalApi)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="externalApi">
        /// Required. The External API resource to update.
        /// 
        /// The External API resource's `name` field is used to identify the External
        /// API resource to update. Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalApi> UpdateExternalApiAsync(ExternalApi externalApi, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExternalApiAsync(externalApi, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExternalApi(DeleteExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExternalApiAsync(DeleteExternalApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExternalApiAsync(DeleteExternalApiRequest request, st::CancellationToken cancellationToken) =>
            DeleteExternalApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExternalApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExternalApi(new DeleteExternalApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExternalApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExternalApiAsync(new DeleteExternalApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExternalApiAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExternalApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExternalApi(ExternalApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExternalApi(new DeleteExternalApiRequest
            {
                ExternalApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExternalApiAsync(ExternalApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExternalApiAsync(new DeleteExternalApiRequest
            {
                ExternalApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the External API resource to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/externalApis/{externalApi}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExternalApiAsync(ExternalApiName name, st::CancellationToken cancellationToken) =>
            DeleteExternalApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExternalApi"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApis(ListExternalApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExternalApi"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApisAsync(ListExternalApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of External API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ExternalApi"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApis(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExternalApisRequest request = new ListExternalApisRequest
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
            return ListExternalApis(request, callSettings);
        }

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of External API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ExternalApi"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApisAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExternalApisRequest request = new ListExternalApisRequest
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
            return ListExternalApisAsync(request, callSettings);
        }

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of External API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ExternalApi"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApis(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExternalApisRequest request = new ListExternalApisRequest
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
            return ListExternalApis(request, callSettings);
        }

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of External API resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ExternalApi"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApisAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExternalApisRequest request = new ListExternalApisRequest
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
            return ListExternalApisAsync(request, callSettings);
        }
    }

    /// <summary>ApiHub client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service provides all methods related to the API hub.
    /// </remarks>
    public sealed partial class ApiHubClientImpl : ApiHubClient
    {
        private readonly gaxgrpc::ApiCall<CreateApiRequest, Api> _callCreateApi;

        private readonly gaxgrpc::ApiCall<GetApiRequest, Api> _callGetApi;

        private readonly gaxgrpc::ApiCall<ListApisRequest, ListApisResponse> _callListApis;

        private readonly gaxgrpc::ApiCall<UpdateApiRequest, Api> _callUpdateApi;

        private readonly gaxgrpc::ApiCall<DeleteApiRequest, wkt::Empty> _callDeleteApi;

        private readonly gaxgrpc::ApiCall<CreateVersionRequest, Version> _callCreateVersion;

        private readonly gaxgrpc::ApiCall<GetVersionRequest, Version> _callGetVersion;

        private readonly gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> _callListVersions;

        private readonly gaxgrpc::ApiCall<UpdateVersionRequest, Version> _callUpdateVersion;

        private readonly gaxgrpc::ApiCall<DeleteVersionRequest, wkt::Empty> _callDeleteVersion;

        private readonly gaxgrpc::ApiCall<CreateSpecRequest, Spec> _callCreateSpec;

        private readonly gaxgrpc::ApiCall<GetSpecRequest, Spec> _callGetSpec;

        private readonly gaxgrpc::ApiCall<GetSpecContentsRequest, SpecContents> _callGetSpecContents;

        private readonly gaxgrpc::ApiCall<ListSpecsRequest, ListSpecsResponse> _callListSpecs;

        private readonly gaxgrpc::ApiCall<UpdateSpecRequest, Spec> _callUpdateSpec;

        private readonly gaxgrpc::ApiCall<DeleteSpecRequest, wkt::Empty> _callDeleteSpec;

        private readonly gaxgrpc::ApiCall<GetApiOperationRequest, ApiOperation> _callGetApiOperation;

        private readonly gaxgrpc::ApiCall<ListApiOperationsRequest, ListApiOperationsResponse> _callListApiOperations;

        private readonly gaxgrpc::ApiCall<GetDefinitionRequest, Definition> _callGetDefinition;

        private readonly gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> _callCreateDeployment;

        private readonly gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> _callGetDeployment;

        private readonly gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> _callListDeployments;

        private readonly gaxgrpc::ApiCall<UpdateDeploymentRequest, Deployment> _callUpdateDeployment;

        private readonly gaxgrpc::ApiCall<DeleteDeploymentRequest, wkt::Empty> _callDeleteDeployment;

        private readonly gaxgrpc::ApiCall<CreateAttributeRequest, Attribute> _callCreateAttribute;

        private readonly gaxgrpc::ApiCall<GetAttributeRequest, Attribute> _callGetAttribute;

        private readonly gaxgrpc::ApiCall<UpdateAttributeRequest, Attribute> _callUpdateAttribute;

        private readonly gaxgrpc::ApiCall<DeleteAttributeRequest, wkt::Empty> _callDeleteAttribute;

        private readonly gaxgrpc::ApiCall<ListAttributesRequest, ListAttributesResponse> _callListAttributes;

        private readonly gaxgrpc::ApiCall<SearchResourcesRequest, SearchResourcesResponse> _callSearchResources;

        private readonly gaxgrpc::ApiCall<CreateExternalApiRequest, ExternalApi> _callCreateExternalApi;

        private readonly gaxgrpc::ApiCall<GetExternalApiRequest, ExternalApi> _callGetExternalApi;

        private readonly gaxgrpc::ApiCall<UpdateExternalApiRequest, ExternalApi> _callUpdateExternalApi;

        private readonly gaxgrpc::ApiCall<DeleteExternalApiRequest, wkt::Empty> _callDeleteExternalApi;

        private readonly gaxgrpc::ApiCall<ListExternalApisRequest, ListExternalApisResponse> _callListExternalApis;

        /// <summary>
        /// Constructs a client wrapper for the ApiHub service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiHubSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiHubClientImpl(ApiHub.ApiHubClient grpcClient, ApiHubSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiHubSettings effectiveSettings = settings ?? ApiHubSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateApi = clientHelper.BuildApiCall<CreateApiRequest, Api>("CreateApi", grpcClient.CreateApiAsync, grpcClient.CreateApi, effectiveSettings.CreateApiSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApi);
            Modify_CreateApiApiCall(ref _callCreateApi);
            _callGetApi = clientHelper.BuildApiCall<GetApiRequest, Api>("GetApi", grpcClient.GetApiAsync, grpcClient.GetApi, effectiveSettings.GetApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApi);
            Modify_GetApiApiCall(ref _callGetApi);
            _callListApis = clientHelper.BuildApiCall<ListApisRequest, ListApisResponse>("ListApis", grpcClient.ListApisAsync, grpcClient.ListApis, effectiveSettings.ListApisSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApis);
            Modify_ListApisApiCall(ref _callListApis);
            _callUpdateApi = clientHelper.BuildApiCall<UpdateApiRequest, Api>("UpdateApi", grpcClient.UpdateApiAsync, grpcClient.UpdateApi, effectiveSettings.UpdateApiSettings).WithGoogleRequestParam("api.name", request => request.Api?.Name);
            Modify_ApiCall(ref _callUpdateApi);
            Modify_UpdateApiApiCall(ref _callUpdateApi);
            _callDeleteApi = clientHelper.BuildApiCall<DeleteApiRequest, wkt::Empty>("DeleteApi", grpcClient.DeleteApiAsync, grpcClient.DeleteApi, effectiveSettings.DeleteApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApi);
            Modify_DeleteApiApiCall(ref _callDeleteApi);
            _callCreateVersion = clientHelper.BuildApiCall<CreateVersionRequest, Version>("CreateVersion", grpcClient.CreateVersionAsync, grpcClient.CreateVersion, effectiveSettings.CreateVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVersion);
            Modify_CreateVersionApiCall(ref _callCreateVersion);
            _callGetVersion = clientHelper.BuildApiCall<GetVersionRequest, Version>("GetVersion", grpcClient.GetVersionAsync, grpcClient.GetVersion, effectiveSettings.GetVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVersion);
            Modify_GetVersionApiCall(ref _callGetVersion);
            _callListVersions = clientHelper.BuildApiCall<ListVersionsRequest, ListVersionsResponse>("ListVersions", grpcClient.ListVersionsAsync, grpcClient.ListVersions, effectiveSettings.ListVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVersions);
            Modify_ListVersionsApiCall(ref _callListVersions);
            _callUpdateVersion = clientHelper.BuildApiCall<UpdateVersionRequest, Version>("UpdateVersion", grpcClient.UpdateVersionAsync, grpcClient.UpdateVersion, effectiveSettings.UpdateVersionSettings).WithGoogleRequestParam("version.name", request => request.Version?.Name);
            Modify_ApiCall(ref _callUpdateVersion);
            Modify_UpdateVersionApiCall(ref _callUpdateVersion);
            _callDeleteVersion = clientHelper.BuildApiCall<DeleteVersionRequest, wkt::Empty>("DeleteVersion", grpcClient.DeleteVersionAsync, grpcClient.DeleteVersion, effectiveSettings.DeleteVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVersion);
            Modify_DeleteVersionApiCall(ref _callDeleteVersion);
            _callCreateSpec = clientHelper.BuildApiCall<CreateSpecRequest, Spec>("CreateSpec", grpcClient.CreateSpecAsync, grpcClient.CreateSpec, effectiveSettings.CreateSpecSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSpec);
            Modify_CreateSpecApiCall(ref _callCreateSpec);
            _callGetSpec = clientHelper.BuildApiCall<GetSpecRequest, Spec>("GetSpec", grpcClient.GetSpecAsync, grpcClient.GetSpec, effectiveSettings.GetSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpec);
            Modify_GetSpecApiCall(ref _callGetSpec);
            _callGetSpecContents = clientHelper.BuildApiCall<GetSpecContentsRequest, SpecContents>("GetSpecContents", grpcClient.GetSpecContentsAsync, grpcClient.GetSpecContents, effectiveSettings.GetSpecContentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpecContents);
            Modify_GetSpecContentsApiCall(ref _callGetSpecContents);
            _callListSpecs = clientHelper.BuildApiCall<ListSpecsRequest, ListSpecsResponse>("ListSpecs", grpcClient.ListSpecsAsync, grpcClient.ListSpecs, effectiveSettings.ListSpecsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSpecs);
            Modify_ListSpecsApiCall(ref _callListSpecs);
            _callUpdateSpec = clientHelper.BuildApiCall<UpdateSpecRequest, Spec>("UpdateSpec", grpcClient.UpdateSpecAsync, grpcClient.UpdateSpec, effectiveSettings.UpdateSpecSettings).WithGoogleRequestParam("spec.name", request => request.Spec?.Name);
            Modify_ApiCall(ref _callUpdateSpec);
            Modify_UpdateSpecApiCall(ref _callUpdateSpec);
            _callDeleteSpec = clientHelper.BuildApiCall<DeleteSpecRequest, wkt::Empty>("DeleteSpec", grpcClient.DeleteSpecAsync, grpcClient.DeleteSpec, effectiveSettings.DeleteSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSpec);
            Modify_DeleteSpecApiCall(ref _callDeleteSpec);
            _callGetApiOperation = clientHelper.BuildApiCall<GetApiOperationRequest, ApiOperation>("GetApiOperation", grpcClient.GetApiOperationAsync, grpcClient.GetApiOperation, effectiveSettings.GetApiOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApiOperation);
            Modify_GetApiOperationApiCall(ref _callGetApiOperation);
            _callListApiOperations = clientHelper.BuildApiCall<ListApiOperationsRequest, ListApiOperationsResponse>("ListApiOperations", grpcClient.ListApiOperationsAsync, grpcClient.ListApiOperations, effectiveSettings.ListApiOperationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApiOperations);
            Modify_ListApiOperationsApiCall(ref _callListApiOperations);
            _callGetDefinition = clientHelper.BuildApiCall<GetDefinitionRequest, Definition>("GetDefinition", grpcClient.GetDefinitionAsync, grpcClient.GetDefinition, effectiveSettings.GetDefinitionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDefinition);
            Modify_GetDefinitionApiCall(ref _callGetDefinition);
            _callCreateDeployment = clientHelper.BuildApiCall<CreateDeploymentRequest, Deployment>("CreateDeployment", grpcClient.CreateDeploymentAsync, grpcClient.CreateDeployment, effectiveSettings.CreateDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeployment);
            Modify_CreateDeploymentApiCall(ref _callCreateDeployment);
            _callGetDeployment = clientHelper.BuildApiCall<GetDeploymentRequest, Deployment>("GetDeployment", grpcClient.GetDeploymentAsync, grpcClient.GetDeployment, effectiveSettings.GetDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeployment);
            Modify_GetDeploymentApiCall(ref _callGetDeployment);
            _callListDeployments = clientHelper.BuildApiCall<ListDeploymentsRequest, ListDeploymentsResponse>("ListDeployments", grpcClient.ListDeploymentsAsync, grpcClient.ListDeployments, effectiveSettings.ListDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeployments);
            Modify_ListDeploymentsApiCall(ref _callListDeployments);
            _callUpdateDeployment = clientHelper.BuildApiCall<UpdateDeploymentRequest, Deployment>("UpdateDeployment", grpcClient.UpdateDeploymentAsync, grpcClient.UpdateDeployment, effectiveSettings.UpdateDeploymentSettings).WithGoogleRequestParam("deployment.name", request => request.Deployment?.Name);
            Modify_ApiCall(ref _callUpdateDeployment);
            Modify_UpdateDeploymentApiCall(ref _callUpdateDeployment);
            _callDeleteDeployment = clientHelper.BuildApiCall<DeleteDeploymentRequest, wkt::Empty>("DeleteDeployment", grpcClient.DeleteDeploymentAsync, grpcClient.DeleteDeployment, effectiveSettings.DeleteDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeployment);
            Modify_DeleteDeploymentApiCall(ref _callDeleteDeployment);
            _callCreateAttribute = clientHelper.BuildApiCall<CreateAttributeRequest, Attribute>("CreateAttribute", grpcClient.CreateAttributeAsync, grpcClient.CreateAttribute, effectiveSettings.CreateAttributeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAttribute);
            Modify_CreateAttributeApiCall(ref _callCreateAttribute);
            _callGetAttribute = clientHelper.BuildApiCall<GetAttributeRequest, Attribute>("GetAttribute", grpcClient.GetAttributeAsync, grpcClient.GetAttribute, effectiveSettings.GetAttributeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAttribute);
            Modify_GetAttributeApiCall(ref _callGetAttribute);
            _callUpdateAttribute = clientHelper.BuildApiCall<UpdateAttributeRequest, Attribute>("UpdateAttribute", grpcClient.UpdateAttributeAsync, grpcClient.UpdateAttribute, effectiveSettings.UpdateAttributeSettings).WithGoogleRequestParam("attribute.name", request => request.Attribute?.Name);
            Modify_ApiCall(ref _callUpdateAttribute);
            Modify_UpdateAttributeApiCall(ref _callUpdateAttribute);
            _callDeleteAttribute = clientHelper.BuildApiCall<DeleteAttributeRequest, wkt::Empty>("DeleteAttribute", grpcClient.DeleteAttributeAsync, grpcClient.DeleteAttribute, effectiveSettings.DeleteAttributeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAttribute);
            Modify_DeleteAttributeApiCall(ref _callDeleteAttribute);
            _callListAttributes = clientHelper.BuildApiCall<ListAttributesRequest, ListAttributesResponse>("ListAttributes", grpcClient.ListAttributesAsync, grpcClient.ListAttributes, effectiveSettings.ListAttributesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAttributes);
            Modify_ListAttributesApiCall(ref _callListAttributes);
            _callSearchResources = clientHelper.BuildApiCall<SearchResourcesRequest, SearchResourcesResponse>("SearchResources", grpcClient.SearchResourcesAsync, grpcClient.SearchResources, effectiveSettings.SearchResourcesSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callSearchResources);
            Modify_SearchResourcesApiCall(ref _callSearchResources);
            _callCreateExternalApi = clientHelper.BuildApiCall<CreateExternalApiRequest, ExternalApi>("CreateExternalApi", grpcClient.CreateExternalApiAsync, grpcClient.CreateExternalApi, effectiveSettings.CreateExternalApiSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExternalApi);
            Modify_CreateExternalApiApiCall(ref _callCreateExternalApi);
            _callGetExternalApi = clientHelper.BuildApiCall<GetExternalApiRequest, ExternalApi>("GetExternalApi", grpcClient.GetExternalApiAsync, grpcClient.GetExternalApi, effectiveSettings.GetExternalApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExternalApi);
            Modify_GetExternalApiApiCall(ref _callGetExternalApi);
            _callUpdateExternalApi = clientHelper.BuildApiCall<UpdateExternalApiRequest, ExternalApi>("UpdateExternalApi", grpcClient.UpdateExternalApiAsync, grpcClient.UpdateExternalApi, effectiveSettings.UpdateExternalApiSettings).WithGoogleRequestParam("external_api.name", request => request.ExternalApi?.Name);
            Modify_ApiCall(ref _callUpdateExternalApi);
            Modify_UpdateExternalApiApiCall(ref _callUpdateExternalApi);
            _callDeleteExternalApi = clientHelper.BuildApiCall<DeleteExternalApiRequest, wkt::Empty>("DeleteExternalApi", grpcClient.DeleteExternalApiAsync, grpcClient.DeleteExternalApi, effectiveSettings.DeleteExternalApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExternalApi);
            Modify_DeleteExternalApiApiCall(ref _callDeleteExternalApi);
            _callListExternalApis = clientHelper.BuildApiCall<ListExternalApisRequest, ListExternalApisResponse>("ListExternalApis", grpcClient.ListExternalApisAsync, grpcClient.ListExternalApis, effectiveSettings.ListExternalApisSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExternalApis);
            Modify_ListExternalApisApiCall(ref _callListExternalApis);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateApiApiCall(ref gaxgrpc::ApiCall<CreateApiRequest, Api> call);

        partial void Modify_GetApiApiCall(ref gaxgrpc::ApiCall<GetApiRequest, Api> call);

        partial void Modify_ListApisApiCall(ref gaxgrpc::ApiCall<ListApisRequest, ListApisResponse> call);

        partial void Modify_UpdateApiApiCall(ref gaxgrpc::ApiCall<UpdateApiRequest, Api> call);

        partial void Modify_DeleteApiApiCall(ref gaxgrpc::ApiCall<DeleteApiRequest, wkt::Empty> call);

        partial void Modify_CreateVersionApiCall(ref gaxgrpc::ApiCall<CreateVersionRequest, Version> call);

        partial void Modify_GetVersionApiCall(ref gaxgrpc::ApiCall<GetVersionRequest, Version> call);

        partial void Modify_ListVersionsApiCall(ref gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> call);

        partial void Modify_UpdateVersionApiCall(ref gaxgrpc::ApiCall<UpdateVersionRequest, Version> call);

        partial void Modify_DeleteVersionApiCall(ref gaxgrpc::ApiCall<DeleteVersionRequest, wkt::Empty> call);

        partial void Modify_CreateSpecApiCall(ref gaxgrpc::ApiCall<CreateSpecRequest, Spec> call);

        partial void Modify_GetSpecApiCall(ref gaxgrpc::ApiCall<GetSpecRequest, Spec> call);

        partial void Modify_GetSpecContentsApiCall(ref gaxgrpc::ApiCall<GetSpecContentsRequest, SpecContents> call);

        partial void Modify_ListSpecsApiCall(ref gaxgrpc::ApiCall<ListSpecsRequest, ListSpecsResponse> call);

        partial void Modify_UpdateSpecApiCall(ref gaxgrpc::ApiCall<UpdateSpecRequest, Spec> call);

        partial void Modify_DeleteSpecApiCall(ref gaxgrpc::ApiCall<DeleteSpecRequest, wkt::Empty> call);

        partial void Modify_GetApiOperationApiCall(ref gaxgrpc::ApiCall<GetApiOperationRequest, ApiOperation> call);

        partial void Modify_ListApiOperationsApiCall(ref gaxgrpc::ApiCall<ListApiOperationsRequest, ListApiOperationsResponse> call);

        partial void Modify_GetDefinitionApiCall(ref gaxgrpc::ApiCall<GetDefinitionRequest, Definition> call);

        partial void Modify_CreateDeploymentApiCall(ref gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> call);

        partial void Modify_GetDeploymentApiCall(ref gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> call);

        partial void Modify_ListDeploymentsApiCall(ref gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> call);

        partial void Modify_UpdateDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateDeploymentRequest, Deployment> call);

        partial void Modify_DeleteDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteDeploymentRequest, wkt::Empty> call);

        partial void Modify_CreateAttributeApiCall(ref gaxgrpc::ApiCall<CreateAttributeRequest, Attribute> call);

        partial void Modify_GetAttributeApiCall(ref gaxgrpc::ApiCall<GetAttributeRequest, Attribute> call);

        partial void Modify_UpdateAttributeApiCall(ref gaxgrpc::ApiCall<UpdateAttributeRequest, Attribute> call);

        partial void Modify_DeleteAttributeApiCall(ref gaxgrpc::ApiCall<DeleteAttributeRequest, wkt::Empty> call);

        partial void Modify_ListAttributesApiCall(ref gaxgrpc::ApiCall<ListAttributesRequest, ListAttributesResponse> call);

        partial void Modify_SearchResourcesApiCall(ref gaxgrpc::ApiCall<SearchResourcesRequest, SearchResourcesResponse> call);

        partial void Modify_CreateExternalApiApiCall(ref gaxgrpc::ApiCall<CreateExternalApiRequest, ExternalApi> call);

        partial void Modify_GetExternalApiApiCall(ref gaxgrpc::ApiCall<GetExternalApiRequest, ExternalApi> call);

        partial void Modify_UpdateExternalApiApiCall(ref gaxgrpc::ApiCall<UpdateExternalApiRequest, ExternalApi> call);

        partial void Modify_DeleteExternalApiApiCall(ref gaxgrpc::ApiCall<DeleteExternalApiRequest, wkt::Empty> call);

        partial void Modify_ListExternalApisApiCall(ref gaxgrpc::ApiCall<ListExternalApisRequest, ListExternalApisResponse> call);

        partial void OnConstruction(ApiHub.ApiHubClient grpcClient, ApiHubSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiHub client</summary>
        public override ApiHub.ApiHubClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateApiRequest(ref CreateApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiRequest(ref GetApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApisRequest(ref ListApisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApiRequest(ref UpdateApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiRequest(ref DeleteApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVersionRequest(ref CreateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVersionRequest(ref GetVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVersionsRequest(ref ListVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVersionRequest(ref UpdateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVersionRequest(ref DeleteVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSpecRequest(ref CreateSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpecRequest(ref GetSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpecContentsRequest(ref GetSpecContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSpecsRequest(ref ListSpecsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpecRequest(ref UpdateSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSpecRequest(ref DeleteSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiOperationRequest(ref GetApiOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApiOperationsRequest(ref ListApiOperationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDefinitionRequest(ref GetDefinitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeploymentRequest(ref CreateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeploymentRequest(ref GetDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeploymentsRequest(ref ListDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeploymentRequest(ref UpdateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeploymentRequest(ref DeleteDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAttributeRequest(ref CreateAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAttributeRequest(ref GetAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAttributeRequest(ref UpdateAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAttributeRequest(ref DeleteAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAttributesRequest(ref ListAttributesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchResourcesRequest(ref SearchResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExternalApiRequest(ref CreateExternalApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExternalApiRequest(ref GetExternalApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExternalApiRequest(ref UpdateExternalApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExternalApiRequest(ref DeleteExternalApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExternalApisRequest(ref ListExternalApisRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Api CreateApi(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiRequest(ref request, ref callSettings);
            return _callCreateApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an API resource in the API hub.
        /// Once an API resource is created, versions can be added to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Api> CreateApiAsync(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiRequest(ref request, ref callSettings);
            return _callCreateApi.Async(request, callSettings);
        }

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Api GetApi(GetApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiRequest(ref request, ref callSettings);
            return _callGetApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Get API resource details including the API versions contained in it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Api> GetApiAsync(GetApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiRequest(ref request, ref callSettings);
            return _callGetApi.Async(request, callSettings);
        }

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public override gax::PagedEnumerable<ListApisResponse, Api> ListApis(ListApisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApisRequest, ListApisResponse, Api>(_callListApis, request, callSettings);
        }

        /// <summary>
        /// List API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(ListApisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApisRequest, ListApisResponse, Api>(_callListApis, request, callSettings);
        }

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Api UpdateApi(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiRequest(ref request, ref callSettings);
            return _callUpdateApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Update an API resource in the API hub. The following fields in the
        /// [API][] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Api.display_name]
        /// * [description][google.cloud.apihub.v1.Api.description]
        /// * [owner][google.cloud.apihub.v1.Api.owner]
        /// * [documentation][google.cloud.apihub.v1.Api.documentation]
        /// * [target_user][google.cloud.apihub.v1.Api.target_user]
        /// * [team][google.cloud.apihub.v1.Api.team]
        /// * [business_unit][google.cloud.apihub.v1.Api.business_unit]
        /// * [maturity_level][google.cloud.apihub.v1.Api.maturity_level]
        /// * [attributes][google.cloud.apihub.v1.Api.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// Updating the owner field requires complete owner message
        /// and updates both owner and email fields.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Api> UpdateApiAsync(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiRequest(ref request, ref callSettings);
            return _callUpdateApi.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteApi(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiRequest(ref request, ref callSettings);
            _callDeleteApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an API resource in the API hub. API can only be deleted if all
        /// underlying versions are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteApiAsync(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiRequest(ref request, ref callSettings);
            return _callDeleteApi.Async(request, callSettings);
        }

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version CreateVersion(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVersionRequest(ref request, ref callSettings);
            return _callCreateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an API version for an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> CreateVersionAsync(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVersionRequest(ref request, ref callSettings);
            return _callCreateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about the API version of an API resource. This will include
        /// information about the specs and operations present in the API
        /// version as well as the deployments linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Async(request, callSettings);
        }

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// List API versions of an API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return _callUpdateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Update API version. The following fields in the
        /// [version][google.cloud.apihub.v1.Version] can be updated currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Version.display_name]
        /// * [description][google.cloud.apihub.v1.Version.description]
        /// * [documentation][google.cloud.apihub.v1.Version.documentation]
        /// * [deployments][google.cloud.apihub.v1.Version.deployments]
        /// * [lifecycle][google.cloud.apihub.v1.Version.lifecycle]
        /// * [compliance][google.cloud.apihub.v1.Version.compliance]
        /// * [accreditation][google.cloud.apihub.v1.Version.accreditation]
        /// * [attributes][google.cloud.apihub.v1.Version.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateVersionRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return _callUpdateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            _callDeleteVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an API version. Version can only be deleted if all underlying specs,
        /// operations, definitions and linked deployments are deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            return _callDeleteVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Spec CreateSpec(CreateSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpecRequest(ref request, ref callSettings);
            return _callCreateSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Add a spec to an API version in the API hub.
        /// Multiple specs can be added to an API version.
        /// Note, while adding a spec, at least one of `contents` or `source_uri` must
        /// be provided. If `contents` is provided, then `spec_type` must also be
        /// provided.
        /// 
        /// On adding a spec with contents to the version, the operations present in it
        /// will be added to the version.Note that the file contents in the spec should
        /// be of the same type as defined in the
        /// `projects/{project}/locations/{location}/attributes/system-spec-type`
        /// attribute associated with spec resource. Note that specs of various types
        /// can be uploaded, however parsing of details is supported for OpenAPI spec
        /// currently.
        /// 
        /// In order to access the information parsed from the spec, use the
        /// [GetSpec][google.cloud.apihub.v1.ApiHub.GetSpec] method.
        /// In order to access the raw contents for a particular spec, use the
        /// [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method.
        /// In order to access the operations parsed from the spec, use the
        /// [ListAPIOperations][google.cloud.apihub.v1.ApiHub.ListApiOperations]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Spec> CreateSpecAsync(CreateSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpecRequest(ref request, ref callSettings);
            return _callCreateSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Spec GetSpec(GetSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpecRequest(ref request, ref callSettings);
            return _callGetSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about the information parsed from a spec.
        /// Note that this method does not return the raw spec contents.
        /// Use [GetSpecContents][google.cloud.apihub.v1.ApiHub.GetSpecContents] method
        /// to retrieve the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Spec> GetSpecAsync(GetSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpecRequest(ref request, ref callSettings);
            return _callGetSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SpecContents GetSpecContents(GetSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpecContentsRequest(ref request, ref callSettings);
            return _callGetSpecContents.Sync(request, callSettings);
        }

        /// <summary>
        /// Get spec contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SpecContents> GetSpecContentsAsync(GetSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpecContentsRequest(ref request, ref callSettings);
            return _callGetSpecContents.Async(request, callSettings);
        }

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Spec"/> resources.</returns>
        public override gax::PagedEnumerable<ListSpecsResponse, Spec> ListSpecs(ListSpecsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpecsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSpecsRequest, ListSpecsResponse, Spec>(_callListSpecs, request, callSettings);
        }

        /// <summary>
        /// List specs corresponding to a particular API resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Spec"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSpecsResponse, Spec> ListSpecsAsync(ListSpecsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpecsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSpecsRequest, ListSpecsResponse, Spec>(_callListSpecs, request, callSettings);
        }

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Spec UpdateSpec(UpdateSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpecRequest(ref request, ref callSettings);
            return _callUpdateSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Update spec. The following fields in the
        /// [spec][google.cloud.apihub.v1.Spec] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Spec.display_name]
        /// * [source_uri][google.cloud.apihub.v1.Spec.source_uri]
        /// * [lint_response][google.cloud.apihub.v1.Spec.lint_response]
        /// * [attributes][google.cloud.apihub.v1.Spec.attributes]
        /// * [contents][google.cloud.apihub.v1.Spec.contents]
        /// * [spec_type][google.cloud.apihub.v1.Spec.spec_type]
        /// 
        /// In case of an OAS spec, updating spec contents can lead to:
        /// 1. Creation, deletion and update of operations.
        /// 2. Creation, deletion and update of definitions.
        /// 3. Update of other info parsed out from the new spec.
        /// 
        /// In case of contents or source_uri being present in update mask, spec_type
        /// must also be present. Also, spec_type can not be present in update mask if
        /// contents or source_uri is not present.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateSpecRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Spec> UpdateSpecAsync(UpdateSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpecRequest(ref request, ref callSettings);
            return _callUpdateSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSpec(DeleteSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpecRequest(ref request, ref callSettings);
            _callDeleteSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a spec.
        /// Deleting a spec will also delete the associated operations from the
        /// version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSpecAsync(DeleteSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpecRequest(ref request, ref callSettings);
            return _callDeleteSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiOperation GetApiOperation(GetApiOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiOperationRequest(ref request, ref callSettings);
            return _callGetApiOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about a particular operation in API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiOperation> GetApiOperationAsync(GetApiOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiOperationRequest(ref request, ref callSettings);
            return _callGetApiOperation.Async(request, callSettings);
        }

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiOperation"/> resources.</returns>
        public override gax::PagedEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperations(ListApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApiOperationsRequest, ListApiOperationsResponse, ApiOperation>(_callListApiOperations, request, callSettings);
        }

        /// <summary>
        /// List operations in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiOperation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApiOperationsResponse, ApiOperation> ListApiOperationsAsync(ListApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApiOperationsRequest, ListApiOperationsResponse, ApiOperation>(_callListApiOperations, request, callSettings);
        }

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Definition GetDefinition(GetDefinitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDefinitionRequest(ref request, ref callSettings);
            return _callGetDefinition.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about a definition in an API version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Definition> GetDefinitionAsync(GetDefinitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDefinitionRequest(ref request, ref callSettings);
            return _callGetDefinition.Async(request, callSettings);
        }

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a deployment resource in the API hub.
        /// Once a deployment resource is created, it can be associated with API
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about a deployment and the API versions linked to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// List deployment resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return _callUpdateDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a deployment resource in the API hub. The following fields in the
        /// [deployment resource][google.cloud.apihub.v1.Deployment] can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Deployment.display_name]
        /// * [description][google.cloud.apihub.v1.Deployment.description]
        /// * [documentation][google.cloud.apihub.v1.Deployment.documentation]
        /// * [deployment_type][google.cloud.apihub.v1.Deployment.deployment_type]
        /// * [resource_uri][google.cloud.apihub.v1.Deployment.resource_uri]
        /// * [endpoints][google.cloud.apihub.v1.Deployment.endpoints]
        /// * [slo][google.cloud.apihub.v1.Deployment.slo]
        /// * [environment][google.cloud.apihub.v1.Deployment.environment]
        /// * [attributes][google.cloud.apihub.v1.Deployment.attributes]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateDeploymentRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return _callUpdateDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            _callDeleteDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a deployment resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            return _callDeleteDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attribute CreateAttribute(CreateAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttributeRequest(ref request, ref callSettings);
            return _callCreateAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a user defined attribute.
        /// 
        /// Certain pre defined attributes are already created by the API hub. These
        /// attributes will have type as `SYSTEM_DEFINED` and can be listed via
        /// [ListAttributes][google.cloud.apihub.v1.ApiHub.ListAttributes] method.
        /// Allowed values for the same can be updated via
        /// [UpdateAttribute][google.cloud.apihub.v1.ApiHub.UpdateAttribute] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attribute> CreateAttributeAsync(CreateAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttributeRequest(ref request, ref callSettings);
            return _callCreateAttribute.Async(request, callSettings);
        }

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attribute GetAttribute(GetAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttributeRequest(ref request, ref callSettings);
            return _callGetAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about the attribute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attribute> GetAttributeAsync(GetAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttributeRequest(ref request, ref callSettings);
            return _callGetAttribute.Async(request, callSettings);
        }

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attribute UpdateAttribute(UpdateAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttributeRequest(ref request, ref callSettings);
            return _callUpdateAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the attribute.  The following fields in the
        /// [Attribute resource][google.cloud.apihub.v1.Attribute] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Attribute.display_name]
        /// The display name can be updated for user defined attributes only.
        /// * [description][google.cloud.apihub.v1.Attribute.description]
        /// The description can be updated for user defined attributes only.
        /// * [allowed_values][google.cloud.apihub.v1.Attribute.allowed_values]
        /// To update the list of allowed values, clients need to use the fetched list
        /// of allowed values and add or remove values to or from the same list.
        /// The mutable allowed values can be updated for both user defined and System
        /// defined attributes. The immutable allowed values cannot be updated or
        /// deleted. The updated list of allowed values cannot be empty. If an allowed
        /// value that is already used by some resource's attribute is deleted, then
        /// the association between the resource and the attribute value will also be
        /// deleted.
        /// * [cardinality][google.cloud.apihub.v1.Attribute.cardinality]
        /// The cardinality can be updated for user defined attributes only.
        /// Cardinality can only be increased during an update.
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateAttributeRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attribute> UpdateAttributeAsync(UpdateAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttributeRequest(ref request, ref callSettings);
            return _callUpdateAttribute.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAttribute(DeleteAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttributeRequest(ref request, ref callSettings);
            _callDeleteAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an attribute.
        /// 
        /// Note: System defined attributes cannot be deleted. All
        /// associations of the attribute being deleted with any API hub resource will
        /// also get deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAttributeAsync(DeleteAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttributeRequest(ref request, ref callSettings);
            return _callDeleteAttribute.Async(request, callSettings);
        }

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attribute"/> resources.</returns>
        public override gax::PagedEnumerable<ListAttributesResponse, Attribute> ListAttributes(ListAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttributesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAttributesRequest, ListAttributesResponse, Attribute>(_callListAttributes, request, callSettings);
        }

        /// <summary>
        /// List all attributes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attribute"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAttributesResponse, Attribute> ListAttributesAsync(ListAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttributesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAttributesRequest, ListAttributesResponse, Attribute>(_callListAttributes, request, callSettings);
        }

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchResourcesResponse, SearchResult> SearchResources(SearchResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchResourcesRequest, SearchResourcesResponse, SearchResult>(_callSearchResources, request, callSettings);
        }

        /// <summary>
        /// Search across API-Hub resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchResourcesResponse, SearchResult> SearchResourcesAsync(SearchResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchResourcesRequest, SearchResourcesResponse, SearchResult>(_callSearchResources, request, callSettings);
        }

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExternalApi CreateExternalApi(CreateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExternalApiRequest(ref request, ref callSettings);
            return _callCreateExternalApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExternalApi> CreateExternalApiAsync(CreateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExternalApiRequest(ref request, ref callSettings);
            return _callCreateExternalApi.Async(request, callSettings);
        }

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExternalApi GetExternalApi(GetExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExternalApiRequest(ref request, ref callSettings);
            return _callGetExternalApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExternalApi> GetExternalApiAsync(GetExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExternalApiRequest(ref request, ref callSettings);
            return _callGetExternalApi.Async(request, callSettings);
        }

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExternalApi UpdateExternalApi(UpdateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExternalApiRequest(ref request, ref callSettings);
            return _callUpdateExternalApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Update an External API resource in the API hub. The following fields can be
        /// updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.ExternalApi.display_name]
        /// * [description][google.cloud.apihub.v1.ExternalApi.description]
        /// * [documentation][google.cloud.apihub.v1.ExternalApi.documentation]
        /// * [endpoints][google.cloud.apihub.v1.ExternalApi.endpoints]
        /// * [paths][google.cloud.apihub.v1.ExternalApi.paths]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateExternalApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExternalApi> UpdateExternalApiAsync(UpdateExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExternalApiRequest(ref request, ref callSettings);
            return _callUpdateExternalApi.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteExternalApi(DeleteExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExternalApiRequest(ref request, ref callSettings);
            _callDeleteExternalApi.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an External API resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteExternalApiAsync(DeleteExternalApiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExternalApiRequest(ref request, ref callSettings);
            return _callDeleteExternalApi.Async(request, callSettings);
        }

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExternalApi"/> resources.</returns>
        public override gax::PagedEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApis(ListExternalApisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExternalApisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExternalApisRequest, ListExternalApisResponse, ExternalApi>(_callListExternalApis, request, callSettings);
        }

        /// <summary>
        /// List External API resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExternalApi"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExternalApisResponse, ExternalApi> ListExternalApisAsync(ListExternalApisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExternalApisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExternalApisRequest, ListExternalApisResponse, ExternalApi>(_callListExternalApis, request, callSettings);
        }
    }

    public partial class ListApisRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSpecsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApiOperationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAttributesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExternalApisRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApisResponse : gaxgrpc::IPageResponse<Api>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Api> GetEnumerator() => Apis.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVersionsResponse : gaxgrpc::IPageResponse<Version>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Version> GetEnumerator() => Versions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSpecsResponse : gaxgrpc::IPageResponse<Spec>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Spec> GetEnumerator() => Specs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApiOperationsResponse : gaxgrpc::IPageResponse<ApiOperation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiOperation> GetEnumerator() => ApiOperations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeploymentsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAttributesResponse : gaxgrpc::IPageResponse<Attribute>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Attribute> GetEnumerator() => Attributes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchResourcesResponse : gaxgrpc::IPageResponse<SearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchResult> GetEnumerator() => SearchResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExternalApisResponse : gaxgrpc::IPageResponse<ExternalApi>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ExternalApi> GetEnumerator() => ExternalApis.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ApiHub
    {
        public partial class ApiHubClient
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
