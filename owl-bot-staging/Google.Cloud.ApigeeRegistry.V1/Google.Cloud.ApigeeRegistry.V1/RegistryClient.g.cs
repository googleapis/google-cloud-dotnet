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
using ga = Google.Api;
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.ApigeeRegistry.V1
{
    /// <summary>Settings for <see cref="RegistryClient"/> instances.</summary>
    public sealed partial class RegistrySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegistrySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegistrySettings"/>.</returns>
        public static RegistrySettings GetDefault() => new RegistrySettings();

        /// <summary>Constructs a new <see cref="RegistrySettings"/> object with default settings.</summary>
        public RegistrySettings()
        {
        }

        private RegistrySettings(RegistrySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListApisSettings = existing.ListApisSettings;
            GetApiSettings = existing.GetApiSettings;
            CreateApiSettings = existing.CreateApiSettings;
            UpdateApiSettings = existing.UpdateApiSettings;
            DeleteApiSettings = existing.DeleteApiSettings;
            ListApiVersionsSettings = existing.ListApiVersionsSettings;
            GetApiVersionSettings = existing.GetApiVersionSettings;
            CreateApiVersionSettings = existing.CreateApiVersionSettings;
            UpdateApiVersionSettings = existing.UpdateApiVersionSettings;
            DeleteApiVersionSettings = existing.DeleteApiVersionSettings;
            ListApiSpecsSettings = existing.ListApiSpecsSettings;
            GetApiSpecSettings = existing.GetApiSpecSettings;
            GetApiSpecContentsSettings = existing.GetApiSpecContentsSettings;
            CreateApiSpecSettings = existing.CreateApiSpecSettings;
            UpdateApiSpecSettings = existing.UpdateApiSpecSettings;
            DeleteApiSpecSettings = existing.DeleteApiSpecSettings;
            TagApiSpecRevisionSettings = existing.TagApiSpecRevisionSettings;
            ListApiSpecRevisionsSettings = existing.ListApiSpecRevisionsSettings;
            RollbackApiSpecSettings = existing.RollbackApiSpecSettings;
            DeleteApiSpecRevisionSettings = existing.DeleteApiSpecRevisionSettings;
            ListApiDeploymentsSettings = existing.ListApiDeploymentsSettings;
            GetApiDeploymentSettings = existing.GetApiDeploymentSettings;
            CreateApiDeploymentSettings = existing.CreateApiDeploymentSettings;
            UpdateApiDeploymentSettings = existing.UpdateApiDeploymentSettings;
            DeleteApiDeploymentSettings = existing.DeleteApiDeploymentSettings;
            TagApiDeploymentRevisionSettings = existing.TagApiDeploymentRevisionSettings;
            ListApiDeploymentRevisionsSettings = existing.ListApiDeploymentRevisionsSettings;
            RollbackApiDeploymentSettings = existing.RollbackApiDeploymentSettings;
            DeleteApiDeploymentRevisionSettings = existing.DeleteApiDeploymentRevisionSettings;
            ListArtifactsSettings = existing.ListArtifactsSettings;
            GetArtifactSettings = existing.GetArtifactSettings;
            GetArtifactContentsSettings = existing.GetArtifactContentsSettings;
            CreateArtifactSettings = existing.CreateArtifactSettings;
            ReplaceArtifactSettings = existing.ReplaceArtifactSettings;
            DeleteArtifactSettings = existing.DeleteArtifactSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegistrySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.ListApis</c>
        /// and <c>RegistryClient.ListApisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.GetApi</c>
        /// and <c>RegistryClient.GetApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.CreateApi</c>
        ///  and <c>RegistryClient.CreateApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.UpdateApi</c>
        ///  and <c>RegistryClient.UpdateApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.DeleteApi</c>
        ///  and <c>RegistryClient.DeleteApiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.ListApiVersions</c> and <c>RegistryClient.ListApiVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApiVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.GetApiVersion</c> and <c>RegistryClient.GetApiVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApiVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.CreateApiVersion</c> and <c>RegistryClient.CreateApiVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.UpdateApiVersion</c> and <c>RegistryClient.UpdateApiVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApiVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.DeleteApiVersion</c> and <c>RegistryClient.DeleteApiVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.ListApiSpecs</c>
        ///  and <c>RegistryClient.ListApiSpecsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApiSpecsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.GetApiSpec</c>
        ///  and <c>RegistryClient.GetApiSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApiSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.GetApiSpecContents</c> and <c>RegistryClient.GetApiSpecContentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApiSpecContentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.CreateApiSpec</c> and <c>RegistryClient.CreateApiSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.UpdateApiSpec</c> and <c>RegistryClient.UpdateApiSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApiSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.DeleteApiSpec</c> and <c>RegistryClient.DeleteApiSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.TagApiSpecRevision</c> and <c>RegistryClient.TagApiSpecRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TagApiSpecRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.ListApiSpecRevisions</c> and <c>RegistryClient.ListApiSpecRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApiSpecRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.RollbackApiSpec</c> and <c>RegistryClient.RollbackApiSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackApiSpecSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.DeleteApiSpecRevision</c> and <c>RegistryClient.DeleteApiSpecRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiSpecRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.ListApiDeployments</c> and <c>RegistryClient.ListApiDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApiDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.GetApiDeployment</c> and <c>RegistryClient.GetApiDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApiDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.CreateApiDeployment</c> and <c>RegistryClient.CreateApiDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.UpdateApiDeployment</c> and <c>RegistryClient.UpdateApiDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApiDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.DeleteApiDeployment</c> and <c>RegistryClient.DeleteApiDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.TagApiDeploymentRevision</c> and <c>RegistryClient.TagApiDeploymentRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TagApiDeploymentRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.ListApiDeploymentRevisions</c> and <c>RegistryClient.ListApiDeploymentRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApiDeploymentRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.RollbackApiDeployment</c> and <c>RegistryClient.RollbackApiDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackApiDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.DeleteApiDeploymentRevision</c> and <c>RegistryClient.DeleteApiDeploymentRevisionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApiDeploymentRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.ListArtifacts</c> and <c>RegistryClient.ListArtifactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListArtifactsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegistryClient.GetArtifact</c>
        ///  and <c>RegistryClient.GetArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetArtifactSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.GetArtifactContents</c> and <c>RegistryClient.GetArtifactContentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetArtifactContentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.CreateArtifact</c> and <c>RegistryClient.CreateArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateArtifactSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.ReplaceArtifact</c> and <c>RegistryClient.ReplaceArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReplaceArtifactSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistryClient.DeleteArtifact</c> and <c>RegistryClient.DeleteArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 200 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteArtifactSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(200), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegistrySettings"/> object.</returns>
        public RegistrySettings Clone() => new RegistrySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegistryClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RegistryClientBuilder : gaxgrpc::ClientBuilderBase<RegistryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegistrySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegistryClientBuilder() : base(RegistryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegistryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegistryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegistryClient Build()
        {
            RegistryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegistryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegistryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegistryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegistryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegistryClient.ChannelPool;
    }

    /// <summary>Registry client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Registry service allows teams to manage descriptions of APIs.
    /// </remarks>
    public abstract partial class RegistryClient
    {
        /// <summary>
        /// The default endpoint for the Registry service, which is a host of "apigeeregistry.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apigeeregistry.googleapis.com:443";

        /// <summary>The default Registry scopes.</summary>
        /// <remarks>
        /// The default Registry scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Registry.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegistryClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="RegistryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegistryClient"/>.</returns>
        public static stt::Task<RegistryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegistryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegistryClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="RegistryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegistryClient"/>.</returns>
        public static RegistryClient Create() => new RegistryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegistryClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegistrySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegistryClient"/>.</returns>
        internal static RegistryClient Create(grpccore::CallInvoker callInvoker, RegistrySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Registry.RegistryClient grpcClient = new Registry.RegistryClient(callInvoker);
            return new RegistryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Registry client</summary>
        public virtual Registry.RegistryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching APIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApisResponse, Api> ListApis(ListApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching APIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Api"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApisResponse, Api> ListApisAsync(ListApisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching APIs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
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
        /// Returns matching APIs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
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
        /// Returns matching APIs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
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
        /// Returns matching APIs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
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
        /// Returns a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(GetApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(GetApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(GetApiRequest request, st::CancellationToken cancellationToken) =>
            GetApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to retrieve.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApi(new GetApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to retrieve.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiAsync(new GetApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to retrieve.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to retrieve.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api GetApi(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApi(new GetApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to retrieve.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiAsync(new GetApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified API.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to retrieve.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> GetApiAsync(ApiName name, st::CancellationToken cancellationToken) =>
            GetApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api CreateApi(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(CreateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(CreateApiRequest request, st::CancellationToken cancellationToken) =>
            CreateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="api">
        /// Required. The API to create.
        /// </param>
        /// <param name="apiId">
        /// Required. The ID to use for the API, which will become the final component of
        /// the API's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api CreateApi(string parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApi(new CreateApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="api">
        /// Required. The API to create.
        /// </param>
        /// <param name="apiId">
        /// Required. The ID to use for the API, which will become the final component of
        /// the API's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(string parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiAsync(new CreateApiRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="api">
        /// Required. The API to create.
        /// </param>
        /// <param name="apiId">
        /// Required. The ID to use for the API, which will become the final component of
        /// the API's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(string parent, Api api, string apiId, st::CancellationToken cancellationToken) =>
            CreateApiAsync(parent, api, apiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="api">
        /// Required. The API to create.
        /// </param>
        /// <param name="apiId">
        /// Required. The ID to use for the API, which will become the final component of
        /// the API's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api CreateApi(gagr::LocationName parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApi(new CreateApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="api">
        /// Required. The API to create.
        /// </param>
        /// <param name="apiId">
        /// Required. The ID to use for the API, which will become the final component of
        /// the API's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(gagr::LocationName parent, Api api, string apiId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiAsync(new CreateApiRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                ApiId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiId, nameof(apiId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified API.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of APIs.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="api">
        /// Required. The API to create.
        /// </param>
        /// <param name="apiId">
        /// Required. The ID to use for the API, which will become the final component of
        /// the API's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> CreateApiAsync(gagr::LocationName parent, Api api, string apiId, st::CancellationToken cancellationToken) =>
            CreateApiAsync(parent, api, apiId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api UpdateApi(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(UpdateApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(UpdateApiRequest request, st::CancellationToken cancellationToken) =>
            UpdateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified API.
        /// </summary>
        /// <param name="api">
        /// Required. The API to update.
        /// 
        /// The `name` field is used to identify the API to update.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Api UpdateApi(Api api, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApi(new UpdateApiRequest
            {
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified API.
        /// </summary>
        /// <param name="api">
        /// Required. The API to update.
        /// 
        /// The `name` field is used to identify the API to update.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(Api api, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiAsync(new UpdateApiRequest
            {
                Api = gax::GaxPreconditions.CheckNotNull(api, nameof(api)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified API.
        /// </summary>
        /// <param name="api">
        /// Required. The API to update.
        /// 
        /// The `name` field is used to identify the API to update.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Api> UpdateApiAsync(Api api, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApiAsync(api, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApi(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(DeleteApiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(DeleteApiRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to delete.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApi(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApi(new DeleteApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to delete.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiAsync(new DeleteApiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to delete.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to delete.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApi(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApi(new DeleteApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to delete.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(ApiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiAsync(new DeleteApiRequest
            {
                ApiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified API and all of the resources that it
        /// owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API to delete.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiAsync(ApiName name, st::CancellationToken cancellationToken) =>
            DeleteApiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns matching versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersions(ListApiVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersionsAsync(ListApiVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable sequence of <see cref="ApiVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiVersionsRequest request = new ListApiVersionsRequest
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
            return ListApiVersions(request, callSettings);
        }

        /// <summary>
        /// Returns matching versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiVersionsRequest request = new ListApiVersionsRequest
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
            return ListApiVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable sequence of <see cref="ApiVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersions(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiVersionsRequest request = new ListApiVersionsRequest
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
            return ListApiVersions(request, callSettings);
        }

        /// <summary>
        /// Returns matching versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersionsAsync(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiVersionsRequest request = new ListApiVersionsRequest
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
            return ListApiVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion GetApiVersion(GetApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> GetApiVersionAsync(GetApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> GetApiVersionAsync(GetApiVersionRequest request, st::CancellationToken cancellationToken) =>
            GetApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion GetApiVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiVersion(new GetApiVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> GetApiVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiVersionAsync(new GetApiVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> GetApiVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion GetApiVersion(ApiVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiVersion(new GetApiVersionRequest
            {
                ApiVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> GetApiVersionAsync(ApiVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiVersionAsync(new GetApiVersionRequest
            {
                ApiVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> GetApiVersionAsync(ApiVersionName name, st::CancellationToken cancellationToken) =>
            GetApiVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion CreateApiVersion(CreateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> CreateApiVersionAsync(CreateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> CreateApiVersionAsync(CreateApiVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiVersion">
        /// Required. The version to create.
        /// </param>
        /// <param name="apiVersionId">
        /// Required. The ID to use for the version, which will become the final component of
        /// the version's resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion CreateApiVersion(string parent, ApiVersion apiVersion, string apiVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiVersion(new CreateApiVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiVersion = gax::GaxPreconditions.CheckNotNull(apiVersion, nameof(apiVersion)),
                ApiVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiVersionId, nameof(apiVersionId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiVersion">
        /// Required. The version to create.
        /// </param>
        /// <param name="apiVersionId">
        /// Required. The ID to use for the version, which will become the final component of
        /// the version's resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> CreateApiVersionAsync(string parent, ApiVersion apiVersion, string apiVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiVersionAsync(new CreateApiVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiVersion = gax::GaxPreconditions.CheckNotNull(apiVersion, nameof(apiVersion)),
                ApiVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiVersionId, nameof(apiVersionId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiVersion">
        /// Required. The version to create.
        /// </param>
        /// <param name="apiVersionId">
        /// Required. The ID to use for the version, which will become the final component of
        /// the version's resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> CreateApiVersionAsync(string parent, ApiVersion apiVersion, string apiVersionId, st::CancellationToken cancellationToken) =>
            CreateApiVersionAsync(parent, apiVersion, apiVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiVersion">
        /// Required. The version to create.
        /// </param>
        /// <param name="apiVersionId">
        /// Required. The ID to use for the version, which will become the final component of
        /// the version's resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion CreateApiVersion(ApiName parent, ApiVersion apiVersion, string apiVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiVersion(new CreateApiVersionRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiVersion = gax::GaxPreconditions.CheckNotNull(apiVersion, nameof(apiVersion)),
                ApiVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiVersionId, nameof(apiVersionId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiVersion">
        /// Required. The version to create.
        /// </param>
        /// <param name="apiVersionId">
        /// Required. The ID to use for the version, which will become the final component of
        /// the version's resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> CreateApiVersionAsync(ApiName parent, ApiVersion apiVersion, string apiVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiVersionAsync(new CreateApiVersionRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiVersion = gax::GaxPreconditions.CheckNotNull(apiVersion, nameof(apiVersion)),
                ApiVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiVersionId, nameof(apiVersionId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of versions.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiVersion">
        /// Required. The version to create.
        /// </param>
        /// <param name="apiVersionId">
        /// Required. The ID to use for the version, which will become the final component of
        /// the version's resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> CreateApiVersionAsync(ApiName parent, ApiVersion apiVersion, string apiVersionId, st::CancellationToken cancellationToken) =>
            CreateApiVersionAsync(parent, apiVersion, apiVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion UpdateApiVersion(UpdateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> UpdateApiVersionAsync(UpdateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> UpdateApiVersionAsync(UpdateApiVersionRequest request, st::CancellationToken cancellationToken) =>
            UpdateApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="apiVersion">
        /// Required. The version to update.
        /// 
        /// The `name` field is used to identify the version to update.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiVersion UpdateApiVersion(ApiVersion apiVersion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiVersion(new UpdateApiVersionRequest
            {
                ApiVersion = gax::GaxPreconditions.CheckNotNull(apiVersion, nameof(apiVersion)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="apiVersion">
        /// Required. The version to update.
        /// 
        /// The `name` field is used to identify the version to update.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> UpdateApiVersionAsync(ApiVersion apiVersion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiVersionAsync(new UpdateApiVersionRequest
            {
                ApiVersion = gax::GaxPreconditions.CheckNotNull(apiVersion, nameof(apiVersion)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="apiVersion">
        /// Required. The version to update.
        /// 
        /// The `name` field is used to identify the version to update.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiVersion> UpdateApiVersionAsync(ApiVersion apiVersion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApiVersionAsync(apiVersion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiVersion(DeleteApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiVersionAsync(DeleteApiVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiVersionAsync(DeleteApiVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiVersion(new DeleteApiVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiVersionAsync(new DeleteApiVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiVersion(ApiVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiVersion(new DeleteApiVersionRequest
            {
                ApiVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiVersionAsync(ApiVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiVersionAsync(new DeleteApiVersionRequest
            {
                ApiVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the version to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiVersionAsync(ApiVersionName name, st::CancellationToken cancellationToken) =>
            DeleteApiVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecs(ListApiSpecsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecsAsync(ListApiSpecsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
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
        /// <returns>A pageable sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiSpecsRequest request = new ListApiSpecsRequest
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
            return ListApiSpecs(request, callSettings);
        }

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiSpecsRequest request = new ListApiSpecsRequest
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
            return ListApiSpecsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
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
        /// <returns>A pageable sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecs(ApiVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiSpecsRequest request = new ListApiSpecsRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApiSpecs(request, callSettings);
        }

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecsAsync(ApiVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiSpecsRequest request = new ListApiSpecsRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApiSpecsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec GetApiSpec(GetApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> GetApiSpecAsync(GetApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> GetApiSpecAsync(GetApiSpecRequest request, st::CancellationToken cancellationToken) =>
            GetApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec GetApiSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpec(new GetApiSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> GetApiSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpecAsync(new GetApiSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> GetApiSpecAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec GetApiSpec(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpec(new GetApiSpecRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> GetApiSpecAsync(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpecAsync(new GetApiSpecRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to retrieve.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> GetApiSpecAsync(ApiSpecName name, st::CancellationToken cancellationToken) =>
            GetApiSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody GetApiSpecContents(GetApiSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetApiSpecContentsAsync(GetApiSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetApiSpecContentsAsync(GetApiSpecContentsRequest request, st::CancellationToken cancellationToken) =>
            GetApiSpecContentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents should be retrieved.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody GetApiSpecContents(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpecContents(new GetApiSpecContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents should be retrieved.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetApiSpecContentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpecContentsAsync(new GetApiSpecContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents should be retrieved.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetApiSpecContentsAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiSpecContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents should be retrieved.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody GetApiSpecContents(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpecContents(new GetApiSpecContentsRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents should be retrieved.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetApiSpecContentsAsync(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiSpecContentsAsync(new GetApiSpecContentsRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec whose contents should be retrieved.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetApiSpecContentsAsync(ApiSpecName name, st::CancellationToken cancellationToken) =>
            GetApiSpecContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec CreateApiSpec(CreateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> CreateApiSpecAsync(CreateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> CreateApiSpecAsync(CreateApiSpecRequest request, st::CancellationToken cancellationToken) =>
            CreateApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="apiSpec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="apiSpecId">
        /// Required. The ID to use for the spec, which will become the final component of
        /// the spec's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec CreateApiSpec(string parent, ApiSpec apiSpec, string apiSpecId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiSpec(new CreateApiSpecRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiSpec = gax::GaxPreconditions.CheckNotNull(apiSpec, nameof(apiSpec)),
                ApiSpecId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiSpecId, nameof(apiSpecId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="apiSpec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="apiSpecId">
        /// Required. The ID to use for the spec, which will become the final component of
        /// the spec's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> CreateApiSpecAsync(string parent, ApiSpec apiSpec, string apiSpecId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiSpecAsync(new CreateApiSpecRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiSpec = gax::GaxPreconditions.CheckNotNull(apiSpec, nameof(apiSpec)),
                ApiSpecId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiSpecId, nameof(apiSpecId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="apiSpec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="apiSpecId">
        /// Required. The ID to use for the spec, which will become the final component of
        /// the spec's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> CreateApiSpecAsync(string parent, ApiSpec apiSpec, string apiSpecId, st::CancellationToken cancellationToken) =>
            CreateApiSpecAsync(parent, apiSpec, apiSpecId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="apiSpec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="apiSpecId">
        /// Required. The ID to use for the spec, which will become the final component of
        /// the spec's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec CreateApiSpec(ApiVersionName parent, ApiSpec apiSpec, string apiSpecId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiSpec(new CreateApiSpecRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiSpec = gax::GaxPreconditions.CheckNotNull(apiSpec, nameof(apiSpec)),
                ApiSpecId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiSpecId, nameof(apiSpecId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="apiSpec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="apiSpecId">
        /// Required. The ID to use for the spec, which will become the final component of
        /// the spec's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> CreateApiSpecAsync(ApiVersionName parent, ApiSpec apiSpec, string apiSpecId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiSpecAsync(new CreateApiSpecRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiSpec = gax::GaxPreconditions.CheckNotNull(apiSpec, nameof(apiSpec)),
                ApiSpecId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiSpecId, nameof(apiSpecId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of specs.
        /// Format: `projects/*/locations/*/apis/*/versions/*`
        /// </param>
        /// <param name="apiSpec">
        /// Required. The spec to create.
        /// </param>
        /// <param name="apiSpecId">
        /// Required. The ID to use for the spec, which will become the final component of
        /// the spec's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> CreateApiSpecAsync(ApiVersionName parent, ApiSpec apiSpec, string apiSpecId, st::CancellationToken cancellationToken) =>
            CreateApiSpecAsync(parent, apiSpec, apiSpecId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec UpdateApiSpec(UpdateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> UpdateApiSpecAsync(UpdateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> UpdateApiSpecAsync(UpdateApiSpecRequest request, st::CancellationToken cancellationToken) =>
            UpdateApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="apiSpec">
        /// Required. The spec to update.
        /// 
        /// The `name` field is used to identify the spec to update.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec UpdateApiSpec(ApiSpec apiSpec, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiSpec(new UpdateApiSpecRequest
            {
                ApiSpec = gax::GaxPreconditions.CheckNotNull(apiSpec, nameof(apiSpec)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="apiSpec">
        /// Required. The spec to update.
        /// 
        /// The `name` field is used to identify the spec to update.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> UpdateApiSpecAsync(ApiSpec apiSpec, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiSpecAsync(new UpdateApiSpecRequest
            {
                ApiSpec = gax::GaxPreconditions.CheckNotNull(apiSpec, nameof(apiSpec)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="apiSpec">
        /// Required. The spec to update.
        /// 
        /// The `name` field is used to identify the spec to update.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> UpdateApiSpecAsync(ApiSpec apiSpec, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApiSpecAsync(apiSpec, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiSpec(DeleteApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiSpecAsync(DeleteApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiSpecAsync(DeleteApiSpecRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpec(new DeleteApiSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpecAsync(new DeleteApiSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiSpecAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiSpec(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpec(new DeleteApiSpecRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiSpecAsync(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpecAsync(new DeleteApiSpecRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec to delete.
        /// Format: `projects/*/locations/*/apis/*/versions/*/specs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiSpecAsync(ApiSpecName name, st::CancellationToken cancellationToken) =>
            DeleteApiSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a tag to a specified revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec TagApiSpecRevision(TagApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a tag to a specified revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> TagApiSpecRevisionAsync(TagApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a tag to a specified revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> TagApiSpecRevisionAsync(TagApiSpecRevisionRequest request, st::CancellationToken cancellationToken) =>
            TagApiSpecRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all revisions of a spec.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiSpecRevisionsResponse, ApiSpec> ListApiSpecRevisions(ListApiSpecRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions of a spec.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiSpec"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiSpecRevisionsResponse, ApiSpec> ListApiSpecRevisionsAsync(ListApiSpecRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the current revision to a specified prior revision.
        /// Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec RollbackApiSpec(RollbackApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the current revision to a specified prior revision.
        /// Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> RollbackApiSpecAsync(RollbackApiSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the current revision to a specified prior revision.
        /// Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> RollbackApiSpecAsync(RollbackApiSpecRequest request, st::CancellationToken cancellationToken) =>
            RollbackApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec DeleteApiSpecRevision(DeleteApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> DeleteApiSpecRevisionAsync(DeleteApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> DeleteApiSpecRevisionAsync(DeleteApiSpecRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiSpecRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec DeleteApiSpecRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpecRevision(new DeleteApiSpecRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> DeleteApiSpecRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpecRevisionAsync(new DeleteApiSpecRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> DeleteApiSpecRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiSpecRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiSpec DeleteApiSpecRevision(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpecRevision(new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> DeleteApiSpecRevisionAsync(ApiSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiSpecRevisionAsync(new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the spec revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/versions/1.0.0/specs/openapi.yaml@c7cfa2a8`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiSpec> DeleteApiSpecRevisionAsync(ApiSpecName name, st::CancellationToken cancellationToken) =>
            DeleteApiSpecRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeployments(ListApiDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeploymentsAsync(ListApiDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiDeploymentsRequest request = new ListApiDeploymentsRequest
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
            return ListApiDeployments(request, callSettings);
        }

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiDeploymentsRequest request = new ListApiDeploymentsRequest
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
            return ListApiDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeployments(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiDeploymentsRequest request = new ListApiDeploymentsRequest
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
            return ListApiDeployments(request, callSettings);
        }

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeploymentsAsync(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApiDeploymentsRequest request = new ListApiDeploymentsRequest
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
            return ListApiDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment GetApiDeployment(GetApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> GetApiDeploymentAsync(GetApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> GetApiDeploymentAsync(GetApiDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment GetApiDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiDeployment(new GetApiDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> GetApiDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiDeploymentAsync(new GetApiDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> GetApiDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment GetApiDeployment(ApiDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiDeployment(new GetApiDeploymentRequest
            {
                ApiDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> GetApiDeploymentAsync(ApiDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiDeploymentAsync(new GetApiDeploymentRequest
            {
                ApiDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to retrieve.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> GetApiDeploymentAsync(ApiDeploymentName name, st::CancellationToken cancellationToken) =>
            GetApiDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment CreateApiDeployment(CreateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> CreateApiDeploymentAsync(CreateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> CreateApiDeploymentAsync(CreateApiDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="apiDeploymentId">
        /// Required. The ID to use for the deployment, which will become the final component of
        /// the deployment's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment CreateApiDeployment(string parent, ApiDeployment apiDeployment, string apiDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiDeployment(new CreateApiDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiDeployment = gax::GaxPreconditions.CheckNotNull(apiDeployment, nameof(apiDeployment)),
                ApiDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiDeploymentId, nameof(apiDeploymentId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="apiDeploymentId">
        /// Required. The ID to use for the deployment, which will become the final component of
        /// the deployment's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> CreateApiDeploymentAsync(string parent, ApiDeployment apiDeployment, string apiDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiDeploymentAsync(new CreateApiDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiDeployment = gax::GaxPreconditions.CheckNotNull(apiDeployment, nameof(apiDeployment)),
                ApiDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiDeploymentId, nameof(apiDeploymentId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="apiDeploymentId">
        /// Required. The ID to use for the deployment, which will become the final component of
        /// the deployment's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> CreateApiDeploymentAsync(string parent, ApiDeployment apiDeployment, string apiDeploymentId, st::CancellationToken cancellationToken) =>
            CreateApiDeploymentAsync(parent, apiDeployment, apiDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="apiDeploymentId">
        /// Required. The ID to use for the deployment, which will become the final component of
        /// the deployment's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment CreateApiDeployment(ApiName parent, ApiDeployment apiDeployment, string apiDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiDeployment(new CreateApiDeploymentRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiDeployment = gax::GaxPreconditions.CheckNotNull(apiDeployment, nameof(apiDeployment)),
                ApiDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiDeploymentId, nameof(apiDeploymentId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="apiDeploymentId">
        /// Required. The ID to use for the deployment, which will become the final component of
        /// the deployment's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> CreateApiDeploymentAsync(ApiName parent, ApiDeployment apiDeployment, string apiDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiDeploymentAsync(new CreateApiDeploymentRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiDeployment = gax::GaxPreconditions.CheckNotNull(apiDeployment, nameof(apiDeployment)),
                ApiDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(apiDeploymentId, nameof(apiDeploymentId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deployments.
        /// Format: `projects/*/locations/*/apis/*`
        /// </param>
        /// <param name="apiDeployment">
        /// Required. The deployment to create.
        /// </param>
        /// <param name="apiDeploymentId">
        /// Required. The ID to use for the deployment, which will become the final component of
        /// the deployment's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> CreateApiDeploymentAsync(ApiName parent, ApiDeployment apiDeployment, string apiDeploymentId, st::CancellationToken cancellationToken) =>
            CreateApiDeploymentAsync(parent, apiDeployment, apiDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment UpdateApiDeployment(UpdateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> UpdateApiDeploymentAsync(UpdateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> UpdateApiDeploymentAsync(UpdateApiDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="apiDeployment">
        /// Required. The deployment to update.
        /// 
        /// The `name` field is used to identify the deployment to update.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment UpdateApiDeployment(ApiDeployment apiDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiDeployment(new UpdateApiDeploymentRequest
            {
                ApiDeployment = gax::GaxPreconditions.CheckNotNull(apiDeployment, nameof(apiDeployment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="apiDeployment">
        /// Required. The deployment to update.
        /// 
        /// The `name` field is used to identify the deployment to update.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> UpdateApiDeploymentAsync(ApiDeployment apiDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApiDeploymentAsync(new UpdateApiDeploymentRequest
            {
                ApiDeployment = gax::GaxPreconditions.CheckNotNull(apiDeployment, nameof(apiDeployment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="apiDeployment">
        /// Required. The deployment to update.
        /// 
        /// The `name` field is used to identify the deployment to update.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If omitted, all fields are updated that
        /// are set in the request message (fields set to default values are ignored).
        /// If an asterisk "*" is specified, all fields are updated, including fields
        /// that are unspecified/default in the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> UpdateApiDeploymentAsync(ApiDeployment apiDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApiDeploymentAsync(apiDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiDeployment(DeleteApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiDeploymentAsync(DeleteApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiDeploymentAsync(DeleteApiDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeployment(new DeleteApiDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeploymentAsync(new DeleteApiDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApiDeployment(ApiDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeployment(new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiDeploymentAsync(ApiDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeploymentAsync(new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment to delete.
        /// Format: `projects/*/locations/*/apis/*/deployments/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApiDeploymentAsync(ApiDeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteApiDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a tag to a specified revision of a
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment TagApiDeploymentRevision(TagApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a tag to a specified revision of a
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> TagApiDeploymentRevisionAsync(TagApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a tag to a specified revision of a
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> TagApiDeploymentRevisionAsync(TagApiDeploymentRevisionRequest request, st::CancellationToken cancellationToken) =>
            TagApiDeploymentRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all revisions of a deployment.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApiDeploymentRevisionsResponse, ApiDeployment> ListApiDeploymentRevisions(ListApiDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions of a deployment.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApiDeploymentRevisionsResponse, ApiDeployment> ListApiDeploymentRevisionsAsync(ListApiDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the current revision to a specified prior
        /// revision. Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment RollbackApiDeployment(RollbackApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the current revision to a specified prior
        /// revision. Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> RollbackApiDeploymentAsync(RollbackApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the current revision to a specified prior
        /// revision. Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> RollbackApiDeploymentAsync(RollbackApiDeploymentRequest request, st::CancellationToken cancellationToken) =>
            RollbackApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment DeleteApiDeploymentRevision(DeleteApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> DeleteApiDeploymentRevisionAsync(DeleteApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> DeleteApiDeploymentRevisionAsync(DeleteApiDeploymentRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteApiDeploymentRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment DeleteApiDeploymentRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeploymentRevision(new DeleteApiDeploymentRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> DeleteApiDeploymentRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeploymentRevisionAsync(new DeleteApiDeploymentRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> DeleteApiDeploymentRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApiDeploymentRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiDeployment DeleteApiDeploymentRevision(ApiDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeploymentRevision(new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> DeleteApiDeploymentRevisionAsync(ApiDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApiDeploymentRevisionAsync(new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment revision to be deleted,
        /// with a revision ID explicitly included.
        /// 
        /// Example:
        /// `projects/sample/locations/global/apis/petstore/deployments/prod@c7cfa2a8`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiDeployment> DeleteApiDeploymentRevisionAsync(ApiDeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteApiDeploymentRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
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
            return ListArtifacts(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
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
            return ListArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
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
            return ListArtifacts(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
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
            return ListArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
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
            return ListArtifacts(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ApiName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
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
            return ListArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ApiVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListArtifacts(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ApiVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ApiSpecName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsApiSpecName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListArtifacts(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ApiSpecName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsApiSpecName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ApiDeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsApiDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListArtifacts(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ApiDeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsApiDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact GetArtifact(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(GetArtifactRequest request, st::CancellationToken cancellationToken) =>
            GetArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to retrieve.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact GetArtifact(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifact(new GetArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to retrieve.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactAsync(new GetArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to retrieve.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(string name, st::CancellationToken cancellationToken) =>
            GetArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to retrieve.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact GetArtifact(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifact(new GetArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to retrieve.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactAsync(new GetArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to retrieve.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> GetArtifactAsync(ArtifactName name, st::CancellationToken cancellationToken) =>
            GetArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody GetArtifactContents(GetArtifactContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetArtifactContentsAsync(GetArtifactContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetArtifactContentsAsync(GetArtifactContentsRequest request, st::CancellationToken cancellationToken) =>
            GetArtifactContentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact whose contents should be retrieved.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody GetArtifactContents(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactContents(new GetArtifactContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact whose contents should be retrieved.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetArtifactContentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactContentsAsync(new GetArtifactContentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact whose contents should be retrieved.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetArtifactContentsAsync(string name, st::CancellationToken cancellationToken) =>
            GetArtifactContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact whose contents should be retrieved.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody GetArtifactContents(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactContents(new GetArtifactContentsRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact whose contents should be retrieved.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetArtifactContentsAsync(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetArtifactContentsAsync(new GetArtifactContentsRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact whose contents should be retrieved.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetArtifactContentsAsync(ArtifactName name, st::CancellationToken cancellationToken) =>
            GetArtifactContentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(CreateArtifactRequest request, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(string parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(string parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(string parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(gagr::LocationName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(gagr::LocationName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(gagr::LocationName parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(ApiName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                ParentAsApiName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiName parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(ApiVersionName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiVersionName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                ParentAsApiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiVersionName parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(ApiSpecName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                ParentAsApiSpecName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiSpecName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                ParentAsApiSpecName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiSpecName parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact CreateArtifact(ApiDeploymentName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifact(new CreateArtifactRequest
            {
                ParentAsApiDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiDeploymentName parent, Artifact artifact, string artifactId, gaxgrpc::CallSettings callSettings = null) =>
            CreateArtifactAsync(new CreateArtifactRequest
            {
                ParentAsApiDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
                ArtifactId = gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)),
            }, callSettings);

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of artifacts.
        /// Format: `{parent}`
        /// </param>
        /// <param name="artifact">
        /// Required. The artifact to create.
        /// </param>
        /// <param name="artifactId">
        /// Required. The ID to use for the artifact, which will become the final component of
        /// the artifact's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// 
        /// Following AIP-162, IDs must not have the form of a UUID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> CreateArtifactAsync(ApiDeploymentName parent, Artifact artifact, string artifactId, st::CancellationToken cancellationToken) =>
            CreateArtifactAsync(parent, artifact, artifactId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact ReplaceArtifact(ReplaceArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> ReplaceArtifactAsync(ReplaceArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> ReplaceArtifactAsync(ReplaceArtifactRequest request, st::CancellationToken cancellationToken) =>
            ReplaceArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="artifact">
        /// Required. The artifact to replace.
        /// 
        /// The `name` field is used to identify the artifact to replace.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Artifact ReplaceArtifact(Artifact artifact, gaxgrpc::CallSettings callSettings = null) =>
            ReplaceArtifact(new ReplaceArtifactRequest
            {
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
            }, callSettings);

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="artifact">
        /// Required. The artifact to replace.
        /// 
        /// The `name` field is used to identify the artifact to replace.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> ReplaceArtifactAsync(Artifact artifact, gaxgrpc::CallSettings callSettings = null) =>
            ReplaceArtifactAsync(new ReplaceArtifactRequest
            {
                Artifact = gax::GaxPreconditions.CheckNotNull(artifact, nameof(artifact)),
            }, callSettings);

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="artifact">
        /// Required. The artifact to replace.
        /// 
        /// The `name` field is used to identify the artifact to replace.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Artifact> ReplaceArtifactAsync(Artifact artifact, st::CancellationToken cancellationToken) =>
            ReplaceArtifactAsync(artifact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteArtifact(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteArtifactAsync(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteArtifactAsync(DeleteArtifactRequest request, st::CancellationToken cancellationToken) =>
            DeleteArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to delete.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteArtifact(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifact(new DeleteArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to delete.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteArtifactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifactAsync(new DeleteArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to delete.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteArtifactAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to delete.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteArtifact(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifact(new DeleteArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to delete.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteArtifactAsync(ArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteArtifactAsync(new DeleteArtifactRequest
            {
                ArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the artifact to delete.
        /// Format: `{parent}/artifacts/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteArtifactAsync(ArtifactName name, st::CancellationToken cancellationToken) =>
            DeleteArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Registry client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Registry service allows teams to manage descriptions of APIs.
    /// </remarks>
    public sealed partial class RegistryClientImpl : RegistryClient
    {
        private readonly gaxgrpc::ApiCall<ListApisRequest, ListApisResponse> _callListApis;

        private readonly gaxgrpc::ApiCall<GetApiRequest, Api> _callGetApi;

        private readonly gaxgrpc::ApiCall<CreateApiRequest, Api> _callCreateApi;

        private readonly gaxgrpc::ApiCall<UpdateApiRequest, Api> _callUpdateApi;

        private readonly gaxgrpc::ApiCall<DeleteApiRequest, wkt::Empty> _callDeleteApi;

        private readonly gaxgrpc::ApiCall<ListApiVersionsRequest, ListApiVersionsResponse> _callListApiVersions;

        private readonly gaxgrpc::ApiCall<GetApiVersionRequest, ApiVersion> _callGetApiVersion;

        private readonly gaxgrpc::ApiCall<CreateApiVersionRequest, ApiVersion> _callCreateApiVersion;

        private readonly gaxgrpc::ApiCall<UpdateApiVersionRequest, ApiVersion> _callUpdateApiVersion;

        private readonly gaxgrpc::ApiCall<DeleteApiVersionRequest, wkt::Empty> _callDeleteApiVersion;

        private readonly gaxgrpc::ApiCall<ListApiSpecsRequest, ListApiSpecsResponse> _callListApiSpecs;

        private readonly gaxgrpc::ApiCall<GetApiSpecRequest, ApiSpec> _callGetApiSpec;

        private readonly gaxgrpc::ApiCall<GetApiSpecContentsRequest, ga::HttpBody> _callGetApiSpecContents;

        private readonly gaxgrpc::ApiCall<CreateApiSpecRequest, ApiSpec> _callCreateApiSpec;

        private readonly gaxgrpc::ApiCall<UpdateApiSpecRequest, ApiSpec> _callUpdateApiSpec;

        private readonly gaxgrpc::ApiCall<DeleteApiSpecRequest, wkt::Empty> _callDeleteApiSpec;

        private readonly gaxgrpc::ApiCall<TagApiSpecRevisionRequest, ApiSpec> _callTagApiSpecRevision;

        private readonly gaxgrpc::ApiCall<ListApiSpecRevisionsRequest, ListApiSpecRevisionsResponse> _callListApiSpecRevisions;

        private readonly gaxgrpc::ApiCall<RollbackApiSpecRequest, ApiSpec> _callRollbackApiSpec;

        private readonly gaxgrpc::ApiCall<DeleteApiSpecRevisionRequest, ApiSpec> _callDeleteApiSpecRevision;

        private readonly gaxgrpc::ApiCall<ListApiDeploymentsRequest, ListApiDeploymentsResponse> _callListApiDeployments;

        private readonly gaxgrpc::ApiCall<GetApiDeploymentRequest, ApiDeployment> _callGetApiDeployment;

        private readonly gaxgrpc::ApiCall<CreateApiDeploymentRequest, ApiDeployment> _callCreateApiDeployment;

        private readonly gaxgrpc::ApiCall<UpdateApiDeploymentRequest, ApiDeployment> _callUpdateApiDeployment;

        private readonly gaxgrpc::ApiCall<DeleteApiDeploymentRequest, wkt::Empty> _callDeleteApiDeployment;

        private readonly gaxgrpc::ApiCall<TagApiDeploymentRevisionRequest, ApiDeployment> _callTagApiDeploymentRevision;

        private readonly gaxgrpc::ApiCall<ListApiDeploymentRevisionsRequest, ListApiDeploymentRevisionsResponse> _callListApiDeploymentRevisions;

        private readonly gaxgrpc::ApiCall<RollbackApiDeploymentRequest, ApiDeployment> _callRollbackApiDeployment;

        private readonly gaxgrpc::ApiCall<DeleteApiDeploymentRevisionRequest, ApiDeployment> _callDeleteApiDeploymentRevision;

        private readonly gaxgrpc::ApiCall<ListArtifactsRequest, ListArtifactsResponse> _callListArtifacts;

        private readonly gaxgrpc::ApiCall<GetArtifactRequest, Artifact> _callGetArtifact;

        private readonly gaxgrpc::ApiCall<GetArtifactContentsRequest, ga::HttpBody> _callGetArtifactContents;

        private readonly gaxgrpc::ApiCall<CreateArtifactRequest, Artifact> _callCreateArtifact;

        private readonly gaxgrpc::ApiCall<ReplaceArtifactRequest, Artifact> _callReplaceArtifact;

        private readonly gaxgrpc::ApiCall<DeleteArtifactRequest, wkt::Empty> _callDeleteArtifact;

        /// <summary>
        /// Constructs a client wrapper for the Registry service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegistrySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegistryClientImpl(Registry.RegistryClient grpcClient, RegistrySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegistrySettings effectiveSettings = settings ?? RegistrySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListApis = clientHelper.BuildApiCall<ListApisRequest, ListApisResponse>("ListApis", grpcClient.ListApisAsync, grpcClient.ListApis, effectiveSettings.ListApisSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApis);
            Modify_ListApisApiCall(ref _callListApis);
            _callGetApi = clientHelper.BuildApiCall<GetApiRequest, Api>("GetApi", grpcClient.GetApiAsync, grpcClient.GetApi, effectiveSettings.GetApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApi);
            Modify_GetApiApiCall(ref _callGetApi);
            _callCreateApi = clientHelper.BuildApiCall<CreateApiRequest, Api>("CreateApi", grpcClient.CreateApiAsync, grpcClient.CreateApi, effectiveSettings.CreateApiSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApi);
            Modify_CreateApiApiCall(ref _callCreateApi);
            _callUpdateApi = clientHelper.BuildApiCall<UpdateApiRequest, Api>("UpdateApi", grpcClient.UpdateApiAsync, grpcClient.UpdateApi, effectiveSettings.UpdateApiSettings).WithGoogleRequestParam("api.name", request => request.Api?.Name);
            Modify_ApiCall(ref _callUpdateApi);
            Modify_UpdateApiApiCall(ref _callUpdateApi);
            _callDeleteApi = clientHelper.BuildApiCall<DeleteApiRequest, wkt::Empty>("DeleteApi", grpcClient.DeleteApiAsync, grpcClient.DeleteApi, effectiveSettings.DeleteApiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApi);
            Modify_DeleteApiApiCall(ref _callDeleteApi);
            _callListApiVersions = clientHelper.BuildApiCall<ListApiVersionsRequest, ListApiVersionsResponse>("ListApiVersions", grpcClient.ListApiVersionsAsync, grpcClient.ListApiVersions, effectiveSettings.ListApiVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApiVersions);
            Modify_ListApiVersionsApiCall(ref _callListApiVersions);
            _callGetApiVersion = clientHelper.BuildApiCall<GetApiVersionRequest, ApiVersion>("GetApiVersion", grpcClient.GetApiVersionAsync, grpcClient.GetApiVersion, effectiveSettings.GetApiVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApiVersion);
            Modify_GetApiVersionApiCall(ref _callGetApiVersion);
            _callCreateApiVersion = clientHelper.BuildApiCall<CreateApiVersionRequest, ApiVersion>("CreateApiVersion", grpcClient.CreateApiVersionAsync, grpcClient.CreateApiVersion, effectiveSettings.CreateApiVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApiVersion);
            Modify_CreateApiVersionApiCall(ref _callCreateApiVersion);
            _callUpdateApiVersion = clientHelper.BuildApiCall<UpdateApiVersionRequest, ApiVersion>("UpdateApiVersion", grpcClient.UpdateApiVersionAsync, grpcClient.UpdateApiVersion, effectiveSettings.UpdateApiVersionSettings).WithGoogleRequestParam("api_version.name", request => request.ApiVersion?.Name);
            Modify_ApiCall(ref _callUpdateApiVersion);
            Modify_UpdateApiVersionApiCall(ref _callUpdateApiVersion);
            _callDeleteApiVersion = clientHelper.BuildApiCall<DeleteApiVersionRequest, wkt::Empty>("DeleteApiVersion", grpcClient.DeleteApiVersionAsync, grpcClient.DeleteApiVersion, effectiveSettings.DeleteApiVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApiVersion);
            Modify_DeleteApiVersionApiCall(ref _callDeleteApiVersion);
            _callListApiSpecs = clientHelper.BuildApiCall<ListApiSpecsRequest, ListApiSpecsResponse>("ListApiSpecs", grpcClient.ListApiSpecsAsync, grpcClient.ListApiSpecs, effectiveSettings.ListApiSpecsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApiSpecs);
            Modify_ListApiSpecsApiCall(ref _callListApiSpecs);
            _callGetApiSpec = clientHelper.BuildApiCall<GetApiSpecRequest, ApiSpec>("GetApiSpec", grpcClient.GetApiSpecAsync, grpcClient.GetApiSpec, effectiveSettings.GetApiSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApiSpec);
            Modify_GetApiSpecApiCall(ref _callGetApiSpec);
            _callGetApiSpecContents = clientHelper.BuildApiCall<GetApiSpecContentsRequest, ga::HttpBody>("GetApiSpecContents", grpcClient.GetApiSpecContentsAsync, grpcClient.GetApiSpecContents, effectiveSettings.GetApiSpecContentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApiSpecContents);
            Modify_GetApiSpecContentsApiCall(ref _callGetApiSpecContents);
            _callCreateApiSpec = clientHelper.BuildApiCall<CreateApiSpecRequest, ApiSpec>("CreateApiSpec", grpcClient.CreateApiSpecAsync, grpcClient.CreateApiSpec, effectiveSettings.CreateApiSpecSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApiSpec);
            Modify_CreateApiSpecApiCall(ref _callCreateApiSpec);
            _callUpdateApiSpec = clientHelper.BuildApiCall<UpdateApiSpecRequest, ApiSpec>("UpdateApiSpec", grpcClient.UpdateApiSpecAsync, grpcClient.UpdateApiSpec, effectiveSettings.UpdateApiSpecSettings).WithGoogleRequestParam("api_spec.name", request => request.ApiSpec?.Name);
            Modify_ApiCall(ref _callUpdateApiSpec);
            Modify_UpdateApiSpecApiCall(ref _callUpdateApiSpec);
            _callDeleteApiSpec = clientHelper.BuildApiCall<DeleteApiSpecRequest, wkt::Empty>("DeleteApiSpec", grpcClient.DeleteApiSpecAsync, grpcClient.DeleteApiSpec, effectiveSettings.DeleteApiSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApiSpec);
            Modify_DeleteApiSpecApiCall(ref _callDeleteApiSpec);
            _callTagApiSpecRevision = clientHelper.BuildApiCall<TagApiSpecRevisionRequest, ApiSpec>("TagApiSpecRevision", grpcClient.TagApiSpecRevisionAsync, grpcClient.TagApiSpecRevision, effectiveSettings.TagApiSpecRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTagApiSpecRevision);
            Modify_TagApiSpecRevisionApiCall(ref _callTagApiSpecRevision);
            _callListApiSpecRevisions = clientHelper.BuildApiCall<ListApiSpecRevisionsRequest, ListApiSpecRevisionsResponse>("ListApiSpecRevisions", grpcClient.ListApiSpecRevisionsAsync, grpcClient.ListApiSpecRevisions, effectiveSettings.ListApiSpecRevisionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListApiSpecRevisions);
            Modify_ListApiSpecRevisionsApiCall(ref _callListApiSpecRevisions);
            _callRollbackApiSpec = clientHelper.BuildApiCall<RollbackApiSpecRequest, ApiSpec>("RollbackApiSpec", grpcClient.RollbackApiSpecAsync, grpcClient.RollbackApiSpec, effectiveSettings.RollbackApiSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRollbackApiSpec);
            Modify_RollbackApiSpecApiCall(ref _callRollbackApiSpec);
            _callDeleteApiSpecRevision = clientHelper.BuildApiCall<DeleteApiSpecRevisionRequest, ApiSpec>("DeleteApiSpecRevision", grpcClient.DeleteApiSpecRevisionAsync, grpcClient.DeleteApiSpecRevision, effectiveSettings.DeleteApiSpecRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApiSpecRevision);
            Modify_DeleteApiSpecRevisionApiCall(ref _callDeleteApiSpecRevision);
            _callListApiDeployments = clientHelper.BuildApiCall<ListApiDeploymentsRequest, ListApiDeploymentsResponse>("ListApiDeployments", grpcClient.ListApiDeploymentsAsync, grpcClient.ListApiDeployments, effectiveSettings.ListApiDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApiDeployments);
            Modify_ListApiDeploymentsApiCall(ref _callListApiDeployments);
            _callGetApiDeployment = clientHelper.BuildApiCall<GetApiDeploymentRequest, ApiDeployment>("GetApiDeployment", grpcClient.GetApiDeploymentAsync, grpcClient.GetApiDeployment, effectiveSettings.GetApiDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApiDeployment);
            Modify_GetApiDeploymentApiCall(ref _callGetApiDeployment);
            _callCreateApiDeployment = clientHelper.BuildApiCall<CreateApiDeploymentRequest, ApiDeployment>("CreateApiDeployment", grpcClient.CreateApiDeploymentAsync, grpcClient.CreateApiDeployment, effectiveSettings.CreateApiDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApiDeployment);
            Modify_CreateApiDeploymentApiCall(ref _callCreateApiDeployment);
            _callUpdateApiDeployment = clientHelper.BuildApiCall<UpdateApiDeploymentRequest, ApiDeployment>("UpdateApiDeployment", grpcClient.UpdateApiDeploymentAsync, grpcClient.UpdateApiDeployment, effectiveSettings.UpdateApiDeploymentSettings).WithGoogleRequestParam("api_deployment.name", request => request.ApiDeployment?.Name);
            Modify_ApiCall(ref _callUpdateApiDeployment);
            Modify_UpdateApiDeploymentApiCall(ref _callUpdateApiDeployment);
            _callDeleteApiDeployment = clientHelper.BuildApiCall<DeleteApiDeploymentRequest, wkt::Empty>("DeleteApiDeployment", grpcClient.DeleteApiDeploymentAsync, grpcClient.DeleteApiDeployment, effectiveSettings.DeleteApiDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApiDeployment);
            Modify_DeleteApiDeploymentApiCall(ref _callDeleteApiDeployment);
            _callTagApiDeploymentRevision = clientHelper.BuildApiCall<TagApiDeploymentRevisionRequest, ApiDeployment>("TagApiDeploymentRevision", grpcClient.TagApiDeploymentRevisionAsync, grpcClient.TagApiDeploymentRevision, effectiveSettings.TagApiDeploymentRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTagApiDeploymentRevision);
            Modify_TagApiDeploymentRevisionApiCall(ref _callTagApiDeploymentRevision);
            _callListApiDeploymentRevisions = clientHelper.BuildApiCall<ListApiDeploymentRevisionsRequest, ListApiDeploymentRevisionsResponse>("ListApiDeploymentRevisions", grpcClient.ListApiDeploymentRevisionsAsync, grpcClient.ListApiDeploymentRevisions, effectiveSettings.ListApiDeploymentRevisionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListApiDeploymentRevisions);
            Modify_ListApiDeploymentRevisionsApiCall(ref _callListApiDeploymentRevisions);
            _callRollbackApiDeployment = clientHelper.BuildApiCall<RollbackApiDeploymentRequest, ApiDeployment>("RollbackApiDeployment", grpcClient.RollbackApiDeploymentAsync, grpcClient.RollbackApiDeployment, effectiveSettings.RollbackApiDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRollbackApiDeployment);
            Modify_RollbackApiDeploymentApiCall(ref _callRollbackApiDeployment);
            _callDeleteApiDeploymentRevision = clientHelper.BuildApiCall<DeleteApiDeploymentRevisionRequest, ApiDeployment>("DeleteApiDeploymentRevision", grpcClient.DeleteApiDeploymentRevisionAsync, grpcClient.DeleteApiDeploymentRevision, effectiveSettings.DeleteApiDeploymentRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApiDeploymentRevision);
            Modify_DeleteApiDeploymentRevisionApiCall(ref _callDeleteApiDeploymentRevision);
            _callListArtifacts = clientHelper.BuildApiCall<ListArtifactsRequest, ListArtifactsResponse>("ListArtifacts", grpcClient.ListArtifactsAsync, grpcClient.ListArtifacts, effectiveSettings.ListArtifactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListArtifacts);
            Modify_ListArtifactsApiCall(ref _callListArtifacts);
            _callGetArtifact = clientHelper.BuildApiCall<GetArtifactRequest, Artifact>("GetArtifact", grpcClient.GetArtifactAsync, grpcClient.GetArtifact, effectiveSettings.GetArtifactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetArtifact);
            Modify_GetArtifactApiCall(ref _callGetArtifact);
            _callGetArtifactContents = clientHelper.BuildApiCall<GetArtifactContentsRequest, ga::HttpBody>("GetArtifactContents", grpcClient.GetArtifactContentsAsync, grpcClient.GetArtifactContents, effectiveSettings.GetArtifactContentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetArtifactContents);
            Modify_GetArtifactContentsApiCall(ref _callGetArtifactContents);
            _callCreateArtifact = clientHelper.BuildApiCall<CreateArtifactRequest, Artifact>("CreateArtifact", grpcClient.CreateArtifactAsync, grpcClient.CreateArtifact, effectiveSettings.CreateArtifactSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateArtifact);
            Modify_CreateArtifactApiCall(ref _callCreateArtifact);
            _callReplaceArtifact = clientHelper.BuildApiCall<ReplaceArtifactRequest, Artifact>("ReplaceArtifact", grpcClient.ReplaceArtifactAsync, grpcClient.ReplaceArtifact, effectiveSettings.ReplaceArtifactSettings).WithGoogleRequestParam("artifact.name", request => request.Artifact?.Name);
            Modify_ApiCall(ref _callReplaceArtifact);
            Modify_ReplaceArtifactApiCall(ref _callReplaceArtifact);
            _callDeleteArtifact = clientHelper.BuildApiCall<DeleteArtifactRequest, wkt::Empty>("DeleteArtifact", grpcClient.DeleteArtifactAsync, grpcClient.DeleteArtifact, effectiveSettings.DeleteArtifactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteArtifact);
            Modify_DeleteArtifactApiCall(ref _callDeleteArtifact);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListApisApiCall(ref gaxgrpc::ApiCall<ListApisRequest, ListApisResponse> call);

        partial void Modify_GetApiApiCall(ref gaxgrpc::ApiCall<GetApiRequest, Api> call);

        partial void Modify_CreateApiApiCall(ref gaxgrpc::ApiCall<CreateApiRequest, Api> call);

        partial void Modify_UpdateApiApiCall(ref gaxgrpc::ApiCall<UpdateApiRequest, Api> call);

        partial void Modify_DeleteApiApiCall(ref gaxgrpc::ApiCall<DeleteApiRequest, wkt::Empty> call);

        partial void Modify_ListApiVersionsApiCall(ref gaxgrpc::ApiCall<ListApiVersionsRequest, ListApiVersionsResponse> call);

        partial void Modify_GetApiVersionApiCall(ref gaxgrpc::ApiCall<GetApiVersionRequest, ApiVersion> call);

        partial void Modify_CreateApiVersionApiCall(ref gaxgrpc::ApiCall<CreateApiVersionRequest, ApiVersion> call);

        partial void Modify_UpdateApiVersionApiCall(ref gaxgrpc::ApiCall<UpdateApiVersionRequest, ApiVersion> call);

        partial void Modify_DeleteApiVersionApiCall(ref gaxgrpc::ApiCall<DeleteApiVersionRequest, wkt::Empty> call);

        partial void Modify_ListApiSpecsApiCall(ref gaxgrpc::ApiCall<ListApiSpecsRequest, ListApiSpecsResponse> call);

        partial void Modify_GetApiSpecApiCall(ref gaxgrpc::ApiCall<GetApiSpecRequest, ApiSpec> call);

        partial void Modify_GetApiSpecContentsApiCall(ref gaxgrpc::ApiCall<GetApiSpecContentsRequest, ga::HttpBody> call);

        partial void Modify_CreateApiSpecApiCall(ref gaxgrpc::ApiCall<CreateApiSpecRequest, ApiSpec> call);

        partial void Modify_UpdateApiSpecApiCall(ref gaxgrpc::ApiCall<UpdateApiSpecRequest, ApiSpec> call);

        partial void Modify_DeleteApiSpecApiCall(ref gaxgrpc::ApiCall<DeleteApiSpecRequest, wkt::Empty> call);

        partial void Modify_TagApiSpecRevisionApiCall(ref gaxgrpc::ApiCall<TagApiSpecRevisionRequest, ApiSpec> call);

        partial void Modify_ListApiSpecRevisionsApiCall(ref gaxgrpc::ApiCall<ListApiSpecRevisionsRequest, ListApiSpecRevisionsResponse> call);

        partial void Modify_RollbackApiSpecApiCall(ref gaxgrpc::ApiCall<RollbackApiSpecRequest, ApiSpec> call);

        partial void Modify_DeleteApiSpecRevisionApiCall(ref gaxgrpc::ApiCall<DeleteApiSpecRevisionRequest, ApiSpec> call);

        partial void Modify_ListApiDeploymentsApiCall(ref gaxgrpc::ApiCall<ListApiDeploymentsRequest, ListApiDeploymentsResponse> call);

        partial void Modify_GetApiDeploymentApiCall(ref gaxgrpc::ApiCall<GetApiDeploymentRequest, ApiDeployment> call);

        partial void Modify_CreateApiDeploymentApiCall(ref gaxgrpc::ApiCall<CreateApiDeploymentRequest, ApiDeployment> call);

        partial void Modify_UpdateApiDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateApiDeploymentRequest, ApiDeployment> call);

        partial void Modify_DeleteApiDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteApiDeploymentRequest, wkt::Empty> call);

        partial void Modify_TagApiDeploymentRevisionApiCall(ref gaxgrpc::ApiCall<TagApiDeploymentRevisionRequest, ApiDeployment> call);

        partial void Modify_ListApiDeploymentRevisionsApiCall(ref gaxgrpc::ApiCall<ListApiDeploymentRevisionsRequest, ListApiDeploymentRevisionsResponse> call);

        partial void Modify_RollbackApiDeploymentApiCall(ref gaxgrpc::ApiCall<RollbackApiDeploymentRequest, ApiDeployment> call);

        partial void Modify_DeleteApiDeploymentRevisionApiCall(ref gaxgrpc::ApiCall<DeleteApiDeploymentRevisionRequest, ApiDeployment> call);

        partial void Modify_ListArtifactsApiCall(ref gaxgrpc::ApiCall<ListArtifactsRequest, ListArtifactsResponse> call);

        partial void Modify_GetArtifactApiCall(ref gaxgrpc::ApiCall<GetArtifactRequest, Artifact> call);

        partial void Modify_GetArtifactContentsApiCall(ref gaxgrpc::ApiCall<GetArtifactContentsRequest, ga::HttpBody> call);

        partial void Modify_CreateArtifactApiCall(ref gaxgrpc::ApiCall<CreateArtifactRequest, Artifact> call);

        partial void Modify_ReplaceArtifactApiCall(ref gaxgrpc::ApiCall<ReplaceArtifactRequest, Artifact> call);

        partial void Modify_DeleteArtifactApiCall(ref gaxgrpc::ApiCall<DeleteArtifactRequest, wkt::Empty> call);

        partial void OnConstruction(Registry.RegistryClient grpcClient, RegistrySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Registry client</summary>
        public override Registry.RegistryClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListApisRequest(ref ListApisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiRequest(ref GetApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApiRequest(ref CreateApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApiRequest(ref UpdateApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiRequest(ref DeleteApiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApiVersionsRequest(ref ListApiVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiVersionRequest(ref GetApiVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApiVersionRequest(ref CreateApiVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApiVersionRequest(ref UpdateApiVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiVersionRequest(ref DeleteApiVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApiSpecsRequest(ref ListApiSpecsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiSpecRequest(ref GetApiSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiSpecContentsRequest(ref GetApiSpecContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApiSpecRequest(ref CreateApiSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApiSpecRequest(ref UpdateApiSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiSpecRequest(ref DeleteApiSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TagApiSpecRevisionRequest(ref TagApiSpecRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApiSpecRevisionsRequest(ref ListApiSpecRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackApiSpecRequest(ref RollbackApiSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiSpecRevisionRequest(ref DeleteApiSpecRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApiDeploymentsRequest(ref ListApiDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiDeploymentRequest(ref GetApiDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApiDeploymentRequest(ref CreateApiDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApiDeploymentRequest(ref UpdateApiDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiDeploymentRequest(ref DeleteApiDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TagApiDeploymentRevisionRequest(ref TagApiDeploymentRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApiDeploymentRevisionsRequest(ref ListApiDeploymentRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackApiDeploymentRequest(ref RollbackApiDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApiDeploymentRevisionRequest(ref DeleteApiDeploymentRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListArtifactsRequest(ref ListArtifactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetArtifactRequest(ref GetArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetArtifactContentsRequest(ref GetArtifactContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateArtifactRequest(ref CreateArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReplaceArtifactRequest(ref ReplaceArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteArtifactRequest(ref DeleteArtifactRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns matching APIs.
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
        /// Returns matching APIs.
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
        /// Returns a specified API.
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
        /// Returns a specified API.
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
        /// Creates a specified API.
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
        /// Creates a specified API.
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
        /// Used to modify a specified API.
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
        /// Used to modify a specified API.
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
        /// Removes a specified API and all of the resources that it
        /// owns.
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
        /// Removes a specified API and all of the resources that it
        /// owns.
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
        /// Returns matching versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersions(ListApiVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApiVersionsRequest, ListApiVersionsResponse, ApiVersion>(_callListApiVersions, request, callSettings);
        }

        /// <summary>
        /// Returns matching versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApiVersionsResponse, ApiVersion> ListApiVersionsAsync(ListApiVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApiVersionsRequest, ListApiVersionsResponse, ApiVersion>(_callListApiVersions, request, callSettings);
        }

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiVersion GetApiVersion(GetApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiVersionRequest(ref request, ref callSettings);
            return _callGetApiVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiVersion> GetApiVersionAsync(GetApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiVersionRequest(ref request, ref callSettings);
            return _callGetApiVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiVersion CreateApiVersion(CreateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiVersionRequest(ref request, ref callSettings);
            return _callCreateApiVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiVersion> CreateApiVersionAsync(CreateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiVersionRequest(ref request, ref callSettings);
            return _callCreateApiVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiVersion UpdateApiVersion(UpdateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiVersionRequest(ref request, ref callSettings);
            return _callUpdateApiVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Used to modify a specified version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiVersion> UpdateApiVersionAsync(UpdateApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiVersionRequest(ref request, ref callSettings);
            return _callUpdateApiVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteApiVersion(DeleteApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiVersionRequest(ref request, ref callSettings);
            _callDeleteApiVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a specified version and all of the resources that
        /// it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteApiVersionAsync(DeleteApiVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiVersionRequest(ref request, ref callSettings);
            return _callDeleteApiVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiSpec"/> resources.</returns>
        public override gax::PagedEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecs(ListApiSpecsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiSpecsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApiSpecsRequest, ListApiSpecsResponse, ApiSpec>(_callListApiSpecs, request, callSettings);
        }

        /// <summary>
        /// Returns matching specs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiSpec"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApiSpecsResponse, ApiSpec> ListApiSpecsAsync(ListApiSpecsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiSpecsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApiSpecsRequest, ListApiSpecsResponse, ApiSpec>(_callListApiSpecs, request, callSettings);
        }

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiSpec GetApiSpec(GetApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiSpecRequest(ref request, ref callSettings);
            return _callGetApiSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiSpec> GetApiSpecAsync(GetApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiSpecRequest(ref request, ref callSettings);
            return _callGetApiSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody GetApiSpecContents(GetApiSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiSpecContentsRequest(ref request, ref callSettings);
            return _callGetApiSpecContents.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a specified spec.
        /// If specs are stored with GZip compression, the default behavior
        /// is to return the spec uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> GetApiSpecContentsAsync(GetApiSpecContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiSpecContentsRequest(ref request, ref callSettings);
            return _callGetApiSpecContents.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiSpec CreateApiSpec(CreateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiSpecRequest(ref request, ref callSettings);
            return _callCreateApiSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiSpec> CreateApiSpecAsync(CreateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiSpecRequest(ref request, ref callSettings);
            return _callCreateApiSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiSpec UpdateApiSpec(UpdateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiSpecRequest(ref request, ref callSettings);
            return _callUpdateApiSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Used to modify a specified spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiSpec> UpdateApiSpecAsync(UpdateApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiSpecRequest(ref request, ref callSettings);
            return _callUpdateApiSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteApiSpec(DeleteApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiSpecRequest(ref request, ref callSettings);
            _callDeleteApiSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a specified spec, all revisions, and all child
        /// resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteApiSpecAsync(DeleteApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiSpecRequest(ref request, ref callSettings);
            return _callDeleteApiSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Adds a tag to a specified revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiSpec TagApiSpecRevision(TagApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TagApiSpecRevisionRequest(ref request, ref callSettings);
            return _callTagApiSpecRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a tag to a specified revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiSpec> TagApiSpecRevisionAsync(TagApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TagApiSpecRevisionRequest(ref request, ref callSettings);
            return _callTagApiSpecRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of a spec.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiSpec"/> resources.</returns>
        public override gax::PagedEnumerable<ListApiSpecRevisionsResponse, ApiSpec> ListApiSpecRevisions(ListApiSpecRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiSpecRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApiSpecRevisionsRequest, ListApiSpecRevisionsResponse, ApiSpec>(_callListApiSpecRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of a spec.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiSpec"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApiSpecRevisionsResponse, ApiSpec> ListApiSpecRevisionsAsync(ListApiSpecRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiSpecRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApiSpecRevisionsRequest, ListApiSpecRevisionsResponse, ApiSpec>(_callListApiSpecRevisions, request, callSettings);
        }

        /// <summary>
        /// Sets the current revision to a specified prior revision.
        /// Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiSpec RollbackApiSpec(RollbackApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackApiSpecRequest(ref request, ref callSettings);
            return _callRollbackApiSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the current revision to a specified prior revision.
        /// Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiSpec> RollbackApiSpecAsync(RollbackApiSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackApiSpecRequest(ref request, ref callSettings);
            return _callRollbackApiSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiSpec DeleteApiSpecRevision(DeleteApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiSpecRevisionRequest(ref request, ref callSettings);
            return _callDeleteApiSpecRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a revision of a spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiSpec> DeleteApiSpecRevisionAsync(DeleteApiSpecRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiSpecRevisionRequest(ref request, ref callSettings);
            return _callDeleteApiSpecRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeployments(ListApiDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApiDeploymentsRequest, ListApiDeploymentsResponse, ApiDeployment>(_callListApiDeployments, request, callSettings);
        }

        /// <summary>
        /// Returns matching deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApiDeploymentsResponse, ApiDeployment> ListApiDeploymentsAsync(ListApiDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApiDeploymentsRequest, ListApiDeploymentsResponse, ApiDeployment>(_callListApiDeployments, request, callSettings);
        }

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiDeployment GetApiDeployment(GetApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiDeploymentRequest(ref request, ref callSettings);
            return _callGetApiDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiDeployment> GetApiDeploymentAsync(GetApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiDeploymentRequest(ref request, ref callSettings);
            return _callGetApiDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiDeployment CreateApiDeployment(CreateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiDeploymentRequest(ref request, ref callSettings);
            return _callCreateApiDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiDeployment> CreateApiDeploymentAsync(CreateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiDeploymentRequest(ref request, ref callSettings);
            return _callCreateApiDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiDeployment UpdateApiDeployment(UpdateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiDeploymentRequest(ref request, ref callSettings);
            return _callUpdateApiDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Used to modify a specified deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiDeployment> UpdateApiDeploymentAsync(UpdateApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApiDeploymentRequest(ref request, ref callSettings);
            return _callUpdateApiDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteApiDeployment(DeleteApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiDeploymentRequest(ref request, ref callSettings);
            _callDeleteApiDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a specified deployment, all revisions, and all
        /// child resources (e.g., artifacts).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteApiDeploymentAsync(DeleteApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiDeploymentRequest(ref request, ref callSettings);
            return _callDeleteApiDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Adds a tag to a specified revision of a
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiDeployment TagApiDeploymentRevision(TagApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TagApiDeploymentRevisionRequest(ref request, ref callSettings);
            return _callTagApiDeploymentRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a tag to a specified revision of a
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiDeployment> TagApiDeploymentRevisionAsync(TagApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TagApiDeploymentRevisionRequest(ref request, ref callSettings);
            return _callTagApiDeploymentRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of a deployment.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListApiDeploymentRevisionsResponse, ApiDeployment> ListApiDeploymentRevisions(ListApiDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiDeploymentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApiDeploymentRevisionsRequest, ListApiDeploymentRevisionsResponse, ApiDeployment>(_callListApiDeploymentRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of a deployment.
        /// Revisions are returned in descending order of revision creation time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApiDeploymentRevisionsResponse, ApiDeployment> ListApiDeploymentRevisionsAsync(ListApiDeploymentRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApiDeploymentRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApiDeploymentRevisionsRequest, ListApiDeploymentRevisionsResponse, ApiDeployment>(_callListApiDeploymentRevisions, request, callSettings);
        }

        /// <summary>
        /// Sets the current revision to a specified prior
        /// revision. Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiDeployment RollbackApiDeployment(RollbackApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackApiDeploymentRequest(ref request, ref callSettings);
            return _callRollbackApiDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the current revision to a specified prior
        /// revision. Note that this creates a new revision with a new revision ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiDeployment> RollbackApiDeploymentAsync(RollbackApiDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackApiDeploymentRequest(ref request, ref callSettings);
            return _callRollbackApiDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiDeployment DeleteApiDeploymentRevision(DeleteApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiDeploymentRevisionRequest(ref request, ref callSettings);
            return _callDeleteApiDeploymentRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a revision of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiDeployment> DeleteApiDeploymentRevisionAsync(DeleteApiDeploymentRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApiDeploymentRevisionRequest(ref request, ref callSettings);
            return _callDeleteApiDeploymentRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Artifact"/> resources.</returns>
        public override gax::PagedEnumerable<ListArtifactsResponse, Artifact> ListArtifacts(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListArtifactsRequest, ListArtifactsResponse, Artifact>(_callListArtifacts, request, callSettings);
        }

        /// <summary>
        /// Returns matching artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Artifact"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListArtifactsResponse, Artifact> ListArtifactsAsync(ListArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListArtifactsRequest, ListArtifactsResponse, Artifact>(_callListArtifacts, request, callSettings);
        }

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Artifact GetArtifact(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetArtifactRequest(ref request, ref callSettings);
            return _callGetArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Artifact> GetArtifactAsync(GetArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetArtifactRequest(ref request, ref callSettings);
            return _callGetArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody GetArtifactContents(GetArtifactContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetArtifactContentsRequest(ref request, ref callSettings);
            return _callGetArtifactContents.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a specified artifact.
        /// If artifacts are stored with GZip compression, the default behavior
        /// is to return the artifact uncompressed (the mime_type response field
        /// indicates the exact format returned).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> GetArtifactContentsAsync(GetArtifactContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetArtifactContentsRequest(ref request, ref callSettings);
            return _callGetArtifactContents.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Artifact CreateArtifact(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateArtifactRequest(ref request, ref callSettings);
            return _callCreateArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Artifact> CreateArtifactAsync(CreateArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateArtifactRequest(ref request, ref callSettings);
            return _callCreateArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Artifact ReplaceArtifact(ReplaceArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceArtifactRequest(ref request, ref callSettings);
            return _callReplaceArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Used to replace a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Artifact> ReplaceArtifactAsync(ReplaceArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceArtifactRequest(ref request, ref callSettings);
            return _callReplaceArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteArtifact(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteArtifactRequest(ref request, ref callSettings);
            _callDeleteArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a specified artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteArtifactAsync(DeleteArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteArtifactRequest(ref request, ref callSettings);
            return _callDeleteArtifact.Async(request, callSettings);
        }
    }

    public partial class ListApisRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApiVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApiSpecsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApiSpecRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApiDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApiDeploymentRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListArtifactsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApisResponse : gaxgrpc::IPageResponse<Api>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Api> GetEnumerator() => Apis.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApiVersionsResponse : gaxgrpc::IPageResponse<ApiVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiVersion> GetEnumerator() => ApiVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApiSpecsResponse : gaxgrpc::IPageResponse<ApiSpec>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiSpec> GetEnumerator() => ApiSpecs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApiSpecRevisionsResponse : gaxgrpc::IPageResponse<ApiSpec>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiSpec> GetEnumerator() => ApiSpecs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApiDeploymentsResponse : gaxgrpc::IPageResponse<ApiDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiDeployment> GetEnumerator() => ApiDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApiDeploymentRevisionsResponse : gaxgrpc::IPageResponse<ApiDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiDeployment> GetEnumerator() => ApiDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListArtifactsResponse : gaxgrpc::IPageResponse<Artifact>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Artifact> GetEnumerator() => Artifacts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Registry
    {
        public partial class RegistryClient
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
