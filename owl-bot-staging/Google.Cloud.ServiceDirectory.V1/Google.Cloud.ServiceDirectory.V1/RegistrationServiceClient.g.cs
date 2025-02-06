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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.ServiceDirectory.V1
{
    /// <summary>Settings for <see cref="RegistrationServiceClient"/> instances.</summary>
    public sealed partial class RegistrationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegistrationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegistrationServiceSettings"/>.</returns>
        public static RegistrationServiceSettings GetDefault() => new RegistrationServiceSettings();

        /// <summary>Constructs a new <see cref="RegistrationServiceSettings"/> object with default settings.</summary>
        public RegistrationServiceSettings()
        {
        }

        private RegistrationServiceSettings(RegistrationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateNamespaceSettings = existing.CreateNamespaceSettings;
            ListNamespacesSettings = existing.ListNamespacesSettings;
            GetNamespaceSettings = existing.GetNamespaceSettings;
            UpdateNamespaceSettings = existing.UpdateNamespaceSettings;
            DeleteNamespaceSettings = existing.DeleteNamespaceSettings;
            CreateServiceSettings = existing.CreateServiceSettings;
            ListServicesSettings = existing.ListServicesSettings;
            GetServiceSettings = existing.GetServiceSettings;
            UpdateServiceSettings = existing.UpdateServiceSettings;
            DeleteServiceSettings = existing.DeleteServiceSettings;
            CreateEndpointSettings = existing.CreateEndpointSettings;
            ListEndpointsSettings = existing.ListEndpointsSettings;
            GetEndpointSettings = existing.GetEndpointSettings;
            UpdateEndpointSettings = existing.UpdateEndpointSettings;
            DeleteEndpointSettings = existing.DeleteEndpointSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegistrationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.CreateNamespace</c> and <c>RegistrationServiceClient.CreateNamespaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.ListNamespaces</c> and <c>RegistrationServiceClient.ListNamespacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNamespacesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.GetNamespace</c> and <c>RegistrationServiceClient.GetNamespaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.UpdateNamespace</c> and <c>RegistrationServiceClient.UpdateNamespaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.DeleteNamespace</c> and <c>RegistrationServiceClient.DeleteNamespaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNamespaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.CreateService</c> and <c>RegistrationServiceClient.CreateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.ListServices</c> and <c>RegistrationServiceClient.ListServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.GetService</c> and <c>RegistrationServiceClient.GetServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.UpdateService</c> and <c>RegistrationServiceClient.UpdateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.DeleteService</c> and <c>RegistrationServiceClient.DeleteServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.CreateEndpoint</c> and <c>RegistrationServiceClient.CreateEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.ListEndpoints</c> and <c>RegistrationServiceClient.ListEndpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEndpointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.GetEndpoint</c> and <c>RegistrationServiceClient.GetEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.UpdateEndpoint</c> and <c>RegistrationServiceClient.UpdateEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.DeleteEndpoint</c> and <c>RegistrationServiceClient.DeleteEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.GetIamPolicy</c> and <c>RegistrationServiceClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.SetIamPolicy</c> and <c>RegistrationServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegistrationServiceClient.TestIamPermissions</c> and <c>RegistrationServiceClient.TestIamPermissionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegistrationServiceSettings"/> object.</returns>
        public RegistrationServiceSettings Clone() => new RegistrationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegistrationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RegistrationServiceClientBuilder : gaxgrpc::ClientBuilderBase<RegistrationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegistrationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegistrationServiceClientBuilder() : base(RegistrationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegistrationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegistrationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegistrationServiceClient Build()
        {
            RegistrationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegistrationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegistrationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegistrationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegistrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegistrationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegistrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegistrationServiceClient.ChannelPool;
    }

    /// <summary>RegistrationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service Directory API for registering services. It defines the following
    /// resource model:
    /// 
    /// - The API has a collection of
    /// [Namespace][google.cloud.servicedirectory.v1.Namespace]
    /// resources, named `projects/*/locations/*/namespaces/*`.
    /// 
    /// - Each Namespace has a collection of
    /// [Service][google.cloud.servicedirectory.v1.Service] resources, named
    /// `projects/*/locations/*/namespaces/*/services/*`.
    /// 
    /// - Each Service has a collection of
    /// [Endpoint][google.cloud.servicedirectory.v1.Endpoint]
    /// resources, named
    /// `projects/*/locations/*/namespaces/*/services/*/endpoints/*`.
    /// </remarks>
    public abstract partial class RegistrationServiceClient
    {
        /// <summary>
        /// The default endpoint for the RegistrationService service, which is a host of
        /// "servicedirectory.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "servicedirectory.googleapis.com:443";

        /// <summary>The default RegistrationService scopes.</summary>
        /// <remarks>
        /// The default RegistrationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegistrationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegistrationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="RegistrationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegistrationServiceClient"/>.</returns>
        public static stt::Task<RegistrationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegistrationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegistrationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="RegistrationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegistrationServiceClient"/>.</returns>
        public static RegistrationServiceClient Create() => new RegistrationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegistrationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegistrationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegistrationServiceClient"/>.</returns>
        internal static RegistrationServiceClient Create(grpccore::CallInvoker callInvoker, RegistrationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegistrationService.RegistrationServiceClient grpcClient = new RegistrationService.RegistrationServiceClient(callInvoker);
            return new RegistrationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegistrationService client</summary>
        public virtual RegistrationService.RegistrationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace CreateNamespace(CreateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> CreateNamespaceAsync(CreateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> CreateNamespaceAsync(CreateNamespaceRequest request, st::CancellationToken cancellationToken) =>
            CreateNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location the namespace
        /// will be created in.
        /// </param>
        /// <param name="namespace">
        /// Required. A namespace with initial fields set.
        /// </param>
        /// <param name="namespaceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace CreateNamespace(string parent, Namespace @namespace, string namespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNamespace(new CreateNamespaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)),
                Namespace = gax::GaxPreconditions.CheckNotNull(@namespace, nameof(@namespace)),
            }, callSettings);

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location the namespace
        /// will be created in.
        /// </param>
        /// <param name="namespace">
        /// Required. A namespace with initial fields set.
        /// </param>
        /// <param name="namespaceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> CreateNamespaceAsync(string parent, Namespace @namespace, string namespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNamespaceAsync(new CreateNamespaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)),
                Namespace = gax::GaxPreconditions.CheckNotNull(@namespace, nameof(@namespace)),
            }, callSettings);

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location the namespace
        /// will be created in.
        /// </param>
        /// <param name="namespace">
        /// Required. A namespace with initial fields set.
        /// </param>
        /// <param name="namespaceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> CreateNamespaceAsync(string parent, Namespace @namespace, string namespaceId, st::CancellationToken cancellationToken) =>
            CreateNamespaceAsync(parent, @namespace, namespaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location the namespace
        /// will be created in.
        /// </param>
        /// <param name="namespace">
        /// Required. A namespace with initial fields set.
        /// </param>
        /// <param name="namespaceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace CreateNamespace(gagr::LocationName parent, Namespace @namespace, string namespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNamespace(new CreateNamespaceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)),
                Namespace = gax::GaxPreconditions.CheckNotNull(@namespace, nameof(@namespace)),
            }, callSettings);

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location the namespace
        /// will be created in.
        /// </param>
        /// <param name="namespace">
        /// Required. A namespace with initial fields set.
        /// </param>
        /// <param name="namespaceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> CreateNamespaceAsync(gagr::LocationName parent, Namespace @namespace, string namespaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNamespaceAsync(new CreateNamespaceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NamespaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)),
                Namespace = gax::GaxPreconditions.CheckNotNull(@namespace, nameof(@namespace)),
            }, callSettings);

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location the namespace
        /// will be created in.
        /// </param>
        /// <param name="namespace">
        /// Required. A namespace with initial fields set.
        /// </param>
        /// <param name="namespaceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> CreateNamespaceAsync(gagr::LocationName parent, Namespace @namespace, string namespaceId, st::CancellationToken cancellationToken) =>
            CreateNamespaceAsync(parent, @namespace, namespaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNamespacesResponse, Namespace> ListNamespaces(ListNamespacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNamespacesResponse, Namespace> ListNamespacesAsync(ListNamespacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location whose namespaces
        /// you'd like to list.
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
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNamespacesResponse, Namespace> ListNamespaces(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNamespacesRequest request = new ListNamespacesRequest
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
            return ListNamespaces(request, callSettings);
        }

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location whose namespaces
        /// you'd like to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNamespacesResponse, Namespace> ListNamespacesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNamespacesRequest request = new ListNamespacesRequest
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
            return ListNamespacesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location whose namespaces
        /// you'd like to list.
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
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNamespacesResponse, Namespace> ListNamespaces(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNamespacesRequest request = new ListNamespacesRequest
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
            return ListNamespaces(request, callSettings);
        }

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project and location whose namespaces
        /// you'd like to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNamespacesResponse, Namespace> ListNamespacesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNamespacesRequest request = new ListNamespacesRequest
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
            return ListNamespacesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace GetNamespace(GetNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetNamespaceAsync(GetNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetNamespaceAsync(GetNamespaceRequest request, st::CancellationToken cancellationToken) =>
            GetNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace GetNamespace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespace(new GetNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetNamespaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespaceAsync(new GetNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetNamespaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace GetNamespace(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespace(new GetNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetNamespaceAsync(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespaceAsync(new GetNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> GetNamespaceAsync(NamespaceName name, st::CancellationToken cancellationToken) =>
            GetNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace UpdateNamespace(UpdateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> UpdateNamespaceAsync(UpdateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> UpdateNamespaceAsync(UpdateNamespaceRequest request, st::CancellationToken cancellationToken) =>
            UpdateNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="namespace">
        /// Required. The updated namespace.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Namespace UpdateNamespace(Namespace @namespace, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNamespace(new UpdateNamespaceRequest
            {
                Namespace = gax::GaxPreconditions.CheckNotNull(@namespace, nameof(@namespace)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="namespace">
        /// Required. The updated namespace.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> UpdateNamespaceAsync(Namespace @namespace, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNamespaceAsync(new UpdateNamespaceRequest
            {
                Namespace = gax::GaxPreconditions.CheckNotNull(@namespace, nameof(@namespace)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="namespace">
        /// Required. The updated namespace.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Namespace> UpdateNamespaceAsync(Namespace @namespace, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNamespaceAsync(@namespace, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNamespace(DeleteNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNamespaceAsync(DeleteNamespaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNamespaceAsync(DeleteNamespaceRequest request, st::CancellationToken cancellationToken) =>
            DeleteNamespaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNamespace(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNamespace(new DeleteNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNamespaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNamespaceAsync(new DeleteNamespaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNamespaceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNamespace(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNamespace(new DeleteNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNamespaceAsync(NamespaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNamespaceAsync(new DeleteNamespaceRequest
            {
                NamespaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the namespace to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNamespaceAsync(NamespaceName name, st::CancellationToken cancellationToken) =>
            DeleteNamespaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(CreateServiceRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace this service will belong to.
        /// </param>
        /// <param name="service">
        /// Required. A service  with initial fields set.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace this service will belong to.
        /// </param>
        /// <param name="service">
        /// Required. A service  with initial fields set.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace this service will belong to.
        /// </param>
        /// <param name="service">
        /// Required. A service  with initial fields set.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(string parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace this service will belong to.
        /// </param>
        /// <param name="service">
        /// Required. A service  with initial fields set.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(NamespaceName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsNamespaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace this service will belong to.
        /// </param>
        /// <param name="service">
        /// Required. A service  with initial fields set.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(NamespaceName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsNamespaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace this service will belong to.
        /// </param>
        /// <param name="service">
        /// Required. A service  with initial fields set.
        /// </param>
        /// <param name="serviceId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(NamespaceName parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all services belonging to a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all services belonging to a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all services belonging to a namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace whose services you'd
        /// like to list.
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
        /// Lists all services belonging to a namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace whose services you'd
        /// like to list.
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
        /// Lists all services belonging to a namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace whose services you'd
        /// like to list.
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
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(NamespaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsNamespaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists all services belonging to a namespace.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the namespace whose services you'd
        /// like to list.
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
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(NamespaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsNamespaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(UpdateServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="service">
        /// Required. The updated service.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service UpdateService(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateService(new UpdateServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="service">
        /// Required. The updated service.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceAsync(new UpdateServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="service">
        /// Required. The updated service.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(service, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(DeleteServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteService(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint CreateEndpoint(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> CreateEndpointAsync(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> CreateEndpointAsync(CreateEndpointRequest request, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service that this endpoint provides.
        /// </param>
        /// <param name="endpoint">
        /// Required. A endpoint with initial fields set.
        /// </param>
        /// <param name="endpointId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint CreateEndpoint(string parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service that this endpoint provides.
        /// </param>
        /// <param name="endpoint">
        /// Required. A endpoint with initial fields set.
        /// </param>
        /// <param name="endpointId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> CreateEndpointAsync(string parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service that this endpoint provides.
        /// </param>
        /// <param name="endpoint">
        /// Required. A endpoint with initial fields set.
        /// </param>
        /// <param name="endpointId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> CreateEndpointAsync(string parent, Endpoint endpoint, string endpointId, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, endpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service that this endpoint provides.
        /// </param>
        /// <param name="endpoint">
        /// Required. A endpoint with initial fields set.
        /// </param>
        /// <param name="endpointId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint CreateEndpoint(ServiceName parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service that this endpoint provides.
        /// </param>
        /// <param name="endpoint">
        /// Required. A endpoint with initial fields set.
        /// </param>
        /// <param name="endpointId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> CreateEndpointAsync(ServiceName parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service that this endpoint provides.
        /// </param>
        /// <param name="endpoint">
        /// Required. A endpoint with initial fields set.
        /// </param>
        /// <param name="endpointId">
        /// Required. The Resource ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, the name must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?` which means the first
        /// character must be a lowercase letter, and all following characters must
        /// be a dash, lowercase letter, or digit, except the last character, which
        /// cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> CreateEndpointAsync(ServiceName parent, Endpoint endpoint, string endpointId, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, endpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service whose endpoints you'd like to
        /// list.
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service whose endpoints you'd like to
        /// list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service whose endpoints you'd like to
        /// list.
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the service whose endpoints you'd like to
        /// list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint UpdateEndpoint(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(UpdateEndpointRequest request, st::CancellationToken cancellationToken) =>
            UpdateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The updated endpoint.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint UpdateEndpoint(Endpoint endpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpoint(new UpdateEndpointRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The updated endpoint.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(Endpoint endpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointAsync(new UpdateEndpointRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The updated endpoint.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(Endpoint endpoint, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEndpointAsync(endpoint, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEndpoint(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEndpointAsync(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEndpointAsync(DeleteEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpoint(new DeleteEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointAsync(new DeleteEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpoint(new DeleteEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointAsync(new DeleteEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests IAM permissions for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests IAM permissions for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests IAM permissions for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegistrationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service Directory API for registering services. It defines the following
    /// resource model:
    /// 
    /// - The API has a collection of
    /// [Namespace][google.cloud.servicedirectory.v1.Namespace]
    /// resources, named `projects/*/locations/*/namespaces/*`.
    /// 
    /// - Each Namespace has a collection of
    /// [Service][google.cloud.servicedirectory.v1.Service] resources, named
    /// `projects/*/locations/*/namespaces/*/services/*`.
    /// 
    /// - Each Service has a collection of
    /// [Endpoint][google.cloud.servicedirectory.v1.Endpoint]
    /// resources, named
    /// `projects/*/locations/*/namespaces/*/services/*/endpoints/*`.
    /// </remarks>
    public sealed partial class RegistrationServiceClientImpl : RegistrationServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateNamespaceRequest, Namespace> _callCreateNamespace;

        private readonly gaxgrpc::ApiCall<ListNamespacesRequest, ListNamespacesResponse> _callListNamespaces;

        private readonly gaxgrpc::ApiCall<GetNamespaceRequest, Namespace> _callGetNamespace;

        private readonly gaxgrpc::ApiCall<UpdateNamespaceRequest, Namespace> _callUpdateNamespace;

        private readonly gaxgrpc::ApiCall<DeleteNamespaceRequest, wkt::Empty> _callDeleteNamespace;

        private readonly gaxgrpc::ApiCall<CreateServiceRequest, Service> _callCreateService;

        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<UpdateServiceRequest, Service> _callUpdateService;

        private readonly gaxgrpc::ApiCall<DeleteServiceRequest, wkt::Empty> _callDeleteService;

        private readonly gaxgrpc::ApiCall<CreateEndpointRequest, Endpoint> _callCreateEndpoint;

        private readonly gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> _callListEndpoints;

        private readonly gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> _callGetEndpoint;

        private readonly gaxgrpc::ApiCall<UpdateEndpointRequest, Endpoint> _callUpdateEndpoint;

        private readonly gaxgrpc::ApiCall<DeleteEndpointRequest, wkt::Empty> _callDeleteEndpoint;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the RegistrationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegistrationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegistrationServiceClientImpl(RegistrationService.RegistrationServiceClient grpcClient, RegistrationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegistrationServiceSettings effectiveSettings = settings ?? RegistrationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateNamespace = clientHelper.BuildApiCall<CreateNamespaceRequest, Namespace>("CreateNamespace", grpcClient.CreateNamespaceAsync, grpcClient.CreateNamespace, effectiveSettings.CreateNamespaceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNamespace);
            Modify_CreateNamespaceApiCall(ref _callCreateNamespace);
            _callListNamespaces = clientHelper.BuildApiCall<ListNamespacesRequest, ListNamespacesResponse>("ListNamespaces", grpcClient.ListNamespacesAsync, grpcClient.ListNamespaces, effectiveSettings.ListNamespacesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNamespaces);
            Modify_ListNamespacesApiCall(ref _callListNamespaces);
            _callGetNamespace = clientHelper.BuildApiCall<GetNamespaceRequest, Namespace>("GetNamespace", grpcClient.GetNamespaceAsync, grpcClient.GetNamespace, effectiveSettings.GetNamespaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNamespace);
            Modify_GetNamespaceApiCall(ref _callGetNamespace);
            _callUpdateNamespace = clientHelper.BuildApiCall<UpdateNamespaceRequest, Namespace>("UpdateNamespace", grpcClient.UpdateNamespaceAsync, grpcClient.UpdateNamespace, effectiveSettings.UpdateNamespaceSettings).WithGoogleRequestParam("namespace.name", request => request.Namespace?.Name);
            Modify_ApiCall(ref _callUpdateNamespace);
            Modify_UpdateNamespaceApiCall(ref _callUpdateNamespace);
            _callDeleteNamespace = clientHelper.BuildApiCall<DeleteNamespaceRequest, wkt::Empty>("DeleteNamespace", grpcClient.DeleteNamespaceAsync, grpcClient.DeleteNamespace, effectiveSettings.DeleteNamespaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNamespace);
            Modify_DeleteNamespaceApiCall(ref _callDeleteNamespace);
            _callCreateService = clientHelper.BuildApiCall<CreateServiceRequest, Service>("CreateService", grpcClient.CreateServiceAsync, grpcClient.CreateService, effectiveSettings.CreateServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateService);
            Modify_CreateServiceApiCall(ref _callCreateService);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callUpdateService = clientHelper.BuildApiCall<UpdateServiceRequest, Service>("UpdateService", grpcClient.UpdateServiceAsync, grpcClient.UpdateService, effectiveSettings.UpdateServiceSettings).WithGoogleRequestParam("service.name", request => request.Service?.Name);
            Modify_ApiCall(ref _callUpdateService);
            Modify_UpdateServiceApiCall(ref _callUpdateService);
            _callDeleteService = clientHelper.BuildApiCall<DeleteServiceRequest, wkt::Empty>("DeleteService", grpcClient.DeleteServiceAsync, grpcClient.DeleteService, effectiveSettings.DeleteServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteService);
            Modify_DeleteServiceApiCall(ref _callDeleteService);
            _callCreateEndpoint = clientHelper.BuildApiCall<CreateEndpointRequest, Endpoint>("CreateEndpoint", grpcClient.CreateEndpointAsync, grpcClient.CreateEndpoint, effectiveSettings.CreateEndpointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEndpoint);
            Modify_CreateEndpointApiCall(ref _callCreateEndpoint);
            _callListEndpoints = clientHelper.BuildApiCall<ListEndpointsRequest, ListEndpointsResponse>("ListEndpoints", grpcClient.ListEndpointsAsync, grpcClient.ListEndpoints, effectiveSettings.ListEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEndpoints);
            Modify_ListEndpointsApiCall(ref _callListEndpoints);
            _callGetEndpoint = clientHelper.BuildApiCall<GetEndpointRequest, Endpoint>("GetEndpoint", grpcClient.GetEndpointAsync, grpcClient.GetEndpoint, effectiveSettings.GetEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEndpoint);
            Modify_GetEndpointApiCall(ref _callGetEndpoint);
            _callUpdateEndpoint = clientHelper.BuildApiCall<UpdateEndpointRequest, Endpoint>("UpdateEndpoint", grpcClient.UpdateEndpointAsync, grpcClient.UpdateEndpoint, effectiveSettings.UpdateEndpointSettings).WithGoogleRequestParam("endpoint.name", request => request.Endpoint?.Name);
            Modify_ApiCall(ref _callUpdateEndpoint);
            Modify_UpdateEndpointApiCall(ref _callUpdateEndpoint);
            _callDeleteEndpoint = clientHelper.BuildApiCall<DeleteEndpointRequest, wkt::Empty>("DeleteEndpoint", grpcClient.DeleteEndpointAsync, grpcClient.DeleteEndpoint, effectiveSettings.DeleteEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEndpoint);
            Modify_DeleteEndpointApiCall(ref _callDeleteEndpoint);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateNamespaceApiCall(ref gaxgrpc::ApiCall<CreateNamespaceRequest, Namespace> call);

        partial void Modify_ListNamespacesApiCall(ref gaxgrpc::ApiCall<ListNamespacesRequest, ListNamespacesResponse> call);

        partial void Modify_GetNamespaceApiCall(ref gaxgrpc::ApiCall<GetNamespaceRequest, Namespace> call);

        partial void Modify_UpdateNamespaceApiCall(ref gaxgrpc::ApiCall<UpdateNamespaceRequest, Namespace> call);

        partial void Modify_DeleteNamespaceApiCall(ref gaxgrpc::ApiCall<DeleteNamespaceRequest, wkt::Empty> call);

        partial void Modify_CreateServiceApiCall(ref gaxgrpc::ApiCall<CreateServiceRequest, Service> call);

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_UpdateServiceApiCall(ref gaxgrpc::ApiCall<UpdateServiceRequest, Service> call);

        partial void Modify_DeleteServiceApiCall(ref gaxgrpc::ApiCall<DeleteServiceRequest, wkt::Empty> call);

        partial void Modify_CreateEndpointApiCall(ref gaxgrpc::ApiCall<CreateEndpointRequest, Endpoint> call);

        partial void Modify_ListEndpointsApiCall(ref gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> call);

        partial void Modify_GetEndpointApiCall(ref gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> call);

        partial void Modify_UpdateEndpointApiCall(ref gaxgrpc::ApiCall<UpdateEndpointRequest, Endpoint> call);

        partial void Modify_DeleteEndpointApiCall(ref gaxgrpc::ApiCall<DeleteEndpointRequest, wkt::Empty> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(RegistrationService.RegistrationServiceClient grpcClient, RegistrationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegistrationService client</summary>
        public override RegistrationService.RegistrationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateNamespaceRequest(ref CreateNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNamespacesRequest(ref ListNamespacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNamespaceRequest(ref GetNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNamespaceRequest(ref UpdateNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNamespaceRequest(ref DeleteNamespaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceRequest(ref CreateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceRequest(ref UpdateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceRequest(ref DeleteServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEndpointRequest(ref CreateEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEndpointsRequest(ref ListEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEndpointRequest(ref GetEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEndpointRequest(ref UpdateEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEndpointRequest(ref DeleteEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Namespace CreateNamespace(CreateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNamespaceRequest(ref request, ref callSettings);
            return _callCreateNamespace.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a namespace, and returns the new namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Namespace> CreateNamespaceAsync(CreateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNamespaceRequest(ref request, ref callSettings);
            return _callCreateNamespace.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Namespace"/> resources.</returns>
        public override gax::PagedEnumerable<ListNamespacesResponse, Namespace> ListNamespaces(ListNamespacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNamespacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNamespacesRequest, ListNamespacesResponse, Namespace>(_callListNamespaces, request, callSettings);
        }

        /// <summary>
        /// Lists all namespaces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Namespace"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNamespacesResponse, Namespace> ListNamespacesAsync(ListNamespacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNamespacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNamespacesRequest, ListNamespacesResponse, Namespace>(_callListNamespaces, request, callSettings);
        }

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Namespace GetNamespace(GetNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNamespaceRequest(ref request, ref callSettings);
            return _callGetNamespace.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Namespace> GetNamespaceAsync(GetNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNamespaceRequest(ref request, ref callSettings);
            return _callGetNamespace.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Namespace UpdateNamespace(UpdateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNamespaceRequest(ref request, ref callSettings);
            return _callUpdateNamespace.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Namespace> UpdateNamespaceAsync(UpdateNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNamespaceRequest(ref request, ref callSettings);
            return _callUpdateNamespace.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteNamespace(DeleteNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNamespaceRequest(ref request, ref callSettings);
            _callDeleteNamespace.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a namespace. This also deletes all services and endpoints in
        /// the namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteNamespaceAsync(DeleteNamespaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNamespaceRequest(ref request, ref callSettings);
            return _callDeleteNamespace.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return _callCreateService.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a service, and returns the new service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return _callCreateService.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all services belonging to a namespace.
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
        /// Lists all services belonging to a namespace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Gets a service.
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
        /// Gets a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return _callUpdateService.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return _callUpdateService.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            _callDeleteService.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a service. This also deletes all endpoints associated with
        /// the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return _callDeleteService.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint CreateEndpoint(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointRequest(ref request, ref callSettings);
            return _callCreateEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an endpoint, and returns the new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> CreateEndpointAsync(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointRequest(ref request, ref callSettings);
            return _callCreateEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists all endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint UpdateEndpoint(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointRequest(ref request, ref callSettings);
            return _callUpdateEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> UpdateEndpointAsync(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointRequest(ref request, ref callSettings);
            return _callUpdateEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEndpoint(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointRequest(ref request, ref callSettings);
            _callDeleteEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEndpointAsync(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointRequest(ref request, ref callSettings);
            return _callDeleteEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM Policy for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Tests IAM permissions for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Tests IAM permissions for a resource (namespace or service only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListNamespacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEndpointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNamespacesResponse : gaxgrpc::IPageResponse<Namespace>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Namespace> GetEnumerator() => Namespaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEndpointsResponse : gaxgrpc::IPageResponse<Endpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Endpoint> GetEnumerator() => Endpoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RegistrationService
    {
        public partial class RegistrationServiceClient
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
